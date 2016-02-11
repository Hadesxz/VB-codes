Public Class frmMain

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Me.Hide()
        frmPlay.Show()
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        Me.Hide()
        frmSetting.Show()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmSetting.OpenFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png; |All Fles|*.*"
        frmPlay.picPlayer2.Visible = False
        frmPlay.picPlayer3.Visible = False
    End Sub
End Class