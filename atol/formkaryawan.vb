Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class formkaryawan
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim namaKaryawan As String = txtkaryawan.Text
        Dim jenisKelamin As String = cmbkelamin.SelectedItem.ToString()
        Dim email As String = txtemail.Text
        Dim tanggalLahir As String = cmbtanggallahir.Value.ToString("yyyy-MM-dd")
        Dim hakAkses As String = txtakses.Text.ToString()
        Dim status As String = "Aktif" ' Misalnya, status default adalah "Aktif"

        ' Validasi data
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(namaKaryawan) _
            OrElse String.IsNullOrWhiteSpace(jenisKelamin) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(hakAkses) Then
            MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Lakukan insert data ke dalam database
        Try
            Using conn As MySqlConnection = KoneksiDatabase.GetConnection()
                conn.Open()

                Dim query As String = "INSERT INTO tb_atol (Username, Password, Nama, JenisKelamin, TanggalLahir, Email,  Akses, Status) " &
                                      "VALUES (@Username, @Password, @Nama, @JenisKelamin, @TanggalLahir, @Email, @HakAkses, @Status)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@Nama", namaKaryawan)
                    cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@TanggalLahir", tanggalLahir)
                    cmd.Parameters.AddWithValue("@HakAkses", hakAkses)
                    cmd.Parameters.AddWithValue("@Status", status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            TampilkanData()
            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanForm()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub BersihkanForm()
        ' Membersihkan form setelah data disimpan
        txtusername.Clear()
        txtpassword.Clear()
        txtkaryawan.Clear()
        cmbkelamin.SelectedIndex = -1
        txtemail.Clear()
        cmbtanggallahir.Value = DateTime.Now
        txtakses.Clear()
    End Sub

    Private Sub formkaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub

    Private Sub TampilkanData()
        Try
            Using conn As MySqlConnection = KoneksiDatabase.GetConnection()
                conn.Open()

                Dim query As String = "SELECT * FROM tb_atol"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dataTable As New DataSet()
                        adapter.Fill(dataTable, "tb_atol")

                        DataGridView1.DataSource = dataTable.Tables("tb_atol")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = Integer.Parse(DataGridView1.SelectedRows(0).Cells("ID").Value.ToString())
            Dim username As String = txtusername.Text
            Dim password As String = txtpassword.Text
            Dim namaKaryawan As String = txtkaryawan.Text
            Dim jenisKelamin As String = cmbkelamin.SelectedItem.ToString()
            Dim email As String = txtemail.Text
            Dim tanggalLahir As String = cmbtanggallahir.Value.ToString("yyyy-MM-dd")
            Dim hakAkses As String = txtakses.Text.ToString()
            Dim status As String = "Aktif" ' Misalnya, status default adalah "Aktif"

            ' Validasi data
            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(namaKaryawan) _
            OrElse String.IsNullOrWhiteSpace(jenisKelamin) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(hakAkses) Then
                MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Lakukan update data di dalam database
            Try
                Using conn As MySqlConnection = KoneksiDatabase.GetConnection()
                    conn.Open()

                    Dim query As String = "UPDATE tb_atol SET Username = @Username, Password = @Password, Nama = @Nama, " &
                                      "JenisKelamin = @JenisKelamin, TanggalLahir = @TanggalLahir, Email = @Email, " &
                                      "Akses = @HakAkses, Status = @Status WHERE ID = @ID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Username", username)
                        cmd.Parameters.AddWithValue("@Password", password)
                        cmd.Parameters.AddWithValue("@Nama", namaKaryawan)
                        cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin)
                        cmd.Parameters.AddWithValue("@Email", email)
                        cmd.Parameters.AddWithValue("@TanggalLahir", tanggalLahir)
                        cmd.Parameters.AddWithValue("@HakAkses", hakAkses)
                        cmd.Parameters.AddWithValue("@Status", status)
                        cmd.Parameters.AddWithValue("@ID", id)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilkanData() ' Menampilkan data terbaru setelah update
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Pilih baris yang akan diupdate.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtusername.Text = row.Cells("Username").Value.ToString()
            txtpassword.Text = row.Cells("Password").Value.ToString()
            txtkaryawan.Text = row.Cells("Nama").Value.ToString()
            cmbkelamin.SelectedItem = row.Cells("JenisKelamin").Value.ToString()
            txtemail.Text = row.Cells("Email").Value.ToString()
            cmbtanggallahir.Value = DateTime.Parse(row.Cells("TanggalLahir").Value.ToString())
            txtakses.Text = row.Cells("Akses").Value.ToString()


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = Integer.Parse(DataGridView1.SelectedRows(0).Cells("ID").Value.ToString())

            ' Konfirmasi penghapusan
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Using conn As MySqlConnection = KoneksiDatabase.GetConnection()
                        conn.Open()

                        Dim query As String = "DELETE FROM tb_atol WHERE ID = @ID"

                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@ID", id)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TampilkanData() ' Menampilkan data terbaru setelah penghapusan
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Pilih baris yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class