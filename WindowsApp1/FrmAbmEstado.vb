Public Class FrmAbmEstado
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If LblSeñal.Text = "Agregar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Estados(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',0)"
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            Else

                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Estados(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',1)"
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        If LblSeñal.Text = "Modificar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Estados SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 0 Where IdEstado = " & Val(TxtIdEstado.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try


                Close()
            Else
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Estados SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 1 Where IdEstado = " & Val(TxtIdEstado.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        FrmEstados.CargaEstados()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub FrmAbmEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If LblSeñal.Text = "Agregar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Estados(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',0)"
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            Else

                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Estados(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',1)"
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        If LblSeñal.Text = "Modificar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Estados SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 0 Where IdEstado = " & Val(TxtIdEstado.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try


                Close()
            Else
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Estados SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 1 Where IdEstado = " & Val(TxtIdEstado.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        FrmEstados.CargaEstados()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged

    End Sub
End Class