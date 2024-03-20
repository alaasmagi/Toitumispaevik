Imports System.Windows.Forms.VisualStyles

Public Class Pohiaken

    Private _kasutaja_id As Integer
    Private HommikKcal As Integer = 0
    Private LounaKcal As Integer = 0
    Private OhtuKcal As Integer = 0
    Private VahepKcal As Integer = 0
    Private ToidukorradKoos As Integer

    Public Sub New(ByVal kasutaja_id As Integer)
        InitializeComponent()
        _kasutaja_id = kasutaja_id
    End Sub
    Public Sub ResetForm()
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
        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil
        lblEesnimi.Text = profiil.Dekrupteerimine(profiil.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "firstname"))
        lblKoduEesnimi.Text = lblEesnimi.Text & "!"
        lblProfiiliSeadedEesnimi.Text = lblEesnimi.Text
        lblProfiiliSeadedKasutajanimi.Text = profiil.Dekrupteerimine(profiil.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "username"))
        lblKasutajaPikkus.Text = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height")
        lblKasutajaKaal.Text = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight")
        lblKasutajaVanus.Text = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age")

        Dim AnaluusK As AnaluusiKomponent.IAnaluus
        AnaluusK = New AnaluusiKomponent.CAnaluus

        'sisendid 2 ja 3 KclParingAndmebaasist vajavad vahetamist (2 kuupäev mingis formaadis) (3 söögiaeg kas nii voi 0-3)
        HommikKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, 100, "hommik"))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Hommik", HommikKcal)

        'sisendid 2 ja 3 KclParingAndmebaasist vajavad vahetamist (2 kuupäev mingis formaadis) (3 söögiaeg kas nii voi 0-3)
        LounaKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, 100, "louna"))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Lõuna", LounaKcal)

        'sisendid 2 ja 3 KclParingAndmebaasist vajavad vahetamist (2 kuupäev mingis formaadis) (3 söögiaeg kas nii voi 0-3)
        OhtuKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, 100, "ohtu"))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Õhtu", OhtuKcal)

        'sisendid 2 ja 3 KclParingAndmebaasist vajavad vahetamist (2 kuupäev mingis formaadis) (3 söögiaeg kas nii voi 0-3)
        VahepKcal = AnaluusK.ToidukordKokku(AnaluusK.KclParingAndmebaasist(_kasutaja_id, 100, "vahep"))
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Vahepalad", VahepKcal)

        'lisada muutuja soovitud kalori tarbimis koguseks "3000" asemel
        ToidukorradKoos = AnaluusK.paevaneKcal(HommikKcal, LounaKcal, OhtuKcal, VahepKcal)
        chrKoduPaneel.Series("Soogikorrad").Points.AddXY("Söömata", 3000 - ToidukorradKoos)



        If profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex") = 0 Then
            pbUlemineMees.Visible = True
            pbAlumineMees.Visible = True
        ElseIf profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "sex") = 1 Then
            pbUlemineNaine.Visible = True
            pbAlumineNaine.Visible = True
        End If
        KomboKastid()

        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 7 päeva")
        cmbAjaluguGraafikuPeriood.SelectedItem = "Viimased 7 päeva"
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane kuu")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 3 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimased 6 kuud")
        cmbAjaluguGraafikuPeriood.Items.Add("Viimane aasta")
        cmbAjaluguGraafikuPeriood.Items.Add("Kogu ajalugu")
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

        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil

        For index = 140 To 210
            cmbMuudaPikkust.Items.Add(index)
        Next
        cmbMuudaPikkust.SelectedItem = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height")

        For index = 30 To 150
            cmbMuudaKaalu.Items.Add(index)
        Next
        cmbMuudaKaalu.SelectedItem = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight")

        For index = 12 To 100
            cmbMuudaVanust.Items.Add(index)
        Next
        cmbMuudaVanust.SelectedItem = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age")
    End Sub

    Private Sub btnMuudaVanust_Click(sender As Object, e As EventArgs) Handles btnMuudaVanust.Click
        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil
        profiil.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaVanust.SelectedItem, "age")
        lblKasutajaVanus.Text = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "age")
        KomboKastid()
    End Sub

    Private Sub btnMuudaKaalu_Click(sender As Object, e As EventArgs) Handles btnMuudaKaalu.Click
        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil
        profiil.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaKaalu.SelectedItem, "weight")
        lblKasutajaKaal.Text = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "weight")
        KomboKastid()
    End Sub

    Private Sub btnMuudaPikkust_Click(sender As Object, e As EventArgs) Handles btnMuudaPikkust.Click
        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil
        profiil.IntegerAndmeValjaSisestusKasutajaTabelisse(_kasutaja_id, cmbMuudaPikkust.SelectedItem, "height")
        lblKasutajaPikkus.Text = profiil.UheIntegerAndmeValjaParingKasutajaTabelist(_kasutaja_id, "height")
        KomboKastid()
    End Sub

    Private Sub btnKinnitaUusSalasona_Click(sender As Object, e As EventArgs) Handles btnKinnitaUusSalasona.Click
        lblVahetaSalasonaViga.ForeColor = Color.Red
        lblVahetaSalasonaViga.Visible = False
        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil
        If (profiil.ArvutaHash(txtKehtivSalasona.Text) = profiil.UheAndmevaljaParingKasutajaTabelist(_kasutaja_id, "password")) Then
            If Len(txtVahetaSalasona.Text) < 8 Then
                txtVahetaSalasona.Text = ""
                lblVahetaSalasonaViga.Text = "Salasõna pikkus peab olema vähemalt 8 tähemärki!"
                lblVahetaSalasonaViga.Visible = True
            ElseIf txtVahetaSalasona.Text <> txtKordaSalasona.Text Then
                txtKordaSalasona.Text = ""
                lblVahetaSalasonaViga.Text = "Salasõnad ei ühti!"
                lblVahetaSalasonaViga.Visible = True
            Else
                profiil.VahetaSalasona(_kasutaja_id, txtVahetaSalasona.Text)
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
End Class