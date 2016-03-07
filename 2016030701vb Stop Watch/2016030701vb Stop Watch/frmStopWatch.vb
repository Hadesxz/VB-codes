Imports System.Threading
Public Class frmStopWatch
    Dim th As System.Threading.Thread
    Dim sec As Integer = 1
    Dim min As Integer = 0
    Dim hr As Integer = 0

    Dim sectext As String = sec
    Dim mintext As String = min
    Dim hrtext As String = hr

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        th = New System.Threading.Thread(AddressOf test)
        If th.ThreadState = ThreadState.Unstarted Then
            th.Start()
        End If
        If th.ThreadState = ThreadState.Suspended Then
            th.Resume()
        End If

    End Sub

    Private Sub test()
        Do While True
            Dim sectext As String = 0 & sec
            Dim mintext As String = 0 & min
            Dim hrtext As String = 0 & hr
            If sec > 9 Then
                sectext = sec
            End If
            If min > 9 Then
                mintext = min
            End If
            If hr > 9 Then
                hrtext = hr
            End If
            lbl_stopwatch.Text = hrtext & ":" & mintext & ":" & sectext

            sec = sec + 1
            Thread.Sleep(1000)
            If sec > 59 Then
                min += 1
                sec = 0
                If min > 59 Then
                    hr += 1
                    min = 0
                End If
            End If
        Loop


    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Environment.Exit(0)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        th.Suspend()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        
        th.Suspend()
        lbl_stopwatch.Text = "00:00:00"
        sec = 1
        min = 0
        hr = 0
    End Sub
End Class
