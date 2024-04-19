Imports System.Windows.Forms.DataVisualization.Charting

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pohiaken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pohiaken))
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.pnlLeftBar = New System.Windows.Forms.Panel()
        Me.btnAjalugu = New System.Windows.Forms.Button()
        Me.btnYlevaade = New System.Windows.Forms.Button()
        Me.btnTreeningud = New System.Windows.Forms.Button()
        Me.btnToidulaud = New System.Windows.Forms.Button()
        Me.pnlNuppudeTagapaneel = New System.Windows.Forms.Panel()
        Me.btnKodu = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.pbUlemineNaine = New System.Windows.Forms.PictureBox()
        Me.btnLogiValja = New System.Windows.Forms.Button()
        Me.btnProfiiliSeaded = New System.Windows.Forms.Button()
        Me.lblEesnimi = New System.Windows.Forms.Label()
        Me.pbUlemineMees = New System.Windows.Forms.PictureBox()
        Me.pnlToidulaud = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.lblRetseptiLisamineViga = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.lbRetseptiKoostisosad = New System.Windows.Forms.ListBox()
        Me.txtRetseptiKoostisosaKogus = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtRetseptiNimi = New System.Windows.Forms.TextBox()
        Me.cmbRetseptiKoostisosad = New System.Windows.Forms.ComboBox()
        Me.btnRetseptLisaKoostisosa = New System.Windows.Forms.Button()
        Me.btnKinnitaRetsept = New System.Windows.Forms.Button()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.lblToiduaineKustutamineViga = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.btnToiduaineKustutamine = New System.Windows.Forms.Button()
        Me.cmbToiduaineKustutamine = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblUueToiduaineLisamineViga = New System.Windows.Forms.Label()
        Me.txtUueToiduaineRasvad = New System.Windows.Forms.TextBox()
        Me.txtUueToiduaineSuhkrud = New System.Windows.Forms.TextBox()
        Me.txtUueToiduaineKcal = New System.Windows.Forms.TextBox()
        Me.txtUueToiduaineSusivesikud = New System.Windows.Forms.TextBox()
        Me.txtUueToiduaineValgud = New System.Windows.Forms.TextBox()
        Me.txtUueToiduaineNimi = New System.Windows.Forms.TextBox()
        Me.btnLisaUusToiduaine = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlRakenduseInfo = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnklblCarmen = New System.Windows.Forms.LinkLabel()
        Me.lnklblEeva = New System.Windows.Forms.LinkLabel()
        Me.lnklblKris = New System.Windows.Forms.LinkLabel()
        Me.lnklblAleks = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlKodu = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.lblTreeninguKiirvalikViga = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btnTreeninguKiirvalikLisa = New System.Windows.Forms.Button()
        Me.txtTreeninguKiirvalikKestus = New System.Windows.Forms.TextBox()
        Me.cmbTreeninguteKiirvalik = New System.Windows.Forms.ComboBox()
        Me.lblKcalPaev = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chbMukbangFilter = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblToiduAineRetseptiLisamineViga = New System.Windows.Forms.Label()
        Me.rdbOhtu = New System.Windows.Forms.RadioButton()
        Me.rdbVahepala = New System.Windows.Forms.RadioButton()
        Me.rdbLouna = New System.Windows.Forms.RadioButton()
        Me.rdbHommik = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnToiduaineKiirvalikLisa = New System.Windows.Forms.Button()
        Me.txtToiduaineKiirvalikKogus = New System.Windows.Forms.TextBox()
        Me.cmbToiduaineKiirvalik = New System.Windows.Forms.ComboBox()
        Me.chrKoduPaneel = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblKoduEesnimi = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblPaevaneTarbimine = New System.Windows.Forms.Label()
        Me.pnlTreeningud = New System.Windows.Forms.Panel()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblKustutaTreeningViga = New System.Windows.Forms.Label()
        Me.btnKustutaTreening = New System.Windows.Forms.Button()
        Me.cmbTreeninguKustutamine = New System.Windows.Forms.ComboBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lblTreeninguLisamineViga = New System.Windows.Forms.Label()
        Me.txtTreeninguLisamineEnergialkulu = New System.Windows.Forms.TextBox()
        Me.txtTreeninguLisamineNimi = New System.Windows.Forms.TextBox()
        Me.btnTreeninguLisamine = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlYlevaade = New System.Windows.Forms.Panel()
        Me.Kaal = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtKaaluEesmärk = New System.Windows.Forms.TextBox()
        Me.btnEesmargiKinnitamine = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtPaevaneKaal = New System.Windows.Forms.TextBox()
        Me.btnPaevaneKaal = New System.Windows.Forms.Button()
        Me.chrKaaluMuutumine = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNaitaYlevaadet = New System.Windows.Forms.Button()
        Me.cmbAjaluguGraafikuPeriood = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chrYlevaade = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlAjalugu = New System.Windows.Forms.Panel()
        Me.chrAjalooPaneel = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.lvPaevasedTreeningud = New System.Windows.Forms.ListView()
        Me.treeninguNimi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.treeninguKalorid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.treeninguKestus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPaevasedToidud = New System.Windows.Forms.ListView()
        Me.toiduKord = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.toiduNimetus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.toiduKcal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAjalooKuupaevTagasi = New System.Windows.Forms.Button()
        Me.bntAjalooKuupaevEdasi = New System.Windows.Forms.Button()
        Me.lblAjaluguNadalaPaev = New System.Windows.Forms.Label()
        Me.lblAjaluguKuupaev = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblProfiiliSeadedEesnimi = New System.Windows.Forms.Label()
        Me.lblProfiiliSeadedKasutajanimi = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbMuudaPikkust = New System.Windows.Forms.ComboBox()
        Me.btnMuudaPikkust = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblKasutajaPikkus = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbMuudaKaalu = New System.Windows.Forms.ComboBox()
        Me.btnMuudaKaalu = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblKasutajaKaal = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbMuudaVanust = New System.Windows.Forms.ComboBox()
        Me.btnMuudaVanust = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblKasutajaVanus = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtKehtivSalasona = New System.Windows.Forms.TextBox()
        Me.lblVahetaSalasonaViga = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKinnitaUusSalasona = New System.Windows.Forms.Button()
        Me.txtVahetaSalasona = New System.Windows.Forms.TextBox()
        Me.txtKordaSalasona = New System.Windows.Forms.TextBox()
        Me.pnlProfiiliSeaded = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblKaloriLimiitViga = New System.Windows.Forms.Label()
        Me.btnKaloriLimiit = New System.Windows.Forms.Button()
        Me.txtKalorilimiit = New System.Windows.Forms.TextBox()
        Me.pbAlumineMees = New System.Windows.Forms.PictureBox()
        Me.pbAlumineNaine = New System.Windows.Forms.PictureBox()
        Me.pnlLeftBar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.pbUlemineNaine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUlemineMees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToidulaud.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.pnlRakenduseInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKodu.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.chrKoduPaneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTreeningud.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.pnlYlevaade.SuspendLayout()
        Me.Kaal.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.chrKaaluMuutumine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chrYlevaade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAjalugu.SuspendLayout()
        CType(Me.chrAjalooPaneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.pnlProfiiliSeaded.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.pbAlumineMees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAlumineNaine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeftBar
        '
        Me.pnlLeftBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlLeftBar.Controls.Add(Me.btnAjalugu)
        Me.pnlLeftBar.Controls.Add(Me.btnYlevaade)
        Me.pnlLeftBar.Controls.Add(Me.btnTreeningud)
        Me.pnlLeftBar.Controls.Add(Me.btnToidulaud)
        Me.pnlLeftBar.Controls.Add(Me.pnlNuppudeTagapaneel)
        Me.pnlLeftBar.Controls.Add(Me.btnKodu)
        Me.pnlLeftBar.Controls.Add(Me.pnlLogo)
        Me.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftBar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftBar.Name = "pnlLeftBar"
        Me.pnlLeftBar.Size = New System.Drawing.Size(232, 563)
        Me.pnlLeftBar.TabIndex = 0
        '
        'btnAjalugu
        '
        Me.btnAjalugu.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAjalugu.FlatAppearance.BorderSize = 0
        Me.btnAjalugu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnAjalugu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjalugu.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjalugu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAjalugu.Image = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_history_22
        Me.btnAjalugu.Location = New System.Drawing.Point(0, 335)
        Me.btnAjalugu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAjalugu.Name = "btnAjalugu"
        Me.btnAjalugu.Size = New System.Drawing.Size(232, 76)
        Me.btnAjalugu.TabIndex = 8
        Me.btnAjalugu.Text = " Ajalugu"
        Me.btnAjalugu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjalugu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjalugu.UseVisualStyleBackColor = False
        '
        'btnYlevaade
        '
        Me.btnYlevaade.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnYlevaade.FlatAppearance.BorderSize = 0
        Me.btnYlevaade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnYlevaade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYlevaade.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYlevaade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnYlevaade.Image = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_overview_22__1_
        Me.btnYlevaade.Location = New System.Drawing.Point(0, 258)
        Me.btnYlevaade.Margin = New System.Windows.Forms.Padding(2)
        Me.btnYlevaade.Name = "btnYlevaade"
        Me.btnYlevaade.Size = New System.Drawing.Size(232, 76)
        Me.btnYlevaade.TabIndex = 9
        Me.btnYlevaade.Text = " Ülevaade"
        Me.btnYlevaade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnYlevaade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnYlevaade.UseVisualStyleBackColor = False
        '
        'btnTreeningud
        '
        Me.btnTreeningud.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTreeningud.FlatAppearance.BorderSize = 0
        Me.btnTreeningud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnTreeningud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreeningud.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreeningud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnTreeningud.Image = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_dumbbell_22__1_
        Me.btnTreeningud.Location = New System.Drawing.Point(0, 181)
        Me.btnTreeningud.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTreeningud.Name = "btnTreeningud"
        Me.btnTreeningud.Size = New System.Drawing.Size(232, 76)
        Me.btnTreeningud.TabIndex = 10
        Me.btnTreeningud.Text = " Treeningud"
        Me.btnTreeningud.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTreeningud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTreeningud.UseVisualStyleBackColor = False
        '
        'btnToidulaud
        '
        Me.btnToidulaud.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnToidulaud.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnToidulaud.FlatAppearance.BorderSize = 0
        Me.btnToidulaud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnToidulaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToidulaud.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToidulaud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnToidulaud.Image = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_cutlery_22__1_
        Me.btnToidulaud.Location = New System.Drawing.Point(0, 104)
        Me.btnToidulaud.Margin = New System.Windows.Forms.Padding(2)
        Me.btnToidulaud.Name = "btnToidulaud"
        Me.btnToidulaud.Size = New System.Drawing.Size(232, 76)
        Me.btnToidulaud.TabIndex = 8
        Me.btnToidulaud.Text = " Toidulaud"
        Me.btnToidulaud.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnToidulaud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnToidulaud.UseVisualStyleBackColor = False
        '
        'pnlNuppudeTagapaneel
        '
        Me.pnlNuppudeTagapaneel.BackColor = System.Drawing.Color.Silver
        Me.pnlNuppudeTagapaneel.Location = New System.Drawing.Point(46, 110)
        Me.pnlNuppudeTagapaneel.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlNuppudeTagapaneel.Name = "pnlNuppudeTagapaneel"
        Me.pnlNuppudeTagapaneel.Size = New System.Drawing.Size(142, 300)
        Me.pnlNuppudeTagapaneel.TabIndex = 11
        '
        'btnKodu
        '
        Me.btnKodu.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnKodu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnKodu.FlatAppearance.BorderSize = 0
        Me.btnKodu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnKodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKodu.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKodu.ForeColor = System.Drawing.Color.White
        Me.btnKodu.Image = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_home_button_54
        Me.btnKodu.Location = New System.Drawing.Point(0, 500)
        Me.btnKodu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKodu.Name = "btnKodu"
        Me.btnKodu.Size = New System.Drawing.Size(232, 76)
        Me.btnKodu.TabIndex = 7
        Me.btnKodu.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.taissuuruses_logo_taustata_väike
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(232, 100)
        Me.pnlLogo.TabIndex = 2
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.pbUlemineNaine)
        Me.pnlTopBar.Controls.Add(Me.btnLogiValja)
        Me.pnlTopBar.Controls.Add(Me.btnProfiiliSeaded)
        Me.pnlTopBar.Controls.Add(Me.lblEesnimi)
        Me.pnlTopBar.Controls.Add(Me.pbUlemineMees)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(232, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(833, 100)
        Me.pnlTopBar.TabIndex = 1
        '
        'pbUlemineNaine
        '
        Me.pbUlemineNaine.Image = CType(resources.GetObject("pbUlemineNaine.Image"), System.Drawing.Image)
        Me.pbUlemineNaine.Location = New System.Drawing.Point(26, 26)
        Me.pbUlemineNaine.Margin = New System.Windows.Forms.Padding(2)
        Me.pbUlemineNaine.Name = "pbUlemineNaine"
        Me.pbUlemineNaine.Size = New System.Drawing.Size(54, 50)
        Me.pbUlemineNaine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUlemineNaine.TabIndex = 4
        Me.pbUlemineNaine.TabStop = False
        Me.pbUlemineNaine.Visible = False
        '
        'btnLogiValja
        '
        Me.btnLogiValja.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnLogiValja.FlatAppearance.BorderSize = 0
        Me.btnLogiValja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnLogiValja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogiValja.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogiValja.ForeColor = System.Drawing.Color.White
        Me.btnLogiValja.Location = New System.Drawing.Point(674, 0)
        Me.btnLogiValja.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogiValja.Name = "btnLogiValja"
        Me.btnLogiValja.Size = New System.Drawing.Size(178, 100)
        Me.btnLogiValja.TabIndex = 2
        Me.btnLogiValja.Text = "Logi välja"
        Me.btnLogiValja.UseVisualStyleBackColor = False
        '
        'btnProfiiliSeaded
        '
        Me.btnProfiiliSeaded.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnProfiiliSeaded.FlatAppearance.BorderSize = 0
        Me.btnProfiiliSeaded.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnProfiiliSeaded.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfiiliSeaded.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfiiliSeaded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnProfiiliSeaded.Location = New System.Drawing.Point(498, 0)
        Me.btnProfiiliSeaded.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProfiiliSeaded.Name = "btnProfiiliSeaded"
        Me.btnProfiiliSeaded.Size = New System.Drawing.Size(178, 100)
        Me.btnProfiiliSeaded.TabIndex = 3
        Me.btnProfiiliSeaded.Text = "Profiili seaded"
        Me.btnProfiiliSeaded.UseVisualStyleBackColor = False
        '
        'lblEesnimi
        '
        Me.lblEesnimi.AutoSize = True
        Me.lblEesnimi.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEesnimi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lblEesnimi.Location = New System.Drawing.Point(86, 38)
        Me.lblEesnimi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEesnimi.Name = "lblEesnimi"
        Me.lblEesnimi.Size = New System.Drawing.Size(68, 21)
        Me.lblEesnimi.TabIndex = 2
        Me.lblEesnimi.Text = "Eesnimi"
        '
        'pbUlemineMees
        '
        Me.pbUlemineMees.Image = CType(resources.GetObject("pbUlemineMees.Image"), System.Drawing.Image)
        Me.pbUlemineMees.Location = New System.Drawing.Point(26, 26)
        Me.pbUlemineMees.Margin = New System.Windows.Forms.Padding(2)
        Me.pbUlemineMees.Name = "pbUlemineMees"
        Me.pbUlemineMees.Size = New System.Drawing.Size(54, 50)
        Me.pbUlemineMees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUlemineMees.TabIndex = 2
        Me.pbUlemineMees.TabStop = False
        Me.pbUlemineMees.Visible = False
        '
        'pnlToidulaud
        '
        Me.pnlToidulaud.Controls.Add(Me.GroupBox14)
        Me.pnlToidulaud.Controls.Add(Me.GroupBox13)
        Me.pnlToidulaud.Controls.Add(Me.GroupBox7)
        Me.pnlToidulaud.Controls.Add(Me.Label15)
        Me.pnlToidulaud.Location = New System.Drawing.Point(232, 100)
        Me.pnlToidulaud.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlToidulaud.Name = "pnlToidulaud"
        Me.pnlToidulaud.Size = New System.Drawing.Size(840, 481)
        Me.pnlToidulaud.TabIndex = 2
        Me.pnlToidulaud.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.lblRetseptiLisamineViga)
        Me.GroupBox14.Controls.Add(Me.Label56)
        Me.GroupBox14.Controls.Add(Me.Label53)
        Me.GroupBox14.Controls.Add(Me.lbRetseptiKoostisosad)
        Me.GroupBox14.Controls.Add(Me.txtRetseptiKoostisosaKogus)
        Me.GroupBox14.Controls.Add(Me.Label40)
        Me.GroupBox14.Controls.Add(Me.Label22)
        Me.GroupBox14.Controls.Add(Me.txtRetseptiNimi)
        Me.GroupBox14.Controls.Add(Me.cmbRetseptiKoostisosad)
        Me.GroupBox14.Controls.Add(Me.btnRetseptLisaKoostisosa)
        Me.GroupBox14.Controls.Add(Me.btnKinnitaRetsept)
        Me.GroupBox14.Location = New System.Drawing.Point(378, 66)
        Me.GroupBox14.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox14.Size = New System.Drawing.Size(450, 211)
        Me.GroupBox14.TabIndex = 31
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Retsepti lisamine andmebaasi"
        '
        'lblRetseptiLisamineViga
        '
        Me.lblRetseptiLisamineViga.AutoSize = True
        Me.lblRetseptiLisamineViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetseptiLisamineViga.ForeColor = System.Drawing.Color.Red
        Me.lblRetseptiLisamineViga.Location = New System.Drawing.Point(24, 179)
        Me.lblRetseptiLisamineViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRetseptiLisamineViga.Name = "lblRetseptiLisamineViga"
        Me.lblRetseptiLisamineViga.Size = New System.Drawing.Size(50, 21)
        Me.lblRetseptiLisamineViga.TabIndex = 42
        Me.lblRetseptiLisamineViga.Text = "VIGA"
        Me.lblRetseptiLisamineViga.Visible = False
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(12, 136)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(59, 19)
        Me.Label56.TabIndex = 38
        Me.Label56.Text = "Kogus:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(137, 141)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(20, 19)
        Me.Label53.TabIndex = 41
        Me.Label53.Text = "g"
        '
        'lbRetseptiKoostisosad
        '
        Me.lbRetseptiKoostisosad.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lbRetseptiKoostisosad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbRetseptiKoostisosad.FormattingEnabled = True
        Me.lbRetseptiKoostisosad.ItemHeight = 19
        Me.lbRetseptiKoostisosad.Location = New System.Drawing.Point(254, 24)
        Me.lbRetseptiKoostisosad.Margin = New System.Windows.Forms.Padding(2)
        Me.lbRetseptiKoostisosad.Name = "lbRetseptiKoostisosad"
        Me.lbRetseptiKoostisosad.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbRetseptiKoostisosad.Size = New System.Drawing.Size(182, 95)
        Me.lbRetseptiKoostisosad.TabIndex = 40
        '
        'txtRetseptiKoostisosaKogus
        '
        Me.txtRetseptiKoostisosaKogus.Location = New System.Drawing.Point(72, 133)
        Me.txtRetseptiKoostisosaKogus.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtRetseptiKoostisosaKogus.Name = "txtRetseptiKoostisosaKogus"
        Me.txtRetseptiKoostisosaKogus.Size = New System.Drawing.Size(64, 27)
        Me.txtRetseptiKoostisosaKogus.TabIndex = 39
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(48, 73)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(158, 19)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "Koostisosa lisamine"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(8, 33)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 19)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Nimi:"
        '
        'txtRetseptiNimi
        '
        Me.txtRetseptiNimi.Location = New System.Drawing.Point(61, 31)
        Me.txtRetseptiNimi.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtRetseptiNimi.Name = "txtRetseptiNimi"
        Me.txtRetseptiNimi.Size = New System.Drawing.Size(177, 27)
        Me.txtRetseptiNimi.TabIndex = 36
        '
        'cmbRetseptiKoostisosad
        '
        Me.cmbRetseptiKoostisosad.DropDownHeight = 100
        Me.cmbRetseptiKoostisosad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRetseptiKoostisosad.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRetseptiKoostisosad.FormattingEnabled = True
        Me.cmbRetseptiKoostisosad.IntegralHeight = False
        Me.cmbRetseptiKoostisosad.ItemHeight = 18
        Me.cmbRetseptiKoostisosad.Location = New System.Drawing.Point(13, 94)
        Me.cmbRetseptiKoostisosad.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRetseptiKoostisosad.Name = "cmbRetseptiKoostisosad"
        Me.cmbRetseptiKoostisosad.Size = New System.Drawing.Size(225, 26)
        Me.cmbRetseptiKoostisosad.TabIndex = 32
        '
        'btnRetseptLisaKoostisosa
        '
        Me.btnRetseptLisaKoostisosa.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRetseptLisaKoostisosa.FlatAppearance.BorderSize = 0
        Me.btnRetseptLisaKoostisosa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnRetseptLisaKoostisosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetseptLisaKoostisosa.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetseptLisaKoostisosa.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRetseptLisaKoostisosa.Location = New System.Drawing.Point(161, 133)
        Me.btnRetseptLisaKoostisosa.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnRetseptLisaKoostisosa.Name = "btnRetseptLisaKoostisosa"
        Me.btnRetseptLisaKoostisosa.Size = New System.Drawing.Size(76, 28)
        Me.btnRetseptLisaKoostisosa.TabIndex = 31
        Me.btnRetseptLisaKoostisosa.Text = "Lisa"
        Me.btnRetseptLisaKoostisosa.UseVisualStyleBackColor = False
        '
        'btnKinnitaRetsept
        '
        Me.btnKinnitaRetsept.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnKinnitaRetsept.FlatAppearance.BorderSize = 0
        Me.btnKinnitaRetsept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnKinnitaRetsept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKinnitaRetsept.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKinnitaRetsept.ForeColor = System.Drawing.SystemColors.Window
        Me.btnKinnitaRetsept.Location = New System.Drawing.Point(254, 170)
        Me.btnKinnitaRetsept.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnKinnitaRetsept.Name = "btnKinnitaRetsept"
        Me.btnKinnitaRetsept.Size = New System.Drawing.Size(182, 28)
        Me.btnKinnitaRetsept.TabIndex = 30
        Me.btnKinnitaRetsept.Text = "Kinnita retsept"
        Me.btnKinnitaRetsept.UseVisualStyleBackColor = False
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.lblToiduaineKustutamineViga)
        Me.GroupBox13.Controls.Add(Me.Label55)
        Me.GroupBox13.Controls.Add(Me.btnToiduaineKustutamine)
        Me.GroupBox13.Controls.Add(Me.cmbToiduaineKustutamine)
        Me.GroupBox13.Location = New System.Drawing.Point(378, 286)
        Me.GroupBox13.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox13.Size = New System.Drawing.Size(450, 179)
        Me.GroupBox13.TabIndex = 30
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Toiduaine/retsepti kustutamine andmebaasist"
        '
        'lblToiduaineKustutamineViga
        '
        Me.lblToiduaineKustutamineViga.AutoSize = True
        Me.lblToiduaineKustutamineViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToiduaineKustutamineViga.ForeColor = System.Drawing.Color.Red
        Me.lblToiduaineKustutamineViga.Location = New System.Drawing.Point(42, 145)
        Me.lblToiduaineKustutamineViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToiduaineKustutamineViga.Name = "lblToiduaineKustutamineViga"
        Me.lblToiduaineKustutamineViga.Size = New System.Drawing.Size(50, 21)
        Me.lblToiduaineKustutamineViga.TabIndex = 36
        Me.lblToiduaineKustutamineViga.Text = "VIGA"
        Me.lblToiduaineKustutamineViga.Visible = False
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(42, 62)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(79, 19)
        Me.Label55.TabIndex = 30
        Me.Label55.Text = "Nimetus:"
        '
        'btnToiduaineKustutamine
        '
        Me.btnToiduaineKustutamine.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnToiduaineKustutamine.FlatAppearance.BorderSize = 0
        Me.btnToiduaineKustutamine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnToiduaineKustutamine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToiduaineKustutamine.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToiduaineKustutamine.ForeColor = System.Drawing.SystemColors.Window
        Me.btnToiduaineKustutamine.Location = New System.Drawing.Point(45, 99)
        Me.btnToiduaineKustutamine.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnToiduaineKustutamine.Name = "btnToiduaineKustutamine"
        Me.btnToiduaineKustutamine.Size = New System.Drawing.Size(355, 35)
        Me.btnToiduaineKustutamine.TabIndex = 29
        Me.btnToiduaineKustutamine.Text = "Kustuta toiduaine/retsept"
        Me.btnToiduaineKustutamine.UseVisualStyleBackColor = False
        '
        'cmbToiduaineKustutamine
        '
        Me.cmbToiduaineKustutamine.DropDownHeight = 100
        Me.cmbToiduaineKustutamine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToiduaineKustutamine.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbToiduaineKustutamine.FormattingEnabled = True
        Me.cmbToiduaineKustutamine.IntegralHeight = False
        Me.cmbToiduaineKustutamine.ItemHeight = 18
        Me.cmbToiduaineKustutamine.Location = New System.Drawing.Point(122, 60)
        Me.cmbToiduaineKustutamine.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbToiduaineKustutamine.Name = "cmbToiduaineKustutamine"
        Me.cmbToiduaineKustutamine.Size = New System.Drawing.Size(278, 26)
        Me.cmbToiduaineKustutamine.TabIndex = 24
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.Label38)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.lblUueToiduaineLisamineViga)
        Me.GroupBox7.Controls.Add(Me.txtUueToiduaineRasvad)
        Me.GroupBox7.Controls.Add(Me.txtUueToiduaineSuhkrud)
        Me.GroupBox7.Controls.Add(Me.txtUueToiduaineKcal)
        Me.GroupBox7.Controls.Add(Me.txtUueToiduaineSusivesikud)
        Me.GroupBox7.Controls.Add(Me.txtUueToiduaineValgud)
        Me.GroupBox7.Controls.Add(Me.txtUueToiduaineNimi)
        Me.GroupBox7.Controls.Add(Me.btnLisaUusToiduaine)
        Me.GroupBox7.Location = New System.Drawing.Point(26, 66)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(328, 399)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Toiduaine lisamine andmebaasi"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(178, 288)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(65, 19)
        Me.Label39.TabIndex = 45
        Me.Label39.Text = "g/100g"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(178, 244)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(65, 19)
        Me.Label38.TabIndex = 44
        Me.Label38.Text = "g/100g"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(178, 192)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(65, 19)
        Me.Label37.TabIndex = 43
        Me.Label37.Text = "g/100g"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(178, 144)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(65, 19)
        Me.Label36.TabIndex = 42
        Me.Label36.Text = "g/100g"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(182, 96)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(87, 19)
        Me.Label35.TabIndex = 41
        Me.Label35.Text = "kcal/100g"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(34, 284)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 19)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "Rasvad:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(34, 238)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 19)
        Me.Label33.TabIndex = 39
        Me.Label33.Text = "Valgud:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(36, 188)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 19)
        Me.Label32.TabIndex = 38
        Me.Label32.Text = "Suhkrud:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(12, 138)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 19)
        Me.Label31.TabIndex = 37
        Me.Label31.Text = "Süsivesikud:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(36, 90)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 19)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Energia:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(26, 44)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(79, 19)
        Me.Label29.TabIndex = 35
        Me.Label29.Text = "Nimetus:"
        '
        'lblUueToiduaineLisamineViga
        '
        Me.lblUueToiduaineLisamineViga.AutoSize = True
        Me.lblUueToiduaineLisamineViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUueToiduaineLisamineViga.ForeColor = System.Drawing.Color.Red
        Me.lblUueToiduaineLisamineViga.Location = New System.Drawing.Point(20, 365)
        Me.lblUueToiduaineLisamineViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUueToiduaineLisamineViga.Name = "lblUueToiduaineLisamineViga"
        Me.lblUueToiduaineLisamineViga.Size = New System.Drawing.Size(50, 21)
        Me.lblUueToiduaineLisamineViga.TabIndex = 34
        Me.lblUueToiduaineLisamineViga.Text = "VIGA"
        Me.lblUueToiduaineLisamineViga.Visible = False
        '
        'txtUueToiduaineRasvad
        '
        Me.txtUueToiduaineRasvad.Location = New System.Drawing.Point(126, 280)
        Me.txtUueToiduaineRasvad.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUueToiduaineRasvad.Name = "txtUueToiduaineRasvad"
        Me.txtUueToiduaineRasvad.Size = New System.Drawing.Size(52, 27)
        Me.txtUueToiduaineRasvad.TabIndex = 33
        '
        'txtUueToiduaineSuhkrud
        '
        Me.txtUueToiduaineSuhkrud.Location = New System.Drawing.Point(124, 184)
        Me.txtUueToiduaineSuhkrud.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUueToiduaineSuhkrud.Name = "txtUueToiduaineSuhkrud"
        Me.txtUueToiduaineSuhkrud.Size = New System.Drawing.Size(54, 27)
        Me.txtUueToiduaineSuhkrud.TabIndex = 32
        '
        'txtUueToiduaineKcal
        '
        Me.txtUueToiduaineKcal.Location = New System.Drawing.Point(124, 88)
        Me.txtUueToiduaineKcal.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUueToiduaineKcal.Name = "txtUueToiduaineKcal"
        Me.txtUueToiduaineKcal.Size = New System.Drawing.Size(56, 27)
        Me.txtUueToiduaineKcal.TabIndex = 31
        '
        'txtUueToiduaineSusivesikud
        '
        Me.txtUueToiduaineSusivesikud.Location = New System.Drawing.Point(124, 136)
        Me.txtUueToiduaineSusivesikud.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUueToiduaineSusivesikud.Name = "txtUueToiduaineSusivesikud"
        Me.txtUueToiduaineSusivesikud.Size = New System.Drawing.Size(54, 27)
        Me.txtUueToiduaineSusivesikud.TabIndex = 30
        '
        'txtUueToiduaineValgud
        '
        Me.txtUueToiduaineValgud.Location = New System.Drawing.Point(124, 236)
        Me.txtUueToiduaineValgud.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUueToiduaineValgud.Name = "txtUueToiduaineValgud"
        Me.txtUueToiduaineValgud.Size = New System.Drawing.Size(54, 27)
        Me.txtUueToiduaineValgud.TabIndex = 29
        '
        'txtUueToiduaineNimi
        '
        Me.txtUueToiduaineNimi.Location = New System.Drawing.Point(124, 40)
        Me.txtUueToiduaineNimi.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtUueToiduaineNimi.Name = "txtUueToiduaineNimi"
        Me.txtUueToiduaineNimi.Size = New System.Drawing.Size(168, 27)
        Me.txtUueToiduaineNimi.TabIndex = 27
        '
        'btnLisaUusToiduaine
        '
        Me.btnLisaUusToiduaine.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLisaUusToiduaine.FlatAppearance.BorderSize = 0
        Me.btnLisaUusToiduaine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnLisaUusToiduaine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLisaUusToiduaine.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLisaUusToiduaine.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLisaUusToiduaine.Location = New System.Drawing.Point(24, 319)
        Me.btnLisaUusToiduaine.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnLisaUusToiduaine.Name = "btnLisaUusToiduaine"
        Me.btnLisaUusToiduaine.Size = New System.Drawing.Size(276, 34)
        Me.btnLisaUusToiduaine.TabIndex = 28
        Me.btnLisaUusToiduaine.Text = "Lisa"
        Me.btnLisaUusToiduaine.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(22, 30)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 30)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Toidulaud"
        '
        'pnlRakenduseInfo
        '
        Me.pnlRakenduseInfo.Controls.Add(Me.Label12)
        Me.pnlRakenduseInfo.Controls.Add(Me.Label10)
        Me.pnlRakenduseInfo.Controls.Add(Me.Label9)
        Me.pnlRakenduseInfo.Controls.Add(Me.Label8)
        Me.pnlRakenduseInfo.Controls.Add(Me.Label11)
        Me.pnlRakenduseInfo.Controls.Add(Me.Label7)
        Me.pnlRakenduseInfo.Controls.Add(Me.GroupBox1)
        Me.pnlRakenduseInfo.Controls.Add(Me.PictureBox2)
        Me.pnlRakenduseInfo.Location = New System.Drawing.Point(232, 100)
        Me.pnlRakenduseInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlRakenduseInfo.Name = "pnlRakenduseInfo"
        Me.pnlRakenduseInfo.Size = New System.Drawing.Size(836, 474)
        Me.pnlRakenduseInfo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(320, 166)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 21)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Results"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(320, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Activity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(320, 106)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nutrition"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(320, 78)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Accountability"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(322, 46)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 21)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Journey"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(734, 498)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "TalTech 2024"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnklblCarmen)
        Me.GroupBox1.Controls.Add(Me.lnklblEeva)
        Me.GroupBox1.Controls.Add(Me.lnklblKris)
        Me.GroupBox1.Controls.Add(Me.lnklblAleks)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(27, 225)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(458, 240)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arendajad"
        '
        'lnklblCarmen
        '
        Me.lnklblCarmen.AutoSize = True
        Me.lnklblCarmen.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblCarmen.Location = New System.Drawing.Point(294, 150)
        Me.lnklblCarmen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblCarmen.Name = "lnklblCarmen"
        Me.lnklblCarmen.Size = New System.Drawing.Size(139, 19)
        Me.lnklblCarmen.TabIndex = 7
        Me.lnklblCarmen.TabStop = True
        Me.lnklblCarmen.Text = "Carmeni GitHub"
        '
        'lnklblEeva
        '
        Me.lnklblEeva.AutoSize = True
        Me.lnklblEeva.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblEeva.Location = New System.Drawing.Point(272, 188)
        Me.lnklblEeva.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblEeva.Name = "lnklblEeva"
        Me.lnklblEeva.Size = New System.Drawing.Size(160, 19)
        Me.lnklblEeva.TabIndex = 6
        Me.lnklblEeva.TabStop = True
        Me.lnklblEeva.Text = "Eeva-Maria GitHub"
        '
        'lnklblKris
        '
        Me.lnklblKris.AutoSize = True
        Me.lnklblKris.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblKris.Location = New System.Drawing.Point(294, 110)
        Me.lnklblKris.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblKris.Name = "lnklblKris"
        Me.lnklblKris.Size = New System.Drawing.Size(137, 19)
        Me.lnklblKris.TabIndex = 5
        Me.lnklblKris.TabStop = True
        Me.lnklblKris.Text = "Kristoferi GitHub"
        '
        'lnklblAleks
        '
        Me.lnklblAleks.AutoSize = True
        Me.lnklblAleks.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblAleks.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblAleks.Location = New System.Drawing.Point(282, 74)
        Me.lnklblAleks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblAleks.Name = "lnklblAleks"
        Me.lnklblAleks.Size = New System.Drawing.Size(151, 19)
        Me.lnklblAleks.TabIndex = 4
        Me.lnklblAleks.TabStop = True
        Me.lnklblAleks.Text = "Aleksandri GitHub"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Eeva-Maria Tšernova"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Carmen Raun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Kristofer Mäeots"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Aleksander Laasmägi"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.taissuuruses_logo_taustata_väike
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(28, 46)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(270, 150)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'pnlKodu
        '
        Me.pnlKodu.Controls.Add(Me.GroupBox10)
        Me.pnlKodu.Controls.Add(Me.lblKcalPaev)
        Me.pnlKodu.Controls.Add(Me.GroupBox8)
        Me.pnlKodu.Controls.Add(Me.chrKoduPaneel)
        Me.pnlKodu.Controls.Add(Me.lblKoduEesnimi)
        Me.pnlKodu.Controls.Add(Me.Label13)
        Me.pnlKodu.Location = New System.Drawing.Point(232, 100)
        Me.pnlKodu.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlKodu.Name = "pnlKodu"
        Me.pnlKodu.Size = New System.Drawing.Size(846, 481)
        Me.pnlKodu.TabIndex = 11
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label47)
        Me.GroupBox10.Controls.Add(Me.lblTreeninguKiirvalikViga)
        Me.GroupBox10.Controls.Add(Me.Label41)
        Me.GroupBox10.Controls.Add(Me.Label42)
        Me.GroupBox10.Controls.Add(Me.btnTreeninguKiirvalikLisa)
        Me.GroupBox10.Controls.Add(Me.txtTreeninguKiirvalikKestus)
        Me.GroupBox10.Controls.Add(Me.cmbTreeninguteKiirvalik)
        Me.GroupBox10.Location = New System.Drawing.Point(468, 295)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox10.Size = New System.Drawing.Size(358, 157)
        Me.GroupBox10.TabIndex = 37
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Treeningsessiooni lisamine"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(170, 92)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(39, 19)
        Me.Label47.TabIndex = 37
        Me.Label47.Text = "min"
        '
        'lblTreeninguKiirvalikViga
        '
        Me.lblTreeninguKiirvalikViga.AutoSize = True
        Me.lblTreeninguKiirvalikViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreeninguKiirvalikViga.ForeColor = System.Drawing.Color.Red
        Me.lblTreeninguKiirvalikViga.Location = New System.Drawing.Point(160, 131)
        Me.lblTreeninguKiirvalikViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTreeninguKiirvalikViga.Name = "lblTreeninguKiirvalikViga"
        Me.lblTreeninguKiirvalikViga.Size = New System.Drawing.Size(50, 21)
        Me.lblTreeninguKiirvalikViga.TabIndex = 36
        Me.lblTreeninguKiirvalikViga.Text = "VIGA"
        Me.lblTreeninguKiirvalikViga.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(54, 90)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(62, 19)
        Me.Label41.TabIndex = 31
        Me.Label41.Text = "Kestus:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(38, 44)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(79, 19)
        Me.Label42.TabIndex = 30
        Me.Label42.Text = "Nimetus:"
        '
        'btnTreeninguKiirvalikLisa
        '
        Me.btnTreeninguKiirvalikLisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnTreeninguKiirvalikLisa.FlatAppearance.BorderSize = 0
        Me.btnTreeninguKiirvalikLisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnTreeninguKiirvalikLisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreeninguKiirvalikLisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreeninguKiirvalikLisa.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTreeninguKiirvalikLisa.Location = New System.Drawing.Point(238, 86)
        Me.btnTreeninguKiirvalikLisa.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnTreeninguKiirvalikLisa.Name = "btnTreeninguKiirvalikLisa"
        Me.btnTreeninguKiirvalikLisa.Size = New System.Drawing.Size(86, 28)
        Me.btnTreeninguKiirvalikLisa.TabIndex = 26
        Me.btnTreeninguKiirvalikLisa.Text = "Lisa"
        Me.btnTreeninguKiirvalikLisa.UseVisualStyleBackColor = False
        '
        'txtTreeninguKiirvalikKestus
        '
        Me.txtTreeninguKiirvalikKestus.Location = New System.Drawing.Point(118, 86)
        Me.txtTreeninguKiirvalikKestus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTreeninguKiirvalikKestus.Name = "txtTreeninguKiirvalikKestus"
        Me.txtTreeninguKiirvalikKestus.Size = New System.Drawing.Size(52, 27)
        Me.txtTreeninguKiirvalikKestus.TabIndex = 25
        '
        'cmbTreeninguteKiirvalik
        '
        Me.cmbTreeninguteKiirvalik.DropDownHeight = 100
        Me.cmbTreeninguteKiirvalik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTreeninguteKiirvalik.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTreeninguteKiirvalik.FormattingEnabled = True
        Me.cmbTreeninguteKiirvalik.IntegralHeight = False
        Me.cmbTreeninguteKiirvalik.ItemHeight = 18
        Me.cmbTreeninguteKiirvalik.Location = New System.Drawing.Point(118, 42)
        Me.cmbTreeninguteKiirvalik.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTreeninguteKiirvalik.Name = "cmbTreeninguteKiirvalik"
        Me.cmbTreeninguteKiirvalik.Size = New System.Drawing.Size(206, 26)
        Me.cmbTreeninguteKiirvalik.TabIndex = 24
        '
        'lblKcalPaev
        '
        Me.lblKcalPaev.AutoSize = True
        Me.lblKcalPaev.ForeColor = System.Drawing.Color.Black
        Me.lblKcalPaev.Location = New System.Drawing.Point(146, 248)
        Me.lblKcalPaev.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKcalPaev.Name = "lblKcalPaev"
        Me.lblKcalPaev.Size = New System.Drawing.Size(70, 19)
        Me.lblKcalPaev.TabIndex = 8
        Me.lblKcalPaev.Text = "Label40"
        Me.lblKcalPaev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chbMukbangFilter)
        Me.GroupBox8.Controls.Add(Me.Label45)
        Me.GroupBox8.Controls.Add(Me.lblToiduAineRetseptiLisamineViga)
        Me.GroupBox8.Controls.Add(Me.rdbOhtu)
        Me.GroupBox8.Controls.Add(Me.rdbVahepala)
        Me.GroupBox8.Controls.Add(Me.rdbLouna)
        Me.GroupBox8.Controls.Add(Me.rdbHommik)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.btnToiduaineKiirvalikLisa)
        Me.GroupBox8.Controls.Add(Me.txtToiduaineKiirvalikKogus)
        Me.GroupBox8.Controls.Add(Me.cmbToiduaineKiirvalik)
        Me.GroupBox8.Location = New System.Drawing.Point(468, 71)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(358, 211)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Toidukorra lisamine"
        '
        'chbMukbangFilter
        '
        Me.chbMukbangFilter.AutoSize = True
        Me.chbMukbangFilter.ForeColor = System.Drawing.Color.Black
        Me.chbMukbangFilter.Location = New System.Drawing.Point(118, 63)
        Me.chbMukbangFilter.Name = "chbMukbangFilter"
        Me.chbMukbangFilter.Size = New System.Drawing.Size(144, 23)
        Me.chbMukbangFilter.TabIndex = 38
        Me.chbMukbangFilter.Text = "Mukbang filter"
        Me.chbMukbangFilter.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(170, 119)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(20, 19)
        Me.Label45.TabIndex = 37
        Me.Label45.Text = "g"
        '
        'lblToiduAineRetseptiLisamineViga
        '
        Me.lblToiduAineRetseptiLisamineViga.AutoSize = True
        Me.lblToiduAineRetseptiLisamineViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToiduAineRetseptiLisamineViga.ForeColor = System.Drawing.Color.Red
        Me.lblToiduAineRetseptiLisamineViga.Location = New System.Drawing.Point(38, 184)
        Me.lblToiduAineRetseptiLisamineViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToiduAineRetseptiLisamineViga.Name = "lblToiduAineRetseptiLisamineViga"
        Me.lblToiduAineRetseptiLisamineViga.Size = New System.Drawing.Size(50, 21)
        Me.lblToiduAineRetseptiLisamineViga.TabIndex = 36
        Me.lblToiduAineRetseptiLisamineViga.Text = "VIGA"
        Me.lblToiduAineRetseptiLisamineViga.Visible = False
        '
        'rdbOhtu
        '
        Me.rdbOhtu.AutoSize = True
        Me.rdbOhtu.ForeColor = System.Drawing.Color.Black
        Me.rdbOhtu.Location = New System.Drawing.Point(284, 158)
        Me.rdbOhtu.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbOhtu.Name = "rdbOhtu"
        Me.rdbOhtu.Size = New System.Drawing.Size(68, 23)
        Me.rdbOhtu.TabIndex = 29
        Me.rdbOhtu.TabStop = True
        Me.rdbOhtu.Text = "Õhtu"
        Me.rdbOhtu.UseVisualStyleBackColor = True
        '
        'rdbVahepala
        '
        Me.rdbVahepala.AutoSize = True
        Me.rdbVahepala.ForeColor = System.Drawing.Color.Black
        Me.rdbVahepala.Location = New System.Drawing.Point(172, 159)
        Me.rdbVahepala.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbVahepala.Name = "rdbVahepala"
        Me.rdbVahepala.Size = New System.Drawing.Size(106, 23)
        Me.rdbVahepala.TabIndex = 28
        Me.rdbVahepala.TabStop = True
        Me.rdbVahepala.Text = "Vahepala"
        Me.rdbVahepala.UseVisualStyleBackColor = True
        '
        'rdbLouna
        '
        Me.rdbLouna.AutoSize = True
        Me.rdbLouna.ForeColor = System.Drawing.Color.Black
        Me.rdbLouna.Location = New System.Drawing.Point(96, 159)
        Me.rdbLouna.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbLouna.Name = "rdbLouna"
        Me.rdbLouna.Size = New System.Drawing.Size(74, 23)
        Me.rdbLouna.TabIndex = 27
        Me.rdbLouna.TabStop = True
        Me.rdbLouna.Text = "Lõuna"
        Me.rdbLouna.UseVisualStyleBackColor = True
        '
        'rdbHommik
        '
        Me.rdbHommik.AutoSize = True
        Me.rdbHommik.ForeColor = System.Drawing.Color.Black
        Me.rdbHommik.Location = New System.Drawing.Point(6, 159)
        Me.rdbHommik.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbHommik.Name = "rdbHommik"
        Me.rdbHommik.Size = New System.Drawing.Size(92, 23)
        Me.rdbHommik.TabIndex = 26
        Me.rdbHommik.TabStop = True
        Me.rdbHommik.Text = "Hommik"
        Me.rdbHommik.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(58, 115)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 19)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Kogus:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(38, 34)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 19)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Nimetus:"
        '
        'btnToiduaineKiirvalikLisa
        '
        Me.btnToiduaineKiirvalikLisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnToiduaineKiirvalikLisa.FlatAppearance.BorderSize = 0
        Me.btnToiduaineKiirvalikLisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnToiduaineKiirvalikLisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToiduaineKiirvalikLisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToiduaineKiirvalikLisa.ForeColor = System.Drawing.SystemColors.Window
        Me.btnToiduaineKiirvalikLisa.Location = New System.Drawing.Point(238, 109)
        Me.btnToiduaineKiirvalikLisa.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnToiduaineKiirvalikLisa.Name = "btnToiduaineKiirvalikLisa"
        Me.btnToiduaineKiirvalikLisa.Size = New System.Drawing.Size(86, 28)
        Me.btnToiduaineKiirvalikLisa.TabIndex = 30
        Me.btnToiduaineKiirvalikLisa.Text = "Lisa"
        Me.btnToiduaineKiirvalikLisa.UseVisualStyleBackColor = False
        '
        'txtToiduaineKiirvalikKogus
        '
        Me.txtToiduaineKiirvalikKogus.Location = New System.Drawing.Point(118, 111)
        Me.txtToiduaineKiirvalikKogus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtToiduaineKiirvalikKogus.Name = "txtToiduaineKiirvalikKogus"
        Me.txtToiduaineKiirvalikKogus.Size = New System.Drawing.Size(52, 27)
        Me.txtToiduaineKiirvalikKogus.TabIndex = 25
        '
        'cmbToiduaineKiirvalik
        '
        Me.cmbToiduaineKiirvalik.DropDownHeight = 100
        Me.cmbToiduaineKiirvalik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToiduaineKiirvalik.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbToiduaineKiirvalik.FormattingEnabled = True
        Me.cmbToiduaineKiirvalik.IntegralHeight = False
        Me.cmbToiduaineKiirvalik.ItemHeight = 18
        Me.cmbToiduaineKiirvalik.Location = New System.Drawing.Point(118, 32)
        Me.cmbToiduaineKiirvalik.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbToiduaineKiirvalik.Name = "cmbToiduaineKiirvalik"
        Me.cmbToiduaineKiirvalik.Size = New System.Drawing.Size(206, 26)
        Me.cmbToiduaineKiirvalik.TabIndex = 24
        '
        'chrKoduPaneel
        '
        Me.chrKoduPaneel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrKoduPaneel.BorderlineColor = System.Drawing.Color.Black
        Me.chrKoduPaneel.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrKoduPaneel.BorderlineWidth = 0
        Me.chrKoduPaneel.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrKoduPaneel.BorderSkin.PageColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea5.Name = "ChartArea1"
        Me.chrKoduPaneel.ChartAreas.Add(ChartArea5)
        Legend5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Legend5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend5.IsTextAutoFit = False
        Legend5.Name = "Legend1"
        Me.chrKoduPaneel.Legends.Add(Legend5)
        Me.chrKoduPaneel.Location = New System.Drawing.Point(26, 78)
        Me.chrKoduPaneel.Margin = New System.Windows.Forms.Padding(2)
        Me.chrKoduPaneel.Name = "chrKoduPaneel"
        Me.chrKoduPaneel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.chrKoduPaneel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series6.IsValueShownAsLabel = True
        Series6.Legend = "Legend1"
        Series6.Name = "Soogikorrad"
        Series6.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White
        Me.chrKoduPaneel.Series.Add(Series6)
        Me.chrKoduPaneel.Size = New System.Drawing.Size(432, 374)
        Me.chrKoduPaneel.TabIndex = 6
        Title4.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Päevane tarbimine"
        Me.chrKoduPaneel.Titles.Add(Title4)
        '
        'lblKoduEesnimi
        '
        Me.lblKoduEesnimi.AutoSize = True
        Me.lblKoduEesnimi.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKoduEesnimi.ForeColor = System.Drawing.Color.Black
        Me.lblKoduEesnimi.Location = New System.Drawing.Point(82, 30)
        Me.lblKoduEesnimi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKoduEesnimi.Name = "lblKoduEesnimi"
        Me.lblKoduEesnimi.Size = New System.Drawing.Size(107, 30)
        Me.lblKoduEesnimi.TabIndex = 1
        Me.lblKoduEesnimi.Text = "Eesnimi!"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(22, 30)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 30)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tere,"
        '
        'LblPaevaneTarbimine
        '
        Me.LblPaevaneTarbimine.AutoSize = True
        Me.LblPaevaneTarbimine.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblPaevaneTarbimine.Location = New System.Drawing.Point(155, 263)
        Me.LblPaevaneTarbimine.Name = "LblPaevaneTarbimine"
        Me.LblPaevaneTarbimine.Size = New System.Drawing.Size(70, 19)
        Me.LblPaevaneTarbimine.TabIndex = 12
        Me.LblPaevaneTarbimine.Text = "Label27"
        Me.LblPaevaneTarbimine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTreeningud
        '
        Me.pnlTreeningud.Controls.Add(Me.GroupBox16)
        Me.pnlTreeningud.Controls.Add(Me.GroupBox11)
        Me.pnlTreeningud.Controls.Add(Me.Label16)
        Me.pnlTreeningud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlTreeningud.Location = New System.Drawing.Point(232, 100)
        Me.pnlTreeningud.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTreeningud.Name = "pnlTreeningud"
        Me.pnlTreeningud.Size = New System.Drawing.Size(838, 476)
        Me.pnlTreeningud.TabIndex = 2
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.Label25)
        Me.GroupBox16.Controls.Add(Me.lblKustutaTreeningViga)
        Me.GroupBox16.Controls.Add(Me.btnKustutaTreening)
        Me.GroupBox16.Controls.Add(Me.cmbTreeninguKustutamine)
        Me.GroupBox16.Location = New System.Drawing.Point(16, 283)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(810, 182)
        Me.GroupBox16.TabIndex = 39
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Treeningu kustutamine andmebaasist"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(132, 62)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 19)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Nimetus:"
        '
        'lblKustutaTreeningViga
        '
        Me.lblKustutaTreeningViga.AutoSize = True
        Me.lblKustutaTreeningViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKustutaTreeningViga.ForeColor = System.Drawing.Color.Red
        Me.lblKustutaTreeningViga.Location = New System.Drawing.Point(276, 143)
        Me.lblKustutaTreeningViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKustutaTreeningViga.Name = "lblKustutaTreeningViga"
        Me.lblKustutaTreeningViga.Size = New System.Drawing.Size(50, 21)
        Me.lblKustutaTreeningViga.TabIndex = 37
        Me.lblKustutaTreeningViga.Text = "VIGA"
        Me.lblKustutaTreeningViga.Visible = False
        '
        'btnKustutaTreening
        '
        Me.btnKustutaTreening.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnKustutaTreening.FlatAppearance.BorderSize = 0
        Me.btnKustutaTreening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnKustutaTreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKustutaTreening.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKustutaTreening.ForeColor = System.Drawing.SystemColors.Window
        Me.btnKustutaTreening.Location = New System.Drawing.Point(280, 97)
        Me.btnKustutaTreening.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnKustutaTreening.Name = "btnKustutaTreening"
        Me.btnKustutaTreening.Size = New System.Drawing.Size(276, 34)
        Me.btnKustutaTreening.TabIndex = 29
        Me.btnKustutaTreening.Text = "Kustuta treening"
        Me.btnKustutaTreening.UseVisualStyleBackColor = False
        '
        'cmbTreeninguKustutamine
        '
        Me.cmbTreeninguKustutamine.DropDownHeight = 100
        Me.cmbTreeninguKustutamine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTreeninguKustutamine.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTreeninguKustutamine.FormattingEnabled = True
        Me.cmbTreeninguKustutamine.IntegralHeight = False
        Me.cmbTreeninguKustutamine.ItemHeight = 18
        Me.cmbTreeninguKustutamine.Location = New System.Drawing.Point(222, 60)
        Me.cmbTreeninguKustutamine.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTreeninguKustutamine.Name = "cmbTreeninguKustutamine"
        Me.cmbTreeninguKustutamine.Size = New System.Drawing.Size(382, 26)
        Me.cmbTreeninguKustutamine.TabIndex = 25
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label46)
        Me.GroupBox11.Controls.Add(Me.Label51)
        Me.GroupBox11.Controls.Add(Me.Label52)
        Me.GroupBox11.Controls.Add(Me.lblTreeninguLisamineViga)
        Me.GroupBox11.Controls.Add(Me.txtTreeninguLisamineEnergialkulu)
        Me.GroupBox11.Controls.Add(Me.txtTreeninguLisamineNimi)
        Me.GroupBox11.Controls.Add(Me.btnTreeninguLisamine)
        Me.GroupBox11.Location = New System.Drawing.Point(16, 78)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox11.Size = New System.Drawing.Size(810, 174)
        Me.GroupBox11.TabIndex = 30
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Treeningu lisamine andmebaasi"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(626, 60)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(68, 19)
        Me.Label46.TabIndex = 41
        Me.Label46.Text = "kcal/1h"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(460, 58)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(104, 19)
        Me.Label51.TabIndex = 36
        Me.Label51.Text = "Energiakulu:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(30, 58)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(79, 19)
        Me.Label52.TabIndex = 35
        Me.Label52.Text = "Nimetus:"
        '
        'lblTreeninguLisamineViga
        '
        Me.lblTreeninguLisamineViga.AutoSize = True
        Me.lblTreeninguLisamineViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreeninguLisamineViga.ForeColor = System.Drawing.Color.Red
        Me.lblTreeninguLisamineViga.Location = New System.Drawing.Point(394, 140)
        Me.lblTreeninguLisamineViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTreeninguLisamineViga.Name = "lblTreeninguLisamineViga"
        Me.lblTreeninguLisamineViga.Size = New System.Drawing.Size(50, 21)
        Me.lblTreeninguLisamineViga.TabIndex = 34
        Me.lblTreeninguLisamineViga.Text = "VIGA"
        Me.lblTreeninguLisamineViga.Visible = False
        '
        'txtTreeninguLisamineEnergialkulu
        '
        Me.txtTreeninguLisamineEnergialkulu.Location = New System.Drawing.Point(568, 54)
        Me.txtTreeninguLisamineEnergialkulu.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtTreeninguLisamineEnergialkulu.Name = "txtTreeninguLisamineEnergialkulu"
        Me.txtTreeninguLisamineEnergialkulu.Size = New System.Drawing.Size(56, 27)
        Me.txtTreeninguLisamineEnergialkulu.TabIndex = 31
        '
        'txtTreeninguLisamineNimi
        '
        Me.txtTreeninguLisamineNimi.Location = New System.Drawing.Point(118, 54)
        Me.txtTreeninguLisamineNimi.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtTreeninguLisamineNimi.Name = "txtTreeninguLisamineNimi"
        Me.txtTreeninguLisamineNimi.Size = New System.Drawing.Size(262, 27)
        Me.txtTreeninguLisamineNimi.TabIndex = 27
        '
        'btnTreeninguLisamine
        '
        Me.btnTreeninguLisamine.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnTreeninguLisamine.FlatAppearance.BorderSize = 0
        Me.btnTreeninguLisamine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnTreeninguLisamine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreeninguLisamine.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreeninguLisamine.ForeColor = System.Drawing.SystemColors.Window
        Me.btnTreeninguLisamine.Location = New System.Drawing.Point(280, 102)
        Me.btnTreeninguLisamine.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnTreeninguLisamine.Name = "btnTreeninguLisamine"
        Me.btnTreeninguLisamine.Size = New System.Drawing.Size(276, 34)
        Me.btnTreeninguLisamine.TabIndex = 28
        Me.btnTreeninguLisamine.Text = "Lisa"
        Me.btnTreeninguLisamine.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(22, 30)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 30)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Treeningud"
        '
        'pnlYlevaade
        '
        Me.pnlYlevaade.Controls.Add(Me.Kaal)
        Me.pnlYlevaade.Controls.Add(Me.GroupBox15)
        Me.pnlYlevaade.Controls.Add(Me.chrKaaluMuutumine)
        Me.pnlYlevaade.Controls.Add(Me.GroupBox2)
        Me.pnlYlevaade.Controls.Add(Me.Label17)
        Me.pnlYlevaade.Location = New System.Drawing.Point(232, 100)
        Me.pnlYlevaade.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlYlevaade.Name = "pnlYlevaade"
        Me.pnlYlevaade.Size = New System.Drawing.Size(838, 476)
        Me.pnlYlevaade.TabIndex = 4
        '
        'Kaal
        '
        Me.Kaal.Controls.Add(Me.Label58)
        Me.Kaal.Controls.Add(Me.txtKaaluEesmärk)
        Me.Kaal.Controls.Add(Me.btnEesmargiKinnitamine)
        Me.Kaal.Location = New System.Drawing.Point(46, 200)
        Me.Kaal.Margin = New System.Windows.Forms.Padding(2)
        Me.Kaal.Name = "Kaal"
        Me.Kaal.Padding = New System.Windows.Forms.Padding(2)
        Me.Kaal.Size = New System.Drawing.Size(292, 124)
        Me.Kaal.TabIndex = 24
        Me.Kaal.TabStop = False
        Me.Kaal.Text = "Kaalu eesmärgi seadmine"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(206, 46)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(28, 19)
        Me.Label58.TabIndex = 25
        Me.Label58.Text = "kg"
        '
        'txtKaaluEesmärk
        '
        Me.txtKaaluEesmärk.Location = New System.Drawing.Point(14, 37)
        Me.txtKaaluEesmärk.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtKaaluEesmärk.Name = "txtKaaluEesmärk"
        Me.txtKaaluEesmärk.Size = New System.Drawing.Size(190, 27)
        Me.txtKaaluEesmärk.TabIndex = 23
        '
        'btnEesmargiKinnitamine
        '
        Me.btnEesmargiKinnitamine.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnEesmargiKinnitamine.FlatAppearance.BorderSize = 0
        Me.btnEesmargiKinnitamine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnEesmargiKinnitamine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEesmargiKinnitamine.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEesmargiKinnitamine.ForeColor = System.Drawing.Color.White
        Me.btnEesmargiKinnitamine.Location = New System.Drawing.Point(14, 68)
        Me.btnEesmargiKinnitamine.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnEesmargiKinnitamine.Name = "btnEesmargiKinnitamine"
        Me.btnEesmargiKinnitamine.Size = New System.Drawing.Size(258, 42)
        Me.btnEesmargiKinnitamine.TabIndex = 22
        Me.btnEesmargiKinnitamine.Text = "Kinnita eesmärk"
        Me.btnEesmargiKinnitamine.UseVisualStyleBackColor = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label57)
        Me.GroupBox15.Controls.Add(Me.txtPaevaneKaal)
        Me.GroupBox15.Controls.Add(Me.btnPaevaneKaal)
        Me.GroupBox15.Location = New System.Drawing.Point(46, 78)
        Me.GroupBox15.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox15.Size = New System.Drawing.Size(292, 118)
        Me.GroupBox15.TabIndex = 23
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Päevase kehakaalu lisamine"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(206, 39)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(28, 19)
        Me.Label57.TabIndex = 24
        Me.Label57.Text = "kg"
        '
        'txtPaevaneKaal
        '
        Me.txtPaevaneKaal.Location = New System.Drawing.Point(10, 30)
        Me.txtPaevaneKaal.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtPaevaneKaal.Name = "txtPaevaneKaal"
        Me.txtPaevaneKaal.Size = New System.Drawing.Size(194, 27)
        Me.txtPaevaneKaal.TabIndex = 23
        '
        'btnPaevaneKaal
        '
        Me.btnPaevaneKaal.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnPaevaneKaal.FlatAppearance.BorderSize = 0
        Me.btnPaevaneKaal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnPaevaneKaal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaevaneKaal.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaevaneKaal.ForeColor = System.Drawing.Color.White
        Me.btnPaevaneKaal.Location = New System.Drawing.Point(10, 62)
        Me.btnPaevaneKaal.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnPaevaneKaal.Name = "btnPaevaneKaal"
        Me.btnPaevaneKaal.Size = New System.Drawing.Size(258, 42)
        Me.btnPaevaneKaal.TabIndex = 22
        Me.btnPaevaneKaal.Text = "Kinnita päevane kaal"
        Me.btnPaevaneKaal.UseVisualStyleBackColor = False
        '
        'chrKaaluMuutumine
        '
        Me.chrKaaluMuutumine.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrKaaluMuutumine.BorderlineColor = System.Drawing.Color.Black
        Me.chrKaaluMuutumine.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrKaaluMuutumine.BorderlineWidth = 0
        Me.chrKaaluMuutumine.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrKaaluMuutumine.BorderSkin.PageColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea6.Name = "ChartArea1"
        Me.chrKaaluMuutumine.ChartAreas.Add(ChartArea6)
        Legend6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Legend6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend6.IsTextAutoFit = False
        Legend6.Name = "Legend1"
        Me.chrKaaluMuutumine.Legends.Add(Legend6)
        Me.chrKaaluMuutumine.Location = New System.Drawing.Point(374, 78)
        Me.chrKaaluMuutumine.Margin = New System.Windows.Forms.Padding(2)
        Me.chrKaaluMuutumine.Name = "chrKaaluMuutumine"
        Me.chrKaaluMuutumine.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.chrKaaluMuutumine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series7.BorderWidth = 3
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Color = System.Drawing.Color.Blue
        Series7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series7.Legend = "Legend1"
        Series7.Name = "Kaal"
        Series7.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White
        Series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series8.BorderWidth = 3
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Color = System.Drawing.Color.Lime
        Series8.Legend = "Legend1"
        Series8.Name = "Siht Kaal"
        Series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Me.chrKaaluMuutumine.Series.Add(Series7)
        Me.chrKaaluMuutumine.Series.Add(Series8)
        Me.chrKaaluMuutumine.Size = New System.Drawing.Size(456, 388)
        Me.chrKaaluMuutumine.TabIndex = 22
        Title5.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.Name = "Title1"
        Title5.Text = "Kehakaalu graafik"
        Me.chrKaaluMuutumine.Titles.Add(Title5)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNaitaYlevaadet)
        Me.GroupBox2.Controls.Add(Me.cmbAjaluguGraafikuPeriood)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(46, 334)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(292, 132)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Graafiku seaded"
        '
        'btnNaitaYlevaadet
        '
        Me.btnNaitaYlevaadet.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnNaitaYlevaadet.FlatAppearance.BorderSize = 0
        Me.btnNaitaYlevaadet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnNaitaYlevaadet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNaitaYlevaadet.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNaitaYlevaadet.ForeColor = System.Drawing.Color.White
        Me.btnNaitaYlevaadet.Location = New System.Drawing.Point(14, 76)
        Me.btnNaitaYlevaadet.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnNaitaYlevaadet.Name = "btnNaitaYlevaadet"
        Me.btnNaitaYlevaadet.Size = New System.Drawing.Size(258, 42)
        Me.btnNaitaYlevaadet.TabIndex = 21
        Me.btnNaitaYlevaadet.Text = "Kuva ülevaade"
        Me.btnNaitaYlevaadet.UseVisualStyleBackColor = False
        '
        'cmbAjaluguGraafikuPeriood
        '
        Me.cmbAjaluguGraafikuPeriood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAjaluguGraafikuPeriood.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAjaluguGraafikuPeriood.FormattingEnabled = True
        Me.cmbAjaluguGraafikuPeriood.Location = New System.Drawing.Point(102, 34)
        Me.cmbAjaluguGraafikuPeriood.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAjaluguGraafikuPeriood.Name = "cmbAjaluguGraafikuPeriood"
        Me.cmbAjaluguGraafikuPeriood.Size = New System.Drawing.Size(170, 26)
        Me.cmbAjaluguGraafikuPeriood.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 36)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 19)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Periood"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(22, 30)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 30)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Ülevaade"
        '
        'chrYlevaade
        '
        Me.chrYlevaade.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrYlevaade.BorderlineColor = System.Drawing.Color.Black
        Me.chrYlevaade.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrYlevaade.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.chrYlevaade.BorderSkin.PageColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer))
        ChartArea7.Name = "ChartArea1"
        Me.chrYlevaade.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.chrYlevaade.Legends.Add(Legend7)
        Me.chrYlevaade.Location = New System.Drawing.Point(677, 101)
        Me.chrYlevaade.Margin = New System.Windows.Forms.Padding(5)
        Me.chrYlevaade.Name = "chrYlevaade"
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.chrYlevaade.Series.Add(Series9)
        Me.chrYlevaade.Size = New System.Drawing.Size(992, 892)
        Me.chrYlevaade.TabIndex = 8
        Me.chrYlevaade.Text = "Ajalugu"
        '
        'pnlAjalugu
        '
        Me.pnlAjalugu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlAjalugu.Controls.Add(Me.chrAjalooPaneel)
        Me.pnlAjalugu.Controls.Add(Me.GroupBox12)
        Me.pnlAjalugu.Controls.Add(Me.btnAjalooKuupaevTagasi)
        Me.pnlAjalugu.Controls.Add(Me.bntAjalooKuupaevEdasi)
        Me.pnlAjalugu.Controls.Add(Me.lblAjaluguNadalaPaev)
        Me.pnlAjalugu.Controls.Add(Me.lblAjaluguKuupaev)
        Me.pnlAjalugu.Controls.Add(Me.Label18)
        Me.pnlAjalugu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAjalugu.ForeColor = System.Drawing.Color.Black
        Me.pnlAjalugu.Location = New System.Drawing.Point(232, 100)
        Me.pnlAjalugu.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlAjalugu.Name = "pnlAjalugu"
        Me.pnlAjalugu.Size = New System.Drawing.Size(833, 481)
        Me.pnlAjalugu.TabIndex = 5
        '
        'chrAjalooPaneel
        '
        Me.chrAjalooPaneel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrAjalooPaneel.BorderlineColor = System.Drawing.Color.Black
        Me.chrAjalooPaneel.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrAjalooPaneel.BorderlineWidth = 0
        Me.chrAjalooPaneel.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrAjalooPaneel.BorderSkin.PageColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea8.Name = "ChartArea1"
        Me.chrAjalooPaneel.ChartAreas.Add(ChartArea8)
        Legend8.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Legend8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend8.IsTextAutoFit = False
        Legend8.Name = "Legend1"
        Me.chrAjalooPaneel.Legends.Add(Legend8)
        Me.chrAjalooPaneel.Location = New System.Drawing.Point(544, 110)
        Me.chrAjalooPaneel.Margin = New System.Windows.Forms.Padding(2)
        Me.chrAjalooPaneel.Name = "chrAjalooPaneel"
        Me.chrAjalooPaneel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.chrAjalooPaneel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series10.IsValueShownAsLabel = True
        Series10.Legend = "Legend1"
        Series10.Name = "Makrod"
        Series10.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White
        Me.chrAjalooPaneel.Series.Add(Series10)
        Me.chrAjalooPaneel.Size = New System.Drawing.Size(276, 330)
        Me.chrAjalooPaneel.TabIndex = 26
        Title6.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.Name = "Title1"
        Title6.Text = "Päevane tarbimine"
        Me.chrAjalooPaneel.Titles.Add(Title6)
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.lvPaevasedTreeningud)
        Me.GroupBox12.Controls.Add(Me.lvPaevasedToidud)
        Me.GroupBox12.Location = New System.Drawing.Point(16, 103)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox12.Size = New System.Drawing.Size(496, 338)
        Me.GroupBox12.TabIndex = 25
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Toidud ja treeningud"
        '
        'lvPaevasedTreeningud
        '
        Me.lvPaevasedTreeningud.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lvPaevasedTreeningud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvPaevasedTreeningud.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.treeninguNimi, Me.treeninguKalorid, Me.treeninguKestus})
        Me.lvPaevasedTreeningud.HideSelection = False
        Me.lvPaevasedTreeningud.Location = New System.Drawing.Point(11, 227)
        Me.lvPaevasedTreeningud.Name = "lvPaevasedTreeningud"
        Me.lvPaevasedTreeningud.Size = New System.Drawing.Size(472, 97)
        Me.lvPaevasedTreeningud.TabIndex = 1
        Me.lvPaevasedTreeningud.UseCompatibleStateImageBehavior = False
        Me.lvPaevasedTreeningud.View = System.Windows.Forms.View.Details
        '
        'treeninguNimi
        '
        Me.treeninguNimi.Text = "Treeningu nimi"
        Me.treeninguNimi.Width = 257
        '
        'treeninguKalorid
        '
        Me.treeninguKalorid.DisplayIndex = 2
        Me.treeninguKalorid.Text = "Kalorid"
        Me.treeninguKalorid.Width = 71
        '
        'treeninguKestus
        '
        Me.treeninguKestus.DisplayIndex = 1
        Me.treeninguKestus.Text = "Kestus"
        Me.treeninguKestus.Width = 143
        '
        'lvPaevasedToidud
        '
        Me.lvPaevasedToidud.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lvPaevasedToidud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvPaevasedToidud.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.toiduKord, Me.toiduNimetus, Me.toiduKcal})
        Me.lvPaevasedToidud.HideSelection = False
        Me.lvPaevasedToidud.Location = New System.Drawing.Point(11, 39)
        Me.lvPaevasedToidud.Name = "lvPaevasedToidud"
        Me.lvPaevasedToidud.Size = New System.Drawing.Size(472, 163)
        Me.lvPaevasedToidud.TabIndex = 0
        Me.lvPaevasedToidud.UseCompatibleStateImageBehavior = False
        Me.lvPaevasedToidud.View = System.Windows.Forms.View.Details
        '
        'toiduKord
        '
        Me.toiduKord.Text = "Toidukord"
        Me.toiduKord.Width = 89
        '
        'toiduNimetus
        '
        Me.toiduNimetus.Text = "Toidu nimetus"
        Me.toiduNimetus.Width = 306
        '
        'toiduKcal
        '
        Me.toiduKcal.Text = "Kalorid"
        Me.toiduKcal.Width = 77
        '
        'btnAjalooKuupaevTagasi
        '
        Me.btnAjalooKuupaevTagasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAjalooKuupaevTagasi.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_double_left_64
        Me.btnAjalooKuupaevTagasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAjalooKuupaevTagasi.FlatAppearance.BorderSize = 0
        Me.btnAjalooKuupaevTagasi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAjalooKuupaevTagasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjalooKuupaevTagasi.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjalooKuupaevTagasi.ForeColor = System.Drawing.Color.Black
        Me.btnAjalooKuupaevTagasi.Location = New System.Drawing.Point(235, 57)
        Me.btnAjalooKuupaevTagasi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAjalooKuupaevTagasi.Name = "btnAjalooKuupaevTagasi"
        Me.btnAjalooKuupaevTagasi.Size = New System.Drawing.Size(62, 26)
        Me.btnAjalooKuupaevTagasi.TabIndex = 24
        Me.btnAjalooKuupaevTagasi.UseVisualStyleBackColor = False
        '
        'bntAjalooKuupaevEdasi
        '
        Me.bntAjalooKuupaevEdasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.bntAjalooKuupaevEdasi.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_double_right_64
        Me.bntAjalooKuupaevEdasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bntAjalooKuupaevEdasi.FlatAppearance.BorderSize = 0
        Me.bntAjalooKuupaevEdasi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.bntAjalooKuupaevEdasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntAjalooKuupaevEdasi.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntAjalooKuupaevEdasi.ForeColor = System.Drawing.Color.Black
        Me.bntAjalooKuupaevEdasi.Location = New System.Drawing.Point(483, 57)
        Me.bntAjalooKuupaevEdasi.Margin = New System.Windows.Forms.Padding(2)
        Me.bntAjalooKuupaevEdasi.Name = "bntAjalooKuupaevEdasi"
        Me.bntAjalooKuupaevEdasi.Size = New System.Drawing.Size(62, 26)
        Me.bntAjalooKuupaevEdasi.TabIndex = 23
        Me.bntAjalooKuupaevEdasi.UseVisualStyleBackColor = False
        '
        'lblAjaluguNadalaPaev
        '
        Me.lblAjaluguNadalaPaev.AutoSize = True
        Me.lblAjaluguNadalaPaev.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjaluguNadalaPaev.ForeColor = System.Drawing.Color.Black
        Me.lblAjaluguNadalaPaev.Location = New System.Drawing.Point(317, 58)
        Me.lblAjaluguNadalaPaev.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAjaluguNadalaPaev.Name = "lblAjaluguNadalaPaev"
        Me.lblAjaluguNadalaPaev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAjaluguNadalaPaev.Size = New System.Drawing.Size(28, 23)
        Me.lblAjaluguNadalaPaev.TabIndex = 6
        Me.lblAjaluguNadalaPaev.Text = "D,"
        Me.lblAjaluguNadalaPaev.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAjaluguKuupaev
        '
        Me.lblAjaluguKuupaev.AutoSize = True
        Me.lblAjaluguKuupaev.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjaluguKuupaev.ForeColor = System.Drawing.Color.Black
        Me.lblAjaluguKuupaev.Location = New System.Drawing.Point(342, 58)
        Me.lblAjaluguKuupaev.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAjaluguKuupaev.Name = "lblAjaluguKuupaev"
        Me.lblAjaluguKuupaev.Size = New System.Drawing.Size(128, 23)
        Me.lblAjaluguKuupaev.TabIndex = 5
        Me.lblAjaluguKuupaev.Text = "DD.MM.YYYY"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(22, 30)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 30)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Ajalugu"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(22, 30)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(176, 30)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Profiili seaded"
        '
        'lblProfiiliSeadedEesnimi
        '
        Me.lblProfiiliSeadedEesnimi.AutoSize = True
        Me.lblProfiiliSeadedEesnimi.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfiiliSeadedEesnimi.ForeColor = System.Drawing.Color.Black
        Me.lblProfiiliSeadedEesnimi.Location = New System.Drawing.Point(536, 90)
        Me.lblProfiiliSeadedEesnimi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProfiiliSeadedEesnimi.Name = "lblProfiiliSeadedEesnimi"
        Me.lblProfiiliSeadedEesnimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblProfiiliSeadedEesnimi.Size = New System.Drawing.Size(88, 25)
        Me.lblProfiiliSeadedEesnimi.TabIndex = 5
        Me.lblProfiiliSeadedEesnimi.Text = "Eesnimi"
        Me.lblProfiiliSeadedEesnimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfiiliSeadedKasutajanimi
        '
        Me.lblProfiiliSeadedKasutajanimi.AutoSize = True
        Me.lblProfiiliSeadedKasutajanimi.ForeColor = System.Drawing.Color.Black
        Me.lblProfiiliSeadedKasutajanimi.Location = New System.Drawing.Point(546, 116)
        Me.lblProfiiliSeadedKasutajanimi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProfiiliSeadedKasutajanimi.Name = "lblProfiiliSeadedKasutajanimi"
        Me.lblProfiiliSeadedKasutajanimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblProfiiliSeadedKasutajanimi.Size = New System.Drawing.Size(78, 19)
        Me.lblProfiiliSeadedKasutajanimi.TabIndex = 7
        Me.lblProfiiliSeadedKasutajanimi.Text = "Kasutaja"
        Me.lblProfiiliSeadedKasutajanimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbMuudaPikkust)
        Me.GroupBox3.Controls.Add(Me.btnMuudaPikkust)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.lblKasutajaPikkus)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(23, 379)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(270, 87)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pikkus"
        '
        'cmbMuudaPikkust
        '
        Me.cmbMuudaPikkust.DropDownHeight = 100
        Me.cmbMuudaPikkust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMuudaPikkust.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMuudaPikkust.FormattingEnabled = True
        Me.cmbMuudaPikkust.IntegralHeight = False
        Me.cmbMuudaPikkust.Location = New System.Drawing.Point(16, 50)
        Me.cmbMuudaPikkust.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMuudaPikkust.Name = "cmbMuudaPikkust"
        Me.cmbMuudaPikkust.Size = New System.Drawing.Size(74, 26)
        Me.cmbMuudaPikkust.TabIndex = 24
        '
        'btnMuudaPikkust
        '
        Me.btnMuudaPikkust.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnMuudaPikkust.FlatAppearance.BorderSize = 0
        Me.btnMuudaPikkust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnMuudaPikkust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMuudaPikkust.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMuudaPikkust.ForeColor = System.Drawing.Color.White
        Me.btnMuudaPikkust.Location = New System.Drawing.Point(174, 44)
        Me.btnMuudaPikkust.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnMuudaPikkust.Name = "btnMuudaPikkust"
        Me.btnMuudaPikkust.Size = New System.Drawing.Size(86, 34)
        Me.btnMuudaPikkust.TabIndex = 23
        Me.btnMuudaPikkust.Text = "Muuda"
        Me.btnMuudaPikkust.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(50, 30)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 19)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "cm"
        '
        'lblKasutajaPikkus
        '
        Me.lblKasutajaPikkus.AutoSize = True
        Me.lblKasutajaPikkus.Location = New System.Drawing.Point(18, 30)
        Me.lblKasutajaPikkus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKasutajaPikkus.Name = "lblKasutajaPikkus"
        Me.lblKasutajaPikkus.Size = New System.Drawing.Size(36, 19)
        Me.lblKasutajaPikkus.TabIndex = 4
        Me.lblKasutajaPikkus.Text = "000"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbMuudaKaalu)
        Me.GroupBox4.Controls.Add(Me.btnMuudaKaalu)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lblKasutajaKaal)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(23, 168)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(270, 96)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kaal"
        '
        'cmbMuudaKaalu
        '
        Me.cmbMuudaKaalu.DropDownHeight = 100
        Me.cmbMuudaKaalu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMuudaKaalu.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMuudaKaalu.FormattingEnabled = True
        Me.cmbMuudaKaalu.IntegralHeight = False
        Me.cmbMuudaKaalu.Location = New System.Drawing.Point(20, 58)
        Me.cmbMuudaKaalu.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMuudaKaalu.Name = "cmbMuudaKaalu"
        Me.cmbMuudaKaalu.Size = New System.Drawing.Size(74, 26)
        Me.cmbMuudaKaalu.TabIndex = 24
        '
        'btnMuudaKaalu
        '
        Me.btnMuudaKaalu.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnMuudaKaalu.FlatAppearance.BorderSize = 0
        Me.btnMuudaKaalu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnMuudaKaalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMuudaKaalu.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMuudaKaalu.ForeColor = System.Drawing.Color.White
        Me.btnMuudaKaalu.Location = New System.Drawing.Point(174, 50)
        Me.btnMuudaKaalu.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnMuudaKaalu.Name = "btnMuudaKaalu"
        Me.btnMuudaKaalu.Size = New System.Drawing.Size(86, 34)
        Me.btnMuudaKaalu.TabIndex = 23
        Me.btnMuudaKaalu.Text = "Muuda"
        Me.btnMuudaKaalu.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(50, 32)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 19)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "kg"
        '
        'lblKasutajaKaal
        '
        Me.lblKasutajaKaal.AutoSize = True
        Me.lblKasutajaKaal.Location = New System.Drawing.Point(18, 32)
        Me.lblKasutajaKaal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKasutajaKaal.Name = "lblKasutajaKaal"
        Me.lblKasutajaKaal.Size = New System.Drawing.Size(36, 19)
        Me.lblKasutajaKaal.TabIndex = 2
        Me.lblKasutajaKaal.Text = "000"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbMuudaVanust)
        Me.GroupBox5.Controls.Add(Me.btnMuudaVanust)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.lblKasutajaVanus)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(23, 272)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(270, 101)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vanus"
        '
        'cmbMuudaVanust
        '
        Me.cmbMuudaVanust.DropDownHeight = 100
        Me.cmbMuudaVanust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMuudaVanust.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMuudaVanust.FormattingEnabled = True
        Me.cmbMuudaVanust.IntegralHeight = False
        Me.cmbMuudaVanust.ItemHeight = 18
        Me.cmbMuudaVanust.Location = New System.Drawing.Point(20, 58)
        Me.cmbMuudaVanust.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMuudaVanust.Name = "cmbMuudaVanust"
        Me.cmbMuudaVanust.Size = New System.Drawing.Size(74, 26)
        Me.cmbMuudaVanust.TabIndex = 23
        '
        'btnMuudaVanust
        '
        Me.btnMuudaVanust.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnMuudaVanust.FlatAppearance.BorderSize = 0
        Me.btnMuudaVanust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnMuudaVanust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMuudaVanust.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMuudaVanust.ForeColor = System.Drawing.SystemColors.Window
        Me.btnMuudaVanust.Location = New System.Drawing.Point(174, 54)
        Me.btnMuudaVanust.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnMuudaVanust.Name = "btnMuudaVanust"
        Me.btnMuudaVanust.Size = New System.Drawing.Size(86, 34)
        Me.btnMuudaVanust.TabIndex = 22
        Me.btnMuudaVanust.Text = "Muuda"
        Me.btnMuudaVanust.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "aastat"
        '
        'lblKasutajaVanus
        '
        Me.lblKasutajaVanus.AutoSize = True
        Me.lblKasutajaVanus.Location = New System.Drawing.Point(18, 36)
        Me.lblKasutajaVanus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKasutajaVanus.Name = "lblKasutajaVanus"
        Me.lblKasutajaVanus.Size = New System.Drawing.Size(36, 19)
        Me.lblKasutajaVanus.TabIndex = 0
        Me.lblKasutajaVanus.Text = "000"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtKehtivSalasona)
        Me.GroupBox6.Controls.Add(Me.lblVahetaSalasonaViga)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.btnKinnitaUusSalasona)
        Me.GroupBox6.Controls.Add(Me.txtVahetaSalasona)
        Me.GroupBox6.Controls.Add(Me.txtKordaSalasona)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(316, 232)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(514, 235)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Vaheta salasõna"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(50, 38)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(137, 19)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Kehtiv salasõna:"
        '
        'txtKehtivSalasona
        '
        Me.txtKehtivSalasona.Location = New System.Drawing.Point(194, 34)
        Me.txtKehtivSalasona.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtKehtivSalasona.Name = "txtKehtivSalasona"
        Me.txtKehtivSalasona.Size = New System.Drawing.Size(312, 27)
        Me.txtKehtivSalasona.TabIndex = 26
        Me.txtKehtivSalasona.UseSystemPasswordChar = True
        '
        'lblVahetaSalasonaViga
        '
        Me.lblVahetaSalasonaViga.AutoSize = True
        Me.lblVahetaSalasonaViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVahetaSalasonaViga.ForeColor = System.Drawing.Color.Red
        Me.lblVahetaSalasonaViga.Location = New System.Drawing.Point(44, 154)
        Me.lblVahetaSalasonaViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVahetaSalasonaViga.Name = "lblVahetaSalasonaViga"
        Me.lblVahetaSalasonaViga.Size = New System.Drawing.Size(50, 21)
        Me.lblVahetaSalasonaViga.TabIndex = 25
        Me.lblVahetaSalasonaViga.Text = "VIGA"
        Me.lblVahetaSalasonaViga.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 122)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 19)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Korda uut salasõna:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Uus salasõna:"
        '
        'btnKinnitaUusSalasona
        '
        Me.btnKinnitaUusSalasona.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnKinnitaUusSalasona.FlatAppearance.BorderSize = 0
        Me.btnKinnitaUusSalasona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnKinnitaUusSalasona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKinnitaUusSalasona.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKinnitaUusSalasona.ForeColor = System.Drawing.Color.White
        Me.btnKinnitaUusSalasona.Location = New System.Drawing.Point(194, 178)
        Me.btnKinnitaUusSalasona.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnKinnitaUusSalasona.Name = "btnKinnitaUusSalasona"
        Me.btnKinnitaUusSalasona.Size = New System.Drawing.Size(312, 50)
        Me.btnKinnitaUusSalasona.TabIndex = 22
        Me.btnKinnitaUusSalasona.Text = "Kinnita uus salasõna"
        Me.btnKinnitaUusSalasona.UseVisualStyleBackColor = False
        '
        'txtVahetaSalasona
        '
        Me.txtVahetaSalasona.Location = New System.Drawing.Point(194, 78)
        Me.txtVahetaSalasona.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtVahetaSalasona.Name = "txtVahetaSalasona"
        Me.txtVahetaSalasona.Size = New System.Drawing.Size(312, 27)
        Me.txtVahetaSalasona.TabIndex = 20
        Me.txtVahetaSalasona.UseSystemPasswordChar = True
        '
        'txtKordaSalasona
        '
        Me.txtKordaSalasona.Location = New System.Drawing.Point(194, 120)
        Me.txtKordaSalasona.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.txtKordaSalasona.Name = "txtKordaSalasona"
        Me.txtKordaSalasona.Size = New System.Drawing.Size(312, 27)
        Me.txtKordaSalasona.TabIndex = 21
        Me.txtKordaSalasona.UseSystemPasswordChar = True
        '
        'pnlProfiiliSeaded
        '
        Me.pnlProfiiliSeaded.Controls.Add(Me.GroupBox9)
        Me.pnlProfiiliSeaded.Controls.Add(Me.pbAlumineMees)
        Me.pnlProfiiliSeaded.Controls.Add(Me.GroupBox6)
        Me.pnlProfiiliSeaded.Controls.Add(Me.GroupBox5)
        Me.pnlProfiiliSeaded.Controls.Add(Me.GroupBox4)
        Me.pnlProfiiliSeaded.Controls.Add(Me.GroupBox3)
        Me.pnlProfiiliSeaded.Controls.Add(Me.lblProfiiliSeadedKasutajanimi)
        Me.pnlProfiiliSeaded.Controls.Add(Me.lblProfiiliSeadedEesnimi)
        Me.pnlProfiiliSeaded.Controls.Add(Me.pbAlumineNaine)
        Me.pnlProfiiliSeaded.Controls.Add(Me.Label20)
        Me.pnlProfiiliSeaded.Location = New System.Drawing.Point(232, 100)
        Me.pnlProfiiliSeaded.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlProfiiliSeaded.Name = "pnlProfiiliSeaded"
        Me.pnlProfiiliSeaded.Size = New System.Drawing.Size(838, 474)
        Me.pnlProfiiliSeaded.TabIndex = 4
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblKaloriLimiitViga)
        Me.GroupBox9.Controls.Add(Me.btnKaloriLimiit)
        Me.GroupBox9.Controls.Add(Me.txtKalorilimiit)
        Me.GroupBox9.Location = New System.Drawing.Point(23, 71)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Size = New System.Drawing.Size(270, 89)
        Me.GroupBox9.TabIndex = 17
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Kalorilimiidi seadmine"
        '
        'lblKaloriLimiitViga
        '
        Me.lblKaloriLimiitViga.AutoSize = True
        Me.lblKaloriLimiitViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaloriLimiitViga.ForeColor = System.Drawing.Color.Red
        Me.lblKaloriLimiitViga.Location = New System.Drawing.Point(19, 64)
        Me.lblKaloriLimiitViga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKaloriLimiitViga.Name = "lblKaloriLimiitViga"
        Me.lblKaloriLimiitViga.Size = New System.Drawing.Size(50, 21)
        Me.lblKaloriLimiitViga.TabIndex = 25
        Me.lblKaloriLimiitViga.Text = "VIGA"
        Me.lblKaloriLimiitViga.Visible = False
        '
        'btnKaloriLimiit
        '
        Me.btnKaloriLimiit.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnKaloriLimiit.FlatAppearance.BorderSize = 0
        Me.btnKaloriLimiit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnKaloriLimiit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaloriLimiit.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaloriLimiit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnKaloriLimiit.Location = New System.Drawing.Point(174, 27)
        Me.btnKaloriLimiit.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnKaloriLimiit.Name = "btnKaloriLimiit"
        Me.btnKaloriLimiit.Size = New System.Drawing.Size(86, 34)
        Me.btnKaloriLimiit.TabIndex = 24
        Me.btnKaloriLimiit.Text = "Sea"
        Me.btnKaloriLimiit.UseVisualStyleBackColor = False
        '
        'txtKalorilimiit
        '
        Me.txtKalorilimiit.Location = New System.Drawing.Point(18, 31)
        Me.txtKalorilimiit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKalorilimiit.Name = "txtKalorilimiit"
        Me.txtKalorilimiit.Size = New System.Drawing.Size(100, 27)
        Me.txtKalorilimiit.TabIndex = 0
        '
        'pbAlumineMees
        '
        Me.pbAlumineMees.BackgroundImage = CType(resources.GetObject("pbAlumineMees.BackgroundImage"), System.Drawing.Image)
        Me.pbAlumineMees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbAlumineMees.Location = New System.Drawing.Point(676, 30)
        Me.pbAlumineMees.Margin = New System.Windows.Forms.Padding(2)
        Me.pbAlumineMees.Name = "pbAlumineMees"
        Me.pbAlumineMees.Size = New System.Drawing.Size(154, 192)
        Me.pbAlumineMees.TabIndex = 16
        Me.pbAlumineMees.TabStop = False
        Me.pbAlumineMees.Visible = False
        '
        'pbAlumineNaine
        '
        Me.pbAlumineNaine.BackgroundImage = CType(resources.GetObject("pbAlumineNaine.BackgroundImage"), System.Drawing.Image)
        Me.pbAlumineNaine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbAlumineNaine.Location = New System.Drawing.Point(676, 30)
        Me.pbAlumineNaine.Margin = New System.Windows.Forms.Padding(2)
        Me.pbAlumineNaine.Name = "pbAlumineNaine"
        Me.pbAlumineNaine.Size = New System.Drawing.Size(154, 192)
        Me.pbAlumineNaine.TabIndex = 4
        Me.pbAlumineNaine.TabStop = False
        Me.pbAlumineNaine.Visible = False
        '
        'Pohiaken
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1065, 563)
        Me.Controls.Add(Me.pnlYlevaade)
        Me.Controls.Add(Me.pnlAjalugu)
        Me.Controls.Add(Me.pnlKodu)
        Me.Controls.Add(Me.pnlToidulaud)
        Me.Controls.Add(Me.pnlTreeningud)
        Me.Controls.Add(Me.pnlRakenduseInfo)
        Me.Controls.Add(Me.pnlProfiiliSeaded)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlLeftBar)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1081, 602)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(953, 490)
        Me.Name = "Pohiaken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Janar"
        Me.pnlLeftBar.ResumeLayout(False)
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.pbUlemineNaine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUlemineMees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToidulaud.ResumeLayout(False)
        Me.pnlToidulaud.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.pnlRakenduseInfo.ResumeLayout(False)
        Me.pnlRakenduseInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKodu.ResumeLayout(False)
        Me.pnlKodu.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.chrKoduPaneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTreeningud.ResumeLayout(False)
        Me.pnlTreeningud.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.pnlYlevaade.ResumeLayout(False)
        Me.pnlYlevaade.PerformLayout()
        Me.Kaal.ResumeLayout(False)
        Me.Kaal.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.chrKaaluMuutumine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.chrYlevaade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAjalugu.ResumeLayout(False)
        Me.pnlAjalugu.PerformLayout()
        CType(Me.chrAjalooPaneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.pnlProfiiliSeaded.ResumeLayout(False)
        Me.pnlProfiiliSeaded.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.pbAlumineMees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAlumineNaine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftBar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents btnLogiValja As Button
    Friend WithEvents pbUlemineMees As PictureBox
    Friend WithEvents btnProfiiliSeaded As Button
    Friend WithEvents lblEesnimi As Label
    Friend WithEvents btnKodu As Button
    Friend WithEvents pnlToidulaud As Panel
    Friend WithEvents btnAjalugu As Button
    Friend WithEvents btnYlevaade As Button
    Friend WithEvents btnTreeningud As Button
    Friend WithEvents btnToidulaud As Button
    Friend WithEvents pnlRakenduseInfo As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lnklblCarmen As LinkLabel
    Friend WithEvents lnklblEeva As LinkLabel
    Friend WithEvents lnklblKris As LinkLabel
    Friend WithEvents lnklblAleks As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlKodu As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents lblKoduEesnimi As Label
    Friend WithEvents pnlTreeningud As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pnlYlevaade As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents pnlAjalugu As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents pnlNuppudeTagapaneel As Panel
    Friend WithEvents pbUlemineNaine As PictureBox
    Friend WithEvents chrKoduPaneel As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNaitaYlevaadet As Button
    Friend WithEvents cmbAjaluguGraafikuPeriood As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnAjalooKuupaevTagasi As Button
    Friend WithEvents bntAjalooKuupaevEdasi As Button
    Friend WithEvents lblAjaluguNadalaPaev As Label
    Friend WithEvents lblAjaluguKuupaev As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents pbAlumineNaine As PictureBox
    Friend WithEvents lblProfiiliSeadedEesnimi As Label
    Friend WithEvents lblProfiiliSeadedKasutajanimi As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbMuudaPikkust As ComboBox
    Friend WithEvents btnMuudaPikkust As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents lblKasutajaPikkus As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbMuudaKaalu As ComboBox
    Friend WithEvents btnMuudaKaalu As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents lblKasutajaKaal As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cmbMuudaVanust As ComboBox
    Friend WithEvents btnMuudaVanust As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblKasutajaVanus As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtKehtivSalasona As TextBox
    Friend WithEvents lblVahetaSalasonaViga As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnKinnitaUusSalasona As Button
    Friend WithEvents txtVahetaSalasona As TextBox
    Friend WithEvents txtKordaSalasona As TextBox
    Friend WithEvents pbAlumineMees As PictureBox
    Friend WithEvents pnlProfiiliSeaded As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtUueToiduaineNimi As TextBox
    Friend WithEvents btnLisaUusToiduaine As Button
    Friend WithEvents txtUueToiduaineRasvad As TextBox
    Friend WithEvents txtUueToiduaineSuhkrud As TextBox
    Friend WithEvents txtUueToiduaineKcal As TextBox
    Friend WithEvents txtUueToiduaineSusivesikud As TextBox
    Friend WithEvents txtUueToiduaineValgud As TextBox
    Friend WithEvents lblUueToiduaineLisamineViga As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents cmbToiduaineKiirvalik As ComboBox
    Friend WithEvents btnToiduaineKiirvalikLisa As Button
    Friend WithEvents txtToiduaineKiirvalikKogus As TextBox
    Friend WithEvents chrKaaluMuutumine As DataVisualization.Charting.Chart
    Friend WithEvents LblPaevaneTarbimine As Label
    Friend WithEvents chrYlevaade As DataVisualization.Charting.Chart
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents rdbOhtu As RadioButton
    Friend WithEvents rdbVahepala As RadioButton
    Friend WithEvents rdbLouna As RadioButton
    Friend WithEvents rdbHommik As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents btnKaloriLimiit As Button
    Friend WithEvents txtKalorilimiit As TextBox
    Friend WithEvents lblKaloriLimiitViga As Label
    Friend WithEvents lblToiduAineRetseptiLisamineViga As Label
    Friend WithEvents lblKcalPaev As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lblTreeninguKiirvalikViga As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents btnTreeninguKiirvalikLisa As Button
    Friend WithEvents txtTreeninguKiirvalikKestus As TextBox
    Friend WithEvents cmbTreeninguteKiirvalik As ComboBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents lblTreeninguLisamineViga As Label
    Friend WithEvents txtTreeninguLisamineEnergialkulu As TextBox
    Friend WithEvents txtTreeninguLisamineNimi As TextBox
    Friend WithEvents btnTreeninguLisamine As Button
    Friend WithEvents Label47 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents lblToiduaineKustutamineViga As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents btnToiduaineKustutamine As Button
    Friend WithEvents cmbToiduaineKustutamine As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents btnPaevaneKaal As Button
    Friend WithEvents Kaal As GroupBox
    Friend WithEvents btnEesmargiKinnitamine As Button
    Friend WithEvents txtKaaluEesmärk As TextBox
    Friend WithEvents txtPaevaneKaal As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtRetseptiNimi As TextBox
    Friend WithEvents cmbRetseptiKoostisosad As ComboBox
    Friend WithEvents btnRetseptLisaKoostisosa As Button
    Friend WithEvents btnKinnitaRetsept As Button
    Friend WithEvents txtRetseptiKoostisosaKogus As TextBox
    Friend WithEvents lbRetseptiKoostisosad As ListBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents lblRetseptiLisamineViga As Label
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents btnKustutaTreening As Button
    Friend WithEvents cmbTreeninguKustutamine As ComboBox
    Friend WithEvents lblKustutaTreeningViga As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents chbMukbangFilter As CheckBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents chrAjalooPaneel As Chart
    Friend WithEvents lvPaevasedTreeningud As ListView
    Friend WithEvents lvPaevasedToidud As ListView
    Friend WithEvents toiduKord As ColumnHeader
    Friend WithEvents toiduNimetus As ColumnHeader
    Friend WithEvents toiduKcal As ColumnHeader
    Friend WithEvents treeninguNimi As ColumnHeader
    Friend WithEvents treeninguKalorid As ColumnHeader
    Friend WithEvents treeninguKestus As ColumnHeader
End Class
