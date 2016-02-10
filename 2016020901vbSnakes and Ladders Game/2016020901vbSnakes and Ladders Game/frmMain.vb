Public Class frmMain
    Dim newPoint As Point
    Dim x As Integer
    Dim y As Integer
    Dim count As Integer = 0
    Dim u As Integer = 3
    Dim turn As Integer = 0

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDice.Click
        Dim Generator As System.Random = New System.Random()
        Dim dice As Integer = Generator.Next(1, 7)

        picDice.Image = Image.FromFile("dice\" + dice.ToString() + ".png")
        turn = count Mod u
        count += 1

        Select Case turn
            Case 0 : For i = 1 To dice
                    x = picPlayer1.Location.X
                    y = picPlayer1.Location.Y
                    If x < 412 And y = 340 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer1.Location = newPoint
                    ElseIf x = 412 And y = 340 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer1.Location = newPoint
                    ElseIf x > 12 And y = 260 Then
                        newPoint = New Point(x - 80, y)
                        picPlayer1.Location = newPoint
                    ElseIf x = 12 And y = 260 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer1.Location = newPoint
                    ElseIf x < 412 And y = 180 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer1.Location = newPoint
                    ElseIf x = 412 And y = 180 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer1.Location = newPoint
                    ElseIf x > 12 And y = 100 Then
                        newPoint = New Point(x - 80, y)
                        picPlayer1.Location = newPoint
                    ElseIf x = 12 And y = 100 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer1.Location = newPoint
                    ElseIf x < 412 And y = 20 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer1.Location = newPoint
                    ElseIf x >= 412 And y = 20 Then
                        For j = 1 To (dice - i)
                            x = picPlayer1.Location.X
                            y = picPlayer1.Location.Y
                            newPoint = New Point(x - 80, y)
                            picPlayer1.Location = newPoint
                            Delay(0.2)
                        Next
                        Exit For
                    End If
                    Delay(0.2)
                Next
            Case 1 : For i = 1 To dice
                    x = picPlayer2.Location.X
                    y = picPlayer2.Location.Y
                    If x < 412 And y = 350 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer2.Location = newPoint
                    ElseIf x = 412 And y = 350 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer2.Location = newPoint
                    ElseIf x > 12 And y = 270 Then
                        newPoint = New Point(x - 80, y)
                        picPlayer2.Location = newPoint
                    ElseIf x = 12 And y = 270 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer2.Location = newPoint
                    ElseIf x < 412 And y = 190 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer2.Location = newPoint
                    ElseIf x = 412 And y = 190 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer2.Location = newPoint
                    ElseIf x > 12 And y = 110 Then
                        newPoint = New Point(x - 80, y)
                        picPlayer2.Location = newPoint
                    ElseIf x = 12 And y = 110 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer2.Location = newPoint
                    ElseIf x < 412 And y = 30 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer2.Location = newPoint
                    ElseIf x >= 412 And y = 30 Then
                        For j = 0 To (dice - i)
                            x = picPlayer2.Location.X
                            y = picPlayer2.Location.Y
                            newPoint = New Point(x - 80, y)
                            picPlayer2.Location = newPoint
                            Delay(0.2)
                        Next
                        Exit For
                    End If
                    Delay(0.2)
                Next
            Case 2 : For i = 1 To dice
                    x = picPlayer3.Location.X
                    y = picPlayer3.Location.Y
                    If x < 412 And y = 360 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer3.Location = newPoint
                    ElseIf x = 412 And y = 360 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer3.Location = newPoint
                    ElseIf x > 12 And y = 280 Then
                        newPoint = New Point(x - 80, y)
                        picPlayer3.Location = newPoint
                    ElseIf x = 12 And y = 280 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer3.Location = newPoint
                    ElseIf x < 412 And y = 200 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer3.Location = newPoint
                    ElseIf x = 412 And y = 200 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer3.Location = newPoint
                    ElseIf x > 12 And y = 120 Then
                        newPoint = New Point(x - 80, y)
                        picPlayer3.Location = newPoint
                    ElseIf x = 12 And y = 120 Then
                        newPoint = New Point(x, y - 80)
                        picPlayer3.Location = newPoint
                    ElseIf x < 412 And y = 40 Then
                        newPoint = New Point(x + 80, y)
                        picPlayer3.Location = newPoint
                    ElseIf x >= 412 And y = 40 Then
                        For j = 0 To (dice - i)
                            x = picPlayer3.Location.X
                            y = picPlayer3.Location.Y
                            newPoint = New Point(x - 80, y)
                            picPlayer3.Location = newPoint
                            Delay(0.2)
                        Next
                        Exit For
                    End If
                    Delay(0.2)
                Next
        End Select

        If picPlayer1.Location.X = 172 And picPlayer1.Location.Y = 340 Then
            newPoint = New Point(172, 100)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 332 And picPlayer1.Location.Y = 340 Then
            newPoint = New Point(332, 260)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 92 And picPlayer1.Location.Y = 260 Then
            newPoint = New Point(92, 20)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 332 And picPlayer1.Location.Y = 180 Then
            newPoint = New Point(252, 340)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 412 And picPlayer1.Location.Y = 100 Then
            newPoint = New Point(412, 260)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 332 And picPlayer1.Location.Y = 100 Then
            newPoint = New Point(332, 20)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 252 And picPlayer1.Location.Y = 100 Then
            newPoint = New Point(252, 260)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 172 And picPlayer1.Location.Y = 20 Then
            newPoint = New Point(12, 340)
            picPlayer1.Location = newPoint
        ElseIf picPlayer1.Location.X = 412 And picPlayer1.Location.Y = 20 Then
            MessageBox.Show("Player 1 win.")
        End If

        If picPlayer2.Location.X = 172 And picPlayer2.Location.Y = 350 Then
            newPoint = New Point(172, 110)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 332 And picPlayer2.Location.Y = 350 Then
            newPoint = New Point(332, 270)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 92 And picPlayer2.Location.Y = 270 Then
            newPoint = New Point(92, 30)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 332 And picPlayer2.Location.Y = 190 Then
            newPoint = New Point(252, 350)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 412 And picPlayer2.Location.Y = 110 Then
            newPoint = New Point(412, 270)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 332 And picPlayer2.Location.Y = 110 Then
            newPoint = New Point(332, 30)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 252 And picPlayer2.Location.Y = 110 Then
            newPoint = New Point(252, 270)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 172 And picPlayer2.Location.Y = 30 Then
            newPoint = New Point(12, 350)
            picPlayer2.Location = newPoint
        ElseIf picPlayer2.Location.X = 412 And picPlayer2.Location.Y = 30 Then
            MessageBox.Show("Player 2 win.")
        End If

        If picPlayer3.Location.X = 172 And picPlayer3.Location.Y = 360 Then
            newPoint = New Point(172, 120)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 332 And picPlayer3.Location.Y = 360 Then
            newPoint = New Point(332, 280)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 92 And picPlayer3.Location.Y = 280 Then
            newPoint = New Point(92, 40)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 332 And picPlayer3.Location.Y = 200 Then
            newPoint = New Point(252, 360)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 412 And picPlayer3.Location.Y = 120 Then
            newPoint = New Point(412, 280)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 332 And picPlayer3.Location.Y = 120 Then
            newPoint = New Point(332, 40)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 252 And picPlayer3.Location.Y = 120 Then
            newPoint = New Point(252, 280)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 172 And picPlayer3.Location.Y = 40 Then
            newPoint = New Point(12, 360)
            picPlayer3.Location = newPoint
        ElseIf picPlayer3.Location.X = 412 And picPlayer3.Location.Y = 40 Then
            MessageBox.Show("Player 3 win.")
        End If

        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        x = picPlayer1.Location.X
        y = picPlayer1.Location.Y
        newPoint = New Point(12, 340)
        picPlayer1.Location = newPoint

        Dim x2 As Integer = picPlayer2.Location.X
        Dim y2 As Integer = picPlayer2.Location.Y
        newPoint = New Point(12, 350)
        picPlayer2.Location = newPoint

        Dim x3 As Integer = picPlayer3.Location.X
        Dim y3 As Integer = picPlayer3.Location.Y
        newPoint = New Point(12, 360)
        picPlayer3.Location = newPoint

        turn = 0
        count = 0

    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        Me.Hide()
        frmSetting.Show()

    End Sub


    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

        Else
            e.Cancel = True
        End If

    End Sub
End Class
