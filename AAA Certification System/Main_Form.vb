Public Class Main_Form
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Load_Home()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Load_Create()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Load_Edit()
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Load_Transfer()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Load_Update()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Load_View()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Load_Login()
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Access_Level = "Admin" Or Access_Level = "LT" Then
            Count_ReCertification()
        End If
    End Sub
End Class