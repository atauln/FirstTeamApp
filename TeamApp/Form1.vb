Public Class Form1
    Public Sub RefreshLabel()
        Label1.Text = NumInt
    End Sub
    Dim NumInt = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NumInt = NumInt + 1
        RefreshLabel()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumInt = NumInt - 1
        RefreshLabel()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NumInt = NumInt * 2
        RefreshLabel()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NumInt = NumInt / 2
        RefreshLabel()
    End Sub
    'Sami









    ' Ends Here
    'Ata










    'Ends Here
    'Kelton














    'Ends Here
End Class
