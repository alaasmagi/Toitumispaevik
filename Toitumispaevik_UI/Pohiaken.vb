Imports System.Data.Entity.Core.Mapping
Imports System.Data.SQLite
Imports System.IO
Imports System.Security.Authentication.ExtendedProtection
Imports System.Windows.Forms.VisualStyles
Imports KasutajaProfiilKomponent
Imports ToidudRetseptidKomponent

Public Class Pohiaken

    Private _kasutaja_id As Integer
    Private kalorilimiit As Integer
    Private HommikKcal As Double = 0
    Private LounaKcal As Double = 0
    Private OhtuKcal As Double = 0
    Private VahepKcal As Double = 0
    Private ToidukorradKoos As Double = 0
    Private kcalUlejaak As Double = 0

    Dim ProfiilK As KasutajaProfiilKomponent.IKasutajaProfiil
    Dim AnaluusK As AnaluusiKomponent.IAnaluus
    Dim ToidudRetseptidK As ToidudRetseptidKomponent.IToidudjaRetseptid

    Public Sub New(ByVal kasutaja_id As Integer)
        InitializeComponent()
        _kasutaja_id = kasutaja_id
        Dim ProfiilK As New KasutajaProfiilKomponent.CKasutajaProfiil
        kalorilimiit = ProfiilK.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "calorie_limit")
    End Sub
    Public Sub ResetForm()
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil

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
        lblKasutajaPikkus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height")
        lblKasutajaKaal.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight")
        lblKasutajaVanus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age")


        If ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex") = 0 Then
            pbUlemineMees.Visible = True
            pbAlumineMees.Visible = True
        ElseIf ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex") = 1 Then
            pbUlemineNaine.Visible = True
            pbAlumineNaine.Visible = True
        End If
        KomboKastid()
        KoduGraafik()
        KiirLisamiseValikud()
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 7 päeva")
        cmbAjaluguGraafikuPeriood.SelectedItem = "Viimased 7 päeva"
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane kuu")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 3 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 6 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane aasta")
        cmbAjaluguGraafikuPeriood.Items.Add("Kogu ajalugu")
    End Sub

    Private Sub KoduGraafik()
        chrKoduPaneel.Series("Soogikorrad").Points.Clear()
        AnaluusK = New AnaluusiKomponent.CAnaluus

        HommikKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), 0))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Hommik", HommikKcal)

        LounaKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), 1))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Lõuna", LounaKcal)

        OhtuKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), 3))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Õhtu", OhtuKcal)

        VahepKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), 2))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Vahepalad", VahepKcal)

        If ToidukorradKoos > kalorilimiit Then
            kcalUlejaak = 0
        Else
            kcalUlejaak = kalorilimiit - ToidukorradKoos
        End If

        ToidukorradKoos = AnaluusK.paevaneKcal(HommikKcal, LounaKcal, OhtuKcal, VahepKcal)
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Söömata", kcalUlejaak)

        LblPaevaneTarbimine.Text = ToidukorradKoos & Environment.NewLine & "/" & Environment.NewLine & kalorilimiit
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

        For index = 140 To 210
            cmbMuudaPikkust.Items.Add(index)
        Next
        cmbMuudaPikkust.SelectedItem = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height")

        For index = 30 To 150
            cmbMuudaKaalu.Items.Add(index)
        Next
        cmbMuudaKaalu.SelectedItem = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight")

        For index = 12 To 100
            cmbMuudaVanust.Items.Add(index)
        Next
        cmbMuudaVanust.SelectedItem = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age")


    End Sub

    Private Sub btnMuudaVanust_Click(sender As Object, e As EventArgs) Handles btnMuudaVanust.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaVanust.SelectedItem, "age")
        lblKasutajaVanus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age")
        KomboKastid()
    End Sub

    Private Sub btnMuudaKaalu_Click(sender As Object, e As EventArgs) Handles btnMuudaKaalu.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaKaalu.SelectedItem, "weight")
        lblKasutajaKaal.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight")
        KomboKastid()
    End Sub

    Private Sub btnMuudaPikkust_Click(sender As Object, e As EventArgs) Handles btnMuudaPikkust.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaPikkust.SelectedItem, "height")
        lblKasutajaPikkus.Text = ProfiilK.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height")
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
        Dim kalorid As New CToidudJaRetseptid

        If IsNumeric(txtUueToiduaineKcal.Text) AndAlso IsNumeric(txtUueToiduaineSusivesikud.Text) AndAlso IsNumeric(txtUueToiduaineSuhkrud.Text) AndAlso
            IsNumeric(txtUueToiduaineRasvad.Text) AndAlso IsNumeric(txtUueToiduaineValgud.Text) Then
            lblUueToiduaineLisamineViga.Visible = False
            kalorid.LisaToiduaine(txtUueToiduaineNimi.Text, txtUueToiduaineKcal.Text, txtUueToiduaineValgud.Text, txtUueToiduaineSusivesikud.Text,
                                  txtUueToiduaineRasvad.Text, txtUueToiduaineSuhkrud.Text)
            txtUueToiduaineNimi.Text = ""
            txtUueToiduaineKcal.Text = ""
            txtUueToiduaineSusivesikud.Text = ""
            txtUueToiduaineSuhkrud.Text = ""
            txtUueToiduaineValgud.Text = ""
            txtUueToiduaineRasvad.Text = ""
            KiirLisamiseValikud()
        Else
            lblUueToiduaineLisamineViga.Text = "Viga toiduaine lisamisel!"
            lblUueToiduaineLisamineViga.Visible = True
        End If
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
        If IsNumeric(txtToiduaineKiirvalikKogus.Text) Then
            ToidudRetseptidK.KasutajaToiduaineVõiRetseptiLisamine(_kasutaja_id, AnaluusK.KuupaevIntegeriks(Date.Now.Date), toidukord, ToidudRetseptidK.ToiduAineNimiEksisteerib(cmbToiduaineKiirvalik.SelectedItem), txtToiduaineKiirvalikKogus.Text)
            KoduGraafik()
            lblToiduAineRetseptiLisamineViga.Visible = False
            txtToiduaineKiirvalikKogus.Text = ""
        Else
            lblToiduAineRetseptiLisamineViga.Text = "Viga koguse sisestuses!"
            lblToiduAineRetseptiLisamineViga.Visible = True
        End If

    End Sub

    Private Sub KiirLisamiseValikud()
        ToidudRetseptidK = New ToidudRetseptidKomponent.CToidudJaRetseptid
        cmbToiduaineKiirvalik.Items.Clear()

        Dim toiduaineteNimed As List(Of String) = ToidudRetseptidK.KiirlisamiseToiduaineNimed
        For Each nimetus As String In toiduaineteNimed
            cmbToiduaineKiirvalik.Items.Add(nimetus)
        Next
        cmbToiduaineKiirvalik.SelectedIndex = 0
    End Sub

    Private Sub btnKaloriLimiit_Click(sender As Object, e As EventArgs) Handles btnKaloriLimiit.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        If (IsNumeric(txtKalorilimiit.Text)) Then
            ProfiilK.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, txtKalorilimiit.Text, "calorie_limit")
            txtKalorilimiit.Text = ""
            lblKaloriLimiitViga.Visible = False
            KoduGraafik()
        Else
            lblKaloriLimiitViga.ForeColor = Color.Red
            lblKaloriLimiitViga.Text = "Viga limiidi seadmisel!"
            lblKaloriLimiitViga.Visible = True
        End If
    End Sub
End Class

