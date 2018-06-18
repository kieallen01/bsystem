Public Class Register


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If acctype.Text = "" Or uname.Text = "" Or pword.Text = "" Or repw.Text = "" Or fname.Text = "" Or mname.Text = "" Or lname.Text = "" Then
            MsgBox("Please Fill All Fields", MsgBoxStyle.Critical)
        ElseIf pword.Text <> repw.Text Then
            MsgBox("Password did not match!", MsgBoxStyle.Critical)

        Else
            Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
            Dim sql As String = "select * from tbl_usermanagement where username = '" & uname.Text & "'"
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                MsgBox("Username is already use!!", MsgBoxStyle.Critical)
            Else
                Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fname.Text)
                Dim b As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mname.Text)
                Dim c As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lname.Text)
                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim sql1 As String = "INSERT INTO tbl_UserManagement values('" & acctype.Text & "','" & (c + ", " + a + " " + b) & "','" & uname.Text & "','" & pword.Text & "')"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("You Are Now Registered", MsgBoxStyle.Information)
                acctype.Text = ""
                uname.Clear()
                pword.Clear()
                repw.Clear()
                fname.Clear()
                mname.Clear()
                lname.Clear()
                conn1.Close()
            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        acctype.Text = ""
        uname.Clear()
        pword.Clear()
        repw.Clear()
        fname.Clear()
        mname.Clear()
        lname.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        acctype.Text = ""
        uname.Text = ""
        pword.Text = ""
        repw.Text = ""
        fname.Text = ""
        Manager.Show()
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub




End Class