Public Class Miembro
    Private Nombre As String
    Private Pesos As List(Of Double) = New List(Of Double)
    Private credenciales As IUserCredentials = New UserCredentials()
    Private RegistroDePromedio As List(Of Double) = New List(Of Double)
    Public Sub New(user As String, pass As String, identifier As String, name As String)
        NombreProp = name
        Me.AsignarCredenciales(user, pass, identifier)
    End Sub
    Public Property NombreProp As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Public Sub InsertarPeso(peso As Double)
        Pesos.Add(peso)
    End Sub
    Private Sub AsignarCredenciales(user As String, password As String, identifier As String)
        Me.credenciales.UserProp = user
        Me.credenciales.PwProp = password
        Me.credenciales.IdProp = identifier
    End Sub
    Public Sub Promedio()
        Dim acumulador As Double
        For Each peso As Double In Pesos
            acumulador += peso
            Pesos.Remove(peso)
        Next
        RegistroDePromedio.Add(acumulador / 3)
    End Sub
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
End Class
