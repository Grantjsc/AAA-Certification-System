Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bounds = Screen.PrimaryScreen.WorkingArea
        'WindowState = FormWindowState.Maximized
        Load_Login()
        'Load_MainForm()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        PassEditPath_Form.ShowDialog()
    End Sub
End Class
