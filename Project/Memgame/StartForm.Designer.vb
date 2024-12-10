<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.Labelname = New System.Windows.Forms.Label()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.difflb = New System.Windows.Forms.Label()
        Me.hardrbtn = New System.Windows.Forms.RadioButton()
        Me.Meduimrbtn = New System.Windows.Forms.RadioButton()
        Me.Easyrbtn = New System.Windows.Forms.RadioButton()
        Me.Startbtn = New System.Windows.Forms.Button()
        Me.Settingspic = New System.Windows.Forms.PictureBox()
        Me.Setting = New Memgame.UserControl1()
        CType(Me.Settingspic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Quitbtn
        '
        Me.Quitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitbtn.Location = New System.Drawing.Point(508, 370)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(89, 43)
        Me.Quitbtn.TabIndex = 1
        Me.Quitbtn.Text = "Quit"
        Me.Quitbtn.UseVisualStyleBackColor = True
        '
        'Labelname
        '
        Me.Labelname.AutoSize = True
        Me.Labelname.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelname.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Labelname.Location = New System.Drawing.Point(253, 374)
        Me.Labelname.Name = "Labelname"
        Me.Labelname.Size = New System.Drawing.Size(173, 31)
        Me.Labelname.TabIndex = 73
        Me.Labelname.Text = "By Ethan Chung"
        '
        'Resetbtn
        '
        Me.Resetbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbtn.Location = New System.Drawing.Point(12, 357)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(189, 56)
        Me.Resetbtn.TabIndex = 75
        Me.Resetbtn.Text = "Reset Everything"
        Me.Resetbtn.UseVisualStyleBackColor = True
        '
        'difflb
        '
        Me.difflb.AutoSize = True
        Me.difflb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.difflb.Location = New System.Drawing.Point(37, 14)
        Me.difflb.Name = "difflb"
        Me.difflb.Size = New System.Drawing.Size(94, 25)
        Me.difflb.TabIndex = 79
        Me.difflb.Text = "Difficulty"
        '
        'hardrbtn
        '
        Me.hardrbtn.AutoSize = True
        Me.hardrbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardrbtn.Location = New System.Drawing.Point(42, 149)
        Me.hardrbtn.Name = "hardrbtn"
        Me.hardrbtn.Size = New System.Drawing.Size(76, 29)
        Me.hardrbtn.TabIndex = 78
        Me.hardrbtn.TabStop = True
        Me.hardrbtn.Text = "Hard"
        Me.hardrbtn.UseVisualStyleBackColor = True
        '
        'Meduimrbtn
        '
        Me.Meduimrbtn.AutoSize = True
        Me.Meduimrbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meduimrbtn.Location = New System.Drawing.Point(42, 103)
        Me.Meduimrbtn.Name = "Meduimrbtn"
        Me.Meduimrbtn.Size = New System.Drawing.Size(106, 29)
        Me.Meduimrbtn.TabIndex = 77
        Me.Meduimrbtn.TabStop = True
        Me.Meduimrbtn.Text = "Medium"
        Me.Meduimrbtn.UseVisualStyleBackColor = True
        '
        'Easyrbtn
        '
        Me.Easyrbtn.AutoSize = True
        Me.Easyrbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easyrbtn.Location = New System.Drawing.Point(42, 58)
        Me.Easyrbtn.Name = "Easyrbtn"
        Me.Easyrbtn.Size = New System.Drawing.Size(78, 29)
        Me.Easyrbtn.TabIndex = 76
        Me.Easyrbtn.TabStop = True
        Me.Easyrbtn.Text = "Easy"
        Me.Easyrbtn.UseVisualStyleBackColor = True
        '
        'Startbtn
        '
        Me.Startbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startbtn.Location = New System.Drawing.Point(505, 324)
        Me.Startbtn.Name = "Startbtn"
        Me.Startbtn.Size = New System.Drawing.Size(92, 40)
        Me.Startbtn.TabIndex = 80
        Me.Startbtn.Text = "Start"
        Me.Startbtn.UseVisualStyleBackColor = True
        '
        'Settingspic
        '
        Me.Settingspic.BackgroundImage = CType(resources.GetObject("Settingspic.BackgroundImage"), System.Drawing.Image)
        Me.Settingspic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Settingspic.Image = CType(resources.GetObject("Settingspic.Image"), System.Drawing.Image)
        Me.Settingspic.Location = New System.Drawing.Point(526, 14)
        Me.Settingspic.Name = "Settingspic"
        Me.Settingspic.Size = New System.Drawing.Size(50, 46)
        Me.Settingspic.TabIndex = 82
        Me.Settingspic.TabStop = False
        '
        'Setting
        '
        Me.Setting.Location = New System.Drawing.Point(154, 83)
        Me.Setting.Name = "Setting"
        Me.Setting.Size = New System.Drawing.Size(422, 209)
        Me.Setting.TabIndex = 81
        Me.Setting.Visible = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 425)
        Me.Controls.Add(Me.Settingspic)
        Me.Controls.Add(Me.Setting)
        Me.Controls.Add(Me.Startbtn)
        Me.Controls.Add(Me.difflb)
        Me.Controls.Add(Me.hardrbtn)
        Me.Controls.Add(Me.Meduimrbtn)
        Me.Controls.Add(Me.Easyrbtn)
        Me.Controls.Add(Me.Resetbtn)
        Me.Controls.Add(Me.Labelname)
        Me.Controls.Add(Me.Quitbtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        CType(Me.Settingspic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quitbtn As System.Windows.Forms.Button
    Friend WithEvents Labelname As System.Windows.Forms.Label
    Friend WithEvents Resetbtn As System.Windows.Forms.Button
    Friend WithEvents difflb As System.Windows.Forms.Label
    Friend WithEvents hardrbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Meduimrbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Easyrbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Startbtn As System.Windows.Forms.Button
    Friend WithEvents Setting As Memgame.UserControl1
    Friend WithEvents Settingspic As System.Windows.Forms.PictureBox
End Class
