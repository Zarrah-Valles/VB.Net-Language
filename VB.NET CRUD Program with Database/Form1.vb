Imports MySql.Data.MySqlClient

Public Class Form1
    Dim EntryCounter As Integer

    ' === FORM LOAD ===
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EntryCounter = DBHelper.GetNextEntryCounter()
        LoadData()
    End Sub

    ' === GENERATE UNIQUE KEY ===
    Private Function GenerateUniqueKey(entryYear As Integer, birthYear As Integer, department As String, fullName As String) As String
        Dim specialChar As String = "-"
        Dim deptInitial As String = department.Substring(0, Math.Min(3, department.Length)).ToUpper()
        Dim entryNumber As String = EntryCounter.ToString("D5")
        Dim nameInitials As String = String.Join("", fullName.Split(" "c).Select(Function(n) If(n.Length > 0, n(0), ""))).ToUpper()

        Dim uniqueKey As String = $"{entryYear Mod 100}{birthYear Mod 100}{specialChar}{deptInitial}{entryNumber}{nameInitials}"
        EntryCounter += 1
        Return uniqueKey
    End Function

    ' === CREATE RECORD ===
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim name As String = txtName.Text.Trim()
            Dim birthYear As Integer = CInt(txtBirthYear.Text)
            Dim department As String = txtDepartment.Text.Trim()
            Dim entryYear As Integer = CInt(txtEntryYear.Text)
            Dim uniqueKey As String = GenerateUniqueKey(entryYear, birthYear, department, name)

            Using con As MySqlConnection = DBHelper.GetConnection()
                con.Open()
                Dim query As String = "INSERT INTO students (unique_key, name, birth_year, department, entry_year)
                                       VALUES (@key, @name, @birth, @dept, @entry)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@key", uniqueKey)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@birth", birthYear)
                    cmd.Parameters.AddWithValue("@dept", department)
                    cmd.Parameters.AddWithValue("@entry", entryYear)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Record added successfully!")
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding record: " & ex.Message)
        End Try
    End Sub

    ' === READ DATA ===
    Private Sub LoadData(Optional searchTerm As String = "")
        Try
            Using con As MySqlConnection = DBHelper.GetConnection()
                con.Open()
                Dim query As String
                If searchTerm = "" Then
                    query = "SELECT * FROM students"
                Else
                    query = "SELECT * FROM students WHERE name LIKE @term OR department LIKE @term"
                End If

                Using cmd As New MySqlCommand(query, con)
                    If searchTerm <> "" Then
                        cmd.Parameters.AddWithValue("@term", "%" & searchTerm & "%")
                    End If
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvStudents.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' === UPDATE RECORD ===
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If dgvStudents.CurrentRow IsNot Nothing Then
                Dim uniqueKey As String = dgvStudents.CurrentRow.Cells("unique_key").Value.ToString()
                Dim name As String = txtName.Text.Trim()
                Dim birthYear As Integer = CInt(txtBirthYear.Text)
                Dim department As String = txtDepartment.Text.Trim()
                Dim entryYear As Integer = CInt(txtEntryYear.Text)

                Using con As MySqlConnection = DBHelper.GetConnection()
                    con.Open()
                    Dim query As String = "UPDATE students 
                                           SET name=@name, birth_year=@birth, department=@dept, entry_year=@entry
                                           WHERE unique_key=@key"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@key", uniqueKey)
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@birth", birthYear)
                        cmd.Parameters.AddWithValue("@dept", department)
                        cmd.Parameters.AddWithValue("@entry", entryYear)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Record updated successfully!")
                LoadData()
                ClearFields()
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message)
        End Try
    End Sub

    ' === DELETE RECORD ===
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If dgvStudents.CurrentRow IsNot Nothing Then
                Dim uniqueKey As String = dgvStudents.CurrentRow.Cells("unique_key").Value.ToString()

                Using con As MySqlConnection = DBHelper.GetConnection()
                    con.Open()
                    Dim query As String = "DELETE FROM students WHERE unique_key=@key"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@key", uniqueKey)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Record deleted successfully!")
                LoadData()
                ClearFields()
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        End Try
    End Sub

    ' === SEARCH ===
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData(txtSearch.Text.Trim())
    End Sub

    ' === GRID SELECTION ===
    Private Sub dgvStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudents.SelectionChanged
        If dgvStudents.CurrentRow IsNot Nothing Then
            txtName.Text = dgvStudents.CurrentRow.Cells("name").Value.ToString()
            txtBirthYear.Text = dgvStudents.CurrentRow.Cells("birth_year").Value.ToString()
            txtDepartment.Text = dgvStudents.CurrentRow.Cells("department").Value.ToString()
            txtEntryYear.Text = dgvStudents.CurrentRow.Cells("entry_year").Value.ToString()
        End If
    End Sub

    ' === CLEAR INPUTS ===
    Private Sub ClearFields()
        txtName.Clear()
        txtBirthYear.Clear()
        txtDepartment.Clear()
        txtEntryYear.Clear()
        txtSearch.Clear()
    End Sub

End Class
