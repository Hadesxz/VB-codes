<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.btnPlayer = New System.Windows.Forms.Button()
        Me.btnPlayer2 = New System.Windows.Forms.Button()
        Me.btnPlayer3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btn2p = New System.Windows.Forms.Button()
        Me.btn3p = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlayer
        '
        Me.btnPlayer.Location = New System.Drawing.Point(312, 52)
        Me.btnPlayer.Name = "btnPlayer"
        Me.btnPlayer.Size = New System.Drawing.Size(152, 23)
        Me.btnPlayer.TabIndex = 0
        Me.btnPlayer.Text = "Choose Icon For Player 1"
        Me.btnPlayer.UseVisualStyleBackColor = True
        '
        'btnPlayer2
        '
        Me.btnPlayer2.Location = New System.Drawing.Point(312, 155)
        Me.btnPlayer2.Name = "btnPlayer2"
        Me.btnPlayer2.Size = New System.Drawing.Size(152, 23)
        Me.btnPlayer2.TabIndex = 1
        Me.btnPlayer2.Text = "Choose Icon For Player 2"
        Me.btnPlayer2.UseVisualStyleBackColor = True
        '
        'btnPlayer3
        '
        Me.btnPlayer3.Location = New System.Drawing.Point(312, 258)
        Me.btnPlayer3.Name = "btnPlayer3"
        Me.btnPlayer3.Size = New System.Drawing.Size(152, 23)
        Me.btnPlayer3.TabIndex = 2
        Me.btnPlayer3.Text = "Choose Icon For Player 3"
        Me.btnPlayer3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(371, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(371, 115)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(371, 218)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(58, 231)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(135, 50)
        Me.btnMain.TabIndex = 6
        Me.btnMain.Text = "Back To Main"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btn2p
        '
        Me.btn2p.Location = New System.Drawing.Point(73, 58)
        Me.btn2p.Name = "btn2p"
        Me.btn2p.Size = New System.Drawing.Size(105, 39)
        Me.btn2p.TabIndex = 7
        Me.btn2p.Text = "2 Players"
        Me.btn2p.UseVisualStyleBackColor = True
        '
        'btn3p
        '
        Me.btn3p.Location = New System.Drawing.Point(73, 121)
        Me.btn3p.Name = "btn3p"
        Me.btn3p.Size = New System.Drawing.Size(105, 39)
        Me.btn3p.TabIndex = 8
        Me.btn3p.Text = "3 Players"
        Me.btn3p.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(502, 329)
        Me.Controls.Add(Me.btn3p)
        Me.Controls.Add(Me.btn2p)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPlayer3)
        Me.Controls.Add(Me.btnPlayer2)
        Me.Controls.Add(Me.btnPlayer)
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlayer As System.Windows.Forms.Button
    Friend WithEvents btnPlayer2 As System.Windows.Forms.Button
    Friend WithEvents btnPlayer3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents btn2p As System.Windows.Forms.Button
    Friend WithEvents btn3p As System.Windows.Forms.Button
End Class
