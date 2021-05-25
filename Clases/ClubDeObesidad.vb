Public Class ClubDeObesidad
    Implements IDataBase
    Private DBdata As List(Of Miembro) = New List(Of Miembro)

    Public Sub AddNewMember(user As String, password As String, name As String) Implements IDataBase.AddNewMember
        Dim ranValue As Integer = Rnd()
        Dim identifier As String = $"{user}{ranValue}{password}"
        DBdata.Add(New Miembro(user, password, identifier, name))
    End Sub

    Public Function GetMember(identifier As String) As Miembro Implements IDataBase.GetMember
        Dim userCredentials As Miembro = Nothing
        For Each member As Miembro In DBdata
            If (identifier = member.Get_Id) Then
                userCredentials = member
            End If
        Next
        Return userCredentials
    End Function

    Public Function ValidateUser(validateMem As Miembro) As Miembro Implements IDataBase.ValidateUser
        For Each miembro As Miembro In DBdata
            If (validateMem.Get_User = miembro.Get_User And validateMem.Get_Pass = miembro.Get_Pass) Then
                Return miembro
            End If
        Next
        Return Nothing
    End Function
End Class