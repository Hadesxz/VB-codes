<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.tboxTime = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShutdown
        '
        Me.btnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShutdown.Location = New System.Drawing.Point(176, 35)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(122, 38)
        Me.btnShutdown.TabIndex = 0
        Me.btnShutdown.Text = "Shutdown"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(176, 89)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(122, 38)
        Me.btnRestart.TabIndex = 1
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'tboxTime
        '
        Me.tboxTime.Location = New System.Drawing.Point(20, 88)
        Me.tboxTime.Name = "tboxTime"
        Me.tboxTime.Size = New System.Drawing.Size(128, 20)
        Me.tboxTime.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(12, 47)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(153, 16)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Please Enter Time in Second"
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(-6, 60)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(304, 34)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "."
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl2.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.Location = New System.Drawing.Point(0, 146)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(298, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(298, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.tboxTime)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnShutdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shutdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents tboxTime As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
