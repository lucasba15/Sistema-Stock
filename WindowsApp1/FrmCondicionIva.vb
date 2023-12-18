Public Class FrmCondicionIva
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 
        FrmAbmCondicionIva.LblSeñal.Text = "Agregar"
        FrmAbmCondicionIva.Show()
    End Sub

    Private Sub FrmCondicionIva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCondicionIva()
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        CargaCondicionIva(TxtBusqueda.Text)
    End Sub
    Public Sub CargaCondicionIva(Optional ByVal filtroDescripcion As String = "")
        If GrillaCondicionIva.Rows.Count <> 0 Then
            GrillaCondicionIva.Rows.Clear()
        End If
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT * FROM CondicionIva WHERE Descripcion LIKE @filtroDescripcion + '%'"
        If ChkActivo.Checked And Not ChkInactivo.Checked Then
            Acciones.CommandText += " AND CondicionIva.Activo = 1"
        ElseIf ChkInactivo.Checked And Not ChkActivo.Checked Then
            Acciones.CommandText += " AND CondicionIva.Activo = 0"
        End If
        Acciones.Parameters.Clear()
        Acciones.Parameters.AddWithValue("@filtroDescripcion", filtroDescripcion)
        LectorDatos = Acciones.ExecuteReader
        If LectorDatos.HasRows Then
            While LectorDatos.Read()
                GrillaCondicionIva.Rows.Add(LectorDatos(0), LectorDatos(1), LectorDatos(2))
            End While
        End If
        LectorDatos.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) 
        Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) 
        FrmAbmCondicionIva.LblSeñal.Text = "Modificar"
        FrmAbmCondicionIva.TxtIdCondicionIva.Text = GrillaCondicionIva.CurrentRow.Cells(0).Value
        FrmAbmCondicionIva.TxtDescripcion.Text = GrillaCondicionIva.CurrentRow.Cells(1).Value
        FrmAbmCondicionIva.CheckBox2.Checked = GrillaCondicionIva.CurrentRow.Cells(2).Value
        FrmAbmCondicionIva.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) 
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "delete from CondicionIva Where IdCondicionIva = " & Val(GrillaCondicionIva.CurrentRow.Cells(0).Value) & ""
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaCondicionIva()

        End If
    End Sub

    Private Sub GrillaCondicionIva_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCondicionIva.CellContentClick

    End Sub

    Private Sub GrillaCondicionIva_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCondicionIva.CellDoubleClick
        FrmAbmProveedores.TxtIdCondicionIva.Text = GrillaCondicionIva.CurrentRow.Cells(0).Value
        FrmAbmProveedores.TxtCondicionIva.Text = GrillaCondicionIva.CurrentRow.Cells(1).Value
        Close()
    End Sub

    Private Sub ChkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTodos.CheckedChanged
        If ChkTodos.Checked Then
            ChkActivo.Checked = False
            ChkInactivo.Checked = False
            CargaCondicionIva(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivo.CheckedChanged
        If ChkActivo.Checked Then
            ChkInactivo.Checked = False
            ChkTodos.Checked = False
            CargaCondicionIva(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ChkInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInactivo.CheckedChanged
        If ChkInactivo.Checked Then
            ChkActivo.Checked = False
            ChkTodos.Checked = False
            CargaCondicionIva(TxtBusqueda.Text)
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FrmAbmCondicionIva.LblSeñal.Text = "Agregar"
        FrmAbmCondicionIva.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        FrmAbmCondicionIva.LblSeñal.Text = "Modificar"
        FrmAbmCondicionIva.TxtIdCondicionIva.Text = GrillaCondicionIva.CurrentRow.Cells(0).Value
        FrmAbmCondicionIva.TxtDescripcion.Text = GrillaCondicionIva.CurrentRow.Cells(1).Value
        FrmAbmCondicionIva.CheckBox2.Checked = GrillaCondicionIva.CurrentRow.Cells(2).Value
        FrmAbmCondicionIva.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... Desea continuar", "Mensaje del sistema", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim IdCondicionIva As Integer = Val(GrillaCondicionIva.CurrentRow.Cells(0).Value)

                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "UPDATE Proveedores SET IdCondicionIva = NULL WHERE IdCondicionIva = " & IdCondicionIva
                Acciones.ExecuteNonQuery()

                Acciones.CommandText = "delete from CondicionIva Where IdCondicionIva = " & IdCondicionIva
                Acciones.ExecuteNonQuery()
                MsgBox("DATOS ELIMINADOS CORRECTAMENTE", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            CargaCondicionIva()

        End If
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Close()
    End Sub
End Class