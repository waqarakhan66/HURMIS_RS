Public Class F2

    Private Sub F2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DesignationTableAdapter.Fill(Me.HURMISDataSet.designation)
        Me.EducationTableAdapter.Fill(Me.HURMISDataSet.education)
        Me.QualificationTableAdapter.Fill(Me.HURMISDataSet.qualification)
        Me.SectionTableAdapter.Fill(Me.HURMISDataSet.section)
        Me.OfficeTableAdapter.Fill(Me.HURMISDataSet.office)
        Me.PvTableAdapter.Fill(Me.HURMISDataSet.pv)

        Dim genderTbl As New DataTable()
        genderTbl.Columns.Add("genderDesc")
        genderTbl.Columns.Add("genderId")
        genderTbl.Rows.Add("Male", "M")
        genderTbl.Rows.Add("Female", "F")
        GenderComboBox.DataSource = genderTbl
        GenderComboBox.DisplayMember = "genderDesc"
        GenderComboBox.ValueMember = "genderId"

        
        Dim srvTbl As New DataTable()
        srvTbl.Columns.Add("srvDesc")
        srvTbl.Columns.Add("srvId")
        srvTbl.Rows.Add("Serving", "S")
        srvTbl.Rows.Add("Retired", "R")
        srvTbl.Rows.Add("Vacant Post", "V")
        SrvComboBox.DataSource = srvTbl
        SrvComboBox.DisplayMember = "srvDesc"
        SrvComboBox.ValueMember = "srvId"


        Dim stTbl As New DataTable()
        stTbl.Columns.Add("stDesc")
        stTbl.Columns.Add("stId")
        stTbl.Rows.Add("Temporary", "T")
        stTbl.Rows.Add("Permanent", "P")
        StComboBox.DataSource = stTbl
        StComboBox.DisplayMember = "stDesc"
        StComboBox.ValueMember = "stId"


        Dim crTbl As New DataTable()
        crTbl.Columns.Add("crDesc")
        crTbl.Columns.Add("crId")
        crTbl.Rows.Add("Appointment", "A")
        crTbl.Rows.Add("Promotion", "P")
        crTbl.Rows.Add("Contract", "C")
        crTbl.Rows.Add("Deputation", "D")
        CrComboBox.DataSource = crTbl
        CrComboBox.DisplayMember = "crDesc"
        CrComboBox.ValueMember = "crId"


        Dim qtaTbl As New DataTable()
        qtaTbl.Columns.Add("qtaDesc")
        qtaTbl.Columns.Add("qtaId")
        qtaTbl.Rows.Add("Appointment", "AP")
        qtaTbl.Rows.Add("Promotion", "PR")
        qtaTbl.Rows.Add("P.M.Package", "PP")
        qtaTbl.Rows.Add("Absorbed", "AB")
        qtaTbl.Rows.Add("Disabled", "DI")
        qtaTbl.Rows.Add("Minority", "MI")
        qtaTbl.Rows.Add("Deputation", "DP")
        QtaComboBox.DataSource = qtaTbl
        QtaComboBox.DisplayMember = "qtaDesc"
        QtaComboBox.ValueMember = "qtaId"


        Dim hhTbl As New DataTable()
        hhTbl.Columns.Add("hhDesc")
        hhTbl.Columns.Add("hhId")
        hhTbl.Rows.Add("Yes", "Y")
        hhTbl.Rows.Add("No", "N")
        HhComboBox.DataSource = hhTbl
        HhComboBox.DisplayMember = "hhDesc"
        HhComboBox.ValueMember = "hhId"


        Dim DnTbl As New DataTable()
        DnTbl.Columns.Add("DnDesc")
        DnTbl.Columns.Add("DnId")
        DnTbl.Rows.Add("No", "N")
        DnTbl.Rows.Add("Yes", "Y")
        DnComboBox.DataSource = DnTbl
        DnComboBox.DisplayMember = "DnDesc"
        DnComboBox.ValueMember = "DnId"


        Dim NroTbl As New DataTable()
        NroTbl.Columns.Add("NroDesc")
        NroTbl.Columns.Add("NroId")
        NroTbl.Rows.Add("No", "N")
        NroTbl.Rows.Add("Yes", "Y")
        NroComboBox.DataSource = NroTbl
        NroComboBox.DisplayMember = "NroDesc"
        NroComboBox.ValueMember = "NroId"


        Dim AdTbl As New DataTable()
        AdTbl.Columns.Add("AdDesc")
        AdTbl.Columns.Add("AdId")
        AdTbl.Rows.Add("Alive", "A")
        AdTbl.Rows.Add("Deceased", "D")
        AdComboBox.DataSource = AdTbl
        AdComboBox.DisplayMember = "AdDesc"
        AdComboBox.ValueMember = "AdId"


        If fromWhere = "fromF1" Then
            Me.DesignationsTableAdapter.FillByServing(Me.HURMISDataSet.designations)
            Me.EmployeeTableAdapter.FillByCNICno(Me.HURMISDataSet.employee, cnicNo)
            Dim n As Integer
            DesignationsBindingSource.MoveFirst()
            For n = 0 To DesignationsDataGridView.RowCount - 1
                If DesignationsBindingSource.Current("post").ToString = postDescription Then
                    Exit For
                End If
                DesignationsBindingSource.MoveNext()
            Next
            DesignationsDataGridView.Enabled = False
            searchLabel.Visible = False
            ComboBox1.Visible = False
            qualificationButton.Visible = False
            SrvComboBox.Enabled = False
            AdComboBox.Enabled = False
        ElseIf fromWhere = "VacantPostsBtn" Then
            Me.DesignationsTableAdapter.FillByVacants(Me.HURMISDataSet.designations)
            Me.EmployeeTableAdapter.FillByVavants(Me.HURMISDataSet.employee)
        ElseIf fromWhere = "ServingBtn" Then
            Me.DesignationsTableAdapter.FillByServing(Me.HURMISDataSet.designations)
            Me.EmployeeTableAdapter.FillByServing(Me.HURMISDataSet.employee)
            SrvComboBox.Enabled = False
            AdComboBox.Enabled = False
        ElseIf fromWhere = "RetiredBtn" Then
            Me.DesignationsTableAdapter.FillByRetired(Me.HURMISDataSet.designations)
            Me.EmployeeTableAdapter.FillByRetired(Me.HURMISDataSet.employee)
            SrvComboBox.Enabled = False
            qualificationButton.Visible = False
        End If

        ComboBox1.SelectedIndex = -1


    End Sub

    Private Sub F2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.SelectedIndex > -1 Then

                DesignationsBindingSource.Filter = " post like '" & ComboBox1.SelectedValue & "%'"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PnoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PnoTextBox.TextChanged
        Try
            FotoPictureBox.ImageLocation = "\\10.10.4.6\foto\" + PnoTextBox.Text + ".jpg"
            'FotoPictureBox.ImageLocation = "D:\HURMIS\foto\" + PnoTextBox.Text + ".jpg"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            Me.Validate()
            Me.QualificationBindingSource.EndEdit()
            Me.EmployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HURMISDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub goBackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goBackButton.Click
        DesignationsDataGridView.Enabled = True
        Me.Close()
    End Sub

    'Private Sub NicTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles NicTextBox.Enter
    '    If NicTextBox.TextLength = 13 Then
    '        NicTextBox.Enabled = False
    '        NameTextBox.Focus()
    '    Else
    '        NicTextBox.Enabled = True
    '    End If
    'End Sub

    Private Sub DpComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DpComboBox.SelectedIndexChanged
        Me.DsTableAdapter.Fill(Me.HURMISDataSet.ds, DpComboBox.SelectedValue)
    End Sub

    Private Sub DesignationsDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DesignationsDataGridView.SelectionChanged
        Try
            dLabel.Text = DesignationsDataGridView.CurrentRow.Cells("post").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub BdTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BdTextBox.Enter
    '    If BdTextBox.Text = vbNullString Then
    '        BdTextBox.Enabled = True
    '    Else
    '        BdTextBox.Enabled = False
    '    End If
    'End Sub

    'Private Sub edTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles EdTextBox.Enter
    '    If EdTextBox.Text = vbNullString Then
    '        EdTextBox.Enabled = True
    '    Else
    '        EdTextBox.Enabled = False
    '    End If
    'End Sub

    'Private Sub ApdTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ApdTextBox.Enter
    '    If ApdTextBox.Text = vbNullString Then
    '        ApdTextBox.Enabled = True
    '    Else
    '        ApdTextBox.Enabled = False
    '    End If
    'End Sub

    Private Sub qualificationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qualificationButton.Click
        If qualificationButton.Text = "Show Qualification(s)" Then
            qualificationButton.Text = "Hide Qualification(s)"
            qualificationPanel.Show()
        ElseIf qualificationButton.Text = "Hide Qualification(s)" Then
            qualificationButton.Text = "Show Qualification(s)"
            qualificationPanel.Hide()
        End If

    End Sub

    Private Sub EidTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EidTextBox.Validating
        If EidTextBox.Text <> vbNullString Then
            EidTextBox.Text = Format(Val(EidTextBox.Text), "000")
        End If
    End Sub

    Private Sub qAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qAddButton.Click
        Me.QualificationBindingSource.AddNew()
    End Sub

    Private Sub qDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qDeleteButton.Click
        Me.QualificationBindingSource.RemoveCurrent()
    End Sub

    Private Sub FillByServingToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.DesignationTableAdapter.FillByServing(Me.HURMISDataSet.designation)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByServingToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.DesignationTableAdapter.FillByServing(Me.HURMISDataSet.designation)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class