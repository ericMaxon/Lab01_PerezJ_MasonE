Public Class Lectura
    Implements ILectura
    Private inputDouble As Double

    Public Property Input As Double Implements ILectura.Input
        Get
            Return inputDouble
        End Get
        Set(value As Double)
            inputDouble = value
        End Set
    End Property

    ' Funcion encargada a la lectura de valores double a unado a validaciones
    Public Function readingDouble(mensaje As String) As Double Implements ILectura.readingDouble
        Dim err As Boolean
        Do
            Try
                err = False
                Me.Input = Double.Parse(InputBox(mensaje, "Datos de entrada"))
                If (Me.Input <= 0) Then
                    MsgBox("Ingrese un valor valido", vbExclamation, "ERROR")
                    err = Not err
                End If
            Catch ex As Exception
                MsgBox("Debe ingresar valores numericos", vbExclamation, "ERROR")
                err = Not err
            End Try
        Loop While err
        Return Input
    End Function
End Class
