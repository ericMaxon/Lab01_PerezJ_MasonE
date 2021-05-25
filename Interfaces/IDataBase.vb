Public Interface IDataBase
    Sub AddNewMember(ByVal user As String, ByVal password As String, ByVal name As String)
    Function GetMember(ByVal identifier As String) As Miembro
    Function ValidateUser(ByVal user As String, ByVal password As String) As String
End Interface
