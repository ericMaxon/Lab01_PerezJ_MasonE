Public Class Main
    Private Store As ClubDeObesidad
    Private miembroInfo As Miembro
    Private navHistory As List(Of Form)
    Private leer As ILectura = New Lectura()
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

    Private Sub btnGB_Click(sender As Object, e As EventArgs) Handles btnGB.Click
        Me.navHistory.Last().Hide()
        navHistory.Remove(Me)
        ResetValue()
        navHistory.Last().Show()
        Me.Dispose()
    End Sub
    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        Me.tbxPass.UseSystemPasswordChar = Not Me.tbxPass.UseSystemPasswordChar
    End Sub

    Private Sub ResetValue()
        Me.tbxPass.ResetText()
        Me.tbxUser.ResetText()
    End Sub

    Private Sub btnStartRitual_Click(sender As Object, e As EventArgs) Handles btnStartRitual.Click
        Static repeticiones As Integer = 1
        MsgBox("Ha comenzado el ritual de pesado")
        For counter = 1 To 3
            Me.miembroInfo.InsertarPeso(leer.readingDouble($"Ingrese el peso marcado en la bascula N{counter}"))
        Next
        MsgBox("Se ha completado el ritual")
        Me.miembroInfo.CalcularPromedio()
        If repeticiones > 1 Then
            Me.btnChangeW.Visible = True
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        ' Haciendo un recorrido dentro del registro para añadir sus valores al listBox
        ' Siempre y cuando la lista de registro tenga algun valor
        If Me.miembroInfo.Get_Registro().Count Then
            Me.miembroInfo.Get_Registro().ForEach(Sub(val)
                                                      lbData.Items.Add(val)
                                                  End Sub
                                            )
        End If
    End Sub

    Private Sub btnChangeW_Click(sender As Object, e As EventArgs) Handles btnChangeW.Click
        MsgBox(Me.miembroInfo.ObtenerComentario())
    End Sub
End Class