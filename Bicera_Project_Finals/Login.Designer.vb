<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Uname = New System.Windows.Forms.TextBox
        Me.LoginB = New System.Windows.Forms.Button
        Me.CancelB = New System.Windows.Forms.Button
        Me.PWord = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(295, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(295, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Uname
        '
        Me.Uname.Location = New System.Drawing.Point(411, 189)
        Me.Uname.Name = "Uname"
        Me.Uname.Size = New System.Drawing.Size(237, 20)
        Me.Uname.TabIndex = 2
        '
        'LoginB
        '
        Me.LoginB.BackColor = System.Drawing.Color.DarkOrange
        Me.LoginB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginB.ForeColor = System.Drawing.Color.White
        Me.LoginB.Location = New System.Drawing.Point(411, 280)
        Me.LoginB.Name = "LoginB"
        Me.LoginB.Size = New System.Drawing.Size(115, 53)
        Me.LoginB.TabIndex = 5
        Me.LoginB.Text = "LOGIN"
        Me.LoginB.UseVisualStyleBackColor = False
        '
        'CancelB
        '
        Me.CancelB.BackColor = System.Drawing.Color.DarkOrange
        Me.CancelB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelB.ForeColor = System.Drawing.Color.White
        Me.CancelB.Location = New System.Drawing.Point(532, 280)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(116, 53)
        Me.CancelB.TabIndex = 6
        Me.CancelB.Text = "CANCEL"
        Me.CancelB.UseVisualStyleBackColor = False
        '
        'PWord
        '
        Me.PWord.Location = New System.Drawing.Point(411, 233)
        Me.PWord.Name = "PWord"
        Me.PWord.Size = New System.Drawing.Size(237, 20)
        Me.PWord.TabIndex = 3
        Me.PWord.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1, 456)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(922, 167)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LOGIN
        '
        Me.AcceptButton = Me.LoginB
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(924, 626)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelB)
        Me.Controls.Add(Me.LoginB)
        Me.Controls.Add(Me.PWord)
        Me.Controls.Add(Me.Uname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Uname As System.Windows.Forms.TextBox
    Friend WithEvents LoginB As System.Windows.Forms.Button
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents PWord As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
