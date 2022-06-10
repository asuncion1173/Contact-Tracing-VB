Public Class Form1
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim visitorFile As System.IO.StreamWriter
        Dim firstName As String = firstTxtBox.Text
        visitorFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\ASUNCION\Desktop\Visitor's Files\" + firstName + ".txt", True)
        visitorFile.WriteLine("First Name: " + firstTxtBox.Text)
        visitorFile.WriteLine("Middle Initial: " + midTxtBox.Text)
        visitorFile.WriteLine("Last Name: " + lastTxtBox.Text)
        visitorFile.WriteLine("Residence: " + residenceTxtBox.Text)
        visitorFile.WriteLine("Contact Number: " + contactTxtBox.Text)
        visitorFile.WriteLine("Gender: " + genderTxtBox.Text)
        visitorFile.WriteLine("Email: " + emailTxtBox.Text)
        visitorFile.WriteLine("Date of Visit: " + dateTxtBox.Text)
        visitorFile.Close()
        MessageBox.Show("Thank you for submitting! Stay safe and always wear your mask!")
        firstTxtBox.Text = ""
        midTxtBox.Text = ""
        lastTxtBox.Text = ""
        residenceTxtBox.Text = ""
        contactTxtBox.Text = ""
        genderTxtBox.Text = ""
        emailTxtBox.Text = ""
        dateTxtBox.Text = ""
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        firstTxtBox.Text = ""
        midTxtBox.Text = ""
        lastTxtBox.Text = ""
        residenceTxtBox.Text = ""
        contactTxtBox.Text = ""
        genderTxtBox.Text = ""
        emailTxtBox.Text = ""
        dateTxtBox.Text = ""
    End Sub
End Class
