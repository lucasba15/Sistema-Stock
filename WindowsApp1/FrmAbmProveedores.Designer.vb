<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbmProveedores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSeñal = New System.Windows.Forms.Label()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtContacto = New System.Windows.Forms.TextBox()
        Me.TxtCondicionIva = New System.Windows.Forms.TextBox()
        Me.TxtProvincia = New System.Windows.Forms.TextBox()
        Me.TxtIdCiudad = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.TxtIdCondicionIva = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Num de Proveedor"
        '
        'LblSeñal
        '
        Me.LblSeñal.AutoSize = True
        Me.LblSeñal.Location = New System.Drawing.Point(574, 121)
        Me.LblSeñal.Name = "LblSeñal"
        Me.LblSeñal.Size = New System.Drawing.Size(34, 13)
        Me.LblSeñal.TabIndex = 69
        Me.LblSeñal.Text = "Señal"
        Me.LblSeñal.Visible = False
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Enabled = False
        Me.TxtIdProveedor.Location = New System.Drawing.Point(16, 98)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.Size = New System.Drawing.Size(143, 20)
        Me.TxtIdProveedor.TabIndex = 0
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(16, 144)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(372, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Apellido"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(12, 261)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(84, 20)
        Me.LblDireccion.TabIndex = 74
        Me.LblDireccion.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Teléfono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 537)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Contacto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Provincia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 20)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Condición Iva"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 583)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 20)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Observaciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 20)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Cuit"
        '
        'TxtContacto
        '
        Me.TxtContacto.Location = New System.Drawing.Point(16, 560)
        Me.TxtContacto.Name = "TxtContacto"
        Me.TxtContacto.Size = New System.Drawing.Size(372, 20)
        Me.TxtContacto.TabIndex = 10
        '
        'TxtCondicionIva
        '
        Me.TxtCondicionIva.Enabled = False
        Me.TxtCondicionIva.Location = New System.Drawing.Point(126, 517)
        Me.TxtCondicionIva.Name = "TxtCondicionIva"
        Me.TxtCondicionIva.Size = New System.Drawing.Size(262, 20)
        Me.TxtCondicionIva.TabIndex = 85
        '
        'TxtProvincia
        '
        Me.TxtProvincia.Location = New System.Drawing.Point(16, 468)
        Me.TxtProvincia.Name = "TxtProvincia"
        Me.TxtProvincia.Size = New System.Drawing.Size(372, 20)
        Me.TxtProvincia.TabIndex = 8
        '
        'TxtIdCiudad
        '
        Me.TxtIdCiudad.Enabled = False
        Me.TxtIdCiudad.Location = New System.Drawing.Point(16, 422)
        Me.TxtIdCiudad.Name = "TxtIdCiudad"
        Me.TxtIdCiudad.Size = New System.Drawing.Size(61, 20)
        Me.TxtIdCiudad.TabIndex = 87
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(16, 376)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(372, 20)
        Me.TxtMail.TabIndex = 6
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(16, 330)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(372, 20)
        Me.TxtTelefono.TabIndex = 5
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(16, 284)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(372, 20)
        Me.TxtDireccion.TabIndex = 4
        '
        'TxtCuit
        '
        Me.TxtCuit.Location = New System.Drawing.Point(16, 236)
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(372, 20)
        Me.TxtCuit.TabIndex = 3
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(16, 190)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(372, 20)
        Me.TxtApellido.TabIndex = 2
        '
        'Buscar
        '
        Me.Buscar.BackgroundImage = CType(resources.GetObject("Buscar.BackgroundImage"), System.Drawing.Image)
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Buscar.Location = New System.Drawing.Point(83, 415)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(37, 27)
        Me.Buscar.TabIndex = 7
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Enabled = False
        Me.TxtCiudad.Location = New System.Drawing.Point(126, 422)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(262, 20)
        Me.TxtCiudad.TabIndex = 94
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(16, 606)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(658, 73)
        Me.TxtObservaciones.TabIndex = 11
        '
        'TxtIdCondicionIva
        '
        Me.TxtIdCondicionIva.Enabled = False
        Me.TxtIdCondicionIva.Location = New System.Drawing.Point(16, 518)
        Me.TxtIdCondicionIva.Name = "TxtIdCondicionIva"
        Me.TxtIdCondicionIva.Size = New System.Drawing.Size(61, 20)
        Me.TxtIdCondicionIva.TabIndex = 97
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox2.Location = New System.Drawing.Point(311, 75)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(77, 24)
        Me.CheckBox2.TabIndex = 99
        Me.CheckBox2.Text = "Activo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(679, 63)
        Me.ToolStrip2.TabIndex = 12
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
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(83, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmAbmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 688)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TxtIdCondicionIva)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtCuit)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtIdCiudad)
        Me.Controls.Add(Me.TxtProvincia)
        Me.Controls.Add(Me.TxtCondicionIva)
        Me.Controls.Add(Me.TxtContacto)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtIdProveedor)
        Me.Controls.Add(Me.LblSeñal)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAbmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - PROVEEDORES"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSeñal As Label
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtContacto As TextBox
    Friend WithEvents TxtCondicionIva As TextBox
    Friend WithEvents TxtProvincia As TextBox
    Friend WithEvents TxtIdCiudad As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtCuit As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents TxtIdCondicionIva As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Button2 As Button
End Class
