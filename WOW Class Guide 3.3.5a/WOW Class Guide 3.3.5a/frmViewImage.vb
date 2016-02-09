Public Class frmViewImage

    Private Sub frmViewImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = frmMain.picboxTalent.Image
    End Sub
End Class