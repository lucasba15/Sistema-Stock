Public Class FrmProveedor
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        Close()
    End Sub




    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked Then
            ChkActivo.Checked = False
            ChkInactivo.Checked = False
            CargaProveedor(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged
        If ChkActivo.Checked Then
            ChkInactivo.Checked = False
            ChkTodos.Checked = False
            CargaProveedor(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged
        If ChkInactivo.Checked Then
            ChkActivo.Checked = False
            ChkTodos.Checked = False
            CargaProveedor(TxtBusqueda.Text)
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProveedores.CellContentClick

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "delete from Proveedores Where IdProveedor = " & Val(GrillaProveedores.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaProveedor()

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        FrmAbmProveedores.LblSeñal.Text = "Modificar"
        FrmAbmProveedores.TxtIdProveedor.Text = GrillaProveedores.CurrentRow.Cells(0).Value
        FrmAbmProveedores.TxtNombre.Text = GrillaProveedores.CurrentRow.Cells(2).Value
        FrmAbmProveedores.TxtApellido.Text = GrillaProveedores.CurrentRow.Cells(3).Value
        FrmAbmProveedores.TxtCuit.Text = GrillaProveedores.CurrentRow.Cells(4).Value
        FrmAbmProveedores.TxtDireccion.Text = GrillaProveedores.CurrentRow.Cells(5).Value
        FrmAbmProveedores.TxtTelefono.Text = GrillaProveedores.CurrentRow.Cells(6).Value
        FrmAbmProveedores.TxtMail.Text = GrillaProveedores.CurrentRow.Cells(7).Value
        FrmAbmProveedores.TxtIdCiudad.Text = GrillaProveedores.CurrentRow.Cells(13).Value
        FrmAbmProveedores.TxtCiudad.Text = GrillaProveedores.CurrentRow.Cells(8).Value
        FrmAbmProveedores.TxtProvincia.Text = GrillaProveedores.CurrentRow.Cells(9).Value
        FrmAbmProveedores.TxtIdCondicionIva.Text = GrillaProveedores.CurrentRow.Cells(14).Value
        FrmAbmProveedores.TxtCondicionIva.Text = GrillaProveedores.CurrentRow.Cells(10).Value
        FrmAbmProveedores.TxtContacto.Text = GrillaProveedores.CurrentRow.Cells(11).Value
        FrmAbmProveedores.TxtObservaciones.Text = GrillaProveedores.CurrentRow.Cells(12).Value
        FrmAbmProveedores.CheckBox2.Checked = GrillaProveedores.CurrentRow.Cells(15).Value
        FrmAbmProveedores.Show()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        FrmAbmProveedores.LblSeñal.Text = "Agregar"
        FrmAbmProveedores.Show()
    End Sub

    Private Sub GrillaProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProveedores.CellDoubleClick
        FrmAbmProductos.TxtIdProveedor.Text = GrillaProveedores.CurrentRow.Cells(0).Value
        FrmAbmProductos.TxtProveedor.Text = GrillaProveedores.CurrentRow.Cells(1).Value
        Close()
    End Sub





    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaProveedor(TxtBusqueda.Text)
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaProveedor(TxtBusqueda.Text)
    End Sub
    Public Sub CargaProveedor(Optional ByVal filtroDescripcion As String = "")
        If GrillaProveedores.Rows.Count <> 0 Then
            GrillaProveedores.Rows.Clear()
        End If
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT Proveedores.IdProveedor,Proveedores.IdCiudad,Proveedores.IdCondicionIva,Proveedores.Nombre,Proveedores.Apellido,Proveedores.Cuit,Proveedores.Direccion,Proveedores.Telefono,Proveedores.Mail,Proveedores.Provincia,Proveedores.Contacto,Proveedores.Observaciones,Proveedores.Activo,Ciudades.Descripcion,CondicionIva.Descripcion FROM Proveedores Left Join Ciudades ON Proveedores.IdCiudad = Ciudades.IdCiudad Left Join CondicionIva ON Proveedores.IdCondicionIva = CondicionIva.IdCondicionIva Where (Proveedores.Apellido + ' ' + Proveedores.Nombre) LIKE @filtroDescripcion + '%'"
        If ChkActivo.Checked And Not ChkInactivo.Checked Then
            Acciones.CommandText += " AND Proveedores.Activo = 1"
        ElseIf ChkInactivo.Checked And Not ChkActivo.Checked Then
            Acciones.CommandText += " AND Proveedores.Activo = 0"
        End If
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader
        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                GrillaProveedores.Rows.Add(LectorDatos(0), LectorDatos(4) & " " & LectorDatos(3), LectorDatos(3), LectorDatos(4), LectorDatos(5), LectorDatos(6), LectorDatos(7), LectorDatos(8), LectorDatos(13), LectorDatos(9), LectorDatos(14), LectorDatos(10), LectorDatos(11), LectorDatos(1), LectorDatos(2), LectorDatos(12))
            End While
        End If
        LectorDatos.Close()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FrmAbmProveedores.LblSeñal.Text = "Agregar"
        FrmAbmProveedores.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        FrmAbmProveedores.LblSeñal.Text = "Modificar"
        Dim idProveedor As Object = GrillaProveedores.CurrentRow.Cells(0).Value
        Dim Nombre As Object = GrillaProveedores.CurrentRow.Cells(2).Value
        Dim Apellido As Object = GrillaProveedores.CurrentRow.Cells(3).Value
        Dim Cuit As Object = GrillaProveedores.CurrentRow.Cells(4).Value
        Dim Direccion As Object = GrillaProveedores.CurrentRow.Cells(5).Value
        Dim Telefono As Object = GrillaProveedores.CurrentRow.Cells(6).Value
        Dim Mail As Object = GrillaProveedores.CurrentRow.Cells(7).Value
        Dim IdCiudad As Object = GrillaProveedores.CurrentRow.Cells(13).Value
        Dim Ciudad As Object = GrillaProveedores.CurrentRow.Cells(8).Value
        Dim Provincia As Object = GrillaProveedores.CurrentRow.Cells(9).Value
        Dim IdCondicionIva As Object = GrillaProveedores.CurrentRow.Cells(14).Value
        Dim CondicionIva As Object = GrillaProveedores.CurrentRow.Cells(10).Value
        Dim Contacto As Object = GrillaProveedores.CurrentRow.Cells(11).Value
        Dim Observaciones As Object = GrillaProveedores.CurrentRow.Cells(12).Value
        Dim Activo As Object = GrillaProveedores.CurrentRow.Cells(15).Value
        FrmAbmProveedores.TxtIdProveedor.Text = If(idProveedor IsNot DBNull.Value, idProveedor.ToString(), "")
        FrmAbmProveedores.TxtNombre.Text = If(Nombre IsNot DBNull.Value, Nombre.ToString(), "")
        FrmAbmProveedores.TxtApellido.Text = If(Apellido IsNot DBNull.Value, Apellido.ToString(), "")
        FrmAbmProveedores.TxtCuit.Text = If(Cuit IsNot DBNull.Value, Cuit.ToString(), "")
        FrmAbmProveedores.TxtDireccion.Text = If(Direccion IsNot DBNull.Value, Direccion.ToString(), "")
        FrmAbmProveedores.TxtTelefono.Text = If(Telefono IsNot DBNull.Value, Telefono.ToString(), "")
        FrmAbmProveedores.TxtMail.Text = If(Mail IsNot DBNull.Value, Mail.ToString(), "")
        FrmAbmProveedores.TxtIdCiudad.Text = If(IdCiudad IsNot DBNull.Value, IdCiudad.ToString(), "")
        FrmAbmProveedores.TxtCiudad.Text = If(Ciudad IsNot DBNull.Value, Ciudad.ToString(), "")
        FrmAbmProveedores.TxtProvincia.Text = If(Provincia IsNot DBNull.Value, Provincia.ToString(), "")
        FrmAbmProveedores.TxtIdCondicionIva.Text = If(IdCondicionIva IsNot DBNull.Value, IdCondicionIva.ToString(), "")
        FrmAbmProveedores.TxtCondicionIva.Text = If(CondicionIva IsNot DBNull.Value, CondicionIva.ToString(), "")
        FrmAbmProveedores.TxtContacto.Text = If(Contacto IsNot DBNull.Value, Contacto.ToString(), "")
        FrmAbmProveedores.TxtObservaciones.Text = If(Observaciones IsNot DBNull.Value, Observaciones.ToString(), "")
        FrmAbmProveedores.CheckBox2.Checked = If(Activo IsNot DBNull.Value, Convert.ToBoolean(Activo), False)
        FrmAbmProveedores.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("El registro será eliminado... ¿Desea continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim IdProveedor As Integer = Val(GrillaProveedores.CurrentRow.Cells(0).Value)

                ' Actualizar la clave foránea de los proveedores asociados a la ciudad que se eliminará.
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "UPDATE Productos SET IdProveedor = NULL WHERE IdProveedor = " & IdProveedor
                Acciones.ExecuteNonQuery()

                ' Luego, elimina la ciudad.
                Acciones.CommandText = "DELETE FROM Proveedores WHERE IdProveedor = " & IdProveedor
                Acciones.ExecuteNonQuery()

                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            ' Vuelve a cargar las ciudades después de la eliminación.
            CargaProveedor()
        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Close()
    End Sub
End Class