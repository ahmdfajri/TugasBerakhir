<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PhotoVoltaic1 = New WindowsApplication1.photoVoltaic()
        Me.UserControl21 = New WindowsApplication1.UserControl2()
        Me.Userregistration2 = New WindowsApplication1.userregistration()
        Me.DeviceRegistration1 = New WindowsApplication1.deviceRegistration()
        Me.Userregistration1 = New WindowsApplication1.userregistration()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 417)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(13, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(182, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Settings"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(13, 267)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "User Registration"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(13, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Device Registration"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(13, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Photovoltaic Monitoring"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PhotoVoltaic1
        '
        Me.PhotoVoltaic1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PhotoVoltaic1.Location = New System.Drawing.Point(200, 0)
        Me.PhotoVoltaic1.Name = "PhotoVoltaic1"
        Me.PhotoVoltaic1.Size = New System.Drawing.Size(1015, 454)
        Me.PhotoVoltaic1.TabIndex = 5
        '
        'UserControl21
        '
        Me.UserControl21.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.UserControl21.Location = New System.Drawing.Point(200, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(762, 439)
        Me.UserControl21.TabIndex = 4
        '
        'Userregistration2
        '
        Me.Userregistration2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Userregistration2.Location = New System.Drawing.Point(200, 0)
        Me.Userregistration2.Name = "Userregistration2"
        Me.Userregistration2.Size = New System.Drawing.Size(1015, 454)
        Me.Userregistration2.TabIndex = 3
        '
        'DeviceRegistration1
        '
        Me.DeviceRegistration1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.DeviceRegistration1.Location = New System.Drawing.Point(200, 0)
        Me.DeviceRegistration1.Name = "DeviceRegistration1"
        Me.DeviceRegistration1.Size = New System.Drawing.Size(808, 470)
        Me.DeviceRegistration1.TabIndex = 2
        '
        'Userregistration1
        '
        Me.Userregistration1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Userregistration1.Location = New System.Drawing.Point(200, 0)
        Me.Userregistration1.Name = "Userregistration1"
        Me.Userregistration1.Size = New System.Drawing.Size(1015, 454)
        Me.Userregistration1.TabIndex = 1
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 415)
        Me.Controls.Add(Me.PhotoVoltaic1)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.Userregistration2)
        Me.Controls.Add(Me.DeviceRegistration1)
        Me.Controls.Add(Me.Userregistration1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Userregistration1 As userregistration
    Friend WithEvents DeviceRegistration1 As deviceRegistration
    Friend WithEvents Userregistration2 As userregistration
    Friend WithEvents UserControl21 As UserControl2
    Friend WithEvents PhotoVoltaic1 As photoVoltaic
End Class
