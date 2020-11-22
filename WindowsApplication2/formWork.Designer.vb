<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formWork
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formWork))
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.copyright = New System.Windows.Forms.Button()
        Me.aboutBtn = New System.Windows.Forms.Button()
        Me.storageBtn = New System.Windows.Forms.Button()
        Me.dashboardBtn = New System.Windows.Forms.Button()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.maximize = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Label()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dashboardPanel = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.subPanel7 = New System.Windows.Forms.Panel()
        Me.timeMinute = New System.Windows.Forms.Label()
        Me.timeHour = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.subPanel6 = New System.Windows.Forms.Panel()
        Me.timeMonth = New System.Windows.Forms.Label()
        Me.timeDay = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.subPanel5 = New System.Windows.Forms.Panel()
        Me.year1 = New System.Windows.Forms.Label()
        Me.year2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.subPanel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.subPanel3 = New System.Windows.Forms.Panel()
        Me.typeText = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.subPanel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.subPanel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.storage = New System.Windows.Forms.Panel()
        Me.adminInput = New System.Windows.Forms.RadioButton()
        Me.moderatorInput = New System.Windows.Forms.RadioButton()
        Me.passwordInput = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.usernameInput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.phoneInput = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addUserBtn = New System.Windows.Forms.Button()
        Me.addressInput = New System.Windows.Forms.TextBox()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.aboutUsPanel = New System.Windows.Forms.Panel()
        Me.about = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.leftPanel.SuspendLayout()
        Me.topPanel.SuspendLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logoPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardPanel.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.subPanel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.subPanel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.subPanel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.subPanel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.subPanel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.subPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.subPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.storage.SuspendLayout()
        Me.aboutUsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'leftPanel
        '
        Me.leftPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.leftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.leftPanel.Controls.Add(Me.copyright)
        Me.leftPanel.Controls.Add(Me.aboutBtn)
        Me.leftPanel.Controls.Add(Me.storageBtn)
        Me.leftPanel.Controls.Add(Me.dashboardBtn)
        Me.leftPanel.Location = New System.Drawing.Point(1, 1)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(254, 653)
        Me.leftPanel.TabIndex = 0
        '
        'copyright
        '
        Me.copyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.copyright.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.copyright.FlatAppearance.BorderSize = 0
        Me.copyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copyright.Font = New System.Drawing.Font("Roboto Condensed", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyright.ForeColor = System.Drawing.Color.White
        Me.copyright.Location = New System.Drawing.Point(0, 615)
        Me.copyright.Name = "copyright"
        Me.copyright.Size = New System.Drawing.Size(255, 38)
        Me.copyright.TabIndex = 0
        Me.copyright.Text = "Copyright@ 2019"
        Me.copyright.UseVisualStyleBackColor = False
        '
        'aboutBtn
        '
        Me.aboutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.aboutBtn.FlatAppearance.BorderSize = 0
        Me.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aboutBtn.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.aboutBtn.Image = CType(resources.GetObject("aboutBtn.Image"), System.Drawing.Image)
        Me.aboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aboutBtn.Location = New System.Drawing.Point(0, 368)
        Me.aboutBtn.Name = "aboutBtn"
        Me.aboutBtn.Size = New System.Drawing.Size(254, 63)
        Me.aboutBtn.TabIndex = 3
        Me.aboutBtn.Text = "About Us   "
        Me.aboutBtn.UseVisualStyleBackColor = False
        '
        'storageBtn
        '
        Me.storageBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.storageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.storageBtn.FlatAppearance.BorderSize = 0
        Me.storageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.storageBtn.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storageBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.storageBtn.Image = CType(resources.GetObject("storageBtn.Image"), System.Drawing.Image)
        Me.storageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.storageBtn.Location = New System.Drawing.Point(0, 305)
        Me.storageBtn.Name = "storageBtn"
        Me.storageBtn.Size = New System.Drawing.Size(254, 63)
        Me.storageBtn.TabIndex = 2
        Me.storageBtn.Text = "Storage     "
        Me.storageBtn.UseVisualStyleBackColor = False
        '
        'dashboardBtn
        '
        Me.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dashboardBtn.FlatAppearance.BorderSize = 0
        Me.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardBtn.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dashboardBtn.Image = CType(resources.GetObject("dashboardBtn.Image"), System.Drawing.Image)
        Me.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardBtn.Location = New System.Drawing.Point(0, 242)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.Size = New System.Drawing.Size(254, 63)
        Me.dashboardBtn.TabIndex = 1
        Me.dashboardBtn.Text = "Dashboard"
        Me.dashboardBtn.UseVisualStyleBackColor = False
        '
        'topPanel
        '
        Me.topPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.topPanel.Controls.Add(Me.minimize)
        Me.topPanel.Controls.Add(Me.maximize)
        Me.topPanel.Controls.Add(Me.Button1)
        Me.topPanel.Controls.Add(Me.closeBtn)
        Me.topPanel.Location = New System.Drawing.Point(1, 1)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(998, 66)
        Me.topPanel.TabIndex = 1
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.Image = CType(resources.GetObject("minimize.Image"), System.Drawing.Image)
        Me.minimize.Location = New System.Drawing.Point(936, 8)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(13, 4)
        Me.minimize.TabIndex = 2
        Me.minimize.TabStop = False
        '
        'maximize
        '
        Me.maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maximize.Image = CType(resources.GetObject("maximize.Image"), System.Drawing.Image)
        Me.maximize.Location = New System.Drawing.Point(959, 3)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(15, 15)
        Me.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.maximize.TabIndex = 1
        Me.maximize.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(853, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.AutoSize = True
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.closeBtn.Location = New System.Drawing.Point(978, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(21, 20)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "X"
        '
        'logoPanel
        '
        Me.logoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.logoPanel.Controls.Add(Me.PictureBox1)
        Me.logoPanel.Location = New System.Drawing.Point(1, 1)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(254, 66)
        Me.logoPanel.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dashboardPanel
        '
        Me.dashboardPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dashboardPanel.BackColor = System.Drawing.Color.White
        Me.dashboardPanel.Controls.Add(Me.Panel7)
        Me.dashboardPanel.Controls.Add(Me.Panel6)
        Me.dashboardPanel.Controls.Add(Me.Panel5)
        Me.dashboardPanel.Controls.Add(Me.Panel4)
        Me.dashboardPanel.Controls.Add(Me.Panel3)
        Me.dashboardPanel.Controls.Add(Me.Panel2)
        Me.dashboardPanel.Controls.Add(Me.Panel1)
        Me.dashboardPanel.Location = New System.Drawing.Point(255, 67)
        Me.dashboardPanel.Name = "dashboardPanel"
        Me.dashboardPanel.Size = New System.Drawing.Size(744, 587)
        Me.dashboardPanel.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Panel7.Controls.Add(Me.subPanel7)
        Me.Panel7.Location = New System.Drawing.Point(490, 394)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(240, 182)
        Me.Panel7.TabIndex = 4
        '
        'subPanel7
        '
        Me.subPanel7.Controls.Add(Me.timeMinute)
        Me.subPanel7.Controls.Add(Me.timeHour)
        Me.subPanel7.Location = New System.Drawing.Point(0, 0)
        Me.subPanel7.Name = "subPanel7"
        Me.subPanel7.Size = New System.Drawing.Size(240, 182)
        Me.subPanel7.TabIndex = 10
        '
        'timeMinute
        '
        Me.timeMinute.AutoSize = True
        Me.timeMinute.Font = New System.Drawing.Font("Roboto Condensed", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeMinute.ForeColor = System.Drawing.Color.White
        Me.timeMinute.Location = New System.Drawing.Point(74, 94)
        Me.timeMinute.Name = "timeMinute"
        Me.timeMinute.Size = New System.Drawing.Size(94, 42)
        Me.timeMinute.TabIndex = 8
        Me.timeMinute.Text = "17:05"
        '
        'timeHour
        '
        Me.timeHour.AutoSize = True
        Me.timeHour.Font = New System.Drawing.Font("Roboto Condensed", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeHour.ForeColor = System.Drawing.Color.White
        Me.timeHour.Location = New System.Drawing.Point(64, 12)
        Me.timeHour.Name = "timeHour"
        Me.timeHour.Size = New System.Drawing.Size(120, 97)
        Me.timeHour.TabIndex = 9
        Me.timeHour.Text = "17"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Panel6.Controls.Add(Me.subPanel6)
        Me.Panel6.Location = New System.Drawing.Point(252, 394)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(240, 182)
        Me.Panel6.TabIndex = 4
        '
        'subPanel6
        '
        Me.subPanel6.Controls.Add(Me.timeMonth)
        Me.subPanel6.Controls.Add(Me.timeDay)
        Me.subPanel6.Location = New System.Drawing.Point(0, 0)
        Me.subPanel6.Name = "subPanel6"
        Me.subPanel6.Size = New System.Drawing.Size(240, 182)
        Me.subPanel6.TabIndex = 8
        '
        'timeMonth
        '
        Me.timeMonth.AutoSize = True
        Me.timeMonth.Font = New System.Drawing.Font("Roboto Condensed", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeMonth.ForeColor = System.Drawing.Color.Black
        Me.timeMonth.Location = New System.Drawing.Point(59, 94)
        Me.timeMonth.Name = "timeMonth"
        Me.timeMonth.Size = New System.Drawing.Size(112, 42)
        Me.timeMonth.TabIndex = 6
        Me.timeMonth.Text = "August"
        '
        'timeDay
        '
        Me.timeDay.AutoSize = True
        Me.timeDay.Font = New System.Drawing.Font("Roboto Condensed", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeDay.ForeColor = System.Drawing.Color.Black
        Me.timeDay.Location = New System.Drawing.Point(62, 12)
        Me.timeDay.Name = "timeDay"
        Me.timeDay.Size = New System.Drawing.Size(120, 97)
        Me.timeDay.TabIndex = 7
        Me.timeDay.Text = "29"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.subPanel5)
        Me.Panel5.Location = New System.Drawing.Point(12, 394)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(240, 182)
        Me.Panel5.TabIndex = 3
        '
        'subPanel5
        '
        Me.subPanel5.Controls.Add(Me.year1)
        Me.subPanel5.Controls.Add(Me.year2)
        Me.subPanel5.Location = New System.Drawing.Point(0, 0)
        Me.subPanel5.Name = "subPanel5"
        Me.subPanel5.Size = New System.Drawing.Size(240, 182)
        Me.subPanel5.TabIndex = 7
        '
        'year1
        '
        Me.year1.AutoSize = True
        Me.year1.Font = New System.Drawing.Font("Roboto Condensed", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year1.ForeColor = System.Drawing.Color.White
        Me.year1.Location = New System.Drawing.Point(69, 12)
        Me.year1.Name = "year1"
        Me.year1.Size = New System.Drawing.Size(101, 81)
        Me.year1.TabIndex = 5
        Me.year1.Text = "20"
        '
        'year2
        '
        Me.year2.AutoSize = True
        Me.year2.Font = New System.Drawing.Font("Roboto Condensed", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year2.ForeColor = System.Drawing.Color.White
        Me.year2.Location = New System.Drawing.Point(69, 81)
        Me.year2.Name = "year2"
        Me.year2.Size = New System.Drawing.Size(101, 81)
        Me.year2.TabIndex = 6
        Me.year2.Text = "19"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel4.Controls.Add(Me.subPanel4)
        Me.Panel4.Location = New System.Drawing.Point(462, 202)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(270, 182)
        Me.Panel4.TabIndex = 3
        '
        'subPanel4
        '
        Me.subPanel4.Controls.Add(Me.PictureBox4)
        Me.subPanel4.Controls.Add(Me.Label11)
        Me.subPanel4.Controls.Add(Me.Label12)
        Me.subPanel4.Location = New System.Drawing.Point(0, 0)
        Me.subPanel4.Name = "subPanel4"
        Me.subPanel4.Size = New System.Drawing.Size(270, 182)
        Me.subPanel4.TabIndex = 8
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(6, 22)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(138, 123)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto Condensed", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(147, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 57)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "View"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Condensed", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(147, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 57)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Datas"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Controls.Add(Me.subPanel3)
        Me.Panel3.Location = New System.Drawing.Point(12, 202)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 182)
        Me.Panel3.TabIndex = 2
        '
        'subPanel3
        '
        Me.subPanel3.Controls.Add(Me.typeText)
        Me.subPanel3.Controls.Add(Me.firstName)
        Me.subPanel3.Controls.Add(Me.lastName)
        Me.subPanel3.Controls.Add(Me.PictureBox5)
        Me.subPanel3.Location = New System.Drawing.Point(0, 0)
        Me.subPanel3.Name = "subPanel3"
        Me.subPanel3.Size = New System.Drawing.Size(450, 182)
        Me.subPanel3.TabIndex = 6
        '
        'typeText
        '
        Me.typeText.AutoSize = True
        Me.typeText.Font = New System.Drawing.Font("Roboto Condensed", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.typeText.Location = New System.Drawing.Point(14, 37)
        Me.typeText.Name = "typeText"
        Me.typeText.Size = New System.Drawing.Size(204, 81)
        Me.typeText.TabIndex = 3
        Me.typeText.Text = "Admin"
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Font = New System.Drawing.Font("Roboto Condensed", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.ForeColor = System.Drawing.Color.Black
        Me.firstName.Location = New System.Drawing.Point(249, 21)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(184, 66)
        Me.firstName.TabIndex = 3
        Me.firstName.Text = "Aayush"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Font = New System.Drawing.Font("Roboto Condensed", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.ForeColor = System.Drawing.Color.Black
        Me.lastName.Location = New System.Drawing.Point(249, 79)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(173, 66)
        Me.lastName.TabIndex = 4
        Me.lastName.Text = "Dhakal"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(224, 31)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(3, 111)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Panel2.Controls.Add(Me.subPanel2)
        Me.Panel2.Location = New System.Drawing.Point(372, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 182)
        Me.Panel2.TabIndex = 2
        '
        'subPanel2
        '
        Me.subPanel2.Controls.Add(Me.PictureBox3)
        Me.subPanel2.Controls.Add(Me.Label10)
        Me.subPanel2.Controls.Add(Me.Label3)
        Me.subPanel2.Location = New System.Drawing.Point(0, 0)
        Me.subPanel2.Name = "subPanel2"
        Me.subPanel2.Size = New System.Drawing.Size(360, 182)
        Me.subPanel2.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(43, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 115)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto Condensed", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(191, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 57)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Enter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(191, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Purchase Details"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.subPanel1)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 182)
        Me.Panel1.TabIndex = 1
        '
        'subPanel1
        '
        Me.subPanel1.BackColor = System.Drawing.Color.Transparent
        Me.subPanel1.Controls.Add(Me.PictureBox2)
        Me.subPanel1.Controls.Add(Me.Label1)
        Me.subPanel1.Controls.Add(Me.Label2)
        Me.subPanel1.Location = New System.Drawing.Point(0, 0)
        Me.subPanel1.Name = "subPanel1"
        Me.subPanel1.Size = New System.Drawing.Size(360, 182)
        Me.subPanel1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(41, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 115)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(189, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(189, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sales Details"
        '
        'storage
        '
        Me.storage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storage.BackColor = System.Drawing.Color.White
        Me.storage.Controls.Add(Me.adminInput)
        Me.storage.Controls.Add(Me.moderatorInput)
        Me.storage.Controls.Add(Me.passwordInput)
        Me.storage.Controls.Add(Me.Label9)
        Me.storage.Controls.Add(Me.usernameInput)
        Me.storage.Controls.Add(Me.Label8)
        Me.storage.Controls.Add(Me.phoneInput)
        Me.storage.Controls.Add(Me.Label7)
        Me.storage.Controls.Add(Me.addUserBtn)
        Me.storage.Controls.Add(Me.addressInput)
        Me.storage.Controls.Add(Me.nameInput)
        Me.storage.Controls.Add(Me.Label4)
        Me.storage.Controls.Add(Me.Label5)
        Me.storage.Controls.Add(Me.Label6)
        Me.storage.Location = New System.Drawing.Point(255, 67)
        Me.storage.Name = "storage"
        Me.storage.Size = New System.Drawing.Size(744, 587)
        Me.storage.TabIndex = 6
        '
        'adminInput
        '
        Me.adminInput.AutoSize = True
        Me.adminInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminInput.Location = New System.Drawing.Point(306, 319)
        Me.adminInput.Name = "adminInput"
        Me.adminInput.Size = New System.Drawing.Size(83, 28)
        Me.adminInput.TabIndex = 13
        Me.adminInput.TabStop = True
        Me.adminInput.Text = "Admin"
        Me.adminInput.UseVisualStyleBackColor = True
        '
        'moderatorInput
        '
        Me.moderatorInput.AutoSize = True
        Me.moderatorInput.Checked = True
        Me.moderatorInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moderatorInput.Location = New System.Drawing.Point(148, 319)
        Me.moderatorInput.Name = "moderatorInput"
        Me.moderatorInput.Size = New System.Drawing.Size(114, 28)
        Me.moderatorInput.TabIndex = 12
        Me.moderatorInput.TabStop = True
        Me.moderatorInput.Text = "Moderator"
        Me.moderatorInput.UseVisualStyleBackColor = True
        '
        'passwordInput
        '
        Me.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInput.Location = New System.Drawing.Point(148, 262)
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.Size = New System.Drawing.Size(313, 40)
        Me.passwordInput.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 33)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Password"
        '
        'usernameInput
        '
        Me.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usernameInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameInput.Location = New System.Drawing.Point(148, 213)
        Me.usernameInput.Name = "usernameInput"
        Me.usernameInput.Size = New System.Drawing.Size(313, 40)
        Me.usernameInput.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 33)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Username"
        '
        'phoneInput
        '
        Me.phoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneInput.Location = New System.Drawing.Point(148, 167)
        Me.phoneInput.Name = "phoneInput"
        Me.phoneInput.Size = New System.Drawing.Size(313, 40)
        Me.phoneInput.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Phone no."
        '
        'addUserBtn
        '
        Me.addUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.addUserBtn.FlatAppearance.BorderSize = 0
        Me.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addUserBtn.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.addUserBtn.Location = New System.Drawing.Point(148, 364)
        Me.addUserBtn.Name = "addUserBtn"
        Me.addUserBtn.Size = New System.Drawing.Size(194, 62)
        Me.addUserBtn.TabIndex = 5
        Me.addUserBtn.Text = "Add User"
        Me.addUserBtn.UseVisualStyleBackColor = False
        '
        'addressInput
        '
        Me.addressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addressInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressInput.Location = New System.Drawing.Point(148, 121)
        Me.addressInput.Name = "addressInput"
        Me.addressInput.Size = New System.Drawing.Size(313, 40)
        Me.addressInput.TabIndex = 4
        '
        'nameInput
        '
        Me.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.Location = New System.Drawing.Point(148, 75)
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(313, 40)
        Me.nameInput.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 33)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 33)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Condensed", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 49)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add User"
        '
        'aboutUsPanel
        '
        Me.aboutUsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aboutUsPanel.BackColor = System.Drawing.Color.White
        Me.aboutUsPanel.Controls.Add(Me.about)
        Me.aboutUsPanel.Location = New System.Drawing.Point(255, 67)
        Me.aboutUsPanel.Name = "aboutUsPanel"
        Me.aboutUsPanel.Size = New System.Drawing.Size(744, 587)
        Me.aboutUsPanel.TabIndex = 6
        '
        'about
        '
        Me.about.AutoSize = True
        Me.about.Font = New System.Drawing.Font("Roboto Condensed", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.Location = New System.Drawing.Point(17, 22)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(165, 49)
        Me.about.TabIndex = 0
        Me.about.Text = "About Us"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'formWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 655)
        Me.Controls.Add(Me.logoPanel)
        Me.Controls.Add(Me.topPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.dashboardPanel)
        Me.Controls.Add(Me.storage)
        Me.Controls.Add(Me.aboutUsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formWork"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.leftPanel.ResumeLayout(False)
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logoPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardPanel.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.subPanel7.ResumeLayout(False)
        Me.subPanel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.subPanel6.ResumeLayout(False)
        Me.subPanel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.subPanel5.ResumeLayout(False)
        Me.subPanel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.subPanel4.ResumeLayout(False)
        Me.subPanel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.subPanel3.ResumeLayout(False)
        Me.subPanel3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.subPanel2.ResumeLayout(False)
        Me.subPanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.subPanel1.ResumeLayout(False)
        Me.subPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.storage.ResumeLayout(False)
        Me.storage.PerformLayout()
        Me.aboutUsPanel.ResumeLayout(False)
        Me.aboutUsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftPanel As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents dashboardPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dashboardBtn As Button
    Friend WithEvents closeBtn As Label
    Friend WithEvents storageBtn As Button
    Friend WithEvents aboutBtn As Button
    Friend WithEvents copyright As Button
    Friend WithEvents storage As Panel
    Friend WithEvents addUserBtn As Button
    Friend WithEvents addressInput As TextBox
    Friend WithEvents nameInput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents usernameInput As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents phoneInput As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents moderatorInput As RadioButton
    Friend WithEvents adminInput As RadioButton
    Friend WithEvents aboutUsPanel As Panel
    Friend WithEvents about As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents typeText As Label
    Friend WithEvents lastName As Label
    Friend WithEvents firstName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents timeDay As Label
    Friend WithEvents timeMonth As Label
    Friend WithEvents year2 As Label
    Friend WithEvents year1 As Label
    Friend WithEvents timeMinute As Label
    Friend WithEvents timeHour As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents maximize As PictureBox
    Friend WithEvents subPanel1 As Panel
    Friend WithEvents subPanel2 As Panel
    Friend WithEvents subPanel3 As Panel
    Friend WithEvents subPanel4 As Panel
    Friend WithEvents subPanel5 As Panel
    Friend WithEvents subPanel6 As Panel
    Friend WithEvents subPanel7 As Panel
End Class
