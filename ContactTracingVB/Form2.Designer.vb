<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.scanBtn = New System.Windows.Forms.Button()
        Me.qrPictureBox = New System.Windows.Forms.PictureBox()
        Me.TitleForm2 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.qrPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scanBtn
        '
        Me.scanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.scanBtn.Font = New System.Drawing.Font("BankGothic Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanBtn.ForeColor = System.Drawing.Color.White
        Me.scanBtn.Location = New System.Drawing.Point(226, 450)
        Me.scanBtn.Name = "scanBtn"
        Me.scanBtn.Size = New System.Drawing.Size(105, 41)
        Me.scanBtn.TabIndex = 0
        Me.scanBtn.Text = "Scan QR"
        Me.scanBtn.UseVisualStyleBackColor = True
        '
        'qrPictureBox
        '
        Me.qrPictureBox.Location = New System.Drawing.Point(12, 103)
        Me.qrPictureBox.Name = "qrPictureBox"
        Me.qrPictureBox.Size = New System.Drawing.Size(529, 338)
        Me.qrPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.qrPictureBox.TabIndex = 1
        Me.qrPictureBox.TabStop = False
        '
        'TitleForm2
        '
        Me.TitleForm2.AutoSize = True
        Me.TitleForm2.Font = New System.Drawing.Font("BankGothic Md BT", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleForm2.ForeColor = System.Drawing.Color.White
        Me.TitleForm2.Location = New System.Drawing.Point(268, 16)
        Me.TitleForm2.Name = "TitleForm2"
        Me.TitleForm2.Size = New System.Drawing.Size(228, 72)
        Me.TitleForm2.TabIndex = 2
        Me.TitleForm2.Text = "Stay Safe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "QR Reader"
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Std Book", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(153, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Be Strong " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and eat your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vegetables, kids"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(553, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TitleForm2)
        Me.Controls.Add(Me.qrPictureBox)
        Me.Controls.Add(Me.scanBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR Scanner"
        CType(Me.qrPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scanBtn As Button
    Friend WithEvents qrPictureBox As PictureBox
    Friend WithEvents TitleForm2 As Label
    Friend WithEvents timer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
