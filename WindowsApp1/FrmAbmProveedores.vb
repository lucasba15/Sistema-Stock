Public Class FrmAbmProveedores
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtObservaciones.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        FrmCiudades.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If LblSeñal.Text = "Agregar" Then
            If TxtIdCiudad.Text = "" Then
                MsgBox("DEBE INGRESAR UNA CIUDAD", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Else
                If TxtIdCondicionIva.Text = "" Then
                    MsgBox("DEBE INGRESAR UNA CONDICIÓN DE IVA", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Else


                    If Not System.Text.RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z]+$") Then
                        MsgBox("EL NOMBRE DEBE CONTENER SOLO LETRAS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                    Else
                        If CheckBox2.Checked = False Then
                            Try
                                Acciones.Connection = ConexionSql
                                Acciones.CommandType = CommandType.Text
                                Acciones.CommandText = "INSERT INTO Proveedores(Nombre,Apellido,Cuit,Direccion,Telefono,Mail,IdCiudad,Provincia,IdCondicionIva,Contacto,Observaciones,Activo) Values('" & TxtNombre.Text & "','" & TxtApellido.Text & "','" & TxtCuit.Text & "','" & TxtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtMail.Text & "','" & TxtIdCiudad.Text & "','" & TxtProvincia.Text & "','" & TxtIdCondicionIva.Text & "','" & TxtContacto.Text & "','" & TxtObservaciones.Text & "',0)"
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
                                Acciones.CommandText = "INSERT INTO Proveedores(Nombre,Apellido,Cuit,Direccion,Telefono,Mail,IdCiudad,Provincia,IdCondicionIva,Contacto,Observaciones,Activo) Values('" & TxtNombre.Text & "','" & TxtApellido.Text & "','" & TxtCuit.Text & "','" & TxtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtMail.Text & "','" & TxtIdCiudad.Text & "','" & TxtProvincia.Text & "','" & TxtIdCondicionIva.Text & "','" & TxtContacto.Text & "','" & TxtObservaciones.Text & "',1)"
                                Acciones.ExecuteNonQuery()
                                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                            Catch ex As Exception
                                MsgBox(ex.ToString)

                            End Try
                            Close()

                        End If
                    End If
                End If
            End If
        End If
        If LblSeñal.Text = "Modificar" Then
            If CheckBox2.Checked = False Then
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Proveedores SET Nombre = '" & TxtNombre.Text & "',Apellido = '" & TxtApellido.Text & "',Cuit = '" & TxtCuit.Text & "',Direccion = '" & TxtDireccion.Text & "',Telefono = '" & TxtTelefono.Text & "',Mail = '" & TxtMail.Text & "',IdCiudad = '" & TxtIdCiudad.Text & "',Provincia = '" & TxtProvincia.Text & "',IdCondicionIva = '" & TxtIdCondicionIva.Text & "',Contacto = '" & TxtContacto.Text & "',Observaciones = '" & TxtObservaciones.Text & "',Activo = 0 Where IdProveedor = " & Val(TxtIdProveedor.Text) & ""
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
                    Acciones.CommandText = "UPDATE Proveedores SET Nombre = '" & TxtNombre.Text & "',Apellido = '" & TxtApellido.Text & "',Cuit = '" & TxtCuit.Text & "',Direccion = '" & TxtDireccion.Text & "',Telefono = '" & TxtTelefono.Text & "',Mail = '" & TxtMail.Text & "',IdCiudad = '" & TxtIdCiudad.Text & "',Provincia = '" & TxtProvincia.Text & "',IdCondicionIva = '" & TxtIdCondicionIva.Text & "',Contacto = '" & TxtContacto.Text & "',Observaciones = '" & TxtObservaciones.Text & "',Activo = 1 Where IdProveedor = " & Val(TxtIdProveedor.Text) & ""
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try


                Close()
            End If
        End If
        FrmProveedor.CargaProveedor()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmCondicionIva.Show()
    End Sub

    Private Sub FrmAbmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If LblSeñal.Text = "Agregar" Then

            If Not System.Text.RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z]+$") Then
                MsgBox("EL NOMBRE DEBE CONTENER SOLO LETRAS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Else
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Proveedores(Nombre, Apellido, Cuit, Direccion, Telefono, Mail, IdCiudad, Provincia, IdCondicionIva, Contacto, Observaciones, Activo) " &
                                               "VALUES (@Nombre, @Apellido, @Cuit, @Direccion, @Telefono, @Mail, @IdCiudad, @Provincia, @IdCondicionIva, @Contacto, @Observaciones, @Activo)"

                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Cuit", TxtCuit.Text)
                    Acciones.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
                    Acciones.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
                    Acciones.Parameters.AddWithValue("@Mail", TxtMail.Text)
                    Acciones.Parameters.AddWithValue("@IdCiudad", If(String.IsNullOrEmpty(TxtIdCiudad.Text), DBNull.Value, TxtIdCiudad.Text))
                    Acciones.Parameters.AddWithValue("@Provincia", TxtProvincia.Text)
                    Acciones.Parameters.AddWithValue("@IdCondicionIva", If(String.IsNullOrEmpty(TxtIdCondicionIva.Text), DBNull.Value, TxtIdCondicionIva.Text))
                    Acciones.Parameters.AddWithValue("@Contacto", TxtContacto.Text)
                    Acciones.Parameters.AddWithValue("@Observaciones", TxtObservaciones.Text)
                    If CheckBox2.Checked Then
                        Acciones.Parameters.AddWithValue("@Activo", True)
                    Else
                        Acciones.Parameters.AddWithValue("@Activo", False)
                    End If

                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
                Close()


            End If
        Else
            If LblSeñal.Text = "Modificar" Then
                Dim activo As Integer = If(CheckBox2.Checked, 1, 0)
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Proveedores SET " &
                                          "Nombre = @Nombre, " &
                                          "Apellido = @Apellido, " &
                                          "Cuit = @Cuit, " &
                                          "Direccion = @Direccion, " &
                                          "Telefono = @Telefono, " &
                                          "Mail = @Mail, " &
                                          "IdCiudad = @IdCiudad, " &
                                          "Provincia = @Provincia, " &
                                          "IdCondicionIva = @IdCondicionIva, " &
                                          "Contacto = @Contacto, " &
                                          "Observaciones = @Observaciones, " &
                                          "Activo = @Activo " &
                                          "WHERE IdProveedor = @IdProveedor"

                    Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                    Acciones.Parameters.AddWithValue("@Cuit", TxtCuit.Text)
                    Acciones.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
                    Acciones.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
                    Acciones.Parameters.AddWithValue("@Mail", TxtMail.Text)
                    Acciones.Parameters.AddWithValue("@IdCiudad", If(String.IsNullOrEmpty(TxtIdCiudad.Text), DBNull.Value, TxtIdCiudad.Text))
                    Acciones.Parameters.AddWithValue("@Provincia", TxtProvincia.Text)
                    Acciones.Parameters.AddWithValue("@IdCondicionIva", If(String.IsNullOrEmpty(TxtIdCondicionIva.Text), DBNull.Value, TxtIdCondicionIva.Text))
                    Acciones.Parameters.AddWithValue("@Contacto", TxtContacto.Text)
                    Acciones.Parameters.AddWithValue("@Observaciones", TxtObservaciones.Text)
                    Acciones.Parameters.AddWithValue("@Activo", activo)
                    Acciones.Parameters.AddWithValue("@IdProveedor", Val(TxtIdProveedor.Text))

                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                    Acciones.Parameters.Clear() ' Limpia los parámetros después de usarlos.
                    Close()
                End Try
            End If

        End If
        FrmProveedor.CargaProveedor()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    Private Sub TxtCuit_TextChanged(sender As Object, e As EventArgs) Handles TxtCuit.TextChanged
        If TxtCuit.Text.Length > 20 Then
            TxtCuit.Text = TxtCuit.Text.Substring(0, 20)
            TxtCuit.SelectionStart = 20
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmCondicionIva.Show()
    End Sub
End Class