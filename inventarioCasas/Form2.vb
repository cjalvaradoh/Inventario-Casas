Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=DESKTOP-3SLI41N;Initial Catalog=USPG;Persist Security Info=True;User ID=sa;Password=1234"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "INSERT INTO casas (nombreCasa, ubicacion, precio, metrosCuadrosTerreno, metrosCuadradosConstruccion) VALUES (@nombreCasa, @ubicacion, @precio, @metrosCuadrosTerreno, @metrosCuadradosConstruccion)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@nombreCasa", TextBox1.Text) ' nombreCasa
                    command.Parameters.AddWithValue("@ubicacion", TextBox2.Text) ' ubicacion
                    command.Parameters.AddWithValue("@precio", TextBox3.Text) ' precio
                    command.Parameters.AddWithValue("@metrosCuadrosTerreno", TextBox4.Text) ' metrosCuadrosTerreno
                    command.Parameters.AddWithValue("@metrosCuadradosConstruccion", TextBox5.Text) ' metrosCuadradosConstruccion

                    command.ExecuteNonQuery()
                    MessageBox.Show("Producto registrado correctamente en la base de datos.")

                    Dim form1 As Form1 = CType(Application.OpenForms("Form1"), Form1)
                    If form1 IsNot Nothing Then
                        form1.ActualizarDataGridView()
                    End If

                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    TextBox5.Text = ""

                End Using

                Form1.Show()
                Me.Hide()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al intentar registrar el producto :" & ex.Message)
        End Try
    End Sub
End Class
