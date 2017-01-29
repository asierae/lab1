Public Class obtenerDatos
    Function obtenerFactura(ByVal idf As Integer) As Factura
        Dim fact As New Factura
        If idf = 121212 Then
            fact.setDatos(1000, 0)
        Else
            fact.setDatos(2000, 1)
        End If
        Return fact

    End Function
End Class
