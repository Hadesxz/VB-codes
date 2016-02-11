Public Class frmSetting

    Private Sub btnPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            frmPlay.picPlayer1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub frmSetting_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnPlayer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer2.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            frmPlay.picPlayer2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnPlayer3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer3.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            frmPlay.picPlayer3.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Me.Hide()
        frmMain.Show()
    End Sub


    Public Sub btn2p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2p.Click
        frmPlay.u = 2
        frmPlay.picPlayer2.Visible = True
        frmPlay.picPlayer3.Visible = False
        MessageBox.Show("2 players!")
    End Sub

    Public Sub btn3p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3p.Click
        frmPlay.u = 3
        frmPlay.picPlayer2.Visible = True
        frmPlay.picPlayer3.Visible = True
        MessageBox.Show("3 players!")
    End Sub
End Class