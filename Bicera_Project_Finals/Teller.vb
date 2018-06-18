Public Class Teller

    Private Sub Teller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lwname.Text = LOGIN.wname
        Dtransactby.Text = LOGIN.dtrans
        Wtransactby.Text = LOGIN.wtrans
        Ttransactby.Text = LOGIN.ttrans
        Timer1.Start()
        Dim d As Date = Date.Today
        tdatetoday.Text = d

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ttime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub


    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        LOGIN.Show()

    End Sub

    Private Sub WExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WExit.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        WExit.Visible = False
        Wamount.Clear()
        Wok.Enabled = True
        Wan.Enabled = True

    End Sub

    Private Sub DExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DExit.Click
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        Damount.Clear()
        DExit.Visible = False
        Dok.Enabled = True
        Dan.Enabled = True


    End Sub

    Private Sub TExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TExit.Click
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        Tamount.Clear()
        ran.Clear()
        TExit.Visible = False
        Tan.Enabled = True
        Tok.Enabled = True
    End Sub

    Private Sub VBExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VBExit.Click
        VBExit.Visible = False
        GroupBox10.Visible = False
        VBan.Enabled = True
        VBok.Enabled = True

    End Sub

    Private Sub Wokamount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_clientmanagement "
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader

        If adata.Read Then
            If adata(1) < Val(Wamount.Text) Then
                MsgBox("Insufficient Balance", MsgBoxStyle.Critical)
            ElseIf Wtransactby.Text = "" Or Wclientname.Text = "" Then
                MsgBox("Please fill all Information", MsgBoxStyle.Critical)
            Else

                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim sql1 As String = "update tbl_clientmanagement set amount = '" & (Val(adata(1)) - Val(Wamount.Text)) & "'"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("Transaction Successful", MsgBoxStyle.Information)
                Wamount.Clear()
                Wclientname.Text = ""


                Dim wconn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim wsql1 As String = "INSERT INTO tbl_transaction values('" & Wtransactby.Text & "','" & Wclientname.Text & "','" & Wokamount.Text & "','" & Today & "','" & Wamount.Text & "','" & (Val(adata(1)) - Val(Wamount.Text)) & "')"
                Dim wcmd1 As New MySqlCommand(wsql1, wconn1)
                wconn1.Open()
                wcmd1.ExecuteNonQuery()

            End If
        End If
        aconn.Close()
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
            lblbalw.Text = Val(data(1)).ToString("N0")
            Wok.Enabled = False
            Wan.Enabled = False

            If data1.Read Then
                wlt.Text = data1(1)

            Else
                wlt.Text = tdatetoday.Text + " " + ttime.Text

            End If
        ElseIf Wan.Text = "" Then
            MsgBox("Please Enter your Account #", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_clientmanagement "
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader

        If adata.Read Then
            If Dtransactby.Text = "" Or Damount.Text = "" Then
                MsgBox("Please fill all Information", MsgBoxStyle.Critical)
            ElseIf Val(Damount.Text) < 1500 Then
                MsgBox("Minimum deposit is 1500", MsgBoxStyle.Critical)
            Else

                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim sql1 As String = "update tbl_clientmanagement set amount = '" & (Val(adata(1)) + Val(Damount.Text)) & "' where accountno = '" & Dan.Text & "'"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("Transaction Successful", MsgBoxStyle.Information)

                Dim wconn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim wsql1 As String = "INSERT INTO tbl_transaction values('" & Dtransactby.Text & "','" & Dclientsname.Text & "','" & dokamount.Text & "','" & Today & "','" & Damount.Text & "','" & (Val(adata(1)) + Val(Damount.Text)) & "')"
                Dim wcmd1 As New MySqlCommand(wsql1, wconn1)
                wconn1.Open()
                wcmd1.ExecuteNonQuery()
                wconn1.Close()

                Damount.Clear()
                Dclientsname.Text = ""
                GroupBox3.Visible = False
                GroupBox4.Visible = False
                Dan.Clear()
                DExit.Visible = False


            End If
        End If
        aconn.Close()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dok.Click
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
            Dok.Enabled = False
            Dan.Enabled = False

            If data1.Read Then
                dlt.Text = data1(1)

            Else
                dlt.Text = tdatetoday.Text + " " + ttime.Text

            End If
        ElseIf Dan.Text = "" Then
            MsgBox("Please Enter your Account #", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Logout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Logout.LinkClicked
        Me.Close()
        LOGIN.Show()
    End Sub


    Private Sub Wokamount_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wokamount.Click
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_clientmanagement where accountno = '" & Wan.Text & "'"
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader

        If adata.Read Then
            If adata(1) < Val(Wamount.Text) Then
                MsgBox("Insufficient Balance", MsgBoxStyle.Critical)
            ElseIf Wamount.Text = "" Or Wamount.Text = " " Then
                MsgBox("Please fill all Information", MsgBoxStyle.Critical)
            ElseIf CDate(wlt.Text).AddDays(30) <= CDate(Today + " " + ttime.Text) Then
                MsgBox("Withdraw Disable due to (30 days Expiry)" & vbNewLine & "Please Deposit to Activate Your Account", MsgBoxStyle.Critical)
            Else

                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim sql1 As String = "update tbl_clientmanagement set amount = '" & (Val(adata(1)) - Val(Wamount.Text)) & "' where accountno = '" & Wan.Text & "'"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("Transaction Successful", MsgBoxStyle.Information)


                Dim wconn1 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                Dim wsql1 As String = "INSERT INTO tbl_transaction values('" & Wtransactby.Text & "','" & Wclientname.Text & "','" & Wokamount.Text & "','" & Today + " " + ttime.Text & "','" & Wamount.Text & "','" & (Val(adata(1)) - Val(Wamount.Text)) & "')"
                Dim wcmd1 As New MySqlCommand(wsql1, wconn1)
                wconn1.Open()
                wcmd1.ExecuteNonQuery()


                Wamount.Clear()
                Wclientname.Text = ""
                WExit.Visible = False
                GroupBox1.Visible = False
                GroupBox2.Visible = False
                Wok.Enabled = True
                Wan.Enabled = True

                Dim aconn3 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim asql3 As String = "select * from tbl_lasttrans where id = '" & Wan.Text & "'"
                Dim acmd3 As New MySqlCommand(asql3, aconn3)
                aconn3.Open()
                Dim adata3 As MySqlDataReader = acmd3.ExecuteReader

                If adata3.Read Then
                    Dim connw As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqlw As String = "update tbl_lasttrans set date = '" & Today + " " + ttime.Text & "'"
                    Dim cmdw As New MySqlCommand(sqlw, connw)
                    connw.Open()
                    cmdw.ExecuteNonQuery()
                    connw.Close()
                Else
                    Dim connw As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqlw As String = "INSERT INTO tbl_lasttrans values('" & Wan.Text & "','" & Today + " " + ttime.Text & "')"
                    Dim cmdw As New MySqlCommand(sqlw, connw)
                    connw.Open()
                    cmdw.ExecuteNonQuery()
                    connw.Close()
                End If



            End If
        End If
        aconn.Close()
    End Sub

    Private Sub dokamount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dokamount.Click
        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim asql As String = "select * from tbl_clientmanagement "
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader

        If adata.Read Then

            If Damount.Text = "" Or Damount.Text = " " Then
                MsgBox("Please fill all Information", MsgBoxStyle.Critical)
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
                    Dim wsql1 As String = "INSERT INTO tbl_transaction values('" & Dtransactby.Text & "','" & Dclientsname.Text & "','" & dokamount.Text & "','" & Today + " " + ttime.Text & "','" & Damount.Text & "','" & (Val(adata(1)) + Val(Damount.Text)) & "')"
                    Dim wcmd1 As New MySqlCommand(wsql1, wconn1)
                    wconn1.Open()
                    wcmd1.ExecuteNonQuery()
                    wconn1.Close()

                    Damount.Clear()
                    Dclientsname.Text = ""
                    DExit.Visible = False
                    GroupBox3.Visible = False
                    GroupBox4.Visible = False
                    Dok.Enabled = True
                    Dan.Enabled = True

                End If
                aconn1a.Close()
                Dim aconn3 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                Dim asql3 As String = "select * from tbl_lasttrans where id = '" & Dan.Text & "'"
                Dim acmd3 As New MySqlCommand(asql3, aconn3)
                aconn3.Open()
                Dim adata3 As MySqlDataReader = acmd3.ExecuteReader

                If adata3.Read Then
                    Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqld As String = "update tbl_lasttrans set date = '" & Today + " " + ttime.Text & "'"
                    Dim cmdd As New MySqlCommand(sqld, connd)
                    connd.Open()
                    cmdd.ExecuteNonQuery()
                    connd.Close()
                Else
                    Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sqld As String = "INSERT INTO tbl_lasttrans values('" & Dan.Text & "','" & Today + " " + ttime.Text & "')"
                    Dim cmdd As New MySqlCommand(sqld, connd)
                    connd.Open()
                    cmdd.ExecuteNonQuery()
                    connd.Close()
                End If



                End If
        End If
        aconn.Close()
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
            Tan.Enabled = False
            Tok.Enabled = False

            If data1.Read Then
                tlt.Text = data1(1)

            Else
                tlt.Text = tdatetoday.Text + " " + ttime.Text

            End If
        ElseIf Tan.Text = "" Then
            MsgBox("Please Enter your Account #", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If
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
            If Tamount.Text = "" Or ran.Text = "" Or Tamount.Text = " " Or ran.Text = " " Then
                MsgBox("Please fill all Information!!", MsgBoxStyle.Critical)
            ElseIf Val(Tamount.Text) > adata(1) Then
                MsgBox("Insufficient Balance!!", MsgBoxStyle.Critical)
            ElseIf CDate(tlt.Text).AddDays(30) <= CDate(Today + " " + ttime.Text) Then
                MsgBox("Transfer is Disable due to (30 days Expiry)" & vbNewLine & "Please Deposit to Activate Your Account", MsgBoxStyle.Critical)
            Else
                If adata1.Read = False Then
                    MsgBox("Receivers Account Number is not Valid!!", MsgBoxStyle.Critical)
                Else
                    Dim conn0 As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                    Dim sql0 As String = "INSERT INTO tbl_transfer values('" & Ttransactby.Text & "','" & senName.Text & "','" & ran.Text & "','" & Today + " " + ttime.Text & "','" & Tamount.Text & "')"
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



                    Tamount.Clear()
                    TExit.Visible = False
                    senName.Text = ""
                    ran.Clear()

                    GroupBox5.Visible = False
                    GroupBox6.Visible = False
                    Tok.Enabled = True
                    Tan.Enabled = True


                    Dim aconn3 As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
                    Dim asql3 As String = "select * from tbl_lasttrans where id = '" & Tan.Text & "'"
                    Dim acmd3 As New MySqlCommand(asql3, aconn3)
                    aconn3.Open()
                    Dim adata3 As MySqlDataReader = acmd3.ExecuteReader

                    If adata3.Read Then
                        Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                        Dim sqld As String = "update tbl_lasttrans set date = '" & Today + " " + ttime.Text & "'"
                        Dim cmdd As New MySqlCommand(sqld, connd)
                        connd.Open()
                        cmdd.ExecuteNonQuery()
                        connd.Close()
                    Else
                        Dim connd As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
                        Dim sqld As String = "INSERT INTO tbl_lasttrans values('" & Tan.Text & "','" & Today + " " + ttime.Text & "')"
                        Dim cmdd As New MySqlCommand(sqld, connd)
                        connd.Open()
                        cmdd.ExecuteNonQuery()
                        connd.Close()
                    End If


                End If

            End If

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VBok.Click
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
            lblv.Text = tdatetoday.Text
            VBok.Enabled = False
            VBan.Enabled = False


        ElseIf Tan.Text = "" Then
            MsgBox("Please Enter your Account #", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If
    End Sub


End Class