Public Class Register
    Private Store As ClubDeObesidad = New BaseDeDatos("eMann", "controlandoElSistema", True)
    Private userCred As IUserCredentials = New UserCredentials()
    Private NavHistory As List(Of Form) = New List(Of Form)
    Private Sub tbxPass_TextChanged(sender As Object, e As EventArgs) Handles tbxPass.TextChanged
        Me.userCred.PwProp = Me.tbxPass.Text
    End Sub

    Private Sub tbxUser_TextChanged(sender As Object, e As EventArgs) Handles tbxUser.TextChanged
        Me.userCred.UserProp = Me.tbxUser.Text
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If (Me.userCred.UserProp <> "" And Me.userCred.PwProp <> "") Then
            'Validando que el usuario ingresado no exista
            If Me.Store.ValidateUser(Me.userCred) Is Nothing Then
                Me.userCred = Me.Store.ValidateUser(Me.userCred)
                MsgBox($"OnCreateClick {Me.userCred.IdProp}")
                MsgBox($"{Me.userCred.UserProp}")
                MsgBox($"{Me.userCred.PwProp}")
                Me.NavHistory.Add(Me)
                Me.NavHistory.Last().Hide()
                Me.NavHistory.Add(New Main(Me.Store, Me.userCred, Me.NavHistory))
                Me.ResetValue()
                Me.NavHistory.Last().Show()
            Else
                MsgBox("Ya existe el usuario", vbOKOnly, "Error")
            End If
        Else
            MsgBox("Complete el formulario para seguir", vbOKOnly, "Fomrulario incompleto")
        End If
    End Sub

    Private Sub btnHveAcc_Click(sender As Object, e As EventArgs) Handles btnHveAcc.Click
        Me.NavHistory.Add(Me)
        Me.NavHistory.Last().Hide()
        Me.NavHistory.Add(New LogIn(Me.Store, Me.NavHistory))
        Me.ResetValue()
        Me.NavHistory.Last().Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        Me.tbxPass.UseSystemPasswordChar = Not Me.tbxPass.UseSystemPasswordChar
    End Sub

    Private Sub ResetValue()
        Me.tbxPass.ResetText()
        Me.tbxUser.ResetText()
    End Sub
End Class
