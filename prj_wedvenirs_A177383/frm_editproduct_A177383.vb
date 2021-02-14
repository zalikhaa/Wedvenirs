Public Class frm_editproduct_A177383

    Dim current_id As String
    Private Sub frm_editproduct_A177383_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_popularity.Items.Add("1")
        cmb_popularity.Items.Add("2")
        cmb_popularity.Items.Add("3")
        cmb_popularity.Items.Add("4")
        cmb_popularity.Items.Add("5")
        cmb_popularity.SelectedIndex = 0

        cmb_category.Items.Add("Accessories")
        cmb_category.Items.Add("Beauty")
        cmb_category.Items.Add("Customizable")
        cmb_category.Items.Add("Goodies Bag")
        cmb_category.Items.Add("Plant")
        cmb_category.Items.Add("Practical Gift")
        cmb_category.SelectedIndex = 0


        refresh_grid()
        get_current_id()

    End Sub

    Private Sub refresh_grid()

        grd_edit.DataSource = run_select("select * from TBL_PRODUCTS_A177383 order by FLD_PRODUCT_ID")

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_edit.CurrentRow.Index

        current_id = grd_edit(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_edit(1, current_row).Value
        txt_price.Text = grd_edit(2, current_row).Value
        cmb_category.Text = grd_edit(3, current_row).Value
        txt_material.Text = grd_edit(4, current_row).Value
        cmb_popularity.Text = grd_edit(5, current_row).Value
        txt_quantity.Text = grd_edit(6, current_row).Value


    End Sub

    Private Sub grd_edit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_edit.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_command("update TBL_PRODUCTS_A177383 set FLD_PRODUCT_NAME= ' " & txt_name.Text & "', FLD_PRICE=' " & txt_price.Text & "', FLD_MATERIAL= ' " & txt_material.Text & "', FLD_CATEGORY= ' " & cmb_category.Text & " ', FLD_POPULARITY = " & cmb_popularity.Text & ", FLD_QUANTITY=  " & txt_quantity.Text & " where  FLD_PRODUCT_ID= '" & current_id & "' ")

        refresh_grid()
        get_current_id()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Beep()
        Dim delete_confirmation = MsgBox("Are you sure you're going to delete the product ID" & current_id & "?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("delete from TBL_PRODUCTS_A177383 where FLD_PRODUCT_ID = '" & current_id & " ' ")

            Beep()
            MsgBox("The product" & current_id & " has been successfully deleted!")

            refresh_grid()
            get_current_id()

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_mainmenu_A177383.Show()
        Me.Hide()

    End Sub
End Class