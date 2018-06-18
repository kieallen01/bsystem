Public Class Edit_Name2

    Private Sub Eok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eok.Click
        Dim full As String
        If Efname.Text = "" Or Emname.Text = "" Or Elname.Text = "" Then
            MsgBox("Please Fill all Fields", MsgBoxStyle.Critical)
        Else

            full = Elname.Text + ", " + Efname.Text + " " + Emname.Text
            Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(full)
            Manager.vufname.Text = a
            Me.Close()
        End If
    End Sub

    Private Sub Ecancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ecancel.Click
        Me.Close()
    End Sub


End Class