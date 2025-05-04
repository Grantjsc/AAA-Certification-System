Public Class Edit_Form
    Private Sub txtEmpNum_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmpNum.KeyUp
        If e.KeyCode = Keys.Enter Then
            Get_EmployeeData_Edit()
        End If
    End Sub

    Private Sub cboValueStream_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboValueStream.SelectedIndexChanged
        txtValueStream.Text = cboValueStream.Text

        cboLine.Items.Clear()

        Select Case cboValueStream.Text
            Case "TR/TE"
                cboLine.Items.AddRange(New String() {"Standard Fuse", "Fuse Holder", "Assembly", "807/804", "808", "303",
                                                                  "Molding", "QA"})

            Case "SQUARE NANO"
                cboLine.Items.AddRange(New String() {"1206 Fuse", "Standard Nano", "Telecom Fuse", "40 Amps",
                                                                  "250V", "OMNI", "885 Fuse", "Tin Dip Fuse", "462", "415", "QA"})

            Case "PICO/SMF/BARRIER"
                cboLine.Items.AddRange(New String() {"Pico Coated and Uncoated", "242-UR/UAT1,4450/259", "459/460, 308/304", "QA"})

            Case "CERAMIC FUSE"
                cboLine.Items.AddRange(New String() {"Greentape Frontline", "Standard Frontline", "Backend", "QA"})

            Case "THIN FILM"
                cboLine.Items.AddRange(New String() {"Backend", "WIA FR4", "PMC", "QA"})

            Case "REED SWITCH"
                cboLine.Items.AddRange(New String() {"Frontline", "Back End", "QA"})

            Case "PLANT QUALITY"
                cboLine.Items.AddRange(New String() {"RS QA", "SQ NANO QA", "PICO QA", "TFF QA", "CCF QA", "TRTE QA"})

            Case Else
                ' Optionally, you can handle other cases or leave the ComboBox empty
        End Select
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        EmployeeData_Populate_Edit()
    End Sub

    Private Sub DataGridView1_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DataGridView1.CellStateChanged
        EmployeeData_Populate_Edit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        EmployeeData_Upadte_Edit()
    End Sub

    Private Sub txtEmpNum_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNum.TextChanged
        If String.IsNullOrEmpty(txtEmpNum.Text) Then
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()

            txtName.Clear()
            txtValueStream.Clear()
            cboValueStream.Text = Nothing
            cboLine.Text = Nothing
            cboStation.Text = Nothing
        End If
    End Sub
End Class