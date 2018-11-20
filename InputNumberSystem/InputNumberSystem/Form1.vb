Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim round As Integer = CInt(TextBox1.Text)
        Dim mess As String = ""
        Dim num As Integer
        Dim sum As Integer = 0

        For x = 1 To round
            num = CInt(InputBox("ป้อนเลขตัวที่" & x, "SplitNumber"))
            sum += num
            mess += num.ToString & vbNewLine
        Next
        Label1.Text = sum
        Label2.Text = sum / round
        Label3.Text = mess

    End Sub
End Class
