Imports System.IO
Public Class FrmProductos

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        FrmAbmProductos.LblSeñal.Text = "Agregar"
        FrmAbmProductos.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProductos.CellContentClick

    End Sub
    'Private dataTable As New DataTable()
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaProductos()
        GrillaProductos.Columns("FechaCarga").DefaultCellStyle.Format = "dd/MM/yyyy"
        GrillaProductos.Columns("FechaActualizacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        GrillaProductos.Columns("Imagen").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        GrillaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaProductos(TxtBusqueda.Text)
    End Sub

    Public Sub CargaProductos(Optional ByVal filtroDescripcion As String = "")

        If GrillaProductos.Rows.Count <> 0 Then
            GrillaProductos.Rows.Clear()
        End If

        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT Productos.IdProducto, Productos.IdProveedor, Productos.IdRubro, Productos.IdEstado, Productos.Descripcion, Productos.CodAlternativo, Productos.Costo, Productos.FechaCarga, Productos.FechaActualizacion, Productos.Imagen, Productos.Observaciones, Productos.Activo, Productos.Cantidad, Productos.PrecioVenta, Proveedores.Nombre, Proveedores.Apellido, Rubros.Descripcion, Estados.Descripcion FROM Productos LEFT JOIN Proveedores ON Productos.IdProveedor = Proveedores.IdProveedor LEFT JOIN Rubros ON Productos.IdRubro = Rubros.IdRubro LEFT JOIN Estados ON Productos.IdEstado = Estados.IdEstado WHERE Productos.Descripcion LIKE @filtroDescripcion + '%'"
        If ChkActivo.Checked And Not ChkInactivo.Checked Then
            Acciones.CommandText += " AND Productos.Activo = 1"
        ElseIf ChkInactivo.Checked And Not ChkActivo.Checked Then
            Acciones.CommandText += " AND Productos.Activo = 0"
        End If
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader

        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                Dim imagenBytes() As Byte
                Dim imagen As Image = Nothing

                If Not LectorDatos.IsDBNull(LectorDatos.GetOrdinal("Imagen")) Then
                    imagenBytes = DirectCast(LectorDatos("Imagen"), Byte())
                    Dim ms As New MemoryStream(imagenBytes)
                    imagen = Image.FromStream(ms)
                End If

                GrillaProductos.Rows.Add(LectorDatos(0), LectorDatos(15) & " " & LectorDatos(14), LectorDatos(16), LectorDatos(17), LectorDatos(4), LectorDatos(5), LectorDatos(6), LectorDatos(7), LectorDatos(8), imagen, LectorDatos(10), LectorDatos(1), LectorDatos(2), LectorDatos(3), LectorDatos(13), LectorDatos(12), LectorDatos(11))
            End While
        Else

            'MessageBox.Show("No se encontraron resultados para la búsqueda especificada.", "Búsqueda de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LectorDatos.Close()

    End Sub




    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        FrmAbmProductos.LblSeñal.Text = "Modificar"
        FrmAbmProductos.TxtIdProducto.Text = GrillaProductos.CurrentRow.Cells(0).Value
        FrmAbmProductos.TxtIdProveedor.Text = GrillaProductos.CurrentRow.Cells(11).Value
        FrmAbmProductos.TxtIdRubro.Text = GrillaProductos.CurrentRow.Cells(12).Value
        FrmAbmProductos.TxtIdEstado.Text = GrillaProductos.CurrentRow.Cells(13).Value
        FrmAbmProductos.TxtProveedor.Text = GrillaProductos.CurrentRow.Cells(1).Value
        FrmAbmProductos.TxtRubro.Text = GrillaProductos.CurrentRow.Cells(2).Value
        FrmAbmProductos.TxtEstado.Text = GrillaProductos.CurrentRow.Cells(3).Value
        FrmAbmProductos.TxtDescripcion.Text = GrillaProductos.CurrentRow.Cells(4).Value
        FrmAbmProductos.TxtCodAlternativo.Text = GrillaProductos.CurrentRow.Cells(5).Value
        FrmAbmProductos.TxtCosto.Text = GrillaProductos.CurrentRow.Cells(6).Value
        FrmAbmProductos.DtFechaCarga.Text = GrillaProductos.CurrentRow.Cells(7).Value
        FrmAbmProductos.DtFechaActualizacion.Text = GrillaProductos.CurrentRow.Cells(8).Value
        FrmAbmProductos.PictureBox1.Image = GrillaProductos.CurrentRow.Cells(9).Value
        FrmAbmProductos.TxtObservaciones.Text = GrillaProductos.CurrentRow.Cells(10).Value
        FrmAbmProductos.TxtPrecioVenta.Text = GrillaProductos.CurrentRow.Cells(14).Value
        FrmAbmProductos.ChkActivo.Checked = GrillaProductos.CurrentRow.Cells(16).Value
        FrmAbmProductos.TxtCantidad.Text = GrillaProductos.CurrentRow.Cells(15).Value
        FrmAbmProductos.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "delete from Productos Where IdProducto = " & Val(GrillaProductos.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaProductos()

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged

    End Sub

    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked Then
            ChkActivo.Checked = False
            ChkInactivo.Checked = False
            CargaProductos(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged
        If ChkActivo.Checked Then
            ChkInactivo.Checked = False
            ChkTodos.Checked = False
            CargaProductos(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged
        If ChkInactivo.Checked Then
            ChkActivo.Checked = False
            ChkTodos.Checked = False
            CargaProductos(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FrmAbmProductos.LblSeñal.Text = "Agregar"
        FrmAbmProductos.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmAbmProductos.LblSeñal.Text = "Modificar"
        Dim idProducto As Object = GrillaProductos.CurrentRow.Cells(0).Value
        Dim idProveedor As Object = GrillaProductos.CurrentRow.Cells(11).Value
        Dim idRubro As Object = GrillaProductos.CurrentRow.Cells(12).Value
        Dim idEstado As Object = GrillaProductos.CurrentRow.Cells(13).Value
        Dim proveedor As Object = GrillaProductos.CurrentRow.Cells(1).Value
        Dim rubro As Object = GrillaProductos.CurrentRow.Cells(2).Value
        Dim estado As Object = GrillaProductos.CurrentRow.Cells(3).Value
        Dim descripcion As Object = GrillaProductos.CurrentRow.Cells(4).Value
        Dim codAlternativo As Object = GrillaProductos.CurrentRow.Cells(5).Value
        Dim costo As Object = GrillaProductos.CurrentRow.Cells(6).Value
        Dim fechaCarga As Object = GrillaProductos.CurrentRow.Cells(7).Value
        Dim fechaActualizacion As Object = GrillaProductos.CurrentRow.Cells(8).Value
        Dim imagen As Object = GrillaProductos.CurrentRow.Cells(9).Value
        Dim observaciones As Object = GrillaProductos.CurrentRow.Cells(10).Value
        Dim precioVenta As Object = GrillaProductos.CurrentRow.Cells(14).Value
        Dim activo As Object = GrillaProductos.CurrentRow.Cells(16).Value
        Dim cantidad As Object = GrillaProductos.CurrentRow.Cells(15).Value

        FrmAbmProductos.TxtIdProducto.Text = If(idProducto IsNot DBNull.Value, idProducto.ToString(), "")
        FrmAbmProductos.TxtIdProveedor.Text = If(idProveedor IsNot DBNull.Value, idProveedor.ToString(), "")
        FrmAbmProductos.TxtIdRubro.Text = If(idRubro IsNot DBNull.Value, idRubro.ToString(), "")
        FrmAbmProductos.TxtIdEstado.Text = If(idEstado IsNot DBNull.Value, idEstado.ToString(), "")
        FrmAbmProductos.TxtProveedor.Text = If(proveedor IsNot DBNull.Value, proveedor.ToString(), "")
        FrmAbmProductos.TxtRubro.Text = If(rubro IsNot DBNull.Value, rubro.ToString(), "")
        FrmAbmProductos.TxtEstado.Text = If(estado IsNot DBNull.Value, estado.ToString(), "")
        FrmAbmProductos.TxtDescripcion.Text = If(descripcion IsNot DBNull.Value, descripcion.ToString(), "")
        FrmAbmProductos.TxtCodAlternativo.Text = If(codAlternativo IsNot DBNull.Value, codAlternativo.ToString(), "")
        FrmAbmProductos.TxtCosto.Text = If(costo IsNot DBNull.Value, costo.ToString(), "")
        FrmAbmProductos.DtFechaCarga.Text = If(fechaCarga IsNot DBNull.Value, Convert.ToDateTime(fechaCarga).ToString(), "")
        FrmAbmProductos.DtFechaActualizacion.Text = If(fechaActualizacion IsNot DBNull.Value, Convert.ToDateTime(fechaActualizacion).ToString(), "")
        FrmAbmProductos.PictureBox1.Image = If(imagen IsNot DBNull.Value, DirectCast(imagen, Image), Nothing)
        FrmAbmProductos.TxtObservaciones.Text = If(observaciones IsNot DBNull.Value, observaciones.ToString(), "")
        FrmAbmProductos.TxtPrecioVenta.Text = If(precioVenta IsNot DBNull.Value, precioVenta.ToString(), "")
        FrmAbmProductos.ChkActivo.Checked = If(activo IsNot DBNull.Value, Convert.ToBoolean(activo), False)
        FrmAbmProductos.TxtCantidad.Text = If(cantidad IsNot DBNull.Value, cantidad.ToString(), "")
        FrmAbmProductos.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "delete from Productos Where IdProducto = " & Val(GrillaProductos.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaProductos()

        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Close()
    End Sub
End Class