Public Class ClubDeObesidad
    Implements IDataBase
    Private DBdata As New List(Of Miembro)

    Public Sub AddNewMember(user As String, password As String, name As String) Implements IDataBase.AddNewMember
        Dim ranValue As Integer = Rnd()
        Dim identifier As String = $"{user}{ranValue}{password}"
        DBdata.Add(New Miembro(user, password, identifier, name))
    End Sub

    Public Function GetMember(identifier As String) As Miembro Implements IDataBase.GetMember
        Dim miembroInfo As Miembro = Nothing
        For Each member As Miembro In DBdata
            If (identifier = member.Get_Id) Then
                miembroInfo = member
            End If
        Next
        Return miembroInfo
    End Function

    Public Function ValidateUser(user As String, password As String) As String Implements IDataBase.ValidateUser
        For Each miembro As Miembro In DBdata
            If (user = miembro.Get_User And password = miembro.Get_Pass) Then
                Return miembro.Get_Id()
            End If
        Next
        Return Nothing
    End Function
End Class