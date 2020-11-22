<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class startPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startPage))
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.copyright = New System.Windows.Forms.Button()
        Me.aboutBtn = New System.Windows.Forms.Button()
        Me.addNewUserBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.maximize = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.Label()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.displayMessage = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newUserPanel = New System.Windows.Forms.Panel()
        Me.lastNameInput = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.firstNameInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.aboutUsPanel = New System.Windows.Forms.Panel()
        Me.about = New System.Windows.Forms.Label()
        Me.leftPanel.SuspendLayout()
        Me.topPanel.SuspendLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logoPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginPanel.SuspendLayout()
        Me.newUserPanel.SuspendLayout()
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
        Me.leftPanel.Controls.Add(Me.addNewUserBtn)
        Me.leftPanel.Controls.Add(Me.loginBtn)
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
        Me.aboutBtn.Text = "About Us"
        Me.aboutBtn.UseVisualStyleBackColor = False
        '
        'addNewUserBtn
        '
        Me.addNewUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.addNewUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.addNewUserBtn.FlatAppearance.BorderSize = 0
        Me.addNewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addNewUserBtn.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewUserBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addNewUserBtn.Image = CType(resources.GetObject("addNewUserBtn.Image"), System.Drawing.Image)
        Me.addNewUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewUserBtn.Location = New System.Drawing.Point(0, 305)
        Me.addNewUserBtn.Name = "addNewUserBtn"
        Me.addNewUserBtn.Size = New System.Drawing.Size(254, 63)
        Me.addNewUserBtn.TabIndex = 2
        Me.addNewUserBtn.Text = "Add User"
        Me.addNewUserBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.loginBtn.Image = CType(resources.GetObject("loginBtn.Image"), System.Drawing.Image)
        Me.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtn.Location = New System.Drawing.Point(0, 242)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(254, 63)
        Me.loginBtn.TabIndex = 1
        Me.loginBtn.Text = "Login     "
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'topPanel
        '
        Me.topPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.topPanel.Controls.Add(Me.minimize)
        Me.topPanel.Controls.Add(Me.maximize)
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
        'loginPanel
        '
        Me.loginPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginPanel.BackColor = System.Drawing.Color.White
        Me.loginPanel.Controls.Add(Me.displayMessage)
        Me.loginPanel.Controls.Add(Me.login)
        Me.loginPanel.Controls.Add(Me.password)
        Me.loginPanel.Controls.Add(Me.username)
        Me.loginPanel.Controls.Add(Me.Label3)
        Me.loginPanel.Controls.Add(Me.Label2)
        Me.loginPanel.Controls.Add(Me.Label1)
        Me.loginPanel.Location = New System.Drawing.Point(255, 67)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(744, 587)
        Me.loginPanel.TabIndex = 3
        '
        'displayMessage
        '
        Me.displayMessage.AutoSize = True
        Me.displayMessage.Font = New System.Drawing.Font("Roboto Condensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayMessage.ForeColor = System.Drawing.Color.Red
        Me.displayMessage.Location = New System.Drawing.Point(121, 248)
        Me.displayMessage.Name = "displayMessage"
        Me.displayMessage.Size = New System.Drawing.Size(254, 25)
        Me.displayMessage.TabIndex = 6
        Me.displayMessage.Text = "Invaild Username or Password"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.login.FlatAppearance.BorderSize = 0
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.login.Location = New System.Drawing.Point(148, 177)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(194, 62)
        Me.login.TabIndex = 5
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(148, 127)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(313, 40)
        Me.password.TabIndex = 4
        Me.password.Text = "password"
        '
        'username
        '
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(148, 75)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(313, 40)
        Me.username.TabIndex = 3
        Me.username.Text = "admin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'newUserPanel
        '
        Me.newUserPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newUserPanel.BackColor = System.Drawing.Color.White
        Me.newUserPanel.Controls.Add(Me.lastNameInput)
        Me.newUserPanel.Controls.Add(Me.Label10)
        Me.newUserPanel.Controls.Add(Me.adminInput)
        Me.newUserPanel.Controls.Add(Me.moderatorInput)
        Me.newUserPanel.Controls.Add(Me.passwordInput)
        Me.newUserPanel.Controls.Add(Me.Label9)
        Me.newUserPanel.Controls.Add(Me.usernameInput)
        Me.newUserPanel.Controls.Add(Me.Label8)
        Me.newUserPanel.Controls.Add(Me.phoneInput)
        Me.newUserPanel.Controls.Add(Me.Label7)
        Me.newUserPanel.Controls.Add(Me.addUserBtn)
        Me.newUserPanel.Controls.Add(Me.addressInput)
        Me.newUserPanel.Controls.Add(Me.firstNameInput)
        Me.newUserPanel.Controls.Add(Me.Label4)
        Me.newUserPanel.Controls.Add(Me.Label5)
        Me.newUserPanel.Controls.Add(Me.Label6)
        Me.newUserPanel.Location = New System.Drawing.Point(255, 67)
        Me.newUserPanel.Name = "newUserPanel"
        Me.newUserPanel.Size = New System.Drawing.Size(744, 587)
        Me.newUserPanel.TabIndex = 6
        '
        'lastNameInput
        '
        Me.lastNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastNameInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameInput.Location = New System.Drawing.Point(172, 121)
        Me.lastNameInput.Name = "lastNameInput"
        Me.lastNameInput.Size = New System.Drawing.Size(313, 40)
        Me.lastNameInput.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 33)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Last Name"
        '
        'adminInput
        '
        Me.adminInput.AutoSize = True
        Me.adminInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminInput.Location = New System.Drawing.Point(353, 363)
        Me.adminInput.Name = "adminInput"
        Me.adminInput.Size = New System.Drawing.Size(108, 35)
        Me.adminInput.TabIndex = 13
        Me.adminInput.TabStop = True
        Me.adminInput.Text = "Admin"
        Me.adminInput.UseVisualStyleBackColor = True
        '
        'moderatorInput
        '
        Me.moderatorInput.AutoSize = True
        Me.moderatorInput.Checked = True
        Me.moderatorInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moderatorInput.Location = New System.Drawing.Point(172, 363)
        Me.moderatorInput.Name = "moderatorInput"
        Me.moderatorInput.Size = New System.Drawing.Size(155, 35)
        Me.moderatorInput.TabIndex = 12
        Me.moderatorInput.TabStop = True
        Me.moderatorInput.Text = "Moderator"
        Me.moderatorInput.UseVisualStyleBackColor = True
        '
        'passwordInput
        '
        Me.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInput.Location = New System.Drawing.Point(172, 308)
        Me.passwordInput.Name = "passwordInput"
        Me.passwordInput.Size = New System.Drawing.Size(313, 40)
        Me.passwordInput.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 33)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Password"
        '
        'usernameInput
        '
        Me.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usernameInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameInput.Location = New System.Drawing.Point(172, 259)
        Me.usernameInput.Name = "usernameInput"
        Me.usernameInput.Size = New System.Drawing.Size(313, 40)
        Me.usernameInput.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 33)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Username"
        '
        'phoneInput
        '
        Me.phoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneInput.Location = New System.Drawing.Point(172, 213)
        Me.phoneInput.Name = "phoneInput"
        Me.phoneInput.Size = New System.Drawing.Size(313, 40)
        Me.phoneInput.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 215)
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
        Me.addUserBtn.Location = New System.Drawing.Point(172, 427)
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
        Me.addressInput.Location = New System.Drawing.Point(172, 167)
        Me.addressInput.Name = "addressInput"
        Me.addressInput.Size = New System.Drawing.Size(313, 40)
        Me.addressInput.TabIndex = 4
        '
        'firstNameInput
        '
        Me.firstNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstNameInput.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameInput.Location = New System.Drawing.Point(172, 75)
        Me.firstNameInput.Name = "firstNameInput"
        Me.firstNameInput.Size = New System.Drawing.Size(313, 40)
        Me.firstNameInput.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 169)
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
        Me.Label5.Size = New System.Drawing.Size(131, 33)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "First Name"
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
        'startPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 655)
        Me.Controls.Add(Me.logoPanel)
        Me.Controls.Add(Me.topPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.newUserPanel)
        Me.Controls.Add(Me.aboutUsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "startPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.leftPanel.ResumeLayout(False)
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logoPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.newUserPanel.ResumeLayout(False)
        Me.newUserPanel.PerformLayout()
        Me.aboutUsPanel.ResumeLayout(False)
        Me.aboutUsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftPanel As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents loginPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents closeBtn As Label
    Friend WithEvents addNewUserBtn As Button
    Friend WithEvents aboutBtn As Button
    Friend WithEvents copyright As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents login As Button
    Friend WithEvents newUserPanel As Panel
    Friend WithEvents addUserBtn As Button
    Friend WithEvents addressInput As TextBox
    Friend WithEvents firstNameInput As TextBox
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
    Friend WithEvents lastNameInput As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents minimize As PictureBox
    Friend WithEvents maximize As PictureBox
    Friend WithEvents displayMessage As Label
End Class
