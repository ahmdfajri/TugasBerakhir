Imports MySql.Data.MySqlClient

Public Class photoVoltaic
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim deviceTable

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "idperangkat" Then
            Dim selectedIdCell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
            If selectedIdCell.Value IsNot Nothing Then

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()


        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim SDA As MySqlDataAdapter

        Try
            conn.Open()
            Dim Query As String
            Query = "Select * from `regisperangkat`"
            cmd = New MySqlCommand(Query, conn)
            adapter.SelectCommand = cmd
            adapter.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            adapter.Update(dbDataset)

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()

        End Try


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

    Private Sub photoVoltaic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class
