'Imports System.Data.Common
'Imports System.Data.OleDb
'Imports System.Data.SqlClient
'Imports System.IO
'Imports Excel = Microsoft.Office.Interop.Excel
'Imports OfficeOpenXml
'Imports OfficeOpenXml.Style
'Imports System.Drawing
'Imports Microsoft.VisualBasic.Logging

'Module Query_Module

'    '========================< FOR GENERAL USE >==========================
'    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\LEAN\AAA Certification System.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfaaacert"
'    Public Dbconnection As New OleDbConnection(connString)

'    Sub ConOpen()
'        If Dbconnection.State = ConnectionState.Closed Then
'            Dbconnection.Open()
'        End If
'    End Sub
'    Sub ConClose()
'        If Dbconnection.State = ConnectionState.Open Then
'            Dbconnection.Close()
'        End If
'    End Sub

'    '=======================< FOR LogIn_Form >=====================

'    Public Access_Level As String
'    Sub Get_User()

'        Try
'            Dim MyData As String
'            Dim cmd As New OleDbCommand
'            Dim Data As New DataTable
'            Dim adap As New OleDbDataAdapter
'            ConOpen()

'            MyData = "SELECT * From AAA_Cert_Userlist_tb WHERE Employee_Number = '" & LogIn_Form.txtUserID.Text & "'"
'            cmd.Connection = Dbconnection
'            cmd.CommandText = MyData
'            adap.SelectCommand = cmd
'            adap.Fill(Data)

'            If Data.Rows.Count > 0 Then

'                'UserN = Data.Rows(0).Item("Username").ToString
'                Access_Level = Data.Rows(0).Item("AccessLevel").ToString
'                Load_MainForm()
'            Else
'                MsgBox("Employee ID doesn't exist in the database", MsgBoxStyle.Critical)
'                LogIn_Form.txtUserID.Clear()

'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            'Dbconnection.Close()
'            ConClose()
'        End Try
'    End Sub

'    '=======================< FOR Main_Form >=====================

'    Sub Count_ReCertification()
'        Dim recertificationCount As Integer = 0

'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            ' SQL query to count employees needing re-certification
'            Dim query As String = "SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb 
'                               WHERE AAA_Exp_Date IS NOT NULL 
'                               AND AAA_Exp_Date BETWEEN Date() AND DateAdd('m', 2, Date())"

'            ' Using block ensures proper disposal of resources
'            Using command As New OleDbCommand(query, Dbconnection)
'                recertificationCount = Convert.ToInt32(command.ExecuteScalar())  ' Get the count
'            End Using

'            ' Display count in message box
'            MsgBox("Employees Needing Re-Certification: " & recertificationCount, MsgBoxStyle.Information, "Certification Due")

'            If recertificationCount = 0 Then
'                Exit Sub
'            Else
'                Load_Transfer()
'            End If
'        End If

'        ConClose()
'    End Sub

'    '=======================< FOR Home_Form >=====================

'    Public Home_EmpName As String
'    Sub Get_EmployeeData_Home()

'        Try
'            Dim MyData As String
'            Dim cmd As New OleDbCommand
'            Dim Data As New DataTable
'            Dim adap As New OleDbDataAdapter
'            ConOpen()

'            MyData = "SELECT * From AAA_Cert_Masterlist_tb WHERE Employee_Number = '" & Home_Form.txtEmpNum.Text & "'"
'            cmd.Connection = Dbconnection
'            cmd.CommandText = MyData
'            adap.SelectCommand = cmd
'            adap.Fill(Data)

'            If Data.Rows.Count > 0 Then

'                Home_EmpName = Data.Rows(0).Item("EmployeeName").ToString
'                Show_EmployeeData_Home()

'            Else
'                MsgBox("Employee number doesn't exist in the Masterlist database", MsgBoxStyle.Critical)
'                Home_Form.txtEmpNum.Clear()
'                Home_Form.txtEmpNum.Focus()

'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            'Dbconnection.Close()
'            ConClose()
'        End Try
'    End Sub

'    Sub Show_EmployeeData_Home()
'        Dim command As New OleDbCommand("", Dbconnection)
'        Dim table As New DataTable

'        'Dbconnection.Open()
'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            command.Connection = Dbconnection
'            command.CommandText = "Select EmployeeName, Department, Line, Station
'                                        From AAA_Cert_Masterlist_tb WHERE EmployeeName = '" & Home_EmpName & "'"


'            Dim rdr As OleDbDataReader = command.ExecuteReader

'            table.Load(rdr)

'            Home_Form.DataGridView1.DataSource = table

'            ' Bold the header cells
'            For Each column As DataGridViewColumn In Home_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
'                column.HeaderCell.Style.SelectionForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
'            Next

'            Home_Form.DataGridView1.Columns("EmployeeName").HeaderText = "Employee Name"
'            Home_Form.DataGridView1.Columns("Department").HeaderText = "Department"
'            Home_Form.DataGridView1.Columns("Line").HeaderText = "Line"
'            Home_Form.DataGridView1.Columns("Station").HeaderText = "Station"

'            Home_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'            Home_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'            Home_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

'            Home_Form.DataGridView1.EnableHeadersVisualStyles = False
'            Home_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

'        End If
'        'Dbconnection.Close()
'        ConClose()
'    End Sub

'    Public Exam_ID As Integer

'    Sub EmployeeData_Populate_Home()
'        Try
'            ' Ensure at least one cell is selected
'            If Home_Form.DataGridView1.SelectedCells.Count > 0 Then
'                Dim selectedRowIndex As Integer = Home_Form.DataGridView1.SelectedCells(0).RowIndex

'                ' Ensure row index is valid
'                If selectedRowIndex >= 0 Then
'                    ' Assuming "Title" is in column index 1 (adjust if needed)
'                    Dim titleColumnIndex As Integer = 2
'                    Dim selectedRow As DataGridViewRow = Home_Form.DataGridView1.Rows(selectedRowIndex)

'                    ' Retrieve the project title from the specified column
'                    Dim User_Val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

'                    ' Ensure value is not empty
'                    If Not String.IsNullOrEmpty(User_Val) Then
'                        Dim query As String = "SELECT * FROM AAA_Cert_Masterlist_tb WHERE Line = @line"

'                        ' Open database connection
'                        ConOpen()

'                        ' Use "Using" to properly dispose of objects
'                        Using command As New OleDbCommand(query, Dbconnection)
'                            command.Parameters.AddWithValue("@line", User_Val)

'                            Using adapter As New OleDbDataAdapter(command)
'                                Using data As New DataTable()
'                                    adapter.Fill(data)

'                                    ' If data is found, populate the filename text field
'                                    If data.Rows.Count > 0 Then
'                                        Exam_ID = data.Rows(0).Item("ID")
'                                        Console.WriteLine(Exam_ID)

'                                        Home_Form.txtName.Text = data.Rows(0).Item("EmployeeName").ToString()
'                                        Home_Form.txtValueStream.Text = data.Rows(0).Item("Department").ToString()
'                                        Home_Form.txtLine.Text = data.Rows(0).Item("Line").ToString()
'                                        Home_Form.txtStation.Text = data.Rows(0).Item("Station").ToString()
'                                    End If
'                                End Using
'                            End Using
'                        End Using
'                    End If
'                End If
'            End If

'        Catch ex As Exception
'            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            ' Close the database connection
'            ConClose()
'        End Try

'    End Sub


'    Sub Get_CheckEmployeeData_Home()

'        Try
'            Dim MyData As String
'            Dim cmd As New OleDbCommand
'            Dim Data As New DataTable
'            Dim adap As New OleDbDataAdapter
'            ConOpen()

'            MyData = "SELECT * From AAA_Cert_Masterlist_tb WHERE ID = " & Exam_ID & ""
'            cmd.Connection = Dbconnection
'            cmd.CommandText = MyData
'            adap.SelectCommand = cmd
'            adap.Fill(Data)

'            If Data.Rows.Count > 0 Then

'                Dim Stat As String = Data.Rows(0).Item("Test_Status").ToString
'                Dim att As Integer = Data.Rows(0).Item("Test_Attempt")
'                Dim dt As Object = Data.Rows(0).Item("AAA_Exp_Date")


'                ' Check if AAA Exp Date is NULL and Test_Status is FAILED
'                If IsDBNull(dt) AndAlso Stat = "" Then
'                    Select Case att
'                        Case 0
'                            MsgBox("This will be your 1st take of AAA exam. Good luck!", MsgBoxStyle.Information)
'                            NonDisclosure_Form.ShowDialog()

'                            'Case 1
'                            '    MsgBox("This will be your 2nd take of AAA exam. Good luck!", MsgBoxStyle.Information)
'                            '    NonDisclosure_Form.ShowDialog()
'                            'Case 2
'                            '    MsgBox("This will be your last take of AAA exam. Good luck!", MsgBoxStyle.Information)
'                            '    NonDisclosure_Form.ShowDialog()
'                    End Select

'                ElseIf IsDBNull(dt) AndAlso Stat = "FAILED" Then

'                    Select Case att

'                        Case 1
'                            MsgBox("This will be your 2nd take of AAA exam. Good luck!", MsgBoxStyle.Information)
'                            NonDisclosure_Form.ShowDialog()
'                        Case 2
'                            MsgBox("This will be your last take of AAA exam. Good luck!", MsgBoxStyle.Information)
'                            NonDisclosure_Form.ShowDialog()

'                        Case 3
'                            MsgBox("You failed the AAA exam 3 times." & vbNewLine & "Please contact AAA coordinator for re-evaluation!", MsgBoxStyle.Critical)
'                            Exit Sub
'                    End Select

'                ElseIf Stat = "PASSED" AndAlso Not IsDBNull(dt) AndAlso CDate(dt) >= Date.Today Then
'                    MsgBox("Your re-evaluation date for this line station is " & CDate(dt))
'                End If

'            Else
'                MsgBox("Employee number doesn't exist in the Masterlist database", MsgBoxStyle.Critical)
'                Home_Form.txtEmpNum.Clear()
'                Home_Form.txtEmpNum.Focus()
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            ConClose()
'        End Try

'    End Sub


'    '=======================< FOR Create_Form >=====================
'    Sub Get_EmployeeData_Create()

'        Try
'            Dim MyData As String
'            Dim cmd As New OleDbCommand
'            Dim Data As New DataTable
'            Dim adap As New OleDbDataAdapter
'            ConOpen()

'            MyData = "SELECT * From AAA_Cert_Alphalist_tb WHERE Employee_Number = '" & Create_Form.txtEmpNum.Text & "'"
'            cmd.Connection = Dbconnection
'            cmd.CommandText = MyData
'            adap.SelectCommand = cmd
'            adap.Fill(Data)

'            If Data.Rows.Count > 0 Then

'                Dim FN As String
'                Dim LN As String

'                'UserN = Data.Rows(0).Item("Username").ToString
'                FN = Data.Rows(0).Item("First_Name").ToString
'                LN = Data.Rows(0).Item("Last_Name").ToString

'                Create_Form.txtName.Text = LN & ", " & FN
'                Create_Form.txtValueStream.Text = Data.Rows(0).Item("Department").ToString

'                Create_Form.cboLine.Items.Clear()

'                Select Case Create_Form.txtValueStream.Text
'                    Case "TR/TE"
'                        Create_Form.cboLine.Items.AddRange(New String() {"Standard Fuse", "Fuse Holder", "Assembly", "807/804", "808", "303",
'                                                                          "Molding", "QA"})

'                    Case "SQUARE NANO"
'                        Create_Form.cboLine.Items.AddRange(New String() {"1206 Fuse", "Standard Nano", "Telecom Fuse", "40 Amps",
'                                                                          "250V", "OMNI", "885 Fuse", "Tin Dip Fuse", "462", "415", "QA"})

'                    Case "PICO/SMF/BARRIER"
'                        Create_Form.cboLine.Items.AddRange(New String() {"Pico Coated and Uncoated", "242-UR/UAT1,4450/259", "459/460, 308/304", "QA"})

'                    Case "CERAMIC FUSE"
'                        Create_Form.cboLine.Items.AddRange(New String() {"Greentape Frontline", "Standard Frontline", "Backend", "QA"})

'                    Case "THIN FILM"
'                        Create_Form.cboLine.Items.AddRange(New String() {"Backend", "WIA FR4", "PMC", "QA"})

'                    Case "REED SWITCH"
'                        Create_Form.cboLine.Items.AddRange(New String() {"Frontline", "Back End", "QA"})

'                    Case "PLANT QUALITY"
'                        Create_Form.cboLine.Items.AddRange(New String() {"QA"})

'                    Case Else
'                        ' Optionally, you can handle other cases or leave the ComboBox empty
'                End Select

'            Else
'                MsgBox("Employee number doesn't exist in the database", MsgBoxStyle.Critical)
'                Create_Form.txtEmpNum.Clear()
'                Create_Form.txtEmpNum.Focus()

'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            'Dbconnection.Close()
'            ConClose()
'        End Try
'    End Sub

'    Sub Add_ToMasterlist()

'        If String.IsNullOrEmpty(Create_Form.txtEmpNum.Text) Then
'            MsgBox("Please enter employee number!", MsgBoxStyle.Critical)
'            Create_Form.txtEmpNum.Focus()

'        ElseIf String.IsNullOrEmpty(Create_Form.cboLine.Text) Then
'            MsgBox("Please select line!", MsgBoxStyle.Critical)
'            Create_Form.cboLine.Focus()

'        ElseIf String.IsNullOrEmpty(Create_Form.cboStation.Text) Then
'            MsgBox("Please select station!", MsgBoxStyle.Critical)
'            Create_Form.cboStation.Focus()

'        Else
'            Dim mycommand As String

'            Dim ID As String = Create_Form.txtEmpNum.Text
'            Dim Name As String = Create_Form.txtName.Text
'            Dim Dept As String = Create_Form.txtValueStream.Text
'            Dim Line As String = Create_Form.cboLine.Text
'            Dim Station As String = Create_Form.cboStation.Text

'            Try
'                ConOpen()
'                mycommand = "INSERT INTO [AAA_Cert_Masterlist_tb] ([Employee_Number],[EmployeeName], [Department], [Line], [Station]) 
'                                    VALUES (@id, @name, @department, @line, @station)"
'                Using command As New OleDbCommand(mycommand, Dbconnection)
'                    command.Parameters.AddWithValue("@id", ID)
'                    command.Parameters.AddWithValue("@name", Name)
'                    command.Parameters.AddWithValue("@department", Dept)
'                    command.Parameters.AddWithValue("@line", Line)
'                    command.Parameters.AddWithValue("@station", Station)
'                    command.ExecuteNonQuery()
'                End Using
'                ConClose()

'                MsgBox("Employee successfully added.", MessageBoxIcon.Information)

'                Create_Form.txtEmpNum.Clear()
'                Create_Form.txtName.Clear()
'                Create_Form.txtValueStream.Clear()
'                Create_Form.cboLine.Items.Clear()
'                Create_Form.cboStation.Items.Clear()

'                Create_Form.txtEmpNum.Focus()
'            Catch ex As Exception
'                MsgBox(ex.Message, vbCritical)
'            End Try

'        End If


'    End Sub


'    '=======================< FOR Edit_Form >=====================
'    Public Edit_EmpName As String
'    Sub Get_EmployeeData_Edit()

'        Try
'            Dim MyData As String
'            Dim cmd As New OleDbCommand
'            Dim Data As New DataTable
'            Dim adap As New OleDbDataAdapter
'            ConOpen()

'            MyData = "SELECT * From AAA_Cert_Masterlist_tb WHERE Employee_Number = '" & Edit_Form.txtEmpNum.Text & "'"
'            cmd.Connection = Dbconnection
'            cmd.CommandText = MyData
'            adap.SelectCommand = cmd
'            adap.Fill(Data)

'            If Data.Rows.Count > 0 Then

'                Edit_EmpName = Data.Rows(0).Item("EmployeeName").ToString
'                Edit_Form.txtValueStream.Text = Data.Rows(0).Item("Department").ToString

'                Edit_Form.cboLine.Items.Clear()

'                Select Case Edit_Form.txtValueStream.Text
'                    Case "TR/TE"
'                        Edit_Form.cboLine.Items.AddRange(New String() {"Standard Fuse", "Fuse Holder", "Assembly", "807/804", "808", "303",
'                                                                          "Molding", "QA"})

'                    Case "SQUARE NANO"
'                        Edit_Form.cboLine.Items.AddRange(New String() {"1206 Fuse", "Standard Nano", "Telecom Fuse", "40 Amps",
'                                                                          "250V", "OMNI", "885 Fuse", "Tin Dip Fuse", "462", "415", "QA"})

'                    Case "PICO/SMF/BARRIER"
'                        Edit_Form.cboLine.Items.AddRange(New String() {"Pico Coated and Uncoated", "242-UR/UAT1,4450/259", "459/460, 308/304", "QA"})

'                    Case "CERAMIC FUSE"
'                        Edit_Form.cboLine.Items.AddRange(New String() {"Greentape Frontline", "Standard Frontline", "Backend", "QA"})

'                    Case "THIN FILM"
'                        Edit_Form.cboLine.Items.AddRange(New String() {"Backend", "WIA FR4", "PMC", "QA"})

'                    Case "REED SWITCH"
'                        Edit_Form.cboLine.Items.AddRange(New String() {"Frontline", "Back End", "QA"})

'                    Case "PLANT QUALITY"
'                        Edit_Form.cboLine.Items.AddRange(New String() {"QA"})

'                    Case Else
'                        ' Optionally, you can handle other cases or leave the ComboBox empty
'                End Select

'                Show_EmployeeData_Edit()
'            Else
'                MsgBox("Employee number doesn't exist in the Masterlist database", MsgBoxStyle.Critical)
'                Edit_Form.txtEmpNum.Clear()
'                Edit_Form.txtEmpNum.Focus()

'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            'Dbconnection.Close()
'            ConClose()
'        End Try
'    End Sub

'    Sub Show_EmployeeData_Edit()
'        Dim command As New OleDbCommand("", Dbconnection)
'        Dim table As New DataTable

'        'Dbconnection.Open()
'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            command.Connection = Dbconnection
'            command.CommandText = "Select ID, EmployeeName, Department, Line, Station
'                                        From AAA_Cert_Masterlist_tb WHERE EmployeeName = '" & Edit_EmpName & "'"


'            Dim rdr As OleDbDataReader = command.ExecuteReader

'            table.Load(rdr)

'            Edit_Form.DataGridView1.DataSource = table

'            ' Bold the header cells
'            For Each column As DataGridViewColumn In Edit_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 11, FontStyle.Bold)
'                column.HeaderCell.Style.SelectionForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 9)
'            Next


'            Edit_Form.DataGridView1.Columns("ID").Width = 50
'            Edit_Form.DataGridView1.Columns("EmployeeName").HeaderText = "Employee Name"
'            Edit_Form.DataGridView1.Columns("Department").HeaderText = "Department"
'            Edit_Form.DataGridView1.Columns("Line").HeaderText = "Line"
'            Edit_Form.DataGridView1.Columns("Station").HeaderText = "Station"

'            Edit_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'            Edit_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'            Edit_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

'            Edit_Form.DataGridView1.EnableHeadersVisualStyles = False
'            Edit_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

'        End If
'        'Dbconnection.Close()
'        ConClose()
'    End Sub


'    Public Edit_ID As Integer
'    Sub EmployeeData_Populate_Edit()
'        Try
'            ' Ensure at least one cell is selected
'            If Edit_Form.DataGridView1.SelectedCells.Count > 0 Then
'                Dim selectedRowIndex As Integer = Edit_Form.DataGridView1.SelectedCells(0).RowIndex

'                ' Ensure row index is valid
'                If selectedRowIndex >= 0 Then
'                    ' Assuming "Title" is in column index 1 (adjust if needed)
'                    Dim titleColumnIndex As Integer = 0
'                    Dim selectedRow As DataGridViewRow = Edit_Form.DataGridView1.Rows(selectedRowIndex)

'                    ' Retrieve the project title from the specified column
'                    Dim User_Val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

'                    ' Ensure value is not empty
'                    If Not String.IsNullOrEmpty(User_Val) Then
'                        Dim query As String = "SELECT * FROM AAA_Cert_Masterlist_tb WHERE ID = @ID"

'                        ' Open database connection
'                        ConOpen()

'                        ' Use "Using" to properly dispose of objects
'                        Using command As New OleDbCommand(query, Dbconnection)
'                            command.Parameters.AddWithValue("@ID", User_Val)

'                            Using adapter As New OleDbDataAdapter(command)
'                                Using data As New DataTable()
'                                    adapter.Fill(data)

'                                    ' If data is found, populate the filename text field
'                                    If data.Rows.Count > 0 Then
'                                        Edit_ID = data.Rows(0).Item("ID")
'                                        Console.WriteLine(Edit_ID)

'                                        Edit_Form.txtName.Text = data.Rows(0).Item("EmployeeName").ToString()
'                                        Edit_Form.txtValueStream.Text = data.Rows(0).Item("Department").ToString()
'                                        'Edit_Form.txtLine.Text = data.Rows(0).Item("Line").ToString()
'                                        'Edit_Form.txtStation.Text = data.Rows(0).Item("Station").ToString()

'                                        Edit_Form.cboValueStream.Text = Nothing
'                                        Edit_Form.cboLine.Text = Nothing
'                                        Edit_Form.cboStation.Text = Nothing
'                                    End If
'                                End Using
'                            End Using
'                        End Using
'                    End If
'                End If
'            End If

'        Catch ex As Exception
'            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            ' Close the database connection
'            ConClose()
'        End Try

'    End Sub

'    Sub EmployeeData_Upadte_Edit()
'        If String.IsNullOrEmpty(Edit_Form.cboValueStream.Text) Then
'            MsgBox("Please select value stream!", MsgBoxStyle.Critical)
'            Edit_Form.cboValueStream.Focus()

'        ElseIf String.IsNullOrEmpty(Edit_Form.cboLine.Text) Then
'            MsgBox("Please select line for the employee!", MsgBoxStyle.Critical)
'            Edit_Form.cboLine.Focus()

'        ElseIf String.IsNullOrEmpty(Edit_Form.cboStation.Text) Then
'            MsgBox("Please select station for the employee!", MsgBoxStyle.Critical)
'            Edit_Form.cboStation.Focus()
'        Else
'            Try
'                Dim Token As String = Edit_ID

'                Dim VS As String = Edit_Form.txtValueStream.Text
'                Dim ln As String = Edit_Form.cboLine.Text
'                Dim Stn As String = Edit_Form.cboStation.Text

'                Dim query As String = "UPDATE AAA_Cert_Masterlist_tb 
'                                        SET Department = @Dept, Line = @line, Station = @Sta
'                                        WHERE ID = @id"

'                Using command As New OleDbCommand(query, Dbconnection)
'                    command.Parameters.AddWithValue("@Dept", VS)
'                    command.Parameters.AddWithValue("@line", ln)
'                    command.Parameters.AddWithValue("@Sta", Stn)
'                    command.Parameters.AddWithValue("@id", Token)
'                    'SQLDbconnection.Open()
'                    ConOpen()
'                    command.ExecuteNonQuery()
'                    ConClose()
'                End Using

'                Edit_Form.txtValueStream.Clear()
'                Edit_Form.cboValueStream.Text = Nothing
'                Edit_Form.cboLine.Text = Nothing
'                Edit_Form.cboStation.Text = Nothing

'                Get_EmployeeData_Edit()

'            Catch ex As Exception
'                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Finally
'                ' Close the database connection
'                ConClose()
'            End Try
'        End If

'    End Sub


'    '=======================< FOR Update_Form >=====================
'    Sub Delete_AlpaList()
'        ConOpen()

'        Dim deleteQuery As String = "DELETE FROM AAA_Cert_Alphalist_tb"

'        Using deleteCmd As New OleDbCommand(deleteQuery, Dbconnection)
'            Dim rowsDeleted As Integer = deleteCmd.ExecuteNonQuery()
'            Debug.WriteLine($"Deleted {rowsDeleted} records from AAA_Cert_Alphalist_tb.")
'        End Using

'        ConClose()
'    End Sub

'    Public Updated_AlphaList As String
'    Sub ImportAlphaList()
'        Try
'            ' Excel Connection String
'            Dim excelPath As String = Updated_AlphaList
'            Dim excelConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excelPath & ";Extended Properties='Excel 12.0 Xml;HDR=YES;'"
'            Using excelConn As New OleDbConnection(excelConnStr)
'                excelConn.Open()

'                ' Read Data from Excel
'                Dim query As String = "SELECT [Empcode], [First Name], [Last Name], [Department] FROM [Sheet1$]"
'                Using cmd As New OleDbCommand(query, excelConn)
'                    Dim adapter As New OleDbDataAdapter(cmd)
'                    Dim dt As New DataTable()
'                    adapter.Fill(dt)

'                    ' Open MS Access Connection
'                    ConOpen()

'                    ' Loop through DataTable and insert data into Access database
'                    For Each row As DataRow In dt.Rows
'                        Dim insertQuery As String = "INSERT INTO AAA_Cert_Alphalist_tb (Employee_Number, First_Name, Last_Name, Department) " &
'                                            "VALUES (@Empcode, @FirstName, @LastName, @Department)"

'                        Using insertCmd As New OleDbCommand(insertQuery, Dbconnection)
'                            insertCmd.Parameters.AddWithValue("@Empcode", row("Empcode").ToString())
'                            insertCmd.Parameters.AddWithValue("@FirstName", row("First Name").ToString())
'                            insertCmd.Parameters.AddWithValue("@LastName", row("Last Name").ToString())
'                            insertCmd.Parameters.AddWithValue("@Department", row("Department").ToString())

'                            insertCmd.ExecuteNonQuery()
'                        End Using
'                    Next

'                    ConClose()
'                End Using
'            End Using

'            MessageBox.Show("AAA Certification Database Alpha List is now up to date!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Update_Form.txtFolderPath.Clear()

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    '=======================< FOR Exam_Form >=====================

'    Public Exam_Attempt As Integer
'    Public Exam_Trial As Integer
'    Sub Get_Attempt_and_Trial()

'        Try
'            Dim MyData As String
'            Dim cmd As New OleDbCommand
'            Dim Data As New DataTable
'            Dim adap As New OleDbDataAdapter
'            ConOpen()

'            MyData = "SELECT * From AAA_Cert_Masterlist_tb WHERE ID = " & Exam_ID & ""
'            cmd.Connection = Dbconnection
'            cmd.CommandText = MyData
'            adap.SelectCommand = cmd
'            adap.Fill(Data)

'            If Data.Rows.Count > 0 Then

'                Exam_Attempt = Data.Rows(0).Item("Test_Attempt")
'                Console.WriteLine(Exam_Attempt)

'                'If Exam_Attempt = 3 Then
'                '    MsgBox("Your already take the exam 3 times!", MsgBoxStyle.Critical)
'                '    Exam_Form.Close()
'                '    Exit Sub
'                'End If

'                '=====< This part is to get the Exam trial >=====
'                Select Case Exam_Attempt
'                    Case 1

'                        Exam_Trial = Data.Rows(0).Item("Test1_Trial")
'                        Console.WriteLine(Exam_Trial)

'                    Case 2

'                        Exam_Trial = Data.Rows(0).Item("Test2_Trial")
'                        Console.WriteLine(Exam_Trial)

'                    Case 3

'                        Exam_Trial = Data.Rows(0).Item("Test3_Trial")
'                        Console.WriteLine(Exam_Trial)
'                End Select

'                If Exam_Trial = 0 Or Exam_Trial = 3 Then
'                    Exam_Attempt += 1
'                End If

'                Select Case Exam_Attempt
'                    Case 1

'                        Exam_Trial = Data.Rows(0).Item("Test1_Trial")
'                        Console.WriteLine(Exam_Trial)

'                        Exam_Trial += 1

'                        Exam_Form.txtTrial.Text = Exam_Trial
'                        Exam_Form.txtAttempt.Text = Exam_Attempt
'                    Case 2

'                        Exam_Trial = Data.Rows(0).Item("Test2_Trial")
'                        Console.WriteLine(Exam_Trial)

'                        Exam_Trial += 1

'                        Exam_Form.txtTrial.Text = Exam_Trial
'                        Exam_Form.txtAttempt.Text = Exam_Attempt
'                    Case 3

'                        Exam_Trial = Data.Rows(0).Item("Test3_Trial")
'                        Console.WriteLine(Exam_Trial)

'                        Exam_Trial += 1

'                        Exam_Form.txtTrial.Text = Exam_Trial
'                        Exam_Form.txtAttempt.Text = Exam_Attempt
'                End Select
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            'Dbconnection.Close()
'            ConClose()
'        End Try
'    End Sub

'    Sub Update_Attempt_and_Trial()
'        Try

'            Select Case Exam_Attempt
'                Case 1
'                    Dim DateTime As String = Date.Now.ToString("MM/dd/yyyy")

'                    Dim query As String = "UPDATE AAA_Cert_Masterlist_tb 
'                                                SET Test1_Date = @dt, Test_Attempt = @att, Test1_Trial = @tri
'                                                WHERE ID = @id"

'                    Using command As New OleDbCommand(query, Dbconnection)
'                        command.Parameters.AddWithValue("@dt", DateTime)
'                        command.Parameters.AddWithValue("@att", Exam_Attempt)
'                        command.Parameters.AddWithValue("@tri", Exam_Trial)
'                        command.Parameters.AddWithValue("@id", Exam_ID)
'                        'Dbconnection.Open()
'                        ConOpen()
'                        command.ExecuteNonQuery()
'                        'Dbconnection.Close()
'                        ConClose()
'                    End Using

'                Case 2
'                    Dim DateTime As String = Date.Now.ToString("MM/dd/yyyy")

'                    Dim query As String = "UPDATE AAA_Cert_Masterlist_tb 
'                                                SET Test2_Date = @dt, Test_Attempt = @att, Test2_Trial = @tri
'                                                WHERE ID = @id"

'                    Using command As New OleDbCommand(query, Dbconnection)
'                        command.Parameters.AddWithValue("@dt", DateTime)
'                        command.Parameters.AddWithValue("@att", Exam_Attempt)
'                        command.Parameters.AddWithValue("@tri", Exam_Trial)
'                        command.Parameters.AddWithValue("@id", Exam_ID)
'                        'Dbconnection.Open()
'                        ConOpen()
'                        command.ExecuteNonQuery()
'                        'Dbconnection.Close()
'                        ConClose()
'                    End Using

'                Case 3
'                    Dim DateTime As String = Date.Now.ToString("MM/dd/yyyy")

'                    Dim query As String = "UPDATE AAA_Cert_Masterlist_tb 
'                                                SET Test3_Date = @dt, Test_Attempt = @att, Test3_Trial = @tri
'                                                WHERE ID = @id"

'                    Using command As New OleDbCommand(query, Dbconnection)
'                        command.Parameters.AddWithValue("@dt", DateTime)
'                        command.Parameters.AddWithValue("@att", Exam_Attempt)
'                        command.Parameters.AddWithValue("@tri", Exam_Trial)
'                        command.Parameters.AddWithValue("@id", Exam_ID)
'                        'Dbconnection.Open()
'                        ConOpen()
'                        command.ExecuteNonQuery()
'                        'Dbconnection.Close()
'                        ConClose()
'                    End Using

'            End Select


'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        End Try
'    End Sub

'    Sub GoodButton_Function_Exam(imageIndex As Integer)
'        Dim DateTime As String = Date.Now.ToString("MM/dd/yyyy")

'        Dim empNum As String = Home_Form.txtEmpNum.Text
'        Dim empName As String = Exam_Form.lblName.Text
'        Dim department As String = Home_Form.txtValueStream.Text
'        Dim deptlog As String = Home_Form.txtValueStream.Text
'        Dim line As String = Exam_Form.lblLine.Text
'        Dim station As String = Exam_Form.lblStation.Text
'        Dim questionNum As Integer = imageIndex + 1 ' Adjust to 1-based index
'        Dim trialEmpAns As String = "GOOD"
'        Dim correctAns As String = ""
'        Dim judgement As String = ""

'        ' Get the correct image number
'        Dim sampleNumber As Integer = Integer.Parse(Path.GetFileNameWithoutExtension(Exam_Form.imageList(imageIndex)))
'        Dim imageNumber As String = Path.GetFileName(Exam_Form.imageList(imageIndex))

'        Select Case department
'            Case "TR/TE"
'                department = "TRTE"
'            Case "SQUARE NANO"
'                department = "SQ_NANO"
'            Case "PICO/SMF/BARRIER"
'                department = "PICO"
'            Case "CERAMIC FUSE"
'                department = "CERAMIC_FUSE"
'            Case "THIN FILM"
'                department = "THIN_FILM"
'            Case "REED SWITCH"
'                department = "REED_SWITCH"
'        End Select

'        Try
'            ConOpen()

'            ' Get correct answer from the answer key using Sample_Number
'            Dim query As String = $"SELECT {department} FROM AAA_Cert_AnswerKey_tb WHERE Sample_Number = @SampleNumber"
'            Using cmd As New OleDbCommand(query, Dbconnection)
'                cmd.Parameters.AddWithValue("@SampleNumber", sampleNumber)
'                Dim result = cmd.ExecuteScalar()

'                If result IsNot Nothing Then
'                    correctAns = result.ToString()
'                    judgement = If(correctAns = trialEmpAns, "Right", "Wrong")
'                Else
'                    MessageBox.Show("No answer key found for this sample number.")
'                    Return
'                End If
'            End Using

'            ' Insert data into exam result table including Image_Number
'            Dim insertQuery As String = "INSERT INTO AAA_Cert_ExamResult_tb (Employee_Number, EmployeeName, Department, Line, Station, Test_Attempt, Test_Date, Test_Trial, EmpAns, CorrectAns, Judgement, Question_Num, Image_Number) " &
'                                         "VALUES (@EmpNum, @EmpName, @Department, @Line, @Station, @attempt, @dt, @tri, @EmpAns, @CorrectAns, @Judgement, @QuestionNum, @ImageNumber)"
'            Using cmd As New OleDbCommand(insertQuery, Dbconnection)
'                cmd.Parameters.AddWithValue("@EmpNum", empNum)
'                cmd.Parameters.AddWithValue("@EmpName", empName)
'                cmd.Parameters.AddWithValue("@Department", deptlog)
'                cmd.Parameters.AddWithValue("@Line", line)
'                cmd.Parameters.AddWithValue("@Station", station)
'                cmd.Parameters.AddWithValue("@attempt", Exam_Attempt)
'                cmd.Parameters.AddWithValue("@dt", DateTime)
'                cmd.Parameters.AddWithValue("@tri", Exam_Trial)
'                cmd.Parameters.AddWithValue("@EmpAns", trialEmpAns)
'                cmd.Parameters.AddWithValue("@CorrectAns", correctAns)
'                cmd.Parameters.AddWithValue("@Judgement", judgement)
'                cmd.Parameters.AddWithValue("@QuestionNum", questionNum)
'                cmd.Parameters.AddWithValue("@ImageNumber", imageNumber)
'                cmd.ExecuteNonQuery()
'            End Using

'            Console.WriteLine("Answer Recorded Successfully.")
'            ConClose()
'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        End Try
'    End Sub

'    Sub NGButton_Function_Exam(imageIndex As Integer)
'        Dim DateTime As String = Date.Now.ToString("MM/dd/yyyy")

'        Dim empNum As String = Home_Form.txtEmpNum.Text
'        Dim empName As String = Exam_Form.lblName.Text
'        Dim department As String = Home_Form.txtValueStream.Text
'        Dim deptlog As String = Home_Form.txtValueStream.Text
'        Dim line As String = Exam_Form.lblLine.Text
'        Dim station As String = Exam_Form.lblStation.Text
'        Dim questionNum As Integer = imageIndex + 1 ' Adjust to 1-based index
'        Dim trialEmpAns As String = "NO GOOD"
'        Dim correctAns As String = ""
'        Dim judgement As String = ""

'        ' Get the correct image number
'        Dim sampleNumber As Integer = Integer.Parse(Path.GetFileNameWithoutExtension(Exam_Form.imageList(imageIndex)))
'        Dim imageNumber As String = Path.GetFileName(Exam_Form.imageList(imageIndex))

'        Select Case department
'            Case "TR/TE"
'                department = "TRTE"
'            Case "SQUARE NANO"
'                department = "SQ_NANO"
'            Case "PICO/SMF/BARRIER"
'                department = "PICO"
'            Case "CERAMIC FUSE"
'                department = "CERAMIC_FUSE"
'            Case "THIN FILM"
'                department = "THIN_FILM"
'            Case "REED SWITCH"
'                department = "REED_SWITCH"
'        End Select

'        Try
'            ConOpen()

'            ' Get correct answer from the answer key using Sample_Number
'            Dim query As String = $"SELECT {department} FROM AAA_Cert_AnswerKey_tb WHERE Sample_Number = @SampleNumber"
'            Using cmd As New OleDbCommand(query, Dbconnection)
'                cmd.Parameters.AddWithValue("@SampleNumber", sampleNumber)
'                Dim result = cmd.ExecuteScalar()

'                If result IsNot Nothing Then
'                    correctAns = result.ToString()
'                    judgement = If(correctAns = trialEmpAns, "Right", "Wrong")
'                Else
'                    MessageBox.Show("No answer key found for this sample number.")
'                    Return
'                End If
'            End Using

'            ' Insert data into exam result table including Image_Number
'            Dim insertQuery As String = "INSERT INTO AAA_Cert_ExamResult_tb (Employee_Number, EmployeeName, Department, Line, Station, Test_Attempt, Test_Date, Test_Trial, EmpAns, CorrectAns, Judgement, Question_Num, Image_Number) " &
'                                         "VALUES (@EmpNum, @EmpName, @Department, @Line, @Station, @attempt, @dt, @tri, @EmpAns, @CorrectAns, @Judgement, @QuestionNum, @ImageNumber)"
'            Using cmd As New OleDbCommand(insertQuery, Dbconnection)
'                cmd.Parameters.AddWithValue("@EmpNum", empNum)
'                cmd.Parameters.AddWithValue("@EmpName", empName)
'                cmd.Parameters.AddWithValue("@Department", deptlog)
'                cmd.Parameters.AddWithValue("@Line", line)
'                cmd.Parameters.AddWithValue("@Station", station)
'                cmd.Parameters.AddWithValue("@attempt", Exam_Attempt)
'                cmd.Parameters.AddWithValue("@dt", DateTime)
'                cmd.Parameters.AddWithValue("@tri", Exam_Trial)
'                cmd.Parameters.AddWithValue("@EmpAns", trialEmpAns)
'                cmd.Parameters.AddWithValue("@CorrectAns", correctAns)
'                cmd.Parameters.AddWithValue("@Judgement", judgement)
'                cmd.Parameters.AddWithValue("@QuestionNum", questionNum)
'                cmd.Parameters.AddWithValue("@ImageNumber", imageNumber)
'                cmd.ExecuteNonQuery()
'            End Using

'            Console.WriteLine("Answer Recorded Successfully.")
'            ConClose()
'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        End Try
'    End Sub

'    'Public Sub UpdateResults(Exam_ID As Integer)
'    '    Try
'    '        ConOpen()

'    '        ' Retrieve trial results
'    '        Dim query As String = "SELECT Test_Attempt, Test_Trial, COUNT(*) AS RightCount FROM AAA_Cert_ExamResult_tb WHERE Exam_ID = @Exam_ID AND Judgement = 'Right' GROUP BY Test_Attempt, Test_Trial"
'    '        Dim cmd As New OleDbCommand(query, Dbconnection)
'    '        cmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '        Dim reader As OleDbDataReader = cmd.ExecuteReader()

'    '        Dim attemptResults As New Dictionary(Of Integer, Dictionary(Of Integer, Integer))

'    '        While reader.Read()
'    '            Dim testAttempt As Integer = Convert.ToInt32(reader("Test_Attempt"))
'    '            Dim testTrial As Integer = Convert.ToInt32(reader("Test_Trial"))
'    '            Dim rightCount As Integer = Convert.ToInt32(reader("RightCount"))

'    '            If Not attemptResults.ContainsKey(testAttempt) Then
'    '                attemptResults(testAttempt) = New Dictionary(Of Integer, Integer)()
'    '            End If

'    '            attemptResults(testAttempt)(testTrial) = rightCount
'    '        End While

'    '        reader.Close()

'    '        ' Update trial results with the average score
'    '        For Each attempt In attemptResults.Keys
'    '            Dim trialResults = attemptResults(attempt)
'    '            For Each trial In trialResults.Keys
'    '                Dim averageScore As Double = (trialResults(trial) / 50) * 100
'    '                Dim columnName As String = $"Test{attempt}_Result_Trial{trial}"
'    '                Dim updateQuery As String = $"UPDATE AAA_Cert_Masterlist_tb SET {columnName} = @AverageScore WHERE ID = @Exam_ID"

'    '                Using updateCmd As New OleDbCommand(updateQuery, Dbconnection)
'    '                    updateCmd.Parameters.AddWithValue("@AverageScore", averageScore)
'    '                    updateCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '                    updateCmd.ExecuteNonQuery()
'    '                End Using
'    '            Next
'    '        Next

'    '        ' Evaluate overall results using the updated logic
'    '        For Each attempt In attemptResults.Keys
'    '            Dim totalRightQuery As String = "SELECT COUNT(*) FROM AAA_Cert_ExamResult_tb WHERE Exam_ID = @Exam_ID AND Test_Attempt = @Attempt AND Judgement = 'Right' AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station"
'    '            Dim totalCmd As New OleDbCommand(totalRightQuery, Dbconnection)
'    '            totalCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '            totalCmd.Parameters.AddWithValue("@Attempt", attempt)
'    '            totalCmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'    '            totalCmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'    '            totalCmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'    '            totalCmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'    '            Dim totalRight As Integer = Convert.ToInt32(totalCmd.ExecuteScalar())

'    '            Dim testStatus As String = If((totalRight / 150) * 100 >= 90, "PASSED", "FAILED")
'    '            Dim testJudgementColumn As String = $"Test{attempt}_Judgement"

'    '            Dim statusUpdateQuery As String = $"UPDATE AAA_Cert_Masterlist_tb SET Test_Status = @TestStatus, {testJudgementColumn} = @TestStatus WHERE ID = @Exam_ID"

'    '            Using statusCmd As New OleDbCommand(statusUpdateQuery, Dbconnection)
'    '                statusCmd.Parameters.AddWithValue("@TestStatus", testStatus)
'    '                statusCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '                statusCmd.ExecuteNonQuery()
'    '            End Using

'    '            ' Update AAA_Exp_Date if Test_Status is PASSED
'    '            If testStatus = "PASSED" Then
'    '                Dim expDate As Date = Date.Today.AddYears(1)
'    '                Dim expDateQuery As String = "UPDATE AAA_Cert_Masterlist_tb SET AAA_Exp_Date = @ExpDate WHERE ID = @Exam_ID"

'    '                Using expCmd As New OleDbCommand(expDateQuery, Dbconnection)
'    '                    expCmd.Parameters.AddWithValue("@ExpDate", expDate)
'    '                    expCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '                    expCmd.ExecuteNonQuery()
'    '                End Using
'    '            End If
'    '        Next

'    '    Catch ex As Exception
'    '        MessageBox.Show("Error: " & ex.Message)
'    '    Finally
'    '        ConClose()
'    '    End Try
'    'End Sub



'    '=======================< FOR TrialResult_Form >=====================

'    'Public Sub UpdateResults(Exam_ID As Integer)
'    '    Try
'    '        ConOpen()

'    '        ' Retrieve trial results
'    '        Dim query As String = "SELECT Test_Attempt, Test_Trial, COUNT(*) AS RightCount FROM AAA_Cert_ExamResult_tb WHERE Exam_ID = @Exam_ID AND Test_Attempt = @Attempt AND Judgement = 'Right' AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station GROUP BY Test_Attempt, Test_Trial"
'    '        Dim cmd As New OleDbCommand(query, Dbconnection)
'    '        cmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '        cmd.Parameters.AddWithValue("@Attempt", Exam_Attempt) ' Example attempt value, update as needed
'    '        cmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'    '        cmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'    '        cmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'    '        cmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'    '        Dim reader As OleDbDataReader = cmd.ExecuteReader()
'    '        Dim attemptResults As New Dictionary(Of Integer, Dictionary(Of Integer, Integer))

'    '        While reader.Read()
'    '            Dim testAttempt As Integer = Convert.ToInt32(reader("Test_Attempt"))
'    '            Dim testTrial As Integer = Convert.ToInt32(reader("Test_Trial"))
'    '            Dim rightCount As Integer = Convert.ToInt32(reader("RightCount"))

'    '            If Not attemptResults.ContainsKey(testAttempt) Then
'    '                attemptResults(testAttempt) = New Dictionary(Of Integer, Integer)()
'    '            End If

'    '            attemptResults(testAttempt)(testTrial) = rightCount
'    '        End While

'    '        reader.Close()

'    '        ' Update trial results with the average score
'    '        For Each attempt In attemptResults.Keys
'    '            Dim trialResults = attemptResults(attempt)
'    '            For Each trial In trialResults.Keys
'    '                Dim totalQuestions As Integer = 50
'    '                Dim averageScore As Double = If(totalQuestions > 0, (trialResults(trial) / totalQuestions) * 100, 0)
'    '                Dim columnName As String = $"Test{attempt}_Result_Trial{trial}"
'    '                Dim updateQuery As String = $"UPDATE AAA_Cert_Masterlist_tb SET {columnName} = @AverageScore WHERE ID = @Exam_ID"

'    '                Using updateCmd As New OleDbCommand(updateQuery, Dbconnection)
'    '                    updateCmd.Parameters.AddWithValue("@AverageScore", averageScore)
'    '                    updateCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '                    updateCmd.ExecuteNonQuery()
'    '                End Using
'    '            Next
'    '        Next

'    '        ' Evaluate overall results
'    '        For Each attempt In attemptResults.Keys
'    '            Dim totalRightQuery As String = "SELECT COUNT(*) FROM AAA_Cert_ExamResult_tb WHERE Exam_ID = @Exam_ID AND Test_Attempt = @Attempt AND Judgement = 'Right' AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station"
'    '            Dim totalCmd As New OleDbCommand(totalRightQuery, Dbconnection)
'    '            totalCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '            totalCmd.Parameters.AddWithValue("@Attempt", attempt)
'    '            totalCmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'    '            totalCmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'    '            totalCmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'    '            totalCmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'    '            Dim totalRight As Integer = Convert.ToInt32(totalCmd.ExecuteScalar())

'    '            ' Dynamically check the total attempts
'    '            Dim totalAttemptQuery As String = "SELECT COUNT(*) FROM AAA_Cert_ExamResult_tb WHERE Exam_ID = @Exam_ID AND Test_Attempt = @Attempt AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station"
'    '            Dim totalAttemptCmd As New OleDbCommand(totalAttemptQuery, Dbconnection)
'    '            totalAttemptCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '            totalAttemptCmd.Parameters.AddWithValue("@Attempt", attempt)
'    '            totalAttemptCmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'    '            totalAttemptCmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'    '            totalAttemptCmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'    '            totalAttemptCmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'    '            Dim totalAttempt As Integer = Convert.ToInt32(totalAttemptCmd.ExecuteScalar())
'    '            Dim testStatus As String = If(totalAttempt > 0 AndAlso (totalRight / totalAttempt) * 100 >= 90, "PASSED", "FAILED")
'    '            Dim testJudgementColumn As String = $"Test{attempt}_Judgement"

'    '            Dim statusUpdateQuery As String = $"UPDATE AAA_Cert_Masterlist_tb SET Test_Status = @TestStatus, {testJudgementColumn} = @TestStatus WHERE ID = @Exam_ID"

'    '            Using statusCmd As New OleDbCommand(statusUpdateQuery, Dbconnection)
'    '                statusCmd.Parameters.AddWithValue("@TestStatus", testStatus)
'    '                statusCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '                statusCmd.ExecuteNonQuery()
'    '            End Using

'    '            ' Update AAA_Exp_Date if Test_Status is PASSED
'    '            If testStatus = "PASSED" Then
'    '                Dim expDate As Date = Date.Today.AddYears(1)
'    '                Dim expDateQuery As String = "UPDATE AAA_Cert_Masterlist_tb SET AAA_Exp_Date = @ExpDate WHERE ID = @Exam_ID"

'    '                Using expCmd As New OleDbCommand(expDateQuery, Dbconnection)
'    '                    expCmd.Parameters.AddWithValue("@ExpDate", expDate)
'    '                    expCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'    '                    expCmd.ExecuteNonQuery()
'    '                End Using
'    '            End If
'    '        Next

'    '    Catch ex As Exception
'    '        MessageBox.Show("Error: " & ex.Message)
'    '    Finally
'    '        ConClose()
'    '    End Try
'    'End Sub

'    Public Sub UpdateResults(Exam_ID As Integer)
'        Try
'            ConOpen()

'            ' Retrieve trial results
'            Dim query As String = "SELECT Test_Attempt, Test_Trial, COUNT(*) AS RightCount FROM AAA_Cert_ExamResult_tb WHERE Test_Attempt = @Attempt AND Judgement = 'Right' AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station GROUP BY Test_Attempt, Test_Trial"
'            Dim cmd As New OleDbCommand(query, Dbconnection)
'            'cmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'            cmd.Parameters.AddWithValue("@Attempt", Exam_Attempt) ' Example attempt value, update as needed
'            cmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'            cmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'            cmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'            cmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'            Dim reader As OleDbDataReader = cmd.ExecuteReader()
'            Dim attemptResults As New Dictionary(Of Integer, Dictionary(Of Integer, Integer))

'            While reader.Read()
'                Dim testAttempt As Integer = Convert.ToInt32(reader("Test_Attempt"))
'                Dim testTrial As Integer = Convert.ToInt32(reader("Test_Trial"))
'                Dim rightCount As Integer = Convert.ToInt32(reader("RightCount"))

'                If Not attemptResults.ContainsKey(testAttempt) Then
'                    attemptResults(testAttempt) = New Dictionary(Of Integer, Integer)()
'                End If

'                attemptResults(testAttempt)(testTrial) = rightCount
'            End While

'            reader.Close()

'            ' Update trial results with the average score
'            For Each attempt In attemptResults.Keys
'                Dim trialResults = attemptResults(attempt)
'                For Each trial In trialResults.Keys
'                    Dim totalQuestions As Integer = 50
'                    Dim averageScore As Double = If(totalQuestions > 0, (trialResults(trial) / totalQuestions) * 100, 0)
'                    Dim columnName As String = $"Test{attempt}_Result_Trial{trial}"
'                    Dim updateQuery As String = $"UPDATE AAA_Cert_Masterlist_tb SET {columnName} = @AverageScore WHERE ID = @Exam_ID"

'                    Using updateCmd As New OleDbCommand(updateQuery, Dbconnection)
'                        updateCmd.Parameters.AddWithValue("@AverageScore", averageScore)
'                        updateCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'                        updateCmd.ExecuteNonQuery()
'                    End Using
'                Next
'            Next

'            ' Evaluate overall results
'            For Each attempt In attemptResults.Keys
'                Dim totalRightQuery As String = "SELECT COUNT(*) FROM AAA_Cert_ExamResult_tb WHERE Test_Attempt = @Attempt AND Judgement = 'Right' AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station"
'                Dim totalCmd As New OleDbCommand(totalRightQuery, Dbconnection)
'                'totalCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'                totalCmd.Parameters.AddWithValue("@Attempt", attempt)
'                totalCmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'                totalCmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'                totalCmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'                totalCmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'                Dim totalRight As Integer = Convert.ToInt32(totalCmd.ExecuteScalar())

'                ' Dynamically check the total attempts
'                Dim totalAttemptQuery As String = "SELECT COUNT(*) FROM AAA_Cert_ExamResult_tb WHERE Test_Attempt = @Attempt AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station"
'                Dim totalAttemptCmd As New OleDbCommand(totalAttemptQuery, Dbconnection)
'                'totalAttemptCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'                totalAttemptCmd.Parameters.AddWithValue("@Attempt", attempt)
'                totalAttemptCmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'                totalAttemptCmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'                totalAttemptCmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'                totalAttemptCmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'                Dim totalAttempt As Integer = Convert.ToInt32(totalAttemptCmd.ExecuteScalar())
'                Dim testStatus As String = If(totalAttempt > 0 AndAlso (totalRight / totalAttempt) * 100 >= 90, "PASSED", "FAILED")
'                Dim testJudgementColumn As String = $"Test{attempt}_Judgement"

'                Dim statusUpdateQuery As String = $"UPDATE AAA_Cert_Masterlist_tb SET Test_Status = @TestStatus, {testJudgementColumn} = @TestStatus WHERE ID = @Exam_ID"

'                Using statusCmd As New OleDbCommand(statusUpdateQuery, Dbconnection)
'                    statusCmd.Parameters.AddWithValue("@TestStatus", testStatus)
'                    statusCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'                    statusCmd.ExecuteNonQuery()
'                End Using

'                ' Update AAA_Exp_Date if Test_Status is PASSED
'                If testStatus = "PASSED" Then
'                    Dim expDate As Date = Date.Today.AddYears(1)
'                    Dim expDateQuery As String = "UPDATE AAA_Cert_Masterlist_tb SET AAA_Exp_Date = @ExpDate WHERE ID = @Exam_ID"

'                    Using expCmd As New OleDbCommand(expDateQuery, Dbconnection)
'                        expCmd.Parameters.AddWithValue("@ExpDate", expDate)
'                        expCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'                        expCmd.ExecuteNonQuery()
'                    End Using
'                End If
'            Next

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    Public TrialResult_TrialNumber As Integer

'    Public Sub Get_TestTrial_Result(Exam_ID As Integer, attempt As Integer)
'        Try
'            ConOpen()
'            Dim displayQuery As String = $"SELECT Test{attempt}_Result_Trial1, Test{attempt}_Result_Trial2, Test{attempt}_Result_Trial3, Test_Status FROM AAA_Cert_Masterlist_tb WHERE ID = @Exam_ID"

'            Using displayCmd As New OleDbCommand(displayQuery, Dbconnection)
'                displayCmd.Parameters.AddWithValue("@Exam_ID", Exam_ID)
'                Using displayReader As OleDbDataReader = displayCmd.ExecuteReader()
'                    If displayReader.Read() Then
'                        TrialResult_Form.lblScore1.Text = "Score: " & displayReader($"Test{attempt}_Result_Trial1").ToString() & "%"
'                        TrialResult_Form.lblScore2.Text = "Score: " & displayReader($"Test{attempt}_Result_Trial2").ToString() & "%"
'                        TrialResult_Form.lblScore3.Text = "Score: " & displayReader($"Test{attempt}_Result_Trial3").ToString() & "%"

'                        Dim testStatus As String = displayReader("Test_Status").ToString()
'                        If testStatus = "PASSED" Then
'                            TrialResult_Form.PictureBox_ExamStatus.Image = My.Resources.pass
'                            TrialResult_Form.lblMessName.Text = "Congrats " & Home_Form.txtName.Text & " you"
'                        ElseIf testStatus = "FAILED" Then
'                            TrialResult_Form.PictureBox_ExamStatus.Image = My.Resources.fail
'                            TrialResult_Form.lblMessName.Text = "Sorry " & Home_Form.txtName.Text & " you"
'                        End If
'                    End If
'                End Using
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    '=======================< FOR ExamResult_Form >=====================

'    Private ExamResults As New List(Of Dictionary(Of String, Object))
'    Private CurrentIndex_ExamRes As Integer = 0

'    Sub DeleteExamResult()
'        ConOpen()

'        Dim department As String = Home_Form.txtValueStream.Text
'        Dim inspectorName As String = Home_Form.txtName.Text
'        Dim idNumber As String = Home_Form.txtEmpNum.Text
'        Dim station As String = Home_Form.txtStation.Text
'        Dim Line As String = Home_Form.txtLine.Text


'        Dim deleteQuery As String = $"DELETE FROM AAA_Cert_ExamResult_tb WHERE Department = '{department}' AND Station = '{station}' AND Employee_Number = '{idNumber}' AND Line = '{Line}' AND Test_Attempt = {Exam_Attempt}"

'        Using deleteCmd As New OleDbCommand(deleteQuery, Dbconnection)
'            Dim rowsDeleted As Integer = deleteCmd.ExecuteNonQuery()
'            Console.WriteLine($"Deleted {rowsDeleted} records from AAA_Cert_ExamResult_tb.")
'        End Using

'        ConClose()
'    End Sub

'    Sub Get_ExamResult(ByVal TrialResult_TrialNumber As Integer)
'        Try
'            ConOpen()
'            Dim query As String = "SELECT Test_Trial, Question_Num, CorrectAns, Image_Number FROM AAA_Cert_ExamResult_tb WHERE Judgement = 'Wrong' AND Test_Trial = @TrialNum AND Test_Attempt = @TestAtt AND Employee_Number = @EmpNum AND Department = @Dept AND Line = @Line AND Station = @Station ORDER BY Question_Num"
'            Using cmd As New OleDbCommand(query, Dbconnection)
'                cmd.Parameters.AddWithValue("@TrialNum", TrialResult_TrialNumber)
'                cmd.Parameters.AddWithValue("@TestAtt", Exam_Attempt)
'                cmd.Parameters.AddWithValue("@EmpNum", Home_Form.txtEmpNum.Text)
'                cmd.Parameters.AddWithValue("@Dept", Home_Form.txtValueStream.Text)
'                cmd.Parameters.AddWithValue("@Line", Home_Form.txtLine.Text)
'                cmd.Parameters.AddWithValue("@Station", Home_Form.txtStation.Text)

'                Dim reader As OleDbDataReader = cmd.ExecuteReader()
'                ExamResults.Clear()
'                While reader.Read()
'                    Dim result As New Dictionary(Of String, Object) From {
'                    {"Test_Trial", reader("Test_Trial")},
'                    {"Question_Num", reader("Question_Num")},
'                    {"CorrectAns", reader("CorrectAns")},
'                    {"Image_Number", reader("Image_Number")}
'                }
'                    ExamResults.Add(result)
'                End While
'            End Using

'            If ExamResults.Count > 0 Then
'                CurrentIndex_ExamRes = 0
'                DisplayCurrentResult()
'            Else
'                MessageBox.Show("No mistakes found.")
'            End If

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    Public Path_TestImage As String '= "C:\Backup\RS"

'    Sub DisplayCurrentResult()
'        If ExamResults.Count = 0 OrElse CurrentIndex_ExamRes < 0 OrElse CurrentIndex_ExamRes >= ExamResults.Count Then Exit Sub

'        Dim currentResult = ExamResults(CurrentIndex_ExamRes)
'        ExamResult_Form.lblTrialNum.Text = currentResult("Test_Trial").ToString()
'        ExamResult_Form.lblQuestion.Text = "Question Number: " & currentResult("Question_Num").ToString()
'        If currentResult("CorrectAns").ToString() = "NO GOOD" Then

'            ExamResult_Form.lblCorrectAns.Text = currentResult("CorrectAns").ToString()
'            ExamResult_Form.lblCorrectAns.ForeColor = Color.Red

'        Else
'            ExamResult_Form.lblCorrectAns.Text = currentResult("CorrectAns").ToString()
'            ExamResult_Form.lblCorrectAns.ForeColor = Color.LimeGreen

'        End If

'        Get_ImagePath() ' get the folder path

'        Dim imagePath As String = $"{Path_TestImage}\{currentResult("Image_Number")}"

'        Console.WriteLine("Image Path: " & imagePath)
'        If IO.File.Exists(imagePath) Then
'            ExamResult_Form.PictureBox1.Image = Image.FromFile(imagePath)
'        Else
'            ExamResult_Form.PictureBox1.Image = Nothing
'        End If

'        ExamResult_Form.lblMistake.Text = $"Mistake(s): {CurrentIndex_ExamRes + 1} of {ExamResults.Count}"
'    End Sub

'    Sub ExamRes_Next()
'        If CurrentIndex_ExamRes < ExamResults.Count - 1 Then
'            CurrentIndex_ExamRes += 1
'            DisplayCurrentResult()
'            ExamResult_Form.btnPrev.Enabled = True
'        Else
'            MessageBox.Show("You are on the last mistake.")
'        End If
'    End Sub

'    Sub ExamRes_Prev()
'        If CurrentIndex_ExamRes > 0 Then
'            CurrentIndex_ExamRes -= 1
'            DisplayCurrentResult()
'        Else
'            MessageBox.Show("You are on the first mistake.")
'        End If
'    End Sub

'    Public Sub Extract_Result()
'        Try
'            ConOpen()

'            Dim department As String = Home_Form.txtValueStream.Text
'            Dim department2 As String = Home_Form.txtValueStream.Text
'            Dim inspectorName As String = Home_Form.txtName.Text
'            Dim idNumber As String = Home_Form.txtEmpNum.Text
'            Dim station As String = Home_Form.txtStation.Text
'            Dim Line As String = Home_Form.txtLine.Text

'            ' Department Mapping
'            Select Case department
'                Case "TR/TE"
'                    department = "TRTE"
'                Case "SQUARE NANO"
'                    department = "SQ_NANO"
'                Case "PICO/SMF/BARRIER"
'                    department = "PICO"
'                Case "CERAMIC FUSE"
'                    department = "CERAMIC_FUSE"
'                Case "THIN FILM"
'                    department = "THIN_FILM"
'                Case "REED SWITCH"
'                    department = "REED_SWITCH"
'                Case Else
'                    MessageBox.Show("Invalid Department Selected.")
'                    Exit Sub
'            End Select

'            ' Retrieve Employee Answers and Judgement Data
'            Dim answerQuery As String = $"SELECT [Question_Num], [Test_Trial], [EmpAns], [Judgement] FROM AAA_Cert_ExamResult_tb WHERE Department = '{department2}' AND Station = '{station}' AND Employee_Number = '{idNumber}' AND Line = '{Line}' AND Test_Attempt = {Exam_Attempt}"
'            Dim answerAdapter As New OleDbDataAdapter(answerQuery, Dbconnection)
'            Dim resultTable As New DataTable()
'            answerAdapter.Fill(resultTable)

'            ' Retrieve Answer Keys
'            Dim answerKeyQuery As String = $"SELECT [{department}] FROM AAA_Cert_AnswerKey_tb"
'            Dim answerKeyAdapter As New OleDbDataAdapter(answerKeyQuery, Dbconnection)
'            Dim answerKeyTable As New DataTable()
'            answerKeyAdapter.Fill(answerKeyTable)

'            If resultTable.Rows.Count = 0 Or answerKeyTable.Rows.Count = 0 Then
'                MessageBox.Show("No data found for the selected department.")
'                Exit Sub
'            End If

'            ' Generate Excel Report
'            SaveARRReport(resultTable, answerKeyTable, inspectorName, idNumber, department, station)
'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    Public Take As String
'    Public Year_Saving As String = Date.Now.ToString("yyyy")
'    Public Month_Saving As String = Date.Now.ToString("MMMM")

'    Public Path_Saving As String '= "C:\Backup\AAA Certification"

'    Sub SaveARRReport(resultTable As DataTable, answerKeyTable As DataTable, inspectorName As String, idNumber As String, department As String, station As String)
'        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
'        Dim dateNtime = DateTime.Now.ToString("MMM dd yyyy - HH_mmtt")

'        Select Case Exam_Attempt
'            Case 1
'                Take = "1st Take"
'            Case 2
'                Take = "2nd Take"
'            Case 3
'                Take = "3rd Take"
'        End Select

'        Get_SavingPath() 'get the folder path

'        Dim get_FolderPath As String = $"{Path_Saving}\AAA Certification\{Year_Saving}\{Month_Saving}\{Take} {inspectorName} {dateNtime}.xlsx"

'        Dim directoryPath As String = Path.GetDirectoryName(get_FolderPath)
'        If Not Directory.Exists(directoryPath) Then
'            Directory.CreateDirectory(directoryPath)
'        End If

'        Try
'            Dim logo As Bitmap = My.Resources.LF

'            Using ms As New MemoryStream()
'                logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
'                ms.Position = 0

'                Using package As New ExcelPackage()
'                    Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("ARR Form")
'                    worksheet.View.PageBreakView = True

'                    worksheet.Cells("A1:H1").Merge = True
'                    Dim picture = worksheet.Drawings.AddPicture("LF_Logo", ms)
'                    picture.SetPosition(0, 0)
'                    picture.SetSize(129, 28)

'                    worksheet.InsertRow(2, 1)

'                    worksheet.Cells("A2:H2").Merge = True
'                    worksheet.Cells("A2").Value = "ATTRIBUTE AGREEMENT ANALYSIS (ANSWER SHEET)"
'                    worksheet.Cells("A2").Style.Font.Size = 16
'                    worksheet.Cells("A2").Style.Font.Bold = True
'                    worksheet.Cells("A2").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("A3").Value = "Inspector's Name:"
'                    worksheet.Cells("A3").Style.Font.Bold = True
'                    worksheet.Cells("B3:D3").Merge = True
'                    worksheet.Cells("B3").Value = inspectorName
'                    worksheet.Cells("B3:D3").Style.Border.Bottom.Style = ExcelBorderStyle.Thin
'                    worksheet.Cells("B3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("E3").Value = "Date Conducted:"
'                    worksheet.Cells("E3").Style.Font.Bold = True
'                    worksheet.Cells("F3:H3").Merge = True
'                    worksheet.Cells("F3").Value = DateTime.Now.ToString("M/d/yyyy")
'                    worksheet.Cells("F3:H3").Style.Border.Bottom.Style = ExcelBorderStyle.Thin
'                    worksheet.Cells("F3").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("A4").Value = "ID Number / Stat:"
'                    worksheet.Cells("A4").Style.Font.Bold = True
'                    worksheet.Cells("B4:D4").Merge = True
'                    worksheet.Cells("B4").Value = $"{idNumber} / {station}"
'                    worksheet.Cells("B4:D4").Style.Border.Bottom.Style = ExcelBorderStyle.Thin
'                    worksheet.Cells("B4").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                    worksheet.Cells("E4").Value = "Department:"
'                    worksheet.Cells("E4").Style.Font.Bold = True
'                    worksheet.Cells("F4:H4").Merge = True
'                    worksheet.Cells("F4").Value = department
'                    worksheet.Cells("F4:H4").Style.Border.Bottom.Style = ExcelBorderStyle.Thin
'                    worksheet.Cells("F4").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("A6").Value = "Test Samples"
'                    worksheet.Cells("A6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                    worksheet.Cells("B6").Value = department
'                    worksheet.Cells("B6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                    worksheet.Cells("C6:D6").Merge = True
'                    worksheet.Cells("C6").Value = "TRIAL 1"
'                    worksheet.Cells("C6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                    worksheet.Cells("E6:F6").Merge = True
'                    worksheet.Cells("E6").Value = "TRIAL 2"
'                    worksheet.Cells("E6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                    worksheet.Cells("G6:H6").Merge = True
'                    worksheet.Cells("G6").Value = "TRIAL 3"
'                    worksheet.Cells("G6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                    worksheet.Cells("A6:H6").Style.Font.Bold = True
'                    worksheet.Cells("A6:H6").Style.Border.BorderAround(ExcelBorderStyle.Thick)

'                    ' Column Headers with Thick Border
'                    worksheet.Cells("A6").Value = "Test Samples"
'                    worksheet.Cells("A6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("B6").Value = department
'                    worksheet.Cells("B6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("C6:D6").Merge = True
'                    worksheet.Cells("C6").Value = "TRIAL 1"
'                    worksheet.Cells("C6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("E6:F6").Merge = True
'                    worksheet.Cells("E6").Value = "TRIAL 2"
'                    worksheet.Cells("E6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("G6:H6").Merge = True
'                    worksheet.Cells("G6").Value = "TRIAL 3"
'                    worksheet.Cells("G6").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center

'                    worksheet.Cells("A6:H6").Style.Font.Bold = True
'                    worksheet.Cells("A6:H6").Style.Border.BorderAround(ExcelBorderStyle.Thick)

'                    worksheet.Cells("A6:A59").Style.Border.BorderAround(ExcelBorderStyle.Thick)
'                    worksheet.Cells("B6:B59").Style.Border.BorderAround(ExcelBorderStyle.Thick)
'                    worksheet.Cells("C6:C59").Style.Border.BorderAround(ExcelBorderStyle.Thick)
'                    worksheet.Cells("E6:E59").Style.Border.BorderAround(ExcelBorderStyle.Thick)
'                    worksheet.Cells("G6:G59").Style.Border.BorderAround(ExcelBorderStyle.Thick)
'                    worksheet.Cells("H6:H59").Style.Border.BorderAround(ExcelBorderStyle.Thick)


'                    Dim totalMatched(3) As Integer
'                    Dim totalInspected(3) As Integer

'                    For i As Integer = 6 To 59
'                        worksheet.Cells($"C{i}:D{i}").Merge = True
'                        worksheet.Cells($"E{i}:F{i}").Merge = True
'                        worksheet.Cells($"G{i}:H{i}").Merge = True
'                        'worksheet.Cells($"H{i}:I{i}").Merge = True

'                        worksheet.Cells($"A{i}").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                        worksheet.Cells($"B{i}").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                        worksheet.Cells($"C{i}").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                        worksheet.Cells($"E{i}").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                        worksheet.Cells($"G{i}").Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
'                    Next

'                    For i As Integer = 0 To 49
'                        worksheet.Cells(i + 7, 1).Value = (i + 1).ToString()
'                        worksheet.Cells(i + 7, 2).Value = answerKeyTable.Rows(i)(department).ToString()

'                        For trialNum As Integer = 1 To 3
'                            Dim trialRow = resultTable.Select($"Question_Num = '{i + 1}' AND Test_Trial = '{trialNum.ToString()}'").FirstOrDefault()
'                            If trialRow IsNot Nothing Then
'                                Dim empAns = trialRow("EmpAns").ToString()
'                                Dim judgement = trialRow("Judgement").ToString()
'                                Dim colIndex As Integer = (trialNum - 1) * 2 + 3

'                                worksheet.Cells(i + 7, colIndex).Value = empAns
'                                totalInspected(trialNum) += 1

'                                If judgement.ToUpper() = "RIGHT" Then
'                                    worksheet.Cells(i + 7, colIndex).Style.Font.Color.SetColor(Color.Green)
'                                    totalMatched(trialNum) += 1
'                                ElseIf judgement.ToUpper() = "WRONG" Then
'                                    worksheet.Cells(i + 7, colIndex).Style.Font.Color.SetColor(Color.Red)
'                                End If
'                            End If
'                        Next
'                    Next

'                    Dim summaryRow As Integer = 57
'                    worksheet.Cells(summaryRow, 1).Value = "# Matched"
'                    worksheet.Cells(summaryRow + 1, 1).Value = "# Inspected"
'                    worksheet.Cells(summaryRow + 2, 1).Value = "% Agreement"

'                    For trialNum As Integer = 1 To 3
'                        Dim colIndex = (trialNum - 1) * 2 + 3
'                        worksheet.Cells(summaryRow, 1, summaryRow + 2, 8).Style.Border.BorderAround(ExcelBorderStyle.Thick)
'                        worksheet.Cells(summaryRow, colIndex).Value = totalMatched(trialNum)
'                        worksheet.Cells(summaryRow + 1, colIndex).Value = totalInspected(trialNum)
'                        worksheet.Cells(summaryRow + 2, colIndex).Value = If(totalInspected(trialNum) > 0, Math.Round((totalMatched(trialNum) / totalInspected(trialNum)) * 100, 2) & "%", "0%")
'                    Next

'                    worksheet.Cells.AutoFitColumns()
'                    package.SaveAs(New System.IO.FileInfo(get_FolderPath))
'                End Using
'            End Using
'        Catch ex As Exception
'            MsgBox(ex.Message, vbCritical)
'        End Try
'    End Sub


'    '=======================< FOR Transfer_Form >=====================


'    Public Recertify_ID As String
'    Public Recertify_Name As String
'    Public Recertify_Dept As String
'    Public Recertify_Line As String
'    Public Recertify_Station As String
'    Public Recertify_Attempt As Integer
'    Public Recertify_Status As String
'    Sub Get_ReCertification_Data()
'        Try
'            ' Ensure at least one cell is selected
'            If Transfer_Form.DataGridView1.SelectedCells.Count > 0 Then
'                Dim selectedRowIndex As Integer = Transfer_Form.DataGridView1.SelectedCells(0).RowIndex

'                ' Ensure row index is valid
'                If selectedRowIndex >= 0 Then
'                    ' Assuming "Title" is in column index 1 (adjust if needed)
'                    Dim titleColumnIndex As Integer = 0
'                    Dim selectedRow As DataGridViewRow = Transfer_Form.DataGridView1.Rows(selectedRowIndex)

'                    ' Retrieve the project title from the specified column
'                    Dim User_Val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

'                    ' Ensure value is not empty
'                    If Not String.IsNullOrEmpty(User_Val) Then
'                        Dim query As String = "SELECT * FROM AAA_Cert_Masterlist_tb WHERE ID = @ID"

'                        ' Open database connection
'                        ConOpen()

'                        ' Use "Using" to properly dispose of objects
'                        Using command As New OleDbCommand(query, Dbconnection)
'                            command.Parameters.AddWithValue("@ID", User_Val)

'                            Using adapter As New OleDbDataAdapter(command)
'                                Using data As New DataTable()
'                                    adapter.Fill(data)

'                                    ' If data is found, populate the filename text field
'                                    If data.Rows.Count > 0 Then
'                                        Recertify_ID = data.Rows(0).Item("ID")
'                                        Recertify_Name = data.Rows(0).Item("EmployeeName")
'                                        Recertify_Dept = data.Rows(0).Item("Department")
'                                        Recertify_Line = data.Rows(0).Item("Line")
'                                        Recertify_Station = data.Rows(0).Item("Station")
'                                        Recertify_Attempt = data.Rows(0).Item("Test_Attempt")
'                                        Recertify_Status = data.Rows(0).Item("Test_Status")

'                                        ReCertifyQstn_Form.lblReCertMes.Text = "Are you allowing " & Recertify_Name & " from " & Recertify_Dept &
'                                                                            " to retake the certification for " & Recertify_Line &
'                                                                            " line " & Recertify_Station & " station?"
'                                        ReCertifyQstn_Form.ShowDialog()

'                                    End If
'                                End Using
'                            End Using
'                        End Using
'                    End If
'                End If
'            End If

'        Catch ex As Exception
'            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            ' Close the database connection
'            ConClose()
'        End Try

'    End Sub

'    Sub CopyData_to_Recertifytb(ByVal idValue As Integer)
'        Try
'            ConOpen()

'            ' Explicitly specify all columns except ID
'            Dim query As String = "INSERT INTO AAA_Cert_Recertification_History_tb (Employee_Number, EmployeeName, Department, Line, Station, " &
'                          "Test_Attempt, Test_Status, Test1_Date, Test1_Trial, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, " &
'                          "Test2_Date, Test2_Trial, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, " &
'                          "Test3_Date, Test3_Trial, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement, AAA_Exp_Date) " &
'                          "SELECT Employee_Number, EmployeeName, Department, Line, Station, " &
'                          "Test_Attempt, Test_Status, Test1_Date, Test1_Trial, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, " &
'                          "Test2_Date, Test2_Trial, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, " &
'                          "Test3_Date, Test3_Trial, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement, AAA_Exp_Date " &
'                          "FROM AAA_Cert_Masterlist_tb WHERE ID = @id"

'            Using cmd As New OleDbCommand(query, Dbconnection)
'                cmd.Parameters.AddWithValue("@id", idValue)
'                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

'                If rowsAffected > 0 Then
'                    Console.WriteLine(rowsAffected.ToString() & " record(s) copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                Else
'                    Console.WriteLine("No records found with the given ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'                End If
'            End Using

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    Sub UpdateData_ofRecertify(idValue As Integer)
'        Try
'            ConOpen()

'            Dim Zero_val As Integer = 0
'            Dim None_val As Object = DBNull.Value ' Use DBNull.Value for empty values

'            Dim query As String = "UPDATE AAA_Cert_Masterlist_tb SET " &
'                              "Test_Attempt = @attempt, Test_Status = @stat, " &
'                              "Test1_Date = @T1Date, Test1_Trial = @T1Trial1, Test1_Result_Trial1 = @T1ResTrial1, Test1_Result_Trial2 = T1ResTrial2, Test1_Result_Trial3 = @T1ResTrial3, Test1_Judgement = @T1Judge, " &
'                              "Test2_Date = @T2Date, Test2_Trial = @T2Trial2, Test2_Result_Trial1 =@T2ResTrial1, Test2_Result_Trial2 = @T2ResTrial2, Test2_Result_Trial3 = T2ResTrial3, Test2_Judgement = T2Judge, " &
'                              "Test3_Date = @T3Date, Test3_Trial = @T3Trial1, Test3_Result_Trial1 = @T3ResTrial1, Test3_Result_Trial2 = @T3ResTrial2, Test3_Result_Trial3 = @T3ResTrial3, Test3_Judgement = @T3Judge, AAA_Exp_Date = @Exp " &
'                              "WHERE ID = @id" ' Assuming Employee_Number is the key

'            Using command As New OleDbCommand(query, Dbconnection)
'                ' Assign parameters (matching the order in the query)
'                command.Parameters.AddWithValue("@attempt", Zero_val) ' Test_Attempt
'                command.Parameters.AddWithValue("@stat", None_val) ' Test_Status
'                command.Parameters.AddWithValue("@T1Date", None_val) ' Test1_Date
'                command.Parameters.AddWithValue("@T1Trial1", Zero_val) ' Test1_Trial
'                command.Parameters.AddWithValue("@T1ResTrial1", Zero_val) ' Test1_Result_Trial1
'                command.Parameters.AddWithValue("@T1ResTrial2", Zero_val) ' Test1_Result_Trial2
'                command.Parameters.AddWithValue("@T1ResTrial3", Zero_val) ' Test1_Result_Trial3
'                command.Parameters.AddWithValue("@T1Judge", None_val) ' Test1_Judgement
'                command.Parameters.AddWithValue("@T2Date", None_val) ' Test2_Date
'                command.Parameters.AddWithValue("@T2Trial2", Zero_val) ' Test2_Trial
'                command.Parameters.AddWithValue("@T2ResTrial1", Zero_val) ' Test2_Result_Trial1
'                command.Parameters.AddWithValue("@T2ResTrial2", Zero_val) ' Test2_Result_Trial2
'                command.Parameters.AddWithValue("T2ResTrial3", Zero_val) ' Test2_Result_Trial3
'                command.Parameters.AddWithValue("@T2Judge", None_val) ' Test2_Judgement
'                command.Parameters.AddWithValue("T3Date", None_val) ' Test3_Date
'                command.Parameters.AddWithValue("@T3Trial1", Zero_val) ' Test3_Trial
'                command.Parameters.AddWithValue("@T3ResTrial1", Zero_val) ' Test3_Result_Trial1
'                command.Parameters.AddWithValue("@T3ResTrial2", Zero_val) ' Test3_Result_Trial2
'                command.Parameters.AddWithValue("@T3ResTrial3", Zero_val) ' Test3_Result_Trial3
'                command.Parameters.AddWithValue("@T3Judge", None_val) ' Test3_Judgement
'                command.Parameters.AddWithValue("@Exp", None_val) ' AAA_Exp_Date
'                command.Parameters.AddWithValue("@id", idValue) ' WHERE condition

'                ' Execute the query
'                Dim rowsAffected As Integer = command.ExecuteNonQuery()
'                If rowsAffected > 0 Then
'                    MsgBox(Recertify_Name & " is now can retake the exam.", MsgBoxStyle.Information)
'                Else
'                    MsgBox("No record found with the given Employee Number.", MsgBoxStyle.Exclamation)
'                End If
'            End Using

'            Recertify_ID = 0

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    Sub Show_ReCertification()
'        Dim table As New DataTable

'        ' Open connection
'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            ' SQL query to fetch employees needing re-certification
'            Dim query As String = "SELECT ID, Employee_Number, EmployeeName, Department, Line, Station, 
'                                      Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                      Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                      Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                      AAA_Exp_Date 
'                               FROM AAA_Cert_Masterlist_tb 
'                               WHERE AAA_Exp_Date IS NOT NULL 
'                                  AND AAA_Exp_Date BETWEEN Date() AND DateAdd('m', 2, Date()) 
'                               ORDER BY EmployeeName"

'            ' Using block ensures proper disposal of resources
'            Using command As New OleDbCommand(query, Dbconnection)
'                Using rdr As OleDbDataReader = command.ExecuteReader()
'                    table.Load(rdr)
'                End Using
'            End Using

'            ' Assign DataGridView source
'            Transfer_Form.DataGridView1.DataSource = table

'            ' Format headers & styles
'            For Each column As DataGridViewColumn In Transfer_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 10, FontStyle.Bold)
'                column.HeaderCell.Style.ForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
'                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
'            Next

'            ' Customize column headers
'            With Transfer_Form.DataGridView1
'                .Columns("Employee_Number").HeaderText = "Employee Number"
'                .Columns("EmployeeName").HeaderText = "Name"
'                .Columns("Department").HeaderText = "Department"
'                .Columns("Line").HeaderText = "Line"
'                .Columns("Station").HeaderText = "Station"

'                .Columns("Test1_Date").HeaderText = "1st Exam"
'                .Columns("Test1_Result_Trial1").HeaderText = "Trial 1"
'                .Columns("Test1_Result_Trial2").HeaderText = "Trial 2"
'                .Columns("Test1_Result_Trial3").HeaderText = "Trial 3"
'                .Columns("Test1_Judgement").HeaderText = "Judgement"

'                .Columns("Test2_Date").HeaderText = "2nd Exam"
'                .Columns("Test2_Result_Trial1").HeaderText = "Trial 1"
'                .Columns("Test2_Result_Trial2").HeaderText = "Trial 2"
'                .Columns("Test2_Result_Trial3").HeaderText = "Trial 3"
'                .Columns("Test2_Judgement").HeaderText = "Judgement"

'                .Columns("Test3_Date").HeaderText = "3rd Exam"
'                .Columns("Test3_Result_Trial1").HeaderText = "Trial 1"
'                .Columns("Test3_Result_Trial2").HeaderText = "Trial 2"
'                .Columns("Test3_Result_Trial3").HeaderText = "Trial 3"
'                .Columns("Test3_Judgement").HeaderText = "Judgement"

'                .Columns("AAA_Exp_Date").HeaderText = "AAA Exp Date"
'            End With

'            ' Apply header colors
'            Dim headerColors As Color() = {Color.FromArgb(249, 202, 36), Color.FromArgb(255, 190, 118), Color.FromArgb(255, 121, 121)}

'            Dim testColumns As String() = {"Test1_Date", "Test1_Result_Trial1", "Test1_Result_Trial2", "Test1_Result_Trial3", "Test1_Judgement",
'                                           "Test2_Date", "Test2_Result_Trial1", "Test2_Result_Trial2", "Test2_Result_Trial3", "Test2_Judgement",
'                                           "Test3_Date", "Test3_Result_Trial1", "Test3_Result_Trial2", "Test3_Result_Trial3", "Test3_Judgement"}

'            For i As Integer = 0 To testColumns.Length - 1
'                Transfer_Form.DataGridView1.Columns(testColumns(i)).HeaderCell.Style.BackColor = headerColors(i \ 5)
'            Next

'            ' Grid appearance settings
'            With Transfer_Form.DataGridView1
'                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'                .DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'                .DefaultCellStyle.SelectionForeColor = Color.White
'                .EnableHeadersVisualStyles = False
'                .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
'            End With
'        End If

'        ' Close connection
'        ConClose()
'    End Sub

'    Sub Show_ReCertification_ValueStream()
'        Dim table As New DataTable

'        Dim dept As String = Transfer_Form.cboValueStream.Text
'        ' Open connection
'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            ' SQL query to fetch employees needing re-certification
'            Dim query As String = $"SELECT ID, Employee_Number, EmployeeName, Department, Line, Station, 
'                                      Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                      Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                      Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                      AAA_Exp_Date 
'                               FROM AAA_Cert_Masterlist_tb 
'                               WHERE AAA_Exp_Date IS NOT NULL 
'                                  AND AAA_Exp_Date BETWEEN Date() AND DateAdd('m', 2, Date()) AND Department = '{dept}'
'                               ORDER BY EmployeeName"

'            ' Using block ensures proper disposal of resources
'            Using command As New OleDbCommand(query, Dbconnection)
'                Using rdr As OleDbDataReader = command.ExecuteReader()
'                    table.Load(rdr)
'                End Using
'            End Using

'            ' Assign DataGridView source
'            Transfer_Form.DataGridView1.DataSource = table

'            ' Format headers & styles
'            For Each column As DataGridViewColumn In Transfer_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 10, FontStyle.Bold)
'                column.HeaderCell.Style.ForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
'                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
'            Next

'            ' Customize column headers
'            With Transfer_Form.DataGridView1
'                .Columns("Employee_Number").HeaderText = "Employee Number"
'                .Columns("EmployeeName").HeaderText = "Name"
'                .Columns("Department").HeaderText = "Department"
'                .Columns("Line").HeaderText = "Line"
'                .Columns("Station").HeaderText = "Station"

'                .Columns("Test1_Date").HeaderText = "1st Exam"
'                .Columns("Test1_Result_Trial1").HeaderText = "Trial 1"
'                .Columns("Test1_Result_Trial2").HeaderText = "Trial 2"
'                .Columns("Test1_Result_Trial3").HeaderText = "Trial 3"
'                .Columns("Test1_Judgement").HeaderText = "Judgement"

'                .Columns("Test2_Date").HeaderText = "2nd Exam"
'                .Columns("Test2_Result_Trial1").HeaderText = "Trial 1"
'                .Columns("Test2_Result_Trial2").HeaderText = "Trial 2"
'                .Columns("Test2_Result_Trial3").HeaderText = "Trial 3"
'                .Columns("Test2_Judgement").HeaderText = "Judgement"

'                .Columns("Test3_Date").HeaderText = "3rd Exam"
'                .Columns("Test3_Result_Trial1").HeaderText = "Trial 1"
'                .Columns("Test3_Result_Trial2").HeaderText = "Trial 2"
'                .Columns("Test3_Result_Trial3").HeaderText = "Trial 3"
'                .Columns("Test3_Judgement").HeaderText = "Judgement"

'                .Columns("AAA_Exp_Date").HeaderText = "AAA Exp Date"
'            End With

'            ' Apply header colors
'            Dim headerColors As Color() = {Color.FromArgb(249, 202, 36), Color.FromArgb(255, 190, 118), Color.FromArgb(255, 121, 121)}

'            Dim testColumns As String() = {"Test1_Date", "Test1_Result_Trial1", "Test1_Result_Trial2", "Test1_Result_Trial3", "Test1_Judgement",
'                                           "Test2_Date", "Test2_Result_Trial1", "Test2_Result_Trial2", "Test2_Result_Trial3", "Test2_Judgement",
'                                           "Test3_Date", "Test3_Result_Trial1", "Test3_Result_Trial2", "Test3_Result_Trial3", "Test3_Judgement"}

'            For i As Integer = 0 To testColumns.Length - 1
'                Transfer_Form.DataGridView1.Columns(testColumns(i)).HeaderCell.Style.BackColor = headerColors(i \ 5)
'            Next

'            ' Grid appearance settings
'            With Transfer_Form.DataGridView1
'                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'                .DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'                .DefaultCellStyle.SelectionForeColor = Color.White
'                .EnableHeadersVisualStyles = False
'                .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen
'            End With
'        End If

'        ' Close connection
'        ConClose()
'    End Sub

'    Sub Count_Transfer_Employee()
'        Dim query As String = "SELECT COUNT(*)  FROM AAA_Cert_Masterlist_tb 
'                               WHERE AAA_Exp_Date IS NOT NULL 
'                                  AND AAA_Exp_Date BETWEEN Date() AND DateAdd('m', 2, Date())"

'        ConOpen()

'        Using command As New OleDbCommand(query, Dbconnection)
'            Dim rowCount As Integer = CInt(command.ExecuteScalar())
'            'Console.WriteLine(rowCount)
'            Transfer_Form.lblCount.Text = rowCount
'        End Using
'        ConClose()
'    End Sub
'    Sub Count_Transfer_Employee_Dept()
'        Dim dept As String = Transfer_Form.cboValueStream.Text
'        Dim query As String = $"SELECT COUNT(*)  FROM AAA_Cert_Masterlist_tb 
'                               WHERE AAA_Exp_Date IS NOT NULL 
'                                  AND AAA_Exp_Date BETWEEN Date() AND DateAdd('m', 2, Date()) AND Department = '{dept}'"

'        ConOpen()

'        Using command As New OleDbCommand(query, Dbconnection)
'            Dim rowCount As Integer = CInt(command.ExecuteScalar())
'            'Console.WriteLine(rowCount)
'            Transfer_Form.lblCount.Text = rowCount
'        End Using
'        ConClose()
'    End Sub

'    '=======================< FOR View_Form >=====================

'    Public View_Passed As Boolean = False
'    Public View_Failed As Boolean = False
'    Public View_All As Boolean = False
'    Sub Show_All_EmpData()
'        Dim command As New OleDbCommand("", Dbconnection)
'        Dim table As New DataTable

'        'Dbconnection.Open()
'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            command.Connection = Dbconnection
'            command.CommandText = "Select Employee_Number, EmployeeName, Department, Line, Station, Test_Status, 
'                                 Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                 Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                 Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                 AAA_Exp_Date 
'                                 From AAA_Cert_Masterlist_tb ORDER BY EmployeeName"

'            Dim rdr As OleDbDataReader = command.ExecuteReader

'            table.Load(rdr)

'            View_Form.DataGridView1.DataSource = table

'            ' Bold the header cells
'            For Each column As DataGridViewColumn In View_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 10, FontStyle.Bold)
'                column.HeaderCell.Style.ForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
'            Next

'            View_Form.DataGridView1.Columns("Employee_Number").HeaderText = "Employee Number"
'            'View_Form.DataGridView1.Columns("Employee_Number").Width = 150 ' Set width in pixels
'            View_Form.DataGridView1.Columns("Employee_Number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


'            View_Form.DataGridView1.Columns("EmployeeName").HeaderText = "Name"
'            View_Form.DataGridView1.Columns("EmployeeName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
'            View_Form.DataGridView1.Columns("Department").HeaderText = "Department"
'            View_Form.DataGridView1.Columns("Line").HeaderText = "Line"
'            View_Form.DataGridView1.Columns("Station").HeaderText = "Station"

'            View_Form.DataGridView1.Columns("Test_Status").HeaderText = "Status"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderText = "1st Exam"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderText = "2nd Exam"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderText = "3rd Exam"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("AAA_Exp_Date").HeaderText = "AAA Exp Date"

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)

'            View_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'            View_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'            View_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

'            View_Form.DataGridView1.EnableHeadersVisualStyles = False
'            View_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

'        End If
'        'Dbconnection.Close()
'        ConClose()
'    End Sub

'    Sub Show_All_EmpData_Passed()
'        Dim command As New OleDbCommand("", Dbconnection)
'        Dim table As New DataTable

'        'Dbconnection.Open()
'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            command.Connection = Dbconnection
'            command.CommandText = "Select Employee_Number, EmployeeName, Department, Line, Station, Test_Status, 
'                                 Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                 Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                 Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                 AAA_Exp_Date 
'                                 From AAA_Cert_Masterlist_tb WHERE Test_Status = 'PASSED' ORDER BY EmployeeName"

'            Dim rdr As OleDbDataReader = command.ExecuteReader

'            table.Load(rdr)

'            View_Form.DataGridView1.DataSource = table

'            ' Bold the header cells
'            For Each column As DataGridViewColumn In View_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 10, FontStyle.Bold)
'                column.HeaderCell.Style.ForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
'            Next

'            View_Form.DataGridView1.Columns("Employee_Number").HeaderText = "Employee Number"
'            'View_Form.DataGridView1.Columns("Employee_Number").Width = 150 ' Set width in pixels
'            View_Form.DataGridView1.Columns("Employee_Number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


'            View_Form.DataGridView1.Columns("EmployeeName").HeaderText = "Name"
'            View_Form.DataGridView1.Columns("EmployeeName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
'            View_Form.DataGridView1.Columns("Department").HeaderText = "Department"
'            View_Form.DataGridView1.Columns("Line").HeaderText = "Line"
'            View_Form.DataGridView1.Columns("Station").HeaderText = "Station"

'            View_Form.DataGridView1.Columns("Test_Status").HeaderText = "Status"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderText = "1st Exam"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderText = "2nd Exam"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderText = "3rd Exam"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("AAA_Exp_Date").HeaderText = "AAA Exp Date"

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)

'            View_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'            View_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'            View_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

'            View_Form.DataGridView1.EnableHeadersVisualStyles = False
'            View_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

'        End If
'        'Dbconnection.Close()
'        ConClose()
'    End Sub

'    Sub Show_All_EmpData_Failed()
'        Dim command As New OleDbCommand("", Dbconnection)
'        Dim table As New DataTable

'        'Dbconnection.Open()
'        ConOpen()

'        If Dbconnection.State = ConnectionState.Open Then
'            command.Connection = Dbconnection
'            command.CommandText = "Select ID,Employee_Number, EmployeeName, Department, Line, Station, Test_Status, 
'                                 Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                 Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                 Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                 AAA_Exp_Date 
'                                 From AAA_Cert_Masterlist_tb WHERE Test_Status = 'FAILED' ORDER BY EmployeeName"

'            Dim rdr As OleDbDataReader = command.ExecuteReader

'            table.Load(rdr)

'            View_Form.DataGridView1.DataSource = table

'            ' Bold the header cells
'            For Each column As DataGridViewColumn In View_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 10, FontStyle.Bold)
'                column.HeaderCell.Style.ForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
'            Next

'            View_Form.DataGridView1.Columns("Employee_Number").HeaderText = "Employee Number"
'            'View_Form.DataGridView1.Columns("Employee_Number").Width = 150 ' Set width in pixels
'            View_Form.DataGridView1.Columns("Employee_Number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


'            View_Form.DataGridView1.Columns("EmployeeName").HeaderText = "Name"
'            View_Form.DataGridView1.Columns("EmployeeName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
'            View_Form.DataGridView1.Columns("Department").HeaderText = "Department"
'            View_Form.DataGridView1.Columns("Line").HeaderText = "Line"
'            View_Form.DataGridView1.Columns("Station").HeaderText = "Station"

'            View_Form.DataGridView1.Columns("Test_Status").HeaderText = "Status"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderText = "1st Exam"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderText = "2nd Exam"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderText = "3rd Exam"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("AAA_Exp_Date").HeaderText = "AAA Exp Date"

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)

'            View_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'            View_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'            View_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

'            View_Form.DataGridView1.EnableHeadersVisualStyles = False
'            View_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

'        End If
'        'Dbconnection.Close()
'        ConClose()
'    End Sub

'    Sub Show_EmpData_Via_ValueStream()
'        Dim command As New OleDbCommand("", Dbconnection)
'        Dim table As New DataTable

'        'Dbconnection.Open()
'        ConOpen()

'        Dim VS As String = View_Form.cboVaLStream.Text

'        If Dbconnection.State = ConnectionState.Open Then
'            command.Connection = Dbconnection

'            If View_All = True Then
'                command.CommandText = $"Select Employee_Number, EmployeeName, Department, Line, Station, Test_Status, 
'                                 Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                 Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                 Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                 AAA_Exp_Date 
'                                 From AAA_Cert_Masterlist_tb WHERE Department = '{VS}' ORDER BY EmployeeName"

'            ElseIf View_Passed = True Then

'                command.CommandText = $"Select Employee_Number, EmployeeName, Department, Line, Station, Test_Status, 
'                                 Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                 Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                 Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                 AAA_Exp_Date 
'                                 From AAA_Cert_Masterlist_tb WHERE Department = '{VS}' AND Test_Status = 'PASSED' ORDER BY EmployeeName"

'            ElseIf View_Failed = True Then

'                command.CommandText = $"Select ID, Employee_Number, EmployeeName, Department, Line, Station, Test_Status, 
'                                 Test1_Date, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, 
'                                 Test2_Date, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, 
'                                 Test3_Date, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement,
'                                 AAA_Exp_Date 
'                                 From AAA_Cert_Masterlist_tb WHERE Department = '{VS}' AND Test_Status = 'FAILED' ORDER BY EmployeeName"
'            End If

'            Dim rdr As OleDbDataReader = command.ExecuteReader

'            table.Load(rdr)

'            View_Form.DataGridView1.DataSource = table

'            ' Bold the header cells
'            For Each column As DataGridViewColumn In View_Form.DataGridView1.Columns
'                column.HeaderCell.Style.Font = New Font("MS Reference Sans Serif", 10, FontStyle.Bold)
'                column.HeaderCell.Style.ForeColor = Color.White
'                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
'                column.DefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8)
'            Next

'            View_Form.DataGridView1.Columns("Employee_Number").HeaderText = "Employee Number"
'            'View_Form.DataGridView1.Columns("Employee_Number").Width = 150 ' Set width in pixels
'            View_Form.DataGridView1.Columns("Employee_Number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


'            View_Form.DataGridView1.Columns("EmployeeName").HeaderText = "Name"
'            View_Form.DataGridView1.Columns("EmployeeName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
'            View_Form.DataGridView1.Columns("Department").HeaderText = "Department"
'            View_Form.DataGridView1.Columns("Line").HeaderText = "Line"
'            View_Form.DataGridView1.Columns("Station").HeaderText = "Station"

'            View_Form.DataGridView1.Columns("Test_Status").HeaderText = "Status"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderText = "1st Exam"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test1_Date").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)
'            View_Form.DataGridView1.Columns("Test1_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(249, 202, 36)

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderText = "2nd Exam"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("Test2_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)
'            View_Form.DataGridView1.Columns("Test2_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 190, 118)

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderText = "3rd Exam"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderText = "Trial 1"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderText = "Trial 2"
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderText = "Trial 3"
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderText = "Judgement"

'            View_Form.DataGridView1.Columns("AAA_Exp_Date").HeaderText = "AAA Exp Date"

'            View_Form.DataGridView1.Columns("Test3_Date").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial1").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial2").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Result_Trial3").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)
'            View_Form.DataGridView1.Columns("Test3_Judgement").HeaderCell.Style.BackColor = Color.FromArgb(255, 121, 121)

'            View_Form.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(223, 228, 234)
'            View_Form.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
'            View_Form.DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

'            View_Form.DataGridView1.EnableHeadersVisualStyles = False
'            View_Form.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen

'        End If
'        'Dbconnection.Close()
'        ConClose()
'    End Sub

'    Public count_query As String
'    Sub Count_Employee()

'        If View_All = True Then
'            count_query = "SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb"

'        ElseIf View_Passed = True Then
'            count_query = "SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb WHERE Test_Status = 'PASSED'"

'        ElseIf View_Failed = True Then
'            count_query = "SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb WHERE Test_Status = 'FAILED'"

'        End If

'        ConOpen()

'        Using command As New OleDbCommand(count_query, Dbconnection)
'            Dim rowCount As Integer = CInt(command.ExecuteScalar())
'            'Console.WriteLine(rowCount)
'            View_Form.lblCount.Text = rowCount
'        End Using
'        ConClose()
'    End Sub

'    Sub Count_Employee_Dept()

'        Dim dept As String = View_Form.cboVaLStream.Text

'        Dim query As String = $"SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb WHERE Department LIKE '{dept}'"

'        If View_All = True Then
'            query = $"SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb WHERE Department LIKE '{dept}'"

'        ElseIf View_Passed = True Then
'            query = $"SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb WHERE Department LIKE '{dept}' AND Test_Status = 'PASSED'"

'        ElseIf View_Failed = True Then
'            query = $"SELECT COUNT(*) FROM AAA_Cert_Masterlist_tb WHERE Department LIKE '{dept}' AND Test_Status = 'FAILED'"

'        End If

'        ConOpen()

'        Using command As New OleDbCommand(query, Dbconnection)

'            Dim rowCount As Integer = 0
'            Dim result As Object = command.ExecuteScalar()
'            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
'                rowCount = CInt(result)
'            End If

'            View_Form.lblCount.Text = rowCount
'        End Using

'        ConClose()
'    End Sub

'    '=======================< FOR RetakeWstn_Form >=====================

'    Public Retaker_ID As String
'    Public Retaker_Name As String
'    Public Retaker_Dept As String
'    Public Retaker_Line As String
'    Public Retaker_Station As String
'    Public Retaker_Attempt As Integer
'    Public Retaker_Status As String
'    Sub Get_Retakers_Data()
'        Try
'            ' Ensure at least one cell is selected
'            If View_Form.DataGridView1.SelectedCells.Count > 0 Then
'                Dim selectedRowIndex As Integer = View_Form.DataGridView1.SelectedCells(0).RowIndex

'                ' Ensure row index is valid
'                If selectedRowIndex >= 0 Then
'                    ' Assuming "Title" is in column index 1 (adjust if needed)
'                    Dim titleColumnIndex As Integer = 0
'                    Dim selectedRow As DataGridViewRow = View_Form.DataGridView1.Rows(selectedRowIndex)

'                    ' Retrieve the project title from the specified column
'                    Dim User_Val As String = selectedRow.Cells(titleColumnIndex).Value?.ToString()

'                    ' Ensure value is not empty
'                    If Not String.IsNullOrEmpty(User_Val) Then
'                        Dim query As String = "SELECT * FROM AAA_Cert_Masterlist_tb WHERE ID = @ID"

'                        ' Open database connection
'                        ConOpen()

'                        ' Use "Using" to properly dispose of objects
'                        Using command As New OleDbCommand(query, Dbconnection)
'                            command.Parameters.AddWithValue("@ID", User_Val)

'                            Using adapter As New OleDbDataAdapter(command)
'                                Using data As New DataTable()
'                                    adapter.Fill(data)

'                                    ' If data is found, populate the filename text field
'                                    If data.Rows.Count > 0 Then
'                                        Retaker_ID = data.Rows(0).Item("ID")
'                                        Retaker_Name = data.Rows(0).Item("EmployeeName")
'                                        Retaker_Dept = data.Rows(0).Item("Department")
'                                        Retaker_Line = data.Rows(0).Item("Line")
'                                        Retaker_Station = data.Rows(0).Item("Station")
'                                        Retaker_Attempt = data.Rows(0).Item("Test_Attempt")
'                                        Retaker_Status = data.Rows(0).Item("Test_Status")

'                                        If Retaker_Attempt = 3 And Retaker_Status = "FAILED" Then

'                                            RetakeQstn_Form.lblRetakeMes.Text = "Are you allowing " & Retaker_Name & " from " & Retaker_Dept &
'                                                                                " to retake the certification for " & Retaker_Line &
'                                                                                " line " & Retaker_Station & " station?"
'                                            RetakeQstn_Form.ShowDialog()
'                                        Else
'                                            MsgBox(Retaker_Name & " still has a few more exam attempts." & vbNewLine &
'                                                   "Current exam attempt: " & Retaker_Attempt, MsgBoxStyle.Critical)
'                                            Exit Sub
'                                        End If
'                                    End If
'                                End Using
'                            End Using
'                        End Using
'                    End If
'                End If
'            End If

'        Catch ex As Exception
'            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            ' Close the database connection
'            ConClose()
'        End Try

'    End Sub

'    Public Sub CopyData_to_Retakertb(ByVal idValue As Integer)
'        Try
'            ConOpen()

'            ' Explicitly specify all columns except ID
'            Dim query As String = "INSERT INTO AAA_Cert_Retaker_tb (Employee_Number, EmployeeName, Department, Line, Station, " &
'                              "Test_Attempt, Test_Status, Test1_Date, Test1_Trial, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, " &
'                              "Test2_Date, Test2_Trial, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, " &
'                              "Test3_Date, Test3_Trial, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement, AAA_Exp_Date) " &
'                              "SELECT Employee_Number, EmployeeName, Department, Line, Station, " &
'                              "Test_Attempt, Test_Status, Test1_Date, Test1_Trial, Test1_Result_Trial1, Test1_Result_Trial2, Test1_Result_Trial3, Test1_Judgement, " &
'                              "Test2_Date, Test2_Trial, Test2_Result_Trial1, Test2_Result_Trial2, Test2_Result_Trial3, Test2_Judgement, " &
'                              "Test3_Date, Test3_Trial, Test3_Result_Trial1, Test3_Result_Trial2, Test3_Result_Trial3, Test3_Judgement, AAA_Exp_Date " &
'                              "FROM AAA_Cert_Masterlist_tb WHERE ID = @id"

'            Using cmd As New OleDbCommand(query, Dbconnection)
'                cmd.Parameters.AddWithValue("@id", idValue)
'                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

'                If rowsAffected > 0 Then
'                    Console.WriteLine(rowsAffected.ToString() & " record(s) copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                Else
'                    Console.WriteLine("No records found with the given ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'                End If
'            End Using

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            ConClose()
'        End Try
'    End Sub

'    Public Sub UpdateData_ofRetaker(idValue As Integer)
'        Try
'            ConOpen()

'            Dim Zero_val As Integer = 0
'            Dim None_val As Object = DBNull.Value ' Use DBNull.Value for empty values

'            Dim query As String = "UPDATE AAA_Cert_Masterlist_tb SET " &
'                                  "Test_Attempt = @attempt, Test_Status = @stat, " &
'                                  "Test1_Date = @T1Date, Test1_Trial = @T1Trial1, Test1_Result_Trial1 = @T1ResTrial1, Test1_Result_Trial2 = @T1ResTrial2, Test1_Result_Trial3 = @T1ResTrial3, Test1_Judgement = @T1Judge, " &
'                                  "Test2_Date = @T2Date, Test2_Trial = @T2Trial1, Test2_Result_Trial1 = @T2ResTrial1, Test2_Result_Trial2 = @T2ResTrial2, Test2_Result_Trial3 = @T2ResTrial3, Test2_Judgement = @T2Judg, " &
'                                  "Test3_Date = @T3Date, Test3_Trial = @T3Trial1, Test3_Result_Trial1 = @T3ResTrial1, Test3_Result_Trial2 = @T3ResTrial2, Test3_Result_Trial3 = @T3ResTrial3, Test3_Judgement = @T3Judge " &
'                                  "WHERE ID = @id" ' Assuming Employee_Number is the key

'            Using command As New OleDbCommand(query, Dbconnection)
'                ' Assign parameters (matching the order in the query)
'                command.Parameters.AddWithValue("@attempt", Zero_val) ' Test_Attempt
'                command.Parameters.AddWithValue("@stat", None_val) ' Test_Status
'                command.Parameters.AddWithValue("@T1Date", None_val) ' Test1_Date
'                command.Parameters.AddWithValue("@T1Trial1", Zero_val) ' Test1_Trial
'                command.Parameters.AddWithValue("@T1ResTrial1", Zero_val) ' Test1_Result_Trial1
'                command.Parameters.AddWithValue("@T1ResTrial2", Zero_val) ' Test1_Result_Trial2
'                command.Parameters.AddWithValue("@T1ResTrial3", Zero_val) ' Test1_Result_Trial3
'                command.Parameters.AddWithValue("@T1Judge", None_val) ' Test1_Judgement
'                command.Parameters.AddWithValue("@T2Date", None_val) ' Test2_Date
'                command.Parameters.AddWithValue("@T2Trial1", Zero_val) ' Test2_Trial
'                command.Parameters.AddWithValue("@T2ResTrial1", Zero_val) ' Test2_Result_Trial1
'                command.Parameters.AddWithValue("@T2ResTrial2", Zero_val) ' Test2_Result_Trial2
'                command.Parameters.AddWithValue("@T2ResTrial3", Zero_val) ' Test2_Result_Trial3
'                command.Parameters.AddWithValue("@T2Judge", None_val) ' Test2_Judgement
'                command.Parameters.AddWithValue("@T3Date", None_val) ' Test3_Date
'                command.Parameters.AddWithValue("@T3Trial1", Zero_val) ' Test3_Trial
'                command.Parameters.AddWithValue("@T3ResTrial1", Zero_val) ' Test3_Result_Trial1
'                command.Parameters.AddWithValue("@T3ResTrial2", Zero_val) ' Test3_Result_Trial2
'                command.Parameters.AddWithValue("@T3ResTrial3", Zero_val) ' Test3_Result_Trial3
'                command.Parameters.AddWithValue("@T3Judge", None_val) ' Test3_Judgement
'                command.Parameters.AddWithValue("@id", idValue) ' WHERE condition

'                ' Execute the query
'                Dim rowsAffected As Integer = command.ExecuteNonQuery()
'                If rowsAffected > 0 Then
'                    MsgBox(Retaker_Name & " is now can retake the exam.", MsgBoxStyle.Information)
'                Else
'                    MsgBox("No record found with the given Employee Number.", MsgBoxStyle.Exclamation)
'                End If
'            End Using

'            Retaker_ID = 0

'        Catch ex As Exception
'            MessageBox.Show("Error: " & ex.Message)
'        Finally
'            ConClose()
'        End Try
'    End Sub


'End Module