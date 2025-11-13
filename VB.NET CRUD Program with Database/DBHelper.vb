Imports MySql.Data.MySqlClient

Module DBHelper
    ' Centralized connection string
    Public ReadOnly Property ConnectionString As String
        Get
            Return "server=localhost;userid=root;password=;database=auto_gen_CRUD_zev"
        End Get
    End Property

    ' Returns a new MySQL connection
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    ' Get the next EntryCounter based on last record
    Public Function GetNextEntryCounter() As Integer
        Dim counter As Integer = 1
        Try
            Using con As MySqlConnection = GetConnection()
                con.Open()
                Dim query As String = "SELECT MAX(unique_key) FROM students"
                Using cmd As New MySqlCommand(query, con)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result.ToString() <> "" Then
                        ' Extract numeric part from last key (assumes format: YYYY-DEPT00001XX)
                        Dim keyNumPart As String = New String(result.ToString().SkipWhile(Function(c) Not Char.IsDigit(c)).ToArray())
                        If keyNumPart.Length >= 5 Then
                            Dim lastNum As Integer
                            If Integer.TryParse(keyNumPart.Substring(3, 5), lastNum) Then
                                counter = lastNum + 1
                            End If
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting next entry number: " & ex.Message)
        End Try
        Return counter
    End Function
End Module
