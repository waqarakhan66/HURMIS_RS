Public Class ssIPinOffices

    Private Sub ssIPinOffices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OfficeTableAdapter.FillBySSip(Me.HURMISDataSet.office, dCode)
        'MsgBox(dCode)
        'Me.EmployeeTableAdapter.FillByIPss(Me.HURMISDataSet.employee, dCode)
    End Sub

    Private Sub OfficeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OfficeDataGridView.CellContentClick

    End Sub
End Class