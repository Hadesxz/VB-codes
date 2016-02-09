<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picMap = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.btnDice = New System.Windows.Forms.Button()
        Me.picDice = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'picPlayer
        '
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(12, 340)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(34, 34)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 2
        Me.picPlayer.TabStop = False
        '
        'btnDice
        '
        Me.btnDice.Location = New System.Drawing.Point(12, 407)
        Me.btnDice.Name = "btnDice"
        Me.btnDice.Size = New System.Drawing.Size(75, 47)
        Me.btnDice.TabIndex = 8
        Me.btnDice.Text = "Dice"
        Me.btnDice.UseVisualStyleBackColor = True
        '
        'picDice
        '
        Me.picDice.Location = New System.Drawing.Point(113, 407)
        Me.picDice.Name = "picDice"
        Me.picDice.Size = New System.Drawing.Size(75, 47)
        Me.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice.TabIndex = 9
        Me.picDice.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(359, 407)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(110, 47)
        Me.btnRestart.TabIndex = 10
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(481, 466)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.picDice)
        Me.Controls.Add(Me.btnDice)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picMap)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMap As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents btnDice As System.Windows.Forms.Button
    Friend WithEvents picDice As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestart As System.Windows.Forms.Button

End Class
