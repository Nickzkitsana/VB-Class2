Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtShow.Click
        Dim first As Integer = CInt(tbStart.Text)
        Dim last As Integer = CInt(tbEnd.Text)
        Dim steps As Integer = CInt(tbStep.Text)

        Dim message As String = ""

        If steps > 0 Then
            If first < last Then
                For x = first To last Step steps
                    message += x & vbNewLine
                Next
            Else
                MessageBox.Show("เลขเริ่มต้น ต้องน้อยกว่า เลขสิ้นสุด เท่านั้น !!!")
            End If
        End If
        If steps < 0 Then
            If first > last Then
                For x = first To last Step steps
                    message -= x & vbNewLine
                Next
            Else
                MessageBox.Show("เลขเริ่มต้น ต้องมากกว่า เลขสิ้นสุด เท่านั้น !!!")
            End If
        End If

    End Sub

    Private Sub tbStart_TextChanged(sender As Object, e As EventArgs) Handles tbStart.TextChanged

    End Sub

    Private Sub tbEnd_TextChanged(sender As Object, e As EventArgs) Handles tbEnd.TextChanged

    End Sub

    Private Sub tbStep_TextChanged(sender As Object, e As EventArgs) Handles tbStep.TextChanged

    End Sub
End Class
