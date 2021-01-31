Public Class Form4
    Private Index As Long
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form11.Show()
        Me.Hide()
        Timer1.Enabled = False

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As Long
        ReDim Preserve Cookies(0 To 4)
        Do Until R = TotalIngridients
            Select Case Ingridients(R)
                Case "flour"
                    Index = R
                    Cookies(0) = "flour"
                    Me.PictureBox1.Image = Image.FromFile(Images(Index))
                Case "chocochips"
                    Cookies(1) = "chocochips"
                    Index = R
                    Me.PictureBox2.Image = Image.FromFile(Images(Index))
                Case "eggs"
                    Index = R
                    Cookies(2) = "eggs"
                    Me.PictureBox4.Image = Image.FromFile(Images(Index))
                Case "Sugar"
                    Index = R
                    Cookies(3) = "sugar"
                    Me.PictureBox3.Image = Image.FromFile(Images(Index))
                Case "butter"
                    Index = R
                    Cookies(4) = "butter"
                    Me.PictureBox5.Image = Image.FromFile(Images(Index))
            End Select
            R += 1
        Loop
    End Sub

End Class