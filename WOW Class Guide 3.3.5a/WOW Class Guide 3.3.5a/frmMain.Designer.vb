<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.comboxClass = New System.Windows.Forms.ComboBox()
        Me.comboxMode = New System.Windows.Forms.ComboBox()
        Me.comboxTalent = New System.Windows.Forms.ComboBox()
        Me.picboxTalent = New System.Windows.Forms.PictureBox()
        Me.rtboxGuide = New System.Windows.Forms.RichTextBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblTalent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picboxTalent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboxClass
        '
        Me.comboxClass.BackColor = System.Drawing.Color.Black
        Me.comboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboxClass.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxClass.ForeColor = System.Drawing.Color.Lime
        Me.comboxClass.FormattingEnabled = True
        Me.comboxClass.Items.AddRange(New Object() {"Warrior", "Paladin", "Death Knight", "Hunter", "Rogue", "Druid", "Shaman", "Mage", "Priest", "Warlock"})
        Me.comboxClass.Location = New System.Drawing.Point(141, 12)
        Me.comboxClass.Name = "comboxClass"
        Me.comboxClass.Size = New System.Drawing.Size(121, 27)
        Me.comboxClass.TabIndex = 0
        '
        'comboxMode
        '
        Me.comboxMode.BackColor = System.Drawing.Color.Black
        Me.comboxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboxMode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxMode.ForeColor = System.Drawing.Color.Lime
        Me.comboxMode.FormattingEnabled = True
        Me.comboxMode.Items.AddRange(New Object() {"PVP", "PVE"})
        Me.comboxMode.Location = New System.Drawing.Point(12, 12)
        Me.comboxMode.Name = "comboxMode"
        Me.comboxMode.Size = New System.Drawing.Size(121, 27)
        Me.comboxMode.TabIndex = 1
        '
        'comboxTalent
        '
        Me.comboxTalent.BackColor = System.Drawing.Color.Black
        Me.comboxTalent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboxTalent.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxTalent.ForeColor = System.Drawing.Color.Lime
        Me.comboxTalent.FormattingEnabled = True
        Me.comboxTalent.Location = New System.Drawing.Point(270, 12)
        Me.comboxTalent.Name = "comboxTalent"
        Me.comboxTalent.Size = New System.Drawing.Size(155, 27)
        Me.comboxTalent.TabIndex = 2
        '
        'picboxTalent
        '
        Me.picboxTalent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picboxTalent.Cursor = System.Windows.Forms.Cursors.Default
        Me.picboxTalent.Location = New System.Drawing.Point(12, 62)
        Me.picboxTalent.Name = "picboxTalent"
        Me.picboxTalent.Size = New System.Drawing.Size(413, 335)
        Me.picboxTalent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxTalent.TabIndex = 3
        Me.picboxTalent.TabStop = False
        '
        'rtboxGuide
        '
        Me.rtboxGuide.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtboxGuide.BackColor = System.Drawing.Color.LightGray
        Me.rtboxGuide.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtboxGuide.Location = New System.Drawing.Point(431, 12)
        Me.rtboxGuide.Name = "rtboxGuide"
        Me.rtboxGuide.ReadOnly = True
        Me.rtboxGuide.Size = New System.Drawing.Size(509, 385)
        Me.rtboxGuide.TabIndex = 4
        Me.rtboxGuide.Text = ""
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMode.Location = New System.Drawing.Point(21, 19)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(68, 13)
        Me.lblMode.TabIndex = 5
        Me.lblMode.Text = "PvP or PvE?"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.BackColor = System.Drawing.Color.Gainsboro
        Me.lblClass.Location = New System.Drawing.Point(148, 19)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(32, 13)
        Me.lblClass.TabIndex = 6
        Me.lblClass.Text = "Class"
        '
        'lblTalent
        '
        Me.lblTalent.AutoSize = True
        Me.lblTalent.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTalent.Location = New System.Drawing.Point(277, 19)
        Me.lblTalent.Name = "lblTalent"
        Me.lblTalent.Size = New System.Drawing.Size(37, 13)
        Me.lblTalent.TabIndex = 7
        Me.lblTalent.Text = "Talent"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Double Click Photo To View"
        Me.Label1.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(431, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(410, 20)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "WELCOME FROM WOW CLASS GUIDE(3.3.5a)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(943, 409)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTalent)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.rtboxGuide)
        Me.Controls.Add(Me.picboxTalent)
        Me.Controls.Add(Me.comboxTalent)
        Me.Controls.Add(Me.comboxMode)
        Me.Controls.Add(Me.comboxClass)
        Me.Name = "frmMain"
        Me.Text = "WoW Guide"
        CType(Me.picboxTalent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboxClass As System.Windows.Forms.ComboBox
    Friend WithEvents comboxMode As System.Windows.Forms.ComboBox
    Friend WithEvents comboxTalent As System.Windows.Forms.ComboBox
    Friend WithEvents picboxTalent As System.Windows.Forms.PictureBox
    Friend WithEvents rtboxGuide As System.Windows.Forms.RichTextBox
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents lblTalent As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
