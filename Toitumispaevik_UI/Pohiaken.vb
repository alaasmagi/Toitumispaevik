Imports System.Data.Entity.Core.Mapping
Imports System.Data.SQLite
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

    Private _kasutaja_id As Integer
    Private kalorilimiit As Integer
    Private kasutajaKaal As Double
    Private kaaluEesmark As Double
    Private kaaluEesmarkVahe As Double
    Private kaaluEesmarkAeg As Double
    Private TabelKaalud As Double()
    Private DateTabelKaalud As Integer()
    Private ajalooKuupaev As Integer
    Private valueMap As New Dictionary(Of String, Integer)()
    Dim kultuur As New CultureInfo("et-EE")


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

    Public Sub New(ByVal kasutaja_id As Integer)
        InitializeComponent()
        _kasutaja_id = kasutaja_id
        Dim ProfiilK As New KasutajaProfiilKomponent.CKasutajaProfiil
        kalorilimiit = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "calorie_limit")
        kaaluEesmark = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "weight_goal")

    End Sub
    Public Sub ResetForm()
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        AnaluusK = New AnaluusiKomponent.CAnaluus

        kasutajaKaal = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "weight")
        kaaluEesmark = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "weight_goal")
        kaaluEesmarkVahe = Math.Abs(kaaluEesmark - kasutajaKaal)
        kaaluEesmarkAeg = kaaluEesmarkVahe / 0.5

        ajalooKuupaev = AnaluusK.KuupaevIntegeriks(Date.Now.Date)
        lblAjaluguKuupaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
        lblAjaluguNadalaPaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev).ToString("ddd", kultuur) + ","

        If AnaluusK.PaevaseAndmereaParing(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), "energy_intake") = -1 Then
            AnaluusK.TuhjaPaevaseAndmereaSisestus(_kasutaja_id, ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight"), AnaluusK.KuupaevIntegeriks(Date.Now.Date))
        End If
        kalorilimiit = AnaluusK.DBParingBMR(_kasutaja_id, ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight_goal"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height"), AnaluusK.KuupaevIntegeriks(Date.Now.Date))

        If kalorilimiit < 1000 Then
            lblSulOnProbleem.Visible = True
            lblKaloriLimiit.Visible = False
        Else
            lblKaloriLimiit.Text = kalorilimiit & "kcal"
            lblSulOnProbleem.Visible = False
            lblKaloriLimiit.Visible = True
        End If

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

        lblEesnimi.Text = ProfiilK.Dekrupteerimine(ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "firstname"))
        lblKoduEesnimi.Text = lblEesnimi.Text & "!"
        lblProfiiliSeadedEesnimi.Text = lblEesnimi.Text
        lblProfiiliSeadedKasutajanimi.Text = ProfiilK.Dekrupteerimine(ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "username"))
        lblKasutajaPikkus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height") & "cm"


        lblKasutajaKaal.Text = kasutajaKaal & "kg"
        lblKaaluEesmark.Text = kaaluEesmark & "kg"
        lblKaaluEesmargiVahe.Text = kaaluEesmarkVahe & "kg"
        lblKaaluEesmargiAeg.Text = kaaluEesmarkAeg & "ndl"
        lblKasutajaVanus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age") & "aastat"


        If ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex") = 0 Then
            pbUlemineMees.Visible = True
            pbAlumineMees.Visible = True
        ElseIf ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex") = 1 Then
            pbUlemineNaine.Visible = True
            pbAlumineNaine.Visible = True
        End If
        KomboKastid()
        KoduGraafik()
        UlevaatusCmbBox()
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 7 päeva")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane kuu")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 3 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 6 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane aasta")
        cmbAjaluguGraafikuPeriood.SelectedIndex = 0

        GraafikuSeaded()
        AjalooAken()

    End Sub

    Private Sub GraafikuSeaded()
        AnaluusK = New AnaluusiKomponent.CAnaluus
        TabelKaalud = AnaluusK.KaaluParingAndmebaasist(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), AnaluusK.PariValueMap(cmbAjaluguGraafikuPeriood.SelectedItem, valueMap))
        DateTabelKaalud = AnaluusK.KaaluDateParingAndmebaasist(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), AnaluusK.PariValueMap(cmbAjaluguGraafikuPeriood.SelectedItem, valueMap))

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

    Private Sub UlevaatusCmbBox()
        AnaluusK = New AnaluusiKomponent.CAnaluus
        AnaluusK.LisaValueMap("Viimased 7 päeva", 7, valueMap)
        AnaluusK.LisaValueMap("Viimane kuu", 30, valueMap)
        AnaluusK.LisaValueMap("Viimased 3 kuud", 91, valueMap)
        AnaluusK.LisaValueMap("Viimased 6 kuud", 182, valueMap)
        AnaluusK.LisaValueMap("Viimane aasta", 365, valueMap)
    End Sub

    Private Sub KoduGraafik()
        chrKoduPaneel.Series("Soogikorrad").Points.Clear()
        AnaluusK = New AnaluusiKomponent.CAnaluus

        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Hommik", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutaja_id, 0))

        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Lõuna", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutaja_id, 1))

        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Õhtu", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutaja_id, 3))

        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Vahepalad", AnaluusK.PariKcalPaveaHetkest(AnaluusK.KuupaevIntegeriks(Date.Now.Date), _kasutaja_id, 2))

        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Söömata", AnaluusK.PariKaloriUlejaak(AnaluusK.PaevaneKcal(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date)), kalorilimiit))
        lblKcalPaev.Text = AnaluusK.PaevaneKcal(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date)) & Environment.NewLine & "/" & Environment.NewLine & kalorilimiit & Environment.NewLine & "kcal"
    End Sub
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

    Private Sub btnLogiValja_Click(sender As Object, e As EventArgs) Handles btnLogiValja.Click
        Me.Hide()
        Dim login_aken As New Login_aken()
        login_aken.Show()
        Me.Close()
    End Sub


    Private Sub btnToidulaud_Click(sender As Object, e As EventArgs) Handles btnToidulaud.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlToidulaud.Visible = True
    End Sub

    Private Sub btnTreeningud_Click(sender As Object, e As EventArgs) Handles btnTreeningud.Click
        pnlYlevaade.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlTreeningud.Visible = True
    End Sub

    Private Sub btnYlevaade_Click(sender As Object, e As EventArgs) Handles btnYlevaade.Click
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlYlevaade.Visible = True
    End Sub

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
    End Sub

    Private Sub btnTulevik_Click(sender As Object, e As EventArgs)
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
    End Sub

    Private Sub btnProfiiliSeaded_Click(sender As Object, e As EventArgs) Handles btnProfiiliSeaded.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlKodu.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlProfiiliSeaded.Visible = True

        kasutajaKaal = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "weight")
        kaaluEesmark = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "weight_goal")
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

    Private Sub btnKodu_Click(sender As Object, e As EventArgs) Handles btnKodu.Click
        pnlYlevaade.Visible = False
        pnlTreeningud.Visible = False
        pnlToidulaud.Visible = False
        pnlAjalugu.Visible = False
        pnlProfiiliSeaded.Visible = False
        pnlRakenduseInfo.Visible = False
        pnlKodu.Visible = True

    End Sub
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
    Sub KomboKastid()

        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid
        TreeningudK = New TreeninguteKomponent.CTreeningud

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
        cmbMuudaPikkust.SelectedItem = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height")

        For index = 12 To 100
            cmbMuudaVanust.Items.Add(index)
        Next
        cmbMuudaVanust.SelectedItem = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age")

    End Sub

    Private Sub btnMuudaVanust_Click(sender As Object, e As EventArgs) Handles btnMuudaVanust.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaVanust.SelectedItem, "age")
        lblKasutajaVanus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age") & "aastat"
        KomboKastid()
    End Sub

    Private Sub btnMuudaPikkust_Click(sender As Object, e As EventArgs) Handles btnMuudaPikkust.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaPikkust.SelectedItem, "height")
        lblKasutajaPikkus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height") & "cm"
        KomboKastid()
    End Sub

    Private Sub btnKinnitaUusSalasona_Click(sender As Object, e As EventArgs) Handles btnKinnitaUusSalasona.Click
        lblVahetaSalasonaViga.ForeColor = Color.Red
        lblVahetaSalasonaViga.Visible = False
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        If (ProfiilK.ArvutaHash(txtKehtivSalasona.Text) = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "password")) Then
            If Len(txtVahetaSalasona.Text) < 8 Then
                txtVahetaSalasona.Text = ""
                lblVahetaSalasonaViga.Text = "Salasõna pikkus peab olema vähemalt 8 tähemärki!"
                lblVahetaSalasonaViga.Visible = True
            ElseIf txtVahetaSalasona.Text <> txtKordaSalasona.Text Then
                txtKordaSalasona.Text = ""
                lblVahetaSalasonaViga.Text = "Salasõnad ei ühti!"
                lblVahetaSalasonaViga.Visible = True
            Else
                ProfiilK.VahetaSalasona(_kasutaja_id, txtVahetaSalasona.Text)
                lblVahetaSalasonaViga.ForeColor = Color.Green
                txtKehtivSalasona.Text = ""
                txtKordaSalasona.Text = ""
                txtVahetaSalasona.Text = ""
                lblVahetaSalasonaViga.Text = "Salasõna vahetus õnnestus!"
                lblVahetaSalasonaViga.Visible = True
            End If
        Else
            txtKehtivSalasona.Text = ""
            lblVahetaSalasonaViga.Text = "Kehtiv salasõna on vale!"
            lblVahetaSalasonaViga.Visible = True
        End If
    End Sub


    Private Sub btnLisaUusToiduaine_Click(sender As Object, e As EventArgs) Handles btnLisaUusToiduaine.Click
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid

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
            End If
        Else
            lblUueToiduaineLisamineViga.Text = "Viga toiduaine lisamisel!"
            lblUueToiduaineLisamineViga.Visible = True
        End If
        KomboKastid()
    End Sub

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
                ToidudRetseptidK.KasutajaToiduaineVõiRetseptiLisamine(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), toidukord, ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem), txtToiduaineKiirvalikKogus.Text)
            ElseIf ToidudRetseptidK.RetseptiNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem) > 0 Then
                ToidudRetseptidK.KasutajaToiduaineVõiRetseptiLisamine(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), toidukord, ToidudRetseptidK.RetseptiNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem), txtToiduaineKiirvalikKogus.Text)
            End If
            lblToiduAineRetseptiLisamineViga.Visible = False
            txtToiduaineKiirvalikKogus.Text = ""
        Else
            lblToiduAineRetseptiLisamineViga.Text = "Viga koguse sisestuses!"
            lblToiduAineRetseptiLisamineViga.Visible = True
        End If
        AjalooInfo()
        KoduGraafik()
    End Sub

    Private Sub btnTreeninguKiirvalikLisa_Click(sender As Object, e As EventArgs) Handles btnTreeninguKiirvalikLisa.Click
        TreeningudK = New TreeninguteKomponent.CTreeningud
        AnaluusK = New AnaluusiKomponent.CAnaluus

        If IsNumeric(txtTreeninguKiirvalikKestus.Text) AndAlso txtTreeninguKiirvalikKestus.Text > 0 Then
            lblTreeninguKiirvalikViga.Visible = False
            TreeningudK.KasutajaTreeninguLisamine(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), TreeningudK.TreeninguNimiEksisteerib(cmbTreeninguteKiirvalik.SelectedItem()), txtTreeninguKiirvalikKestus.Text)
            AnaluusK.PaevaneKcal(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date))
            txtTreeninguKiirvalikKestus.Text = ""
        Else
            lblTreeninguKiirvalikViga.Text = "Viga kestuse sisestuses!"
            lblTreeninguKiirvalikViga.Visible = True
        End If
        AjalooInfo()
    End Sub

    Private Sub btnTreeninguLisamine_Click(sender As Object, e As EventArgs) Handles btnTreeninguLisamine.Click
        TreeningudK = New TreeninguteKomponent.CTreeningud

        If IsNumeric(txtTreeninguLisamineEnergialkulu.Text) AndAlso txtTreeninguLisamineEnergialkulu.Text > 0 Then
            If TreeningudK.TreeninguNimiEksisteerib(txtUueToiduaineNimi.Text) > 0 Then
                lblTreeninguLisamineViga.Text = "Treening on juba andmebaasis!"
                lblTreeninguLisamineViga.Visible = True
            Else
                lblTreeninguLisamineViga.Visible = False
                TreeningudK.LisaTreening(txtTreeninguLisamineNimi.Text, txtTreeninguLisamineEnergialkulu.Text)
                txtTreeninguLisamineNimi.Text = ""
                txtTreeninguLisamineEnergialkulu.Text = ""
            End If
        Else
            lblUueToiduaineLisamineViga.Text = "Viga energiakulu sisestuses!"
            lblUueToiduaineLisamineViga.Visible = True
        End If
        KomboKastid()
    End Sub



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

    Private Sub btnKinnitaRetsept_Click(sender As Object, e As EventArgs) Handles btnKinnitaRetsept.Click
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid

        If ToidudRetseptidK.RetseptiNimiEksisteerib(txtRetseptiNimi.Text) > 0 Then
            lblRetseptiLisamineViga.Text = "Nimi juba kasutusel!"
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
            For i As Integer = 0 To retseptideKoostisosad.Count - 1
                Dim koostisosa As String = retseptideKoostisosad(i)
                Dim kogus As String = retseptideKoostisosadeKogused(i)

                ToidudRetseptidK.LisaRetseptiKoostisosadeTabelisse(retsepti_id, koostisosa, kogus)
            Next
            retseptideKoostisosad.Clear()
            retseptideKoostisosadeKogused.Clear()
            lbRetseptiKoostisosad.Items.Clear()
        End If
        KomboKastid()
    End Sub

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
                KomboKastid()
            End If
        End If
    End Sub

    Private Sub btnPaevaneKaal_Click(sender As Object, e As EventArgs) Handles btnPaevaneKaal.Click
        AnaluusK = New AnaluusiKomponent.CAnaluus
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil

        If IsNumeric(txtPaevaneKaal.Text) AndAlso txtPaevaneKaal.Text > 0 Then
            lblPaevaseKehakaaluLisamineViga.Visible = False
            AnaluusK.KaaluLisamine(_kasutaja_id, txtPaevaneKaal.Text)
            ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, txtPaevaneKaal.Text, "weight")
            lblKasutajaKaal.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight")
            KomboKastid()
            GraafikuSeaded()
            txtPaevaneKaal.Text = ""
        Else
            lblPaevaseKehakaaluLisamineViga.Text = "Ebakorrektne sisestus!"
            lblPaevaseKehakaaluLisamineViga.Visible = True
        End If
        kalorilimiit = AnaluusK.DBParingBMR(_kasutaja_id, ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight_goal"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height"), AnaluusK.KuupaevIntegeriks(Date.Now.Date))
    End Sub

    Private Sub btnNaitaYlevaadet_Click(sender As Object, e As EventArgs) Handles btnNaitaYlevaadet.Click
        GraafikuSeaded()
    End Sub

    Private Sub btnEesmargiKinnitamine_Click(sender As Object, e As EventArgs) Handles btnEesmargiKinnitamine.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        If IsNumeric(txtKaaluEesmärk.Text) AndAlso txtKaaluEesmärk.Text > 0 Then
            lblKaaluEesmargiSeadmineViga.Visible = False
            ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, txtKaaluEesmärk.Text, "weight_goal")
            kaaluEesmark = txtKaaluEesmärk.Text
            GraafikuSeaded()
            txtKaaluEesmärk.Text = ""
        Else
            lblKaaluEesmargiSeadmineViga.Text = "Ebakorrektne sisestus!"
            lblKaaluEesmargiSeadmineViga.Visible = True
        End If
        kalorilimiit = AnaluusK.DBParingBMR(_kasutaja_id, ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight"), ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight_goal"),
                             ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height"), AnaluusK.KuupaevIntegeriks(Date.Now.Date))
    End Sub


    Private Sub btnToiduaineKustutamine_Click(sender As Object, e As EventArgs) Handles btnToiduaineKustutamine.Click
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid

        Dim toiduaine_retsepti_id As Integer?
        toiduaine_retsepti_id = ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbToiduaineKustutamine.SelectedItem)

        If toiduaine_retsepti_id.HasValue Then
            If toiduaine_retsepti_id < 2006 Then
                lblToiduaineKustutamineViga.Text = "Baastoiduainet ei saa kustutada!"
                lblToiduaineKustutamineViga.Visible = True
            Else
                lblToiduaineKustutamineViga.Visible = False
                ToidudRetseptidK.ToiduaineVoiRetseptiKustutamine(toiduaine_retsepti_id, 1)
                KomboKastid()
            End If
        Else
            lblToiduaineKustutamineViga.Visible =
            toiduaine_retsepti_id = ToidudRetseptidK.RetseptiNimiEksisteerib(cmbToiduaineKustutamine.SelectedItem)
            ToidudRetseptidK.ToiduaineVoiRetseptiKustutamine(toiduaine_retsepti_id, 0)
            KomboKastid()
        End If
    End Sub
    Private Sub chbMukbangFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chbMukbangFilter.CheckedChanged
        KomboKastid()
    End Sub
    Private Sub AjalooInfo()
        AnaluusK = New AnaluusiKomponent.CAnaluus
        TreeningudK = New TreeninguteKomponent.CTreeningud
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid

        lvPaevasedToidud.Items.Clear()
        lvPaevasedTreeningud.Items.Clear()

        Dim paevasteToitudeId As Double() = AnaluusK.PaevasedToidud(_kasutaja_id, ajalooKuupaev, "food_id")
        Dim paevasteToitudeKcal As Double() = AnaluusK.PaevasedToidud(_kasutaja_id, ajalooKuupaev, "energy_intake")
        Dim paevasteToitudeToidukord As Double() = AnaluusK.PaevasedToidud(_kasutaja_id, ajalooKuupaev, "time_of_meal")


        If AnaluusK.PaevaseAndmereaParing(_kasutaja_id, ajalooKuupaev, "daily_weight") > 0 Then
            lblAjaluguKehakaal.Text = AnaluusK.PaevaseAndmereaParing(_kasutaja_id, ajalooKuupaev, "daily_weight") & "kg"
            lblAjaluguVordlusTanasega.Text = AnaluusK.PaevaseAndmereaParing(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), "daily_weight") - AnaluusK.PaevaseAndmereaParing(_kasutaja_id, ajalooKuupaev, "daily_weight") & "kg"
            lblAjaluguSoodudKalorid.Text = AnaluusK.PaevaseAndmereaParing(_kasutaja_id, ajalooKuupaev, "energy_intake") & "kcal"
            lblAjaluguKulutatudKalorid.Text = AnaluusK.PaevaseAndmereaParing(_kasutaja_id, ajalooKuupaev, "energy_consumption") & "kcal"
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
        Dim paevasteTreeninguteId As Double() = AnaluusK.PaevasedTreeningud(_kasutaja_id, ajalooKuupaev, "training_id")
        Dim paevasteTreeninguteKcal As Double() = AnaluusK.PaevasedTreeningud(_kasutaja_id, ajalooKuupaev, "total_consumption")
        Dim paevasteTreeninguteKestus As Double() = AnaluusK.PaevasedTreeningud(_kasutaja_id, ajalooKuupaev, "duration")

        For index = 0 To paevasteTreeninguteId.Count - 1
            lvPaevasedTreeningud.Items.Add(New ListViewItem({TreeningudK.TreeninguNimeLeidmine(paevasteTreeninguteId(index)), paevasteTreeninguteKcal(index) & "kcal", paevasteTreeninguteKestus(index) & "min"}))
        Next



    End Sub

    Private Sub MakroGraafik()
        chrAjalooPaneel.Series("Makrod").Points.Clear()
        AnaluusK = New AnaluusiKomponent.CAnaluus

        chrAjalooPaneel.Series("Makrod").Points.AddXY("Süsivesikud", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutaja_id, "total_c_hydrates"))

        chrAjalooPaneel.Series("Makrod").Points.AddXY("Suhkrud", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutaja_id, "total_sugar"))

        chrAjalooPaneel.Series("Makrod").Points.AddXY("Valgud", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutaja_id, "total_protein"))

        chrAjalooPaneel.Series("Makrod").Points.AddXY("Rasvad", AnaluusK.PariMakroaineKogus(ajalooKuupaev, _kasutaja_id, "total_lipid"))

    End Sub

    Private Sub bntAjalooKuupaevEdasi_Click(sender As Object, e As EventArgs) Handles bntAjalooKuupaevEdasi.Click
        AnaluusK = New AnaluusiKomponent.CAnaluus
        If ajalooKuupaev < AnaluusK.KuupaevIntegeriks(Date.Now.Date) Then
            ajalooKuupaev = ajalooKuupaev + 1
            AjalooAken()
        End If
    End Sub

    Private Sub btnAjalooKuupaevTagasi_Click(sender As Object, e As EventArgs) Handles btnAjalooKuupaevTagasi.Click
        AnaluusK = New AnaluusiKomponent.CAnaluus
        ajalooKuupaev = ajalooKuupaev - 1
        AjalooAken()
    End Sub

    Private Sub AjalooAken()
        AnaluusK = New AnaluusiKomponent.CAnaluus
        lblAjaluguKuupaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev)
        lblAjaluguNadalaPaev.Text = AnaluusK.IntegerKuupaevaks(ajalooKuupaev).ToString("ddd", kultuur) + ","

        AjalooInfo()
        MakroGraafik()
    End Sub
End Class

