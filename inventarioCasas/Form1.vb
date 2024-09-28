Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = "Data Source=DESKTOP-3SLI41N;Initial Catalog=USPG;Persist Security Info=True;User ID=sa;Password=1234"

    Public Sub Form1_Load(sender As Object, e As EventArgs)
        ActualizarDataGridView()
    End Sub

    Public Sub ActualizarDataGridView()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "SELECT
                [nombreCasa],
                [ubicacion],
                [precio],
                [metrosCuadrosTerreno],
                [metrosCuadradosConstruccion]
                FROM [casas];"

                Dim adapter As New SqlDataAdapter(sql, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos del DataGridView:" & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDataGridView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
