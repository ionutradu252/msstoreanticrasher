<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.exitbtn = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.tabcontrol = New Guna.UI2.WinForms.Guna2TabControl()
        Me.gamespage = New System.Windows.Forms.TabPage()
        Me.fh3btn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.sotgame = New Guna.UI2.WinForms.Guna2TileButton()
        Me.msfsgamebtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.fh4btn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.fh5btn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.utilspage = New System.Windows.Forms.TabPage()
        Me.ds4btn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.testprocessdbgbtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.snpfxbtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.taskmgrbtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.addgamesdbgbtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.checkpiddbgbtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.cmdbtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.newexplorerbtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.taskbarpage = New System.Windows.Forms.TabPage()
        Me.datagridview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.icontab = New System.Windows.Forms.DataGridViewImageColumn()
        Me.nametab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pathtab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.settingspage = New System.Windows.Forms.TabPage()
        Me.versionlbl = New System.Windows.Forms.Label()
        Me.debugbtn = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.resettodefaultbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updfreqlbl = New System.Windows.Forms.Label()
        Me.updfreqscroll = New Guna.UI2.WinForms.Guna2TrackBar()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.timeoutlbl = New System.Windows.Forms.Label()
        Me.timeoutscroll = New Guna.UI2.WinForms.Guna2TrackBar()
        Me.gamerunningpage = New System.Windows.Forms.TabPage()
        Me.quitgamebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.gamepidlbl = New System.Windows.Forms.Label()
        Me.isgamerunninglbl = New System.Windows.Forms.Label()
        Me.tueclbl = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.ispidrunninglbl = New System.Windows.Forms.Label()
        Me.quitantigamebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.pidlbl = New System.Windows.Forms.Label()
        Me.runninggamelbl = New System.Windows.Forms.Label()
        Me.gameico = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tuectimer = New System.Windows.Forms.Timer(Me.components)
        Me.minimizebtn = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.tabcontrol.SuspendLayout()
        Me.gamespage.SuspendLayout()
        Me.utilspage.SuspendLayout()
        Me.taskbarpage.SuspendLayout()
        CType(Me.datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingspage.SuspendLayout()
        Me.gamerunningpage.SuspendLayout()
        CType(Me.gameico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'exitbtn
        '
        Me.exitbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitbtn.Animated = True
        Me.exitbtn.CustomClick = True
        Me.exitbtn.FillColor = System.Drawing.Color.Transparent
        Me.exitbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.exitbtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitbtn.Location = New System.Drawing.Point(843, 12)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(45, 45)
        Me.exitbtn.TabIndex = 0
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.gamespage)
        Me.tabcontrol.Controls.Add(Me.utilspage)
        Me.tabcontrol.Controls.Add(Me.taskbarpage)
        Me.tabcontrol.Controls.Add(Me.settingspage)
        Me.tabcontrol.Controls.Add(Me.gamerunningpage)
        Me.tabcontrol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcontrol.ItemSize = New System.Drawing.Size(100, 60)
        Me.tabcontrol.Location = New System.Drawing.Point(12, 12)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(825, 476)
        Me.tabcontrol.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tabcontrol.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.tabcontrol.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabcontrol.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tabcontrol.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tabcontrol.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tabcontrol.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabcontrol.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabcontrol.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.tabcontrol.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tabcontrol.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tabcontrol.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.tabcontrol.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tabcontrol.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tabcontrol.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabcontrol.TabButtonSize = New System.Drawing.Size(100, 60)
        Me.tabcontrol.TabIndex = 1
        Me.tabcontrol.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.tabcontrol.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'gamespage
        '
        Me.gamespage.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gamespage.Controls.Add(Me.fh3btn)
        Me.gamespage.Controls.Add(Me.sotgame)
        Me.gamespage.Controls.Add(Me.msfsgamebtn)
        Me.gamespage.Controls.Add(Me.fh4btn)
        Me.gamespage.Controls.Add(Me.fh5btn)
        Me.gamespage.Location = New System.Drawing.Point(4, 64)
        Me.gamespage.Name = "gamespage"
        Me.gamespage.Padding = New System.Windows.Forms.Padding(3)
        Me.gamespage.Size = New System.Drawing.Size(817, 408)
        Me.gamespage.TabIndex = 0
        Me.gamespage.Text = "Games"
        '
        'fh3btn
        '
        Me.fh3btn.Animated = True
        Me.fh3btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.fh3btn.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.fh3dark
        Me.fh3btn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.fh3
        Me.fh3btn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fh3btn.CustomImages.ImageSize = New System.Drawing.Size(180, 180)
        Me.fh3btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.fh3btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.fh3btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.fh3btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.fh3btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.fh3btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fh3btn.ForeColor = System.Drawing.Color.White
        Me.fh3btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fh3btn.ImageSize = New System.Drawing.Size(180, 180)
        Me.fh3btn.Location = New System.Drawing.Point(6, 6)
        Me.fh3btn.Name = "fh3btn"
        Me.fh3btn.Size = New System.Drawing.Size(180, 180)
        Me.fh3btn.TabIndex = 4
        Me.fh3btn.Text = "Forza Horizon 3"
        Me.fh3btn.TextOffset = New System.Drawing.Point(0, 65)
        Me.fh3btn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'sotgame
        '
        Me.sotgame.Animated = True
        Me.sotgame.Cursor = System.Windows.Forms.Cursors.Default
        Me.sotgame.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.sotdark
        Me.sotgame.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.sot
        Me.sotgame.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sotgame.CustomImages.ImageSize = New System.Drawing.Size(180, 180)
        Me.sotgame.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.sotgame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.sotgame.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.sotgame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.sotgame.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.sotgame.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sotgame.ForeColor = System.Drawing.Color.White
        Me.sotgame.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.sotgame.ImageSize = New System.Drawing.Size(180, 180)
        Me.sotgame.Location = New System.Drawing.Point(6, 210)
        Me.sotgame.Name = "sotgame"
        Me.sotgame.Size = New System.Drawing.Size(180, 180)
        Me.sotgame.TabIndex = 3
        Me.sotgame.Text = "Sea of Thieves"
        Me.sotgame.TextOffset = New System.Drawing.Point(0, 65)
        Me.sotgame.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'msfsgamebtn
        '
        Me.msfsgamebtn.Animated = True
        Me.msfsgamebtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.msfsgamebtn.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.msfsdark
        Me.msfsgamebtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.msfs
        Me.msfsgamebtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.msfsgamebtn.CustomImages.ImageSize = New System.Drawing.Size(150, 150)
        Me.msfsgamebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.msfsgamebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.msfsgamebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.msfsgamebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.msfsgamebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.msfsgamebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.msfsgamebtn.ForeColor = System.Drawing.Color.White
        Me.msfsgamebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.msfsgamebtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.msfsgamebtn.Location = New System.Drawing.Point(620, 6)
        Me.msfsgamebtn.Name = "msfsgamebtn"
        Me.msfsgamebtn.Size = New System.Drawing.Size(180, 180)
        Me.msfsgamebtn.TabIndex = 2
        Me.msfsgamebtn.Text = "Microsoft Flight Simulator"
        Me.msfsgamebtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.msfsgamebtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'fh4btn
        '
        Me.fh4btn.Animated = True
        Me.fh4btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.fh4btn.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.fh4dark
        Me.fh4btn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.fh4
        Me.fh4btn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fh4btn.CustomImages.ImageSize = New System.Drawing.Size(180, 180)
        Me.fh4btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.fh4btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.fh4btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.fh4btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.fh4btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.fh4btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fh4btn.ForeColor = System.Drawing.Color.White
        Me.fh4btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fh4btn.ImageSize = New System.Drawing.Size(180, 180)
        Me.fh4btn.Location = New System.Drawing.Point(210, 6)
        Me.fh4btn.Name = "fh4btn"
        Me.fh4btn.Size = New System.Drawing.Size(180, 180)
        Me.fh4btn.TabIndex = 0
        Me.fh4btn.Text = "Forza Horizon 4"
        Me.fh4btn.TextOffset = New System.Drawing.Point(0, 65)
        Me.fh4btn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'fh5btn
        '
        Me.fh5btn.Animated = True
        Me.fh5btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.fh5btn.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.fh5dark
        Me.fh5btn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.fh5
        Me.fh5btn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fh5btn.CustomImages.ImageSize = New System.Drawing.Size(180, 180)
        Me.fh5btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.fh5btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.fh5btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.fh5btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.fh5btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.fh5btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fh5btn.ForeColor = System.Drawing.Color.White
        Me.fh5btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.fh5btn.ImageSize = New System.Drawing.Size(180, 180)
        Me.fh5btn.Location = New System.Drawing.Point(416, 6)
        Me.fh5btn.Name = "fh5btn"
        Me.fh5btn.Size = New System.Drawing.Size(180, 180)
        Me.fh5btn.TabIndex = 1
        Me.fh5btn.Text = "Forza Horizon 5"
        Me.fh5btn.TextOffset = New System.Drawing.Point(0, 65)
        Me.fh5btn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'utilspage
        '
        Me.utilspage.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.utilspage.Controls.Add(Me.ds4btn)
        Me.utilspage.Controls.Add(Me.testprocessdbgbtn)
        Me.utilspage.Controls.Add(Me.snpfxbtn)
        Me.utilspage.Controls.Add(Me.taskmgrbtn)
        Me.utilspage.Controls.Add(Me.addgamesdbgbtn)
        Me.utilspage.Controls.Add(Me.checkpiddbgbtn)
        Me.utilspage.Controls.Add(Me.cmdbtn)
        Me.utilspage.Controls.Add(Me.newexplorerbtn)
        Me.utilspage.Location = New System.Drawing.Point(4, 64)
        Me.utilspage.Name = "utilspage"
        Me.utilspage.Padding = New System.Windows.Forms.Padding(3)
        Me.utilspage.Size = New System.Drawing.Size(817, 408)
        Me.utilspage.TabIndex = 3
        Me.utilspage.Text = "Utilities"
        '
        'ds4btn
        '
        Me.ds4btn.Animated = True
        Me.ds4btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ds4btn.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.ds4dark
        Me.ds4btn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.ds4
        Me.ds4btn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ds4btn.CustomImages.ImageOffset = New System.Drawing.Point(0, 20)
        Me.ds4btn.CustomImages.ImageSize = New System.Drawing.Size(150, 100)
        Me.ds4btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ds4btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ds4btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ds4btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ds4btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ds4btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ds4btn.ForeColor = System.Drawing.Color.White
        Me.ds4btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ds4btn.ImageSize = New System.Drawing.Size(180, 180)
        Me.ds4btn.Location = New System.Drawing.Point(6, 210)
        Me.ds4btn.Name = "ds4btn"
        Me.ds4btn.Size = New System.Drawing.Size(180, 180)
        Me.ds4btn.TabIndex = 10
        Me.ds4btn.Text = "DS4"
        Me.ds4btn.TextOffset = New System.Drawing.Point(0, 65)
        Me.ds4btn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'testprocessdbgbtn
        '
        Me.testprocessdbgbtn.Animated = True
        Me.testprocessdbgbtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.testprocessdbgbtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.msstoreicon1
        Me.testprocessdbgbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.testprocessdbgbtn.CustomImages.ImageSize = New System.Drawing.Size(120, 120)
        Me.testprocessdbgbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.testprocessdbgbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.testprocessdbgbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.testprocessdbgbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.testprocessdbgbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.testprocessdbgbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.testprocessdbgbtn.ForeColor = System.Drawing.Color.White
        Me.testprocessdbgbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.testprocessdbgbtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.testprocessdbgbtn.Location = New System.Drawing.Point(210, 210)
        Me.testprocessdbgbtn.Name = "testprocessdbgbtn"
        Me.testprocessdbgbtn.Size = New System.Drawing.Size(180, 180)
        Me.testprocessdbgbtn.TabIndex = 9
        Me.testprocessdbgbtn.Text = "TestProcess"
        Me.testprocessdbgbtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.testprocessdbgbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.testprocessdbgbtn.Visible = False
        '
        'snpfxbtn
        '
        Me.snpfxbtn.Animated = True
        Me.snpfxbtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.snpfxbtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.supporticon
        Me.snpfxbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.snpfxbtn.CustomImages.ImageSize = New System.Drawing.Size(140, 140)
        Me.snpfxbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.snpfxbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.snpfxbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.snpfxbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.snpfxbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.snpfxbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.snpfxbtn.ForeColor = System.Drawing.Color.White
        Me.snpfxbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.snpfxbtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.snpfxbtn.Location = New System.Drawing.Point(620, 6)
        Me.snpfxbtn.Name = "snpfxbtn"
        Me.snpfxbtn.Size = New System.Drawing.Size(180, 180)
        Me.snpfxbtn.TabIndex = 8
        Me.snpfxbtn.Text = "snaipdefix"
        Me.snpfxbtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.snpfxbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'taskmgrbtn
        '
        Me.taskmgrbtn.Animated = True
        Me.taskmgrbtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.taskmgrbtn.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.taskmgrdark
        Me.taskmgrbtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.tskmgr
        Me.taskmgrbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.taskmgrbtn.CustomImages.ImageSize = New System.Drawing.Size(140, 140)
        Me.taskmgrbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.taskmgrbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.taskmgrbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.taskmgrbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.taskmgrbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.taskmgrbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.taskmgrbtn.ForeColor = System.Drawing.Color.White
        Me.taskmgrbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.taskmgrbtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.taskmgrbtn.Location = New System.Drawing.Point(416, 6)
        Me.taskmgrbtn.Name = "taskmgrbtn"
        Me.taskmgrbtn.Size = New System.Drawing.Size(180, 180)
        Me.taskmgrbtn.TabIndex = 7
        Me.taskmgrbtn.Text = "Task Manager"
        Me.taskmgrbtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.taskmgrbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'addgamesdbgbtn
        '
        Me.addgamesdbgbtn.Animated = True
        Me.addgamesdbgbtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.addgamesdbgbtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.msstoreicon1
        Me.addgamesdbgbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.addgamesdbgbtn.CustomImages.ImageSize = New System.Drawing.Size(120, 120)
        Me.addgamesdbgbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addgamesdbgbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addgamesdbgbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addgamesdbgbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addgamesdbgbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.addgamesdbgbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addgamesdbgbtn.ForeColor = System.Drawing.Color.White
        Me.addgamesdbgbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.addgamesdbgbtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.addgamesdbgbtn.Location = New System.Drawing.Point(416, 210)
        Me.addgamesdbgbtn.Name = "addgamesdbgbtn"
        Me.addgamesdbgbtn.Size = New System.Drawing.Size(180, 180)
        Me.addgamesdbgbtn.TabIndex = 6
        Me.addgamesdbgbtn.Text = "Add Games page"
        Me.addgamesdbgbtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.addgamesdbgbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.addgamesdbgbtn.Visible = False
        '
        'checkpiddbgbtn
        '
        Me.checkpiddbgbtn.Animated = True
        Me.checkpiddbgbtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.checkpiddbgbtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.msstoreicon1
        Me.checkpiddbgbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.checkpiddbgbtn.CustomImages.ImageSize = New System.Drawing.Size(120, 120)
        Me.checkpiddbgbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.checkpiddbgbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.checkpiddbgbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.checkpiddbgbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.checkpiddbgbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.checkpiddbgbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.checkpiddbgbtn.ForeColor = System.Drawing.Color.White
        Me.checkpiddbgbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.checkpiddbgbtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.checkpiddbgbtn.Location = New System.Drawing.Point(620, 210)
        Me.checkpiddbgbtn.Name = "checkpiddbgbtn"
        Me.checkpiddbgbtn.Size = New System.Drawing.Size(180, 180)
        Me.checkpiddbgbtn.TabIndex = 5
        Me.checkpiddbgbtn.Text = "Check PID"
        Me.checkpiddbgbtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.checkpiddbgbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.checkpiddbgbtn.Visible = False
        '
        'cmdbtn
        '
        Me.cmdbtn.Animated = True
        Me.cmdbtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdbtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.cmdico
        Me.cmdbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdbtn.CustomImages.ImageSize = New System.Drawing.Size(140, 140)
        Me.cmdbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmdbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdbtn.ForeColor = System.Drawing.Color.White
        Me.cmdbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.cmdbtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.cmdbtn.Location = New System.Drawing.Point(210, 6)
        Me.cmdbtn.Name = "cmdbtn"
        Me.cmdbtn.Size = New System.Drawing.Size(180, 180)
        Me.cmdbtn.TabIndex = 2
        Me.cmdbtn.Text = "Command Prompt"
        Me.cmdbtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.cmdbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'newexplorerbtn
        '
        Me.newexplorerbtn.Animated = True
        Me.newexplorerbtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.newexplorerbtn.CustomImages.HoveredImage = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.newexplorericodark
        Me.newexplorerbtn.CustomImages.Image = Global.MSStore_Anti_Crasher__snpfx_.My.Resources.Resources.newexplorerico
        Me.newexplorerbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.newexplorerbtn.CustomImages.ImageSize = New System.Drawing.Size(140, 140)
        Me.newexplorerbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.newexplorerbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.newexplorerbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.newexplorerbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.newexplorerbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.newexplorerbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.newexplorerbtn.ForeColor = System.Drawing.Color.White
        Me.newexplorerbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.newexplorerbtn.ImageSize = New System.Drawing.Size(180, 180)
        Me.newexplorerbtn.Location = New System.Drawing.Point(6, 6)
        Me.newexplorerbtn.Name = "newexplorerbtn"
        Me.newexplorerbtn.Size = New System.Drawing.Size(180, 180)
        Me.newexplorerbtn.TabIndex = 1
        Me.newexplorerbtn.Text = "Explorer ++"
        Me.newexplorerbtn.TextOffset = New System.Drawing.Point(0, 65)
        Me.newexplorerbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'taskbarpage
        '
        Me.taskbarpage.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.taskbarpage.Controls.Add(Me.datagridview)
        Me.taskbarpage.Location = New System.Drawing.Point(4, 64)
        Me.taskbarpage.Name = "taskbarpage"
        Me.taskbarpage.Padding = New System.Windows.Forms.Padding(3)
        Me.taskbarpage.Size = New System.Drawing.Size(817, 408)
        Me.taskbarpage.TabIndex = 1
        Me.taskbarpage.Text = "Taskbar"
        '
        'datagridview
        '
        Me.datagridview.AllowUserToAddRows = False
        Me.datagridview.AllowUserToDeleteRows = False
        Me.datagridview.AllowUserToResizeColumns = False
        Me.datagridview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.datagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.datagridview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridview.ColumnHeadersHeight = 20
        Me.datagridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.icontab, Me.nametab, Me.pathtab})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridview.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridview.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.datagridview.Location = New System.Drawing.Point(3, 3)
        Me.datagridview.MultiSelect = False
        Me.datagridview.Name = "datagridview"
        Me.datagridview.ReadOnly = True
        Me.datagridview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.datagridview.RowHeadersVisible = False
        Me.datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagridview.Size = New System.Drawing.Size(811, 402)
        Me.datagridview.TabIndex = 0
        Me.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.datagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.datagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview.ThemeStyle.HeaderStyle.Height = 20
        Me.datagridview.ThemeStyle.ReadOnly = True
        Me.datagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridview.ThemeStyle.RowsStyle.Height = 22
        Me.datagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'icontab
        '
        Me.icontab.HeaderText = "Icon"
        Me.icontab.Name = "icontab"
        Me.icontab.ReadOnly = True
        Me.icontab.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.icontab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'nametab
        '
        Me.nametab.HeaderText = "Name"
        Me.nametab.Name = "nametab"
        Me.nametab.ReadOnly = True
        '
        'pathtab
        '
        Me.pathtab.HeaderText = "Path"
        Me.pathtab.Name = "pathtab"
        Me.pathtab.ReadOnly = True
        '
        'settingspage
        '
        Me.settingspage.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.settingspage.Controls.Add(Me.versionlbl)
        Me.settingspage.Controls.Add(Me.debugbtn)
        Me.settingspage.Controls.Add(Me.resettodefaultbtn)
        Me.settingspage.Controls.Add(Me.Label1)
        Me.settingspage.Controls.Add(Me.updfreqlbl)
        Me.settingspage.Controls.Add(Me.updfreqscroll)
        Me.settingspage.Controls.Add(Me.Guna2VSeparator1)
        Me.settingspage.Controls.Add(Me.timeoutlbl)
        Me.settingspage.Controls.Add(Me.timeoutscroll)
        Me.settingspage.Location = New System.Drawing.Point(4, 64)
        Me.settingspage.Name = "settingspage"
        Me.settingspage.Padding = New System.Windows.Forms.Padding(3)
        Me.settingspage.Size = New System.Drawing.Size(817, 408)
        Me.settingspage.TabIndex = 2
        Me.settingspage.Text = "Settings"
        '
        'versionlbl
        '
        Me.versionlbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.versionlbl.Location = New System.Drawing.Point(6, 331)
        Me.versionlbl.Name = "versionlbl"
        Me.versionlbl.Size = New System.Drawing.Size(300, 23)
        Me.versionlbl.TabIndex = 8
        Me.versionlbl.Text = "version"
        Me.versionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'debugbtn
        '
        Me.debugbtn.Animated = True
        Me.debugbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.debugbtn.CheckedState.BorderThickness = 0
        Me.debugbtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.debugbtn.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.debugbtn.CheckedState.InnerOffset = -4
        Me.debugbtn.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.debugbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.debugbtn.Location = New System.Drawing.Point(6, 88)
        Me.debugbtn.Name = "debugbtn"
        Me.debugbtn.Size = New System.Drawing.Size(300, 55)
        Me.debugbtn.TabIndex = 7
        Me.debugbtn.Text = "Debug Mode"
        Me.debugbtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.debugbtn.UncheckedState.BorderThickness = 2
        Me.debugbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.debugbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'resettodefaultbtn
        '
        Me.resettodefaultbtn.Animated = True
        Me.resettodefaultbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.resettodefaultbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.resettodefaultbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.resettodefaultbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.resettodefaultbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.resettodefaultbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.resettodefaultbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.resettodefaultbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.resettodefaultbtn.Location = New System.Drawing.Point(70, 357)
        Me.resettodefaultbtn.Name = "resettodefaultbtn"
        Me.resettodefaultbtn.Size = New System.Drawing.Size(180, 45)
        Me.resettodefaultbtn.TabIndex = 6
        Me.resettodefaultbtn.Text = "Reset to default"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(363, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Do not change stuff here unless you know what you're doing!"
        '
        'updfreqlbl
        '
        Me.updfreqlbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updfreqlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.updfreqlbl.Location = New System.Drawing.Point(328, 59)
        Me.updfreqlbl.Name = "updfreqlbl"
        Me.updfreqlbl.Size = New System.Drawing.Size(258, 23)
        Me.updfreqlbl.TabIndex = 4
        Me.updfreqlbl.Text = "Update frequency :"
        '
        'updfreqscroll
        '
        Me.updfreqscroll.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.updfreqscroll.Location = New System.Drawing.Point(6, 59)
        Me.updfreqscroll.Maximum = 30
        Me.updfreqscroll.Minimum = 1
        Me.updfreqscroll.Name = "updfreqscroll"
        Me.updfreqscroll.Size = New System.Drawing.Size(300, 23)
        Me.updfreqscroll.TabIndex = 3
        Me.updfreqscroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.updfreqscroll.Value = 5
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(312, 6)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 396)
        Me.Guna2VSeparator1.TabIndex = 2
        '
        'timeoutlbl
        '
        Me.timeoutlbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeoutlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.timeoutlbl.Location = New System.Drawing.Point(328, 6)
        Me.timeoutlbl.Name = "timeoutlbl"
        Me.timeoutlbl.Size = New System.Drawing.Size(258, 23)
        Me.timeoutlbl.TabIndex = 1
        Me.timeoutlbl.Text = "Timeout :"
        '
        'timeoutscroll
        '
        Me.timeoutscroll.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.timeoutscroll.Location = New System.Drawing.Point(6, 6)
        Me.timeoutscroll.Maximum = 200
        Me.timeoutscroll.Minimum = 20
        Me.timeoutscroll.Name = "timeoutscroll"
        Me.timeoutscroll.Size = New System.Drawing.Size(300, 23)
        Me.timeoutscroll.TabIndex = 0
        Me.timeoutscroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.timeoutscroll.Value = 60
        '
        'gamerunningpage
        '
        Me.gamerunningpage.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.gamerunningpage.Controls.Add(Me.quitgamebtn)
        Me.gamerunningpage.Controls.Add(Me.gamepidlbl)
        Me.gamerunningpage.Controls.Add(Me.isgamerunninglbl)
        Me.gamerunningpage.Controls.Add(Me.tueclbl)
        Me.gamerunningpage.Controls.Add(Me.Guna2Button1)
        Me.gamerunningpage.Controls.Add(Me.ispidrunninglbl)
        Me.gamerunningpage.Controls.Add(Me.quitantigamebtn)
        Me.gamerunningpage.Controls.Add(Me.pidlbl)
        Me.gamerunningpage.Controls.Add(Me.runninggamelbl)
        Me.gamerunningpage.Controls.Add(Me.gameico)
        Me.gamerunningpage.Location = New System.Drawing.Point(4, 64)
        Me.gamerunningpage.Name = "gamerunningpage"
        Me.gamerunningpage.Padding = New System.Windows.Forms.Padding(3)
        Me.gamerunningpage.Size = New System.Drawing.Size(817, 408)
        Me.gamerunningpage.TabIndex = 4
        Me.gamerunningpage.Text = "Running"
        '
        'quitgamebtn
        '
        Me.quitgamebtn.Animated = True
        Me.quitgamebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.quitgamebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.quitgamebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.quitgamebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.quitgamebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.quitgamebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.quitgamebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.quitgamebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.quitgamebtn.Location = New System.Drawing.Point(564, 141)
        Me.quitgamebtn.Name = "quitgamebtn"
        Me.quitgamebtn.Size = New System.Drawing.Size(180, 45)
        Me.quitgamebtn.TabIndex = 13
        Me.quitgamebtn.Text = "Quit game"
        '
        'gamepidlbl
        '
        Me.gamepidlbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamepidlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.gamepidlbl.Location = New System.Drawing.Point(456, 49)
        Me.gamepidlbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 20)
        Me.gamepidlbl.Name = "gamepidlbl"
        Me.gamepidlbl.Size = New System.Drawing.Size(258, 23)
        Me.gamepidlbl.TabIndex = 12
        Me.gamepidlbl.Text = "Game PID :"
        '
        'isgamerunninglbl
        '
        Me.isgamerunninglbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isgamerunninglbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.isgamerunninglbl.Location = New System.Drawing.Point(456, 92)
        Me.isgamerunninglbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 20)
        Me.isgamerunninglbl.Name = "isgamerunninglbl"
        Me.isgamerunninglbl.Size = New System.Drawing.Size(258, 23)
        Me.isgamerunninglbl.TabIndex = 11
        Me.isgamerunninglbl.Text = "Is game running :"
        '
        'tueclbl
        '
        Me.tueclbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tueclbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.tueclbl.Location = New System.Drawing.Point(456, 6)
        Me.tueclbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 20)
        Me.tueclbl.Name = "tueclbl"
        Me.tueclbl.Size = New System.Drawing.Size(258, 23)
        Me.tueclbl.TabIndex = 10
        Me.tueclbl.Text = "Time until explorer close : "
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(192, 141)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "Check PID"
        '
        'ispidrunninglbl
        '
        Me.ispidrunninglbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ispidrunninglbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ispidrunninglbl.Location = New System.Drawing.Point(192, 92)
        Me.ispidrunninglbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 20)
        Me.ispidrunninglbl.Name = "ispidrunninglbl"
        Me.ispidrunninglbl.Size = New System.Drawing.Size(258, 23)
        Me.ispidrunninglbl.TabIndex = 8
        Me.ispidrunninglbl.Text = "Is PID running : "
        '
        'quitantigamebtn
        '
        Me.quitantigamebtn.Animated = True
        Me.quitantigamebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.quitantigamebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.quitantigamebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.quitantigamebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.quitantigamebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.quitantigamebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.quitantigamebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.quitantigamebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.quitantigamebtn.Location = New System.Drawing.Point(378, 141)
        Me.quitantigamebtn.Name = "quitantigamebtn"
        Me.quitantigamebtn.Size = New System.Drawing.Size(180, 45)
        Me.quitantigamebtn.TabIndex = 7
        Me.quitantigamebtn.Text = "Quit anti-crasher"
        '
        'pidlbl
        '
        Me.pidlbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pidlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pidlbl.Location = New System.Drawing.Point(192, 49)
        Me.pidlbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 20)
        Me.pidlbl.Name = "pidlbl"
        Me.pidlbl.Size = New System.Drawing.Size(258, 23)
        Me.pidlbl.TabIndex = 3
        Me.pidlbl.Text = "PID : "
        '
        'runninggamelbl
        '
        Me.runninggamelbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.runninggamelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.runninggamelbl.Location = New System.Drawing.Point(192, 6)
        Me.runninggamelbl.Margin = New System.Windows.Forms.Padding(3, 0, 3, 20)
        Me.runninggamelbl.Name = "runninggamelbl"
        Me.runninggamelbl.Size = New System.Drawing.Size(258, 23)
        Me.runninggamelbl.TabIndex = 2
        Me.runninggamelbl.Text = "Running :"
        '
        'gameico
        '
        Me.gameico.ImageRotate = 0!
        Me.gameico.Location = New System.Drawing.Point(6, 6)
        Me.gameico.Name = "gameico"
        Me.gameico.Size = New System.Drawing.Size(180, 180)
        Me.gameico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gameico.TabIndex = 0
        Me.gameico.TabStop = False
        '
        'tuectimer
        '
        Me.tuectimer.Interval = 1000
        '
        'minimizebtn
        '
        Me.minimizebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizebtn.Animated = True
        Me.minimizebtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.minimizebtn.FillColor = System.Drawing.Color.Transparent
        Me.minimizebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.minimizebtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.minimizebtn.Location = New System.Drawing.Point(843, 63)
        Me.minimizebtn.Name = "minimizebtn"
        Me.minimizebtn.Size = New System.Drawing.Size(45, 45)
        Me.minimizebtn.TabIndex = 2
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.minimizebtn)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.exitbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainform"
        Me.tabcontrol.ResumeLayout(False)
        Me.gamespage.ResumeLayout(False)
        Me.utilspage.ResumeLayout(False)
        Me.taskbarpage.ResumeLayout(False)
        CType(Me.datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingspage.ResumeLayout(False)
        Me.gamerunningpage.ResumeLayout(False)
        CType(Me.gameico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents tabcontrol As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents gamespage As TabPage
    Friend WithEvents taskbarpage As TabPage
    Friend WithEvents exitbtn As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents settingspage As TabPage
    Friend WithEvents fh4btn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents fh5btn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents sotgame As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents msfsgamebtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents datagridview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents icontab As DataGridViewImageColumn
    Friend WithEvents nametab As DataGridViewTextBoxColumn
    Friend WithEvents pathtab As DataGridViewTextBoxColumn
    Friend WithEvents utilspage As TabPage
    Friend WithEvents newexplorerbtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents cmdbtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents checkpiddbgbtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents fh3btn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents addgamesdbgbtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents gamerunningpage As TabPage
    Friend WithEvents timeoutscroll As Guna.UI2.WinForms.Guna2TrackBar
    Friend WithEvents timeoutlbl As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents updfreqlbl As Label
    Friend WithEvents updfreqscroll As Guna.UI2.WinForms.Guna2TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents resettodefaultbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gameico As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents runninggamelbl As Label
    Friend WithEvents pidlbl As Label
    Friend WithEvents quitantigamebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ispidrunninglbl As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents taskmgrbtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents tueclbl As Label
    Friend WithEvents tuectimer As Timer
    Friend WithEvents snpfxbtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents testprocessdbgbtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents debugbtn As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents ds4btn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents minimizebtn As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents versionlbl As Label
    Friend WithEvents isgamerunninglbl As Label
    Friend WithEvents gamepidlbl As Label
    Friend WithEvents quitgamebtn As Guna.UI2.WinForms.Guna2Button
End Class
