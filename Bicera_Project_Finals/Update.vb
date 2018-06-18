Public Class up

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Manager.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_usermanagement where username = '" & uname.Text & "' and password = '" & eop.Text & "' "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader


        If fname.Text = "" Or mname.Text = "" Or lname.Text = "" Or uname.Text = "" Or eop.Text = "" Or enp.Text = "" Or rnp.Text = "" Then
            MsgBox("Please Fill All Fields", MsgBoxStyle.Critical)
        ElseIf data.Read Then

            If enp.Text <> rnp.Text Then
                MsgBox("New Password did not match", MsgBoxStyle.Critical)
            ElseIf uname.Text <> data(2) Then
                MsgBox("Username is Invalid", MsgBoxStyle.Critical)
            ElseIf eop.Text <> data(3) Then
                MsgBox("Invalid Old Password", MsgBoxStyle.Critical)
            Else

                Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fname.Text)
                Dim b As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mname.Text)
                Dim c As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lname.Text)
                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim sql1 As String = "update tbl_usermanagement set password = '" & enp.Text & "',name = '" & (c + ", " + a + " " + b) & "' where username = '" & uname.Text & "'"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("Successfully Updated", MsgBoxStyle.Information)
                conn1.Close()

            End If

            conn.Close()
        End If

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        uname.Clear()
        enp.Clear()
        rnp.Clear()
        eop.Clear()
        fname.Clear()
        mname.Clear()
        lname.Clear()
    End Sub

    Private Sub up_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_usermanagement"
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader
        While adata.Read
            Dim lv2 As New ListViewItem
            lv2 = ListView1.Items.Add(adata(1))
            With lv2
                .SubItems.Add(adata(2))
                .SubItems.Add(adata(3))
            End With
        End While
        aconn.Close()
    End Sub
End Class