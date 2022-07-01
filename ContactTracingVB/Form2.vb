Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Form2
    Dim cameraDisplay As VideoCaptureDevice
    Dim bitQR As Bitmap
    Private Sub scanBtn_Click(sender As Object, e As EventArgs) Handles scanBtn.Click
        Dim cameraDisplayQR As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameraDisplayQR.ShowDialog() = DialogResult.OK Then
            cameraDisplay = cameraDisplayQR.VideoDevice
            AddHandler cameraDisplay.NewFrame, New NewFrameEventHandler(AddressOf qrCapture)
            cameraDisplay.Start()
        End If
    End Sub

    Private Sub qrCapture(sender As Object, eventArgs As NewFrameEventArgs)
        bitQR = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        qrPictureBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
End Class