Public Class EditPath_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub EditPath_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_ImagePath() ' get the folder path
        Get_SavingPath() 'get the folder path

        txtImagePath.Text = Path_TestImage
        txtSavePath.Text = Path_Saving
    End Sub

    Private Sub btnImage_Change_Click(sender As Object, e As EventArgs) Handles btnImage_Change.Click
        If String.IsNullOrEmpty(txtImagePath.Text) Then
            MsgBox("Please enter the folder path of images", MsgBoxStyle.Critical)
        Else
            New_Path_TestImage = txtImagePath.Text
            Update_ImagePath()
            MsgBox("Path is now up to date!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnSaving_Change_Click(sender As Object, e As EventArgs) Handles btnSaving_Change.Click
        If String.IsNullOrEmpty(txtSavePath.Text) Then
            MsgBox("Please enter the saving folder path for AAA exam result", MsgBoxStyle.Critical)
        Else
            New_Path_Saving = txtSavePath.Text
            Update_SavingPath()
            MsgBox("Path is now up to date!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnImage_NewPath_Click(sender As Object, e As EventArgs) Handles btnImage_NewPath.Click
        FolderBrowserDialog1.Description = "Select New Path for Test Images"
        FolderBrowserDialog1.ShowDialog()
        txtImagePath.Text = FolderBrowserDialog1.SelectedPath.ToString
    End Sub

    Private Sub btnSaving_NewPath_Click(sender As Object, e As EventArgs) Handles btnSaving_NewPath.Click
        FolderBrowserDialog2.Description = "Select New Path for ARR"
        FolderBrowserDialog2.ShowDialog()
        txtSavePath.Text = FolderBrowserDialog2.SelectedPath.ToString
    End Sub
End Class