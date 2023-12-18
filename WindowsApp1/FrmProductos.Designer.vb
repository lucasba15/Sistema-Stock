<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Me.GrillaProductos = New System.Windows.Forms.DataGridView()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.ChkInactivo = New System.Windows.Forms.CheckBox()
        Me.ChkTodos = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodAlternativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActualizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaProductos
        '
        Me.GrillaProductos.AllowUserToAddRows = False
        Me.GrillaProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.Proveedor, Me.Rubro, Me.Estado, Me.Descripcion, Me.CodAlternativo, Me.Costo, Me.FechaCarga, Me.FechaActualizacion, Me.Imagen, Me.Observaciones, Me.IdProveedor, Me.IdRubro, Me.IdEstado, Me.PrecioVenta, Me.Cantidad, Me.Activo})
        Me.GrillaProductos.Location = New System.Drawing.Point(17, 136)
        Me.GrillaProductos.Name = "GrillaProductos"
        Me.GrillaProductos.Size = New System.Drawing.Size(1121, 325)
        Me.GrillaProductos.TabIndex = 2
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(245, 114)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(285, 20)
        Me.TxtBusqueda.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Búsqueda por Nombre"
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkActivo.Location = New System.Drawing.Point(1082, 93)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChkActivo.TabIndex = 6
        Me.ChkActivo.Text = "Activo"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'ChkInactivo
        '
        Me.ChkInactivo.AutoSize = True
        Me.ChkInactivo.CheckAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ChkInactivo.Location = New System.Drawing.Point(1074, 116)
        Me.ChkInactivo.Name = "ChkInactivo"
        Me.ChkInactivo.Size = New System.Drawing.Size(64, 17)
        Me.ChkInactivo.TabIndex = 7
        Me.ChkInactivo.Text = "Inactivo"
        Me.ChkInactivo.UseVisualStyleBackColor = True
        '
        'ChkTodos
        '
        Me.ChkTodos.AutoSize = True
        Me.ChkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkTodos.Checked = True
        Me.ChkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTodos.Location = New System.Drawing.Point(1082, 70)
        Me.ChkTodos.Name = "ChkTodos"
        Me.ChkTodos.Size = New System.Drawing.Size(56, 17)
        Me.ChkTodos.TabIndex = 8
        Me.ChkTodos.Text = "Todos"
        Me.ChkTodos.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripSeparator5, Me.BtnModificar, Me.ToolStripSeparator6, Me.ToolStripButton8, Me.ToolStripSeparator7, Me.ToolStripButton9})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1157, 63)
        Me.ToolStrip2.TabIndex = 16
        Me.ToolStrip2.Text = "ToolStrip2"
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
        Me.ToolStripButton6.Text = "Agregar"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 63)
        '
        'BtnModificar
        '
        Me.BtnModificar.AutoSize = False
        Me.BtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(60, 60)
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 63)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton8.Text = "Eliminar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 63)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.AutoSize = False
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(60, 60)
        Me.ToolStripButton9.Text = "Salir"
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "Num de          Producto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.Visible = False
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 170
        '
        'Rubro
        '
        Me.Rubro.HeaderText = "Rubro"
        Me.Rubro.Name = "Rubro"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Nombre"
        Me.Descripcion.Name = "Descripcion"
        '
        'CodAlternativo
        '
        Me.CodAlternativo.HeaderText = "Cod Alternativo"
        Me.CodAlternativo.Name = "CodAlternativo"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.Visible = False
        '
        'FechaCarga
        '
        Me.FechaCarga.HeaderText = "Fecha Carga"
        Me.FechaCarga.Name = "FechaCarga"
        '
        'FechaActualizacion
        '
        Me.FechaActualizacion.HeaderText = "Fecha Actualizacion"
        Me.FechaActualizacion.Name = "FechaActualizacion"
        '
        'Imagen
        '
        Me.Imagen.FillWeight = 400.0!
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        '
        'IdProveedor
        '
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.Visible = False
        '
        'IdRubro
        '
        Me.IdRubro.HeaderText = "IdRubro"
        Me.IdRubro.Name = "IdRubro"
        Me.IdRubro.Visible = False
        '
        'IdEstado
        '
        Me.IdEstado.HeaderText = "IdEstado"
        Me.IdEstado.Name = "IdEstado"
        Me.IdEstado.Visible = False
        '
        'PrecioVenta
        '
        Me.PrecioVenta.HeaderText = "PrecioVenta"
        Me.PrecioVenta.Name = "PrecioVenta"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = False
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 493)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ChkTodos)
        Me.Controls.Add(Me.ChkInactivo)
        Me.Controls.Add(Me.ChkActivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.GrillaProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOS"
        CType(Me.GrillaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaProductos As DataGridView
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents ChkInactivo As CheckBox
    Friend WithEvents ChkTodos As CheckBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents BtnModificar As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Rubro As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents CodAlternativo As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents FechaCarga As DataGridViewTextBoxColumn
    Friend WithEvents FechaActualizacion As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewImageColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents IdRubro As DataGridViewTextBoxColumn
    Friend WithEvents IdEstado As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
End Class
