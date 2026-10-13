Imports System.Drawing.Drawing2D

Public Class myProfile
    Private Sub picProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakePictureCircular()
    End Sub

    Private Sub MakePictureCircular()
            Dim circle As New GraphicsPath()

            circle.AddEllipse(0, 0, picProfile.Width, picProfile.Height)

            picProfile.Region = New Region(circle)

            circle.Dispose()
        End Sub

    End Class
