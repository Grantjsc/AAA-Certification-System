Public Class ReCertifyQstn_Form
    Private Sub ReCertifyQstn_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        CopyData_to_Recertifytb(Recertify_ID)
        UpdateData_ofRecertify(Recertify_ID)

        'If Transfer_Form.cboValueStream.Text = "ALL" Then
        '    Show_ReCertification()
        '    Count_Transfer_Employee()
        'Else
        '    Show_ReCertification_ValueStream()
        '    Count_Transfer_Employee_Dept()
        'End If

        Load_Home()

        Me.Close()
    End Sub
End Class