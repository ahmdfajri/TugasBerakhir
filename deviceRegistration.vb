Imports MySql.Data.MySqlClient

Public Class deviceRegistration
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub deviceRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idDevice As String = TextBox1.Text
        Dim intallationDate As String = TextBox2.Text
        Dim deviceType As String = TextBox3.Text
        Dim location As String = TextBox4.Text
        Dim deviceSerialNumber As String = TextBox5.Text

        connect()
        Try
            conn.Open()
        Catch ex As Exception
        End Try
        cmd.CommandText = String.Format("INSERT INTO `regisperangkat` (`idperangkat` , `tanggalinstalasi`,`noproduksi`,`tipeperangkat`,`location`) VALUES ('{0}' , '{1}', '{2}', '{3}', '{4}')", idDevice, intallationDate, deviceType, deviceSerialNumber, location)
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Device Registered!", MsgBoxStyle.Information, "Create")
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

