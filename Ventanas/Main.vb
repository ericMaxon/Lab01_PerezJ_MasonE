Public Class Main
    Private Store As ClubDeObesidad
    Private miembroInfo As Miembro
    Private navHistory As List(Of Form)
    Public Sub New(ByRef _Store As ClubDeObesidad, _userCred As Miembro, ByRef _NavHistory As List(Of Form))
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Store = _Store
        Me.miembroInfo = _userCred
        Me.navHistory = _NavHistory
        Me.title.Text = $"{Me.title.Text} {Me.miembroInfo.NombreProp}"
        Me.tbxUser.Text = Me.miembroInfo.Get_User()
        Me.tbxPass.Text = Me.miembroInfo.Get_Pass()
        Me.tbxUser.PlaceholderText = Me.miembroInfo.Get_User()
        Me.tbxPass.PlaceholderText = Me.miembroInfo.Get_Pass()
    End Sub


    Private Sub tbxPass_TextChanged(sender As Object, e As EventArgs) Handles tbxPass.TextChanged
         = tbxPass.Text
    End Sub

    Private Sub tbxUser_TextChanged(sender As Object, e As EventArgs) Handles tbxUser.TextChanged
         = Me.tbxUser.Text
    End Sub

    Private Sub btnGB_Click(sender As Object, e As EventArgs) Handles btnGB.Click
        Me.navHistory.Last().Hide()
        navHistory.Remove(Me)
        ResetValue()
        navHistory.Last().Show()
    End Sub
    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        Me.tbxPass.UseSystemPasswordChar = Not Me.tbxPass.UseSystemPasswordChar
    End Sub

    Private Sub ResetValue()


        Me.tbxPass.ResetText()
        Me.tbxUser.ResetText()
    End Sub

    Private Sub btnStartRitual_Click(sender As Object, e As EventArgs) Handles btnStartRitual.Click

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        ' Haciendo un recorrido dentro del registro para añadir sus valores al listBox
        Me.miembroInfo.Get_Registro().ForEach(Sub(val)
                                                  lbData.Items.Add(val)
                                              End Sub
                                            )
    End Sub
End Class