Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class formlogin
    Private Sub formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username = TextBox1.Text
        Dim password = TextBox2.Text

        Dim role = GetRoleFromDatabase(username, password)

        If role IsNot Nothing Then
            MessageBox.Show("Login berhasil! Peran Anda: " & role)
            ' Sembunyikan form login
            Hide()
        Else
            MessageBox.Show("Login gagal. Cek kembali username dan password.")
        End If
    End Sub
    Private Function GetRoleFromDatabase(username As String, password As String) As String
        Using connection As MySqlConnection = KoneksiDatabase.GetConnection()
            Try
                connection.Open()

                Dim query As String = "SELECT tb_atol FROM users WHERE Username=? AND Password=?"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)

                    Dim role As Object = command.ExecuteScalar()
                    Return If(role IsNot Nothing, role.ToString(), Nothing)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

End Class