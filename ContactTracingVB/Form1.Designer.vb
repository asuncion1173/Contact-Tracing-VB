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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.titleName = New System.Windows.Forms.Label()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'submitBtn
        '
        Me.submitBtn.Font = New System.Drawing.Font("BankGothic Lt BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitBtn.Location = New System.Drawing.Point(382, 295)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(98, 24)
        Me.submitBtn.TabIndex = 9
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'firstTxtBox
        '
        Me.firstTxtBox.Location = New System.Drawing.Point(33, 82)
        Me.firstTxtBox.Name = "firstTxtBox"
        Me.firstTxtBox.Size = New System.Drawing.Size(190, 19)
        Me.firstTxtBox.TabIndex = 1
        '
        'lastTxtBox
        '
        Me.lastTxtBox.Location = New System.Drawing.Point(281, 82)
        Me.lastTxtBox.Name = "lastTxtBox"
        Me.lastTxtBox.Size = New System.Drawing.Size(199, 19)
        Me.lastTxtBox.TabIndex = 3
        '
        'contactTxtBox
        '
        Me.contactTxtBox.Location = New System.Drawing.Point(33, 167)
        Me.contactTxtBox.Name = "contactTxtBox"
        Me.contactTxtBox.Size = New System.Drawing.Size(143, 19)
        Me.contactTxtBox.TabIndex = 5
        '
        'residenceTxtBox
        '
        Me.residenceTxtBox.Location = New System.Drawing.Point(33, 128)
        Me.residenceTxtBox.Name = "residenceTxtBox"
        Me.residenceTxtBox.Size = New System.Drawing.Size(447, 19)
        Me.residenceTxtBox.TabIndex = 4
        '
        'dateTxtBox
        '
        Me.dateTxtBox.Location = New System.Drawing.Point(33, 254)
        Me.dateTxtBox.Name = "dateTxtBox"
        Me.dateTxtBox.Size = New System.Drawing.Size(115, 19)
        Me.dateTxtBox.TabIndex = 8
        '
        'emailTxtBox
        '
        Me.emailTxtBox.Location = New System.Drawing.Point(33, 210)
        Me.emailTxtBox.Name = "emailTxtBox"
        Me.emailTxtBox.Size = New System.Drawing.Size(250, 19)
        Me.emailTxtBox.TabIndex = 7
        '
        'genderTxtBox
        '
        Me.genderTxtBox.Location = New System.Drawing.Point(224, 167)
        Me.genderTxtBox.Name = "genderTxtBox"
        Me.genderTxtBox.Size = New System.Drawing.Size(59, 19)
        Me.genderTxtBox.TabIndex = 6
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(29, 67)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(89, 14)
        Me.firstName.TabIndex = 8
        Me.firstName.Text = "First Name"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(281, 67)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(85, 14)
        Me.lastName.TabIndex = 9
        Me.lastName.Text = "Last Name"
        '
        'midTxtBox
        '
        Me.midTxtBox.Location = New System.Drawing.Point(242, 82)
        Me.midTxtBox.Name = "midTxtBox"
        Me.midTxtBox.Size = New System.Drawing.Size(25, 19)
        Me.midTxtBox.TabIndex = 2
        '
        'middleName
        '
        Me.middleName.AutoSize = True
        Me.middleName.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middleName.Location = New System.Drawing.Point(240, 67)
        Me.middleName.Name = "middleName"
        Me.middleName.Size = New System.Drawing.Size(35, 14)
        Me.middleName.TabIndex = 11
        Me.middleName.Text = "M.I."
        '
        'residence
        '
        Me.residence.AutoSize = True
        Me.residence.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residence.Location = New System.Drawing.Point(29, 114)
        Me.residence.Name = "residence"
        Me.residence.Size = New System.Drawing.Size(84, 14)
        Me.residence.TabIndex = 12
        Me.residence.Text = "Residence"
        '
        'contactNumber
        '
        Me.contactNumber.AutoSize = True
        Me.contactNumber.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNumber.Location = New System.Drawing.Point(29, 152)
        Me.contactNumber.Name = "contactNumber"
        Me.contactNumber.Size = New System.Drawing.Size(132, 14)
        Me.contactNumber.TabIndex = 13
        Me.contactNumber.Text = "Contact Number"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(221, 152)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(63, 14)
        Me.gender.TabIndex = 14
        Me.gender.Text = "Gender"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(29, 195)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(47, 14)
        Me.email.TabIndex = 15
        Me.email.Text = "Email"
        '
        'dateOfVisit
        '
        Me.dateOfVisit.AutoSize = True
        Me.dateOfVisit.Font = New System.Drawing.Font("BankGothic Lt BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateOfVisit.Location = New System.Drawing.Point(29, 239)
        Me.dateOfVisit.Name = "dateOfVisit"
        Me.dateOfVisit.Size = New System.Drawing.Size(104, 14)
        Me.dateOfVisit.TabIndex = 16
        Me.dateOfVisit.Text = "Date of Visit"
        '
        'titleName
        '
        Me.titleName.AutoSize = True
        Me.titleName.Font = New System.Drawing.Font("BankGothic Md BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleName.ForeColor = System.Drawing.Color.White
        Me.titleName.Location = New System.Drawing.Point(158, 26)
        Me.titleName.Name = "titleName"
        Me.titleName.Size = New System.Drawing.Size(205, 25)
        Me.titleName.TabIndex = 17
        Me.titleName.Text = "Stay Safe App"
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("BankGothic Lt BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(278, 295)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(85, 24)
        Me.clearBtn.TabIndex = 18
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(514, 345)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.titleName)
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
        Me.Font = New System.Drawing.Font("BankGothic Lt BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stay Safe"
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
    Friend WithEvents titleName As Label
    Friend WithEvents clearBtn As Button
End Class
