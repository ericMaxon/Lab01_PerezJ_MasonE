Public Class UserCredentials
    Implements IUserCredentials
    Private user As String
    Private password As String
    Private identifier As String
    Public Sub New()
        Me.user = ""
        Me.password = ""
        Me.identifier = ""
    End Sub
    Public Sub New(_user As String, _password As String, _identifier As String)
        Me.UserProp = _user
        Me.PwProp = _password
        Me.IdProp = _identifier
    End Sub
    Public Property UserProp As String Implements IUserCredentials.UserProp
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property
    Public Property PwProp As String Implements IUserCredentials.PwProp
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
    Public Property IdProp As String Implements IUserCredentials.IdProp
        Get
            Return identifier
        End Get
        Set(value As String)
            identifier = value
        End Set
    End Property

End Class
