Public Class Manager

    Private Sub Manager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lwname.Text = LOGIN.wname
        Dtransactby.Text = LOGIN.dtrans
        Wtransactby.Text = LOGIN.wtrans
        Ttransactby.Text = LOGIN.ttrans
        Timer1.Start()
        Dim d As Date = Date.Today
        mdatetoday.Text = d

        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_clientmanagement "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader
        While data.Read
            Dim lv As New ListViewItem
            lv = ListView1.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
                .SubItems.Add(data(5))
                .SubItems.Add(data(6))
                .SubItems.Add(data(7))
                .SubItems.Add(data(8))
                .SubItems.Add(data(9))
                .SubItems.Add(data(10))
                .SubItems.Add(data(11))
                .SubItems.Add(data(12))
            End With
        End While
        conn.Close()

        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_transaction "
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader
        While adata.Read
            Dim lv2 As New ListViewItem
            lv2 = ListView2.Items.Add(adata(0))
            With lv2
                .SubItems.Add(adata(1))
                .SubItems.Add(adata(2))
                .SubItems.Add(adata(3))
                .SubItems.Add(adata(4))
                .SubItems.Add(adata(5))
            End With
        End While
        aconn.Close()

        Dim bconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim bsql As String = "select * from tbl_usermanagement "
        Dim bcmd As New MySqlCommand(bsql, bconn)
        bconn.Open()
        Dim bdata As MySqlDataReader = bcmd.ExecuteReader
        While bdata.Read
            Dim lv2 As New ListViewItem
            lv2 = ListView3.Items.Add(bdata(0))
            With lv2
                .SubItems.Add(bdata(1))
                .SubItems.Add(bdata(2))
                .SubItems.Add(bdata(3))
                .SubItems.Add(bdata(4))
            End With
        End While
        bconn.Close()


        Dim cconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim csql As String = "select * from tbl_transfer "
        Dim ccmd As New MySqlCommand(csql, cconn)
        cconn.Open()
        Dim cdata As MySqlDataReader = ccmd.ExecuteReader

        While cdata.Read
            Dim lv As New ListViewItem
            lv = ListView4.Items.Add(cdata(0))
            With lv
                .SubItems.Add(cdata(1))
                .SubItems.Add(cdata(2))
                .SubItems.Add(cdata(3))
                .SubItems.Add(cdata(4))
            End With
        End While
        cconn.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mtime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Wok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wok.Click
        Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql As String = "Select * from tbl_clientmanagement where accountno = '" & Wan.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql1 As String = "Select * from tbl_lasttrans where id = '" & Wan.Text & "'"
        Dim cmd1 As New MySqlCommand(sql1, conn1)
        conn1.Open()
        Dim data1 As MySqlDataReader = cmd1.ExecuteReader

        If data.Read Then
            Wclientname.Text = data(2)
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            WExit.Visible = True
            Wok.Enabled = False
            Wan.Enabled = False
            lblbalw.Text = Val(data(1)).ToString("N0")
            If data1.Read Then
                wlt.Text = data1(1)

            Else
                wlt.Text = mdatetoday.Text + " " + mtime.Text

            End If
        ElseIf Wan.Text = "" Then
            MsgBox("Please Enter Clients Account Number", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dok.Click
        Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql As String = "Select * from tbl_clientmanagement where accountno = '" & Dan.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql1 As String = "Select * from tbl_lasttrans where id = '" & Dan.Text & "'"
        Dim cmd1 As New MySqlCommand(sql1, conn1)
        conn1.Open()
        Dim data1 As MySqlDataReader = cmd1.ExecuteReader

        If data.Read Then
            Dclientsname.Text = data(2)
            GroupBox3.Visible = True
            GroupBox4.Visible = True
            DExit.Visible = True
            lblbald.Text = Val(data(1)).ToString("N0")
            Dan.Enabled = False
            Dok.Enabled = False

            If data1.Read Then
                dlt.Text = data1(1)

            Else
                dlt.Text = mdatetoday.Text + " " + mtime.Text


            End If
        ElseIf Dan.Text = "" Then
            MsgBox("Please Enter Clients Account Number", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tok.Click
        Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql As String = "Select * from tbl_clientmanagement where accountno = '" & Tan.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql1 As String = "Select * from tbl_lasttrans where id = '" & Tan.Text & "'"
        Dim cmd1 As New MySqlCommand(sql1, conn1)
        conn1.Open()
        Dim data1 As MySqlDataReader = cmd1.ExecuteReader

        If data.Read Then
            GroupBox5.Visible = True
            GroupBox6.Visible = True
            TExit.Visible = True
            senName.Text = data(2)
            lblbalt.Text = Val(data(1)).ToString("N0")
            Tok.Enabled = False
            Tan.Enabled = False

            If data1.Read Then
                tlt.Text = data1(1)

            Else
                tlt.Text = mdatetoday.Text + " " + mtime.Text

            End If
        ElseIf Tan.Text = "" Then
            MsgBox("Please Enter Clients Account Number", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If


    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Samount.Text = "" Or accno.Text = "" Or fname.Text = "" Or sname.Text = "" Or mname.Text = "" Or add.Text = "" Or age.Text = "" Or pnumber.Text = "" Or dbirth.Text = "" Or pbirth.Text = "" Or nat.Text = "" Or occu.Text = "" Or gender.Text = "" Or cstatus.Text = "" Then
            MsgBox("Please Fill all Fields", MsgBoxStyle.Critical)
        Else
            Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
            Dim sql As String = "Select * from tbl_clientmanagement where accountno = '" & accno.Text & "'"
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                MsgBox("Account Number is Already Use", MsgBoxStyle.Critical)
            Else
                If Samount.Text < 1500 Then
                    MsgBox("Minimum Starting Amount is 1500!", MsgBoxStyle.Critical)
                Else
                    'clear and insert
                    ListView1.Items.Clear()
                    Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fname.Text)
                    Dim b As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mname.Text)
                    Dim c As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sname.Text)

                    Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sql1 As String = "INSERT INTO tbl_clientmanagement values('" & accno.Text & "','" & Samount.Text & "','" & (c + ", " + a + " " + b) & "','" & add.Text & "','" & pnumber.Text & "','" & dbirth.Text & "','" & age.Text & "','" & pbirth.Text & "','" & nat.Text & "','" & occu.Text & "','" & gender.Text & "','" & cstatus.Text & "','" & Today + " " + mtime.Text & "')"
                    Dim cmd1 As New MySqlCommand(sql1, conn1)
                    conn1.Open()
                    cmd1.ExecuteNonQuery()
                    MsgBox("Successfully Saved", MsgBoxStyle.Information)
                    fname.Clear()
                    sname.Clear()
                    mname.Clear()
                    add.Clear()
                    pnumber.Clear()
                    age.Clear()
                    dbirth.ResetText()
                    pbirth.Clear()
                    nat.Clear()
                    occu.Clear()
                    gender.Text = ""
                    cstatus.Text = ""
                    accno.Text = ""
                    Samount.Clear()

                    conn1.Close()

                    'refresh
                    Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                    Dim asql As String = "select * from tbl_clientmanagement "
                    Dim acmd As New MySqlCommand(asql, aconn)
                    aconn.Open()
                    Dim adata As MySqlDataReader = acmd.ExecuteReader
                    While adata.Read
                        Dim lv As New ListViewItem
                        lv = ListView1.Items.Add(adata(0))
                        With lv
                            .SubItems.Add(adata(1))
                            .SubItems.Add(adata(2))
                            .SubItems.Add(adata(3))
                            .SubItems.Add(adata(4))
                            .SubItems.Add(adata(5))
                            .SubItems.Add(adata(6))
                            .SubItems.Add(adata(7))
                            .SubItems.Add(adata(8))
                            .SubItems.Add(adata(9))
                            .SubItems.Add(adata(10))
                            .SubItems.Add(adata(11))
                            .SubItems.Add(adata(12))
                        End With
                    End While
                    aconn.Close()
                End If

            End If
            conn.Close()

        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        age.Clear()
        accno.Clear()
        fname.Clear()
        sname.Clear()
        mname.Clear()
        add.Clear()
        pnumber.Clear()
        dbirth.ResetText()
        pbirth.Clear()
        nat.Clear()
        occu.Clear()
        gender.Text = ""
        cstatus.Text = ""
        Samount.Clear()
    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged
        ListView1.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_clientmanagement where accountno like '" & search.Text & "%' or fullname like '" & search.Text & "%' or phone like '" & search.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        While data.Read
            Dim lv As New ListViewItem
            lv = ListView1.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
                .SubItems.Add(data(5))
                .SubItems.Add(data(6))
                .SubItems.Add(data(7))
                .SubItems.Add(data(8))
                .SubItems.Add(data(9))
                .SubItems.Add(data(10))
                .SubItems.Add(data(11))
                .SubItems.Add(data(12))
            End With
        End While
        conn.Close()
    End Sub

    Private Sub WExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WExit.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        WExit.Visible = False
        Wamount.Clear()
        Wclientname.Text = ""
        Wok.Enabled = True
        Wan.Enabled = True



    End Sub

    Private Sub DExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DExit.Click
        DExit.Visible = False
        Damount.Clear()
        Dclientsname.Text = ""
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        Dan.Enabled = True
        Dok.Enabled = True

    End Sub

    Private Sub TExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TExit.Click
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        TExit.Visible = False

        Tamount.Clear()
        ran.Clear()
        Tok.Enabled = True
        Tan.Enabled = True
    End Sub

    Private Sub VBExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VBExit.Click
        VBExit.Visible = False
        GroupBox10.Visible = False
        VBok.Enabled = True
        VBan.Enabled = True
    End Sub


    Private Sub Wokamount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wokamount.Click
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_clientmanagement where accountno = '" & Wan.Text & "'"
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader

        If adata.Read Then
            If adata(1) < Val(Wamount.Text) Then
                MsgBox("Insufficient Balance", MsgBoxStyle.Critical)
            ElseIf Wamount.Text = "" Or Wamount.Text = " " Then
                MsgBox("Please Enter Amount!!", MsgBoxStyle.Critical)
            ElseIf CDate(wlt.Text).AddDays(30) <= CDate(Today + " " + mtime.Text) Then
                MsgBox("Withdraw Disable due to (30 days Expiry)" & vbNewLine & "Please Deposit to Activate Your Account", MsgBoxStyle.Critical)
            Else

                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim sql1 As String = "update tbl_clientmanagement set amount = '" & (Val(adata(1)) - Val(Wamount.Text)) & "' where accountno = '" & Wan.Text & "'"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("Transaction Successful", MsgBoxStyle.Information)


                Dim wconn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim wsql1 As String = "INSERT INTO tbl_transaction values('" & Wtransactby.Text & "','" & Wclientname.Text & "','" & Wokamount.Text & "','" & Today + " " + mtime.Text & "','" & Wamount.Text & "','" & (Val(adata(1)) - Val(Wamount.Text)) & "')"
                Dim wcmd1 As New MySqlCommand(wsql1, wconn1)
                wconn1.Open()
                wcmd1.ExecuteNonQuery()

                ListView1.Items.Clear()
                Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim asql1 As String = "select * from tbl_clientmanagement "
                Dim acmd1 As New MySqlCommand(asql1, aconn1)
                aconn1.Open()
                Dim adata1 As MySqlDataReader = acmd1.ExecuteReader
                While adata1.Read
                    Dim lv As New ListViewItem
                    lv = ListView1.Items.Add(adata1(0))
                    With lv
                        .SubItems.Add(adata1(1))
                        .SubItems.Add(adata1(2))
                        .SubItems.Add(adata1(3))
                        .SubItems.Add(adata1(4))
                        .SubItems.Add(adata1(5))
                        .SubItems.Add(adata1(6))
                        .SubItems.Add(adata1(7))
                        .SubItems.Add(adata1(8))
                        .SubItems.Add(adata1(9))
                        .SubItems.Add(adata1(10))
                        .SubItems.Add(adata1(11))
                        .SubItems.Add(adata1(12))
                    End With
                End While
                aconn1.Close()

                Wamount.Clear()
                Wclientname.Text = ""
                WExit.Visible = False
                GroupBox1.Visible = False
                GroupBox2.Visible = False
                Wok.Enabled = True
                Wan.Enabled = True




                ListView2.Items.Clear()
                Dim aconn2 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim asql2 As String = "select * from tbl_transaction "
                Dim acmd2 As New MySqlCommand(asql2, aconn2)
                aconn2.Open()
                Dim adata2 As MySqlDataReader = acmd2.ExecuteReader
                While adata2.Read
                    Dim lv As New ListViewItem
                    lv = ListView2.Items.Add(adata2(0))
                    With lv
                        .SubItems.Add(adata2(1))
                        .SubItems.Add(adata2(2))
                        .SubItems.Add(adata2(3))
                        .SubItems.Add(adata2(4))
                        .SubItems.Add(adata2(5))
                    End With
                End While
                aconn2.Close()

                Dim aconn3 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim asql3 As String = "select * from tbl_lasttrans where id = '" & Wan.Text & "'"
                Dim acmd3 As New MySqlCommand(asql3, aconn3)
                aconn3.Open()
                Dim adata3 As MySqlDataReader = acmd3.ExecuteReader

                If adata3.Read Then
                    Dim connw As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqlw As String = "update tbl_lasttrans set date = '" & Today + " " + mtime.Text & "'"
                    Dim cmdw As New MySqlCommand(sqlw, connw)
                    connw.Open()
                    cmdw.ExecuteNonQuery()
                    connw.Close()
                Else
                    Dim connw As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqlw As String = "INSERT INTO tbl_lasttrans values('" & Wan.Text & "','" & Today + " " + mtime.Text & "')"
                    Dim cmdw As New MySqlCommand(sqlw, connw)
                    connw.Open()
                    cmdw.ExecuteNonQuery()
                    connw.Close()
                End If



            End If
        End If
        aconn.Close()
    End Sub


    Private Sub Wcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Wamount.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dokamount.Click
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_clientmanagement "
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader

        If adata.Read Then

            If Damount.Text = "" Or Damount.Text = " " Then
                MsgBox("Please Enter Amount!!", MsgBoxStyle.Critical)
            ElseIf Val(Damount.Text) < 1500 Then
                MsgBox("Minimum deposit is 1500", MsgBoxStyle.Critical)
            Else
                Dim aconn1a As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim asql1a As String = "select * from tbl_clientmanagement where accountno = '" & Dan.Text & "' "
                Dim acmd1a As New MySqlCommand(asql1a, aconn1a)
                aconn1a.Open()
                Dim adata1a As MySqlDataReader = acmd1a.ExecuteReader
                If adata1a.Read Then

                    Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sql1 As String = "update tbl_clientmanagement set amount = '" & (Val(adata1a(1)) + Val(Damount.Text)) & "' where accountno = '" & Dan.Text & "'"
                    Dim cmd1 As New MySqlCommand(sql1, conn1)
                    conn1.Open()
                    cmd1.ExecuteNonQuery()
                    MsgBox("Transaction Successful", MsgBoxStyle.Information)

                    Dim wconn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim wsql1 As String = "INSERT INTO tbl_transaction values('" & Dtransactby.Text & "','" & Dclientsname.Text & "','" & dokamount.Text & "','" & Today + " " + mtime.Text & "','" & Damount.Text & "','" & (Val(adata(1)) + Val(Damount.Text)) & "')"
                    Dim wcmd1 As New MySqlCommand(wsql1, wconn1)
                    wconn1.Open()
                    wcmd1.ExecuteNonQuery()
                    wconn1.Close()


                    ListView1.Items.Clear()
                    Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                    Dim asql1 As String = "select * from tbl_clientmanagement "
                    Dim acmd1 As New MySqlCommand(asql1, aconn1)
                    aconn1.Open()
                    Dim adata1 As MySqlDataReader = acmd1.ExecuteReader
                    While adata1.Read
                        Dim lv As New ListViewItem
                        lv = ListView1.Items.Add(adata(0))
                        With lv
                            .SubItems.Add(adata1(1))
                            .SubItems.Add(adata1(2))
                            .SubItems.Add(adata1(3))
                            .SubItems.Add(adata1(4))
                            .SubItems.Add(adata1(5))
                            .SubItems.Add(adata1(6))
                            .SubItems.Add(adata1(7))
                            .SubItems.Add(adata1(8))
                            .SubItems.Add(adata1(9))
                            .SubItems.Add(adata1(10))
                            .SubItems.Add(adata1(11))
                            .SubItems.Add(adata1(12))
                        End With
                    End While
                    aconn1.Close()

                    Damount.Clear()
                    Dclientsname.Text = ""
                    DExit.Visible = False
                    GroupBox3.Visible = False
                    GroupBox4.Visible = False
                    Dok.Enabled = True
                    Dan.Enabled = True


                    ListView2.Items.Clear()
                    Dim aconn2 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                    Dim asql2 As String = "select * from tbl_transaction "
                    Dim acmd2 As New MySqlCommand(asql2, aconn2)
                    aconn2.Open()
                    Dim adata2 As MySqlDataReader = acmd2.ExecuteReader
                    While adata2.Read
                        Dim lv As New ListViewItem
                        lv = ListView2.Items.Add(adata2(0))
                        With lv
                            .SubItems.Add(adata2(1))
                            .SubItems.Add(adata2(2))
                            .SubItems.Add(adata2(3))
                            .SubItems.Add(adata2(4))
                            .SubItems.Add(adata2(5))
                        End With
                    End While
                    aconn2.Close()
                End If
                Dim aconn3 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim asql3 As String = "select * from tbl_lasttrans where id = '" & Dan.Text & "'"
                Dim acmd3 As New MySqlCommand(asql3, aconn3)
                aconn3.Open()
                Dim adata3 As MySqlDataReader = acmd3.ExecuteReader

                If adata3.Read Then
                    Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqld As String = "update tbl_lasttrans set date = '" & Today + " " + mtime.Text & "'"
                    Dim cmdd As New MySqlCommand(sqld, connd)
                    connd.Open()
                    cmdd.ExecuteNonQuery()
                    connd.Close()
                Else
                    Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqld As String = "INSERT INTO tbl_lasttrans values('" & Dan.Text & "','" & Today + " " + mtime.Text & "')"
                    Dim cmdd As New MySqlCommand(sqld, connd)
                    connd.Open()
                    cmdd.ExecuteNonQuery()
                    connd.Close()
                End If



            End If
        End If
        aconn.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Close()
        LOGIN.Show()
    End Sub

    Private Sub ListView1_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.ItemActivate
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_clientmanagement where accountno = '" & ListView1.SelectedItems(0).Text & "' "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            caccno.Text = data(0)
            cfname.Text = data(2)
            cadd.Text = data(3)
            cp.Text = data(4)
            cdbirth.Text = data(5)
            cage.Text = data(6)
            cpbirth.Text = data(7)
            cnat.Text = data(8)
            coccu.Text = data(9)
            cgender.Text = data(10)
            Eccstatus.Text = data(11)
            cup.Enabled = False
            cedit.Enabled = True
        End If
        conn.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cedit.Click
        ccancel.Enabled = True
        caccno.Enabled = True
        cadd.Enabled = True
        cp.Enabled = True
        cdbirth.Enabled = True
        cage.Enabled = True
        cpbirth.Enabled = True
        cnat.Enabled = True
        coccu.Enabled = True
        cgender.Enabled = True
        Eccstatus.Enabled = True
        cup.Enabled = True
        cednm.Enabled = True
        cedit.Enabled = False

    End Sub

    Private Sub cup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cup.Click
        If caccno.Text = "" Or cfname.Text = "" Or cadd.Text = "" Or cp.Text = "" Or cdbirth.Text = "" Or cage.Text = "" Or cpbirth.Text = "" Or cnat.Text = "" Or coccu.Text = "" Or cgender.Text = "" Or Eccstatus.Text = "" Then
            MsgBox("Please fill all Fields!", MsgBoxStyle.Critical)

        Else
            an = ListView1.SelectedItems(0).Text
            updates("update tbl_clientmanagement set fullname = '" & cfname.Text & "',address = '" & cadd.Text & "',phone = '" & cp.Text & "',dateofbirth = '" & cdbirth.Text & "',placeofbirth = '" & cpbirth.Text & "',nationality = '" & cnat.Text & "',occupation = '" & coccu.Text & "',gender = '" & cgender.Text & "',civilstatus = '" & Eccstatus.Text & "' where accountno = '" & an & "'")
            MsgBox("Successfully Updated!", MsgBoxStyle.Information)

            ListView1.Items.Clear()
            Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
            Dim asql1 As String = "select * from tbl_clientmanagement "
            Dim acmd1 As New MySqlCommand(asql1, aconn1)
            aconn1.Open()
            Dim adata1 As MySqlDataReader = acmd1.ExecuteReader
            While adata1.Read
                Dim lv As New ListViewItem
                lv = ListView1.Items.Add(adata1(0))
                With lv
                    .SubItems.Add(adata1(1))
                    .SubItems.Add(adata1(2))
                    .SubItems.Add(adata1(3))
                    .SubItems.Add(adata1(4))
                    .SubItems.Add(adata1(5))
                    .SubItems.Add(adata1(6))
                    .SubItems.Add(adata1(7))
                    .SubItems.Add(adata1(8))
                    .SubItems.Add(adata1(9))
                    .SubItems.Add(adata1(10))
                    .SubItems.Add(adata1(11))
                    .SubItems.Add(adata1(12))
                End With
            End While
            aconn1.Close()

            cfname.Clear()
            cfname.Enabled = False
            cednm.Enabled = False
            cadd.Clear()
            cadd.Enabled = False
            cp.Clear()
            cp.Enabled = False
            cage.Clear()
            cage.Enabled = False
            cdbirth.ResetText()
            cdbirth.Enabled = False
            cpbirth.Clear()
            cpbirth.Enabled = False
            cnat.Clear()
            cnat.Enabled = False
            coccu.Clear()
            coccu.Enabled = False
            cgender.Text = ""
            cgender.Enabled = False
            Eccstatus.Text = ""
            Eccstatus.Enabled = False
            caccno.Text = ""
            caccno.Enabled = False
            cup.Enabled = False
            cedit.Enabled = False
            ccancel.Enabled = False

        End If
    End Sub

    Private Sub cednm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cednm.Click
        Edit_Name.Show()
    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

        If auid.Text = "" Or uacctype.Text = "" Or uuname.Text = "" Or upword.Text = "" Or urepw.Text = "" Or ufname.Text = "" Or umname.Text = "" Or ulname.Text = "" Then
            MsgBox("Please Fill All Fields", MsgBoxStyle.Critical)
        ElseIf upword.Text <> urepw.Text Then
            MsgBox("Password did not match!", MsgBoxStyle.Critical)

        Else
            Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
            Dim sql As String = "select * from tbl_usermanagement where username = '" & uuname.Text & "'"
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim data As MySqlDataReader = cmd.ExecuteReader

            Dim uconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
            Dim usql As String = "select * from tbl_usermanagement where id = '" & auid.Text & "'"
            Dim ucmd As New MySqlCommand(usql, uconn)
            uconn.Open()
            Dim udata As MySqlDataReader = ucmd.ExecuteReader


            If data.Read Then
                MsgBox("Username is already use!!", MsgBoxStyle.Critical)
            ElseIf udata.Read Then
                MsgBox("ID number is already use!!", MsgBoxStyle.Critical)
            Else
                Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ufname.Text)
                Dim b As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(umname.Text)
                Dim c As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ulname.Text)
                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim sql1 As String = "INSERT INTO tbl_UserManagement values('" & auid.Text & "','" & uacctype.Text & "','" & (c + ", " + a + " " + b) & "','" & uuname.Text & "','" & upword.Text & "')"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()

                ListView3.Items.Clear()
                Dim bconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim bsql As String = "select * from tbl_usermanagement "
                Dim bcmd As New MySqlCommand(bsql, bconn)
                bconn.Open()
                Dim bdata As MySqlDataReader = bcmd.ExecuteReader
                While bdata.Read
                    Dim lv2 As New ListViewItem
                    lv2 = ListView3.Items.Add(bdata(0))
                    With lv2
                        .SubItems.Add(bdata(1))
                        .SubItems.Add(bdata(2))
                        .SubItems.Add(bdata(3))
                        .SubItems.Add(bdata(4))
                    End With
                End While
                bconn.Close()


                MsgBox("You Are Now Registered", MsgBoxStyle.Information)
                auid.Clear()
                uacctype.Text = ""
                uuname.Clear()
                upword.Clear()
                urepw.Clear()
                ufname.Clear()
                umname.Clear()
                ulname.Clear()
                conn1.Close()

            End If
            conn.Close()
            uconn.Close()

        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        auid.Clear()
        ufname.Clear()
        umname.Clear()
        uacctype.Text = ""
        uuname.Clear()
        upword.Clear()
        urepw.Clear()
        fname.Clear()
        mname.Clear()
        ulname.Clear()
    End Sub

    Private Sub ListView3_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.ItemActivate
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_usermanagement where id = '" & ListView3.SelectedItems(0).Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            vuid.Text = data(0)
            lblacclvl.Text = data(1)
            vufname.Text = data(2)
            vuuname.Text = data(3)
            vuuname.Enabled = False
            vupword.Text = data(4)
            vupword.Enabled = False
            vuup.Enabled = False
            vuedit.Enabled = True


        End If
        conn.Close()
    End Sub

 

    Private Sub vuedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuedit.Click
        vuedname.Enabled = True
        vuuname.Enabled = True
        vupword.Enabled = True
        vuup.Enabled = True
        vucancel.Enabled = True
        vuedit.Enabled = False
    End Sub

    Private Sub vuup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuup.Click
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_usermanagement where id = '" & vuid.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If vuuname.Text = " " Or vupword.Text = " " Or vuuname.Text = "" Or vupword.Text = "" Then
            MsgBox("Please fill all Fields!", MsgBoxStyle.Critical)
        ElseIf data.Read Then
            MsgBox("Username is Already Used!! Try another Username", MsgBoxStyle.Critical)
        Else
            at = ListView3.SelectedItems(0).Text
            updates("update tbl_usermanagement set username = '" & vuuname.Text & "',password = '" & vupword.Text & "' where id = '" & at & "'")
            MsgBox("Successfully Updated!", MsgBoxStyle.Information)

            ListView3.Items.Clear()
            Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
            Dim asql1 As String = "select * from tbl_usermanagement "
            Dim acmd1 As New MySqlCommand(asql1, aconn1)
            aconn1.Open()
            Dim adata1 As MySqlDataReader = acmd1.ExecuteReader
            While adata1.Read
                Dim lv As New ListViewItem
                lv = ListView3.Items.Add(adata1(0))
                With lv
                    .SubItems.Add(adata1(1))
                    .SubItems.Add(adata1(2))
                    .SubItems.Add(adata1(3))
                    .SubItems.Add(adata1(4))
                End With
            End While
            vuid.Text = ""
            aconn1.Close()
            vufname.Text = ""
            vuuname.Clear()
            vuuname.Enabled = False
            lblacclvl.Text = ""
            vupword.Clear()
            vupword.Enabled = False
            vuedname.Enabled = False
            vuup.Enabled = False
            vuedit.Enabled = False
            vucancel.Enabled = False


        End If
    End Sub

    Private Sub vuedname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuedname.Click
        Edit_Name2.Show()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListView2.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_transaction where clientname like '" & searchth.Text & "%' or type like '" & searchth.Text & "%' or date like '" & searchth.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        While data.Read
            Dim lv As New ListViewItem
            lv = ListView2.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
                .SubItems.Add(data(5))
            End With
        End While
        conn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub vucancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vucancel.Click
        vuid.Text = ""
        vufname.Text = ""
        vuuname.Clear()
        lblacclvl.Text = ""
        vupword.Clear()
        vuedname.Enabled = False
        vuup.Enabled = False
        vuedit.Enabled = False
        vucancel.Enabled = False
    End Sub

 
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccancel.Click
        cfname.Clear()
        cfname.Enabled = False
        cednm.Enabled = False
        cadd.Clear()
        cadd.Enabled = False
        cp.Clear()
        cp.Enabled = False
        cage.Clear()
        cage.Enabled = False
        cdbirth.ResetText()
        cdbirth.Enabled = False
        cpbirth.Clear()
        cpbirth.Enabled = False
        cnat.Clear()
        cnat.Enabled = False
        coccu.Clear()
        coccu.Enabled = False
        cgender.Text = ""
        cgender.Enabled = False
        Eccstatus.Text = ""
        Eccstatus.Enabled = False
        caccno.Text = ""
        caccno.Enabled = False
        cup.Enabled = False
        cedit.Enabled = False
        ccancel.Enabled = False

    End Sub

  

    Private Sub searchth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchth.TextChanged
        ListView2.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_transaction where id like '" & searchth.Text & "%' or clientname like '" & searchth.Text & "%' or type like '" & searchth.Text & "%' or date like '" & searchth.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        While data.Read
            Dim lv As New ListViewItem
            lv = ListView2.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
                .SubItems.Add(data(5))
            End With
        End While
        conn.Close()
    End Sub



    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        ListView3.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_usermanagement where id like '" & TextBox7.Text & "%' or name like '" & TextBox7.Text & "%' or username like '" & TextBox7.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        While data.Read
            Dim lv As New ListViewItem
            lv = ListView3.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
            End With
        End While
        conn.Close()
    End Sub


    Private Sub btrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btrans.Click
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_clientmanagement where accountno = '" & Tan.Text & "'"
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader


        Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql1 As String = "select * from tbl_clientmanagement where accountno = '" & ran.Text & "'"
        Dim acmd1 As New MySqlCommand(asql1, aconn1)
        aconn1.Open()
        Dim adata1 As MySqlDataReader = acmd1.ExecuteReader

        If adata.Read Then
            If Tamount.Text = "" Or Tamount.Text = " " Or ran.Text = "" Or ran.Text = " " Then
                MsgBox("Please fill all Information!!", MsgBoxStyle.Critical)
            ElseIf Val(Tamount.Text) > adata(1) Then
                MsgBox("Insufficient Balance!!", MsgBoxStyle.Critical)
            ElseIf CDate(tlt.Text).AddDays(30) <= CDate(Today + " " + mtime.Text) Then
                MsgBox("Transfer is Disable due to (30 days Expiry)" & vbNewLine & "Please Deposit to Activate Your Account", MsgBoxStyle.Critical)
            Else
                If adata1.Read = False Then
                    MsgBox("Receivers Account Number is not Valid!!", MsgBoxStyle.Critical)
                Else
                    Dim conn0 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sql0 As String = "INSERT INTO tbl_transfer values('" & Ttransactby.Text & "','" & senName.Text & "','" & ran.Text & "','" & Today + " " + mtime.Text & "','" & Tamount.Text & "')"
                    Dim cmd0 As New MySqlCommand(sql0, conn0)
                    conn0.Open()
                    cmd0.ExecuteNonQuery()

                    Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sql1 As String = "update tbl_clientmanagement set amount = '" & (Val(adata(1)) - Val(Tamount.Text)) & "' where accountno = '" & Tan.Text & "'"
                    Dim cmd1 As New MySqlCommand(sql1, conn1)
                    conn1.Open()
                    cmd1.ExecuteNonQuery()
                    conn1.Close()


                    Dim conn2 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sql2 As String = "update tbl_clientmanagement set amount = '" & (Val(adata1(1)) + Val(Tamount.Text)) & "' where accountno = '" & ran.Text & "'"
                    Dim cmd2 As New MySqlCommand(sql2, conn2)
                    conn2.Open()
                    cmd2.ExecuteNonQuery()
                    conn2.Close()
                    MsgBox("Successful Transfer!!", MsgBoxStyle.Information)

                    'ref

                    ListView1.Items.Clear()
                    Dim conn3 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                    Dim sql3 As String = "select * from tbl_clientmanagement "
                    Dim cmd3 As New MySqlCommand(sql3, conn3)
                    conn3.Open()
                    Dim data3 As MySqlDataReader = cmd3.ExecuteReader
                    While data3.Read
                        Dim lv As New ListViewItem
                        lv = ListView1.Items.Add(data3(0))
                        With lv
                            .SubItems.Add(data3(1))
                            .SubItems.Add(data3(2))
                            .SubItems.Add(data3(3))
                            .SubItems.Add(data3(4))
                            .SubItems.Add(data3(5))
                            .SubItems.Add(data3(6))
                            .SubItems.Add(data3(7))
                            .SubItems.Add(data3(8))
                            .SubItems.Add(data3(9))
                            .SubItems.Add(data3(10))
                            .SubItems.Add(data3(11))
                            .SubItems.Add(data3(12))
                        End With
                    End While
                    aconn1.Close()

                    Tamount.Clear()
                    TExit.Visible = False
                    senName.Text = ""
                    ran.Clear()

                    GroupBox5.Visible = False
                    GroupBox6.Visible = False
                    Tok.Enabled = True
                    Tan.Enabled = True


                    ListView4.Items.Clear()
                    Dim conn4 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                    Dim sql4 As String = "select * from tbl_transfer "
                    Dim cmd4 As New MySqlCommand(sql4, conn4)
                    conn4.Open()
                    Dim data4 As MySqlDataReader = cmd4.ExecuteReader
                    While data4.Read
                        Dim lv As New ListViewItem
                        lv = ListView4.Items.Add(data4(0))
                        With lv
                            .SubItems.Add(data4(1))
                            .SubItems.Add(data4(2))
                            .SubItems.Add(data4(3))
                            .SubItems.Add(data4(4))
                        End With
                    End While
                    conn4.Close()


                    Dim aconn3 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                    Dim asql3 As String = "select * from tbl_lasttrans where id = '" & Tan.Text & "'"
                    Dim acmd3 As New MySqlCommand(asql3, aconn3)
                    aconn3.Open()
                    Dim adata3 As MySqlDataReader = acmd3.ExecuteReader

                    If adata3.Read Then
                        Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                        Dim sqld As String = "update tbl_lasttrans set date = '" & Today + " " + mtime.Text & "'"
                        Dim cmdd As New MySqlCommand(sqld, connd)
                        connd.Open()
                        cmdd.ExecuteNonQuery()
                        connd.Close()
                    Else
                        Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                        Dim sqld As String = "INSERT INTO tbl_lasttrans values('" & Tan.Text & "','" & Today + " " + mtime.Text & "')"
                        Dim cmdd As New MySqlCommand(sqld, connd)
                        connd.Open()
                        cmdd.ExecuteNonQuery()
                        connd.Close()
                    End If


                End If

            End If

        End If
    End Sub

    Private Sub searchtht_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchtht.TextChanged
        ListView4.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim sql As String = "select * from tbl_transfer where id like '" & searchtht.Text & "%' or sender like '" & searchtht.Text & "%' or receiverAccountNo like '" & searchtht.Text & "%' or date like '" & searchtht.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        While data.Read
            Dim lv As New ListViewItem
            lv = ListView4.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
            End With
        End While
        conn.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VBok.Click
        Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql As String = "Select * from tbl_clientmanagement where accountno = '" & VBan.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            GroupBox10.Visible = True
            lblaccno.Text = data(0)
            lblname.Text = data(2)
            lbladd.Text = data(3)
            VBExit.Visible = True
            lblbalVB.Text = Val(data(1)).ToString("N0")
            lblv.Text = mdatetoday.Text
            VBok.Enabled = False
            VBan.Enabled = False

        ElseIf Tan.Text = "" Then
            MsgBox("Please Enter Clients Account Number", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub dbirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbirth.ValueChanged
        Dim a As Integer
        Dim d As Date = dbirth.Text
        a = Today.Year - d.Year

        If (d > Today.AddYears(-a)) Then
            a -= 1
            age.Clear()
            age.Text = a
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            vupword.UseSystemPasswordChar = False
        Else
            vupword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cdbirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdbirth.ValueChanged
        If cdbirth.Enabled = True Then
            Dim a As Integer
            Dim d As Date = cdbirth.Text
            a = Today.Year - d.Year

            If (d > Today.AddYears(-a)) Then
                a -= 1
                cage.Clear()
                cage.Text = a
            End If
        End If
    End Sub


    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

  
End Class