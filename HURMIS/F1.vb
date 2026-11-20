Imports System.Data
Imports System.Data.SqlClient

Public Class F1

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Dim StrError As String = Nothing
    Dim StrConn As String = My.Settings.HURMISConnectionString

    Private Sub F1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Name of Employee"
        Me.TextBox1.Focus()

        Dim statusTbl As New DataTable()
        statusTbl.Columns.Add("statusDesc")
        statusTbl.Columns.Add("statusId")
        statusTbl.Rows.Add("Recommended", "R")
        statusTbl.Rows.Add("Rejected", "J")
        statusTbl.Rows.Add("Under Process", "U")
        statusTbl.Rows.Add("Pend", "P")
        StatusComboBox.DataSource = statusTbl
        StatusComboBox.DisplayMember = "statusDesc"
        StatusComboBox.ValueMember = "statusId"

        Dim attachTbl As New DataTable()
        attachTbl.Columns.Add("attachDesc")
        attachTbl.Columns.Add("attachId")
        attachTbl.Rows.Add("No", "N")
        attachTbl.Rows.Add("Yes", "Y")
        AttachComboBox.DataSource = attachTbl
        AttachComboBox.DisplayMember = "attachDesc"
        AttachComboBox.ValueMember = "attachId"

        Me.SectionTableAdapter.Fill(Me.HURMISDataSet.section)
        Me.OfficeTableAdapter.Fill(Me.HURMISDataSet.office)
        Me.EducationTableAdapter.Fill(Me.HURMISDataSet.education)
        'Me.PostingTableAdapter.Fill(Me.HURMISDataSet.posting)
        'Me.QualificationTableAdapter.Fill(Me.HURMISDataSet.qualification)
        'Me.EmployeeTableAdapter.FillByServing(Me.HURMISDataSet.employee)

    End Sub

    Private Sub ServingEmployeeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServingEmployeeBtn.Click
        Try
            Me.EmployeeTableAdapter.FillByServingEmployees(Me.HURMISDataSet.employee)
            Me.QualificationTableAdapter.Fill(Me.HURMISDataSet.qualification)
            Me.PostingTableAdapter.Fill(Me.HURMISDataSet.posting)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub REtiredEmployeeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REtiredEmployeeBtn.Click
        Try
            Me.EmployeeTableAdapter.FillByRetiredEmployees(Me.HURMISDataSet.employee)
            Me.QualificationTableAdapter.Fill(Me.HURMISDataSet.qualification)
            Me.PostingTableAdapter.Fill(Me.HURMISDataSet.posting)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EmployeeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeBtn.Click
        Try
            Me.EmployeeTableAdapter.FillByAllEmployees(Me.HURMISDataSet.employee)
            Me.QualificationTableAdapter.Fill(Me.HURMISDataSet.qualification)
            Me.PostingTableAdapter.Fill(Me.HURMISDataSet.posting)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = vbNullString
        TextBox1.Focus()
    End Sub

    Private Sub F1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
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
            EmployeeBindingSource.Filter = x & " LIKE '%" & TextBox1.Text & "%'"
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub qSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qSaveButton.Click
        Me.Validate()
        Me.QualificationBindingSource.EndEdit()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HURMISDataSet)
    End Sub

    Private Sub ssIpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ssIpButton.Click
        dCode = EmployeeDataGridView.CurrentRow.Cells("did").Value
        ssIPinOffices.Show()
    End Sub

    Private Sub EmployeeDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellEnter
        Try
            FotoPictureBox.ImageLocation = "\\10.10.4.6\foto\" + EmployeeBindingSource.Current("pno").ToString + ".jpg"
            'FotoPictureBox.ImageLocation = "D:\HURMIS\foto\" + EmployeeBindingSource.Current("pno").ToString + ".jpg"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub EmployeeDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
        Try
            If Me.EmployeeDataGridView.Columns(e.ColumnIndex).Name = "updateButton" Then
                postDescription = EmployeeDataGridView.CurrentRow.Cells("post").Value
                cnicNo = EmployeeDataGridView.CurrentRow.Cells("nic").Value
                fromWhere = "fromF1"
                F2.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSaveButton.Click
        Me.Validate()
        Me.PostingBindingSource.EndEdit()
        Me.EmployeeBindingSource.EndEdit()
        Me.EmployeeTableAdapter.Update(Me.HURMISDataSet)
        Me.TableAdapterManager.UpdateAll(Me.HURMISDataSet)
    End Sub

    Private Sub tAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tAddButton.Click
        Me.PostingBindingSource.AddNew()
        'Me.YrComboBox.Focus()
    End Sub

    Private Sub tDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDeleteButton.Click
        Me.PostingBindingSource.RemoveCurrent()
    End Sub

    Private Sub qAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qAddButton.Click
        Me.QualificationBindingSource.AddNew()
    End Sub

    Private Sub qDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qDeleteButton.Click
        Me.QualificationBindingSource.RemoveCurrent()
    End Sub

End Class

