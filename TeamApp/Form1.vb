Public Class Form1

    Public Sub RefreshLabel()
        Label1.Text = NumInt
    End Sub
    Dim NumInt = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add1.Click
        NumInt = NumInt + 1
        RefreshLabel()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Minus1.Click
        NumInt = NumInt - 1
        RefreshLabel()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Multiply2.Click
        NumInt = NumInt * 2
        RefreshLabel()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Divide2.Click
        NumInt = NumInt / 2
        RefreshLabel()
    End Sub



End Class
