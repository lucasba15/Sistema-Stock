Public Class FrmListaClientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmClientes.LblSeñal.Text = "Listado"
        FrmClientes.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BorraTemporal()
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "DELETE FROM Reporte"
        Acciones.Parameters.Clear()
        Acciones.ExecuteNonQuery()
    End Sub
    Private Function LlenaTemporal() As Boolean
        Acciones.Connection = ConexionSql
        Acciones.CommandType = CommandType.Text
        Acciones.CommandText = "SELECT FechaVenta, Apellido, Nombre, TipoComprobante, NroComprobante, TotalVenta FROM Ventas WHERE FechaVenta >= @DesdeFecha AND FechaVenta <= @HastaFecha AND Apellido = @Apellido AND Nombre = @Nombre"
        Acciones.CommandText += " ORDER BY FechaVenta"
        Acciones.Parameters.AddWithValue("@DesdeFecha", DtDesde.Value.Date)
        Acciones.Parameters.AddWithValue("@HastaFecha", DtHasta.Value.Date)
        Acciones.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
        Acciones.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        LectorDatos = Acciones.ExecuteReader


        ' LectorDatos.Close()

        If LectorDatos.HasRows Then
            Dim acumulado As Decimal = 0
            While LectorDatos.Read()
                Try
                    Acciones2.Connection = ConexionSql
                    Acciones2.CommandType = CommandType.Text
                    Acciones2.CommandText = "INSERT INTO Reporte(Campo1, Campo2, Campo3, Campo4, Campo5, Campo6) VALUES(@Campo1, @Campo2, @Campo3, @Campo4, @Campo5, @Campo6)"
                    Dim tipoComprobante As String = LectorDatos(3)
                    Dim totalVenta As Decimal = LectorDatos(5)
                    Dim campo6Value As Decimal

                    If tipoComprobante = "Devolucion" Then
                        campo6Value = -totalVenta
                    Else
                        campo6Value = totalVenta
                    End If
                    acumulado += campo6Value
                    Acciones2.Parameters.AddWithValue("@Campo1", LectorDatos(0))
                    Acciones2.Parameters.AddWithValue("@Campo2", $"{LectorDatos(1)} {LectorDatos(2)}")
                    Acciones2.Parameters.AddWithValue("@Campo3", LectorDatos(3))
                    Acciones2.Parameters.AddWithValue("@Campo4", LectorDatos(4))
                    Acciones2.Parameters.AddWithValue("@Campo5", LectorDatos(5))
                    Acciones2.Parameters.AddWithValue("@Campo6", acumulado)
                    Acciones2.ExecuteNonQuery()
                    Acciones2.Parameters.Clear()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End While
            Return True
        Else

            MsgBox("No existen datos para esta Consulta", vbOKOnly + vbInformation, "Mensaje del Sistema")
            Return False
        End If
        LectorDatos.Close()
    End Function

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        BorraTemporal()
        If LlenaTemporal() Then
            FrmCrystalReport.Show()
            LectorDatos.Close()
        Else
            LectorDatos.Close()
        End If
    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Close()
    End Sub

    Private Sub FrmListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtDesde.Value = DateTime.Now
        DtHasta.Value = DateTime.Now
    End Sub
End Class