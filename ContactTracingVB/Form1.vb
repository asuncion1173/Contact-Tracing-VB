Public Class Form1
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim visitorFile As System.IO.StreamWriter

        visitorFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\ASUNCION\Desktop\Visitor's Files\Visitor.txt", True)
        visitorFile.WriteLine(firstTxtBox.Text)
    End Sub
End Class
