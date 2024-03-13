Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports System.Data.SQLite

Public Class Login_aken

    Private Sub ResetForm()
        pnlLogoLogiSisse.Visible = True
        pnlLogiSisse.Visible = True
        pnlLooKonto.Visible = False
        pnlLooKontoEdasi.Visible = False
        pnlLooKontoEdasi2.Visible = False
        pnlUnustasinSalasona.Visible = False
        txtLogiSisseSalasona.UseSystemPasswordChar = True
        txtLooKontoSalasona.UseSystemPasswordChar = True
        txtKordaSalasona.UseSystemPasswordChar = True
        txtUnustasinSalasonaEdasiUusSalasona.UseSystemPasswordChar = True
        txtUnustasinSalasonaEdasiKordaSalasona.UseSystemPasswordChar = True
        lblLooKontoViga.Visible = False
        lblLooKontoEdasiViga.Visible = False
        lblLooKontoEdasi2Viga.Visible = False
        lblLogiSisseViga.Visible = False
        lblUnustasinSalasonaEdasiViga.Visible = False
        lblKontotEiEksisteeri.Visible = False
        lblTurvaKusimus.Visible = False
        lblTurvaKusimusEdasiKasutajanimi.Visible = False
        pnlUnustasinSalasonaEdasi.Visible = False


        'For Each pnl As Panel In Me.Controls.OfType(Of Panel)()
        'For Each ctrl As Control In pnl.Controls
        'If ctrl Is TextBox Then  ' Check type using Is
        'ctrl.Text = ""  ' Clear text box (safe casting)
        'ElseIf ctrl Is RadioButton Then
        'CType(ctrl, RadioButton).Checked = False  ' Safe casting for RadioButton
        'ElseIf ctrl Is CheckBox Then
        'CType(ctrl, CheckBox).Checked = False  ' Safe casting for CheckBox
        'End If
        'Next
        'Next


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
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ResetForm()
        Me.Hide()
        Pohiaken.Show()
    End Sub

    Private Sub btnLooKontoEdasi_Click(sender As Object, e As EventArgs) Handles btnLooKontoEdasi.Click
        pnlLooKonto.Visible = False
        pnlLooKontoEdasi.Visible = True
    End Sub
    Private Sub btnLooKontoEdasi2_Click(sender As Object, e As EventArgs) Handles btnLooKontoEdasi2.Click
        pnlLooKontoEdasi.Visible = False
        pnlLooKontoEdasi2.Visible = True
    End Sub
    Private Sub btnLooKonto_Click(sender As Object, e As EventArgs) Handles btnLooKonto.Click
        ResetForm()
        Me.Hide()
        Pohiaken.Show()
    End Sub

    Private Sub lblUnustasidSalasona_Click(sender As Object, e As EventArgs) Handles lblUnustasidSalasona.Click
        pnlLogiSisse.Visible = False
        pnlUnustasinSalasona.Visible = True
    End Sub

    Private Sub lblLooKontoEdasi2Tagasi_Click(sender As Object, e As EventArgs) Handles lblLooKontoEdasi2Tagasi.Click
        pnlLooKontoEdasi2.Visible = False
        pnlLooKontoEdasi.Visible = True
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
        pnlUnustasinSalasona.Visible = False
        pnlUnustasinSalasonaEdasi.Visible = True
    End Sub
    Private Sub lblUnustasinSalasonaEdasiSalasonaMeenus_Click(sender As Object, e As EventArgs) Handles lblUnustasinSalasonaEdasiSalasonaMeenus.Click
        pnlUnustasinSalasonaEdasi.Visible = False
        pnlLogiSisse.Visible = True
    End Sub
    Private Sub btnKinnitaUusSalasona_Click(sender As Object, e As EventArgs) Handles btnKinnitaUusSalasona.Click
        pnlUnustasinSalasonaEdasi.Visible = False
        pnlLogiSisse.Visible = True
    End Sub
End Class

