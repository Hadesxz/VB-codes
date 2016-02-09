Public Class frm1

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        btnShutdown.Visible = False
        btnRestart.Visible = False
        lbl1.Visible = False
        tboxTime.Visible = False
        lbl2.Visible = True
        btnExit.Visible = True
        Dim time As Integer = Integer.Parse(tboxTime.Text)
        Do While time > 0
            time -= 1
            lbl2.Text = "This PC will ShutDown in " & time + 1 & " second(s)."
            Delay(1)
        Loop
        Shell("shutdown -s -f -t 0")
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        btnShutdown.Visible = False
        btnRestart.Visible = False
        lbl1.Visible = False
        tboxTime.Visible = False
        lbl2.Visible = True
        btnExit.Visible = True
        Dim time As Integer = Integer.Parse(tboxTime.Text)
        Do While time >= 0
            time -= 1
            lbl2.Text = "This PC will Restart in " & time + 1 & " second(s)."
            Delay(1)
        Loop
        Shell("shutdown -r -f -t 0")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub
End Class
