Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Double = CDbl(TextBox1.Text)
        If score < 0 Or score > 100 Then
            MessageBox.Show("Score is out of range...", "Score",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        ElseIf score >= 80 Then
            Label1.Text = "Grade A"
        ElseIf score >= 70 Then
            Label1.Text = "Grade B"
        ElseIf score >= 60 Then
            Label1.Text = "Grade C"
        ElseIf score >= 50 Then
            Label1.Text = "Grade D"
        Else
            Label1.Text = "Grade F"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
