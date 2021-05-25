Public Class Main
    Private Store As ClubDeObesidad
    Private userCred As IUserCredentials
    Private navHistory As List(Of Form)
    Public Sub New(ByRef _Store As ClubDeObesidad, _userCred As IUserCredentials, ByRef _NavHistory As List(Of Form))
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Store = _Store
        Me.userCred = _userCred
        Me.navHistory = _NavHistory
        Me.tbxUser.Text = Me.userCred.UserProp
        Me.tbxPass.Text = Me.userCred.PwProp
        Me.tbxUser.PlaceholderText = Me.userCred.UserProp
        Me.tbxPass.PlaceholderText = Me.userCred.PwProp
        If Me.userCred.AdminProp Then
            Me.navHistory.Last().Hide()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbxPass_TextChanged(sender As Object, e As EventArgs) Handles tbxPass.TextChanged
        userCred.PwProp = tbxPass.Text
    End Sub

    Private Sub tbxUser_TextChanged(sender As Object, e As EventArgs) Handles tbxUser.TextChanged
        Me.userCred.UserProp = Me.tbxUser.Text
    End Sub

    Private Sub btnGB_Click(sender As Object, e As EventArgs) Handles btnGB.Click
        Me.navHistory.Last().Hide()
        navHistory.Remove(Me)
        ResetValue()
        navHistory.Last().Show()

    End Sub
    Private Sub ResetValue()
        Me.userCred.UserProp = ""
        Me.userCred.PwProp = ""
        Me.tbxPass.ResetText()
        Me.tbxUser.ResetText()
    End Sub
End Class