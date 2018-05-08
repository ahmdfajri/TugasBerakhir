<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxBatVolt = New System.Windows.Forms.TextBox()
        Me.TextBoxBatCur = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTemp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxLoc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxLoadVolt = New System.Windows.Forms.TextBox()
        Me.TextBoxLoadCur = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSolarVolt = New System.Windows.Forms.TextBox()
        Me.TextBoxSolarCur = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CurrentButton = New System.Windows.Forms.Button()
        Me.VoltButton = New System.Windows.Forms.Button()
        Me.RealTimeGraph = New ZedGraph.ZedGraphControl()
        Me.TextBoxYcor = New System.Windows.Forms.TextBox()
        Me.TextBoxXcor = New System.Windows.Forms.TextBox()
        Me.TextBoxZcor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxBatVolt)
        Me.GroupBox2.Controls.Add(Me.TextBoxBatCur)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(359, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 224)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Battery Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Battery Voltage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Battery Current"
        '
        'TextBoxBatVolt
        '
        Me.TextBoxBatVolt.Location = New System.Drawing.Point(181, 109)
        Me.TextBoxBatVolt.Name = "TextBoxBatVolt"
        Me.TextBoxBatVolt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBatVolt.TabIndex = 2
        '
        'TextBoxBatCur
        '
        Me.TextBoxBatCur.Location = New System.Drawing.Point(181, 42)
        Me.TextBoxBatCur.Name = "TextBoxBatCur"
        Me.TextBoxBatCur.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBatCur.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextBoxZcor)
        Me.GroupBox3.Controls.Add(Me.TextBoxXcor)
        Me.GroupBox3.Controls.Add(Me.TextBoxYcor)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxTemp)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBoxLoc)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBoxStatus)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(357, 224)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controller Information"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(166, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(6, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Device Temp"
        '
        'TextBoxTemp
        '
        Me.TextBoxTemp.Location = New System.Drawing.Point(166, 73)
        Me.TextBoxTemp.Name = "TextBoxTemp"
        Me.TextBoxTemp.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxTemp.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(6, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Device ID "
        '
        'TextBoxLoc
        '
        Me.TextBoxLoc.Location = New System.Drawing.Point(9, 153)
        Me.TextBoxLoc.Name = "TextBoxLoc"
        Me.TextBoxLoc.Size = New System.Drawing.Size(278, 20)
        Me.TextBoxLoc.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(6, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Location"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(6, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Device Status"
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Location = New System.Drawing.Point(166, 105)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxStatus.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 237)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.TextBoxLoadVolt)
        Me.GroupBox5.Controls.Add(Me.TextBoxLoadCur)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(686, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(327, 224)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DC Load Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Load Voltage"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Load Current"
        '
        'TextBoxLoadVolt
        '
        Me.TextBoxLoadVolt.Location = New System.Drawing.Point(181, 109)
        Me.TextBoxLoadVolt.Name = "TextBoxLoadVolt"
        Me.TextBoxLoadVolt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLoadVolt.TabIndex = 2
        '
        'TextBoxLoadCur
        '
        Me.TextBoxLoadCur.Location = New System.Drawing.Point(181, 42)
        Me.TextBoxLoadCur.Name = "TextBoxLoadCur"
        Me.TextBoxLoadCur.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLoadCur.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxSolarVolt)
        Me.GroupBox1.Controls.Add(Me.TextBoxSolarCur)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(1013, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 224)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solar Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(7, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Solar Voltage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Solar Current"
        '
        'TextBoxSolarVolt
        '
        Me.TextBoxSolarVolt.Location = New System.Drawing.Point(123, 109)
        Me.TextBoxSolarVolt.Name = "TextBoxSolarVolt"
        Me.TextBoxSolarVolt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSolarVolt.TabIndex = 1
        '
        'TextBoxSolarCur
        '
        Me.TextBoxSolarCur.Location = New System.Drawing.Point(123, 42)
        Me.TextBoxSolarCur.Name = "TextBoxSolarCur"
        Me.TextBoxSolarCur.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSolarCur.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(12, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 290)
        Me.Panel2.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CurrentButton)
        Me.GroupBox4.Controls.Add(Me.VoltButton)
        Me.GroupBox4.Controls.Add(Me.RealTimeGraph)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(328, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(645, 280)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Real Time Curve"
        '
        'CurrentButton
        '
        Me.CurrentButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrentButton.Location = New System.Drawing.Point(16, 86)
        Me.CurrentButton.Name = "CurrentButton"
        Me.CurrentButton.Size = New System.Drawing.Size(75, 23)
        Me.CurrentButton.TabIndex = 2
        Me.CurrentButton.Text = "Cur"
        Me.CurrentButton.UseVisualStyleBackColor = True
        '
        'VoltButton
        '
        Me.VoltButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VoltButton.Location = New System.Drawing.Point(16, 33)
        Me.VoltButton.Name = "VoltButton"
        Me.VoltButton.Size = New System.Drawing.Size(75, 23)
        Me.VoltButton.TabIndex = 1
        Me.VoltButton.Text = "Volt"
        Me.VoltButton.UseVisualStyleBackColor = True
        '
        'RealTimeGraph
        '
        Me.RealTimeGraph.Location = New System.Drawing.Point(130, 19)
        Me.RealTimeGraph.Name = "RealTimeGraph"
        Me.RealTimeGraph.ScrollGrace = 0R
        Me.RealTimeGraph.ScrollMaxX = 0R
        Me.RealTimeGraph.ScrollMaxY = 0R
        Me.RealTimeGraph.ScrollMaxY2 = 0R
        Me.RealTimeGraph.ScrollMinX = 0R
        Me.RealTimeGraph.ScrollMinY = 0R
        Me.RealTimeGraph.ScrollMinY2 = 0R
        Me.RealTimeGraph.Size = New System.Drawing.Size(484, 225)
        Me.RealTimeGraph.TabIndex = 0
        '
        'TextBoxYcor
        '
        Me.TextBoxYcor.Location = New System.Drawing.Point(127, 198)
        Me.TextBoxYcor.Name = "TextBoxYcor"
        Me.TextBoxYcor.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxYcor.TabIndex = 11
        '
        'TextBoxXcor
        '
        Me.TextBoxXcor.Location = New System.Drawing.Point(11, 198)
        Me.TextBoxXcor.Name = "TextBoxXcor"
        Me.TextBoxXcor.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxXcor.TabIndex = 12
        '
        'TextBoxZcor
        '
        Me.TextBoxZcor.Location = New System.Drawing.Point(247, 198)
        Me.TextBoxZcor.Name = "TextBoxZcor"
        Me.TextBoxZcor.Size = New System.Drawing.Size(74, 20)
        Me.TextBoxZcor.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(6, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "X cordinate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(124, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 15)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Y cordinate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(244, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Z cordinate"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 558)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxBatVolt As TextBox
    Friend WithEvents TextBoxBatCur As TextBox
    Friend WithEvents TextBoxStatus As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CurrentButton As Button
    Friend WithEvents VoltButton As Button
    Friend WithEvents RealTimeGraph As ZedGraph.ZedGraphControl
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxLoc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxTemp As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSolarVolt As TextBox
    Friend WithEvents TextBoxSolarCur As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxLoadVolt As TextBox
    Friend WithEvents TextBoxLoadCur As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxZcor As TextBox
    Friend WithEvents TextBoxXcor As TextBox
    Friend WithEvents TextBoxYcor As TextBox
End Class
