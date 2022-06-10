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
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.firstTxtBox = New System.Windows.Forms.TextBox()
        Me.lastTxtBox = New System.Windows.Forms.TextBox()
        Me.contactTxtBox = New System.Windows.Forms.TextBox()
        Me.residenceTxtBox = New System.Windows.Forms.TextBox()
        Me.dateTxtBox = New System.Windows.Forms.TextBox()
        Me.emailTxtBox = New System.Windows.Forms.TextBox()
        Me.genderTxtBox = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.Label()
        Me.midTxtBox = New System.Windows.Forms.TextBox()
        Me.middleName = New System.Windows.Forms.Label()
        Me.residence = New System.Windows.Forms.Label()
        Me.contactNumber = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.dateOfVisit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(389, 282)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(75, 23)
        Me.submitBtn.TabIndex = 0
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'firstTxtBox
        '
        Me.firstTxtBox.Location = New System.Drawing.Point(49, 52)
        Me.firstTxtBox.Name = "firstTxtBox"
        Me.firstTxtBox.Size = New System.Drawing.Size(177, 20)
        Me.firstTxtBox.TabIndex = 1
        '
        'lastTxtBox
        '
        Me.lastTxtBox.Location = New System.Drawing.Point(287, 52)
        Me.lastTxtBox.Name = "lastTxtBox"
        Me.lastTxtBox.Size = New System.Drawing.Size(177, 20)
        Me.lastTxtBox.TabIndex = 2
        '
        'contactTxtBox
        '
        Me.contactTxtBox.Location = New System.Drawing.Point(49, 144)
        Me.contactTxtBox.Name = "contactTxtBox"
        Me.contactTxtBox.Size = New System.Drawing.Size(137, 20)
        Me.contactTxtBox.TabIndex = 3
        '
        'residenceTxtBox
        '
        Me.residenceTxtBox.Location = New System.Drawing.Point(49, 102)
        Me.residenceTxtBox.Name = "residenceTxtBox"
        Me.residenceTxtBox.Size = New System.Drawing.Size(415, 20)
        Me.residenceTxtBox.TabIndex = 4
        '
        'dateTxtBox
        '
        Me.dateTxtBox.Location = New System.Drawing.Point(49, 238)
        Me.dateTxtBox.Name = "dateTxtBox"
        Me.dateTxtBox.Size = New System.Drawing.Size(113, 20)
        Me.dateTxtBox.TabIndex = 5
        '
        'emailTxtBox
        '
        Me.emailTxtBox.Location = New System.Drawing.Point(49, 191)
        Me.emailTxtBox.Name = "emailTxtBox"
        Me.emailTxtBox.Size = New System.Drawing.Size(229, 20)
        Me.emailTxtBox.TabIndex = 6
        '
        'genderTxtBox
        '
        Me.genderTxtBox.Location = New System.Drawing.Point(213, 144)
        Me.genderTxtBox.Name = "genderTxtBox"
        Me.genderTxtBox.Size = New System.Drawing.Size(65, 20)
        Me.genderTxtBox.TabIndex = 7
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Location = New System.Drawing.Point(46, 36)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(57, 13)
        Me.firstName.TabIndex = 8
        Me.firstName.Text = "First Name"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Location = New System.Drawing.Point(284, 36)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(58, 13)
        Me.lastName.TabIndex = 9
        Me.lastName.Text = "Last Name"
        '
        'midTxtBox
        '
        Me.midTxtBox.Location = New System.Drawing.Point(242, 52)
        Me.midTxtBox.Name = "midTxtBox"
        Me.midTxtBox.Size = New System.Drawing.Size(30, 20)
        Me.midTxtBox.TabIndex = 10
        '
        'middleName
        '
        Me.middleName.AutoSize = True
        Me.middleName.Location = New System.Drawing.Point(239, 36)
        Me.middleName.Name = "middleName"
        Me.middleName.Size = New System.Drawing.Size(25, 13)
        Me.middleName.TabIndex = 11
        Me.middleName.Text = "M.I."
        '
        'residence
        '
        Me.residence.AutoSize = True
        Me.residence.Location = New System.Drawing.Point(46, 86)
        Me.residence.Name = "residence"
        Me.residence.Size = New System.Drawing.Size(58, 13)
        Me.residence.TabIndex = 12
        Me.residence.Text = "Residence"
        '
        'contactNumber
        '
        Me.contactNumber.AutoSize = True
        Me.contactNumber.Location = New System.Drawing.Point(46, 128)
        Me.contactNumber.Name = "contactNumber"
        Me.contactNumber.Size = New System.Drawing.Size(84, 13)
        Me.contactNumber.TabIndex = 13
        Me.contactNumber.Text = "Contact Number"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Location = New System.Drawing.Point(210, 128)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(42, 13)
        Me.gender.TabIndex = 14
        Me.gender.Text = "Gender"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(46, 175)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(32, 13)
        Me.email.TabIndex = 15
        Me.email.Text = "Email"
        '
        'dateOfVisit
        '
        Me.dateOfVisit.AutoSize = True
        Me.dateOfVisit.Location = New System.Drawing.Point(46, 222)
        Me.dateOfVisit.Name = "dateOfVisit"
        Me.dateOfVisit.Size = New System.Drawing.Size(64, 13)
        Me.dateOfVisit.TabIndex = 16
        Me.dateOfVisit.Text = "Date of Visit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 364)
        Me.Controls.Add(Me.dateOfVisit)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.contactNumber)
        Me.Controls.Add(Me.residence)
        Me.Controls.Add(Me.middleName)
        Me.Controls.Add(Me.midTxtBox)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.genderTxtBox)
        Me.Controls.Add(Me.emailTxtBox)
        Me.Controls.Add(Me.dateTxtBox)
        Me.Controls.Add(Me.residenceTxtBox)
        Me.Controls.Add(Me.contactTxtBox)
        Me.Controls.Add(Me.lastTxtBox)
        Me.Controls.Add(Me.firstTxtBox)
        Me.Controls.Add(Me.submitBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitBtn As Button
    Friend WithEvents firstTxtBox As TextBox
    Friend WithEvents lastTxtBox As TextBox
    Friend WithEvents contactTxtBox As TextBox
    Friend WithEvents residenceTxtBox As TextBox
    Friend WithEvents dateTxtBox As TextBox
    Friend WithEvents emailTxtBox As TextBox
    Friend WithEvents genderTxtBox As TextBox
    Friend WithEvents firstName As Label
    Friend WithEvents lastName As Label
    Friend WithEvents midTxtBox As TextBox
    Friend WithEvents middleName As Label
    Friend WithEvents residence As Label
    Friend WithEvents contactNumber As Label
    Friend WithEvents gender As Label
    Friend WithEvents email As Label
    Friend WithEvents dateOfVisit As Label
End Class
