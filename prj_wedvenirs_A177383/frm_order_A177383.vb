Public Class frm_order_A177383
    Private Sub frm_order_A177383_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_WEDVENIRS_A177383.accdb;Persist Security Info=False;"

        Dim mysql As String = "select * from TBL_ORDER_A177383"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_order.DataSource = mytable


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_mainmenu_A177383.Show()
        Me.Hide()

    End Sub
End Class