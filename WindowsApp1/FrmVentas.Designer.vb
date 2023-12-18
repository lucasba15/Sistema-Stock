<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.ChkContado = New System.Windows.Forms.CheckBox()
        Me.ChkCuentaCorriente = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrillaProductosFinal = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrillaProductosInicial = New System.Windows.Forms.DataGridView()
        Me.Codigo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtComprobante = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ChkVenta = New System.Windows.Forms.CheckBox()
        Me.ChkDevolucion = New System.Windows.Forms.CheckBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblNroComprobante = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        CType(Me.GrillaProductosFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaProductosInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(609, 34)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(293, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cliente"
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Location = New System.Drawing.Point(458, 34)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(77, 20)
        Me.TxtIdCliente.TabIndex = 95
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(609, 60)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(293, 20)
        Me.TxtApellido.TabIndex = 96
        '
        'ChkContado
        '
        Me.ChkContado.AutoSize = True
        Me.ChkContado.Location = New System.Drawing.Point(422, 99)
        Me.ChkContado.Name = "ChkContado"
        Me.ChkContado.Size = New System.Drawing.Size(66, 17)
        Me.ChkContado.TabIndex = 1
        Me.ChkContado.Text = "Contado"
        Me.ChkContado.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkContado.UseVisualStyleBackColor = True
        '
        'ChkCuentaCorriente
        '
        Me.ChkCuentaCorriente.AutoSize = True
        Me.ChkCuentaCorriente.Location = New System.Drawing.Point(422, 122)
        Me.ChkCuentaCorriente.Name = "ChkCuentaCorriente"
        Me.ChkCuentaCorriente.Size = New System.Drawing.Size(105, 17)
        Me.ChkCuentaCorriente.TabIndex = 98
        Me.ChkCuentaCorriente.Text = "Cuenta Corriente"
        Me.ChkCuentaCorriente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Tipo Venta"
        '
        'GrillaProductosFinal
        '
        Me.GrillaProductosFinal.AllowUserToAddRows = False
        Me.GrillaProductosFinal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrillaProductosFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProductosFinal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Cantidad, Me.PrecioUnitario, Me.PrecioTotal})
        Me.GrillaProductosFinal.Location = New System.Drawing.Point(639, 171)
        Me.GrillaProductosFinal.Name = "GrillaProductosFinal"
        Me.GrillaProductosFinal.Size = New System.Drawing.Size(719, 367)
        Me.GrillaProductosFinal.TabIndex = 100
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 300
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 70
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.Width = 150
        '
        'PrecioTotal
        '
        Me.PrecioTotal.HeaderText = "Total"
        Me.PrecioTotal.Name = "PrecioTotal"
        Me.PrecioTotal.Width = 150
        '
        'GrillaProductosInicial
        '
        Me.GrillaProductosInicial.AllowUserToAddRows = False
        Me.GrillaProductosInicial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrillaProductosInicial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProductosInicial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo2, Me.Descripcion2, Me.PrecioVenta, Me.Cantidad2})
        Me.GrillaProductosInicial.Location = New System.Drawing.Point(12, 171)
        Me.GrillaProductosInicial.Name = "GrillaProductosInicial"
        Me.GrillaProductosInicial.Size = New System.Drawing.Size(606, 367)
        Me.GrillaProductosInicial.TabIndex = 3
        '
        'Codigo2
        '
        Me.Codigo2.HeaderText = "Código"
        Me.Codigo2.Name = "Codigo2"
        Me.Codigo2.Visible = False
        '
        'Descripcion2
        '
        Me.Descripcion2.HeaderText = "Descripción"
        Me.Descripcion2.Name = "Descripcion2"
        Me.Descripcion2.Width = 300
        '
        'PrecioVenta
        '
        Me.PrecioVenta.HeaderText = "Precio Venta"
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.Width = 150
        '
        'Cantidad2
        '
        Me.Cantidad2.HeaderText = "Cantidad"
        Me.Cantidad2.Name = "Cantidad2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 541)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Código"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(12, 564)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(108, 20)
        Me.TxtCodigo.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 541)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Descripción"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(155, 564)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(328, 20)
        Me.TxtDescripcion.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 587)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Precio Venta"
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(12, 610)
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(108, 20)
        Me.TxtPrecioVenta.TabIndex = 107
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 587)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(155, 610)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(77, 20)
        Me.TxtCantidad.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(263, 587)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Total"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(267, 610)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(108, 20)
        Me.TxtTotal.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(800, 541)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Total Venta"
        '
        'TxtTotalVenta
        '
        Me.TxtTotalVenta.Location = New System.Drawing.Point(908, 541)
        Me.TxtTotalVenta.Name = "TxtTotalVenta"
        Me.TxtTotalVenta.Size = New System.Drawing.Size(209, 20)
        Me.TxtTotalVenta.TabIndex = 115
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 20)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Nro Comprobante :"
        '
        'TxtComprobante
        '
        Me.TxtComprobante.Enabled = False
        Me.TxtComprobante.Location = New System.Drawing.Point(12, 32)
        Me.TxtComprobante.Name = "TxtComprobante"
        Me.TxtComprobante.Size = New System.Drawing.Size(85, 20)
        Me.TxtComprobante.TabIndex = 117
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Fecha"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(8, 94)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(0, 20)
        Me.LblFecha.TabIndex = 119
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(667, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 20)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Tipo Comprobante"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(227, 25)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Búsqueda por Nombre"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(250, 145)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(285, 20)
        Me.TxtBusqueda.TabIndex = 122
        '
        'ChkVenta
        '
        Me.ChkVenta.AutoSize = True
        Me.ChkVenta.Location = New System.Drawing.Point(727, 106)
        Me.ChkVenta.Name = "ChkVenta"
        Me.ChkVenta.Size = New System.Drawing.Size(54, 17)
        Me.ChkVenta.TabIndex = 2
        Me.ChkVenta.Text = "Venta"
        Me.ChkVenta.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkVenta.UseVisualStyleBackColor = True
        '
        'ChkDevolucion
        '
        Me.ChkDevolucion.AutoSize = True
        Me.ChkDevolucion.Location = New System.Drawing.Point(727, 129)
        Me.ChkDevolucion.Name = "ChkDevolucion"
        Me.ChkDevolucion.Size = New System.Drawing.Size(80, 17)
        Me.ChkDevolucion.TabIndex = 124
        Me.ChkDevolucion.Text = "Devolución"
        Me.ChkDevolucion.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkDevolucion.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripSeparator6, Me.ToolStripButton7, Me.ToolStripSeparator2, Me.ToolStripButton8})
        Me.ToolStrip3.Location = New System.Drawing.Point(1135, 541)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(195, 63)
        Me.ToolStrip3.TabIndex = 7
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton6.Text = "Registrar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 63)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.AutoSize = False
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton7.Text = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 63)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton8.Text = "Borrar Todo"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.ToolStrip2.Location = New System.Drawing.Point(12, 633)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(129, 63)
        Me.ToolStrip2.TabIndex = 6
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(173, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 20)
        Me.Label13.TabIndex = 127
        '
        'LblNroComprobante
        '
        Me.LblNroComprobante.AutoSize = True
        Me.LblNroComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroComprobante.Location = New System.Drawing.Point(164, 9)
        Me.LblNroComprobante.Name = "LblNroComprobante"
        Me.LblNroComprobante.Size = New System.Drawing.Size(0, 20)
        Me.LblNroComprobante.TabIndex = 128
        '
        'Buscar
        '
        Me.Buscar.BackgroundImage = CType(resources.GetObject("Buscar.BackgroundImage"), System.Drawing.Image)
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Buscar.Location = New System.Drawing.Point(554, 26)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(37, 31)
        Me.Buscar.TabIndex = 0
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.LblNroComprobante)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.ChkDevolucion)
        Me.Controls.Add(Me.ChkVenta)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtComprobante)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTotalVenta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPrecioVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GrillaProductosInicial)
        Me.Controls.Add(Me.GrillaProductosFinal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkCuentaCorriente)
        Me.Controls.Add(Me.ChkContado)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtIdCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTAS"
        CType(Me.GrillaProductosFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaProductosInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents ChkContado As CheckBox
    Friend WithEvents ChkCuentaCorriente As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GrillaProductosFinal As DataGridView
    Friend WithEvents GrillaProductosInicial As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTotalVenta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtComprobante As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents ChkVenta As CheckBox
    Friend WithEvents ChkDevolucion As CheckBox
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Label13 As Label
    Friend WithEvents LblNroComprobante As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotal As DataGridViewTextBoxColumn
    Friend WithEvents Codigo2 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion2 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad2 As DataGridViewTextBoxColumn
End Class
