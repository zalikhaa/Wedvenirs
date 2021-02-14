Public Class frm_editstaff_A177383

    Dim current_id As String
    Private Sub frm_editstaff_A177383_Lad(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_id()

    End Sub

    Private Sub refresh_grid()

        grd_staff.DataSource = run_select("select * from TBL_STAFF_A177383 order by FLD_STAFF_ID")

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_id = grd_staff(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_email.Text = grd_staff(2, current_row).Value
        txt_phone.Text = grd_staff(3, current_row).Value


    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_command("update TBL_STAFF_A177383 set FLD_STAFF_NAME= ' " & txt_name.Text & "', FLD_STAFF_EMAIL= ' " & txt_email.Text & "', FLD_PHONE= " & txt_phone.Text & "  where  FLD_STAFF_ID= '" & current_id & "' ")

        refresh_grid()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Beep()
        Dim delete_confirmation = MsgBox("Are you sure you're going to delete the staff ID" & current_id & "?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from TBL_STAFF_A177383 where FLD_STAFF_ID = '" & current_id & " ' ")

            Beep()
            MsgBox("The staff " & current_id & " has been successfully deleted!")

            refresh_grid()
            get_current_id()

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_mainmenu_A177383.Show()
        Me.Hide()

    End Sub
End Class

