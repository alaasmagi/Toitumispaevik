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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlYlevaade = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNaitaYlevaadet = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbAjaluguGraafikuPeriood = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chrYlevaade = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlAjalugu = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
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
        Me.lblKcalPaev = New System.Windows.Forms.Label()
        Me.pnlLeftBar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.pbUlemineNaine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUlemineMees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToidulaud.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.pnlRakenduseInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKodu.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.chrKoduPaneel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTreeningud.SuspendLayout()
        Me.pnlYlevaade.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chrYlevaade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAjalugu.SuspendLayout()
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
        Me.pnlLeftBar.Name = "pnlLeftBar"
        Me.pnlLeftBar.Size = New System.Drawing.Size(348, 886)
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
        Me.btnAjalugu.Location = New System.Drawing.Point(0, 496)
        Me.btnAjalugu.Name = "btnAjalugu"
        Me.btnAjalugu.Size = New System.Drawing.Size(348, 114)
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
        Me.btnYlevaade.Location = New System.Drawing.Point(0, 381)
        Me.btnYlevaade.Name = "btnYlevaade"
        Me.btnYlevaade.Size = New System.Drawing.Size(348, 114)
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
        Me.btnTreeningud.Location = New System.Drawing.Point(0, 266)
        Me.btnTreeningud.Name = "btnTreeningud"
        Me.btnTreeningud.Size = New System.Drawing.Size(348, 114)
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
        Me.btnToidulaud.Location = New System.Drawing.Point(0, 150)
        Me.btnToidulaud.Name = "btnToidulaud"
        Me.btnToidulaud.Size = New System.Drawing.Size(348, 114)
        Me.btnToidulaud.TabIndex = 8
        Me.btnToidulaud.Text = " Toidulaud"
        Me.btnToidulaud.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnToidulaud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnToidulaud.UseVisualStyleBackColor = False
        '
        'pnlNuppudeTagapaneel
        '
        Me.pnlNuppudeTagapaneel.BackColor = System.Drawing.Color.Silver
        Me.pnlNuppudeTagapaneel.Location = New System.Drawing.Point(69, 150)
        Me.pnlNuppudeTagapaneel.Name = "pnlNuppudeTagapaneel"
        Me.pnlNuppudeTagapaneel.Size = New System.Drawing.Size(213, 459)
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
        Me.btnKodu.Location = New System.Drawing.Point(0, 753)
        Me.btnKodu.Name = "btnKodu"
        Me.btnKodu.Size = New System.Drawing.Size(348, 114)
        Me.btnKodu.TabIndex = 7
        Me.btnKodu.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.taissuuruses_logo_taustata_väike
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(348, 150)
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
        Me.pnlTopBar.Location = New System.Drawing.Point(348, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1263, 150)
        Me.pnlTopBar.TabIndex = 1
        '
        'pbUlemineNaine
        '
        Me.pbUlemineNaine.Image = CType(resources.GetObject("pbUlemineNaine.Image"), System.Drawing.Image)
        Me.pbUlemineNaine.Location = New System.Drawing.Point(39, 39)
        Me.pbUlemineNaine.Name = "pbUlemineNaine"
        Me.pbUlemineNaine.Size = New System.Drawing.Size(81, 75)
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
        Me.btnLogiValja.Location = New System.Drawing.Point(1011, 0)
        Me.btnLogiValja.Name = "btnLogiValja"
        Me.btnLogiValja.Size = New System.Drawing.Size(267, 150)
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
        Me.btnProfiiliSeaded.Location = New System.Drawing.Point(747, 0)
        Me.btnProfiiliSeaded.Name = "btnProfiiliSeaded"
        Me.btnProfiiliSeaded.Size = New System.Drawing.Size(267, 150)
        Me.btnProfiiliSeaded.TabIndex = 3
        Me.btnProfiiliSeaded.Text = "Profiili seaded"
        Me.btnProfiiliSeaded.UseVisualStyleBackColor = False
        '
        'lblEesnimi
        '
        Me.lblEesnimi.AutoSize = True
        Me.lblEesnimi.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEesnimi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lblEesnimi.Location = New System.Drawing.Point(129, 57)
        Me.lblEesnimi.Name = "lblEesnimi"
        Me.lblEesnimi.Size = New System.Drawing.Size(100, 30)
        Me.lblEesnimi.TabIndex = 2
        Me.lblEesnimi.Text = "Eesnimi"
        '
        'pbUlemineMees
        '
        Me.pbUlemineMees.Image = CType(resources.GetObject("pbUlemineMees.Image"), System.Drawing.Image)
        Me.pbUlemineMees.Location = New System.Drawing.Point(39, 39)
        Me.pbUlemineMees.Name = "pbUlemineMees"
        Me.pbUlemineMees.Size = New System.Drawing.Size(81, 75)
        Me.pbUlemineMees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUlemineMees.TabIndex = 2
        Me.pbUlemineMees.TabStop = False
        Me.pbUlemineMees.Visible = False
        '
        'pnlToidulaud
        '
        Me.pnlToidulaud.Controls.Add(Me.GroupBox7)
        Me.pnlToidulaud.Controls.Add(Me.Label15)
        Me.pnlToidulaud.Location = New System.Drawing.Point(348, 150)
        Me.pnlToidulaud.Name = "pnlToidulaud"
        Me.pnlToidulaud.Size = New System.Drawing.Size(1278, 786)
        Me.pnlToidulaud.TabIndex = 2
        Me.pnlToidulaud.Visible = False
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
        Me.GroupBox7.Location = New System.Drawing.Point(39, 123)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(492, 621)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Toiduaine lisamine andmebaasi"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(274, 453)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(93, 28)
        Me.Label39.TabIndex = 45
        Me.Label39.Text = "g/100g"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(274, 386)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(93, 28)
        Me.Label38.TabIndex = 44
        Me.Label38.Text = "g/100g"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(274, 310)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(93, 28)
        Me.Label37.TabIndex = 43
        Me.Label37.Text = "g/100g"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(274, 236)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(93, 28)
        Me.Label36.TabIndex = 42
        Me.Label36.Text = "g/100g"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(278, 164)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(127, 28)
        Me.Label35.TabIndex = 41
        Me.Label35.Text = "kcal/100g"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(58, 446)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(103, 28)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "Rasvad:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(58, 378)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 28)
        Me.Label33.TabIndex = 39
        Me.Label33.Text = "Valgud:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(60, 303)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(110, 28)
        Me.Label32.TabIndex = 38
        Me.Label32.Text = "Suhkrud:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(24, 228)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(147, 28)
        Me.Label31.TabIndex = 37
        Me.Label31.Text = "Süsivesikud:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(60, 156)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(108, 28)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Energia:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(46, 86)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(115, 28)
        Me.Label29.TabIndex = 35
        Me.Label29.Text = "Nimetus:"
        '
        'lblUueToiduaineLisamineViga
        '
        Me.lblUueToiduaineLisamineViga.AutoSize = True
        Me.lblUueToiduaineLisamineViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUueToiduaineLisamineViga.ForeColor = System.Drawing.Color.Red
        Me.lblUueToiduaineLisamineViga.Location = New System.Drawing.Point(78, 578)
        Me.lblUueToiduaineLisamineViga.Name = "lblUueToiduaineLisamineViga"
        Me.lblUueToiduaineLisamineViga.Size = New System.Drawing.Size(75, 30)
        Me.lblUueToiduaineLisamineViga.TabIndex = 34
        Me.lblUueToiduaineLisamineViga.Text = "VIGA"
        Me.lblUueToiduaineLisamineViga.Visible = False
        '
        'txtUueToiduaineRasvad
        '
        Me.txtUueToiduaineRasvad.Location = New System.Drawing.Point(195, 441)
        Me.txtUueToiduaineRasvad.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtUueToiduaineRasvad.Name = "txtUueToiduaineRasvad"
        Me.txtUueToiduaineRasvad.Size = New System.Drawing.Size(76, 37)
        Me.txtUueToiduaineRasvad.TabIndex = 33
        '
        'txtUueToiduaineSuhkrud
        '
        Me.txtUueToiduaineSuhkrud.Location = New System.Drawing.Point(192, 298)
        Me.txtUueToiduaineSuhkrud.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtUueToiduaineSuhkrud.Name = "txtUueToiduaineSuhkrud"
        Me.txtUueToiduaineSuhkrud.Size = New System.Drawing.Size(79, 37)
        Me.txtUueToiduaineSuhkrud.TabIndex = 32
        '
        'txtUueToiduaineKcal
        '
        Me.txtUueToiduaineKcal.Location = New System.Drawing.Point(192, 152)
        Me.txtUueToiduaineKcal.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtUueToiduaineKcal.Name = "txtUueToiduaineKcal"
        Me.txtUueToiduaineKcal.Size = New System.Drawing.Size(82, 37)
        Me.txtUueToiduaineKcal.TabIndex = 31
        '
        'txtUueToiduaineSusivesikud
        '
        Me.txtUueToiduaineSusivesikud.Location = New System.Drawing.Point(192, 224)
        Me.txtUueToiduaineSusivesikud.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtUueToiduaineSusivesikud.Name = "txtUueToiduaineSusivesikud"
        Me.txtUueToiduaineSusivesikud.Size = New System.Drawing.Size(79, 37)
        Me.txtUueToiduaineSusivesikud.TabIndex = 30
        '
        'txtUueToiduaineValgud
        '
        Me.txtUueToiduaineValgud.Location = New System.Drawing.Point(192, 374)
        Me.txtUueToiduaineValgud.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtUueToiduaineValgud.Name = "txtUueToiduaineValgud"
        Me.txtUueToiduaineValgud.Size = New System.Drawing.Size(79, 37)
        Me.txtUueToiduaineValgud.TabIndex = 29
        '
        'txtUueToiduaineNimi
        '
        Me.txtUueToiduaineNimi.Location = New System.Drawing.Point(192, 81)
        Me.txtUueToiduaineNimi.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtUueToiduaineNimi.Name = "txtUueToiduaineNimi"
        Me.txtUueToiduaineNimi.Size = New System.Drawing.Size(250, 37)
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
        Me.btnLisaUusToiduaine.Location = New System.Drawing.Point(24, 516)
        Me.btnLisaUusToiduaine.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnLisaUusToiduaine.Name = "btnLisaUusToiduaine"
        Me.btnLisaUusToiduaine.Size = New System.Drawing.Size(414, 51)
        Me.btnLisaUusToiduaine.TabIndex = 28
        Me.btnLisaUusToiduaine.Text = "Lisa"
        Me.btnLisaUusToiduaine.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(33, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(192, 45)
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
        Me.pnlRakenduseInfo.Location = New System.Drawing.Point(348, 150)
        Me.pnlRakenduseInfo.Name = "pnlRakenduseInfo"
        Me.pnlRakenduseInfo.Size = New System.Drawing.Size(1278, 786)
        Me.pnlRakenduseInfo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(480, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 30)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Results"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(480, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 30)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Activity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(480, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nutrition"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(480, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Accountability"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(483, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 30)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Journey"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1101, 747)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 28)
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
        Me.GroupBox1.Location = New System.Drawing.Point(42, 357)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 360)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arendajad"
        '
        'lnklblCarmen
        '
        Me.lnklblCarmen.AutoSize = True
        Me.lnklblCarmen.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblCarmen.Location = New System.Drawing.Point(441, 225)
        Me.lnklblCarmen.Name = "lnklblCarmen"
        Me.lnklblCarmen.Size = New System.Drawing.Size(207, 28)
        Me.lnklblCarmen.TabIndex = 7
        Me.lnklblCarmen.TabStop = True
        Me.lnklblCarmen.Text = "Carmeni GitHub"
        '
        'lnklblEeva
        '
        Me.lnklblEeva.AutoSize = True
        Me.lnklblEeva.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblEeva.Location = New System.Drawing.Point(408, 282)
        Me.lnklblEeva.Name = "lnklblEeva"
        Me.lnklblEeva.Size = New System.Drawing.Size(236, 28)
        Me.lnklblEeva.TabIndex = 6
        Me.lnklblEeva.TabStop = True
        Me.lnklblEeva.Text = "Eeva-Maria GitHub"
        '
        'lnklblKris
        '
        Me.lnklblKris.AutoSize = True
        Me.lnklblKris.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblKris.Location = New System.Drawing.Point(441, 165)
        Me.lnklblKris.Name = "lnklblKris"
        Me.lnklblKris.Size = New System.Drawing.Size(200, 28)
        Me.lnklblKris.TabIndex = 5
        Me.lnklblKris.TabStop = True
        Me.lnklblKris.Text = "Kristoferi GitHub"
        '
        'lnklblAleks
        '
        Me.lnklblAleks.AutoSize = True
        Me.lnklblAleks.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblAleks.LinkColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lnklblAleks.Location = New System.Drawing.Point(423, 111)
        Me.lnklblAleks.Name = "lnklblAleks"
        Me.lnklblAleks.Size = New System.Drawing.Size(224, 28)
        Me.lnklblAleks.TabIndex = 4
        Me.lnklblAleks.TabStop = True
        Me.lnklblAleks.Text = "Aleksandri GitHub"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 28)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Eeva-Maria Tšernova"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Carmen Raun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Kristofer Mäeots"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Aleksander Laasmägi"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.taissuuruses_logo_taustata_väike
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(42, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(405, 225)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'pnlKodu
        '
        Me.pnlKodu.Controls.Add(Me.lblKcalPaev)
        Me.pnlKodu.Controls.Add(Me.GroupBox8)
        Me.pnlKodu.Controls.Add(Me.chrKoduPaneel)
        Me.pnlKodu.Controls.Add(Me.lblKoduEesnimi)
        Me.pnlKodu.Controls.Add(Me.Label13)
        Me.pnlKodu.Location = New System.Drawing.Point(348, 150)
        Me.pnlKodu.Name = "pnlKodu"
        Me.pnlKodu.Size = New System.Drawing.Size(1281, 786)
        Me.pnlKodu.TabIndex = 11
        '
        'GroupBox8
        '
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
        Me.GroupBox8.Location = New System.Drawing.Point(712, 112)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(536, 278)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Toidukorra lisamine"
        '
        'lblToiduAineRetseptiLisamineViga
        '
        Me.lblToiduAineRetseptiLisamineViga.AutoSize = True
        Me.lblToiduAineRetseptiLisamineViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToiduAineRetseptiLisamineViga.ForeColor = System.Drawing.Color.Red
        Me.lblToiduAineRetseptiLisamineViga.Location = New System.Drawing.Point(62, 237)
        Me.lblToiduAineRetseptiLisamineViga.Name = "lblToiduAineRetseptiLisamineViga"
        Me.lblToiduAineRetseptiLisamineViga.Size = New System.Drawing.Size(75, 30)
        Me.lblToiduAineRetseptiLisamineViga.TabIndex = 36
        Me.lblToiduAineRetseptiLisamineViga.Text = "VIGA"
        Me.lblToiduAineRetseptiLisamineViga.Visible = False
        '
        'rdbOhtu
        '
        Me.rdbOhtu.AutoSize = True
        Me.rdbOhtu.ForeColor = System.Drawing.Color.Black
        Me.rdbOhtu.Location = New System.Drawing.Point(426, 200)
        Me.rdbOhtu.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbOhtu.Name = "rdbOhtu"
        Me.rdbOhtu.Size = New System.Drawing.Size(97, 32)
        Me.rdbOhtu.TabIndex = 35
        Me.rdbOhtu.TabStop = True
        Me.rdbOhtu.Text = "Õhtu"
        Me.rdbOhtu.UseVisualStyleBackColor = True
        '
        'rdbVahepala
        '
        Me.rdbVahepala.AutoSize = True
        Me.rdbVahepala.ForeColor = System.Drawing.Color.Black
        Me.rdbVahepala.Location = New System.Drawing.Point(258, 200)
        Me.rdbVahepala.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbVahepala.Name = "rdbVahepala"
        Me.rdbVahepala.Size = New System.Drawing.Size(155, 32)
        Me.rdbVahepala.TabIndex = 34
        Me.rdbVahepala.TabStop = True
        Me.rdbVahepala.Text = "Vahepala"
        Me.rdbVahepala.UseVisualStyleBackColor = True
        '
        'rdbLouna
        '
        Me.rdbLouna.AutoSize = True
        Me.rdbLouna.ForeColor = System.Drawing.Color.Black
        Me.rdbLouna.Location = New System.Drawing.Point(144, 200)
        Me.rdbLouna.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbLouna.Name = "rdbLouna"
        Me.rdbLouna.Size = New System.Drawing.Size(111, 32)
        Me.rdbLouna.TabIndex = 33
        Me.rdbLouna.TabStop = True
        Me.rdbLouna.Text = "Lõuna"
        Me.rdbLouna.UseVisualStyleBackColor = True
        '
        'rdbHommik
        '
        Me.rdbHommik.AutoSize = True
        Me.rdbHommik.ForeColor = System.Drawing.Color.Black
        Me.rdbHommik.Location = New System.Drawing.Point(8, 200)
        Me.rdbHommik.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbHommik.Name = "rdbHommik"
        Me.rdbHommik.Size = New System.Drawing.Size(135, 32)
        Me.rdbHommik.TabIndex = 32
        Me.rdbHommik.TabStop = True
        Me.rdbHommik.Text = "Hommik"
        Me.rdbHommik.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(30, 134)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(131, 28)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Kogus (g):"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(38, 72)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(115, 28)
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
        Me.btnToiduaineKiirvalikLisa.Location = New System.Drawing.Point(330, 128)
        Me.btnToiduaineKiirvalikLisa.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnToiduaineKiirvalikLisa.Name = "btnToiduaineKiirvalikLisa"
        Me.btnToiduaineKiirvalikLisa.Size = New System.Drawing.Size(129, 42)
        Me.btnToiduaineKiirvalikLisa.TabIndex = 29
        Me.btnToiduaineKiirvalikLisa.Text = "Lisa"
        Me.btnToiduaineKiirvalikLisa.UseVisualStyleBackColor = False
        '
        'txtToiduaineKiirvalikKogus
        '
        Me.txtToiduaineKiirvalikKogus.Location = New System.Drawing.Point(177, 129)
        Me.txtToiduaineKiirvalikKogus.Name = "txtToiduaineKiirvalikKogus"
        Me.txtToiduaineKiirvalikKogus.Size = New System.Drawing.Size(76, 37)
        Me.txtToiduaineKiirvalikKogus.TabIndex = 25
        '
        'cmbToiduaineKiirvalik
        '
        Me.cmbToiduaineKiirvalik.DropDownHeight = 100
        Me.cmbToiduaineKiirvalik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToiduaineKiirvalik.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbToiduaineKiirvalik.FormattingEnabled = True
        Me.cmbToiduaineKiirvalik.IntegralHeight = False
        Me.cmbToiduaineKiirvalik.ItemHeight = 26
        Me.cmbToiduaineKiirvalik.Location = New System.Drawing.Point(177, 64)
        Me.cmbToiduaineKiirvalik.Name = "cmbToiduaineKiirvalik"
        Me.cmbToiduaineKiirvalik.Size = New System.Drawing.Size(280, 34)
        Me.cmbToiduaineKiirvalik.TabIndex = 24
        '
        'chrKoduPaneel
        '
        Me.chrKoduPaneel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrKoduPaneel.BorderlineColor = System.Drawing.Color.Black
        Me.chrKoduPaneel.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrKoduPaneel.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chrKoduPaneel.BorderSkin.PageColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea4.Name = "ChartArea1"
        Me.chrKoduPaneel.ChartAreas.Add(ChartArea4)
        Legend4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Legend4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Me.chrKoduPaneel.Legends.Add(Legend4)
        Me.chrKoduPaneel.Location = New System.Drawing.Point(42, 112)
        Me.chrKoduPaneel.Name = "chrKoduPaneel"
        Me.chrKoduPaneel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.chrKoduPaneel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.Legend = "Legend1"
        Series4.Name = "Soogikorrad"
        Series4.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White
        Me.chrKoduPaneel.Series.Add(Series4)
        Me.chrKoduPaneel.Size = New System.Drawing.Size(648, 574)
        Me.chrKoduPaneel.TabIndex = 6
        Title3.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Päevane tarbimine"
        Me.chrKoduPaneel.Titles.Add(Title3)
        '
        'lblKoduEesnimi
        '
        Me.lblKoduEesnimi.AutoSize = True
        Me.lblKoduEesnimi.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKoduEesnimi.ForeColor = System.Drawing.Color.Black
        Me.lblKoduEesnimi.Location = New System.Drawing.Point(123, 45)
        Me.lblKoduEesnimi.Name = "lblKoduEesnimi"
        Me.lblKoduEesnimi.Size = New System.Drawing.Size(162, 45)
        Me.lblKoduEesnimi.TabIndex = 1
        Me.lblKoduEesnimi.Text = "Eesnimi!"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(33, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 45)
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
        Me.pnlTreeningud.Controls.Add(Me.Label16)
        Me.pnlTreeningud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlTreeningud.Location = New System.Drawing.Point(348, 150)
        Me.pnlTreeningud.Name = "pnlTreeningud"
        Me.pnlTreeningud.Size = New System.Drawing.Size(1281, 786)
        Me.pnlTreeningud.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(33, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(216, 45)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Treeningud"
        '
        'pnlYlevaade
        '
        Me.pnlYlevaade.Controls.Add(Me.Chart1)
        Me.pnlYlevaade.Controls.Add(Me.GroupBox2)
        Me.pnlYlevaade.Controls.Add(Me.Label17)
        Me.pnlYlevaade.Location = New System.Drawing.Point(348, 150)
        Me.pnlYlevaade.Name = "pnlYlevaade"
        Me.pnlYlevaade.Size = New System.Drawing.Size(1281, 786)
        Me.pnlYlevaade.TabIndex = 4
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea5.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea5)
        Legend5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Legend5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend5.IsTextAutoFit = False
        Legend5.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend5)
        Me.Chart1.Location = New System.Drawing.Point(681, 116)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.Chart1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series5.IsValueShownAsLabel = True
        Series5.Legend = "Legend1"
        Series5.Name = "Soogikorrad"
        Series5.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(564, 462)
        Me.Chart1.TabIndex = 22
        Title4.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Päevane tarbimine"
        Me.Chart1.Titles.Add(Title4)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNaitaYlevaadet)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmbAjaluguGraafikuPeriood)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(33, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 390)
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
        Me.btnNaitaYlevaadet.Location = New System.Drawing.Point(24, 303)
        Me.btnNaitaYlevaadet.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnNaitaYlevaadet.Name = "btnNaitaYlevaadet"
        Me.btnNaitaYlevaadet.Size = New System.Drawing.Size(381, 63)
        Me.btnNaitaYlevaadet.TabIndex = 21
        Me.btnNaitaYlevaadet.Text = "Kuva ülevaade"
        Me.btnNaitaYlevaadet.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(153, 123)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 32)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Kehakaal"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 123)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(118, 28)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Andmed"
        '
        'cmbAjaluguGraafikuPeriood
        '
        Me.cmbAjaluguGraafikuPeriood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAjaluguGraafikuPeriood.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAjaluguGraafikuPeriood.FormattingEnabled = True
        Me.cmbAjaluguGraafikuPeriood.Location = New System.Drawing.Point(153, 51)
        Me.cmbAjaluguGraafikuPeriood.Name = "cmbAjaluguGraafikuPeriood"
        Me.cmbAjaluguGraafikuPeriood.Size = New System.Drawing.Size(253, 34)
        Me.cmbAjaluguGraafikuPeriood.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 28)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Periood"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(33, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(190, 45)
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
        ChartArea6.Name = "ChartArea1"
        Me.chrYlevaade.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.chrYlevaade.Legends.Add(Legend6)
        Me.chrYlevaade.Location = New System.Drawing.Point(677, 101)
        Me.chrYlevaade.Margin = New System.Windows.Forms.Padding(5)
        Me.chrYlevaade.Name = "chrYlevaade"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Me.chrYlevaade.Series.Add(Series6)
        Me.chrYlevaade.Size = New System.Drawing.Size(992, 892)
        Me.chrYlevaade.TabIndex = 8
        Me.chrYlevaade.Text = "Ajalugu"
        '
        'pnlAjalugu
        '
        Me.pnlAjalugu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlAjalugu.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlAjalugu.Controls.Add(Me.Button2)
        Me.pnlAjalugu.Controls.Add(Me.Button1)
        Me.pnlAjalugu.Controls.Add(Me.Label26)
        Me.pnlAjalugu.Controls.Add(Me.Label25)
        Me.pnlAjalugu.Controls.Add(Me.Label18)
        Me.pnlAjalugu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAjalugu.ForeColor = System.Drawing.Color.Black
        Me.pnlAjalugu.Location = New System.Drawing.Point(348, 150)
        Me.pnlAjalugu.Name = "pnlAjalugu"
        Me.pnlAjalugu.Size = New System.Drawing.Size(1263, 786)
        Me.pnlAjalugu.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(494, 248)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(226, 147)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button2.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_double_left_64
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(356, 126)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 38)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button1.BackgroundImage = Global.Toitumispaevik_UI.My.Resources.Resources.icons8_double_right_64
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(730, 126)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 38)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(450, 126)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(90, 36)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Täna,"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(537, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(195, 36)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "DD.MM.YYYY"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(33, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 45)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Ajalugu"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(33, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(265, 45)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Profiili seaded"
        '
        'lblProfiiliSeadedEesnimi
        '
        Me.lblProfiiliSeadedEesnimi.AutoSize = True
        Me.lblProfiiliSeadedEesnimi.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfiiliSeadedEesnimi.ForeColor = System.Drawing.Color.Black
        Me.lblProfiiliSeadedEesnimi.Location = New System.Drawing.Point(804, 135)
        Me.lblProfiiliSeadedEesnimi.Name = "lblProfiiliSeadedEesnimi"
        Me.lblProfiiliSeadedEesnimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblProfiiliSeadedEesnimi.Size = New System.Drawing.Size(133, 39)
        Me.lblProfiiliSeadedEesnimi.TabIndex = 5
        Me.lblProfiiliSeadedEesnimi.Text = "Eesnimi"
        Me.lblProfiiliSeadedEesnimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfiiliSeadedKasutajanimi
        '
        Me.lblProfiiliSeadedKasutajanimi.AutoSize = True
        Me.lblProfiiliSeadedKasutajanimi.ForeColor = System.Drawing.Color.Black
        Me.lblProfiiliSeadedKasutajanimi.Location = New System.Drawing.Point(819, 174)
        Me.lblProfiiliSeadedKasutajanimi.Name = "lblProfiiliSeadedKasutajanimi"
        Me.lblProfiiliSeadedKasutajanimi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblProfiiliSeadedKasutajanimi.Size = New System.Drawing.Size(113, 28)
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
        Me.GroupBox3.Location = New System.Drawing.Point(42, 592)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(405, 153)
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
        Me.cmbMuudaPikkust.Location = New System.Drawing.Point(24, 75)
        Me.cmbMuudaPikkust.Name = "cmbMuudaPikkust"
        Me.cmbMuudaPikkust.Size = New System.Drawing.Size(109, 34)
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
        Me.btnMuudaPikkust.Location = New System.Drawing.Point(261, 66)
        Me.btnMuudaPikkust.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnMuudaPikkust.Name = "btnMuudaPikkust"
        Me.btnMuudaPikkust.Size = New System.Drawing.Size(129, 51)
        Me.btnMuudaPikkust.TabIndex = 23
        Me.btnMuudaPikkust.Text = "Muuda"
        Me.btnMuudaPikkust.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(75, 45)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 28)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "cm"
        '
        'lblKasutajaPikkus
        '
        Me.lblKasutajaPikkus.AutoSize = True
        Me.lblKasutajaPikkus.Location = New System.Drawing.Point(27, 45)
        Me.lblKasutajaPikkus.Name = "lblKasutajaPikkus"
        Me.lblKasutajaPikkus.Size = New System.Drawing.Size(51, 28)
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
        Me.GroupBox4.Location = New System.Drawing.Point(42, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(405, 153)
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
        Me.cmbMuudaKaalu.Location = New System.Drawing.Point(30, 86)
        Me.cmbMuudaKaalu.Name = "cmbMuudaKaalu"
        Me.cmbMuudaKaalu.Size = New System.Drawing.Size(109, 34)
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
        Me.btnMuudaKaalu.Location = New System.Drawing.Point(264, 76)
        Me.btnMuudaKaalu.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnMuudaKaalu.Name = "btnMuudaKaalu"
        Me.btnMuudaKaalu.Size = New System.Drawing.Size(129, 51)
        Me.btnMuudaKaalu.TabIndex = 23
        Me.btnMuudaKaalu.Text = "Muuda"
        Me.btnMuudaKaalu.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(75, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 28)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "kg"
        '
        'lblKasutajaKaal
        '
        Me.lblKasutajaKaal.AutoSize = True
        Me.lblKasutajaKaal.Location = New System.Drawing.Point(27, 48)
        Me.lblKasutajaKaal.Name = "lblKasutajaKaal"
        Me.lblKasutajaKaal.Size = New System.Drawing.Size(51, 28)
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
        Me.GroupBox5.Location = New System.Drawing.Point(42, 434)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(405, 153)
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
        Me.cmbMuudaVanust.ItemHeight = 26
        Me.cmbMuudaVanust.Location = New System.Drawing.Point(30, 88)
        Me.cmbMuudaVanust.Name = "cmbMuudaVanust"
        Me.cmbMuudaVanust.Size = New System.Drawing.Size(109, 34)
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
        Me.btnMuudaVanust.Location = New System.Drawing.Point(264, 82)
        Me.btnMuudaVanust.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnMuudaVanust.Name = "btnMuudaVanust"
        Me.btnMuudaVanust.Size = New System.Drawing.Size(129, 51)
        Me.btnMuudaVanust.TabIndex = 22
        Me.btnMuudaVanust.Text = "Muuda"
        Me.btnMuudaVanust.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "aastat"
        '
        'lblKasutajaVanus
        '
        Me.lblKasutajaVanus.AutoSize = True
        Me.lblKasutajaVanus.Location = New System.Drawing.Point(27, 54)
        Me.lblKasutajaVanus.Name = "lblKasutajaVanus"
        Me.lblKasutajaVanus.Size = New System.Drawing.Size(51, 28)
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
        Me.GroupBox6.Location = New System.Drawing.Point(489, 372)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(771, 372)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Vaheta salasõna"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(75, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(202, 28)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Kehtiv salasõna:"
        '
        'txtKehtivSalasona
        '
        Me.txtKehtivSalasona.Location = New System.Drawing.Point(291, 51)
        Me.txtKehtivSalasona.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtKehtivSalasona.Name = "txtKehtivSalasona"
        Me.txtKehtivSalasona.Size = New System.Drawing.Size(466, 37)
        Me.txtKehtivSalasona.TabIndex = 26
        Me.txtKehtivSalasona.UseSystemPasswordChar = True
        '
        'lblVahetaSalasonaViga
        '
        Me.lblVahetaSalasonaViga.AutoSize = True
        Me.lblVahetaSalasonaViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVahetaSalasonaViga.ForeColor = System.Drawing.Color.Red
        Me.lblVahetaSalasonaViga.Location = New System.Drawing.Point(66, 231)
        Me.lblVahetaSalasonaViga.Name = "lblVahetaSalasonaViga"
        Me.lblVahetaSalasonaViga.Size = New System.Drawing.Size(75, 30)
        Me.lblVahetaSalasonaViga.TabIndex = 25
        Me.lblVahetaSalasonaViga.Text = "VIGA"
        Me.lblVahetaSalasonaViga.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(33, 183)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(244, 28)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Korda uut salasõna:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 28)
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
        Me.btnKinnitaUusSalasona.Location = New System.Drawing.Point(291, 267)
        Me.btnKinnitaUusSalasona.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnKinnitaUusSalasona.Name = "btnKinnitaUusSalasona"
        Me.btnKinnitaUusSalasona.Size = New System.Drawing.Size(468, 75)
        Me.btnKinnitaUusSalasona.TabIndex = 22
        Me.btnKinnitaUusSalasona.Text = "Kinnita uus salasõna"
        Me.btnKinnitaUusSalasona.UseVisualStyleBackColor = False
        '
        'txtVahetaSalasona
        '
        Me.txtVahetaSalasona.Location = New System.Drawing.Point(291, 117)
        Me.txtVahetaSalasona.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtVahetaSalasona.Name = "txtVahetaSalasona"
        Me.txtVahetaSalasona.Size = New System.Drawing.Size(466, 37)
        Me.txtVahetaSalasona.TabIndex = 20
        Me.txtVahetaSalasona.UseSystemPasswordChar = True
        '
        'txtKordaSalasona
        '
        Me.txtKordaSalasona.Location = New System.Drawing.Point(291, 180)
        Me.txtKordaSalasona.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.txtKordaSalasona.Name = "txtKordaSalasona"
        Me.txtKordaSalasona.Size = New System.Drawing.Size(466, 37)
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
        Me.pnlProfiiliSeaded.Location = New System.Drawing.Point(348, 150)
        Me.pnlProfiiliSeaded.Name = "pnlProfiiliSeaded"
        Me.pnlProfiiliSeaded.Size = New System.Drawing.Size(1281, 786)
        Me.pnlProfiiliSeaded.TabIndex = 4
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblKaloriLimiitViga)
        Me.GroupBox9.Controls.Add(Me.btnKaloriLimiit)
        Me.GroupBox9.Controls.Add(Me.txtKalorilimiit)
        Me.GroupBox9.Location = New System.Drawing.Point(42, 116)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(405, 153)
        Me.GroupBox9.TabIndex = 17
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Kalorilimiidi seadmine"
        '
        'lblKaloriLimiitViga
        '
        Me.lblKaloriLimiitViga.AutoSize = True
        Me.lblKaloriLimiitViga.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaloriLimiitViga.ForeColor = System.Drawing.Color.Red
        Me.lblKaloriLimiitViga.Location = New System.Drawing.Point(27, 92)
        Me.lblKaloriLimiitViga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKaloriLimiitViga.Name = "lblKaloriLimiitViga"
        Me.lblKaloriLimiitViga.Size = New System.Drawing.Size(75, 30)
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
        Me.btnKaloriLimiit.Location = New System.Drawing.Point(261, 36)
        Me.btnKaloriLimiit.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.btnKaloriLimiit.Name = "btnKaloriLimiit"
        Me.btnKaloriLimiit.Size = New System.Drawing.Size(129, 51)
        Me.btnKaloriLimiit.TabIndex = 24
        Me.btnKaloriLimiit.Text = "Sea"
        Me.btnKaloriLimiit.UseVisualStyleBackColor = False
        '
        'txtKalorilimiit
        '
        Me.txtKalorilimiit.Location = New System.Drawing.Point(28, 44)
        Me.txtKalorilimiit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKalorilimiit.Name = "txtKalorilimiit"
        Me.txtKalorilimiit.Size = New System.Drawing.Size(148, 37)
        Me.txtKalorilimiit.TabIndex = 0
        '
        'pbAlumineMees
        '
        Me.pbAlumineMees.BackgroundImage = CType(resources.GetObject("pbAlumineMees.BackgroundImage"), System.Drawing.Image)
        Me.pbAlumineMees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbAlumineMees.Location = New System.Drawing.Point(1017, 45)
        Me.pbAlumineMees.Name = "pbAlumineMees"
        Me.pbAlumineMees.Size = New System.Drawing.Size(231, 288)
        Me.pbAlumineMees.TabIndex = 16
        Me.pbAlumineMees.TabStop = False
        Me.pbAlumineMees.Visible = False
        '
        'pbAlumineNaine
        '
        Me.pbAlumineNaine.BackgroundImage = CType(resources.GetObject("pbAlumineNaine.BackgroundImage"), System.Drawing.Image)
        Me.pbAlumineNaine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbAlumineNaine.Location = New System.Drawing.Point(1017, 45)
        Me.pbAlumineNaine.Name = "pbAlumineNaine"
        Me.pbAlumineNaine.Size = New System.Drawing.Size(231, 288)
        Me.pbAlumineNaine.TabIndex = 4
        Me.pbAlumineNaine.TabStop = False
        Me.pbAlumineNaine.Visible = False
        '
        'lblKcalPaev
        '
        Me.lblKcalPaev.AutoSize = True
        Me.lblKcalPaev.Location = New System.Drawing.Point(217, 372)
        Me.lblKcalPaev.Name = "lblKcalPaev"
        Me.lblKcalPaev.Size = New System.Drawing.Size(103, 28)
        Me.lblKcalPaev.TabIndex = 8
        Me.lblKcalPaev.Text = "Label40"
        Me.lblKcalPaev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Pohiaken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1611, 886)
        Me.Controls.Add(Me.pnlKodu)
        Me.Controls.Add(Me.pnlProfiiliSeaded)
        Me.Controls.Add(Me.pnlToidulaud)
        Me.Controls.Add(Me.pnlTreeningud)
        Me.Controls.Add(Me.pnlRakenduseInfo)
        Me.Controls.Add(Me.pnlAjalugu)
        Me.Controls.Add(Me.pnlYlevaade)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlLeftBar)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1633, 942)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1440, 774)
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
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.pnlRakenduseInfo.ResumeLayout(False)
        Me.pnlRakenduseInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKodu.ResumeLayout(False)
        Me.pnlKodu.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.chrKoduPaneel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTreeningud.ResumeLayout(False)
        Me.pnlTreeningud.PerformLayout()
        Me.pnlYlevaade.ResumeLayout(False)
        Me.pnlYlevaade.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.chrYlevaade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAjalugu.ResumeLayout(False)
        Me.pnlAjalugu.PerformLayout()
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbAjaluguGraafikuPeriood As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
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
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
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
End Class
