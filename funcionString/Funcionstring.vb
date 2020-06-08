Public Class Funcionstring
    Private Sub txtMostrar_Click(sender As Object, e As EventArgs) Handles txtMostrar.Click
        Dim cadena As String

        cadena = txtcadena.Text
        txtLongitud.Text = cadena.Length
        txtUltimo.Text = cadena.Substring(cadena.Length - 1, 1)
        txtPrimero.Text = cadena.Substring(0, 1)
        txt3y8.Text = cadena.Substring(2, 7)
        txtB.Text = cadena.IndexOf("B", 0) + 1
        txtMayus.Text = cadena.ToUpper
        txtMinus.Text = cadena.ToLower
        txtBorrar.Text = cadena.Replace(" ", "")

    End Sub

    Private Sub txtNuevo_Click(sender As Object, e As EventArgs) Handles txtNuevo.Click
        txtcadena.Clear()
        txtLongitud.Clear()
        txtUltimo.Clear()
        txtPrimero.Clear()
        txt3y8.Clear()
        txtB.Clear()
        txtMayus.Clear()
        txtMinus.Clear()
        txtBorrar.Clear()
    End Sub

    Private Sub txtSalir_Click(sender As Object, e As EventArgs) Handles txtSalir.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir = 6 Then
            End
        End If
    End Sub
End Class
