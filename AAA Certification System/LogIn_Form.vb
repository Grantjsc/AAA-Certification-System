Public Class LogIn_Form
    Private Sub LogIn_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        'txtUserID.Focus()
    End Sub
    Private Sub txtUserID_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUserID.KeyUp
        If e.KeyCode = Keys.Enter Then
            Get_User()
        End If
    End Sub

    Private Sub txtUserID_Enter(sender As Object, e As EventArgs) Handles txtUserID.Enter
        If txtUserID.Text = "Employee number" Then

            txtUserID.Text = ""
            txtUserID.ForeColor = Color.DimGray
            txtUserID.Font = New Font("Segoe UI Semibold", 24, FontStyle.Regular)
        End If
    End Sub

    Private Sub txtUserID_Leave(sender As Object, e As EventArgs) Handles txtUserID.Leave
        If txtUserID.Text = "" Then

            txtUserID.Text = "Employee number"
            txtUserID.ForeColor = Color.Silver
            txtUserID.Font = New Font("Segoe UI light", 24, FontStyle.Regular)
        End If
    End Sub
End Class