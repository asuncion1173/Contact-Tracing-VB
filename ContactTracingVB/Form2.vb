Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec

Public Class Form2
    Dim cameraDisplay As VideoCaptureDevice
    Dim bitQR As Bitmap
    Private Sub scanBtn_Click(sender As Object, e As EventArgs) Handles scanBtn.Click
        Dim cameraDisplayQR As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameraDisplayQR.ShowDialog() = DialogResult.OK Then
            cameraDisplay = cameraDisplayQR.VideoDevice
            AddHandler cameraDisplay.NewFrame, New NewFrameEventHandler(AddressOf qrCapture)
            cameraDisplay.Start()
            timer.Start()
        End If
    End Sub

    Private Sub qrCapture(sender As Object, eventArgs As NewFrameEventArgs)
        bitQR = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        qrPictureBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If qrPictureBox.Image IsNot Nothing Then
            Dim reader As BarcodeReader = New BarcodeReader
            Dim result As Result = reader.Decode(DirectCast(qrPictureBox.Image, Bitmap))
            If result IsNot Nothing Then
                Dim form1 As New Form1
                form1.fromQR = result.ToString()
                Me.Hide()
                form1.Show()
                MessageBox.Show(result.ToString())
            End If
        End If

    End Sub
End Class