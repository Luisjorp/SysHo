Imports capaEntidad
Imports capaNegocios
Public Class frmLogin

    Public Sub Login()
        Dim objeto As New cnTrabajador
        Dim datos As New DataTable
        Dim tra As New ceTrabajador

        tra.login = txtLogin.Text
        tra.password = txtPassword.Text

        datos = objeto.RN_login(tra)

        'If datos no son vacíos falta
        If txtLogin.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Por favor, verifique que no ha dejado campos vacíos.", MsgBoxStyle.Critical, "CAMPOS VACÍOS")
        Else
            If datos.Rows.Count = 0 Then
                MsgBox("No tiene acceso al sistema.", MsgBoxStyle.Critical, "Credenciales Incorrectas")
            Else
                Dim frm As New frmMain()
                'Faltan accesos
                frm.Show()
                Close()
            End If
        End If

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Login()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class