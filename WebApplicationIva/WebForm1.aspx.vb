Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio
        Dim tipoiva
        Dim calculo As New calculos.Calculo
        Dim datos As New calculos.Datos
        If (TextBox4.Text.Length = 0) Then
            precio = TextBox1.Text
            tipoiva = ListBox1.SelectedIndex
            If IsNumeric(precio) And IsNumeric(tipoiva) Then
                TextBox1.BackColor = Drawing.Color.White
                datos = calculo.Calcular(precio, tipoiva)
            Else
                TextBox1.BackColor = Drawing.Color.Red

            End If

        Else
            If IsNumeric(TextBox4.Text) Then
                TextBox4.BackColor = Drawing.Color.White
                datos = calculo.calcularFactura(TextBox4.Text)
            Else
                TextBox4.BackColor = Drawing.Color.Red

            End If
            End If

            TextBox2.Text = datos.getTodo()
            TextBox3.Text = datos.getIva()

    End Sub


End Class