<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(169, 324)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(75, 23)
        Me.btnValidar.TabIndex = 0
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(127, 48)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(167, 20)
        Me.txtProducto.TabIndex = 2
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(127, 97)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Precio"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(127, 152)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 195)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(176, 99)
        Me.txtDescripcion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripcion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(423, 383)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnValidar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ErrorProvide"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValidar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents toolTip As ToolTip
End Class
