Imports MySql.Data.MySqlClient

Public Class userregistration
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userName As String = TextBox1.Text
        Dim userNumber As String = TextBox2.Text
        Dim userType As String = TextBox3.Text
        connect()
        Try
            conn.Open()
        Catch ex As Exception
        End Try
        cmd.CommandText = String.Format("INSERT INTO `userregistration` (`name` , `user_number`,`user_type`) VALUES ('{0}' , '{1}', '{2}')", userName, userNumber, userType)
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("User Registered!", MsgBoxStyle.Information, "Create")
    End Sub

    Public Sub connect()
        Dim DatabaseName As String = "solarchargermonitoring"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class
