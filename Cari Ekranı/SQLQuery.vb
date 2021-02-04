Imports System.Data.SqlClient

Public Class SQLQuery

    Shared connectionString As String = "Data Source=YAZILIM4\MEGA;Initial Catalog=MegaData_TEST;Integrated Security=True;Persist Security Info=True;User ID=sa"

    Shared connection As New SqlConnection(connectionString)

    Public Shared Function cmdMaker(str As String) As DataTable

        Dim sqlCommand As New SqlCommand(str, connection)
        Dim dataTable As New DataTable
        Dim sqlDataAdapter As New SqlDataAdapter(str, connection)

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            sqlDataAdapter.Fill(dataTable)
            sqlCommand.Dispose()
            Return dataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        connection.Close()
        Return Nothing
    End Function

    Public Shared Function cmd(str As String)
        Dim sqlCommand As New SqlCommand(str, connection)

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Return sqlCommand.ExecuteScalar()
            sqlCommand.Dispose()

        Catch ex As Exception
            MessageBox.Show("SQL Query Hatası: " & ex.Message, "Error")
        End Try
        connection.Close()
        Return Nothing
    End Function

End Class
