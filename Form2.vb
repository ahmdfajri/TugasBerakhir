Imports MySql.Data.MySqlClient

Public Class Form2
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim createUsername As String = TextBox1.Text
        Dim createPassword As String = TextBox2.Text

        Try
            conn.Open()
        Catch ex As Exception
        End Try
        cmd.CommandText = String.Format("INSERT INTO `login` (`username` , `password`) VALUES ('{0}' , '{1}')", createUsername, createPassword)
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Create Account!", MsgBoxStyle.Information, "Create")
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
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