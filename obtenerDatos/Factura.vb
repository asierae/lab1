Public Class Factura
    Dim precio As Integer
    Dim tipoiva As Integer
    Function setDatos(ByVal a As Integer, ByVal b As Integer) As Single
        precio = a
        tipoiva = b
    End Function
    Function getPrecio() As Integer
        Return precio

    End Function
    Function getTipoIva() As Integer
        Return tipoiva
    End Function
End Class
