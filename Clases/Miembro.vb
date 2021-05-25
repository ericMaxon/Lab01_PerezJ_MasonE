Public Class Miembro
    Private Nombre As String
    Private Pesos As New List(Of Double)
    Public credenciales As IUserCredentials
    Private RegistroDePromedio As New List(Of Double)

    Public Sub New()
        NombreProp = ""
    End Sub
    Public Sub New(user As String, pass As String, identifier As String, name As String)
        NombreProp = name
        credenciales = New UserCredentials(user, pass, identifier)
    End Sub
    Public Property NombreProp As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Private Sub AsignarCredenciales(user As String, password As String, identifier As String)
        Me.credenciales.UserProp = user
        Me.credenciales.PwProp = password
        Me.credenciales.IdProp = identifier
    End Sub
    Public Sub InsertarPeso(peso As Double)
        Pesos.Add(peso)
    End Sub
    Public Sub CalcularPromedio()
        ' Sub que obtiene los pesos y asigna el promedio al registro
        Dim acumuladorPesos As Double
        Dim cantidadPesos As Integer = Pesos.Count
        For Each peso As Double In Pesos
            acumuladorPesos += peso
            ' Se eliminan los pesos para reiniciar la Lista de Pesos
            Pesos.Remove(peso)
        Next
        RegistroDePromedio.Add(acumuladorPesos / cantidadPesos)
    End Sub
    Public Function ObtenerComentario() As String
        ' Se verifica que en el registro se haya ingresado mas de 1 promedio
        If RegistroDePromedio.Count > 1 Then
            Dim promedioAnterior As Double = RegistroDePromedio.ElementAt(RegistroDePromedio.Count - 2) ' Sacando el valor anterior
            Dim diferencia As Double = promedioAnterior - RegistroDePromedio.Last()
            If diferencia > 0 Then
                Return "SUBIO"
            Else
                Return "BAJO"
            End If
        End If
        Return "Debe volver a realizar el ritual para comprobar la mejora"
    End Function
    Public Function Get_User() As String
        Return Me.credenciales.UserProp
    End Function
    Public Function Get_Pass() As String
        Return Me.credenciales.PwProp
    End Function
    Public Function Get_Id() As String
        Return Me.credenciales.IdProp
    End Function
    Public Function Get_Registro() As List(Of Double)
        Return RegistroDePromedio
    End Function
    Public Function Get_Pesos() As List(Of Double)
        Return Pesos
    End Function
End Class
