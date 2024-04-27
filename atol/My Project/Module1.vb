Imports MySql.Data.MySqlClient
Module Module1
    Private connStr As String = "server=localhost;port=3306;user id=root;password=;database=db_tugas;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connStr)
        Return conn
    End Function

    Public Sub CloseConnection(ByVal conn As MySqlConnection)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module
