<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DATABASE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtName = New TextBox()
        txtBirthYear = New TextBox()
        txtDepartment = New TextBox()
        txtEntryYear = New TextBox()
        txtSearch = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        btnClear = New Button()
        btnExit = New Button()
        dgvStudents = New DataGridView()
        unique_key = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        birth_year = New DataGridViewTextBoxColumn()
        department = New DataGridViewTextBoxColumn()
        entry_year = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12.0F)
        txtName.Location = New Point(149, 20)
        txtName.Name = "txtName"
        txtName.Size = New Size(257, 29)
        txtName.TabIndex = 0
        ' 
        ' txtBirthYear
        ' 
        txtBirthYear.Font = New Font("Segoe UI", 12.0F)
        txtBirthYear.Location = New Point(149, 67)
        txtBirthYear.Name = "txtBirthYear"
        txtBirthYear.Size = New Size(257, 29)
        txtBirthYear.TabIndex = 1
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Segoe UI", 12.0F)
        txtDepartment.Location = New Point(149, 112)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(257, 29)
        txtDepartment.TabIndex = 2
        ' 
        ' txtEntryYear
        ' 
        txtEntryYear.Font = New Font("Segoe UI", 12.0F)
        txtEntryYear.Location = New Point(149, 154)
        txtEntryYear.Name = "txtEntryYear"
        txtEntryYear.Size = New Size(257, 29)
        txtEntryYear.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12.0F)
        txtSearch.Location = New Point(520, 19)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(257, 29)
        txtSearch.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Green
        btnAdd.Font = New Font("Tahoma", 12.0F)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(60, 202)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(101, 33)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.ForestGreen
        btnUpdate.Font = New Font("Tahoma", 12.0F)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(190, 202)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(101, 33)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Green
        btnDelete.Font = New Font("Tahoma", 12.0F)
        btnDelete.ForeColor = Color.Transparent
        btnDelete.Location = New Point(321, 202)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(101, 33)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Green
        btnSearch.Font = New Font("Tahoma", 12.0F)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(545, 63)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(101, 33)
        btnSearch.TabIndex = 8
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Orange
        btnClear.Font = New Font("Tahoma", 12.0F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(453, 202)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(101, 33)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.Font = New Font("Tahoma", 12.0F)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(584, 202)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 33)
        btnExit.TabIndex = 16
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' dgvStudents
        ' 
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.BackgroundColor = Color.FromArgb(192, 255, 192)
        dgvStudents.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {unique_key, colName, birth_year, department, entry_year})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
        dgvStudents.GridColor = Color.Black
        dgvStudents.Location = New Point(2, 253)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        dgvStudents.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvStudents.Size = New Size(935, 243)
        dgvStudents.TabIndex = 9
        ' 
        ' unique_key
        ' 
        unique_key.HeaderText = "Unique Key"
        unique_key.Name = "unique_key"
        unique_key.ReadOnly = True
        unique_key.Width = 200
        ' 
        ' colName
        ' 
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.Width = 200
        ' 
        ' birth_year
        ' 
        birth_year.HeaderText = "BirthYear"
        birth_year.Name = "birth_year"
        birth_year.Width = 150
        ' 
        ' department
        ' 
        department.HeaderText = "Department"
        department.Name = "department"
        department.Width = 150
        ' 
        ' entry_year
        ' 
        entry_year.HeaderText = "Entry Year"
        entry_year.Name = "entry_year"
        entry_year.Width = 120
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.Location = New Point(25, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 19)
        Label1.TabIndex = 10
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.Location = New Point(25, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 19)
        Label2.TabIndex = 11
        Label2.Text = "Birth Year:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label3.Location = New Point(25, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 19)
        Label3.TabIndex = 12
        Label3.Text = "Department: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label4.Location = New Point(25, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 19)
        Label4.TabIndex = 13
        Label4.Text = "Entry Year:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label5.Location = New Point(444, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 19)
        Label5.TabIndex = 14
        Label5.Text = "Search:"
        ' 
        ' DATABASE
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(192, 255, 192)
        ClientSize = New Size(935, 517)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvStudents)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtSearch)
        Controls.Add(txtEntryYear)
        Controls.Add(txtDepartment)
        Controls.Add(txtBirthYear)
        Controls.Add(txtName)
        Name = "DATABASE"
        Text = "DATABASE"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBirthYear As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtEntryYear As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents unique_key As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents birth_year As DataGridViewTextBoxColumn
    Friend WithEvents department As DataGridViewTextBoxColumn
    Friend WithEvents entry_year As DataGridViewTextBoxColumn

End Class
