Public Class frmWebBrowser

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Hide()
        frmHtmlEditor.Show()
    End Sub
End Class