Public Class Form1
    Public Property fromQR As String
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim visitorFile As System.IO.StreamWriter
        Dim firstName As String = firstTxtBox.Text
        If System.IO.File.Exists("C:\Users\ASUNCION\Desktop\Visitor's Files\" + firstName + ".txt") Then
            System.IO.File.Delete("C:\Users\ASUNCION\Desktop\Visitor's Files\" + firstName + ".txt")
        End If
        visitorFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\ASUNCION\Desktop\Visitor's Files\" + firstName + ".txt", True)
        visitorFile.WriteLine("First Name: " + firstTxtBox.Text)
        visitorFile.WriteLine("Middle Initial: " + midTxtBox.Text)
        visitorFile.WriteLine("Last Name: " + lastTxtBox.Text)
        visitorFile.WriteLine("Residence: " + residenceTxtBox.Text)
        visitorFile.WriteLine("Contact Number: " + contactTxtBox.Text)
        visitorFile.WriteLine("Gender: " + genderTxtBox.Text)
        visitorFile.WriteLine("Email: " + emailTxtBox.Text)
        visitorFile.WriteLine("Date of Visit: " + dateTxtBox.Text)
        visitorFile.WriteLine("Positive in Symptoms: " + symptomsTxtBox.Text)
        visitorFile.WriteLine("Has travelled: " + travelTxtBox.Text)
        visitorFile.WriteLine("Close Contact: " + closeContactTxtBox.Text)
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
        symptomsTxtBox.Text = ""
        travelTxtBox.Text = ""
        closeContactTxtBox.Text = ""
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
        symptomsTxtBox.Text = ""
        travelTxtBox.Text = ""
        closeContactTxtBox.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim infoQR As String() = fromQR.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        firstTxtBox.Text = infoQR(0)
        midTxtBox.Text = infoQR(1)
        lastTxtBox.Text = infoQR(2)
        residenceTxtBox.Text = infoQR(3)
        contactTxtBox.Text = infoQR(4)
        genderTxtBox.Text = infoQR(5)
        emailTxtBox.Text = infoQR(6)
        dateTxtBox.Text = infoQR(7)
        symptomsTxtBox.Text = infoQR(8)
        travelTxtBox.Text = infoQR(9)
        closeContactTxtBox.Text = infoQR(10)
    End Sub
End Class
