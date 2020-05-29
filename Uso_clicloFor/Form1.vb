Public Class Form1




    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click


        Dim num As Integer
        Dim x As Integer
        num = Val(txtNumero.Text)
        txtTabla.Text = ""
        For x = 1 To 10
            txtTabla.Text = txtTabla.Text & num & " * " & x & " = " & num * x & vbCrLf
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTabla.Clear()
        txtNumero.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim salir As String



        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir <> 6 Then
            txtNumero.Focus()
        Else
            End
        End If
    End Sub
End Class
