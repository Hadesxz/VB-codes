Imports System.Threading

Public Class FrmMain

    Dim th As System.Threading.Thread
    Dim i As Integer = 1
    Dim key As String = ""
    Dim count As Integer = 1
    Dim de As Integer = 1
    Dim delay As Double = 1

    Property Nullable As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            AppActivate("World of Warcraft")
            SendKeys.SendWait("Username")
            SendKeys.SendWait("{TAB}")
            SendKeys.SendWait("Password")
            SendKeys.SendWait("{ENTER}")
        Catch ex As Exception
            MessageBox.Show("Please start World of Warcraft")
        End Try

    End Sub

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        th = New Thread(AddressOf clicking)
        th.Start()
    End Sub

    Private Sub clicking()

        If tboxCount.Text = Nothing Or tboxDelay.Text = Nothing Or tboxKeys.Text = Nothing Then
            MessageBox.Show("Please fill blanks.")
        Else
            key = tboxKeys.Text.ToString()
            count = Integer.Parse(tboxCount.Text)
            de = Double.Parse(tboxDelay.Text)
            delay = de * 1000
        End If

        Try

            While i <= count
                'SendMessageHM(hWndR2, WM_SETTEXT, 0, "a")
		SendKeys.SendWait(key)
                i = i + 1
                Thread.Sleep(delay)
            End While
        Catch ex As Exception
            MessageBox.Show("Please start World of Warcraft")
        End Try
        tboxCount.Clear()
        tboxKeys.Clear()
        tboxDelay.Clear()
    End Sub

    'Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Control.CheckForIllegalCrossThreadCalls = False
        'SendMessageHM(hWndR2, WM_SETTEXT, 1, "Hello World!!")
    'End Sub

    'Dim WM_SETTEXT As Long = 13
    'Dim GW_CHILD As Long = 5

    'Declare Function GetWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal uCmd As Integer) As IntPtr

    'Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr 'Int32

    'Declare Function SendMessageHM Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As String) As Int32

    'Dim hWnd1 As IntPtr = FindWindow("Notepad", "Untitled - Notepad")
    'Dim hWndR2 As IntPtr = GetWindow(hWnd1, GW_CHILD)




End Class
