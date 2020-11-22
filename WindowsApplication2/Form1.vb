Public Class startPage
    Private isBeingDragged As Boolean = False
    Private mouseDownX As Integer
    Private mouseDownY As Integer
    Private primaryColor As Color = Color.FromArgb(1, 183, 10)
    Private secondaryColor As Color = Color.FromArgb(41, 41, 41)
    Private otherColor As Color = Color.FromArgb(75, 75, 75)

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
        Me.Close()
    End Sub

    Private Sub selectPanel(panel1 As Panel, panel2 As Panel, panel3 As Panel)
        panel1.Show()
        panel2.Hide()
        panel3.Hide()
    End Sub
    Private Sub selectBtn(button1 As Button, button2 As Button, button3 As Button)
        button1.BackColor = otherColor
        button2.BackColor = secondaryColor
        button3.BackColor = secondaryColor
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        selectBtn(loginBtn, addNewUserBtn, aboutBtn)
        selectPanel(loginPanel, newUserPanel, aboutUsPanel)
    End Sub

    Private Sub registorBtn_Click(sender As Object, e As EventArgs) Handles addNewUserBtn.Click
        selectBtn(addNewUserBtn, loginBtn, aboutBtn)
        selectPanel(newUserPanel, loginPanel, aboutUsPanel)
    End Sub

    Private Sub aboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        selectBtn(aboutBtn, addNewUserBtn, loginBtn)
        selectPanel(aboutUsPanel, newUserPanel, loginPanel)
    End Sub
    Private Sub startPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        displayMessage.Hide()
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim send As New forSql
        If send.checkPassword(username, password) = 1 Then
            formWork.Show()
            formWork.WindowState = Me.WindowState
            Me.Hide()
        ElseIf send.checkPassword(username, password) = 0 Then
            displayMessage.Show()
        End If
    End Sub

End Class
