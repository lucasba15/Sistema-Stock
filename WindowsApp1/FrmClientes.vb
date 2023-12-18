Public Class FrmClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaClientes(TxtBusqueda.Text)
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaClientes(TxtBusqueda.Text)
    End Sub
    Public Sub CargaClientes(Optional ByVal filtroDescripcion As String = "")
        If GrillaClientes.Rows.Count <> 0 Then
            GrillaClientes.Rows.Clear()
        End If
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT * From Clientes Where (Clientes.Apellido + ' ' + Clientes.Nombre) LIKE @filtroDescripcion + '%'"
        If ChkActivo.Checked And Not ChkInactivo.Checked Then
            Acciones.CommandText += " AND Clientes.Activo = 1"
        ElseIf ChkInactivo.Checked And Not ChkActivo.Checked Then
            Acciones.CommandText += " AND Clientes.Activo = 0"
        End If
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader
        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                GrillaClientes.Rows.Add(LectorDatos(0), LectorDatos(1) & " " & LectorDatos(2), LectorDatos(1), LectorDatos(2), LectorDatos(3), LectorDatos(4), LectorDatos(5), LectorDatos(6), LectorDatos(7))
            End While
        End If
        LectorDatos.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        FrmAbmClientes.LblSeñal.Text = "Agregar"
        FrmAbmClientes.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        FrmAbmClientes.LblSeñal.Text = "Modificar"
        FrmAbmClientes.TxtIdCliente.Text = GrillaClientes.CurrentRow.Cells(0).Value
        FrmAbmClientes.TxtApellido.Text = GrillaClientes.CurrentRow.Cells(2).Value
        FrmAbmClientes.TxtNombre.Text = GrillaClientes.CurrentRow.Cells(3).Value
        FrmAbmClientes.TxtDireccion.Text = GrillaClientes.CurrentRow.Cells(4).Value
        FrmAbmClientes.TxtTelefono.Text = GrillaClientes.CurrentRow.Cells(5).Value
        FrmAbmClientes.TxtMail.Text = GrillaClientes.CurrentRow.Cells(6).Value
        'FrmAbmClientes.ChkTipoCliente.Checked = GrillaClientes.CurrentRow.Cells(7).Value'
        FrmAbmClientes.ChkActivo.Checked = GrillaClientes.CurrentRow.Cells(8).Value
        FrmAbmClientes.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "delete from Clientes Where IdCliente = " & Val(GrillaClientes.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaClientes()

        End If
    End Sub

    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked Then
            ChkActivo.Checked = False
            ChkInactivo.Checked = False
            CargaClientes(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged
        If ChkActivo.Checked Then
            ChkInactivo.Checked = False
            ChkTodos.Checked = False
            CargaClientes(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged
        If ChkInactivo.Checked Then
            ChkActivo.Checked = False
            ChkTodos.Checked = False
            CargaClientes(TxtBusqueda.Text)
        End If
    End Sub


    Private Sub GrillaClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellDoubleClick
        If LblSeñal.Text = "Agregar" Then
            FrmVentas.TxtIdCliente.Text = GrillaClientes.CurrentRow.Cells(0).Value
            FrmVentas.TxtApellido.Text = GrillaClientes.CurrentRow.Cells(2).Value
            FrmVentas.TxtNombre.Text = GrillaClientes.CurrentRow.Cells(3).Value
            Close()
        End If
        If LblSeñal.Text = "Listado" Then
                FrmListaClientes.TxtApellido.Text = GrillaClientes.CurrentRow.Cells(2).Value
                FrmListaClientes.TxtNombre.Text = GrillaClientes.CurrentRow.Cells(3).Value
                Close()
            End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FrmAbmClientes.LblSeñal.Text = "Agregar"
        FrmAbmClientes.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        FrmAbmClientes.LblSeñal.Text = "Modificar"
        FrmAbmClientes.TxtIdCliente.Text = GrillaClientes.CurrentRow.Cells(0).Value
        FrmAbmClientes.TxtApellido.Text = GrillaClientes.CurrentRow.Cells(2).Value
        FrmAbmClientes.TxtNombre.Text = GrillaClientes.CurrentRow.Cells(3).Value
        FrmAbmClientes.TxtDireccion.Text = GrillaClientes.CurrentRow.Cells(4).Value
        FrmAbmClientes.TxtTelefono.Text = GrillaClientes.CurrentRow.Cells(5).Value
        FrmAbmClientes.TxtMail.Text = GrillaClientes.CurrentRow.Cells(6).Value
        'FrmAbmClientes.ChkTipoCliente.Checked = GrillaClientes.CurrentRow.Cells(7).Value'
        FrmAbmClientes.ChkActivo.Checked = GrillaClientes.CurrentRow.Cells(8).Value
        FrmAbmClientes.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("El registro será eliminado... ¿Desea continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim IdCliente As Integer = Val(GrillaClientes.CurrentRow.Cells(0).Value)

                ' Actualizar la clave foránea de los proveedores asociados a la ciudad que se eliminará.
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "UPDATE Ventas SET IdCliente = NULL WHERE IdCliente = " & IdCliente
                Acciones.ExecuteNonQuery()
                Acciones.CommandText = "Update CuentasCorrientes SET IdCliente = NULL WHERE IdCliente = " & IdCliente
                Acciones.ExecuteNonQuery()

                Acciones.CommandText = "DELETE FROM Clientes WHERE IdCliente = " & IdCliente
                Acciones.ExecuteNonQuery()

                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            CargaClientes()
        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Close()
    End Sub

    Private Sub GrillaClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellContentClick

    End Sub
End Class