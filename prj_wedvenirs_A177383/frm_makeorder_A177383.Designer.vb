<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_A177383
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_A177383))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_make = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_popularity = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_cart = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.dud_qty = New System.Windows.Forms.NumericUpDown()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.grd_newmake = New System.Windows.Forms.DataGridView()
        Me.FLD_PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_BOUGHT_QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLD_PRODUCT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_order_id = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        CType(Me.grd_make, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dud_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_newmake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(349, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make Order"
        '
        'grd_make
        '
        Me.grd_make.AllowUserToAddRows = False
        Me.grd_make.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_make.BackgroundColor = System.Drawing.Color.White
        Me.grd_make.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_make.Location = New System.Drawing.Point(226, 72)
        Me.grd_make.Name = "grd_make"
        Me.grd_make.ReadOnly = True
        Me.grd_make.Size = New System.Drawing.Size(591, 137)
        Me.grd_make.TabIndex = 1
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(737, 256)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(80, 29)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "New Order"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(413, 496)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(120, 23)
        Me.btn_confirm.TabIndex = 4
        Me.btn_confirm.Text = "CONFIRM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(223, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "STEP 1: Select information above:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(221, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Customer ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(327, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(221, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(296, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "STEP 2: Confirm your order in the list below and click confirm:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(483, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Current Order ID:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(757, 531)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 27)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_cust
        '
        Me.txt_cust.Location = New System.Drawing.Point(224, 265)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.Size = New System.Drawing.Size(82, 20)
        Me.txt_cust.TabIndex = 26
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(330, 265)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(79, 20)
        Me.txt_name.TabIndex = 27
        '
        'lst_product
        '
        Me.lst_product.BackColor = System.Drawing.Color.White
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(141, 72)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(62, 82)
        Me.lst_product.TabIndex = 29
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(23, 72)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(112, 137)
        Me.pic_product.TabIndex = 30
        Me.pic_product.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(22, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Material: "
        '
        'txt_category
        '
        Me.txt_category.Location = New System.Drawing.Point(106, 320)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.Size = New System.Drawing.Size(79, 20)
        Me.txt_category.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(105, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Category:"
        '
        'txt_popularity
        '
        Me.txt_popularity.Location = New System.Drawing.Point(106, 358)
        Me.txt_popularity.Name = "txt_popularity"
        Me.txt_popularity.Size = New System.Drawing.Size(64, 20)
        Me.txt_popularity.TabIndex = 34
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_total.Location = New System.Drawing.Point(20, 420)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(57, 13)
        Me.lbl_total.TabIndex = 33
        Me.lbl_total.Text = "Total (RM)"
        '
        'txt_productname
        '
        Me.txt_productname.Location = New System.Drawing.Point(23, 280)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(100, 20)
        Me.txt_productname.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(20, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Name: "
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(23, 358)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(64, 20)
        Me.txt_material.TabIndex = 38
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(26, 436)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(23, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Quantity:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(103, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Popularity:"
        '
        'btn_cart
        '
        Me.btn_cart.Location = New System.Drawing.Point(39, 482)
        Me.btn_cart.Name = "btn_cart"
        Me.btn_cart.Size = New System.Drawing.Size(120, 23)
        Me.btn_cart.TabIndex = 43
        Me.btn_cart.Text = "Add To Cart"
        Me.btn_cart.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(559, 496)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(120, 23)
        Me.btn_remove.TabIndex = 44
        Me.btn_remove.Text = "REMOVE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(20, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Product ID:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(23, 241)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(20, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Price:"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(23, 319)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(64, 20)
        Me.txt_price.TabIndex = 50
        '
        'dud_qty
        '
        Me.dud_qty.Location = New System.Drawing.Point(23, 397)
        Me.dud_qty.Name = "dud_qty"
        Me.dud_qty.Size = New System.Drawing.Size(120, 20)
        Me.dud_qty.TabIndex = 52
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(596, 264)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(83, 21)
        Me.cmb_staff.TabIndex = 54
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(242, 374)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(64, 20)
        Me.txt_date.TabIndex = 55
        '
        'grd_newmake
        '
        Me.grd_newmake.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.grd_newmake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_newmake.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FLD_PRODUCT_ID, Me.FLD_BOUGHT_QUANTITY, Me.FLD_PRICE, Me.FLD_PRODUCT_NAME})
        Me.grd_newmake.Location = New System.Drawing.Point(224, 319)
        Me.grd_newmake.Name = "grd_newmake"
        Me.grd_newmake.RowHeadersWidth = 62
        Me.grd_newmake.RowTemplate.Height = 28
        Me.grd_newmake.Size = New System.Drawing.Size(591, 129)
        Me.grd_newmake.TabIndex = 58
        '
        'FLD_PRODUCT_ID
        '
        Me.FLD_PRODUCT_ID.HeaderText = "Product ID"
        Me.FLD_PRODUCT_ID.MinimumWidth = 8
        Me.FLD_PRODUCT_ID.Name = "FLD_PRODUCT_ID"
        Me.FLD_PRODUCT_ID.Width = 150
        '
        'FLD_BOUGHT_QUANTITY
        '
        Me.FLD_BOUGHT_QUANTITY.HeaderText = "Product Name"
        Me.FLD_BOUGHT_QUANTITY.MinimumWidth = 8
        Me.FLD_BOUGHT_QUANTITY.Name = "FLD_BOUGHT_QUANTITY"
        Me.FLD_BOUGHT_QUANTITY.Width = 150
        '
        'FLD_PRICE
        '
        Me.FLD_PRICE.HeaderText = "Quantity"
        Me.FLD_PRICE.MinimumWidth = 8
        Me.FLD_PRICE.Name = "FLD_PRICE"
        Me.FLD_PRICE.Width = 150
        '
        'FLD_PRODUCT_NAME
        '
        Me.FLD_PRODUCT_NAME.HeaderText = "Price"
        Me.FLD_PRODUCT_NAME.MinimumWidth = 8
        Me.FLD_PRODUCT_NAME.Name = "FLD_PRODUCT_NAME"
        Me.FLD_PRODUCT_NAME.Width = 150
        '
        'lbl_order_id
        '
        Me.lbl_order_id.AutoSize = True
        Me.lbl_order_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_id.Location = New System.Drawing.Point(483, 268)
        Me.lbl_order_id.Name = "lbl_order_id"
        Me.lbl_order_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_order_id.TabIndex = 59
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Location = New System.Drawing.Point(593, 248)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(46, 13)
        Me.lbl_staff.TabIndex = 60
        Me.lbl_staff.Text = "Staff ID:"
        '
        'frm_makeorder_A177383
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(860, 570)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_order_id)
        Me.Controls.Add(Me.grd_newmake)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.dud_qty)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_cart)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_category)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_popularity)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_cust)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.grd_make)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_makeorder_A177383"
        Me.Text = "Make Order"
        CType(Me.grd_make, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dud_qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_newmake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grd_make As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lst_product As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_category As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_popularity As TextBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_material As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_cart As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents dud_qty As NumericUpDown
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents txt_date As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents grd_newmake As DataGridView
    Friend WithEvents FLD_PRODUCT_ID As DataGridViewTextBoxColumn
    Friend WithEvents FLD_BOUGHT_QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRICE As DataGridViewTextBoxColumn
    Friend WithEvents FLD_PRODUCT_NAME As DataGridViewTextBoxColumn
    Friend WithEvents lbl_order_id As Label
    Friend WithEvents lbl_staff As Label
End Class
