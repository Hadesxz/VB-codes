Public Class Form1
    Dim newPoint As Point
    Dim x As Integer
    Dim y As Integer

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDice.Click
        Dim Generator As System.Random = New System.Random()
        Dim dice As Integer = Generator.Next(1, 7)

        picDice.Image = Image.FromFile("dice\" + dice.ToString() + ".png")
        For i = 1 To dice
            x = picPlayer.Location.X
            y = picPlayer.Location.Y
            If x < 412 And y = 340 Then
                newPoint = New Point(x + 80, y)
                picPlayer.Location = newPoint
            ElseIf x = 412 And y = 340 Then
                newPoint = New Point(x, y - 80)
                picPlayer.Location = newPoint
            ElseIf x > 12 And y = 260 Then
                newPoint = New Point(x - 80, y)
                picPlayer.Location = newPoint
            ElseIf x = 12 And y = 260 Then
                newPoint = New Point(x, y - 80)
                picPlayer.Location = newPoint
            ElseIf x < 412 And y = 180 Then
                newPoint = New Point(x + 80, y)
                picPlayer.Location = newPoint
            ElseIf x = 412 And y = 180 Then
                newPoint = New Point(x, y - 80)
                picPlayer.Location = newPoint
            ElseIf x > 12 And y = 100 Then
                newPoint = New Point(x - 80, y)
                picPlayer.Location = newPoint
            ElseIf x = 12 And y = 100 Then
                newPoint = New Point(x, y - 80)
                picPlayer.Location = newPoint
            ElseIf x < 412 And y = 20 Then
                newPoint = New Point(x + 80, y)
                picPlayer.Location = newPoint
            End If
            Delay(0.2)
        Next
        If picPlayer.Location.X = 172 And picPlayer.Location.Y = 340 Then
            newPoint = New Point(172, 100)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 332 And picPlayer.Location.Y = 340 Then
            newPoint = New Point(332, 260)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 92 And picPlayer.Location.Y = 260 Then
            newPoint = New Point(92, 20)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 332 And picPlayer.Location.Y = 180 Then
            newPoint = New Point(252, 340)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 412 And picPlayer.Location.Y = 100 Then
            newPoint = New Point(412, 260)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 332 And picPlayer.Location.Y = 100 Then
            newPoint = New Point(332, 20)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 252 And picPlayer.Location.Y = 100 Then
            newPoint = New Point(252, 260)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 172 And picPlayer.Location.Y = 20 Then
            newPoint = New Point(12, 340)
            picPlayer.Location = newPoint
        ElseIf picPlayer.Location.X = 412 And picPlayer.Location.Y = 20 Then
            MessageBox.Show("You Win.")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        x = picPlayer.Location.X
        y = picPlayer.Location.Y
        newPoint = New Point(12, 340)
        picPlayer.Location = newPoint
    End Sub
End Class
