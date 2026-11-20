Imports System.Data
Imports System.Data.SqlClient

Public Class F3

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Private Sub F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Name of Employee"
        Me.TextBox1.Focus()
        Me.EmployeeTableAdapter.FillByYearWiseRetirements(Me.HURMISDataSet.employee)

        'If EmployeeDataGridView.CurrentRow.Cells("retdDate").Value > Now() Then
        '    Me.EmployeeDataGridView.Columns(e.ColumnIndex).Enabled = True
        '    EmployeeDataGridView.Rows.("RetdBtn").Enabled = True
        'End If

        Dim srvTbl As New DataTable()
        srvTbl.Columns.Add("srvDesc")
        srvTbl.Columns.Add("srvId")
        srvTbl.Rows.Add("Serving", "S")
        srvTbl.Rows.Add("Retired", "R")
        SrvComboBox.DataSource = srvTbl
        SrvComboBox.DisplayMember = "srvDesc"
        SrvComboBox.ValueMember = "srvId"

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = vbNullString
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim x As String = "nic"
        If ComboBox1.Text = "CNIC Number of Employee" Then
            x = "nic"
            TextBox1.MaxLength = 13
        ElseIf ComboBox1.Text = "Name of Employee" Then
            x = "name"
            TextBox1.MaxLength = 35
        ElseIf ComboBox1.Text = "Designation of Employee" Then
            x = "post"
            TextBox1.MaxLength = 65
        ElseIf ComboBox1.Text = "Regional / Field Office" Then
            x = "rofo"
            TextBox1.MaxLength = 30
        End If

        Try
            EmployeeBindingSource.Filter = x & " like '%" & TextBox1.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub goBackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goBackButton.Click
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            If SrvComboBox.SelectedValue = "R" And (RdTextBox.Text = vbNullString Or RdTextBox.Text > EmployeeDataGridView.CurrentRow.Cells("retdDate").Value) Then
                MsgBox("INVALID DATE")
            Else
                Me.Validate()
                Me.EmployeeBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.HURMISDataSet)
                Me.EmployeeTableAdapter.FillByYearWiseRetirements(Me.HURMISDataSet.employee)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EmployeeDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
        Try
            If Me.EmployeeDataGridView.Columns(e.ColumnIndex).Name = "RetdBtn" Then
                SrvComboBox.SelectedValue = "R"
                If Me.RdTextBox.Text = vbNullString Then
                    Me.RdTextBox.Text = EmployeeBindingSource.Current("retdDate")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub EmployeeDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
    '    Try
    '        If Me.EmployeeDataGridView.Columns(e.ColumnIndex).Name = "updateButton" Then
    '            postDescription = EmployeeDataGridView.CurrentRow.Cells("post").Value
    '            cnicNo = EmployeeDataGridView.CurrentRow.Cells("nic").Value
    '            fromWhere = "fromF1"
    '            F2.Show()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
End Class