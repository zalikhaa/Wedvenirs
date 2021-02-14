Public Class frm_insertstaff_A177383
    Private Sub frm_insertstaff_A177383_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "select FLD_STAFF_ID from TBL_STAFF_A177383 order by FLD_STAFF_ID"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "select * from TBL_STAFF_A177383 order by FLD_STAFF_ID"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_staff.DataSource = mytable

    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_email.Text = ""
        txt_phone.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "insert into TBL_STAFF_A177383 values  (' " & txt_id.Text & "', ' " & txt_name.Text & "', ' " & txt_email.Text & "', " & txt_phone.Text & ")"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered: " & ex.Message)
            mywriter.Connection.Close()

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_mainmenu_A177383.Show()
        Me.Hide()

    End Sub
End Class