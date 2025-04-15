Public Class TrialResult_Form
    Private Sub TrialResult_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_TestTrial_Result(Exam_ID, Exam_Attempt)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        DeleteExamResult()
        Load_Home()
    End Sub

    Private Sub btnView1_Click(sender As Object, e As EventArgs) Handles btnView1.Click
        TrialResult_TrialNumber = 1
        Load_ExamResultForm()
    End Sub

    Private Sub btnView2_Click(sender As Object, e As EventArgs) Handles btnView2.Click
        TrialResult_TrialNumber = 2
        Load_ExamResultForm()
    End Sub

    Private Sub btnview3_Click(sender As Object, e As EventArgs) Handles btnview3.Click
        TrialResult_TrialNumber = 3
        Load_ExamResultForm()
    End Sub

    Private Sub btnKAPPA_Click(sender As Object, e As EventArgs) Handles btnKAPPA.Click
        MsgBox("KAPPA is currently unavailable.", MsgBoxStyle.Information)
    End Sub
End Class