<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Monitoring = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Monitoring
        '
        Me.Monitoring.Activecolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Monitoring.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Monitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Monitoring.BorderRadius = 0
        Me.Monitoring.ButtonText = "Monitoring"
        Me.Monitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Monitoring.DisabledColor = System.Drawing.Color.Gray
        Me.Monitoring.Iconcolor = System.Drawing.Color.Transparent
        Me.Monitoring.Iconimage = CType(resources.GetObject("Monitoring.Iconimage"), System.Drawing.Image)
        Me.Monitoring.Iconimage_right = Nothing
        Me.Monitoring.Iconimage_right_Selected = Nothing
        Me.Monitoring.Iconimage_Selected = Nothing
        Me.Monitoring.IconMarginLeft = 0
        Me.Monitoring.IconMarginRight = 0
        Me.Monitoring.IconRightVisible = False
        Me.Monitoring.IconRightZoom = 0R
        Me.Monitoring.IconVisible = False
        Me.Monitoring.IconZoom = 90.0R
        Me.Monitoring.IsTab = True
        Me.Monitoring.Location = New System.Drawing.Point(3, 3)
        Me.Monitoring.Name = "Monitoring"
        Me.Monitoring.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Monitoring.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Monitoring.OnHoverTextColor = System.Drawing.Color.White
        Me.Monitoring.selected = False
        Me.Monitoring.Size = New System.Drawing.Size(218, 63)
        Me.Monitoring.TabIndex = 4
        Me.Monitoring.Text = "Monitoring"
        Me.Monitoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Monitoring.Textcolor = System.Drawing.Color.White
        Me.Monitoring.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 72)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(170, 159)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(255, 107)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 6
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Monitoring)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(707, 485)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Monitoring As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
