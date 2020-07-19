Public Class Form1
    Dim Username As String
    Dim Password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาป้อนใส่รหัสผ่านของคุณ")
        If Username = "นุ๊กเน็ต" And Password = "1212" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-11\Pictures\All_Images/kid03.jpg")
        ElseIf Username = "วรรณวลี" And Password = "1313" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-11\Pictures\All_Images/99299328_3101185003280029_42355825011851264_o.jpg")
        ElseIf Username = "เดอะเกรท" And Password = "1414" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-11\Pictures\All_Images/100817709_3101185009946695_1273833475463446528_o.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
