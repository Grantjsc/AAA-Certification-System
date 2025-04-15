Public Class Create_Form
    Private Sub Create_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Bounds = Screen.PrimaryScreen.WorkingArea
        'WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtEmpNum_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmpNum.KeyUp
        If e.KeyCode = Keys.Enter Then
            Get_EmployeeData_Create()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmpNum.Clear()
        txtName.Clear()
        txtValueStream.Clear()
        cboLine.Items.Clear()

        txtEmpNum.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_ToMasterlist()
    End Sub
End Class