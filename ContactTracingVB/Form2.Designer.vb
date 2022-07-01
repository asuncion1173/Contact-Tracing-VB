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
        Me.scanBtn = New System.Windows.Forms.Button()
        Me.qrPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.qrPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scanBtn
        '
        Me.scanBtn.Location = New System.Drawing.Point(223, 424)
        Me.scanBtn.Name = "scanBtn"
        Me.scanBtn.Size = New System.Drawing.Size(105, 41)
        Me.scanBtn.TabIndex = 0
        Me.scanBtn.Text = "Scan QR"
        Me.scanBtn.UseVisualStyleBackColor = True
        '
        'qrPictureBox
        '
        Me.qrPictureBox.Location = New System.Drawing.Point(21, 60)
        Me.qrPictureBox.Name = "qrPictureBox"
        Me.qrPictureBox.Size = New System.Drawing.Size(520, 338)
        Me.qrPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.qrPictureBox.TabIndex = 1
        Me.qrPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "QR Reader"
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(553, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.qrPictureBox)
        Me.Controls.Add(Me.scanBtn)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.qrPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scanBtn As Button
    Friend WithEvents qrPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents timer As Timer
End Class
