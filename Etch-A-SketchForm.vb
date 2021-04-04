'Laura Riley
'RCET 0265
'Spring 2021
'Etch-a-Sketch
'

Option Strict On
Option Explicit On

Public Class EtchASketchForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DrawPictureBox.Image = Nothing
        DrawPictureBox.BackColor = Color.Empty
    End Sub
End Class
