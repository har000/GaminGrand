Public Class Form6
    Private Index As Double
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form7.Show()
        Me.Hide()
        Timer1.Enabled = False

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As Long
        ReDim Preserve Lasagna(0 To 6)
        Do Until R = TotalIngridients
            Select Case Ingridients(R)
                Case "sauce"
                    Index = R
                    Lasagna(0) = "sauce"
                    Me.PictureBox1.Image = Image.FromFile(Images(Index))
                Case "pasta"
                    Index = R
                    Lasagna(1) = "pasta"
                    Me.PictureBox2.Image = Image.FromFile(Images(Index))
                Case "garlic"
                    Index = R
                    Lasagna(2) = "garlic"
                    Me.PictureBox4.Image = Image.FromFile(Images(Index))
                Case "hotwater"
                    Index = R
                    Lasagna(3) = "hotwater"
                    Me.PictureBox3.Image = Image.FromFile(Images(Index))
                Case "cheese"
                    Index = R
                    Lasagna(4) = "cheese"
                    Me.PictureBox5.Image = Image.FromFile(Images(Index))
                Case "spinach"
                    Index = R
                    Lasagna(5) = "spinach"
                    Me.PictureBox6.Image = Image.FromFile(Images(Index))
                Case "meat"
                    Index = R
                    Lasagna(6) = "meat"
                    Me.PictureBox7.Image = Image.FromFile(Images(Index))
            End Select
            R += 1
        Loop
    End Sub
End Class