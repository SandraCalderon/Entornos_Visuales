Public Class Form1
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'try catch
        'validarteChildre buttonm 
        'validating(Dentro de las cajas de texto)
        'validated nos valida si dejamos un caja vacia
        Try
            'si las casills estas sin ningun valor o vacias
            'primero valida que producto<> vacio, precio<>vacio, cantidad val(cantidad)convierte ese valor en entero
            If Me.ValidateChildren And txtProducto.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
                'me. accesede a todos los datos y validateChildren se lo aplica a todos los controles
                'String.Empty es para verificar si esta vacio es igual a decir " " 
                '= para que solo reconozca cuando este vacio
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            'catch ex as exception
            'catch variables as excepcion
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtProducto_Validated(sender As Object, e As EventArgs) Handles txtProducto.Validated

    End Sub


    Private Sub txtPrecio_Validated(sender As Object, e As EventArgs) Handles txtPrecio.Validated

    End Sub
End Class
