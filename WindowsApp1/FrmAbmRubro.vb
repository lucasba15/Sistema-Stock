Public Class FrmAbmRubro
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If LblSeñal.Text = "Agregar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Rubros(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',0)"
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
                    Acciones.CommandText = "INSERT INTO Rubros(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',1)"
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
                    Acciones.CommandText = "UPDATE Rubros SET Descripcion = '" & TxtDescripcion.Text & "', Activo = 0 Where IdRubro = " & Val(TxtIdRubro.Text) & ""
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
                    Acciones.CommandText = "UPDATE Rubros SET Descripcion = '" & TxtDescripcion.Text & "', Activo = 1 Where IdRubro = " & Val(TxtIdRubro.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        FrmRubro.CargaRubros()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrmAbmRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If LblSeñal.Text = "Agregar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Rubros(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',0)"
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
                    Acciones.CommandText = "INSERT INTO Rubros(Descripcion, Activo)VALUES('" & TxtDescripcion.Text & "',1)"
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
                    Acciones.CommandText = "UPDATE Rubros SET Descripcion = '" & TxtDescripcion.Text & "', Activo = 0 Where IdRubro = " & Val(TxtIdRubro.Text) & ""
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
                    Acciones.CommandText = "UPDATE Rubros SET Descripcion = '" & TxtDescripcion.Text & "', Activo = 1 Where IdRubro = " & Val(TxtIdRubro.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        FrmRubro.CargaRubros()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub
End Class