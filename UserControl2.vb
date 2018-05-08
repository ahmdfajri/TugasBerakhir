﻿Imports MySql.Data.MySqlClient

Public Class UserControl2
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ssidName As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        connect()
        Try
            conn.Open()
        Catch ex As Exception
        End Try
        cmd.CommandText = String.Format("INSERT INTO `settings` (`ssid_name` , `ssid_password`) VALUES ('{0}' , '{1}')", ssidName, pass)
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Setting Registered!", MsgBoxStyle.Information, "Create")

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
