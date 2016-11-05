Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TotalPiezas As Integer
        Dim Importe As Decimal
        Dim Donuts, Magdalenas As Integer
        Donuts = CInt(TextBox1.Text)
        Magdalenas = CInt(TextBox2.Text)
        TotalPiezas = Donuts + Magdalenas
        Importe = Donuts * 3 + Magdalenas * 2
        Label7.Text = TotalPiezas
        Label8.Text = Importe
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label7.Text = ""
        Label8.Text = ""
    End Sub
End Class
