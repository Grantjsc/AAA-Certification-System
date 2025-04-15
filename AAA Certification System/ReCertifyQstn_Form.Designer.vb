<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReCertifyQstn_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnYes = New Guna.UI2.WinForms.Guna2Button()
        Me.lblReCertMes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Transparent
        Me.btnNo.BorderColor = System.Drawing.Color.Red
        Me.btnNo.BorderRadius = 10
        Me.btnNo.BorderThickness = 3
        Me.btnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNo.FillColor = System.Drawing.Color.White
        Me.btnNo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.Red
        Me.btnNo.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnNo.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnNo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNo.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnNo.Location = New System.Drawing.Point(316, 236)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.ShadowDecoration.BorderRadius = 15
        Me.btnNo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNo.ShadowDecoration.Enabled = True
        Me.btnNo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnNo.Size = New System.Drawing.Size(112, 39)
        Me.btnNo.TabIndex = 12
        Me.btnNo.Text = "No"
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Transparent
        Me.btnYes.BorderColor = System.Drawing.Color.Green
        Me.btnYes.BorderRadius = 10
        Me.btnYes.BorderThickness = 3
        Me.btnYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnYes.FillColor = System.Drawing.Color.White
        Me.btnYes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.Green
        Me.btnYes.HoverState.FillColor = System.Drawing.Color.Green
        Me.btnYes.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnYes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnYes.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnYes.Location = New System.Drawing.Point(155, 236)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.ShadowDecoration.BorderRadius = 15
        Me.btnYes.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnYes.ShadowDecoration.Enabled = True
        Me.btnYes.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnYes.Size = New System.Drawing.Size(112, 39)
        Me.btnYes.TabIndex = 11
        Me.btnYes.Text = "Yes"
        '
        'lblReCertMes
        '
        Me.lblReCertMes.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblReCertMes.Location = New System.Drawing.Point(24, 35)
        Me.lblReCertMes.Name = "lblReCertMes"
        Me.lblReCertMes.Size = New System.Drawing.Size(538, 175)
        Me.lblReCertMes.TabIndex = 10
        Me.lblReCertMes.Text = "Are you allowing GRANT JONATHAN CATAPANG from PICO/SMF/BARRIER to re-certificatio" &
    "n of 459/460, 308/304 line FI station?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblReCertMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReCertifyQstn_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 311)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblReCertMes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReCertifyQstn_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnYes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblReCertMes As Label
End Class
