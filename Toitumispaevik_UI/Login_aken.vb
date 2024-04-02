Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms
Imports System.Collections.Generic

Imports System.IO
Imports System.Data.SQLite
Imports System.Data.CommandType
Public Class Login_aken

    Dim sugu As Integer
    Dim kasutaja_id As Integer = 0

    Dim ProfiilK As KasutajaProfiilKomponent.IKasutajaProfiil
    Private Sub ResetForm()
        TuhjendaKonteiner(Me)
        pnlLogoLogiSisse.Visible = True
        pnlLogiSisse.Visible = True
        pnlLooKonto.Visible = False
        pnlLooKontoEdasi.Visible = False
        pnlUnustasinSalasona.Visible = False
        txtLogiSisseSalasona.UseSystemPasswordChar = True
        txtLooKontoSalasona.UseSystemPasswordChar = True
        txtKordaSalasona.UseSystemPasswordChar = True
        txtUnustasinSalasonaEdasiUusSalasona.UseSystemPasswordChar = True
        txtUnustasinSalasonaEdasiKordaSalasona.UseSystemPasswordChar = True
        lblLooKontoViga.Visible = False
        lblLooKontoEdasiViga.Visible = False
        lblLogiSisseViga.Visible = False
        lblUnustasinSalasonaEdasiViga.Visible = False
        lblKontotEiEksisteeri.Visible = False
        lblTurvaKusimus.Visible = False
        lblTurvaKusimusEdasiKasutajanimi.Visible = False
        pnlUnustasinSalasonaEdasi.Visible = False

        For index = 140 To 210
            cmbPikkus.Items.Add(index)
        Next
        cmbPikkus.SelectedItem = 176

        For index = 30 To 150
            cmbKehaKaal.Items.Add(index)
        Next
        cmbKehaKaal.SelectedItem = 70

        For index = 12 To 100
            cmbVanus.Items.Add(index)
        Next
        cmbVanus.SelectedItem = 20
        turvaKusimused()
    End Sub

    Private Sub turvaKusimused()

        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil

        Dim kusimused As List(Of String) = ProfiilK.TurvaKusimused
        For Each kusimus As String In kusimused
            cmbTurvaKüsimus.Items.Add(kusimus)
        Next
        cmbTurvaKüsimus.SelectedIndex = 0
    End Sub
    Private Sub Login_aken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub
    Private Sub lblPoleKontot_Click(sender As Object, e As EventArgs) Handles lblPoleKontot.Click
        pnlLogiSisse.Visible = False
        pnlLooKonto.Visible = True
    End Sub

    Private Sub lblKontoOlemas_Click(sender As Object, e As EventArgs) Handles lblKontoOlemas.Click
        pnlLooKonto.Visible = False
        pnlLogiSisse.Visible = True
    End Sub

    Private Sub btnLogiSisse_Click(sender As Object, e As EventArgs) Handles btnLogiSisse.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        kasutaja_id = ProfiilK.KontrolliKontoOlemasolu(txtLogiSisseKasutaja.Text)

        If kasutaja_id = 0 Then
            lblLogiSisseViga.Text = "Sisestatud nimega kasutajat ei leitud!"
            lblLogiSisseViga.Visible = True
            txtLogiSisseSalasona.Text = ""
            txtLogiSisseKasutaja.Text = ""
        ElseIf ProfiilK.SisseLogimine(kasutaja_id, txtLogiSisseSalasona.Text) = 0 Then
            lblLogiSisseViga.Text = "Sisestatud salasõna on vale!"
            lblLogiSisseViga.Visible = True
            txtLogiSisseSalasona.Text = ""
        Else
            lblLogiSisseViga.Visible = False
            ResetForm()
            Me.Hide()
            Dim pohiaken As New Pohiaken(kasutaja_id)
            pohiaken.ResetForm()
            pohiaken.Show()
        End If
    End Sub

    Private Sub btnLooKontoEdasi_Click(sender As Object, e As EventArgs) Handles btnLooKontoEdasi.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        kasutaja_id = ProfiilK.KontrolliKontoOlemasolu(txtLooKontoKasutajanimi.Text)
        If txtEesnimi.Text = "" Then
            lblLooKontoViga.Text = "Eesnime lahter ei tohi jääda tühjaks!"
            lblLooKontoViga.Visible = True
        ElseIf kasutaja_id <> 0 Then
            lblLooKontoViga.Text = "Sellise kasutajanimega konto on juba olemas!"
            lblLooKontoViga.Visible = True
        ElseIf Len(txtLooKontoSalasona.Text) < 8 Then
            lblLooKontoViga.Text = "Salasõna pikkus peab olema vähemalt 8 tähemärki!"
            lblLooKontoViga.Visible = True
        ElseIf txtLooKontoSalasona.Text <> txtKordaSalasona.Text Then
            lblLooKontoViga.Text = "Salasõnad ei ühti!"
            lblLooKontoViga.Visible = True
        Else
            lblLooKontoViga.Visible = False
            pnlLooKonto.Visible = False
            pnlLooKontoEdasi.Visible = True
        End If
    End Sub
    Private Sub btnLooKonto_Click(sender As Object, e As EventArgs) Handles btnLooKonto.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        If txtTurvaVastus.Text = "" Then
            lblLooKontoEdasiViga.Text = "Parooli taasteküsimuse vastuse viga!"
            lblLooKontoEdasiViga.Visible = True
        ElseIf rdbMeesSugu.Checked = False And rdbNaisSugu.Checked = False Then
            lblLooKontoEdasiViga.Text = "Viga soo valikul!"
            lblLooKontoEdasiViga.Visible = True
        Else
            If rdbNaisSugu.Checked = True Then
                sugu = 1
            Else
                sugu = 0
            End If
            lblLooKontoEdasiViga.Visible = False
            kasutaja_id = ProfiilK.LooKonto(txtLooKontoKasutajanimi.Text, txtLooKontoSalasona.Text, txtEesnimi.Text,
                                                              cmbTurvaKüsimus.SelectedIndex, txtTurvaVastus.Text, cmbPikkus.SelectedItem, cmbKehaKaal.SelectedItem, sugu,
                                                              cmbVanus.SelectedItem)
            If kasutaja_id > 0 Then
                ResetForm()
                Me.Hide()
                Dim pohiaken As New Pohiaken(kasutaja_id)
                pohiaken.ResetForm()
                pohiaken.Show()
            Else
                lblLooKontoEdasiViga.Text = "Konto loomine ebaõnnestus!"
                lblLooKontoEdasiViga.Visible = True
            End If
        End If
    End Sub

    Private Sub lblUnustasidSalasona_Click(sender As Object, e As EventArgs) Handles lblUnustasidSalasona.Click
        pnlLogiSisse.Visible = False
        pnlUnustasinSalasona.Visible = True
    End Sub

    Private Sub lblLooKontoEdasiTagasi_Click(sender As Object, e As EventArgs) Handles lblLooKontoEdasiTagasi.Click
        pnlLooKontoEdasi.Visible = False
        pnlLooKonto.Visible = True
    End Sub

    Private Sub lblSalasonaMeenus_Click(sender As Object, e As EventArgs) Handles lblSalasonaMeenus.Click
        pnlUnustasinSalasona.Visible = False
        pnlLogiSisse.Visible = True
    End Sub
    Private Sub btnEsitaTurvaKusimuseVastus_Click(sender As Object, e As EventArgs) Handles btnEsitaTurvaKusimuseVastus.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil

        If ProfiilK.UheAndmevaljaParingKasutajaTabelist(kasutaja_id, "recovery_answer") = ProfiilK.ArvutaHash(txtUnustasinSalasonaTurvaVastus.Text) Then
            lblTurvaKusimusEdasiKasutajanimi.Text = txtUnustasinSalasonaKasutajanimi.Text
            lblTurvaKüsimuseVastuseViga.Visible = False
            lblTurvaKusimusEdasiKasutajanimi.Visible = True
            pnlUnustasinSalasona.Visible = False
            pnlUnustasinSalasonaEdasi.Visible = True
        Else
            txtTurvaVastus.Text = ""
            lblTurvaKüsimuseVastuseViga.Text = "Turvaküsimuse vastus on vale!"
            lblTurvaKüsimuseVastuseViga.Visible = True
        End If
    End Sub
    Private Sub lblUnustasinSalasonaEdasiSalasonaMeenus_Click(sender As Object, e As EventArgs) Handles lblUnustasinSalasonaEdasiSalasonaMeenus.Click
        pnlUnustasinSalasonaEdasi.Visible = False
        pnlLogiSisse.Visible = True
    End Sub
    Private Sub btnKinnitaUusSalasona_Click(sender As Object, e As EventArgs) Handles btnKinnitaUusSalasona.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        If Len(txtUnustasinSalasonaEdasiUusSalasona.Text) < 8 Then
            lblUnustasinSalasonaEdasiViga.Text = "Salasõna pikkus peab olema vähemalt 8 tähemärki!"
            lblUnustasinSalasonaEdasiViga.Visible = True
        ElseIf txtUnustasinSalasonaEdasiUusSalasona.Text <> txtUnustasinSalasonaEdasiKordaSalasona.Text Then
            lblUnustasinSalasonaEdasiViga.Text = "Salasõnad ei ühti!"
            lblUnustasinSalasonaEdasiViga.Visible = True
        Else
            ProfiilK.VahetaSalasona(kasutaja_id, txtUnustasinSalasonaEdasiUusSalasona.Text)
            lblUnustasinSalasonaEdasiViga.Visible = False
            pnlUnustasinSalasonaEdasi.Visible = False
            pnlLogiSisse.Visible = True
        End If

    End Sub

    Private Sub btnNaitaTurvakusimust_Click(sender As Object, e As EventArgs) Handles btnNaitaTurvakusimust.Click
        ProfiilK = New KasutajaProfiilKomponent.CKasutajaProfiil
        kasutaja_id = ProfiilK.KontrolliKontoOlemasolu(txtUnustasinSalasonaKasutajanimi.Text)
        If kasutaja_id = 0 Then
            lblKontotEiEksisteeri.Text = "Sisestatud kasutajanimega kontot ei eksisteeri!"
            lblKontotEiEksisteeri.Visible = True
        Else
            lblKontotEiEksisteeri.Visible = False
            lblTurvaKusimus.Text = ProfiilK.TurvaKusimuseLeidmine(kasutaja_id)
            lblTurvaKusimus.Visible = True
        End If
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

End Class



