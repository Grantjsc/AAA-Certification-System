Imports System.IO
Imports System.Threading
Public Class Exam_Form

    Public imageList As New List(Of String)()
    Public currentIndex As Integer = 0
    Private Sub Exam_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Get_ImagePath() ' get the folder path

        Dim folderPath As String = Path_TestImage

        ' Get all JPG files from 1.JPG to 50.JPG
        For i As Integer = 1 To 50
            Dim filePath As String = Path.Combine(folderPath, i & ".JPG")
            If File.Exists(filePath) Then
                imageList.Add(filePath)
            End If
        Next

        ' Shuffle the images randomly
        Dim rnd As New Random()
        imageList = imageList.OrderBy(Function(x) rnd.Next()).ToList()

        If imageList.Count = 0 Then
            MsgBox("No valid JPG files found!" & vbNewLine & "Kindly set up the folder path for test images", MsgBoxStyle.Critical)
            Me.Close()
            Exit Sub
        End If

        Get_Attempt_and_Trial()
        SelectRandom()

    End Sub

    Private Sub btnGood_DoubleClick(sender As Object, e As EventArgs) Handles btnGood.DoubleClick
        Dim currentImageIndex As Integer = currentIndex - 1
        If currentImageIndex < 0 Then currentImageIndex = 0 ' Prevent negative index

        GoodButton_Function_Exam(currentImageIndex)
        Thread.Sleep(500)
        SelectRandom()
    End Sub


    Private Sub btnNG_DoubleClick(sender As Object, e As EventArgs) Handles btnNG.DoubleClick
        Dim currentImageIndex As Integer = currentIndex - 1
        If currentImageIndex < 0 Then currentImageIndex = 0 ' Prevent negative index

        NGButton_Function_Exam(currentImageIndex)
        Thread.Sleep(500)
        SelectRandom()
    End Sub

    Private Sub SelectRandom()
        If imageList.Count = 0 Then
            MessageBox.Show("No images to display.")
            Return
        End If

        If currentIndex < imageList.Count Then
            ' Capture the current image index before incrementing
            Dim currentImageIndex As Integer = currentIndex
            PictureBox1.Image = Image.FromFile(imageList(currentImageIndex))
            currentIndex += 1
            GroupBox_TestNum.Text = "Item: " & currentIndex
        Else
            MessageBox.Show("Done!")
            currentIndex = 0

            ' Optional: Shuffle the images again if you want to restart
            Dim rnd As New Random()
            imageList = imageList.OrderBy(Function(x) rnd.Next()).ToList()

            Update_Attempt_and_Trial()

            If Exam_Trial = 3 Then
                UpdateResults(Exam_ID)

                Load_TrialResultForm() 'Show the Exam summary

                Extract_Result() 'Save the exam in excel

                Me.Close()
                Exit Sub
            End If

            Get_Attempt_and_Trial()
            MsgBox("This is Exam: " & Exam_Attempt & " Trial: " & Exam_Trial, MsgBoxStyle.Information)
            SelectRandom()
        End If
    End Sub
End Class