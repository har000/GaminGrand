Public Class Form8


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Form1.Show()
        Me.Close()
        Timer1.Enabled = False

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Stars Mod 3 = 0 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True

        ElseIf Stars Mod 3 = 2 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False

        ElseIf Stars Mod 3 = 1 Then
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = False
        End If
    End Sub
End Class