Imports MySql.Data.MySqlClient

Public Class Form3



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PhotoVoltaic1.BringToFront()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeviceRegistration1.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Userregistration1.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserControl21.BringToFront()
    End Sub

    Private Sub PhotoVoltaic1_Load(sender As Object, e As EventArgs) Handles PhotoVoltaic1.Load

    End Sub
End Class