<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Name
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Efname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Emname = New System.Windows.Forms.TextBox
        Me.Elname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Eok = New System.Windows.Forms.Button
        Me.Ecancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Efname
        '
        Me.Efname.Location = New System.Drawing.Point(12, 12)
        Me.Efname.Name = "Efname"
        Me.Efname.Size = New System.Drawing.Size(189, 20)
        Me.Efname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emname
        '
        Me.Emname.Location = New System.Drawing.Point(207, 12)
        Me.Emname.Name = "Emname"
        Me.Emname.Size = New System.Drawing.Size(189, 20)
        Me.Emname.TabIndex = 4
        '
        'Elname
        '
        Me.Elname.Location = New System.Drawing.Point(402, 12)
        Me.Elname.Name = "Elname"
        Me.Elname.Size = New System.Drawing.Size(189, 20)
        Me.Elname.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(251, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Middle Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(445, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Eok
        '
        Me.Eok.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Eok.ForeColor = System.Drawing.Color.Red
        Me.Eok.Location = New System.Drawing.Point(196, 72)
        Me.Eok.Name = "Eok"
        Me.Eok.Size = New System.Drawing.Size(97, 23)
        Me.Eok.TabIndex = 8
        Me.Eok.Text = "OK"
        Me.Eok.UseVisualStyleBackColor = False
        '
        'Ecancel
        '
        Me.Ecancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Ecancel.ForeColor = System.Drawing.Color.Red
        Me.Ecancel.Location = New System.Drawing.Point(308, 72)
        Me.Ecancel.Name = "Ecancel"
        Me.Ecancel.Size = New System.Drawing.Size(97, 23)
        Me.Ecancel.TabIndex = 9
        Me.Ecancel.Text = "CANCEL"
        Me.Ecancel.UseVisualStyleBackColor = False
        '
        'Edit_Name
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(602, 97)
        Me.Controls.Add(Me.Ecancel)
        Me.Controls.Add(Me.Eok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Elname)
        Me.Controls.Add(Me.Emname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Efname)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Edit_Name"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Efname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Emname As System.Windows.Forms.TextBox
    Friend WithEvents Elname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Eok As System.Windows.Forms.Button
    Friend WithEvents Ecancel As System.Windows.Forms.Button
End Class
