Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adapter As New MySqlDataAdapter


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        connect()

        Try
            conn.Open()
        Catch ex As Exception
        End Try

        cmd.CommandText = "SELECT * FROM login WHERE username = '" + username + "' AND password= '" + password + "'"
        Dim myCommand As New MySqlCommand

        cmd.Connection = conn
        adapter.SelectCommand = cmd

        Dim myData As MySqlDataReader
        myData = cmd.ExecuteReader()


        While myData.Read()
            MessageBox.Show(String.Format("username: {0}", myData.GetValue(1)))
        End While
        If myData.HasRows <> 0 Then
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("incorrect username or password!", MsgBoxStyle.Information, "error")
        End If
        conn.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
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
