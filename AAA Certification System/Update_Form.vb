Public Class Update_Form
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim filePath As String = OpenFileDialog1.FileName

            txtFolderPath.Text = filePath
            Updated_AlphaList = txtFolderPath.Text
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Result As DialogResult = MsgBox("The old data will be deleted after updating the Alphalist." & vbNewLine &
                                            "Do you want to continue?", MsgBoxStyle.OkCancel)
        If Result = DialogResult.OK Then
            If String.IsNullOrEmpty(txtFolderPath.Text) Then
                MsgBox("Please select the path of GB exam result!", MsgBoxStyle.Critical)
            Else
                Delete_AlpaList()
                ImportAlphaList()
                'ImportAlphaList(Updated_AlphaList)
            End If

        ElseIf Result = DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
End Class