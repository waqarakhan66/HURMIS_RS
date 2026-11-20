Public Class F0

    Private Sub ExtBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtBtn.Click
        LF.Close()
        Me.Close()
    End Sub

    Private Sub EmpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpBtn.Click
        F1.Show()
    End Sub

    Private Sub MedBillBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VacantPostsBtn.Click
        fromWhere = "VacantPostsBtn"
        F2.Show()
    End Sub

    Private Sub ServingBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServingBtn.Click
        fromWhere = "ServingBtn"
        F2.Show()
    End Sub

    Private Sub RetiredBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetiredBtn.Click
        fromWhere = "RetiredBtn"
        F2.Show()
    End Sub

    Private Sub YearWiseRetdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearWiseRetdButton.Click
        F3.Show()
    End Sub
End Class
