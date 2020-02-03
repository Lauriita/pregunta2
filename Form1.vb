Public Class Form1

    Dim a(4, 4) As Integer
    Dim i, j As Integer
    Dim random As New Random
    Dim suma As Integer = 0
    Dim cadena As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Randomize()
        For i = 0 To 3
            For j = 0 To 3
                a(i, j) = random.Next(0, 9)
                cadena = cadena & " " & a(i, j)
            Next
            cadena = cadena & vbNewLine
        Next
        j = 4

        For i = 0 To 3

            suma = suma + a(i, j)

            j = j - 1

        Next

        cadena = cadena & vbNewLine & suma
        TextBox1.Text = cadena

    End Sub
End Class
