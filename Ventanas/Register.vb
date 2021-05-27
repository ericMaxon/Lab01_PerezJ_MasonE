Public Class Register
    Private Store As IDataBase = New ClubDeObesidad()
    Private NavHistory As List(Of Form) = New List(Of Form)
    Private userCred As IUserCredentials = New UserCredentials()
    Private nombre As String
    Private Sub tbxPass_TextChanged(sender As Object, e As EventArgs) Handles tbxPass.TextChanged
        Me.userCred.PwProp = Me.tbxPass.Text
    End Sub

    Private Sub tbxUser_TextChanged(sender As Object, e As EventArgs) Handles tbxUser.TextChanged
        Me.userCred.UserProp = Me.tbxUser.Text
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbxName.TextChanged
        nombre = tbxName.Text
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim newMember As New Miembro()
        Dim id As String
        If (Me.userCred.UserProp <> "" And Me.userCred.PwProp <> "" And nombre <> "") Then
            'Validando que el usuario ingresado no exista
            If Me.Store.ValidateUser(userCred.UserProp, userCred.PwProp) Is Nothing Then
                Me.Store.AddNewMember(userCred.UserProp, userCred.PwProp, nombre) ' Se agrega el usuario a la "base de datos" 
                id = Me.Store.ValidateUser(userCred.UserProp, userCred.PwProp)
                ' Se obtiene el id del nuevo usuario
                ' Luego se valida que el usuario haya sido ingresado
                If id IsNot Nothing Then
                    newMember = Me.Store.GetMember(id)
                    Me.NavHistory.Add(Me)
                    Me.NavHistory.Last().Hide()
                    Me.NavHistory.Add(New Main(Me.Store, newMember, Me.NavHistory))
                    Me.ResetValue()
                    Me.NavHistory.Last().Show()
                Else
                    MsgBox("Ha habido un error al crear el usuario", vbOKOnly, "Error")
                End If
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
        Me.tbxName.ResetText()
        Me.tbxPass.ResetText()
        Me.tbxUser.ResetText()
        userCred.UserProp = ""
        userCred.PwProp = ""
        nombre = ""
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        MyBase.Dispose()
    End Sub
End Class
