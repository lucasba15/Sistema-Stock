<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbmProductos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.TxtIdRubro = New System.Windows.Forms.TextBox()
        Me.TxtIdEstado = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodAlternativo = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.DtFechaCarga = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.TxtRubro = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.LblSeñal = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num de Producto"
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Enabled = False
        Me.TxtIdProducto.Location = New System.Drawing.Point(18, 86)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.Size = New System.Drawing.Size(143, 20)
        Me.TxtIdProducto.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 586)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Observaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cod Alternativo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 486)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Imagen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha de Actualización"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Fecha de Carga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Rubro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Costo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Proveedor"
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Enabled = False
        Me.TxtIdProveedor.Location = New System.Drawing.Point(16, 132)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdProveedor.TabIndex = 15
        '
        'TxtIdRubro
        '
        Me.TxtIdRubro.Enabled = False
        Me.TxtIdRubro.Location = New System.Drawing.Point(16, 181)
        Me.TxtIdRubro.Name = "TxtIdRubro"
        Me.TxtIdRubro.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdRubro.TabIndex = 16
        '
        'TxtIdEstado
        '
        Me.TxtIdEstado.Enabled = False
        Me.TxtIdEstado.Location = New System.Drawing.Point(16, 230)
        Me.TxtIdEstado.Name = "TxtIdEstado"
        Me.TxtIdEstado.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdEstado.TabIndex = 17
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(18, 279)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(657, 20)
        Me.TxtDescripcion.TabIndex = 5
        '
        'TxtCodAlternativo
        '
        Me.TxtCodAlternativo.Location = New System.Drawing.Point(16, 325)
        Me.TxtCodAlternativo.Name = "TxtCodAlternativo"
        Me.TxtCodAlternativo.Size = New System.Drawing.Size(128, 20)
        Me.TxtCodAlternativo.TabIndex = 6
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(16, 371)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(128, 20)
        Me.TxtCosto.TabIndex = 8
        '
        'DtFechaCarga
        '
        Me.DtFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaCarga.Location = New System.Drawing.Point(16, 417)
        Me.DtFechaCarga.Name = "DtFechaCarga"
        Me.DtFechaCarga.Size = New System.Drawing.Size(128, 20)
        Me.DtFechaCarga.TabIndex = 10
        Me.DtFechaCarga.Value = New Date(2023, 5, 10, 0, 0, 0, 0)
        '
        'DtFechaActualizacion
        '
        Me.DtFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaActualizacion.Location = New System.Drawing.Point(16, 463)
        Me.DtFechaActualizacion.Name = "DtFechaActualizacion"
        Me.DtFechaActualizacion.Size = New System.Drawing.Size(128, 20)
        Me.DtFechaActualizacion.TabIndex = 11
        Me.DtFechaActualizacion.Value = New Date(2023, 5, 10, 0, 0, 0, 0)
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(15, 750)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(658, 73)
        Me.TxtObservaciones.TabIndex = 61
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Enabled = False
        Me.TxtProveedor.Location = New System.Drawing.Point(99, 132)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(331, 20)
        Me.TxtProveedor.TabIndex = 63
        '
        'TxtRubro
        '
        Me.TxtRubro.Enabled = False
        Me.TxtRubro.Location = New System.Drawing.Point(99, 181)
        Me.TxtRubro.Name = "TxtRubro"
        Me.TxtRubro.Size = New System.Drawing.Size(331, 20)
        Me.TxtRubro.TabIndex = 65
        '
        'TxtEstado
        '
        Me.TxtEstado.Enabled = False
        Me.TxtEstado.Location = New System.Drawing.Point(99, 230)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(331, 20)
        Me.TxtEstado.TabIndex = 67
        '
        'LblSeñal
        '
        Me.LblSeñal.AutoSize = True
        Me.LblSeñal.Location = New System.Drawing.Point(503, 159)
        Me.LblSeñal.Name = "LblSeñal"
        Me.LblSeñal.Size = New System.Drawing.Size(34, 13)
        Me.LblSeñal.TabIndex = 68
        Me.LblSeñal.Text = "Señal"
        Me.LblSeñal.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(99, 489)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 94)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 509)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Examinar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(233, 348)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 20)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Precio Venta"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(237, 371)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(128, 20)
        Me.TxtPrecioVenta.TabIndex = 9
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(237, 325)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(128, 20)
        Me.TxtCantidad.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(233, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 20)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Cantidad"
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkActivo.Checked = True
        Me.ChkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkActivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ChkActivo.Location = New System.Drawing.Point(353, 87)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(77, 24)
        Me.ChkActivo.TabIndex = 17
        Me.ChkActivo.Text = "Activo"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(679, 63)
        Me.ToolStrip2.TabIndex = 14
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton1.Text = "Aceptar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 63)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton4.Text = "Salir"
        '
        'Buscar
        '
        Me.Buscar.BackgroundImage = CType(resources.GetObject("Buscar.BackgroundImage"), System.Drawing.Image)
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Buscar.Location = New System.Drawing.Point(56, 128)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(37, 27)
        Me.Buscar.TabIndex = 2
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(56, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(56, 226)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 27)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 609)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(658, 73)
        Me.TextBox1.TabIndex = 13
        '
        'FrmAbmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 684)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ChkActivo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtPrecioVenta)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblSeñal)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.TxtRubro)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.DtFechaActualizacion)
        Me.Controls.Add(Me.DtFechaCarga)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtCodAlternativo)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtIdEstado)
        Me.Controls.Add(Me.TxtIdRubro)
        Me.Controls.Add(Me.TxtIdProveedor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIdProducto)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAbmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - PRODUCTOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents TxtIdRubro As TextBox
    Friend WithEvents TxtIdEstado As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtCodAlternativo As TextBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents DtFechaCarga As DateTimePicker
    Friend WithEvents DtFechaActualizacion As DateTimePicker
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents TxtRubro As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents LblSeñal As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Buscar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
