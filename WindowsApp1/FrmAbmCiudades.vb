Public Class FrmAbmCiudades
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If LblSeñal.Text = "Agregar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Ciudades(Descripcion,Activo)VALUES('" & TxtDescripcion.Text & "', 0)"
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
                    Acciones.CommandText = "INSERT INTO Ciudades(Descripcion,Activo)VALUES('" & TxtDescripcion.Text & "', 1)"
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
                    Acciones.CommandText = "UPDATE Ciudades SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 0 Where IdCiudad = " & Val(TxtIdCiudad.Text) & ""
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
                    Acciones.CommandText = "UPDATE Ciudades SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 1 Where IdCiudad = " & Val(TxtIdCiudad.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        Frmciudades.CargaCiudades()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub FrmAbmCiudades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDescripcion.BorderStyle = BorderStyle.FixedSingle
        TxtDescripcion.BackColor = Color.LightYellow
        TxtDescripcion.ForeColor = Color.Black

    End Sub
    Private Sub TxtDescripcion_GotFocus(sender As Object, e As EventArgs) Handles TxtDescripcion.GotFocus
        TxtDescripcion.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtDescripcion.LostFocus
        TxtDescripcion.BackColor = SystemColors.Window
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If LblSeñal.Text = "Agregar" Then
            Dim ciudadExiste As Boolean = False

            ' Verificar si la ciudad ya existe en la base de datos antes de agregarla
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "SELECT COUNT(*) FROM Ciudades WHERE Descripcion = '" & TxtDescripcion.Text & "'"
                Dim cantidad As Integer = CInt(Acciones.ExecuteScalar())
                If cantidad > 0 Then
                    ciudadExiste = True
                    MsgBox("La ciudad ya existe en la base de datos.", vbExclamation, "MENSAJE DEL SISTEMA")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            If Not ciudadExiste Then
                If CheckBox2.Checked = False Then
                    Try
                        Acciones.Connection = ConexionSql
                        Acciones.CommandType = CommandType.Text
                        Acciones.CommandText = "INSERT INTO Ciudades(Descripcion,Activo)VALUES('" & TxtDescripcion.Text & "', 0)"
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
                        Acciones.CommandText = "INSERT INTO Ciudades(Descripcion,Activo)VALUES('" & TxtDescripcion.Text & "', 1)"
                        Acciones.ExecuteNonQuery()
                        MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                    Catch ex As Exception
                        MsgBox(ex.ToString)

                    End Try
                    Close()
                End If
            End If
        End If
        If LblSeñal.Text = "Modificar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Ciudades SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 0 Where IdCiudad = " & Val(TxtIdCiudad.Text) & ""
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
                    Acciones.CommandText = "UPDATE Ciudades SET Descripcion = '" & TxtDescripcion.Text & "',Activo = 1 Where IdCiudad = " & Val(TxtIdCiudad.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If
        End If
        Frmciudades.CargaCiudades()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub
End Class