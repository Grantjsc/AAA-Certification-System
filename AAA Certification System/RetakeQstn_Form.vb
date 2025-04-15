Public Class RetakeQstn_Form
    Private Sub RetakeQstn_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get_Retakers_Data()'
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        CopyData_to_Retakertb(Retaker_ID)
        UpdateData_ofRetaker(Retaker_ID)

        Show_All_EmpData_Failed()
        Count_Employee()
        Me.Close()
    End Sub
End Class