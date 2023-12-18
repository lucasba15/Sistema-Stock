<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.GrillaClientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ChkTodos = New System.Windows.Forms.CheckBox()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.ChkInactivo = New System.Windows.Forms.CheckBox()
        Me.LblSeñal = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.BtnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoYNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaClientes
        '
        Me.GrillaClientes.AllowUserToAddRows = False
        Me.GrillaClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCliente, Me.ApellidoYNombre, Me.Apellido, Me.Nombre, Me.Direccion, Me.Telefono, Me.Mail, Me.TipoCliente, Me.Activo})
        Me.GrillaClientes.Location = New System.Drawing.Point(9, 139)
        Me.GrillaClientes.Name = "GrillaClientes"
        Me.GrillaClientes.Size = New System.Drawing.Size(1096, 323)
        Me.GrillaClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Búsqueda por Apellido y Nombre"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(340, 113)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(572, 20)
        Me.TxtBusqueda.TabIndex = 8
        '
        'ChkTodos
        '
        Me.ChkTodos.AutoSize = True
        Me.ChkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkTodos.Checked = True
        Me.ChkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTodos.Location = New System.Drawing.Point(1049, 70)
        Me.ChkTodos.Name = "ChkTodos"
        Me.ChkTodos.Size = New System.Drawing.Size(56, 17)
        Me.ChkTodos.TabIndex = 11
        Me.ChkTodos.Text = "Todos"
        Me.ChkTodos.UseVisualStyleBackColor = True
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkActivo.Location = New System.Drawing.Point(1049, 93)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChkActivo.TabIndex = 12
        Me.ChkActivo.Text = "Activo"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'ChkInactivo
        '
        Me.ChkInactivo.AutoSize = True
        Me.ChkInactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkInactivo.Location = New System.Drawing.Point(1041, 116)
        Me.ChkInactivo.Name = "ChkInactivo"
        Me.ChkInactivo.Size = New System.Drawing.Size(64, 17)
        Me.ChkInactivo.TabIndex = 13
        Me.ChkInactivo.Text = "Inactivo"
        Me.ChkInactivo.UseVisualStyleBackColor = True
        '
        'LblSeñal
        '
        Me.LblSeñal.AutoSize = True
        Me.LblSeñal.Location = New System.Drawing.Point(285, 71)
        Me.LblSeñal.Name = "LblSeñal"
        Me.LblSeñal.Size = New System.Drawing.Size(34, 13)
        Me.LblSeñal.TabIndex = 14
        Me.LblSeñal.Text = "Señal"
        Me.LblSeñal.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAgregar, Me.ToolStripSeparator5, Me.ToolStripButton7, Me.ToolStripSeparator6, Me.ToolStripButton8, Me.ToolStripSeparator7, Me.ToolStripButton9})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1112, 63)
        Me.ToolStrip2.TabIndex = 15
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AutoSize = False
        Me.BtnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(60, 60)
        Me.BtnAgregar.Text = "Agregar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 63)
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
        Me.ToolStripButton7.Text = "Modificar"
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
        'IdCliente
        '
        Me.IdCliente.HeaderText = "NroCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.Visible = False
        Me.IdCliente.Width = 300
        '
        'ApellidoYNombre
        '
        Me.ApellidoYNombre.HeaderText = "Apellido y Nombre"
        Me.ApellidoYNombre.Name = "ApellidoYNombre"
        Me.ApellidoYNombre.Width = 300
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = False
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Width = 250
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Width = 200
        '
        'Mail
        '
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        Me.Mail.Width = 300
        '
        'TipoCliente
        '
        Me.TipoCliente.HeaderText = "Tipo de Cliente"
        Me.TipoCliente.Name = "TipoCliente"
        Me.TipoCliente.Visible = False
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = False
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 474)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.LblSeñal)
        Me.Controls.Add(Me.ChkInactivo)
        Me.Controls.Add(Me.ChkActivo)
        Me.Controls.Add(Me.ChkTodos)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES"
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrillaClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents ChkTodos As CheckBox
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents ChkInactivo As CheckBox
    Friend WithEvents LblSeñal As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents BtnAgregar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoYNombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Mail As DataGridViewTextBoxColumn
    Friend WithEvents TipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
End Class
