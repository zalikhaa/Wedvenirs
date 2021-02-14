Public Class frm_insertproduct_A177383

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproduct_A177383_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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



    End Sub

    Private Sub refresh_grid()

        grd_edit.DataSource = run_select("select * from TBL_PRODUCTS_A177383 order by FLD_PRODUCT_ID")

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_quantity.Text = ""
        cmb_category.Text = ""
        txt_material.Text = " "
        cmb_popularity.Text = ""

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub


    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "insert into TBL_PRODUCTS_A177383 values  (' " & txt_id.Text & "', ' " & txt_name.Text & "', ' " & txt_price.Text & "', ' " & cmb_category.Text & "',' " & txt_material.Text & "', " & cmb_popularity.Text & ",  " & txt_quantity.Text & "  )"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")


            refresh_grid()


        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data that you entered as shown below" & ex.Message)
            mywriter.Connection.Close()

        End Try


    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        'OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        txt_picture.Text = OpenFileDialog1.FileName
        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_mainmenu_A177383.Show()
        Me.Hide()

    End Sub
End Class