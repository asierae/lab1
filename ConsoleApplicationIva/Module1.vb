Module Module1

    Sub Main()
        Dim total As Decimal
        Dim tipoiva As Decimal
        Dim calc As New calculos.Calculo
        Dim datos As New calculos.Datos

        While True
            Console.WriteLine("Escribe el total a pagar: ")
            total = Console.ReadLine()
            Console.WriteLine("Escribe el tipo de Iva: General=0 Reducido=1 SuperReducido=2 ")
            tipoiva = Console.ReadLine()
  
            datos = calc.Calcular(total, tipoiva)
            Console.Write("Total Sin IVA: ")
            Console.WriteLine(datos.getTodo())
            Console.Write("IVA: ")
            Console.WriteLine(datos.getIva())
        End While
    End Sub

End Module
