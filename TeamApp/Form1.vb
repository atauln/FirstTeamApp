Public Class Form1

    Public Sub RefreshLabel()
        Label1.Text = NumInt
    End Sub
    'declare new variable (NumInt)
    Dim NumInt = 0
    'declare new variable (f)
    Dim f = 1
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

    Private Sub Mixed1_Click(sender As Object, e As EventArgs) Handles Mixed1.Click
        NumInt = NumInt * 2
        NumInt = NumInt - 3
        RefreshLabel()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Mixed2.Click
        NumInt = NumInt + 2
        NumInt = NumInt * 2
        NumInt = NumInt - 3
        RefreshLabel()
    End Sub

    Private Sub Clear_Btn_Click(sender As Object, e As EventArgs) Handles Clear_Btn.Click
        NumInt = 0
        RefreshLabel()
    End Sub

    Private Sub Mixed3_Click(sender As Object, e As EventArgs) Handles Mixed3.Click
        NumInt = NumInt / 3
        NumInt = NumInt + 2
        NumInt = NumInt * 2
        RefreshLabel()
    End Sub
    Private Sub MixedVis_Btn_Click(sender As Object, e As EventArgs) Handles MixedVis_Btn.Click
        If f = 0 Then
            f = 1
            Mixed1.Visible = False
            Mixed2.Visible = False
            Mixed3.Visible = False
            Mixed4.Visible = False
            Exit Sub
        End If
        If f = 1 Then
            f = 0
            Mixed1.Visible = True
            Mixed2.Visible = True
            Mixed3.Visible = True
            Mixed4.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Mixed4.Click
        NumInt = NumInt / 7
        NumInt = NumInt + 2
        NumInt = NumInt * 2
        NumInt = NumInt - 3
        RefreshLabel()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Square.Click
        NumInt = NumInt * NumInt
        RefreshLabel()
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles Button1.Click
        NumInt = NumInt * NumInt
        RefreshLabel()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        NumInt = NumInt / NumInt
        RefreshLabel()
    End Sub
End Class
