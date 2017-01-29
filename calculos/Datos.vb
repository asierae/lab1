Public Class Datos
    Dim tsi As Decimal
    Dim iva As Decimal

    Function setDatos(a As Decimal, b As Decimal) As Single
        tsi = a
        iva = b
    End Function

    Function getTodo() As Decimal
        Return tsi
    End Function
    Function getIva() As Decimal
        Return iva
    End Function
End Class
