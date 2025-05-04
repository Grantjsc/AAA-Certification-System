Imports OfficeOpenXml.FormulaParsing.Excel.Functions
Imports System.IO

Public Class Home_Form
    Private Sub txtEmpNum_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmpNum.KeyUp
        If e.KeyCode = Keys.Enter Then
            Get_EmployeeData_Home()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        EmployeeData_Populate_Home()
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        EmployeeData_Populate_Home()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Please enter the employee number!", MsgBoxStyle.Critical)
            txtEmpNum.Focus()
        Else

            Exam_Form.lblName.Text = txtName.Text
            Exam_Form.lblStation.Text = txtStation.Text
            Exam_Form.lblLine.Text = txtLine.Text

            Get_CheckEmployeeData_Home()

            'NonDisclosure_Form.ShowDialog()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'UpdateResults(Exam_ID)
        'Load_ExamResultForm()
        'Load_TrialResultForm()
        'Extract_Result()
        'DeleteExamResult()

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub txtEmpNum_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNum.TextChanged
        If String.IsNullOrEmpty(txtEmpNum.Text) Then
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()

            txtName.Clear()
            txtValueStream.Clear()
            txtLine.Clear()
            txtStation.Clear()
        End If
    End Sub
End Class