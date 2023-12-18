<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCondicionIva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCondicionIva))
        Me.GrillaCondicionIva = New System.Windows.Forms.DataGridView()
        Me.IdCondicionIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ChkTodos = New System.Windows.Forms.CheckBox()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.ChkInactivo = New System.Windows.Forms.CheckBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        CType(Me.GrillaCondicionIva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaCondicionIva
        '
        Me.GrillaCondicionIva.AllowUserToAddRows = False
        Me.GrillaCondicionIva.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrillaCondicionIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCondicionIva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCondicionIva, Me.Descripcion, Me.Activo})
        Me.GrillaCondicionIva.Location = New System.Drawing.Point(12, 135)
        Me.GrillaCondicionIva.Name = "GrillaCondicionIva"
        Me.GrillaCondicionIva.Size = New System.Drawing.Size(648, 372)
        Me.GrillaCondicionIva.TabIndex = 4
        '
        'IdCondicionIva
        '
        Me.IdCondicionIva.HeaderText = "Num Condicion Iva"
        Me.IdCondicionIva.Name = "IdCondicionIva"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Nombre"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 500
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Búsqueda por Nombre"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(240, 109)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(285, 20)
        Me.TxtBusqueda.TabIndex = 8
        '
        'ChkTodos
        '
        Me.ChkTodos.AutoSize = True
        Me.ChkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkTodos.Checked = True
        Me.ChkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTodos.Location = New System.Drawing.Point(604, 66)
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
        Me.ChkActivo.Location = New System.Drawing.Point(604, 89)
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
        Me.ChkInactivo.Location = New System.Drawing.Point(596, 112)
        Me.ChkInactivo.Name = "ChkInactivo"
        Me.ChkInactivo.Size = New System.Drawing.Size(64, 17)
        Me.ChkInactivo.TabIndex = 13
        Me.ChkInactivo.Text = "Inactivo"
        Me.ChkInactivo.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripSeparator5, Me.ToolStripButton7, Me.ToolStripSeparator6, Me.ToolStripButton8, Me.ToolStripSeparator7, Me.ToolStripButton9})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(670, 63)
        Me.ToolStrip2.TabIndex = 19
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
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        'FrmCondicionIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 560)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ChkInactivo)
        Me.Controls.Add(Me.ChkActivo)
        Me.Controls.Add(Me.ChkTodos)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaCondicionIva)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCondicionIva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONDICIÓN IVA"
        CType(Me.GrillaCondicionIva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaCondicionIva As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents IdCondicionIva As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents ChkTodos As CheckBox
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents ChkInactivo As CheckBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
End Class
