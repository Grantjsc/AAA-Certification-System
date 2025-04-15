Public Class View_Form
    Private Sub View_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnPassed.ForeColor = Color.Black
        btnPassed.FillColor = Color.Transparent

        btnFailed.ForeColor = Color.Black
        btnFailed.FillColor = Color.Transparent

        btnAll.ForeColor = Color.White
        btnAll.FillColor = SystemColors.ActiveCaption

        View_Passed = False
        View_Failed = False
        View_All = True

        Show_All_EmpData()
        Count_Employee()
    End Sub

    Private Sub cboVaLStream_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVaLStream.SelectedIndexChanged
        If cboVaLStream.Text = "ALL" Then
            If View_All = True Then
                Show_All_EmpData()
                Count_Employee()

            ElseIf View_Passed = True Then
                Show_All_EmpData_Passed()
                Count_Employee()
            ElseIf View_Failed = True Then
                Show_All_EmpData_Failed()
                Count_Employee()
            End If
        Else
            Show_EmpData_Via_ValueStream()
            Count_Employee_Dept()
        End If
    End Sub

    Private Sub btnPassed_Click(sender As Object, e As EventArgs) Handles btnPassed.Click
        btnPassed.ForeColor = Color.White
        btnPassed.FillColor = SystemColors.ActiveCaption

        btnFailed.ForeColor = Color.Black
        btnFailed.FillColor = Color.Transparent

        btnAll.ForeColor = Color.Black
        btnAll.FillColor = Color.Transparent

        cboVaLStream.Text = Nothing

        View_Passed = True
        View_Failed = False
        View_All = False

        Show_All_EmpData_Passed()
        Count_Employee()
    End Sub
    Private Sub btnFailed_Click(sender As Object, e As EventArgs) Handles btnFailed.Click
        btnPassed.ForeColor = Color.Black
        btnPassed.FillColor = Color.Transparent

        btnFailed.ForeColor = Color.White
        btnFailed.FillColor = SystemColors.ActiveCaption

        btnAll.ForeColor = Color.Black
        btnAll.FillColor = Color.Transparent

        cboVaLStream.Text = Nothing

        View_Passed = False
        View_Failed = True
        View_All = False

        Show_All_EmpData_Failed()
        Count_Employee()

        MsgBox("Please click on the employee name to enable it to retake the AAA examination.", MsgBoxStyle.Information)
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        btnPassed.ForeColor = Color.Black
        btnPassed.FillColor = Color.Transparent

        btnFailed.ForeColor = Color.Black
        btnFailed.FillColor = Color.Transparent

        btnAll.ForeColor = Color.White
        btnAll.FillColor = SystemColors.ActiveCaption

        cboVaLStream.Text = Nothing

        View_Passed = False
        View_Failed = False
        View_All = True

        Show_All_EmpData()
        Count_Employee()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'If View_Failed = True Then
        '    Get_Retakers_Data()
        '    RetakeQstn_Form.ShowDialog()
        'End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If View_Failed = True Then
            Get_Retakers_Data()
            'RetakeQstn_Form.ShowDialog()
        End If
    End Sub
End Class