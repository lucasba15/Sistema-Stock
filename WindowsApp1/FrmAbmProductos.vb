Imports System.IO
Public Class FrmAbmProductos
    Private Sub TxtCosto_TextChanged(sender As Object, e As EventArgs) Handles TxtCosto.TextChanged





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmProveedor.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub TxtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCosto.KeyPress
        ' Verifica si la tecla presionada es un dígito válido, la tecla de retroceso o el separador decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ControlChars.Back AndAlso Not e.KeyChar = ","c AndAlso Not e.KeyChar = "."c Then
            ' Si no es un dígito válido, la tecla de retroceso o el separador decimal, ignora la tecla presionada
            e.Handled = True
        End If

        ' Si el separador decimal ya está presente en el cuadro de texto, no permitir que el usuario ingrese otro
        If e.KeyChar = ","c OrElse e.KeyChar = "."c Then
            If TxtCosto.Text.Contains(",") OrElse TxtCosto.Text.Contains(".") Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        'Crear una instancia del control OpenFileDialog
        Dim openFileDialog1 As New OpenFileDialog()

        'Configurar las propiedades del control
        openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif.*bmp;*.tif;*.tiff;*.jfif"
        openFileDialog1.Title = "Seleccionar imagen"
        openFileDialog1.Multiselect = False

        'Si el usuario selecciona una imagen y presiona el botón "Abrir"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            'Obtener la ruta del archivo seleccionado
            Dim imagenRuta As String = openFileDialog1.FileName

            'Cargar la imagen en un control PictureBox
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.ImageLocation = imagenRuta

        End If




    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FrmAbmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4.BackColor = Color.Green
        Button4.ForeColor = Color.White
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatAppearance.BorderColor = Color.DarkGreen
        DtFechaCarga.Value = DateTime.Now
        DtFechaActualizacion.Value = DateTime.Now
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If LblSeñal.Text = "Agregar" Then
            If TxtIdProveedor.Text = "" Then
                MsgBox("DEBE INGRESAR UN PROVEEDOR", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            ElseIf TxtIdRubro.Text = "" Then
                MsgBox("DEBE INGRESAR UN RUBRO", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            ElseIf TxtIdEstado.Text = "" Then
                MsgBox("DEBE INGRESAR UN ESTADO", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            ElseIf PictureBox1.Image Is Nothing Then
                MsgBox("DEBE INGRESAR UNA IMÁGEN", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Else
                Try
                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "INSERT INTO Productos(IdProveedor,IdRubro,IdEstado,Descripcion,CodAlternativo,Costo,FechaCarga,FechaActualizacion,Imagen,Observaciones,PrecioVenta,Cantidad,Activo) VALUES(@IdProveedor,@IdRubro,@IdEstado,@Descripcion,@CodAlternativo,@Costo,@FechaCarga,@FechaActualizacion,@Imagen,@Observaciones,@PrecioVenta,@Cantidad,@Activo)"
                    Acciones.Parameters.AddWithValue("@IdProveedor", TxtIdProveedor.Text)
                    Acciones.Parameters.AddWithValue("@IdRubro", TxtIdRubro.Text)
                    Acciones.Parameters.AddWithValue("@IdEstado", TxtIdEstado.Text)
                    Acciones.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
                    Acciones.Parameters.AddWithValue("@CodAlternativo", TxtCodAlternativo.Text)
                    Acciones.Parameters.AddWithValue("@Costo", TxtCosto.Text)
                    Acciones.Parameters.AddWithValue("@FechaCarga", DtFechaCarga.Value)
                    Acciones.Parameters.AddWithValue("@FechaActualizacion", DtFechaActualizacion.Value)
                    Acciones.Parameters.AddWithValue("@Observaciones", TxtObservaciones.Text)
                    Acciones.Parameters.AddWithValue("@PrecioVenta", TxtPrecioVenta.Text)
                    Acciones.Parameters.AddWithValue("@Cantidad", TxtCantidad.Text)

                    If ChkActivo.Checked Then
                        Acciones.Parameters.AddWithValue("@Activo", True)
                    Else
                        Acciones.Parameters.AddWithValue("@Activo", False)
                    End If

                    ' Guardar la imagen en imagenBytes
                    Dim imagenBytes As Byte()
                    Using ms As New MemoryStream()
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        imagenBytes = ms.ToArray()
                    End Using

                    Acciones.Parameters.AddWithValue("@Imagen", imagenBytes)

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
                    ' Guardar la imagen en imagenBytes
                    Dim imagenBytes As Byte() = Nothing
                    If Not PictureBox1.Image Is Nothing Then
                        Using ms As New MemoryStream()
                            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                            imagenBytes = ms.ToArray()
                        End Using
                    End If

                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Productos SET IdProveedor = @IdProveedor, IdRubro = @IdRubro, IdEstado = @IdEstado, Descripcion = @Descripcion, CodAlternativo = @CodAlternativo, Costo = @Costo, FechaCarga = @FechaCarga, FechaActualizacion = @FechaActualizacion, Imagen = @Imagen, Observaciones = @Observaciones, PrecioVenta = @PrecioVenta, Activo = @Activo, Cantidad = @Cantidad WHERE IdProducto = @IdProducto"
                    Acciones.Parameters.AddWithValue("@IdProveedor", If(String.IsNullOrEmpty(TxtIdProveedor.Text), DBNull.Value, TxtIdProveedor.Text))
                    Acciones.Parameters.AddWithValue("@IdRubro", If(String.IsNullOrEmpty(TxtIdRubro.Text), DBNull.Value, TxtIdRubro.Text))
                    Acciones.Parameters.AddWithValue("@IdEstado", If(String.IsNullOrEmpty(TxtIdEstado.Text), DBNull.Value, TxtIdEstado.Text))
                    Acciones.Parameters.AddWithValue("@Descripcion", If(String.IsNullOrEmpty(TxtDescripcion.Text), DBNull.Value, TxtDescripcion.Text))
                    Acciones.Parameters.AddWithValue("@CodAlternativo", If(String.IsNullOrEmpty(TxtCodAlternativo.Text), DBNull.Value, TxtCodAlternativo.Text))
                    Acciones.Parameters.AddWithValue("@Costo", If(String.IsNullOrEmpty(TxtCosto.Text), DBNull.Value, TxtCosto.Text))
                    Acciones.Parameters.AddWithValue("@FechaCarga", DtFechaCarga.Value)
                    Acciones.Parameters.AddWithValue("@FechaActualizacion", DtFechaActualizacion.Value)
                    Acciones.Parameters.AddWithValue("@Imagen", If(imagenBytes Is Nothing OrElse imagenBytes.Length = 0, DBNull.Value, imagenBytes))
                    Acciones.Parameters.AddWithValue("@Observaciones", If(String.IsNullOrEmpty(TxtObservaciones.Text), DBNull.Value, TxtObservaciones.Text))
                    Acciones.Parameters.AddWithValue("@PrecioVenta", If(String.IsNullOrEmpty(TxtPrecioVenta.Text), DBNull.Value, TxtPrecioVenta.Text))
                    Acciones.Parameters.AddWithValue("@Cantidad", If(String.IsNullOrEmpty(TxtCantidad.Text), DBNull.Value, TxtCantidad.Text))
                    Acciones.Parameters.AddWithValue("@Activo", False)
                    Acciones.Parameters.AddWithValue("@IdProducto", Val(TxtIdProducto.Text))
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Close()
            Else
                If ChkActivo.Checked = True Then
                    Try
                        ' Guardar la imagen en imagenBytes
                        Dim imagenBytes As Byte() = Nothing
                        If Not PictureBox1.Image Is Nothing Then
                            Using ms As New MemoryStream()
                                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                                imagenBytes = ms.ToArray()
                            End Using
                        End If

                        Acciones.Connection = ConexionSql
                        Acciones.CommandType = CommandType.Text
                        Acciones.CommandText = "UPDATE Productos SET IdProveedor = @IdProveedor, IdRubro = @IdRubro, IdEstado = @IdEstado, Descripcion = @Descripcion, CodAlternativo = @CodAlternativo, Costo = @Costo, FechaCarga = @FechaCarga, FechaActualizacion = @FechaActualizacion, Imagen = @Imagen, Observaciones = @Observaciones, PrecioVenta = @PrecioVenta, Activo = @Activo, Cantidad = @Cantidad WHERE IdProducto = @IdProducto"
                        Acciones.Parameters.AddWithValue("@IdProveedor", If(String.IsNullOrEmpty(TxtIdProveedor.Text), DBNull.Value, TxtIdProveedor.Text))
                        Acciones.Parameters.AddWithValue("@IdRubro", If(String.IsNullOrEmpty(TxtIdRubro.Text), DBNull.Value, TxtIdRubro.Text))
                        Acciones.Parameters.AddWithValue("@IdEstado", If(String.IsNullOrEmpty(TxtIdEstado.Text), DBNull.Value, TxtIdEstado.Text))
                        Acciones.Parameters.AddWithValue("@Descripcion", If(String.IsNullOrEmpty(TxtDescripcion.Text), DBNull.Value, TxtDescripcion.Text))
                        Acciones.Parameters.AddWithValue("@CodAlternativo", If(String.IsNullOrEmpty(TxtCodAlternativo.Text), DBNull.Value, TxtCodAlternativo.Text))
                        Acciones.Parameters.AddWithValue("@Costo", If(String.IsNullOrEmpty(TxtCosto.Text), DBNull.Value, TxtCosto.Text))
                        Acciones.Parameters.AddWithValue("@FechaCarga", DtFechaCarga.Value)
                        Acciones.Parameters.AddWithValue("@FechaActualizacion", DtFechaActualizacion.Value)
                        Acciones.Parameters.AddWithValue("@Imagen", If(imagenBytes Is Nothing OrElse imagenBytes.Length = 0, DBNull.Value, imagenBytes))
                        Acciones.Parameters.AddWithValue("@Observaciones", If(String.IsNullOrEmpty(TxtObservaciones.Text), DBNull.Value, TxtObservaciones.Text))
                        Acciones.Parameters.AddWithValue("@PrecioVenta", If(String.IsNullOrEmpty(TxtPrecioVenta.Text), DBNull.Value, TxtPrecioVenta.Text))
                        Acciones.Parameters.AddWithValue("@Cantidad", If(String.IsNullOrEmpty(TxtCantidad.Text), DBNull.Value, TxtCantidad.Text))
                        Acciones.Parameters.AddWithValue("@Activo", True)
                        Acciones.Parameters.AddWithValue("@IdProducto", Val(TxtIdProducto.Text))
                        Acciones.ExecuteNonQuery()
                        MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If

            Close()
        End If

        FrmProductos.CargaProductos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        FrmRubro.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        FrmEstados.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If LblSeñal.Text = "Agregar" Then
            Try
                Acciones.Connection = ConexionSql
                Acciones.CommandType = CommandType.Text
                Acciones.CommandText = "INSERT INTO Productos(IdProveedor,IdRubro,IdEstado,Descripcion,CodAlternativo,Costo,FechaCarga,FechaActualizacion,Imagen,Observaciones,PrecioVenta,Cantidad,Activo) VALUES(@IdProveedor,@IdRubro,@IdEstado,@Descripcion,@CodAlternativo,@Costo,@FechaCarga,@FechaActualizacion,@Imagen,@Observaciones,@PrecioVenta,@Cantidad,@Activo)"
                Acciones.Parameters.AddWithValue("@IdProveedor", If(String.IsNullOrEmpty(TxtIdProveedor.Text), DBNull.Value, TxtIdProveedor.Text))
                Acciones.Parameters.AddWithValue("@IdRubro", If(String.IsNullOrEmpty(TxtIdRubro.Text), DBNull.Value, TxtIdRubro.Text))
                Acciones.Parameters.AddWithValue("@IdEstado", If(String.IsNullOrEmpty(TxtIdEstado.Text), DBNull.Value, TxtIdEstado.Text))
                Acciones.Parameters.AddWithValue("@Descripcion", If(String.IsNullOrEmpty(TxtDescripcion.Text), DBNull.Value, TxtDescripcion.Text))
                Acciones.Parameters.AddWithValue("@CodAlternativo", If(String.IsNullOrEmpty(TxtCodAlternativo.Text), DBNull.Value, TxtCodAlternativo.Text))
                Acciones.Parameters.AddWithValue("@Costo", If(String.IsNullOrEmpty(TxtCosto.Text), DBNull.Value, TxtCosto.Text))
                Acciones.Parameters.AddWithValue("@FechaCarga", DtFechaCarga.Value)
                Acciones.Parameters.AddWithValue("@FechaActualizacion", DtFechaActualizacion.Value)
                Acciones.Parameters.AddWithValue("@Observaciones", If(String.IsNullOrEmpty(TextBox1.Text), DBNull.Value, TextBox1.Text))
                Acciones.Parameters.AddWithValue("@PrecioVenta", If(String.IsNullOrEmpty(TxtPrecioVenta.Text), DBNull.Value, TxtPrecioVenta.Text))
                Acciones.Parameters.AddWithValue("@Cantidad", If(String.IsNullOrEmpty(TxtCantidad.Text), DBNull.Value, TxtCantidad.Text))

                If ChkActivo.Checked Then
                    Acciones.Parameters.AddWithValue("@Activo", True)
                Else
                    Acciones.Parameters.AddWithValue("@Activo", False)
                End If

                Dim imagenBytes As Byte() = Nothing ' Inicializa imagenBytes como Nothing

                If PictureBox1.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        imagenBytes = ms.ToArray()
                    End Using
                End If

                If imagenBytes Is Nothing Then
                    Acciones.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = DBNull.Value
                Else
                    Acciones.Parameters.Add("@Imagen", SqlDbType.VarBinary).Value = imagenBytes
                End If




                Acciones.ExecuteNonQuery()
                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Close()
        End If
        'End If
        If LblSeñal.Text = "Modificar" Then
            If ChkActivo.Checked = False Then
                Try
                    ' Guardar la imagen en imagenBytes
                    Dim imagenBytes As Byte() = Nothing
                    If Not PictureBox1.Image Is Nothing Then
                        Using ms As New MemoryStream()
                            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                            imagenBytes = ms.ToArray()
                        End Using
                    End If

                    Acciones.Connection = ConexionSql
                    Acciones.CommandType = CommandType.Text
                    Acciones.CommandText = "UPDATE Productos SET IdProveedor = @IdProveedor, IdRubro = @IdRubro, IdEstado = @IdEstado, Descripcion = @Descripcion, CodAlternativo = @CodAlternativo, Costo = @Costo, FechaCarga = @FechaCarga, FechaActualizacion = @FechaActualizacion, Imagen = @Imagen, Observaciones = @Observaciones, PrecioVenta = @PrecioVenta, Activo = @Activo, Cantidad = @Cantidad WHERE IdProducto = @IdProducto"
                    Acciones.Parameters.AddWithValue("@IdProveedor", If(String.IsNullOrEmpty(TxtIdProveedor.Text), DBNull.Value, TxtIdProveedor.Text))
                    Acciones.Parameters.AddWithValue("@IdRubro", If(String.IsNullOrEmpty(TxtIdRubro.Text), DBNull.Value, TxtIdRubro.Text))
                    Acciones.Parameters.AddWithValue("@IdEstado", If(String.IsNullOrEmpty(TxtIdEstado.Text), DBNull.Value, TxtIdEstado.Text))
                    Acciones.Parameters.AddWithValue("@Descripcion", If(String.IsNullOrEmpty(TxtDescripcion.Text), DBNull.Value, TxtDescripcion.Text))
                    Acciones.Parameters.AddWithValue("@CodAlternativo", If(String.IsNullOrEmpty(TxtCodAlternativo.Text), DBNull.Value, TxtCodAlternativo.Text))
                    Acciones.Parameters.AddWithValue("@Costo", If(String.IsNullOrEmpty(TxtCosto.Text), DBNull.Value, TxtCosto.Text))
                    Acciones.Parameters.AddWithValue("@FechaCarga", DtFechaCarga.Value)
                    Acciones.Parameters.AddWithValue("@FechaActualizacion", DtFechaActualizacion.Value)
                    Acciones.Parameters.AddWithValue("@Imagen", If(imagenBytes Is Nothing OrElse imagenBytes.Length = 0, DBNull.Value, imagenBytes))
                    Acciones.Parameters.AddWithValue("@Observaciones", If(String.IsNullOrEmpty(TxtObservaciones.Text), DBNull.Value, TxtObservaciones.Text))
                    Acciones.Parameters.AddWithValue("@PrecioVenta", If(String.IsNullOrEmpty(TxtPrecioVenta.Text), DBNull.Value, TxtPrecioVenta.Text))
                    Acciones.Parameters.AddWithValue("@Cantidad", If(String.IsNullOrEmpty(TxtCantidad.Text), DBNull.Value, TxtCantidad.Text))
                    Acciones.Parameters.AddWithValue("@Activo", False)
                    Acciones.Parameters.AddWithValue("@IdProducto", Val(TxtIdProducto.Text))
                    Acciones.ExecuteNonQuery()
                    MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Close()
            Else
                If ChkActivo.Checked = True Then
                    Try
                        ' Guardar la imagen en imagenBytes
                        Dim imagenBytes As Byte() = Nothing
                        If Not PictureBox1.Image Is Nothing Then
                            Using ms As New MemoryStream()
                                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                                imagenBytes = ms.ToArray()
                            End Using
                        End If

                        Acciones.Connection = ConexionSql
                        Acciones.CommandType = CommandType.Text
                        Acciones.CommandText = "UPDATE Productos SET IdProveedor = @IdProveedor, IdRubro = @IdRubro, IdEstado = @IdEstado, Descripcion = @Descripcion, CodAlternativo = @CodAlternativo, Costo = @Costo, FechaCarga = @FechaCarga, FechaActualizacion = @FechaActualizacion, Imagen = @Imagen, Observaciones = @Observaciones, PrecioVenta = @PrecioVenta, Activo = @Activo, Cantidad = @Cantidad WHERE IdProducto = @IdProducto"
                        Acciones.Parameters.AddWithValue("@IdProveedor", If(String.IsNullOrEmpty(TxtIdProveedor.Text), DBNull.Value, TxtIdProveedor.Text))
                        Acciones.Parameters.AddWithValue("@IdRubro", If(String.IsNullOrEmpty(TxtIdRubro.Text), DBNull.Value, TxtIdRubro.Text))
                        Acciones.Parameters.AddWithValue("@IdEstado", If(String.IsNullOrEmpty(TxtIdEstado.Text), DBNull.Value, TxtIdEstado.Text))
                        Acciones.Parameters.AddWithValue("@Descripcion", If(String.IsNullOrEmpty(TxtDescripcion.Text), DBNull.Value, TxtDescripcion.Text))
                        Acciones.Parameters.AddWithValue("@CodAlternativo", If(String.IsNullOrEmpty(TxtCodAlternativo.Text), DBNull.Value, TxtCodAlternativo.Text))
                        Acciones.Parameters.AddWithValue("@Costo", If(String.IsNullOrEmpty(TxtCosto.Text), DBNull.Value, TxtCosto.Text))
                        Acciones.Parameters.AddWithValue("@FechaCarga", DtFechaCarga.Value)
                        Acciones.Parameters.AddWithValue("@FechaActualizacion", DtFechaActualizacion.Value)
                        Acciones.Parameters.AddWithValue("@Imagen", If(imagenBytes Is Nothing OrElse imagenBytes.Length = 0, DBNull.Value, imagenBytes))
                        Acciones.Parameters.AddWithValue("@Observaciones", If(String.IsNullOrEmpty(TxtObservaciones.Text), DBNull.Value, TxtObservaciones.Text))
                        Acciones.Parameters.AddWithValue("@PrecioVenta", If(String.IsNullOrEmpty(TxtPrecioVenta.Text), DBNull.Value, TxtPrecioVenta.Text))
                        Acciones.Parameters.AddWithValue("@Cantidad", If(String.IsNullOrEmpty(TxtCantidad.Text), DBNull.Value, TxtCantidad.Text))
                        Acciones.Parameters.AddWithValue("@Activo", True)
                        Acciones.Parameters.AddWithValue("@IdProducto", Val(TxtIdProducto.Text))
                        Acciones.ExecuteNonQuery()
                        MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation, "MENSAJE DEL SISTEMA")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If

            Close()
        End If

        FrmProductos.CargaProductos()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        FrmProveedor.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmRubro.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmEstados.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class