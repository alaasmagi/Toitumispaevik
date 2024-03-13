Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports System.Data.SQLite

Public Class Login_aken

    Dim sugu As Integer
    Private Sub ResetForm()
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
        turvaKusimused()
    End Sub

    Sub turvaKusimused()
        Dim connectionString As String = "Data Source=C:\Users\alder\Documents\Toitumispaevik\database.db;Version=3;"
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            For index = 0 To 10
                Dim selectSql As String = "SELECT recovery_question FROM recovery_questions WHERE recovery_question_id = @id"

                Using cmd As New SQLiteCommand(selectSql, connection)
                    cmd.Parameters.AddWithValue("@id", index)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbTurvaKüsimus.Items.Add(reader("recovery_question"))
                        End While
                    End Using
                End Using
            Next
        End Using
        cmbTurvaKüsimus.SelectedIndex = 0
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
        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil
        If Len(txtLooKontoSalasona.Text) < 8 Then
            lblLooKontoViga.Text = "Salasõna pikkus peab olema vähemalt 8 tähemärki!"
            lblLooKontoViga.Visible = True
        ElseIf txtLooKontoSalasona.Text <> txtKordaSalasona.Text Then
            lblLooKontoViga.Text = "Salasõnad ei ühti!"
            lblLooKontoViga.Visible = True
        ElseIf profiil.KontrolliKontoOlemasolu(txtLooKontoKasutajanimi.text) = True Then
            lblLooKontoViga.Text = "Sellise kasutajanimega konto on juba olemas!"
            lblLooKontoViga.Visible = True
        Else
            lblLooKontoViga.Visible = False
            pnlLooKonto.Visible = False
            pnlLooKontoEdasi.Visible = True
        End If
    End Sub
    Private Sub btnLooKonto_Click(sender As Object, e As EventArgs) Handles btnLooKonto.Click
        If txtTurvaVastus.Text = "" Then
            lblLooKontoEdasiViga.Text = "Parooli taasteküsimuse vastuse viga!"
            lblLooKontoEdasiViga.Visible = True
        ElseIf rdbMeesSugu.Checked = False And rdbNaisSugu.Checked = False Then
            lblLooKontoEdasiViga.Text = "Viga soo valikul!"
            lblLooKontoEdasiViga.Visible = True
        Else
            lblLooKontoEdasiViga.Visible = False
            Dim profiil As New CKasutajaProfiil.CKasutajaProfiil()
            If profiil.LooKonto(txtLooKontoKasutajanimi.Text, txtLooKontoSalasona.Text, txtEesnimi.Text,
                                                              cmbTurvaKüsimus.SelectedIndex, txtTurvaVastus.Text, cmbPikkus.SelectedItem, cmbKehaKaal.SelectedItem, sugu,
                                                              cmbVanus.SelectedItem) > 0 Then
                ResetForm()
                Me.Hide()
                Pohiaken.Show()
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

    Private Sub btnNaitaTurvakusimust_Click(sender As Object, e As EventArgs) Handles btnNaitaTurvakusimust.Click
        Dim profiil As New CKasutajaProfiil.CKasutajaProfiil
        If profiil.KontrolliKontoOlemasolu(txtUnustasinSalasonaKasutajanimi.Text) = False Then
            lblKontotEiEksisteeri.Text = "Sisestatud kasutajanimega kontot ei eksisteeri!"
            lblKontotEiEksisteeri.Visible = True
        Else
            lblKontotEiEksisteeri.Visible = False
            lblTurvaKusimus.Text = profiil.TurvaKusimuseLeidmine(txtUnustasinSalasonaKasutajanimi.Text)
            lblTurvaKusimus.Visible = True
        End If
    End Sub

End Class

