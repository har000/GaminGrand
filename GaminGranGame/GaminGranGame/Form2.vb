Public Class Form2
    Private Index As Long
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form7.Show()
        Me.Close()
        Timer1.Enabled = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As Long
        ReDim Preserve Jello(0 To 2)
        Do Until R = TotalIngridients
            Select Case Ingridients(R)
                Case "jello"
                    Index = R
                    Jello(0) = "jello"
                    Me.PictureBox1.Image = Image.FromFile(Images(Index))
                Case "hotwater"
                    Index = R
                    Jello(1) = "hotwater"
                    Me.PictureBox2.Image = Image.FromFile(Images(Index))
                Case "water"
                    Index = R
                    Jello(2) = "water"
                    Me.PictureBox4.Image = Image.FromFile(Images(Index))
            End Select
            R += 1
        Loop

    End Sub
End Class