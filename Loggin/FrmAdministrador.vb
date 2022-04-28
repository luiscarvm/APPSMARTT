Public Class FrmAdministrador
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmLogin.Show()
        FrmLogin.Refresh()


        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'Convert.ToTextBox(FrmLogin.txtUsuario) = Label2.Text

    End Sub
End Class