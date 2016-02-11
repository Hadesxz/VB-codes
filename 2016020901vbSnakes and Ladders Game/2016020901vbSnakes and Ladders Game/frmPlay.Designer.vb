<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlay))
        Me.picMap = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.btnDice = New System.Windows.Forms.Button()
        Me.picDice = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.btnBM = New System.Windows.Forms.Button()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMap
        '
        Me.picMap.Image = CType(resources.GetObject("picMap.Image"), System.Drawing.Image)
        Me.picMap.Location = New System.Drawing.Point(0, 0)
        Me.picMap.Name = "picMap"
        Me.picMap.Size = New System.Drawing.Size(480, 400)
        Me.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMap.TabIndex = 1
        Me.picMap.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.Image = CType(resources.GetObject("picPlayer1.Image"), System.Drawing.Image)
        Me.picPlayer1.Location = New System.Drawing.Point(12, 340)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(34, 34)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 2
        Me.picPlayer1.TabStop = False
        '
        'btnDice
        '
        Me.btnDice.Location = New System.Drawing.Point(0, 400)
        Me.btnDice.Name = "btnDice"
        Me.btnDice.Size = New System.Drawing.Size(75, 64)
        Me.btnDice.TabIndex = 8
        Me.btnDice.Text = "Dice"
        Me.btnDice.UseVisualStyleBackColor = True
        '
        'picDice
        '
        Me.picDice.Location = New System.Drawing.Point(81, 400)
        Me.picDice.Name = "picDice"
        Me.picDice.Size = New System.Drawing.Size(75, 64)
        Me.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice.TabIndex = 9
        Me.picDice.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(254, 400)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(110, 64)
        Me.btnRestart.TabIndex = 10
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'picPlayer2
        '
        Me.picPlayer2.Image = CType(resources.GetObject("picPlayer2.Image"), System.Drawing.Image)
        Me.picPlayer2.Location = New System.Drawing.Point(12, 350)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(34, 34)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer2.TabIndex = 11
        Me.picPlayer2.TabStop = False
        '
        'picPlayer3
        '
        Me.picPlayer3.Image = CType(resources.GetObject("picPlayer3.Image"), System.Drawing.Image)
        Me.picPlayer3.Location = New System.Drawing.Point(12, 360)
        Me.picPlayer3.Name = "picPlayer3"
        Me.picPlayer3.Size = New System.Drawing.Size(34, 34)
        Me.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer3.TabIndex = 12
        Me.picPlayer3.TabStop = False
        '
        'btnBM
        '
        Me.btnBM.Location = New System.Drawing.Point(370, 400)
        Me.btnBM.Name = "btnBM"
        Me.btnBM.Size = New System.Drawing.Size(110, 64)
        Me.btnBM.TabIndex = 13
        Me.btnBM.Text = "Back To Main"
        Me.btnBM.UseVisualStyleBackColor = True
        '
        'frmPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(481, 466)
        Me.Controls.Add(Me.btnBM)
        Me.Controls.Add(Me.picPlayer3)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.picDice)
        Me.Controls.Add(Me.btnDice)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.picMap)
        Me.Name = "frmPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snakes and Ladders"
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMap As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDice As System.Windows.Forms.Button
    Friend WithEvents picDice As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents picPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBM As System.Windows.Forms.Button

End Class
