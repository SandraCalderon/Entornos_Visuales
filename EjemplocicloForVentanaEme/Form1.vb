Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double

        valor = Val(txtValor.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multiplicacion = valor * i
            'format((variable).tostring,2) para hacer un cast o conversion y el dos para indicar la cantidad de numeros despues del punto
            division = Format((valor / i).ToString)
            cmbSuma.Items.Add((valor & "+" & i & "=" & suma))
            cmbResta.Items.Add((valor & "-" & i & "=" & resta))
            cmbMulti.Items.Add((valor & "x" & i & "=" & multiplicacion))
            cmbDivide.Items.Add((valor & "/" & i & "=" & division))
        Next
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese numero", "Ingreso")
        txtValor.Text = valor
    End Sub
End Class
