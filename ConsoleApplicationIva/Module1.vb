Module Module1

    Sub Main()
        Dim total
        Dim tipoiva
        Dim calc As New calculos.Calculo
        Dim datos As New calculos.Datos

        While True
            Console.WriteLine("Escribe el total a pagar: ")
            total = Console.ReadLine()
            If Not IsNumeric(total) Then
                Console.WriteLine("Introduce un número valido")
                Continue While
            End If
            Console.WriteLine("Escribe el tipo de Iva: General=0 Reducido=1 SuperReducido=2 ")
            tipoiva = Console.ReadLine()
            If Not IsNumeric(tipoiva) Or tipoiva > 2 Then
                Console.WriteLine("Error Introduce un número entero valido entre 0 y 2")
                Continue While
            End If
            datos = calc.Calcular(total, tipoiva)
            Console.Write("Total Sin IVA: ")
            Console.WriteLine(datos.getTodo())
            Console.Write("IVA: ")
            Console.WriteLine(datos.getIva())
            Console.WriteLine("---------------------------------")
        End While
    End Sub

End Module
