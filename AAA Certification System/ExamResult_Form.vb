Public Class ExamResult_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ExamResult_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_ExamResult(TrialResult_TrialNumber)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ExamRes_Prev()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ExamRes_Next()
    End Sub
End Class