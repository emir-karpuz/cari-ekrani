Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class SQLQuery

    'ALTERNATİF OLARAK SQL CLIENT BAĞLANTILARI DA BULUNUYOR.

    'Shared alternativeConnection As String = "Data Source=ASUS-FX553;Initial Catalog=MegaData_TEST;Integrated Security=True;Persist Security Info=True"
    'Shared connectionString As String = "Data Source=YAZILIM4\MEGA;Initial Catalog=MegaData_TEST;Integrated Security=True;Persist Security Info=True;User ID=sa"

    'Shared connection As New SqlConnection(frmAnaMenu.connection)
    Shared connection As New OleDbConnection(frmAnaMenu.connection)

    Public Shared Function cmdDataTable(str As String) As DataTable

        Dim dataTable As New DataTable
        'Dim sqlDataAdapter As New SqlDataAdapter(str, connection)
        Dim oleDBDataAdapter As New OleDbDataAdapter(str, connection)

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'SqlDataAdapter.Fill(dataTable)
            oleDBDataAdapter.Fill(dataTable)
            Return dataTable
        Catch ex As Exception
            MessageBox.Show("SORGU HATASI: " & ex.Message & Environment.NewLine & ex.StackTrace, "Error")
        End Try

        connection.Close()

        Return Nothing
    End Function

    Public Shared Function cmdFirstData(str As String)
        'Dim sqlCommand As New SqlCommand(str, connection)
        Dim oleDBCommand As New OleDbCommand(str, connection)

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Return oleDBCommand.ExecuteScalar()
            oleDBCommand.Dispose()

        Catch ex As Exception
            MessageBox.Show("SORGU HATASI: " & ex.Message & Environment.NewLine & ex.StackTrace, "Error")
        End Try
        connection.Close()
        Return Nothing
    End Function

End Class
