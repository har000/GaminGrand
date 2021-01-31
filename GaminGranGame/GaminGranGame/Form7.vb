Public Class Form7
    Private Rating As Long


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Rating = 0
        ' If RadioButton1.Text = "jello" Or RadioButton1.Text = "hotwater" Or RadioButton1.Text = "water" Then
        'Rating = Rating + 1
        'ElseIf RadioButton2.Text = "jello" Or RadioButton2.Text = "hotwater" Or RadioButton2.Text = "water" Then
        ' Rating = Rating + 1
        'ElseIf RadioButton3.Text = "jello" Or RadioButton3.Text = "hotwater" Or RadioButton3.Text = "water" Then
        'Rating = Rating + 1
        'ElseIf RadioButton4.Text = "jello" Or RadioButton4.Text = "hotwater" Or RadioButton4.Text = "water" Then
        'Rating = Rating + 1
        'ElseIf RadioButton5.Text = "jello" Or RadioButton5.Text = "hotwater" Or RadioButton5.Text = "water" Then
        'Rating = Rating + 1
        'ElseIf RadioButton6.Text = "jello" Or RadioButton6.Text = "hotwater" Or RadioButton6.Text = "water" Then
        'Rating = Rating + 1
        'End If
        If CheckBox4.Checked = True And CheckBox1.Checked = True And CheckBox6.Checked = True Then
            Rating = Rating + 1
        End If
        If Rating = 1 Then
            Stars = Stars + 1
        Else Stars = 0
        End If


        Form8.Show()
        Me.Close()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class