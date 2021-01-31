Public Class Form3
    Private Index As Double
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form9.Show()
        Me.Hide()
        Timer1.Enabled = False

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As Long
        ReDim Preserve Stew(0 To 3)
        Do Until R = TotalIngridients
            Select Case Ingridients(R)
                Case "carrot"
                    Index = R
                    Stew(0) = "carrot"
                    Me.PictureBox1.Image = Image.FromFile(Images(Index))
                Case "hotwater"
                    Index = R
                    Stew(1) = "hotwater"
                    Me.PictureBox2.Image = Image.FromFile(Images(Index))
                Case "wine"
                    Index = R
                    Stew(2) = "wine"
                    Me.PictureBox4.Image = Image.FromFile(Images(Index))
                Case "meat"
                    Index = R
                    Stew(3) = "meat"
                    Me.PictureBox3.Image = Image.FromFile(Images(Index))

            End Select
            R += 1
        Loop
    End Sub
End Class