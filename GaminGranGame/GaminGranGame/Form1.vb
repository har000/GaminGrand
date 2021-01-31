Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Stars < 3 Then
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
        If Stars < 6 And Stars >= 3 Then
            Button2.Enabled = True
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
        If Stars < 9 And Stars >= 6 Then
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = False
            Button5.Enabled = False
        End If

        If Stars < 12 And Stars >= 9 Then
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = False
        End If
        If Stars < 9 And Stars >= 6 Then
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
        End If

        FileOpen(1, "Images.txt", OpenMode.Input)
        Dim N As Long

        Do Until EOF(1)
            ReDim Preserve Images(0 To N)
            Input(1, Images(N))
            N += 1
        Loop
        TotalImages = N
        FileClose(1)

        FileOpen(2, "Ingredients.txt", OpenMode.Input)
        Dim R As Long

        Do Until EOF(2)
            ReDim Preserve Ingridients(0 To R)
            Input(2, Ingridients(R))
            R += 1
        Loop
        TotalIngridients = R
        FileClose(2)



    End Sub
End Class
