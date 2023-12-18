<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedor))
        Me.GrillaProveedores = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.ChkInactivo = New System.Windows.Forms.CheckBox()
        Me.ChkTodos = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombreyapellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondicionIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCiudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCondicionIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaProveedores
        '
        Me.GrillaProveedores.AllowUserToAddRows = False
        Me.GrillaProveedores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedor, Me.Nombreyapellido, Me.Nombre, Me.Apellido, Me.Cuit, Me.Direccion, Me.Telefono, Me.Mail, Me.Ciudad, Me.Provincia, Me.CondicionIva, Me.Contacto, Me.Observaciones, Me.IdCiudad, Me.IdCondicionIva, Me.Activo})
        Me.GrillaProveedores.Location = New System.Drawing.Point(12, 116)
        Me.GrillaProveedores.Name = "GrillaProveedores"
        Me.GrillaProveedores.Size = New System.Drawing.Size(1147, 357)
        Me.GrillaProveedores.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Búsqueda por Apellido y Nombre"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(340, 90)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(684, 20)
        Me.TxtBusqueda.TabIndex = 6
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkActivo.Location = New System.Drawing.Point(1103, 69)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(56, 17)
        Me.ChkActivo.TabIndex = 7
        Me.ChkActivo.Text = "Activo"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'ChkInactivo
        '
        Me.ChkInactivo.AutoSize = True
        Me.ChkInactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkInactivo.Location = New System.Drawing.Point(1095, 90)
        Me.ChkInactivo.Name = "ChkInactivo"
        Me.ChkInactivo.Size = New System.Drawing.Size(64, 17)
        Me.ChkInactivo.TabIndex = 8
        Me.ChkInactivo.Text = "Inactivo"
        Me.ChkInactivo.UseVisualStyleBackColor = True
        '
        'ChkTodos
        '
        Me.ChkTodos.AutoSize = True
        Me.ChkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkTodos.Checked = True
        Me.ChkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTodos.Location = New System.Drawing.Point(1103, 46)
        Me.ChkTodos.Name = "ChkTodos"
        Me.ChkTodos.Size = New System.Drawing.Size(56, 17)
        Me.ChkTodos.TabIndex = 9
        Me.ChkTodos.Text = "Todos"
        Me.ChkTodos.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton9})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(243, 63)
        Me.ToolStrip2.TabIndex = 10
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
        'IdProveedor
        '
        Me.IdProveedor.HeaderText = "Num de Proveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.Visible = False
        '
        'Nombreyapellido
        '
        Me.Nombreyapellido.HeaderText = "Apellido y Nombre"
        Me.Nombreyapellido.Name = "Nombreyapellido"
        Me.Nombreyapellido.Width = 200
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = False
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Visible = False
        '
        'Cuit
        '
        Me.Cuit.HeaderText = "Cuit"
        Me.Cuit.Name = "Cuit"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'Mail
        '
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        '
        'Ciudad
        '
        Me.Ciudad.HeaderText = "Ciudad"
        Me.Ciudad.Name = "Ciudad"
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        '
        'CondicionIva
        '
        Me.CondicionIva.HeaderText = "CondicionIva"
        Me.CondicionIva.Name = "CondicionIva"
        '
        'Contacto
        '
        Me.Contacto.HeaderText = "Contacto"
        Me.Contacto.Name = "Contacto"
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        '
        'IdCiudad
        '
        Me.IdCiudad.HeaderText = "IdCiudad"
        Me.IdCiudad.Name = "IdCiudad"
        Me.IdCiudad.Visible = False
        '
        'IdCondicionIva
        '
        Me.IdCondicionIva.HeaderText = "IdCondicionIva"
        Me.IdCondicionIva.Name = "IdCondicionIva"
        Me.IdCondicionIva.Visible = False
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = False
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1170, 485)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ChkTodos)
        Me.Controls.Add(Me.ChkInactivo)
        Me.Controls.Add(Me.ChkActivo)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaProveedores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDORES                                              "
        CType(Me.GrillaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaProveedores As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents ChkInactivo As CheckBox
    Friend WithEvents ChkTodos As CheckBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Nombreyapellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Cuit As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Mail As DataGridViewTextBoxColumn
    Friend WithEvents Ciudad As DataGridViewTextBoxColumn
    Friend WithEvents Provincia As DataGridViewTextBoxColumn
    Friend WithEvents CondicionIva As DataGridViewTextBoxColumn
    Friend WithEvents Contacto As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents IdCiudad As DataGridViewTextBoxColumn
    Friend WithEvents IdCondicionIva As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
End Class
