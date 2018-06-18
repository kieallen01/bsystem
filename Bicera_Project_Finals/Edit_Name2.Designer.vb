<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Name2
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
        Me.Ecancel = New System.Windows.Forms.Button
        Me.Eok = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Elname = New System.Windows.Forms.TextBox
        Me.Emname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Efname = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Ecancel
        '
        Me.Ecancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Ecancel.ForeColor = System.Drawing.Color.Red
        Me.Ecancel.Location = New System.Drawing.Point(307, 72)
        Me.Ecancel.Name = "Ecancel"
        Me.Ecancel.Size = New System.Drawing.Size(97, 23)
        Me.Ecancel.TabIndex = 17
        Me.Ecancel.Text = "CANCEL"
        Me.Ecancel.UseVisualStyleBackColor = False
        '
        'Eok
        '
        Me.Eok.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Eok.ForeColor = System.Drawing.Color.Red
        Me.Eok.Location = New System.Drawing.Point(195, 72)
        Me.Eok.Name = "Eok"
        Me.Eok.Size = New System.Drawing.Size(97, 23)
        Me.Eok.TabIndex = 16
        Me.Eok.Text = "OK"
        Me.Eok.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(444, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(250, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Middle Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Elname
        '
        Me.Elname.Location = New System.Drawing.Point(401, 12)
        Me.Elname.Name = "Elname"
        Me.Elname.Size = New System.Drawing.Size(189, 20)
        Me.Elname.TabIndex = 13
        '
        'Emname
        '
        Me.Emname.Location = New System.Drawing.Point(206, 12)
        Me.Emname.Name = "Emname"
        Me.Emname.Size = New System.Drawing.Size(189, 20)
        Me.Emname.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Efname
        '
        Me.Efname.Location = New System.Drawing.Point(11, 12)
        Me.Efname.Name = "Efname"
        Me.Efname.Size = New System.Drawing.Size(189, 20)
        Me.Efname.TabIndex = 10
        '
        'Edit_Name2
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
        Me.Name = "Edit_Name2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ecancel As System.Windows.Forms.Button
    Friend WithEvents Eok As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Elname As System.Windows.Forms.TextBox
    Friend WithEvents Emname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Efname As System.Windows.Forms.TextBox
End Class
