Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio As Decimal
        Dim tipoiva As Decimal
        Dim calculo As New calculos.Calculo
        Dim datos As New calculos.Datos

        If (TextBox4.Text.Length = 0) Then
            precio = TextBox1.Text
            tipoiva = ListBox1.SelectedIndex
            datos = calculo.Calcular(precio, tipoiva)
        Else
            datos = calculo.calcularFactura(TextBox4.Text)

        End If
        TextBox2.Text = datos.getTodo()
        TextBox3.Text = datos.getIva()

        Label5.Text = datos.getTodo() + datos.getIva()
    End Sub
End Class
