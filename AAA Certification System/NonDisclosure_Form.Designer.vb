<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NonDisclosure_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NonDisclosure_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgree = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(698, 287)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgree
        '
        Me.btnAgree.BackColor = System.Drawing.Color.Transparent
        Me.btnAgree.BorderColor = System.Drawing.Color.Green
        Me.btnAgree.BorderRadius = 10
        Me.btnAgree.BorderThickness = 3
        Me.btnAgree.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAgree.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAgree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAgree.FillColor = System.Drawing.Color.White
        Me.btnAgree.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgree.ForeColor = System.Drawing.Color.Green
        Me.btnAgree.HoverState.FillColor = System.Drawing.Color.Green
        Me.btnAgree.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAgree.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAgree.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnAgree.Location = New System.Drawing.Point(295, 323)
        Me.btnAgree.Name = "btnAgree"
        Me.btnAgree.ShadowDecoration.BorderRadius = 15
        Me.btnAgree.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAgree.ShadowDecoration.Enabled = True
        Me.btnAgree.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnAgree.Size = New System.Drawing.Size(160, 56)
        Me.btnAgree.TabIndex = 6
        Me.btnAgree.Text = "I AGREE"
        '
        'NonDisclosure_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(748, 413)
        Me.Controls.Add(Me.btnAgree)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NonDisclosure_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AAA Examination - Non-Disclosure Agreement"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgree As Guna.UI2.WinForms.Guna2Button
End Class
