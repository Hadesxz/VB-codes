Public Class frmMain

    Private Sub picboxTalent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picboxTalent.DoubleClick
        frmViewImage.Show()
    End Sub


    Private Sub comboxClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboxClass.SelectedIndexChanged
        comboxTalent.Enabled = True
        lblClass.Hide()
        Select Case comboxClass.SelectedItem.ToString()
            Case "Warrior"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Arms")
                comboxTalent.Items.Add("Protection")
                comboxTalent.Items.Add("Fury")
            Case "Paladin"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Holy")
                comboxTalent.Items.Add("Protection")
                comboxTalent.Items.Add("Retribution")
            Case "Death Knight"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Blood")
                comboxTalent.Items.Add("Frost")
                comboxTalent.Items.Add("Unholy")
            Case "Hunter"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Beast Mastery")
                comboxTalent.Items.Add("Marksmanship")
                comboxTalent.Items.Add("Survival")
            Case "Rogue"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Assassination")
                comboxTalent.Items.Add("Combat")
                comboxTalent.Items.Add("Subtlety")
            Case "Mage"
                comboxTalent.Items.Clear()
                If comboxMode.SelectedItem.ToString() = "PVE" Then
                    comboxTalent.Items.Add("Arcane")
                    comboxTalent.Items.Add("Fire(TTW)")
                    comboxTalent.Items.Add("Fire(LB FFB)")
                    comboxTalent.Items.Add("Frost")
                Else
                    comboxTalent.Items.Add("Arcane")
                    comboxTalent.Items.Add("Fire")
                    comboxTalent.Items.Add("Frost")
                End If
            Case "Shaman"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Elemental")
                comboxTalent.Items.Add("Enhancement")
                comboxTalent.Items.Add("Restoration")
            Case "Priest"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Discipline")
                comboxTalent.Items.Add("Holy")
                comboxTalent.Items.Add("Shadow")
            Case "Druid"
                comboxTalent.Items.Clear()
                comboxTalent.Items.Add("Balance")
                comboxTalent.Items.Add("Feral")
                comboxTalent.Items.Add("Healr")
            Case "Warlock"
                comboxTalent.Items.Add("Affliction")
                comboxTalent.Items.Add("Demonology")
                comboxTalent.Items.Add("Destruction")

        End Select
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to EXIT?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Environment.Exit(1)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboxClass.Enabled = False
        comboxTalent.Enabled = False
        rtboxGuide.Hide()
        picboxTalent.Hide()
    End Sub

    Private Sub comboxMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboxMode.SelectedIndexChanged
        comboxClass.Enabled = True
        lblMode.Hide()
        If comboxClass.SelectedItem = Nothing Then
        ElseIf comboxMode.SelectedItem.ToString() = "PVP" And comboxClass.SelectedItem.ToString() = "Mage" Then
            comboxTalent.Items.Clear()
            comboxTalent.Items.Add("Arcane")
            comboxTalent.Items.Add("Fire")
            comboxTalent.Items.Add("Frost")
        ElseIf comboxMode.SelectedItem.ToString() = "PVE" And comboxClass.SelectedItem.ToString() = "Mage" Then
            comboxTalent.Items.Clear()
            comboxTalent.Items.Add("Arcane")
            comboxTalent.Items.Add("Fire(TTW)")
            comboxTalent.Items.Add("Fire(LB FFB)")
            comboxTalent.Items.Add("Frost")
        End If
    End Sub

    Private Sub comboxTalent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboxTalent.SelectedIndexChanged
        lblTalent.Hide()
        Label1.Show()
        lblTitle.Hide()
        Dim srFileReader As IO.StreamReader = Nothing
        Dim sReadFileName As String = comboxMode.SelectedItem.ToString() + comboxClass.SelectedItem.ToString() + comboxTalent.SelectedItem.ToString() + ".txt"
        Dim stext As String = ""
        Dim sLine As String = ""
        srFileReader = System.IO.File.OpenText(sReadFileName)
        stext = srFileReader.ReadToEnd()
        rtboxGuide.Text = stext
        picboxTalent.Image = Image.FromFile(comboxMode.SelectedItem.ToString() + comboxClass.SelectedItem.ToString() + comboxTalent.SelectedItem.ToString() + ".png")
        rtboxGuide.Show()
        picboxTalent.Show()
    End Sub

End Class
