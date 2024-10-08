﻿
' Kaloripäeviku projekt "Janar"
' Põhiaken
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Imports System.Data.Entity.Core.Mapping
Imports System.Data.Entity.ModelConfiguration.Configuration.Properties
Imports System.Data.SQLite
Imports System.Drawing.Design
Imports System.Drawing.Text
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Security.Authentication.ExtendedProtection
Imports System.Windows.Forms.VisualStyles
Imports AnaluusiKomponent
Imports KasutajaProfiilKomponent
Imports ToidudRetseptidKomponent

Public Class Pohiaken

    Private _kasutajaId As Integer
    Private kalorilimiit As Integer
    Private kasutajaKaal As Double
    Private kaaluEesmark As Double
    Private kaaluEesmarkVahe As Double
    Private kaaluEesmarkAeg As Double
    Private TabelKaalud As Double()
    Private DateTabelKaalud As Integer()
    Private ajalooKuupaev As Integer
    Private valueMap As New Dictionary(Of String, Integer)()
    Dim kultuur As New CultureInfo("et-EE") ' eestikeelne formaat

    Dim retseptideKoostisosad As New List(Of Integer)
    Dim retseptideKoostisosadeKogused As New List(Of Integer)

    Dim retseptiKcal As Integer = 0
    Dim retseptiSusivesikud As Integer = 0
    Dim retseptiSuhkur As Integer = 0
    Dim retseptiValgud As Integer = 0
    Dim retseptiLipiidid As Integer = 0

    Dim ProfiilK As KasutajaProfiilKomponent.IKasutajaProfiil
    Dim AnaluusK As AnaluusiKomponent.IAnaluus
    Dim ToidudRetseptidK As ToidudRetseptidKomponent.IToidudjaRetseptid
    Dim TreeningudK As TreeninguteKomponent.ITreeningud
    Dim SalvestamineK As CSVExporterDNF.IExporter


    ' Funktsioon põhiakna laadimiseks
    Public Sub New(ByVal kasutajaId As Integer)
        InitializeComponent()
        _kasutajaId = kasutajaId
        Dim ProfiilK As New KasutajaProfiilKomponent.CKasutajaProfiil
        kalorilimiit = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "calorie_limit")
        kaaluEesmark = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight_goal")
    End Sub


    ' Funktsioon põhiakna algsätete taastamiseks
    Public Sub ResetForm()
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        AnaluusK = New AnaluusiKomponent.CAnaluus

        kasutajaKaal = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight")
        kaaluEesmark = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight_goal")
        kaaluEesmarkVahe = Math.Abs(kaaluEesmark - kasutajaKaal)
        kaaluEesmarkAeg = kaaluEesmarkVahe / 0.5

        ajalooKuupaev = AnaluusK.KuupaevIntegeriks(Date.Now.Date)
        lblAjaluguKuupaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
        lblAjaluguNadalaPaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev).ToString("ddd", kultuur) + ","

        If AnaluusK.PaevaseAndmereaParing(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date), "energy_intake") = -1 Then
            AnaluusK.TuhjaPaevaseAndmereaSisestus(_kasutajaId, ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight"), AnaluusK.KuupaevIntegeriks(Date.Now.Date))
        End If
        KaloriteLimiidiLeidmine()

        TuhjendaKonteiner(Me)
        pnlLogo.Visible = True
        pnlTopBar.Visible = True
        pnlLeftBar.Visible = True
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlKodu.Visible = True
        menuuNuppudeVaikeVarv()
        btnKodu.BackColor = Color.FromArgb(205, 234, 231)

        lblEesnimi.Text = ProfiilK.Dekrupteerimine(ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutajaId, "firstname"))
        lblKoduEesnimi.Text = lblEesnimi.Text & "!"
        lblProfiiliSeadedEesnimi.Text = lblEesnimi.Text
        lblProfiiliSeadedKasutajanimi.Text = ProfiilK.Dekrupteerimine(ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutajaId, "username"))
        lblKasutajaPikkus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "height") & "cm"

        lblKasutajaKaal.Text = kasutajaKaal & "kg"
        lblKaaluEesmark.Text = kaaluEesmark & "kg"
        lblKaaluEesmargiVahe.Text = kaaluEesmarkVahe & "kg"
        lblKaaluEesmargiAeg.Text = kaaluEesmarkAeg & "ndl"
        lblKasutajaVanus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "age") & "aastat"

        If ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "sex") = 0 Then
            pbUlemineMees.Visible = True
            pbAlumineMees.Visible = True
        ElseIf ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "sex") = 1 Then
            pbUlemineNaine.Visible = True
            pbAlumineNaine.Visible = True
        End If

        KomboKastid()
        KoduGraafik()

        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 7 päeva")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane kuu")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 3 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 6 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane aasta")
        cmbAjaluguGraafikuPeriood.SelectedIndex = 0

        YlevaateGraafik()
        AjalooAken()
    End Sub


    ' Funktsioon tekstiväljade ja kombokastide tühjendamiseks
    Private Sub TuhjendaKonteiner(ByVal parentControl As Control)
        For Each ctrl As Control In parentControl.Controls
            If TypeOf ctrl Is System.Windows.Forms.TextBox Then
                DirectCast(ctrl, System.Windows.Forms.TextBox).Text = ""
            ElseIf TypeOf ctrl Is System.Windows.Forms.ComboBox Then
                DirectCast(ctrl, System.Windows.Forms.ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is System.Windows.Forms.CheckBox Then
                DirectCast(ctrl, System.Windows.Forms.CheckBox).Checked = False
            ElseIf TypeOf ctrl Is System.Windows.Forms.RadioButton Then
                DirectCast(ctrl, System.Windows.Forms.RadioButton).Checked = False
            ElseIf TypeOf ctrl Is System.Windows.Forms.ListBox Then
                DirectCast(ctrl, System.Windows.Forms.ListBox).Items.Clear()
            ElseIf TypeOf ctrl Is Panel Then
                TuhjendaKonteiner(ctrl)
            End If
        Next
    End Sub


    ' Funktsioon kombokastide laadimiseks
    Private Sub KomboKastid()

        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid
        TreeningudK = New TreeninguteKomponent.CTreeningud
        AnaluusK = New AnaluusiKomponent.CAnaluus

        cmbMuudaVanust.Items.Clear()
        cmbMuudaPikkust.Items.Clear()
        cmbToiduaineKiirvalik.Items.Clear()
        cmbTreeninguteKiirvalik.Items.Clear()
        cmbRetseptiKoostisosad.Items.Clear()
        cmbTreeninguKustutamine.Items.Clear()
        cmbToiduaineKustutamine.Items.Clear()

        Dim mukbangFlag As Integer = 0

        If chbMukbangFilter.Checked Then
            mukbangFlag = 1
        Else
            mukbangFlag = 0
        End If

        Dim toiduaineteNimed As List(Of String) = ToidudRetseptidK.KiirlisamiseToiduaineNimed(mukbangFlag)
        Dim retseptideNimed As List(Of String) = ToidudRetseptidK.KiirlisamiseRetseptideNimed(mukbangFlag)
        Dim treeninguteNimed As List(Of String) = TreeningudK.KiirlisamiseTreeninguNimed

        For Each nimetus As String In toiduaineteNimed
            cmbToiduaineKiirvalik.Items.Add(nimetus)
            cmbToiduaineKustutamine.Items.Add(nimetus)
            cmbRetseptiKoostisosad.Items.Add(nimetus)
        Next
        For Each nimetus As String In retseptideNimed
            cmbToiduaineKiirvalik.Items.Add(nimetus)
            cmbToiduaineKustutamine.Items.Add(nimetus)
        Next
        cmbToiduaineKiirvalik.SelectedIndex = 0
        cmbRetseptiKoostisosad.SelectedIndex = 0
        cmbToiduaineKustutamine.SelectedIndex = 0

        For Each nimetus As String In treeninguteNimed
            cmbTreeninguteKiirvalik.Items.Add(nimetus)
            cmbTreeninguKustutamine.Items.Add(nimetus)
        Next
        cmbTreeninguKustutamine.SelectedIndex = 0
        cmbTreeninguteKiirvalik.SelectedIndex = 0

        For index = 140 To 210
            cmbMuudaPikkust.Items.Add(index)
        Next
        cmbMuudaPikkust.SelectedItem = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "height")

        For index = 12 To 100
            cmbMuudaVanust.Items.Add(index)
        Next
        cmbMuudaVanust.SelectedItem = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "age")

        AnaluusK.LisaValueMap("Viimased 7 päeva", 7, valueMap)
        AnaluusK.LisaValueMap("Viimane kuu", 30, valueMap)
        AnaluusK.LisaValueMap("Viimased 3 kuud", 91, valueMap)
        AnaluusK.LisaValueMap("Viimased 6 kuud", 182, valueMap)
        AnaluusK.LisaValueMap("Viimane aasta", 365, valueMap)
    End Sub


    ' Funktsioon kehakaalu ja sihtkaalu graafiku kuvamiseks
    Private Sub YlevaateGraafik()
        AnaluusK = New AnaluusiKomponent.CAnaluus
        TabelKaalud = AnaluusK.KaaluParingAndmebaasist(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date), AnaluusK.PariValueMap(cmbAjaluguGraafikuPeriood.SelectedItem, valueMap))
        DateTabelKaalud = AnaluusK.KaaluDateParingAndmebaasist(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date), AnaluusK.PariValueMap(cmbAjaluguGraafikuPeriood.SelectedItem, valueMap))

        chrKaaluMuutumine.Series("Kaal").Points.Clear()
        chrKaaluMuutumine.Series("Siht Kaal").Points.Clear()
        For muutuja As Integer = 0 To TabelKaalud.Length - 1 Step +1
            If muutuja > 0 AndAlso (DateTabelKaalud(muutuja - 1) + 1) < DateTabelKaalud(muutuja) Then
                DateTabelKaalud(muutuja - 1) = DateTabelKaalud(muutuja - 1) + 1
                chrKaaluMuutumine.Series("Kaal").Points.AddXY(AnaluusK.IntegerKuupaevaks(DateTabelKaalud(muutuja - 1)), TabelKaalud(muutuja - 1))
                chrKaaluMuutumine.Series("Siht Kaal").Points.AddXY(AnaluusK.IntegerKuupaevaks(DateTabelKaalud(muutuja - 1)), kaaluEesmark)
                muutuja -= 1
            Else
                If muutuja = TabelKaalud.Length - 1 AndAlso TabelKaalud(muutuja) = 0 Then
                    If muutuja - 1 >= 0 Then
                        chrKaaluMuutumine.Series("Kaal").Points.AddXY(AnaluusK.IntegerKuupaevaks(DateTabelKaalud(muutuja)), TabelKaalud(muutuja - 1))
                    End If

                Else
                    chrKaaluMuutumine.Series("Kaal").Points.AddXY(AnaluusK.IntegerKuupaevaks(DateTabelKaalud(muutuja)), TabelKaalud(muutuja))
                End If
                chrKaaluMuutumine.Series("Siht Kaal").Points.AddXY(AnaluusK.IntegerKuupaevaks(DateTabelKaalud(muutuja)), kaaluEesmark)
            End If
        Next
    End Sub


    ' Funktsioon söögikordade graafiku kuvamiseks
    Private Sub KoduGraafik()
        AnaluusK = New AnaluusiKomponent.CAnaluus

        chrKoduPaneel.Series("Soogikorrad").Points.Clear()
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Hommik", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutajaId, 0))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Lõuna", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutajaId, 1))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Õhtu", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutajaId, 3))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Vahepalad", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutajaId, 2))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Söömata", AnaluusK.PariKaloriUlejaak(AnaluusK.PaevaneKcal(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date)), kalorilimiit))
        lblKcalPaev.Text = AnaluusK.PaevaneKcal(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date)) & Environment.NewLine & "/" & Environment.NewLine & kalorilimiit & Environment.NewLine & "kcal"
    End Sub


    ' Funktsioon makroainete graafiku kuvamiseks
    Private Sub MakroGraafik()
        AnaluusK = New AnaluusiKomponent.CAnaluus

        chrAjalooPaneel.Series("Makrod").Points.Clear()
        chrAjalooPaneel.Series("Makrod").Points.AddXY("Süsivesikud", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutajaId, "total_c_hydrates"))
        chrAjalooPaneel.Series("Makrod").Points.AddXY("Suhkrud", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutajaId, "total_sugar"))
        chrAjalooPaneel.Series("Makrod").Points.AddXY("Valgud", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutajaId, "total_protein"))
        chrAjalooPaneel.Series("Makrod").Points.AddXY("Rasvad", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutajaId, "total_lipid"))
    End Sub


    ' Funktsioon, mis reageerib logo vajutusele
    Private Sub pnlLogo_Click(sender As Object, e As EventArgs) Handles pnlLogo.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = True
    End Sub


    Private Sub lnklblAleks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAleks.LinkClicked
        Process.Start("https://github.com/alaasmagi")
    End Sub


    Private Sub lnklblKris_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblKris.LinkClicked
        Process.Start("https://github.com/Kristoober")
    End Sub


    Private Sub lnklblCarmen_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblCarmen.LinkClicked
        Process.Start("https://github.com/CarmenRaun")
    End Sub


    Private Sub lnklblEeva_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblEeva.LinkClicked
        Process.Start("https://github.com/eetser")
    End Sub


    Private Sub lnklblMonster_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblMonster.LinkClicked
        Process.Start("https://i.pinimg.com/originals/54/e0/5d/54e05d64cfba06861544f94d5405802f.png")
    End Sub


    Private Sub lnklblBelief_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblBelief.LinkClicked
        Process.Start("https://www.beliefwater.com/wp-content/uploads/2021/05/BELIEF-FUNCTIONAL-WATER.png")
    End Sub


    Private Sub lnklblPaulig_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblPaulig.LinkClicked
        Process.Start("https://banner2.cleanpng.com/20180813/osa/kisspng-paulig-oy-logo-coffee-brand-amp-quot-amp-quot-29-5b72054d8dbfa3.3462457815341991175806.jpg")
    End Sub


    ' Funktsioon, mis reageerib väljalogimisnupu vajutusele
    Private Sub btnLogiValja_Click(sender As Object, e As EventArgs) Handles btnLogiValja.Click
        Me.Hide()
        Dim login_aken As New Login_aken()
        login_aken.Show()
        Me.Close()
    End Sub


    ' Funktsioon, mis reageerib toidulaua nupu vajutusele
    Private Sub btnToidulaud_Click(sender As Object, e As EventArgs) Handles btnToidulaud.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlToidulaud.Visible = True
        menuuNuppudeVaikeVarv()
        btnToidulaud.BackColor = Color.FromArgb(205, 234, 231)
    End Sub


    ' Funktsioon, mis reageerib treeningute nupu vajutusele
    Private Sub btnTreeningud_Click(sender As Object, e As EventArgs) Handles btnTreeningud.Click
        pnlYlevaade.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlTreeningud.Visible = True
        menuuNuppudeVaikeVarv()
        btnTreeningud.BackColor = Color.FromArgb(205, 234, 231)
    End Sub


    ' Funktsioon, mis reageerib ülevaate nupu vajutusele
    Private Sub btnYlevaade_Click(sender As Object, e As EventArgs) Handles btnYlevaade.Click
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlYlevaade.Visible = True
        menuuNuppudeVaikeVarv()
        btnYlevaade.BackColor = Color.FromArgb(205, 234, 231)
    End Sub


    ' Funktsioon, mis reageerib ajaloo nupu vajutusele
    Private Sub btnAjalugu_Click(sender As Object, e As EventArgs) Handles btnAjalugu.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlAjalugu.Visible = True
        MakroGraafik()
        menuuNuppudeVaikeVarv()
        btnAjalugu.BackColor = Color.FromArgb(205, 234, 231)
    End Sub


    ' Funktsioon, mis reageerib profiili seadete nupu vajutusele
    Private Sub btnProfiiliSeaded_Click(sender As Object, e As EventArgs) Handles btnProfiiliSeaded.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlProfiiliSeaded.Visible = True
        menuuNuppudeVaikeVarv()
        btnProfiiliSeaded.BackColor = Color.FromArgb(205, 234, 231)

        kasutajaKaal = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight")
        kaaluEesmark = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight_goal")
        kaaluEesmarkVahe = Math.Abs(kaaluEesmark - kasutajaKaal)
        kaaluEesmarkAeg = kaaluEesmarkVahe / 0.5

        lblKasutajaKaal.Text = kasutajaKaal & "kg"
        lblKaaluEesmark.Text = kaaluEesmark & "kg"
        lblKaaluEesmargiVahe.Text = kaaluEesmarkVahe & "kg"
        lblKaaluEesmargiAeg.Text = kaaluEesmarkAeg & "ndl"

        If kasutajaKaal > kaaluEesmark Then
            lblProfiilKehakaaluLangus.Visible = True
            lblProfiilKehakaaluTõstmine.Visible = False
            lblProfiilKehakaalSama.Visible = False
        ElseIf kasutajaKaal < kaaluEesmark Then
            lblProfiilKehakaaluLangus.Visible = False
            lblProfiilKehakaaluTõstmine.Visible = True
            lblProfiilKehakaalSama.Visible = False
        Else
            lblProfiilKehakaaluLangus.Visible = False
            lblProfiilKehakaaluTõstmine.Visible = False
            lblProfiilKehakaalSama.Visible = True
        End If
    End Sub


    ' Funktsioon, mis reageerib kodu nupu vajutusele
    Private Sub btnKodu_Click(sender As Object, e As EventArgs) Handles btnKodu.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlKodu.Visible = True
        menuuNuppudeVaikeVarv()
        btnKodu.BackColor = Color.FromArgb(205, 234, 231)
    End Sub


    ' Funktsioon, mis reageerib vanuse muutmise nupu vajutusele
    Private Sub btnMuudaVanust_Click(sender As Object, e As EventArgs) Handles btnMuudaVanust.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutajaId, cmbMuudaVanust.SelectedItem, "age")
        lblKasutajaVanus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "age") & "aastat"
        pbVanuseMuutmineOnnestus.Visible = True
        Timer2s.Start()
        KaloriteLimiidiLeidmine()
        KomboKastid()
    End Sub


    ' Funktsioon, mis reageerib pikkuse muutmise nupu vajutusele
    Private Sub btnMuudaPikkust_Click(sender As Object, e As EventArgs) Handles btnMuudaPikkust.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutajaId, cmbMuudaPikkust.SelectedItem, "height")
        lblKasutajaPikkus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "height") & "cm"
        pbPikkuseMuutmineOnnestus.Visible = True
        Timer2s.Start()
        KaloriteLimiidiLeidmine()
        KomboKastid()
    End Sub


    ' Funktsioon, mis reageerib uue salasõna kinnitamise nupu vajutusele
    Private Sub btnKinnitaUusSalasona_Click(sender As Object, e As EventArgs) Handles btnKinnitaUusSalasona.Click
        lblVahetaSalasonaViga.Visible = False
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        If (ProfiilK.ArvutaHash(txtKehtivSalasona.Text) = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutajaId, "password")) Then
            If Len(txtVahetaSalasona.Text) < 8 Then
                txtVahetaSalasona.Text = ""
                lblVahetaSalasonaViga.Text = "Salasõna pikkus peab olema vähemalt 8 tähemärki!"
                lblVahetaSalasonaViga.Visible = True
            ElseIf txtVahetaSalasona.Text <> txtKordaSalasona.Text Then
                txtKordaSalasona.Text = ""
                lblVahetaSalasonaViga.Text = "Salasõnad ei ühti!"
                lblVahetaSalasonaViga.Visible = True
            ElseIf ProfiilK.ArvutaHash(txtVahetaSalasona.Text) = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutajaId, "password") OrElse
                    ProfiilK.ArvutaHash(txtKordaSalasona.Text) = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutajaId, "password") Then
                lblVahetaSalasonaViga.Text = "Salasõna juba kasutusel!"
                lblVahetaSalasonaViga.Visible = True
            Else
                ProfiilK.VahetaSalasona(_kasutajaId, txtVahetaSalasona.Text)
                txtKehtivSalasona.Text = ""
                txtKordaSalasona.Text = ""
                txtVahetaSalasona.Text = ""
                pbSalasonaVahetusOnnestus.Visible = True
                Timer2s.Start()
            End If
        Else
            txtKehtivSalasona.Text = ""
            lblVahetaSalasonaViga.Text = "Kehtiv salasõna on vale!"
            lblVahetaSalasonaViga.Visible = True
        End If
    End Sub


    ' Funktsioon, mis reageerib uue toiduaine lisamise nupu vajutusele
    Private Sub btnLisaUusToiduaine_Click(sender As Object, e As EventArgs) Handles btnLisaUusToiduaine.Click
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid

        If txtUueToiduaineNimi.Text = "" Then
            lblUueToiduaineLisamineViga.Text = "Nime lahter on tühi!"
            lblUueToiduaineLisamineViga.Visible = True
        Else
            If IsNumeric(txtUueToiduaineKcal.Text) AndAlso IsNumeric(txtUueToiduaineSusivesikud.Text) AndAlso IsNumeric(txtUueToiduaineSuhkrud.Text) AndAlso
               IsNumeric(txtUueToiduaineRasvad.Text) AndAlso IsNumeric(txtUueToiduaineValgud.Text) Then
                If ToidudRetseptidK.ToiduAineNimiEksisteerib(txtUueToiduaineNimi.Text) > 0 Then
                    lblUueToiduaineLisamineViga.Text = "Viga toiduaine lisamisel!"
                    lblUueToiduaineLisamineViga.Visible = True
                Else
                    lblUueToiduaineLisamineViga.Visible = False
                    ToidudRetseptidK.LisaToiduaine(txtUueToiduaineNimi.Text, txtUueToiduaineKcal.Text, txtUueToiduaineValgud.Text, txtUueToiduaineSusivesikud.Text,
                                          txtUueToiduaineRasvad.Text, txtUueToiduaineSuhkrud.Text)
                    txtUueToiduaineNimi.Text = ""
                    txtUueToiduaineKcal.Text = ""
                    txtUueToiduaineSusivesikud.Text = ""
                    txtUueToiduaineSuhkrud.Text = ""
                    txtUueToiduaineValgud.Text = ""
                    txtUueToiduaineRasvad.Text = ""
                    pbToiduaineLoomineOnnestus.Visible = True
                    Timer2s.Start()
                End If
            Else
                lblUueToiduaineLisamineViga.Text = "Viga toiduaine lisamisel!"
                lblUueToiduaineLisamineViga.Visible = True
            End If
            KomboKastid()
        End If
    End Sub


    ' Funktsioon, mis reageerib toidu kiirvaliku lisamise nupu vajutusele
    Private Sub btnToiduaineKiirvalikLisa_Click(sender As Object, e As EventArgs) Handles btnToiduaineKiirvalikLisa.Click
        Dim toidukord As Integer = 0
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid
        AnaluusK = New AnaluusiKomponent.CAnaluus

        If rdbHommik.Checked = True Then
            toidukord = 0
        ElseIf rdbLouna.Checked = True Then
            toidukord = 1
        ElseIf rdbVahepala.Checked = True Then
            toidukord = 2
        ElseIf rdbOhtu.Checked = True Then
            toidukord = 3
        Else
            lblToiduAineRetseptiLisamineViga.Text = "Toidukorda pole valitud!"
            lblToiduAineRetseptiLisamineViga.Visible = True
        End If
        If IsNumeric(txtToiduaineKiirvalikKogus.Text) AndAlso txtToiduaineKiirvalikKogus.Text > 0 Then
            If ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem) > 0 Then
                ToidudRetseptidK.KasutajaToiduaineVõiRetseptiLisamine(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date), toidukord, ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem), txtToiduaineKiirvalikKogus.Text)
            ElseIf ToidudRetseptidK.RetseptiNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem) > 0 Then
                ToidudRetseptidK.KasutajaToiduaineVõiRetseptiLisamine(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date), toidukord, ToidudRetseptidK.RetseptiNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem), txtToiduaineKiirvalikKogus.Text)
            End If
            lblToiduAineRetseptiLisamineViga.Visible = False
            txtToiduaineKiirvalikKogus.Text = ""
            pbToidukorraLisamineOnnestus.Visible = True
            Timer2s.Start()
        Else
            lblToiduAineRetseptiLisamineViga.Text = "Viga koguse sisestuses!"
            lblToiduAineRetseptiLisamineViga.Visible = True
        End If
        AjalooInfo()
        KoduGraafik()
    End Sub


    ' Funktsioon, mis seab menüünuppudele taustaks programmi vaikeväärtuse
    Private Sub menuuNuppudeVaikeVarv()
        btnToidulaud.BackColor = Color.FromArgb(188, 227, 224)
        btnTreeningud.BackColor = Color.FromArgb(188, 227, 224)
        btnYlevaade.BackColor = Color.FromArgb(188, 227, 224)
        btnAjalugu.BackColor = Color.FromArgb(188, 227, 224)
        btnKodu.BackColor = Color.FromArgb(188, 227, 224)
        btnProfiiliSeaded.BackColor = Color.FromArgb(188, 227, 224)
    End Sub


    ' Funktsioon, mis reageerib treeningsessiooni lisamise nupu vajutusele
    Private Sub btnTreeninguKiirvalikLisa_Click(sender As Object, e As EventArgs) Handles btnTreeninguKiirvalikLisa.Click
        TreeningudK = New TreeninguteKomponent.CTreeningud
        AnaluusK = New AnaluusiKomponent.CAnaluus

        If IsNumeric(txtTreeninguKiirvalikKestus.Text) AndAlso txtTreeninguKiirvalikKestus.Text > 0 Then
            lblTreeninguKiirvalikViga.Visible = False
            TreeningudK.KasutajaTreeninguLisamine(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date), TreeningudK.TreeninguNimiEksisteerib(cmbTreeninguteKiirvalik.SelectedItem()), txtTreeninguKiirvalikKestus.Text)
            AnaluusK.PaevaneKcal(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date))
            txtTreeninguKiirvalikKestus.Text = ""
            pbTreeningsessiooniLisamineOnnestus.Visible = True
            Timer2s.Start()
        Else
            lblTreeninguKiirvalikViga.Text = "Viga kestuse sisestuses!"
            lblTreeninguKiirvalikViga.Visible = True
        End If
        AjalooInfo()
    End Sub


    ' Funktsioon, mis reageerib treeningu lisamise nupu vajutusele
    Private Sub btnTreeninguLisamine_Click(sender As Object, e As EventArgs) Handles btnTreeninguLisamine.Click
        TreeningudK = New TreeninguteKomponent.CTreeningud
        If txtTreeninguLisamineNimi.Text = "" Then
            lblTreeninguLisamineViga.Text = "Nime lahter tühi!"
            lblTreeninguLisamineViga.Visible = True
        Else
            If IsNumeric(txtTreeninguLisamineEnergialkulu.Text) AndAlso txtTreeninguLisamineEnergialkulu.Text > 0 Then
                If TreeningudK.TreeninguNimiEksisteerib(txtTreeninguLisamineNimi.Text) > 0 Then
                    lblTreeninguLisamineViga.Text = "Treening on juba andmebaasis!"
                    txtTreeninguLisamineNimi.Text = ""
                    txtTreeninguLisamineEnergialkulu.Text = ""
                    lblTreeninguLisamineViga.Visible = True
                Else
                    lblTreeninguLisamineViga.Visible = False
                    TreeningudK.LisaTreening(txtTreeninguLisamineNimi.Text, txtTreeninguLisamineEnergialkulu.Text)
                    txtTreeninguLisamineNimi.Text = ""
                    txtTreeninguLisamineEnergialkulu.Text = ""
                    pbTreeninguLisamineOnnestus.Visible = True
                    Timer2s.Start()
                End If
            Else
                lblTreeninguLisamineViga.Text = "Viga energiakulu sisestuses!"
                lblTreeninguLisamineViga.Visible = True
            End If
        End If
        KomboKastid()
    End Sub


    ' Funktsioon, mis reageerib retsepti koostisosa lisamise nupu vajutusele
    Private Sub btnRetseptLisaKoostisosa_Click(sender As Object, e As EventArgs) Handles btnRetseptLisaKoostisosa.Click
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid
        AnaluusK = New AnaluusiKomponent.CAnaluus

        If IsNumeric(txtRetseptiKoostisosaKogus.Text) AndAlso txtRetseptiKoostisosaKogus.Text > 0 Then
            retseptiKcal = retseptiKcal + AnaluusK.RetseptiToiduaineToitevaartuseArvutus(ToidudRetseptidK.ToiteVaartuseParing(ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbRetseptiKoostisosad.SelectedItem), "energy", 0), txtRetseptiKoostisosaKogus.Text)
            retseptiSusivesikud = retseptiSusivesikud + AnaluusK.RetseptiToiduaineToitevaartuseArvutus(ToidudRetseptidK.ToiteVaartuseParing(ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbRetseptiKoostisosad.SelectedItem), "c_hydrates", 0), txtRetseptiKoostisosaKogus.Text)
            retseptiSuhkur = retseptiSuhkur + AnaluusK.RetseptiToiduaineToitevaartuseArvutus(ToidudRetseptidK.ToiteVaartuseParing(ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbRetseptiKoostisosad.SelectedItem), "sugar", 0), txtRetseptiKoostisosaKogus.Text)
            retseptiValgud = retseptiValgud + AnaluusK.RetseptiToiduaineToitevaartuseArvutus(ToidudRetseptidK.ToiteVaartuseParing(ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbRetseptiKoostisosad.SelectedItem), "protein", 0), txtRetseptiKoostisosaKogus.Text)
            retseptiLipiidid = retseptiLipiidid + AnaluusK.RetseptiToiduaineToitevaartuseArvutus(ToidudRetseptidK.ToiteVaartuseParing(ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbRetseptiKoostisosad.SelectedItem), "lipid", 0), txtRetseptiKoostisosaKogus.Text)
            lbRetseptiKoostisosad.Items.Add(cmbRetseptiKoostisosad.SelectedItem)
            retseptideKoostisosad.Add(ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbRetseptiKoostisosad.SelectedItem.ToString()))
            retseptideKoostisosadeKogused.Add(txtRetseptiKoostisosaKogus.Text)
            txtRetseptiKoostisosaKogus.Text = ""
            lblRetseptiLisamineViga.Visible = False
        Else
            lblRetseptiLisamineViga.Text = "Viga koostisosa koguses!"
            lblRetseptiLisamineViga.Visible = True
        End If
        KomboKastid()
    End Sub


    ' Funktsioon, mis reageerib retsepti kinnitamise nupu vajutusele
    Private Sub btnKinnitaRetsept_Click(sender As Object, e As EventArgs) Handles btnKinnitaRetsept.Click
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid
        If txtRetseptiNimi.Text = "" Then
            lblRetseptiLisamineViga.Text = "Nime lahter tühi!"
            lblRetseptiLisamineViga.Visible = True
        Else
            If ToidudRetseptidK.RetseptiNimiEksisteerib(txtRetseptiNimi.Text) > 0 Then
                lblRetseptiLisamineViga.Text = "Retsept on juba andmebaasis!"
                lblRetseptiLisamineViga.Visible = True
            Else
                If lbRetseptiKoostisosad.Items.Count = 0 Then
                    lblRetseptiLisamineViga.Text = "Toiduained puuduvad!"
                    lblRetseptiLisamineViga.Visible = True
                Else
                    lblRetseptiLisamineViga.Visible = False
                    Dim retsepti_id = ToidudRetseptidK.LisaRetsept(txtRetseptiNimi.Text, retseptiKcal, retseptiSusivesikud, retseptiSuhkur, retseptiValgud, retseptiLipiidid)
                    retseptiKcal = 0
                    retseptiSusivesikud = 0
                    retseptiSuhkur = 0
                    retseptiValgud = 0
                    retseptiLipiidid = 0
                    txtRetseptiNimi.Text = ""
                    pbRetseptiLoomineOnnestus.Visible = True
                    Timer2s.Start()
                    For i As Integer = 0 To retseptideKoostisosad.Count - 1
                        Dim koostisosa As String = retseptideKoostisosad(i)
                        Dim kogus As String = retseptideKoostisosadeKogused(i)

                        ToidudRetseptidK.LisaRetseptiKoostisosadeTabelisse(retsepti_id, koostisosa, kogus)
                    Next
                    retseptideKoostisosad.Clear()
                    retseptideKoostisosadeKogused.Clear()
                    lbRetseptiKoostisosad.Items.Clear()
                End If
            End If
        End If
        KomboKastid()
    End Sub


    ' Funktsioon, mis reageerib treeningu kustutamise nupu vajutusele
    Private Sub btnKustutaTreening_Click(sender As Object, e As EventArgs) Handles btnKustutaTreening.Click
        TreeningudK = New TreeninguteKomponent.CTreeningud

        Dim treeningu_id = TreeningudK.TreeninguNimiEksisteerib(cmbTreeninguKustutamine.SelectedItem)
        If treeningu_id < 4006 Then
            lblKustutaTreeningViga.Text = "Baastreeningut ei saa kustutada!"
            lblKustutaTreeningViga.Visible = True
        Else
            If TreeningudK.KustutaTreening(TreeningudK.TreeninguNimiEksisteerib(cmbTreeninguKustutamine.SelectedItem)) = 0 Then
                lblKustutaTreeningViga.Text = "Treeningu kustutamine ebaõnnestus!"
                lblKustutaTreeningViga.Visible = True
            Else
                lblKustutaTreeningViga.Visible = False
                pbTreeninguKustutamineOnnestus.Visible = True
                Timer2s.Start()
                KomboKastid()
            End If
        End If
    End Sub


    ' Funktsioon, mis reageerib päevase kehakaalu lisamise nupu vajutusele
    Private Sub btnPaevaneKaal_Click(sender As Object, e As EventArgs) Handles btnPaevaneKaal.Click
        AnaluusK = New AnaluusiKomponent.CAnaluus
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil

        If IsNumeric(txtPaevaneKaal.Text) AndAlso txtPaevaneKaal.Text > 0 Then
            lblPaevaseKehakaaluLisamineViga.Visible = False
            AnaluusK.KaaluLisamine(_kasutajaId, txtPaevaneKaal.Text)
            ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutajaId, txtPaevaneKaal.Text, "weight")
            lblKasutajaKaal.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight")
            KomboKastid()
            YlevaateGraafik()
            txtPaevaneKaal.Text = ""
            pbKehakaaluLisamineOnnestus.Visible = True
            Timer2s.Start()
        Else
            lblPaevaseKehakaaluLisamineViga.Text = "Ebakorrektne sisestus!"
            lblPaevaseKehakaaluLisamineViga.Visible = True
        End If
        KaloriteLimiidiLeidmine()
    End Sub


    ' Funktsioon, mis reageerib ülevaate näitamise nupu vajutusele
    Private Sub btnNaitaYlevaadet_Click(sender As Object, e As EventArgs) Handles btnNaitaYlevaadet.Click
        YlevaateGraafik()
    End Sub


    ' Funktsioon kalorilimiidi leidmiseks
    Private Sub KaloriteLimiidiLeidmine()
        kalorilimiit = AnaluusK.DBParingBMR(_kasutajaId, ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "sex"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "age"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "weight_goal"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutajaId, "height"), AnaluusK.KuupaevIntegeriks(Date.Now.Date))

        If kalorilimiit < 1000 Then
            lblSulOnProbleem.Visible = True
            lblKaloriLimiit.Visible = False
            kalorilimiit = 1000
        Else
            lblKaloriLimiit.Text = kalorilimiit & "kcal"
            lblSulOnProbleem.Visible = False
            lblKaloriLimiit.Visible = True
        End If
        KoduGraafik()
    End Sub


    ' Funktsioon, mis reageerib eesmärgi kinnitamise nupu vajutusele
    Private Sub btnEesmargiKinnitamine_Click(sender As Object, e As EventArgs) Handles btnEesmargiKinnitamine.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        If IsNumeric(txtKaaluEesmärk.Text) AndAlso txtKaaluEesmärk.Text > 0 Then
            lblKaaluEesmargiSeadmineViga.Visible = False
            ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutajaId, txtKaaluEesmärk.Text, "weight_goal")
            kaaluEesmark = txtKaaluEesmärk.Text
            YlevaateGraafik()
            txtKaaluEesmärk.Text = ""
            pbKaaluEesmarkOnnestus.Visible = True
            Timer2s.Start()
        Else
            lblKaaluEesmargiSeadmineViga.Text = "Ebakorrektne sisestus!"
            lblKaaluEesmargiSeadmineViga.Visible = True
        End If
        KaloriteLimiidiLeidmine()
    End Sub


    ' Funktsioon, mis reageerib toiduaine kustutamise nupu vajutusele
    Private Sub btnToiduaineKustutamine_Click(sender As Object, e As EventArgs) Handles btnToiduaineKustutamine.Click
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid

        Dim toiduaine_retsepti_id As Integer?
        toiduaine_retsepti_id = ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbToiduaineKustutamine.SelectedItem)

        If toiduaine_retsepti_id = 0 Then
            lblToiduaineKustutamineViga.Visible = False
            toiduaine_retsepti_id = ToidudRetseptidK.RetseptiNimiEksisteerib(cmbToiduaineKustutamine.SelectedItem)
            ToidudRetseptidK.ToiduaineVoiRetseptiKustutamine(toiduaine_retsepti_id, 0)
            pbRetseptiKustutamineOnnestus.Visible = True
            Timer2s.Start()
            KomboKastid()
        ElseIf toiduaine_retsepti_id < 2006 Then
            lblToiduaineKustutamineViga.Text = "Baastoiduainet ei saa kustutada!"
            lblToiduaineKustutamineViga.Visible = True
        Else

            lblToiduaineKustutamineViga.Visible = False
            ToidudRetseptidK.ToiduaineVoiRetseptiKustutamine(toiduaine_retsepti_id, 1)
            pbRetseptiKustutamineOnnestus.Visible = True
            Timer2s.Start()
            KomboKastid()
        End If
    End Sub


    ' Funktsioon, mis reageerib mukbang linnukese muutusele
    Private Sub chbMukbangFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chbMukbangFilter.CheckedChanged
        KomboKastid()
    End Sub


    ' Funktsioon ajaloo info kuvamiseks kindlal kuupäeval
    Private Sub AjalooInfo()
        AnaluusK = New AnaluusiKomponent.CAnaluus
        TreeningudK = New TreeninguteKomponent.CTreeningud
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid

        lvPaevasedToidud.Items.Clear()
        lvPaevasedTreeningud.Items.Clear()

        Dim paevasteToitudeId As Double() = AnaluusK.PaevasedToidud(_kasutajaId, ajalooKuupaev, "food_id")
        Dim paevasteToitudeKcal As Double() = AnaluusK.PaevasedToidud(_kasutajaId, ajalooKuupaev, "energy_intake")
        Dim paevasteToitudeToidukord As Double() = AnaluusK.PaevasedToidud(_kasutajaId, ajalooKuupaev, "time_of_meal")

        If AnaluusK.PaevaseAndmereaParing(_kasutajaId, ajalooKuupaev, "daily_weight") > 0 Then
            lblAjaluguKehakaal.Text = AnaluusK.PaevaseAndmereaParing(_kasutajaId, ajalooKuupaev, "daily_weight") & "kg"
            lblAjaluguVordlusTanasega.Text = AnaluusK.PaevaseAndmereaParing(_kasutajaId, ajalooKuupaev, "daily_weight") - AnaluusK.PaevaseAndmereaParing(_kasutajaId, AnaluusK.KuupaevIntegeriks(Date.Now.Date), "daily_weight") & "kg"
            lblAjaluguSoodudKalorid.Text = AnaluusK.PaevaseAndmereaParing(_kasutajaId, ajalooKuupaev, "energy_intake") & "kcal"
            lblAjaluguKulutatudKalorid.Text = AnaluusK.PaevaseAndmereaParing(_kasutajaId, ajalooKuupaev, "energy_consumption") & "kcal"
        Else
            lblAjaluguKehakaal.Text = "0"
            lblAjaluguVordlusTanasega.Text = "0"
            lblAjaluguSoodudKalorid.Text = "0"
            lblAjaluguKulutatudKalorid.Text = "0"
        End If

        For index_ = 0 To paevasteToitudeId.Count - 1
            If paevasteToitudeId(index_) < 3000 Then
                Select Case (paevasteToitudeToidukord(index_))
                    Case 0
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Hommik", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 0), paevasteToitudeKcal(index_) & "kcal"}))
                    Case 1
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Lõuna", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 0), paevasteToitudeKcal(index_) & "kcal"}))
                    Case 2
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Vahepala", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 0), paevasteToitudeKcal(index_) & "kcal"}))
                    Case 3
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Õhtu", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 0), paevasteToitudeKcal(index_) & "kcal"}))
                End Select
            Else
                Select Case (paevasteToitudeToidukord(index_))
                    Case 0
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Hommik", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 1), paevasteToitudeKcal(index_) & "kcal"}))
                    Case 1
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Lõuna", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 1), paevasteToitudeKcal(index_) & "kcal"}))
                    Case 2
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Vahepala", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 1), paevasteToitudeKcal(index_) & "kcal"}))
                    Case 3
                        lvPaevasedToidud.Items.Add(New ListViewItem({"Õhtu", ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(index_), 1), paevasteToitudeKcal(index_) & "kcal"}))
                End Select
            End If
        Next
        Dim paevasteTreeninguteId As Double() = AnaluusK.PaevasedTreeningud(_kasutajaId, ajalooKuupaev, "training_id")
        Dim paevasteTreeninguteKcal As Double() = AnaluusK.PaevasedTreeningud(_kasutajaId, ajalooKuupaev, "total_consumption")
        Dim paevasteTreeninguteKestus As Double() = AnaluusK.PaevasedTreeningud(_kasutajaId, ajalooKuupaev, "duration")

        For index = 0 To paevasteTreeninguteId.Count - 1
            lvPaevasedTreeningud.Items.Add(New ListViewItem({TreeningudK.TreeninguNimeLeidmine(paevasteTreeninguteId(index)), paevasteTreeninguteKcal(index) & "kcal", paevasteTreeninguteKestus(index) & "min"}))
        Next
    End Sub


    ' Funktsioon, mis reageerib ajaloo kuupäeva edasiliikumise nupu vajutusele
    Private Sub bntAjalooKuupaevEdasi_Click(sender As Object, e As EventArgs) Handles bntAjalooKuupaevEdasi.Click
        AnaluusK = New AnaluusiKomponent.CAnaluus
        If ajalooKuupaev < AnaluusK.KuupaevIntegeriks(Date.Now.Date) Then
            ajalooKuupaev = ajalooKuupaev + 1
            calAjalugu.SelectionEnd = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
            AjalooAken()
        End If
    End Sub


    ' Funktsioon, mis reageerib ajaloo kuupäeva tagasiliikumise nupu vajutusele
    Private Sub btnAjalooKuupaevTagasi_Click(sender As Object, e As EventArgs) Handles btnAjalooKuupaevTagasi.Click
        AnaluusK = New AnaluusiKomponent.CAnaluus
        ajalooKuupaev = ajalooKuupaev - 1
        calAjalugu.SelectionEnd = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
        AjalooAken()
    End Sub


    ' Funktsioon, mis haldab ajaloo infot
    Private Sub AjalooAken()
        AnaluusK = New AnaluusiKomponent.CAnaluus
        lblAjaluguKuupaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
        lblAjaluguNadalaPaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev).ToString("ddd", kultuur) + ","

        AjalooInfo()
        MakroGraafik()
    End Sub


    ' Funktsioon, mis taimeri aja otsalõppedes lülitab lülitab rohelised linnukesed välja
    Private Sub Timer2s_Tick(sender As Object, e As EventArgs) Handles Timer2s.Tick
        Timer2s.Stop()
        pbRetseptiLoomineOnnestus.Visible = False
        pbRetseptiKustutamineOnnestus.Visible = False
        pbToiduaineLoomineOnnestus.Visible = False
        pbTreeninguLisamineOnnestus.Visible = False
        pbTreeninguKustutamineOnnestus.Visible = False
        pbPikkuseMuutmineOnnestus.Visible = False
        pbVanuseMuutmineOnnestus.Visible = False
        pbSalasonaVahetusOnnestus.Visible = False
        pbToidukorraLisamineOnnestus.Visible = False
        pbTreeningsessiooniLisamineOnnestus.Visible = False
        pbKehakaaluLisamineOnnestus.Visible = False
        pbKaaluEesmarkOnnestus.Visible = False
        pbAjalooValjavoteOnnestus.Visible = False
    End Sub


    Private Sub lblValiKuupaevKalendrist_Click(sender As Object, e As EventArgs) Handles lblValiKuupaevKalendrist.Click
        calAjalugu.Visible = True
    End Sub


    ' Funktsioon, mis reageerib ajaloo kuupäeva kalendri valiku valimisele
    Private Sub calAjalugu_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calAjalugu.DateSelected
        AnaluusK = New AnaluusiKomponent.CAnaluus
        ajalooKuupaev = AnaluusK.KuupaevIntegeriks(calAjalugu.SelectionEnd)
        If ajalooKuupaev > AnaluusK.KuupaevIntegeriks(Date.Now.Date) Then
            calAjalugu.SelectionEnd = Date.Now.Date
            ajalooKuupaev = AnaluusK.KuupaevIntegeriks(Date.Now.Date)
        End If
        calAjalugu.Visible = False
        AjalooAken()
        MakroGraafik()
    End Sub


    Private Sub pnlAjalugu_Click(sender As Object, e As EventArgs) Handles pnlAjalugu.Click
        calAjalugu.Visible = False
    End Sub


    ' Funktsioon, mis reageerib ajaloo väljavõtte nupu vajutusele
    Private Sub btnAjalooValjavote_Click(sender As Object, e As EventArgs) Handles btnAjalooValjavote.Click
        SalvestamineK = New CSVExporterDNF.CExporter
        AnaluusK = New AnaluusiKomponent.CAnaluus
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid
        TreeningudK = New TreeninguteKomponent.CTreeningud

        SalvestamineK.delimiter = "     "

        Dim failiAsukoht As String = SalvestamineK.setFileToSave()
        lblFailiAsukoht.Text = failiAsukoht
        lblFailiAsukoht.Visible = True

        Dim paevasedToidud As New List(Of String())()
        Dim paevasedTreeningud As New List(Of String())()

        paevasedToidud.Add(New String(2) {})
        paevasedTreeningud.Add(New String(2) {})

        Dim paevasteToitudeId As Double() = AnaluusK.PaevasedToidud(_kasutajaId, ajalooKuupaev, "food_id")
        Dim paevasteToitudeKcal As Double() = AnaluusK.PaevasedToidud(_kasutajaId, ajalooKuupaev, "energy_intake")

        Dim paevasteTreeninguteId As Double() = AnaluusK.PaevasedTreeningud(_kasutajaId, ajalooKuupaev, "training_id")
        Dim paevasteTreeninguteKcal As Double() = AnaluusK.PaevasedTreeningud(_kasutajaId, ajalooKuupaev, "total_consumption")

        paevasedToidud(0)(0) = "Kuupäev:"
        paevasedToidud(0)(1) = "Toit:"
        paevasedToidud(0)(2) = "Kalorid:"

        For toit = 0 To paevasteToitudeId.Count - 1
            Dim toiduRida(2) As String
            toiduRida(0) = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
            If paevasteToitudeId(toit) < 3000 Then
                toiduRida(1) = ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(toit), 0)
            Else
                toiduRida(1) = ToidudRetseptidK.ToiduaineVoiRetseptiNimi(paevasteToitudeId(toit), 1)
            End If
            toiduRida(2) = paevasteToitudeKcal(toit) & "kcal"
            paevasedToidud.Add(toiduRida)
        Next

        paevasedTreeningud(0)(0) = "Kuupäev:"
        paevasedTreeningud(0)(1) = "Treeningu liik:"
        paevasedTreeningud(0)(2) = "Kulutatud kalorid:"

        For treening = 0 To paevasteTreeninguteId.Count - 1
            Dim treeninguRida(2) As String
            treeninguRida(0) = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
            treeninguRida(1) = TreeningudK.TreeninguNimeLeidmine(paevasteTreeninguteId(treening))
            treeninguRida(2) = paevasteTreeninguteKcal(treening) & "kcal"
            paevasedTreeningud.Add(treeninguRida)
        Next

        Dim paevasedToidudMassiiv As String(,) = New String(paevasedToidud.Count - 1, 2) {}
        For i = 0 To paevasedToidud.Count - 1
            For j = 0 To paevasedToidud(i).Length - 1
                paevasedToidudMassiiv(i, j) = paevasedToidud(i)(j)
            Next
        Next

        Dim paevasedTreeningudMassiiv As String(,) = New String(paevasedTreeningud.Count - 1, 2) {}
        For i = 0 To paevasedTreeningud.Count - 1
            For j = 0 To paevasedTreeningud(i).Length - 1
                paevasedTreeningudMassiiv(i, j) = paevasedTreeningud(i)(j)
            Next
        Next

        If failiAsukoht.Length > 1 Then
            SalvestamineK.saveDataToCsv(paevasedToidudMassiiv, True)
            SalvestamineK.saveDataToCsv(paevasedTreeningudMassiiv, True)

            pbAjalooValjavoteOnnestus.Visible = True
            Timer2s.Start()
        Else
            Exit Sub
        End If
    End Sub
End Class

