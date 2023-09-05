Public Class Form1
    Private Sub btnGender_Click(sender As Object, e As EventArgs) Handles btnGender.Click

        Dim Gender As String

        Gender = lbGender.SelectedItem
        MessageBox.Show("hi you are a " & Gender)


    End Sub
End Class
