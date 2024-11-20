Public Module Funciones
    Public Bichos_De_Bolsillo As MenuPrincipal
    Public Function FormAbierto(ByVal formulario As String) As Boolean
        For Each f As Form In My.Application.OpenForms
            If f.Name = formulario Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
