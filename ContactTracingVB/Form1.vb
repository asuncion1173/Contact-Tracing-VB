Public Class Form1
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim visitorFile As System.IO.StreamWriter

        visitorFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\ASUNCION\Desktop\Visitor's Files\Visitor.txt", True)
        visitorFile.WriteLine(firstTxtBox.Text)
        visitorFile.WriteLine(midTxtBox.Text)
        visitorFile.WriteLine(lastTxtBox.Text)
        visitorFile.WriteLine(residenceTxtBox.Text)
        visitorFile.WriteLine(contactTxtBox.Text)
        visitorFile.WriteLine(genderTxtBox.Text)
        visitorFile.WriteLine(emailTxtBox.Text)
        visitorFile.WriteLine(dateTxtBox.Text)
        visitorFile.Close()
        MessageBox.Show("Thank you for submitting! Stay safe and always wear your mask!")
    End Sub
End Class
