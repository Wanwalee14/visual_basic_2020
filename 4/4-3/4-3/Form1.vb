Public Class Form1
    Dim Num1, Num2, Result As Double
    Dim Result1 As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Result = Num1 * Num2
        Result1 = Result / 50
        Label5.Text = Result
        Label6.Text = Result1
    End Sub
End Class
