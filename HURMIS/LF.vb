Imports System.Data
Imports System.Data.SqlClient

Public Class LF

    Dim StrError As String = Nothing
    Dim StrConn As String = My.Settings.HURMISConnectionString
    Dim COUNTER As Integer = 0

    Private Sub LF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub loginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginButton.Click
        If uNameTextBox.Text = "" Then
            MsgBox("PLEASE ENTER THE LOGIN NAME")
            uNameTextBox.Focus()
        Else
            Dim cnnSc As SqlConnection = New SqlConnection(StrConn)
            cnnSc.Open()
            Dim strSQL As String = "SELECT COUNT(*) FROM logins WHERE userName = '" + uNameTextBox.Text + "' AND userPassword = '" + uPasswordTextBox.Text + "'"
            Dim cmdScalar As SqlCommand = New SqlCommand(strSQL, cnnSc)
            cmdScalar.CommandType = CommandType.Text
            Dim intCount As Integer = CInt(cmdScalar.ExecuteScalar)
            cnnSc.Close()
            If intCount = 0 Then
                MsgBox("INVALID PASSWORD")
                uNameTextBox.Focus()
            Else
                If uNameTextBox.Text = "OPERATOR" Then
                    flg = "1"
                End If
                ' Me.Close()
                usr = uNameTextBox.Text
                F0.Show()
            End If
        End If

    End Sub


    Private Sub uNameTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles uNameTextBox.Validated
        Dim cnnSc As SqlConnection = New SqlConnection(StrConn)
        cnnSc.Open()
        If uNameTextBox.Text <> "" Then

            Dim strSQL As String = "SELECT COUNT(*) FROM logins WHERE userName = '" + uNameTextBox.Text + "'"
            Dim cmdScalar As SqlCommand = New SqlCommand(strSQL, cnnSc)
            cmdScalar.CommandType = CommandType.Text
            Dim intCount As Integer
            intCount = CInt(cmdScalar.ExecuteScalar)
            cnnSc.Close()
            If intCount = 0 Then
                MsgBox("INVALID USER NAME")
                uNameTextBox.Text = ""
                uNameTextBox.Focus()
            End If
        End If
        'If Val(ScTextBox.Text) <> intCount + 1 Then
        '    StrError = "Now fill the data for Sector No. 0" + (intCount + 1).ToString
        '    MsgBox(StrError, MsgBoxStyle.Information, "Sector Number")
        '    e.Cancel = True
        '    ScTextBox.Text = vbNullString
        'End If
    End Sub


    'Private Sub logoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    uNameTextBox.Text = ""
    '    uPasswordTextBox.Text = ""
    '    Me.Close()
    'End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class
