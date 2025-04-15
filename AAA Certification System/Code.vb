Imports System.Configuration

Module Funtion_Module
    Sub Load_Login()
        Home_Form.Close()
        Create_Form.Close()
        Edit_Form.Close()
        Transfer_Form.Close()
        Update_Form.Close()
        View_Form.Close()

        With LogIn_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(LogIn_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_MainForm()
        LogIn_Form.Close()

        Select Case Access_Level
            Case "Admin"
                Main_Form.btnUpdate.Visible = True
            Case "LT"
                Main_Form.btnUpdate.Visible = False

            Case Else
                Main_Form.btnUpdate.Visible = False
                Main_Form.btnView.Visible = False
        End Select

        With Main_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(Main_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_ExamForm()

        With Exam_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(Exam_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        NonDisclosure_Form.Close()

    End Sub

    Sub Load_TrialResultForm()

        With TrialResult_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(TrialResult_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub
    Sub Load_ExamResultForm()

        With ExamResult_Form
            .TopLevel = False
            Form1.MasterPanel.Controls.Add(ExamResult_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

    End Sub


    '=====================< CODE For Main Form >========================

    Sub Load_Home()

        Main_Form.btnHome.FillColor = Color.Orange
        Main_Form.btnHome.Image = My.Resources.home_colored_

        Main_Form.btnCreate.FillColor = Color.Transparent
        Main_Form.btnCreate.Image = My.Resources.add_group

        Main_Form.btnEdit.FillColor = Color.Transparent
        Main_Form.btnEdit.Image = My.Resources.note

        Main_Form.btnTransfer.FillColor = Color.Transparent
        Main_Form.btnTransfer.Image = My.Resources.transfer

        Main_Form.btnUpdate.FillColor = Color.Transparent
        Main_Form.btnUpdate.Image = My.Resources.export

        Main_Form.btnView.FillColor = Color.Transparent
        Main_Form.btnView.Image = My.Resources.search

        Create_Form.Close()
        Edit_Form.Close()
        Transfer_Form.Close()
        Update_Form.Close()
        View_Form.Close()

        With Home_Form
            .TopLevel = False
            Main_Form.MainPanel.Controls.Add(Home_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_Create()

        Main_Form.btnHome.FillColor = Color.Transparent
        Main_Form.btnHome.Image = My.Resources.home

        Main_Form.btnCreate.FillColor = Color.Orange
        Main_Form.btnCreate.Image = My.Resources.add_group__colored_

        Main_Form.btnEdit.FillColor = Color.Transparent
        Main_Form.btnEdit.Image = My.Resources.note

        Main_Form.btnTransfer.FillColor = Color.Transparent
        Main_Form.btnTransfer.Image = My.Resources.transfer

        Main_Form.btnUpdate.FillColor = Color.Transparent
        Main_Form.btnUpdate.Image = My.Resources.export

        Main_Form.btnView.FillColor = Color.Transparent
        Main_Form.btnView.Image = My.Resources.search

        Home_Form.Close()
        Edit_Form.Close()
        Transfer_Form.Close()
        Update_Form.Close()
        View_Form.Close()

        With Create_Form
            .TopLevel = False
            Main_Form.MainPanel.Controls.Add(Create_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_Edit()

        Main_Form.btnHome.FillColor = Color.Transparent
        Main_Form.btnHome.Image = My.Resources.home

        Main_Form.btnCreate.FillColor = Color.Transparent
        Main_Form.btnCreate.Image = My.Resources.add_group

        Main_Form.btnEdit.FillColor = Color.Orange
        Main_Form.btnEdit.Image = My.Resources.note__colored_

        Main_Form.btnTransfer.FillColor = Color.Transparent
        Main_Form.btnTransfer.Image = My.Resources.transfer

        Main_Form.btnUpdate.FillColor = Color.Transparent
        Main_Form.btnUpdate.Image = My.Resources.export

        Main_Form.btnView.FillColor = Color.Transparent
        Main_Form.btnView.Image = My.Resources.search

        Home_Form.Close()
        Create_Form.Close()
        Transfer_Form.Close()
        Update_Form.Close()
        View_Form.Close()

        With Edit_Form
            .TopLevel = False
            Main_Form.MainPanel.Controls.Add(Edit_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_Transfer()

        Main_Form.btnHome.FillColor = Color.Transparent
        Main_Form.btnHome.Image = My.Resources.home

        Main_Form.btnCreate.FillColor = Color.Transparent
        Main_Form.btnCreate.Image = My.Resources.add_group

        Main_Form.btnEdit.FillColor = Color.Transparent
        Main_Form.btnEdit.Image = My.Resources.note

        Main_Form.btnTransfer.FillColor = Color.Orange
        Main_Form.btnTransfer.Image = My.Resources.transfer__colored_

        Main_Form.btnUpdate.FillColor = Color.Transparent
        Main_Form.btnUpdate.Image = My.Resources.export

        Main_Form.btnView.FillColor = Color.Transparent
        Main_Form.btnView.Image = My.Resources.search

        Home_Form.Close()
        Create_Form.Close()
        Edit_Form.Close()
        Update_Form.Close()
        View_Form.Close()

        With Transfer_Form
            .TopLevel = False
            Main_Form.MainPanel.Controls.Add(Transfer_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_Update()

        Main_Form.btnHome.FillColor = Color.Transparent
        Main_Form.btnHome.Image = My.Resources.home

        Main_Form.btnCreate.FillColor = Color.Transparent
        Main_Form.btnCreate.Image = My.Resources.add_group

        Main_Form.btnEdit.FillColor = Color.Transparent
        Main_Form.btnEdit.Image = My.Resources.note

        Main_Form.btnTransfer.FillColor = Color.Transparent
        Main_Form.btnTransfer.Image = My.Resources.transfer

        Main_Form.btnUpdate.FillColor = Color.Orange
        Main_Form.btnUpdate.Image = My.Resources.export__colored_

        Main_Form.btnView.FillColor = Color.Transparent
        Main_Form.btnView.Image = My.Resources.search

        Home_Form.Close()
        Create_Form.Close()
        Edit_Form.Close()
        Transfer_Form.Close()
        View_Form.Close()

        With Update_Form
            .TopLevel = False
            Main_Form.MainPanel.Controls.Add(Update_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub Load_View()

        Main_Form.btnHome.FillColor = Color.Transparent
        Main_Form.btnHome.Image = My.Resources.home

        Main_Form.btnCreate.FillColor = Color.Transparent
        Main_Form.btnCreate.Image = My.Resources.add_group

        Main_Form.btnEdit.FillColor = Color.Transparent
        Main_Form.btnEdit.Image = My.Resources.note

        Main_Form.btnTransfer.FillColor = Color.Transparent
        Main_Form.btnTransfer.Image = My.Resources.transfer

        Main_Form.btnUpdate.FillColor = Color.Transparent
        Main_Form.btnUpdate.Image = My.Resources.export

        Main_Form.btnView.FillColor = Color.Orange
        Main_Form.btnView.Image = My.Resources.search__colored_

        Home_Form.Close()
        Create_Form.Close()
        Edit_Form.Close()
        Transfer_Form.Close()
        Update_Form.Close()

        With View_Form
            .TopLevel = False
            Main_Form.MainPanel.Controls.Add(View_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub
End Module

Module AppConfig_Module

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    '=================< Get Paths >===================
    Sub Get_ImagePath()
        Dim value As String = System.Configuration.ConfigurationManager.AppSettings("ImagePath")
        Console.WriteLine(value)

        Path_TestImage = value
    End Sub

    Sub Get_SavingPath()
        Dim value As String = System.Configuration.ConfigurationManager.AppSettings("SavingPath")
        Console.WriteLine(value)

        Path_Saving = value
    End Sub

    '=================< Update Paths >=================

    Public New_Path_TestImage As String
    Public New_Path_Saving As String

    Sub Update_ImagePath()
        config.AppSettings.Settings("ImagePath").Value = New_Path_TestImage ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_SavingPath()
        config.AppSettings.Settings("SavingPath").Value = New_Path_Saving ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub
End Module