Public Class FrmVentas
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FrmClientes.LblSeñal.Text = "Agregar"
        FrmClientes.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obtener la fecha actual
        Dim fechaActual As Date = Date.Today

        ' Asignar la fecha actual al control Label
        LblFecha.Text = fechaActual.ToString("dd/MM/yyyy")

        TxtComprobante.Text = 1

        NroComprobante()
        CargaVentasInicial()

        TxtPrecioVenta.ReadOnly = True
        TxtCodigo.ReadOnly = True
        TxtDescripcion.ReadOnly = True
        'TxtComprobante.ReadOnly = True
        TxtNombre.ReadOnly = True
        TxtApellido.ReadOnly = True
        TxtIdCliente.ReadOnly = True
        TxtTotalVenta.ReadOnly = True
        Dim total As Decimal = 0


    End Sub
    Public Sub CargaVentasInicial(Optional ByVal filtroDescripcion As String = "")

        If GrillaProductosInicial.Rows.Count <> 0 Then
            GrillaProductosInicial.Rows.Clear()
        End If

        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "Select Productos.IdProducto, Productos.Descripcion, Productos.PrecioVenta, Productos.Cantidad From Productos Where Productos.Descripcion Like @filtroDescripcion + '%'" '%' + @filtro + '%'"
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader

        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                GrillaProductosInicial.Rows.Add(LectorDatos(0), LectorDatos(1), LectorDatos(2), LectorDatos(3))
            End While
        Else
            'MessageBox.Show("No se encontraron resultados para la búsqueda especificada.", "Búsqueda de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LectorDatos.Close()

    End Sub
    Public Sub NroComprobante()
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT Comprobante FROM Comprobantes WITH (UPDLOCK, ROWLOCK) ORDER BY Comprobante ASC"
        Acciones.Parameters.Clear()
        LectorDatos = Acciones.ExecuteReader
        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                TxtComprobante.Text = LectorDatos(0) + 1
            End While
        Else
            'MessageBox.Show("No se encontraron resultados para la búsqueda especificada.", "Búsqueda de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LectorDatos.Close()
    End Sub
    Private Sub CalcularMultiplicacion()
        ' Verificar si los TextBox contienen números válidos
        Dim numero1 As Integer
        Dim numero2 As Integer
        If Integer.TryParse(TxtPrecioVenta.Text, numero1) AndAlso Integer.TryParse(TxtCantidad.Text, numero2) Then
            If numero2 >= 10 Then
                Dim resultado As Integer = numero1 * numero2
                Dim descuento As Decimal = resultado * 10 / 100
                resultado = resultado - descuento
                TxtTotal.Text = resultado.ToString()
            Else
                If numero2 >= 5 Then
                    Dim resultado As Integer = numero1 * numero2
                    Dim descuento As Decimal = resultado * 5 / 100
                    resultado = resultado - descuento
                    TxtTotal.Text = resultado.ToString()
                Else
                    Dim resultado As Integer = numero1 * numero2
                    TxtTotal.Text = resultado.ToString()
                End If
            End If
        End If
    End Sub

    Private Sub GrillaProductosInicial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProductosInicial.CellDoubleClick
        TxtCodigo.Text = GrillaProductosInicial.CurrentRow.Cells(0).Value
        TxtDescripcion.Text = GrillaProductosInicial.CurrentRow.Cells(1).Value
        TxtPrecioVenta.Text = GrillaProductosInicial.CurrentRow.Cells(2).Value
        TxtCantidad.Select()
        TxtBusqueda.Text = ""
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        ' Permitir solo números y comas (',')
        CalcularMultiplicacion()
    End Sub

    Private Sub TxtPrecioVenta_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecioVenta.TextChanged
        CalcularMultiplicacion()
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Dim Codigo As String = TxtCodigo.Text
        Dim Descripcion As String = TxtDescripcion.Text
        Dim PrecioVenta As String = TxtPrecioVenta.Text
        Dim Cantidad As String = TxtCantidad.Text
        Dim Total As String = TxtTotal.Text
        Dim cantidadIngresada As Decimal = 0
        Dim stockDisponible As Decimal = 0

        If Not Decimal.TryParse(Cantidad, cantidadIngresada) Then
            MsgBox("La cantidad ingresada no es válida", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            TxtCantidad.Text = ""
            Return
        End If
        If Not Decimal.TryParse(GrillaProductosInicial.CurrentRow.Cells(3).Value.ToString(), stockDisponible) Then
            MsgBox("El stock disponible no es válido", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If
        'Verificar la selección de tipo de venta
        If ChkVenta.Checked = False AndAlso ChkDevolucion.Checked = False Then
            MsgBox("Debe seleccionar un tipo de comprobante", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        ' Verificar que se haya ingresado una cantidad
        If String.IsNullOrEmpty(Cantidad) Then
            MsgBox("Debe ingresar una cantidad", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        ' Verificar que se haya ingresado un precio total
        If String.IsNullOrEmpty(Total) Then
            MsgBox("Debe ingresar un precio total", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        ' Verificar la selección de tipo de venta
        If ChkContado.Checked = False AndAlso ChkCuentaCorriente.Checked = False Then
            MsgBox("Debe seleccionar un tipo de venta", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        ' Verificar que se haya ingresado un cliente
        If String.IsNullOrEmpty(TxtIdCliente.Text) Then
            MsgBox("Debe ingresar un cliente", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If
        If Codigo = GrillaProductosInicial.CurrentRow.Cells(0).Value And Cantidad > GrillaProductosInicial.CurrentRow.Cells(3).Value Then
            MsgBox("La cantidad ingresada es mayor al stock disponible", vbOKOnly + vbExclamation, "MENSAJE DEL SISTEMA")
        Else

            Dim cantidadFinal As Integer

            ' Calcular la cantidad final según el tipo de venta seleccionado
            If ChkVenta.Checked Then
                cantidadFinal = stockDisponible - cantidadIngresada
            ElseIf ChkDevolucion.Checked Then
                cantidadFinal = stockDisponible + cantidadIngresada
            End If

            ' Agregar el valor a la celda deseada del DataGridView
            GrillaProductosFinal.Rows.Add(Codigo, Descripcion, Cantidad, PrecioVenta, Total)

            ' Actualizar el stock en el DataGridView inicial
            GrillaProductosInicial.CurrentRow.Cells(3).Value = cantidadFinal

            ' Limpiar el contenido del TextBox después de agregarlo al DataGridView
            TxtCodigo.Text = String.Empty
            TxtDescripcion.Text = String.Empty
            TxtPrecioVenta.Text = String.Empty
            TxtCantidad.Text = String.Empty
            TxtTotal.Text = String.Empty
        End If

        ' Calcular la suma de la columna deseada

        ' Calcular la suma de la columna deseada
        Dim TotalVenta As Decimal = 0
        For Each fila As DataGridViewRow In GrillaProductosFinal.Rows
            Dim precio As Decimal
            If Decimal.TryParse(fila.Cells("PrecioTotal").Value.ToString(), precio) Then
                TotalVenta += precio
            End If
        Next

        ' Mostrar la suma en el TextBox
        TxtTotalVenta.Text = TotalVenta.ToString()

    End Sub

    Private Sub TxtTotalVenta_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalVenta.TextChanged

    End Sub

    Private Sub GrillaProductosFinal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProductosFinal.CellContentClick

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaVentasInicial(TxtBusqueda.Text)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("Se borrara todo lo ingresado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                TxtIdCliente.Text = ""
                TxtNombre.Text = ""
                TxtApellido.Text = ""
                TxtTotalVenta.Text = ""
                GrillaProductosFinal.Rows.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            'CargaVentasInicial()

        End If

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("¿DESEA REGISTRAR LA VENTA?", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Convertir la fecha a un formato válido (suponiendo que el formato es "dd/MM/yyyy")
            Dim fechaVenta As DateTime = DateTime.ParseExact(LblFecha.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            Dim fechaVentaFormateada As String = fechaVenta.ToString("yyyy-MM-dd")
            ' Insertar en Comprobantes
            Acciones.CommandText = "INSERT INTO Comprobantes(Comprobante) VALUES(@Comprobante)"
            Acciones.Parameters.Clear()
            Acciones.Parameters.AddWithValue("@Comprobante", TxtComprobante.Text)
            Acciones.ExecuteNonQuery()


            If ChkVenta.Checked = True Then
                ' Insertar en Ventas o CuentasCorrientes según corresponda
                ' Insertar en Ventas o CuentasCorrientes según corresponda
                If ChkContado.Checked = True Then
                    ' Insertar en Ventas
                    Acciones.CommandText = "INSERT INTO Ventas(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", TxtIdCliente.Text)
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@TipoVenta", "Contado")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Venta")
                    Acciones.Parameters.AddWithValue("@TotalVenta", TxtTotalVenta.Text)
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.ExecuteNonQuery()
                ElseIf ChkCuentaCorriente.Checked = True Then
                    'Insertar en CuentasCorrientes
                    Acciones.CommandText = "INSERT INTO CuentasCorrientes(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta, Saldo) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta, @Saldo)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", TxtIdCliente.Text)
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@TipoVenta", "CuentaCorriente")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Venta")
                    Acciones.Parameters.AddWithValue("@TotalVenta", TxtTotalVenta.Text)
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.Parameters.AddWithValue("@Saldo", TxtTotalVenta.Text)
                    Acciones.ExecuteNonQuery()
                End If
            End If
            If ChkDevolucion.Checked = True Then
                ' Insertar en Ventas o CuentasCorrientes como Devolución
                If ChkCuentaCorriente.Checked = True Then
                    ' Insertar en CuentasCorrientes
                    Acciones.CommandText = "INSERT INTO CuentasCorrientes(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta, Saldo) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta, @Saldo)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", TxtIdCliente.Text)
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@TipoVenta", "CuentaCorriente")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Devolucion")
                    Acciones.Parameters.AddWithValue("@TotalVenta", TxtTotalVenta.Text)
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.Parameters.AddWithValue("@Saldo", TxtTotalVenta.Text)
                    Acciones.ExecuteNonQuery()
                ElseIf ChkContado.Checked = True Then
                    ' Insertar en Ventas
                    Acciones.CommandText = "INSERT INTO Ventas(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", TxtIdCliente.Text)
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@TipoVenta", "Contado")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Devolucion")
                    Acciones.Parameters.AddWithValue("@TotalVenta", TxtTotalVenta.Text)
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.ExecuteNonQuery()
                End If
            End If



            ' Insertar en DetalleVentas
            For Each fila As DataGridViewRow In GrillaProductosFinal.Rows
                Dim query As String = "INSERT INTO DetalleVentas(NroComprobante, Codigo, Descripcion, Cantidad, PrecioUnitario, PrecioTotal) VALUES(@NroComprobante, @Codigo, @Descripcion, @Cantidad, @PrecioUnitario, @PrecioTotal)"
                Acciones.CommandText = query
                Acciones.Parameters.Clear()
                Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                Acciones.Parameters.AddWithValue("@Codigo", fila.Cells(0).Value.ToString())
                Acciones.Parameters.AddWithValue("@Descripcion", fila.Cells(1).Value.ToString())
                Acciones.Parameters.AddWithValue("@Cantidad", Integer.Parse(fila.Cells(2).Value.ToString()))
                Acciones.Parameters.AddWithValue("@PrecioUnitario", fila.Cells(3).Value.ToString())
                Acciones.Parameters.AddWithValue("@PrecioTotal", fila.Cells(4).Value.ToString())
                Acciones.ExecuteNonQuery()
            Next

            ' Actualizar el stock
            For Each fila As DataGridViewRow In GrillaProductosFinal.Rows
                Dim codigo As String = fila.Cells(0).Value.ToString()
                Dim cantidad As Integer = CInt(fila.Cells(2).Value.ToString())

                If ChkVenta.Checked = True Then
                    ' Actualizar cantidad en Productos (restar)
                    Acciones.CommandText = "UPDATE Productos SET Cantidad = Cantidad - @Cantidad WHERE IdProducto = @Codigo"
                Else
                    ' Actualizar cantidad en Productos (sumar)
                    Acciones.CommandText = "UPDATE Productos SET Cantidad = Cantidad + @Cantidad WHERE IdProducto = @Codigo"
                End If

                Acciones.Parameters.Clear()
                Acciones.Parameters.AddWithValue("@Cantidad", cantidad)
                Acciones.Parameters.AddWithValue("@Codigo", codigo)
                Acciones.ExecuteNonQuery()
            Next

            MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            TxtIdCliente.Text = ""
            TxtNombre.Text = ""
            TxtApellido.Text = ""
            TxtTotalVenta.Text = ""
            GrillaProductosFinal.Rows.Clear()
            NroComprobante()
            CargaVentasInicial()



        End If
    End Sub







    Private Sub GrillaProductosInicial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProductosInicial.CellContentClick

    End Sub

    Private Sub ChkContado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkContado.CheckedChanged
        If ChkContado.Checked = True Then
            ChkCuentaCorriente.Checked = False
        End If
    End Sub

    Private Sub ChkCuentaCorriente_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCuentaCorriente.CheckedChanged
        If ChkCuentaCorriente.Checked = True Then
            ChkContado.Checked = False
        End If
    End Sub

    Private Sub ChkVenta_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVenta.CheckedChanged
        If ChkVenta.Checked = True Then
            ChkDevolucion.Checked = False
        End If
    End Sub

    Private Sub ChkDevolucion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDevolucion.CheckedChanged
        If ChkDevolucion.Checked = True Then
            ChkVenta.Checked = False
        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        If GrillaProductosFinal.SelectedRows.Count > 0 Then
            If ChkVenta.Checked Then
                ' Obtener los datos de la fila seleccionada
                Dim filaSeleccionada As DataGridViewRow = GrillaProductosFinal.SelectedRows(0)
                Dim codigo As String = filaSeleccionada.Cells("Codigo").Value.ToString()
                Dim cantidad As Integer = Convert.ToInt32(filaSeleccionada.Cells("Cantidad").Value)

                ' Devolver el stock al DataGridView inicial
                For Each fila As DataGridViewRow In GrillaProductosInicial.Rows
                    If fila.Cells("Codigo2").Value.ToString() = codigo Then
                        Dim stockInicial As Integer = Convert.ToInt32(fila.Cells("Cantidad2").Value)
                        fila.Cells("Cantidad2").Value = stockInicial + cantidad
                        Exit For
                    End If
                Next

                ' Eliminar la fila seleccionada del DataGridView final
                GrillaProductosFinal.Rows.Remove(filaSeleccionada)
            End If
            If ChkDevolucion.Checked Then
                If GrillaProductosFinal.SelectedRows.Count > 0 Then
                    ' Obtener los datos de la fila seleccionada
                    Dim filaSeleccionada As DataGridViewRow = GrillaProductosFinal.SelectedRows(0)
                    Dim codigo As String = filaSeleccionada.Cells("Codigo").Value.ToString()
                    Dim cantidad As Integer = Convert.ToInt32(filaSeleccionada.Cells("Cantidad").Value)

                    ' Devolver el stock al DataGridView inicial
                    For Each fila As DataGridViewRow In GrillaProductosInicial.Rows
                        If fila.Cells("Codigo2").Value.ToString() = codigo Then
                            Dim stockInicial As Integer = Convert.ToInt32(fila.Cells("Cantidad2").Value)
                            fila.Cells("Cantidad2").Value = stockInicial - cantidad
                            Exit For
                        End If
                    Next

                    ' Eliminar la fila seleccionada del DataGridView final
                    GrillaProductosFinal.Rows.Remove(filaSeleccionada)
                End If
            End If
        End If
    End Sub



    Private Sub TxtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTotal.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Dim result As DialogResult = MessageBox.Show("¿DESEA REGISTRAR LA VENTA?", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Convertir la fecha a un formato válido
            Dim fechaVenta As DateTime = DateTime.ParseExact(LblFecha.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            Dim fechaVentaFormateada As String = fechaVenta.ToString("yyyy-MM-dd")
            ' Insertar en Comprobantes
            Acciones.CommandText = "INSERT INTO Comprobantes(Comprobante) VALUES(@Comprobante)"
            Acciones.Parameters.Clear()
            Acciones.Parameters.AddWithValue("@Comprobante", TxtComprobante.Text)
            Acciones.ExecuteNonQuery()


            If ChkVenta.Checked = True Then
                ' Insertar en Ventas o CuentasCorrientes según corresponda
                ' Insertar en Ventas o CuentasCorrientes según corresponda
                If ChkContado.Checked = True Then
                    ' Insertar en Ventas
                    Acciones.CommandText = "INSERT INTO Ventas(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", If(String.IsNullOrEmpty(TxtIdCliente.Text), DBNull.Value, TxtIdCliente.Text))
                    Acciones.Parameters.AddWithValue("@Apellido", If(String.IsNullOrEmpty(TxtApellido.Text), DBNull.Value, TxtApellido.Text))
                    Acciones.Parameters.AddWithValue("@Nombre", If(String.IsNullOrEmpty(TxtNombre.Text), DBNull.Value, TxtNombre.Text))
                    Acciones.Parameters.AddWithValue("@TipoVenta", "Contado")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Venta")
                    Acciones.Parameters.AddWithValue("@TotalVenta", If(String.IsNullOrEmpty(TxtTotalVenta.Text), DBNull.Value, TxtTotalVenta.Text))
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.ExecuteNonQuery()
                ElseIf ChkCuentaCorriente.Checked = True Then
                    'Insertar en CuentasCorrientes
                    Acciones.CommandText = "INSERT INTO CuentasCorrientes(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta, Saldo) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta, @Saldo)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", If(String.IsNullOrEmpty(TxtIdCliente.Text), DBNull.Value, TxtIdCliente.Text))
                    Acciones.Parameters.AddWithValue("@Apellido", If(String.IsNullOrEmpty(TxtApellido.Text), DBNull.Value, TxtApellido.Text))
                    Acciones.Parameters.AddWithValue("@Nombre", If(String.IsNullOrEmpty(TxtNombre.Text), DBNull.Value, TxtNombre.Text))
                    Acciones.Parameters.AddWithValue("@TipoVenta", "CuentaCorriente")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Venta")
                    Acciones.Parameters.AddWithValue("@TotalVenta", If(String.IsNullOrEmpty(TxtTotalVenta.Text), DBNull.Value, TxtTotalVenta.Text))
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.Parameters.AddWithValue("@Saldo", TxtTotalVenta.Text)
                    Acciones.ExecuteNonQuery()
                End If
            End If
            If ChkDevolucion.Checked = True Then
                ' Insertar en Ventas o CuentasCorrientes como Devolución
                If ChkCuentaCorriente.Checked = True Then
                    ' Insertar en CuentasCorrientes
                    Acciones.CommandText = "INSERT INTO CuentasCorrientes(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta, Saldo) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta, @Saldo)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", If(String.IsNullOrEmpty(TxtIdCliente.Text), DBNull.Value, TxtIdCliente.Text))
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@TipoVenta", "CuentaCorriente")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Devolucion")
                    Acciones.Parameters.AddWithValue("@TotalVenta", TxtTotalVenta.Text)
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.Parameters.AddWithValue("@Saldo", TxtTotalVenta.Text)
                    Acciones.ExecuteNonQuery()
                ElseIf ChkContado.Checked = True Then
                    ' Insertar en Ventas
                    Acciones.CommandText = "INSERT INTO Ventas(NroComprobante, IdCliente, Apellido, Nombre, TipoVenta, TipoComprobante, TotalVenta, FechaVenta) VALUES(@NroComprobante, @IdCliente, @Apellido, @Nombre, @TipoVenta, @TipoComprobante, @TotalVenta, @FechaVenta)"
                    Acciones.Parameters.Clear()
                    Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                    Acciones.Parameters.AddWithValue("@IdCliente", If(String.IsNullOrEmpty(TxtIdCliente.Text), DBNull.Value, TxtIdCliente.Text))
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@TipoVenta", "Contado")
                    Acciones.Parameters.AddWithValue("@TipoComprobante", "Devolucion")
                    Acciones.Parameters.AddWithValue("@TotalVenta", TxtTotalVenta.Text)
                    Acciones.Parameters.AddWithValue("@FechaVenta", fechaVentaFormateada)
                    Acciones.ExecuteNonQuery()
                End If
            End If



            ' Insertar en DetalleVentas
            For Each fila As DataGridViewRow In GrillaProductosFinal.Rows
                Dim query As String = "INSERT INTO DetalleVentas(NroComprobante, Codigo, Descripcion, Cantidad, PrecioUnitario, PrecioTotal) VALUES(@NroComprobante, @Codigo, @Descripcion, @Cantidad, @PrecioUnitario, @PrecioTotal)"
                Acciones.CommandText = query
                Acciones.Parameters.Clear()
                Acciones.Parameters.AddWithValue("@NroComprobante", TxtComprobante.Text)
                Acciones.Parameters.AddWithValue("@Codigo", fila.Cells(0).Value.ToString())
                Acciones.Parameters.AddWithValue("@Descripcion", fila.Cells(1).Value.ToString())
                Acciones.Parameters.AddWithValue("@Cantidad", Integer.Parse(fila.Cells(2).Value.ToString()))
                Acciones.Parameters.AddWithValue("@PrecioUnitario", fila.Cells(3).Value.ToString())
                Acciones.Parameters.AddWithValue("@PrecioTotal", fila.Cells(4).Value.ToString())
                Acciones.ExecuteNonQuery()
            Next

            ' Actualizar el stock
            For Each fila As DataGridViewRow In GrillaProductosFinal.Rows
                Dim codigo As String = fila.Cells(0).Value.ToString()
                Dim cantidad As Integer = CInt(fila.Cells(2).Value.ToString())

                If ChkVenta.Checked = True Then
                    ' Actualizar cantidad en Productos (restar)
                    Acciones.CommandText = "UPDATE Productos SET Cantidad = Cantidad - @Cantidad WHERE IdProducto = @Codigo"
                Else
                    ' Actualizar cantidad en Productos (sumar)
                    Acciones.CommandText = "UPDATE Productos SET Cantidad = Cantidad + @Cantidad WHERE IdProducto = @Codigo"
                End If

                Acciones.Parameters.Clear()
                Acciones.Parameters.AddWithValue("@Cantidad", cantidad)
                Acciones.Parameters.AddWithValue("@Codigo", codigo)
                Acciones.ExecuteNonQuery()
            Next

            MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            TxtIdCliente.Text = ""
            TxtNombre.Text = ""
            TxtApellido.Text = ""
            TxtTotalVenta.Text = ""
            GrillaProductosFinal.Rows.Clear()
            NroComprobante()
            CargaVentasInicial()



        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        If GrillaProductosFinal.SelectedRows.Count > 0 Then
            If ChkVenta.Checked Then
                ' Obtener los datos de la fila seleccionada
                Dim filaSeleccionada As DataGridViewRow = GrillaProductosFinal.SelectedRows(0)
                Dim codigo As String = filaSeleccionada.Cells("Codigo").Value.ToString()
                Dim cantidad As Integer = Convert.ToInt32(filaSeleccionada.Cells("Cantidad").Value)

                ' Devolver el stock al DataGridView inicial
                For Each fila As DataGridViewRow In GrillaProductosInicial.Rows
                    If fila.Cells("Codigo2").Value.ToString() = codigo Then
                        Dim stockInicial As Integer = Convert.ToInt32(fila.Cells("Cantidad2").Value)
                        fila.Cells("Cantidad2").Value = stockInicial + cantidad
                        Exit For
                    End If
                Next

                ' Eliminar la fila seleccionada del DataGridView final
                GrillaProductosFinal.Rows.Remove(filaSeleccionada)
            End If
            If ChkDevolucion.Checked Then
                If GrillaProductosFinal.SelectedRows.Count > 0 Then
                    ' Obtener los datos de la fila seleccionada
                    Dim filaSeleccionada As DataGridViewRow = GrillaProductosFinal.SelectedRows(0)
                    Dim codigo As String = filaSeleccionada.Cells("Codigo").Value.ToString()
                    Dim cantidad As Integer = Convert.ToInt32(filaSeleccionada.Cells("Cantidad").Value)

                    ' Devolver el stock al DataGridView inicial
                    For Each fila As DataGridViewRow In GrillaProductosInicial.Rows
                        If fila.Cells("Codigo2").Value.ToString() = codigo Then
                            Dim stockInicial As Integer = Convert.ToInt32(fila.Cells("Cantidad2").Value)
                            fila.Cells("Cantidad2").Value = stockInicial - cantidad
                            Exit For
                        End If
                    Next

                    ' Eliminar la fila seleccionada del DataGridView final
                    GrillaProductosFinal.Rows.Remove(filaSeleccionada)
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("Se borrara todo lo ingresado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                TxtIdCliente.Text = ""
                TxtNombre.Text = ""
                TxtApellido.Text = ""
                TxtTotalVenta.Text = ""
                GrillaProductosFinal.Rows.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim Codigo As String = TxtCodigo.Text
        Dim Descripcion As String = TxtDescripcion.Text
        Dim PrecioVenta As String = TxtPrecioVenta.Text
        Dim Cantidad As String = TxtCantidad.Text
        Dim Total As String = TxtTotal.Text
        Dim cantidadIngresada As Decimal = 0
        Dim stockDisponible As Decimal = 0

        If Not Decimal.TryParse(Cantidad, cantidadIngresada) Then
            MsgBox("La cantidad ingresada no es válida", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            TxtCantidad.Text = ""
            Return
        End If
        If Not Decimal.TryParse(GrillaProductosInicial.CurrentRow.Cells(3).Value.ToString(), stockDisponible) Then
            MsgBox("El stock disponible no es válido", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If
        'Verificar la selección de tipo de venta
        If ChkVenta.Checked = False AndAlso ChkDevolucion.Checked = False Then
            MsgBox("Debe seleccionar un tipo de comprobante", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        ' Verificar que se haya ingresado una cantidad
        If String.IsNullOrEmpty(Cantidad) Then
            MsgBox("Debe ingresar una cantidad", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        ' Verificar que se haya ingresado un precio total
        If String.IsNullOrEmpty(Total) Then
            MsgBox("Debe ingresar un precio total", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        ' Verificar la selección de tipo de venta
        If ChkContado.Checked = False AndAlso ChkCuentaCorriente.Checked = False Then
            MsgBox("Debe seleccionar un tipo de venta", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Return
        End If

        Dim cantidadFinal As Integer

            ' Calcular la cantidad final según el tipo de venta seleccionado
            If ChkVenta.Checked Then
                cantidadFinal = stockDisponible - cantidadIngresada
            ElseIf ChkDevolucion.Checked Then
                cantidadFinal = stockDisponible + cantidadIngresada
            End If

            ' Agregar el valor a la celda deseada del DataGridView
            GrillaProductosFinal.Rows.Add(Codigo, Descripcion, Cantidad, PrecioVenta, Total)

            ' Actualizar el stock en el DataGridView inicial
            GrillaProductosInicial.CurrentRow.Cells(3).Value = cantidadFinal

            ' Limpiar el contenido del TextBox después de agregarlo al DataGridView
            TxtCodigo.Text = String.Empty
            TxtDescripcion.Text = String.Empty
            TxtPrecioVenta.Text = String.Empty
            TxtCantidad.Text = String.Empty
            TxtTotal.Text = String.Empty


        ' Calcular la suma de la columna deseada

        ' Calcular la suma de la columna deseada
        Dim TotalVenta As Decimal = 0
        For Each fila As DataGridViewRow In GrillaProductosFinal.Rows
            Dim precio As Decimal
            If Decimal.TryParse(fila.Cells("PrecioTotal").Value.ToString(), precio) Then
                TotalVenta += precio
            End If
        Next

        ' Mostrar la suma en el TextBox
        TxtTotalVenta.Text = TotalVenta.ToString()

    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    Private Sub ToolStripSeparator6_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator6.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles LblNroComprobante.Click

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        FrmClientes.LblSeñal.Text = "Agregar"
        FrmClientes.Show()
    End Sub
End Class