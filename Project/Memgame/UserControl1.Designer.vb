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
        Me.Mutebtn = New System.Windows.Forms.PictureBox()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Volupbtn = New System.Windows.Forms.Button()
        Me.Voldownbtn = New System.Windows.Forms.Button()
        CType(Me.Mutebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mutebtn
        '
        Me.Mutebtn.BackgroundImage = Global.Memgame.My.Resources.Resources.vol_muted
        Me.Mutebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mutebtn.Location = New System.Drawing.Point(206, 3)
        Me.Mutebtn.Name = "Mutebtn"
        Me.Mutebtn.Size = New System.Drawing.Size(71, 70)
        Me.Mutebtn.TabIndex = 2
        Me.Mutebtn.TabStop = False
        '
        'Savebtn
        '
        Me.Savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.Location = New System.Drawing.Point(189, 146)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(98, 40)
        Me.Savebtn.TabIndex = 3
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'Volupbtn
        '
        Me.Volupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volupbtn.Location = New System.Drawing.Point(88, 79)
        Me.Volupbtn.Name = "Volupbtn"
        Me.Volupbtn.Size = New System.Drawing.Size(120, 61)
        Me.Volupbtn.TabIndex = 9
        Me.Volupbtn.Text = "Volume Up"
        Me.Volupbtn.UseVisualStyleBackColor = True
        '
        'Voldownbtn
        '
        Me.Voldownbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voldownbtn.Location = New System.Drawing.Point(283, 79)
        Me.Voldownbtn.Name = "Voldownbtn"
        Me.Voldownbtn.Size = New System.Drawing.Size(120, 61)
        Me.Voldownbtn.TabIndex = 10
        Me.Voldownbtn.Text = "Volume Down"
        Me.Voldownbtn.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Voldownbtn)
        Me.Controls.Add(Me.Volupbtn)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Mutebtn)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(503, 189)
        CType(Me.Mutebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mutebtn As System.Windows.Forms.PictureBox
    Friend WithEvents Savebtn As System.Windows.Forms.Button
    Friend WithEvents Volupbtn As System.Windows.Forms.Button
    Friend WithEvents Voldownbtn As System.Windows.Forms.Button

End Class
