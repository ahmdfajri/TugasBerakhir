Imports MySql.Data.MySqlClient
Imports ZedGraph


Public Class Form4
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim user_select
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        Try
            conn.Open()
            Dim Query As String
            Query = "Select distinct(`id perangkat`) from `regisperangkat`"
            cmd = New MySqlCommand(Query, conn)
            Dim reader = cmd.ExecuteReader
            While reader.Read
                ComboBox1.Items.Add(reader.GetString("id perangkat"))
            End While
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        user_select = ComboBox1.Text
        connect()

        Try
            conn.Open()
            Dim Query As String
            Query = "Select * from `regisperangkat` Where `id perangkat`='" + user_select + "' ORDER BY `id` DESC"
            cmd = New MySqlCommand(Query, conn)
            Dim reader = cmd.ExecuteReader
            'read only first row'

            reader.Read()
            TextBoxTemp.Text = reader.GetString("device temp")
            TextBoxBatCur.Text = reader.GetString("cell current")
            TextBoxBatVolt.Text = reader.GetString("cell voltage")
            TextBoxLoadCur.Text = reader.GetString("load current")
            TextBoxLoc.Text = reader.GetString("location")
            TextBoxStatus.Text = reader.GetString("status")
            TextBoxLoadVolt.Text = reader.GetString("load voltage")
            TextBoxSolarCur.Text = reader.GetString("solar current")
            TextBoxSolarVolt.Text = reader.GetString("solar voltage")
            TextBoxXcor.Text = reader.GetString("cordinate x")
            TextBoxYcor.Text = reader.GetString("cordinate y")
            TextBoxZcor.Text = reader.GetString("cordinate z")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub CreateVoltGraph(realTimeGraph As ZedGraphControl, reader As MySqlDataReader)
        'clear the graph'
        realTimeGraph.GraphPane.CurveList.Clear()
        Dim myPane As GraphPane = realTimeGraph.GraphPane
        Dim solarCurve As CurveItem
        Dim loadCurve As CurveItem
        Dim batteryCurve As CurveItem

        'Set the Titles'
        myPane.Title.Text = "Real Time Graph)"
        myPane.XAxis.Title.Text = "Time"
        myPane.YAxis.Title.Text = "Value (Solar, Battery, Load)"
        'make an array for data'
        Dim solarVoltageData As New PointPairList
        Dim loadVoltageData As New PointPairList
        Dim batteryVoltageData As New PointPairList
        While reader.Read()
            solarVoltageData.Add(reader.GetDateTime("trigger time").ToOADate, reader.GetString("solar voltage"))
            loadVoltageData.Add(reader.GetDateTime("trigger time").ToOADate, reader.GetString("load voltage"))
            batteryVoltageData.Add(reader.GetDateTime("trigger time").ToOADate, reader.GetString("cell voltage"))
        End While
        'Generate a red curve with diamond'
        'symbols, And "Solar" in the legend'
        solarCurve = myPane.AddCurve("Solar", solarVoltageData, Color.Yellow, SymbolType.Circle)
        loadCurve = myPane.AddCurve("Load", loadVoltageData, Color.Red, SymbolType.Square)
        batteryCurve = myPane.AddCurve("Battery", batteryVoltageData, Color.Blue, SymbolType.Triangle)


        'Set the XAxis to date type'
        myPane.XAxis.Type = AxisType.Date
        'Tell ZedGraph to refigure the axes since the data' 
        'have changed'

        realTimeGraph.AxisChange()
    End Sub
    Private Sub CreateCurGraph(realTimeGraph As ZedGraphControl, reader As MySqlDataReader)
        'clear the graph'
        realTimeGraph.GraphPane.CurveList.Clear()
        Dim myPane As GraphPane = realTimeGraph.GraphPane
        Dim solarCurve As CurveItem
        Dim loadCurve As CurveItem
        Dim batteryCurve As CurveItem

        'Set the Titles'
        myPane.Title.Text = "Real Time Graph)"
        myPane.XAxis.Title.Text = "Time"
        myPane.YAxis.Title.Text = "Value (Solar, Battery, Load)"
        'make an array for data'
        Dim solarCurrentData As New PointPairList
        Dim loadCurrentData As New PointPairList
        Dim batteryCurrentData As New PointPairList
        While reader.Read()
            solarCurrentData.Add(reader.GetDateTime("trigger time").ToOADate, reader.GetString("solar current"))
            loadCurrentData.Add(reader.GetDateTime("trigger time").ToOADate, reader.GetString("load current"))
            batteryCurrentData.Add(reader.GetDateTime("trigger time").ToOADate, reader.GetString("cell current"))
        End While
        'Generate a red curve with diamond'
        'symbols, And "Solar" in the legend'
        solarCurve = myPane.AddCurve("Solar", solarCurrentData, Color.Yellow, SymbolType.Circle)
        loadCurve = myPane.AddCurve("Load", loadCurrentData, Color.Red, SymbolType.Square)
        batteryCurve = myPane.AddCurve("Battery", batteryCurrentData, Color.Blue, SymbolType.Triangle)


        'Set the XAxis to date type'
        myPane.XAxis.Type = AxisType.Date
        'Tell ZedGraph to refigure the axes since the data' 
        'have changed'

        realTimeGraph.AxisChange()
    End Sub

    Private Sub VoltButton_Click(sender As Object, e As EventArgs) Handles VoltButton.Click
        Try
            conn.Open()
            Dim Query As String
            Query = "Select `load voltage`,`cell voltage`,`solar voltage`,`trigger time` from `regisperangkat` Where `id perangkat`='" + user_select + "'"
            cmd = New MySqlCommand(Query, conn)
            Dim reader = cmd.ExecuteReader
            CreateVoltGraph(RealTimeGraph, reader)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub CurrentButton_Click(sender As Object, e As EventArgs) Handles CurrentButton.Click
        Try
            conn.Open()
            Dim Query As String
            Query = "Select `load current`,`cell current`,`solar current`,`trigger time` from `regisperangkat` Where `id perangkat`='" + user_select + "'"
            cmd = New MySqlCommand(Query, conn)
            Dim reader = cmd.ExecuteReader
            CreateCurGraph(RealTimeGraph, reader)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxXcor.TextChanged

    End Sub
End Class