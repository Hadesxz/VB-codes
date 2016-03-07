Imports System.Threading
Public Class frm1

    Dim th As System.Threading.Thread
    Private Sub shutdown()
        Dim time As Integer = Integer.Parse(tboxTime.Text)
        Do While time > 0
            time -= 1
            lbl2.Text = "This PC will ShutDown in " & time & " second(s)."
            Thread.Sleep(1000)
        Loop
        Shell("shutdown -s -f -t 0")
    End Sub

    Private Sub restart()
        Dim time As Integer = Integer.Parse(tboxTime.Text)
        Do While time > 0
            time -= 1
            lbl2.Text = "This PC will Restart in " & time & " second(s)."
            Thread.Sleep(1000)
        Loop
        Shell("shutdown -r -f -t 0")
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        btnShutdown.Visible = False
        btnRestart.Visible = False
        lbl1.Visible = False
        tboxTime.Visible = False
        lbl2.Visible = True
        btnExit.Visible = True

        th = New System.Threading.Thread(AddressOf shutdown)
        th.Start()

    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        btnShutdown.Visible = False
        btnRestart.Visible = False
        lbl1.Visible = False
        tboxTime.Visible = False
        lbl2.Visible = True
        btnExit.Visible = True

        th = New System.Threading.Thread(AddressOf restart)
        th.Start()
        
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub

    Private Sub frm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub
End Class
