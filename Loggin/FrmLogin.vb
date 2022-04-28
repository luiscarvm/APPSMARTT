Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If usuarioRegistrado(txtUsuario.Text) = True Then
                Dim contra As String = contrasena(txtUsuario.Text)
                If contra.Equals(txtContrasena.Text) = True Then
                    Me.Hide()
                    If ConsultarTipoUsuario(txtUsuario.Text) = 1 Then
                        FrmAdministrador.ShowDialog()
                    ElseIf ConsultarTipoUsuario(txtUsuario.Text) = 2 Then
                        FrmInvitado.ShowDialog()
                    Else
                        FrmEstandar.ShowDialog()
                    End If
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + txtUsuario.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtUsuario.Clear()
        txtContrasena.Clear()
    End Sub

    Private Sub txtContrasena_TextChanged(sender As Object, e As EventArgs) Handles txtContrasena.TextChanged

    End Sub
End Class
