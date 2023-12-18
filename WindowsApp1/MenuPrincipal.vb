Public Class MenuPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConexionSql.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Productos;Data Source=DESKTOP-42PQ4QK\SQLEXPRESS; Multipleactiveresultsets=True"
            ConexionSql.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        FrmProveedor.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        FrmProductos.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        Frmciudades.Show()
    End Sub

    Private Sub RubrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RubrosToolStripMenuItem.Click
        FrmRubro.Show()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click
        FrmEstados.Show()
    End Sub

    Private Sub CondicionIvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CondicionIvaToolStripMenuItem.Click
        FrmCondicionIva.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmClientes.Show()
    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        FrmVentas.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FrmListadoFecha.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Close()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        FrmListaClientes.Show()
    End Sub

    Private Sub ToolStripSeparator4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
