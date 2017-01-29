Public Class Calculo
    Function Calcular(ByVal total As Decimal, ByVal tipoiva As Decimal) As Datos
        Dim datos As New Datos
        Dim todo As Decimal
        Dim todoiva As Decimal
        If tipoiva = 0 Then
            todoiva = total * 0.23999999999999999
        ElseIf tipoiva = 1 Then
            todoiva = total * 0.10000000000000001
        ElseIf tipoiva = 2 Then
            todoiva = total * 0.040000000000000001

        End If
        todo = total - todoiva
        datos.setDatos(todo, todoiva)
        Return datos
    End Function

    Function calcularFactura(ByVal idf As Integer) As Datos
        Dim base As New obtenerDatos.obtenerDatos
        Dim fact As New obtenerDatos.Factura
        fact = base.obtenerFactura(idf)
        Return Calcular(fact.getPrecio(), fact.getTipoIva())

    End Function
End Class
