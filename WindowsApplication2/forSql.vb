Imports MySql.Data.MySqlClient
Public Class forSql
    Public Function checkPassword(username As TextBox, password As TextBox)
        Dim constr = "server=localhost;uid=root;pwd=;database=project"
        Dim sql = "SELECT * FROM login WHERE username=@username and password=@password;"

        Using dbcon As New MySqlConnection(constr)
            Using cmd As New MySqlCommand(sql, dbcon)
                dbcon.Open()
                cmd.Parameters.Add(New MySqlParameter("@username", username.Text))
                cmd.Parameters.Add(New MySqlParameter("@password", password.Text))
                Using rdr = cmd.ExecuteReader
                    If rdr.HasRows Then
                        username.Text = ""
                        password.Text = ""
                        Return 1
                    Else
                        Return 0
                    End If
                End Using
                dbcon.Close()
            End Using
        End Using
    End Function


End Class
