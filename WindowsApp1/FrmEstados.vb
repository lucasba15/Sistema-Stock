Public Class FrmEstados
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 
        FrmAbmEstado.LblSeñal.Text = "Agregar"
        FrmAbmEstado.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) 
        FrmAbmEstado.LblSeñal.Text = "Modificar"
        FrmAbmEstado.TxtIdEstado.Text = GrillaEstados.CurrentRow.Cells(0).Value
        FrmAbmEstado.TxtDescripcion.Text = GrillaEstados.CurrentRow.Cells(1).Value
        FrmAbmEstado.CheckBox2.Checked = GrillaEstados.CurrentRow.Cells(2).Value
        FrmAbmEstado.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) 
        Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) 
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "delete from Estados Where IdEstado = " & Val(GrillaEstados.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaEstados()

        End If
    End Sub

    Private Sub FrmEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaEstados()
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaEstados(TxtBusqueda.Text)
    End Sub
    Public Sub CargaEstados(Optional ByVal filtroDescripcion As String = "")
        If GrillaEstados.Rows.Count <> 0 Then
            GrillaEstados.Rows.Clear()
        End If
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT * FROM Estados WHERE Descripcion LIKE @filtroDescripcion + '%'"
        If ChkActivo.Checked And Not ChkInactivo.Checked Then
            Acciones.CommandText += " AND Estados.Activo = 1"
        ElseIf ChkInactivo.Checked And Not ChkActivo.Checked Then
            Acciones.CommandText += " AND Estados.Activo = 0"
        End If
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader
        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                GrillaEstados.Rows.Add(LectorDatos(0), LectorDatos(1), LectorDatos(2))
            End While
        End If
        LectorDatos.Close()
    End Sub

    Private Sub GrillaEstados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaEstados.CellContentClick

    End Sub

    Private Sub GrillaEstados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaEstados.CellDoubleClick
        FrmAbmProductos.TxtIdEstado.Text = GrillaEstados.CurrentRow.Cells(0).Value
        FrmAbmProductos.TxtEstado.Text = GrillaEstados.CurrentRow.Cells(1).Value
        Close()
    End Sub

    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked Then
            ChkActivo.Checked = False
            ChkInactivo.Checked = False
            CargaEstados(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged
        If ChkActivo.Checked Then
            ChkInactivo.Checked = False
            ChkTodos.Checked = False
            CargaEstados(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged
        If ChkInactivo.Checked Then
            ChkActivo.Checked = False
            ChkTodos.Checked = False
            CargaEstados(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FrmAbmEstado.LblSeñal.Text = "Agregar"
        FrmAbmEstado.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        FrmAbmEstado.LblSeñal.Text = "Modificar"
        FrmAbmEstado.TxtIdEstado.Text = GrillaEstados.CurrentRow.Cells(0).Value
        FrmAbmEstado.TxtDescripcion.Text = GrillaEstados.CurrentRow.Cells(1).Value
        FrmAbmEstado.CheckBox2.Checked = GrillaEstados.CurrentRow.Cells(2).Value
        FrmAbmEstado.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("El registro será eliminado... ¿Desea continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim IdEstado As Integer = Val(GrillaEstados.CurrentRow.Cells(0).Value)

                ' Actualizar la clave foránea de los proveedores asociados a la ciudad que se eliminará.
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "UPDATE Productos SET IdEstado = NULL WHERE IdEstado = " & IdEstado
                Acciones.ExecuteNonQuery()
                Acciones.CommandText = "DELETE FROM Estados WHERE IdEstado = " & IdEstado
                Acciones.ExecuteNonQuery()

                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            CargaEstados()
        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Close()
    End Sub
End Class