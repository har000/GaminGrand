Public Class Form9
    Private Rating As Double
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox4.Checked = True And CheckBox1.Checked = True And CheckBox6.Checked = True And CheckBox2.Checked = True Then
            Rating = Rating + 1
        End If
        If Rating = 1 Then
            Stars = Stars + 1
        Else Stars = 0
        End If

        Me.Hide()
        Form10.Show()
    End Sub
End Class