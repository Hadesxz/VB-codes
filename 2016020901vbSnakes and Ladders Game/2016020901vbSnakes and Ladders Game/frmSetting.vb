Public Class frmSetting

    Private Sub btnPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            frmMain.picPlayer1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub frmSetting_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnPlayer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer2.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            frmMain.picPlayer2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnPlayer3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer3.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            frmMain.picPlayer3.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Me.Hide()
        frmMain.Show()
    End Sub

 
End Class