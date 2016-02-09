Public Class frmHtmlEditor

    Private Sub rtboxEdit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtboxEdit.DoubleClick
        frmWebBrowser.WebBrowser1.DocumentText = rtboxEdit.Text
        Me.Hide()
        frmWebBrowser.Show()
    End Sub

End Class
