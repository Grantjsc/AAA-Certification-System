Public Class Transfer_Form
    Private Sub Transfer_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Show_ReCertification()
        Count_Transfer_Employee()
        MsgBox("Please click on the employee name to enable it to take Re-Certification", MsgBoxStyle.Information)
    End Sub

    Private Sub cboValueStream_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboValueStream.SelectedIndexChanged
        If cboValueStream.Text = "ALL" Then
            Show_ReCertification()
            Count_Transfer_Employee()
        Else
            Show_ReCertification_ValueStream()
            Count_Transfer_Employee_Dept()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Get_ReCertification_Data()
    End Sub

End Class