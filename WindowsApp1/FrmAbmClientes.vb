Public Class FrmAbmClientes
    Private Sub FrmAbmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If LblSeñal.Text = "Agregar" Then
            If TxtMail.Text.Length < 6 OrElse TxtMail.Text.Length > 30 Then
                MsgBox("El correo electrónico debe tener entre 6 y 30 caracteres.", vbOKOnly + vbExclamation, "MENSAJE DEL SISTEMA")
                Exit Sub
            Else
                If ChkActivo.Checked = False Then
                    Try
                        Acciones.Connection = ConexionSql
                        Acciones.CommandType = CommandType.Text
                        Acciones.CommandText = "INSERT INTO Clientes(Apellido,Nombre,Direccion,Telefono,Mail,Activo) Values('" & TxtApellido.Text & "','" & TxtNombre.Text & "','" & TxtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtMail.Text & "',0)"
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
                        Acciones.CommandText = "INSERT INTO Clientes(Apellido,Nombre,Direccion,Telefono,Mail,Activo) Values('" & TxtApellido.Text & "','" & TxtNombre.Text & "','" & TxtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtMail.Text & "',1)"
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
            If ChkActivo.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Clientes SET Apellido = '" & TxtApellido.Text & "',Nombre = '" & TxtNombre.Text & "',Direccion = '" & TxtDireccion.Text & "',Telefono = '" & TxtTelefono.Text & "',Mail = '" & TxtMail.Text & "',Activo = 0 Where IdCliente = " & Val(TxtIdCliente.Text) & ""
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
                    Acciones.CommandText = "UPDATE Clientes SET Apellido = '" & TxtApellido.Text & "',Nombre = '" & TxtNombre.Text & "',Direccion = '" & TxtDireccion.Text & "',Telefono = '" & TxtTelefono.Text & "',Mail = '" & TxtMail.Text & "',Activo = 1 Where IdCliente = " & Val(TxtIdCliente.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try


                Close()
            End If
        End If
        FrmClientes.CargaClientes()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub LblSeñal_Click(sender As Object, e As EventArgs) Handles LblSeñal.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles LblAceptar.Click
        If LblSeñal.Text = "Agregar" Then
            If ChkActivo.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Clientes(Apellido,Nombre,Direccion,Telefono,Mail,Activo) Values('" & TxtApellido.Text & "','" & TxtNombre.Text & "','" & TxtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtMail.Text & "',0)"
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
                    Acciones.CommandText = "INSERT INTO Clientes(Apellido,Nombre,Direccion,Telefono,Mail,Activo) Values('" & TxtApellido.Text & "','" & TxtNombre.Text & "','" & TxtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtMail.Text & "',1)"
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                Close()
            End If

        End If
        If LblSeñal.Text = "Modificar" Then
            If ChkActivo.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Clientes SET Apellido = '" & TxtApellido.Text & "',Nombre = '" & TxtNombre.Text & "',Direccion = '" & TxtDireccion.Text & "',Telefono = '" & TxtTelefono.Text & "',Mail = '" & TxtMail.Text & "',Activo = 0 Where IdCliente = " & Val(TxtIdCliente.Text) & ""
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
                    Acciones.CommandText = "UPDATE Clientes SET Apellido = '" & TxtApellido.Text & "',Nombre = '" & TxtNombre.Text & "',Direccion = '" & TxtDireccion.Text & "',Telefono = '" & TxtTelefono.Text & "',Mail = '" & TxtMail.Text & "',Activo = 1 Where IdCliente = " & Val(TxtIdCliente.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try


                Close()
            End If
        End If
        FrmClientes.CargaClientes()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub
End Class