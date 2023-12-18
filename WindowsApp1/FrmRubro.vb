Public Class FrmRubro
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 
        FrmAbmRubro.LblSeñal.Text = "Agregar"
        FrmAbmRubro.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) 
        FrmAbmRubro.LblSeñal.Text = "Modificar"
        FrmAbmRubro.TxtIdRubro.Text = GrillaRubros.CurrentRow.Cells(0).Value
        FrmAbmRubro.TxtDescripcion.Text = GrillaRubros.CurrentRow.Cells(1).Value
        FrmAbmRubro.CheckBox2.Checked = GrillaRubros.CurrentRow.Cells(2).Value
        FrmAbmRubro.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) 
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "delete from Rubros Where IdRubro = " & Val(GrillaRubros.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaRubros()

        End If
    End Sub

    Private Sub FrmRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaRubros()
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaRubros(TxtBusqueda.Text)
    End Sub
    Public Sub CargaRubros(Optional ByVal filtroDescripcion As String = "")
        If GrillaRubros.Rows.Count <> 0 Then
            GrillaRubros.Rows.Clear()
        End If
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT * FROM Rubros WHERE Descripcion LIKE @filtroDescripcion + '%'"
        If ChkActivo.Checked And Not ChkInactivo.Checked Then
            Acciones.CommandText += " AND Rubros.Activo = 1"
        ElseIf ChkInactivo.Checked And Not ChkActivo.Checked Then
            Acciones.CommandText += " AND Rubros.Activo = 0"
        End If
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader
        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                GrillaRubros.Rows.Add(LectorDatos(0), LectorDatos(1), LectorDatos(2))
            End While
        End If
        LectorDatos.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) 
        Close()
    End Sub

    Private Sub GrillaRubros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaRubros.CellContentClick

    End Sub

    Private Sub GrillaRubros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaRubros.CellDoubleClick
        FrmAbmProductos.TxtIdRubro.Text = GrillaRubros.CurrentRow.Cells(0).Value
        FrmAbmProductos.TxtRubro.Text = GrillaRubros.CurrentRow.Cells(1).Value
        Close()
    End Sub

    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked Then
            ChkActivo.Checked = False
            ChkInactivo.Checked = False
            CargaRubros(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged
        If ChkActivo.Checked Then
            ChkInactivo.Checked = False
            ChkTodos.Checked = False
            CargaRubros(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged
        If ChkInactivo.Checked Then
            ChkActivo.Checked = False
            ChkTodos.Checked = False
            CargaRubros(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FrmAbmRubro.LblSeñal.Text = "Agregar"
        FrmAbmRubro.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        FrmAbmRubro.LblSeñal.Text = "Modificar"
        FrmAbmRubro.TxtIdRubro.Text = GrillaRubros.CurrentRow.Cells(0).Value
        FrmAbmRubro.TxtDescripcion.Text = GrillaRubros.CurrentRow.Cells(1).Value
        FrmAbmRubro.CheckBox2.Checked = GrillaRubros.CurrentRow.Cells(2).Value
        FrmAbmRubro.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("El registro será eliminado... ¿Desea continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim IdRubro As Integer = Val(GrillaRubros.CurrentRow.Cells(0).Value)

                ' Actualizar la clave foránea de los proveedores asociados a la ciudad que se eliminará.
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "UPDATE Productos SET IdRubro = NULL WHERE IdRubro = " & IdRubro
                Acciones.ExecuteNonQuery()

                ' Luego, elimina la ciudad.
                Acciones.CommandText = "DELETE FROM Rubros WHERE IdRubro = " & IdRubro
                Acciones.ExecuteNonQuery()

                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            ' Vuelve a cargar las ciudades después de la eliminación.
            CargaRubros()
        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Close()
    End Sub
End Class