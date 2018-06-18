Public Class LOGIN

    Public wname As String
    Public wtrans As String
    Public dtrans As String
    Public ttrans As String



    Private Sub LoginB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginB.Click
        Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_bsystem")
        Dim sql As String = "Select * from tbl_UserManagement where username = '" & Uname.Text & "' and password = '" & PWord.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            If data(1) = "Teller" Then
                MsgBox("WELCOME" & " " & data(2), MsgBoxStyle.Information)
                Uname.Clear()
                PWord.Clear()
                Me.Hide()
                wname = data(3)
                wtrans = data(2)
                dtrans = data(2)
                ttrans = data(2)
                Teller.Show()
            ElseIf data(1) = "Manager" Then
                MsgBox("WELCOME" & " " & data(2), MsgBoxStyle.Information)
                Uname.Clear()
                PWord.Clear()
                Me.Hide()
                wname = data(3)
                wtrans = data(2)
                dtrans = data(2)
                ttrans = data(2)
                Manager.Show()

            End If
        Else
            MsgBox("Invalid Username/Password", MsgBoxStyle.Critical)
        End If
        conn.Close()
    End Sub

    Private Sub CancelB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelB.Click
        End
    End Sub

End Class
