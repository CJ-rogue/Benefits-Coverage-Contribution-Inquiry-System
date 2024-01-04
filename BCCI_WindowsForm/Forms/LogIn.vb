Public Class LogIn

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Show the menu form
        If CheckBox1.Checked Then
            Menu.Show()

            ' Close the login form
            Me.Close()
        Else
            MessageBox.Show(vbCrLf & "Please agree to the Terms of Service and Privacy Policy to continue using this app." & vbCrLf, "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
End Class
