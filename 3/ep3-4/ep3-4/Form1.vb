Public Class Form1
    Dim Num1, Num2, Num11, Result, Result1 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        Num11 = TextBox4.Text
        Result = Num1 * Num2
        Result1 = Num11 - Result
        TextBox3.Text = Result
        TextBox5.Text = Result1

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
