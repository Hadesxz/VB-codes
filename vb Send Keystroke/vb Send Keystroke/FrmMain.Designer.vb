<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.tboxKeys = New System.Windows.Forms.TextBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lblKeys = New System.Windows.Forms.Label()
        Me.tboxCount = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tboxDelay = New System.Windows.Forms.TextBox()
        Me.lblDelay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(94, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(147, 44)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'tboxKeys
        '
        Me.tboxKeys.Location = New System.Drawing.Point(256, 58)
        Me.tboxKeys.Name = "tboxKeys"
        Me.tboxKeys.Size = New System.Drawing.Size(41, 20)
        Me.tboxKeys.TabIndex = 1
        '
        'btnClick
        '
        Me.btnClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.Location = New System.Drawing.Point(117, 186)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(100, 38)
        Me.btnClick.TabIndex = 4
        Me.btnClick.Text = "Click"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'lblKeys
        '
        Me.lblKeys.AutoSize = True
        Me.lblKeys.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeys.Location = New System.Drawing.Point(33, 59)
        Me.lblKeys.Name = "lblKeys"
        Me.lblKeys.Size = New System.Drawing.Size(177, 19)
        Me.lblKeys.TabIndex = 4
        Me.lblKeys.Text = "Please Enter keys to press"
        '
        'tboxCount
        '
        Me.tboxCount.Location = New System.Drawing.Point(236, 94)
        Me.tboxCount.Name = "tboxCount"
        Me.tboxCount.Size = New System.Drawing.Size(61, 20)
        Me.tboxCount.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(33, 95)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(171, 19)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Please Enter Repeat Time"
        '
        'tboxDelay
        '
        Me.tboxDelay.Location = New System.Drawing.Point(236, 136)
        Me.tboxDelay.Name = "tboxDelay"
        Me.tboxDelay.Size = New System.Drawing.Size(61, 20)
        Me.tboxDelay.TabIndex = 3
        '
        'lblDelay
        '
        Me.lblDelay.AutoSize = True
        Me.lblDelay.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelay.Location = New System.Drawing.Point(33, 137)
        Me.lblDelay.Name = "lblDelay"
        Me.lblDelay.Size = New System.Drawing.Size(150, 19)
        Me.lblDelay.TabIndex = 3
        Me.lblDelay.Text = "Time to delay (in sec)"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(351, 245)
        Me.Controls.Add(Me.lblDelay)
        Me.Controls.Add(Me.tboxDelay)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.tboxCount)
        Me.Controls.Add(Me.lblKeys)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.tboxKeys)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "FrmMain"
        Me.Text = "World Of Warcraft Key Presser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents tboxKeys As System.Windows.Forms.TextBox
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents lblKeys As System.Windows.Forms.Label
    Friend WithEvents tboxCount As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tboxDelay As System.Windows.Forms.TextBox
    Friend WithEvents lblDelay As System.Windows.Forms.Label

End Class
