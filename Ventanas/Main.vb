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
        If Me.miembroInfo.Get_Registro().Count Then
            InsertarData()
            Me.btnChangeW.Visible = True
            End If
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
        MsgBox("Ha comenzado el ritual de pesado", vbOKOnly, "Inicio")
        For counter = 1 To 3 ' Realizando la lectura de los pesos
            Me.miembroInfo.InsertarPeso(leer.readingDouble($"Ingrese el peso marcado en la bascula N{counter}"))
        Next
        MsgBox("Se ha completado el ritual", vbOKOnly, "Inicio")
        Me.miembroInfo.CalcularPromedio()
        InsertarData()
        If Me.lbData.Items.Count >= 1 Then
            Me.btnChangeW.Visible = True
        End If
    End Sub

    Private Sub btnChangeW_Click(sender As Object, e As EventArgs) Handles btnChangeW.Click
        Dim comment = Me.miembroInfo.ObtenerComentario()
        If comment.Equals("SUBIO") Then
            MsgBox(comment, vbCritical, "Directo al gym")
        Else
            MsgBox(comment, vbInformation, "Mantengamos la linea")
        End If
    End Sub

    Private Sub InsertarData()
        Dim lista As List(Of Double) = Me.miembroInfo.Get_Registro()
        Dim data As Double
        Dim anterior As Double
        ' Haciendo un recorrido dentro del registro para añadir sus valores al listBox
        For i = 0 To lista.Count - 1
            If lbData.Items.Count = 0 Then ' Si la lista esta vacia
                data = lista(lbData.Items.Count) ' Se le da el tamaño de count porque es cero
                lbData.Items.Add(data)
            Else
                If i > lbData.Items.Count - 1 Then ' Hacer el salto de posicion porque se supone que ya se ingreso mas de un valor
                    anterior = lista(i - 1)
                    data = lista(i)
                    If data <> anterior Then
                        lbData.Items.Add(data)
                    End If
                End If
            End If
        Next
    End Sub
End Class