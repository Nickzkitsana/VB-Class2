<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbStart = New System.Windows.Forms.TextBox()
        Me.tbEnd = New System.Windows.Forms.TextBox()
        Me.tbStep = New System.Windows.Forms.TextBox()
        Me.BtShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbStart
        '
        Me.tbStart.Location = New System.Drawing.Point(123, 46)
        Me.tbStart.Name = "tbStart"
        Me.tbStart.Size = New System.Drawing.Size(100, 20)
        Me.tbStart.TabIndex = 0
        '
        'tbEnd
        '
        Me.tbEnd.Location = New System.Drawing.Point(123, 97)
        Me.tbEnd.Name = "tbEnd"
        Me.tbEnd.Size = New System.Drawing.Size(100, 20)
        Me.tbEnd.TabIndex = 1
        '
        'tbStep
        '
        Me.tbStep.Location = New System.Drawing.Point(123, 149)
        Me.tbStep.Name = "tbStep"
        Me.tbStep.Size = New System.Drawing.Size(100, 20)
        Me.tbStep.TabIndex = 2
        '
        'BtShow
        '
        Me.BtShow.Location = New System.Drawing.Point(45, 205)
        Me.BtShow.Name = "BtShow"
        Me.BtShow.Size = New System.Drawing.Size(177, 54)
        Me.BtShow.TabIndex = 3
        Me.BtShow.Text = "  แสดงตัวเลข"
        Me.BtShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "เลขเริ่มต้น"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "เลขสิ้นสุด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ลำดับเพิ่ม / ลด"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 280)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtShow)
        Me.Controls.Add(Me.tbStep)
        Me.Controls.Add(Me.tbEnd)
        Me.Controls.Add(Me.tbStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbStart As TextBox
    Friend WithEvents tbEnd As TextBox
    Friend WithEvents tbStep As TextBox
    Friend WithEvents BtShow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
