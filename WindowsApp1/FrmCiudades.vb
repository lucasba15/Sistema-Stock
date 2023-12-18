Public Class Frmciudades
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 
        FrmAbmCiudades.LblSeñal.Text = "Agregar"
        FrmAbmCiudades.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) 
        FrmAbmCiudades.LblSeñal.Text = "Modificar"
        FrmAbmCiudades.TxtIdCiudad.Text = GrillaCiudades.CurrentRow.Cells(0).Value
        FrmAbmCiudades.TxtDescripcion.Text = GrillaCiudades.CurrentRow.Cells(1).Value
        FrmAbmCiudades.CheckBox2.Checked = GrillaCiudades.CurrentRow.Cells(2).Value
        FrmAbmCiudades.Show()
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
                Acciones.CommandText = "delete from Ciudades Where IdCiudad = " & Val(GrillaCiudades.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaCiudades()

        End If
    End Sub

    Private Sub FrmCiudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCiudades()
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaCiudades(TxtBusqueda.Text)
    End Sub
    Public Sub CargaCiudades(Optional ByVal filtroDescripcion As String = "")
        If GrillaCiudades.Rows.Count <> 0 Then
            GrillaCiudades.Rows.Clear()
        End If
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT * FROM Ciudades WHERE Descripcion LIKE @filtroDescripcion + '%'"
        If ChkActivo.Checked And Not ChkInactivo.Checked Then
            Acciones.CommandText += " AND Ciudades.Activo = 1"
        ElseIf ChkInactivo.Checked And Not ChkActivo.Checked Then
            Acciones.CommandText += " AND Ciudades.Activo = 0"
        End If
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader
        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                GrillaCiudades.Rows.Add(LectorDatos(0), LectorDatos(1), LectorDatos(2))
            End While
        End If
        LectorDatos.Close()
    End Sub

    Private Sub GrillaCiudades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCiudades.CellContentClick

    End Sub

    Private Sub GrillaCiudades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCiudades.CellDoubleClick
        FrmAbmProveedores.TxtIdCiudad.Text = GrillaCiudades.CurrentRow.Cells(0).Value
        FrmAbmProveedores.TxtCiudad.Text = GrillaCiudades.CurrentRow.Cells(1).Value
        Close()
    End Sub

    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked Then
            ChkActivo.Checked = False
            ChkInactivo.Checked = False
            CargaCiudades(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged
        If ChkActivo.Checked Then
            ChkInactivo.Checked = False
            ChkTodos.Checked = False
            CargaCiudades(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged
        If ChkInactivo.Checked Then
            ChkActivo.Checked = False
            ChkTodos.Checked = False
            CargaCiudades(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FrmAbmCiudades.LblSeñal.Text = "Agregar"
        FrmAbmCiudades.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        FrmAbmCiudades.LblSeñal.Text = "Modificar"
        FrmAbmCiudades.TxtIdCiudad.Text = GrillaCiudades.CurrentRow.Cells(0).Value
        FrmAbmCiudades.TxtDescripcion.Text = GrillaCiudades.CurrentRow.Cells(1).Value
        FrmAbmCiudades.CheckBox2.Checked = GrillaCiudades.CurrentRow.Cells(2).Value
        FrmAbmCiudades.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("El registro será eliminado... ¿Desea continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim IdCiudad As Integer = Val(GrillaCiudades.CurrentRow.Cells(0).Value)

                ' Actualizar la clave foránea de los proveedores asociados a la ciudad que se eliminará.
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "UPDATE Proveedores SET IdCiudad = NULL WHERE IdCiudad = " & IdCiudad
                Acciones.ExecuteNonQuery()

                ' Luego, elimina la ciudad.
                Acciones.CommandText = "DELETE FROM Ciudades WHERE IdCiudad = " & IdCiudad
                Acciones.ExecuteNonQuery()

                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            ' Vuelve a cargar las ciudades después de la eliminación.
            CargaCiudades()
        End If
    End Sub



    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Close()
    End Sub
End Class