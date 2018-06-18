Module Module1
    Public bal As String = ""
    Public an As String = ""
    Public at As String = ""


    Public Sub updates(ByVal sql As String)
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_bsystem")
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

End Module

