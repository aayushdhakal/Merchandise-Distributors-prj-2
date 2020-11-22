Public Class formWork
    Private isBeingDragged As Boolean = False
    Private mouseDownX As Integer
    Private mouseDownY As Integer
    Private primaryColor As Color = Color.FromArgb(1, 183, 10) 'Green Color
    Private secondaryColor As Color = Color.FromArgb(41, 41, 41) 'black
    Private otherColor As Color = Color.FromArgb(75, 75, 75) 'light grey
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles topPanel.MouseDown, leftPanel.MouseDown
        If e.Button = MouseButtons.Left Then
            isBeingDragged = True
            mouseDownX = e.X
            mouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles topPanel.MouseUp, leftPanel.MouseUp
        If e.Button = MouseButtons.Left Then
            isBeingDragged = False
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles topPanel.MouseMove, leftPanel.MouseMove
        If isBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - mouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - mouseDownY)
            Me.Location = tmp
        End If
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        startPage.Close()
    End Sub
    'this function is to show the panel it has been clicked
    Private Sub selectPanel(panel1 As Panel, panel2 As Panel, panel3 As Panel)
        panel1.Show()
        panel2.Hide()
        panel3.Hide()
    End Sub
    'this function make the selected button hightlight with the color type otherColor
    Private Sub selectBtn(button1 As Button, button2 As Button, button3 As Button)
        button1.BackColor = otherColor
        button2.BackColor = secondaryColor
        button3.BackColor = secondaryColor
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        selectBtn(dashboardBtn, storageBtn, aboutBtn)
        selectPanel(dashboardPanel, storage, aboutUsPanel)
    End Sub

    Private Sub registorBtn_Click(sender As Object, e As EventArgs) Handles storageBtn.Click, subPanel4.Click, PictureBox4.Click, Label11.Click, Label12.Click
        selectBtn(storageBtn, dashboardBtn, aboutBtn)
        selectPanel(storage, dashboardPanel, aboutUsPanel)
    End Sub

    Private Sub aboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        selectBtn(aboutBtn, storageBtn, dashboardBtn)
        selectPanel(aboutUsPanel, storage, dashboardPanel)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeDay.Text = Now.ToString("dd")
        timeMonth.Text = MonthName(Now.Date.Month(), False)
        timeHour.Text = Now.ToString("HH")
        timeMinute.Text = Now.ToString("mm:ss")
        year2.Text = Date.Today.Year Mod 2000
        year1.Text = Date.Today.Year.ToString.Substring(0, 2)
    End Sub
    'panel1=black
    'panel2=primaryColor
    'panel2=RGB(204,204,204)
    'PANEL3=RGB(173,173,173)
    Private Sub panelMouseLeave(color As Color, panel As Panel, label As Label, label1 As Label, picture As PictureBox)
        Dim tmpColor As Color = color
        panel.BackColor = tmpColor
        panel.BackColor = tmpColor
        label.BackColor = tmpColor
        label1.BackColor = tmpColor
        picture.BackColor = tmpColor
    End Sub
    Private Sub panelMouseEnter(Panel As Panel, label As Label, label1 As Label, picture As PictureBox)
        Dim tmpColor As Color = Color.FromArgb(160, 160, 160)
        Panel.BackColor = tmpColor
        label.BackColor = tmpColor
        label1.BackColor = tmpColor
        picture.BackColor = tmpColor
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, PictureBox2.MouseEnter, Label2.MouseEnter, Label1.MouseEnter, subPanel1.MouseEnter
        panelMouseEnter(Panel1, Label1, Label2, PictureBox2)
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave, PictureBox2.MouseLeave, Label2.MouseLeave, Label1.MouseLeave, subPanel1.MouseLeave
        panelMouseLeave(Color.Black, Panel1, Label1, Label2, PictureBox2)
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter, PictureBox3.MouseEnter, Label3.MouseEnter, Label10.MouseEnter, subPanel2.MouseEnter
        panelMouseEnter(Panel2, Label10, Label3, PictureBox3)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave, PictureBox3.MouseLeave, Label3.MouseLeave, Label10.MouseLeave, subPanel2.MouseLeave
        panelMouseLeave(primaryColor, Panel2, Label10, Label3, PictureBox3)
    End Sub

    Private Sub Panel4_MouseEnter(sender As Object, e As EventArgs) Handles Panel4.MouseEnter, PictureBox4.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, subPanel4.MouseEnter
        panelMouseEnter(Panel4, Label11, Label12, PictureBox4)
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave, PictureBox4.MouseLeave, Label12.MouseLeave, Label11.MouseLeave, subPanel4.MouseLeave
        panelMouseLeave(Color.FromArgb(173, 173, 173), Panel4, Label12, Label11, PictureBox4)
    End Sub
    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
        dashboardSize()
    End Sub
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub formWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Me.Refresh()
        dashboardSize()
    End Sub
    Private Sub dashboardSize()
        Dim mainPanelsizeX As Double = dashboardPanel.Width
        Dim mainPanelsizeY As Double = dashboardPanel.Height

        Dim singlePanelHeight As Double = ((92 * mainPanelsizeY) / 100) / 3

        Dim mainPanelgapX As Double = (2 * mainPanelsizeX) / 100
        Dim mainPanelgapY As Double = (2 * mainPanelsizeY) / 100

        Panel2.Width = (48 * mainPanelsizeX) / 100
        Panel2.Height = singlePanelHeight
        Panel1.Width = Panel2.Width
        Panel1.Height = singlePanelHeight
        Panel1.Location = New Point(mainPanelgapX, mainPanelgapY)
        Panel2.Location = New Point(mainPanelgapX + Panel1.Width, mainPanelgapY)

        Panel3.Width = (58 * mainPanelsizeX) / 100
        Panel3.Height = singlePanelHeight
        Panel4.Width = (38 * mainPanelsizeX) / 100
        Panel4.Height = singlePanelHeight
        Panel3.Location = New Point(mainPanelgapX, 2 * mainPanelgapY + Panel2.Height)
        Panel4.Location = New Point(mainPanelgapX + Panel3.Width, 2 * mainPanelgapY + Panel2.Height)

        Panel5.Width = (32 * mainPanelsizeX) / 100
        Panel5.Height = singlePanelHeight
        Panel6.Width = Panel5.Width
        Panel6.Height = singlePanelHeight
        Panel7.Width = Panel5.Width
        Panel7.Height = singlePanelHeight
        Panel5.Location = New Point(mainPanelgapX, 3 * mainPanelgapY + 2 * Panel5.Height)
        Panel6.Location = New Point(mainPanelgapX + Panel5.Width, 3 * mainPanelgapY + 2 * Panel5.Height)
        Panel7.Location = New Point(mainPanelgapX + 2 * Panel5.Width, 3 * mainPanelgapY + 2 * Panel5.Height)

        panellocation(Panel1, subPanel1)
        panellocation(Panel2, subPanel2)
        panellocation(Panel3, subPanel3)
        panellocation(Panel4, subPanel4)
        panellocation(Panel5, subPanel5)
        panellocation(Panel6, subPanel6)
        panellocation(Panel7, subPanel7)
    End Sub
    Private Sub onClick()
        MessageBox.Show("hellow")
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, PictureBox2.Click, Label2.Click, Label1.Click
        onClick()
    End Sub

    Private Sub panellocation(parent As Panel, child As Panel)
        Dim childLocationX, childLocationY As Double

        childLocationX = parent.Width / 2 - child.Width / 2
        childLocationY = parent.Height / 2 - child.Height / 2

        child.Location = New Point(childLocationX, childLocationY)

    End Sub
    'this is for minimize,maximize and close background change
    Private Sub bgChange(name As PictureBox, condition As String) 'mouse enter
        If condition = "close" Then
            name.BackColor = Color.Red
        ElseIf condition = "normal" Then
            name.BackColor = primaryColor
        End If

    End Sub
    Private Sub bgChange2(name As PictureBox) 'mouse leave
        name.BackColor = secondaryColor
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startPage.Show()
        startPage.WindowState = Me.WindowState
        Me.Hide()
    End Sub
End Class