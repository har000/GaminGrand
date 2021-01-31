Public Class Form5
    Private Index As Double
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form7.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As Long
        ReDim Preserve Sandwich(0 To 5)
        Do Until R = TotalIngridients
            Select Case Ingridients(R)
                Case "lettuce"
                    Index = R
                    Sandwich(0) = "lettuce"
                    Me.PictureBox1.Image = Image.FromFile(Images(Index))
                Case "tomato"
                    Index = R
                    Sandwich(1) = "tomato"
                    Me.PictureBox2.Image = Image.FromFile(Images(Index))
                Case "mayo"
                    Index = R
                    Sandwich(2) = "mayo"
                    Me.PictureBox4.Image = Image.FromFile(Images(Index))
                Case "bread"
                    Index = R
                    Sandwich(3) = "bread"
                    Me.PictureBox3.Image = Image.FromFile(Images(Index))
                Case "cheese"
                    Index = R
                    Sandwich(4) = "cheese"
                    Me.PictureBox5.Image = Image.FromFile(Images(Index))
                Case "ham"
                    Index = R
                    Sandwich(5) = "ham"
                    Me.PictureBox6.Image = Image.FromFile(Images(Index))
            End Select
            R += 1
        Loop
    End Sub
End Class