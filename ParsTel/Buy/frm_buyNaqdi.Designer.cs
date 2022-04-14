namespace ParsTel.Buy
{
    partial class frm_buyNaqdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_info = new DevComponents.DotNetBar.PanelEx();
            this.txt_dateSaler = new System.Windows.Forms.MaskedTextBox();
            this.cmb_typeBuy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nameSaler = new DevComponents.DotNetBar.LabelX();
            this.btn_addSaler = new DevComponents.DotNetBar.ButtonX();
            this.lbl_idSaler = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnl_Goods = new DevComponents.DotNetBar.PanelEx();
            this.dg_display = new System.Windows.Forms.DataGridView();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_clearGoods = new DevComponents.DotNetBar.ButtonX();
            this.btn_allClear = new DevComponents.DotNetBar.ButtonX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_goodsId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lbl_goodsInfo = new DevComponents.DotNetBar.LabelX();
            this.btn_addGoods = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_numbersGoods = new System.Windows.Forms.MaskedTextBox();
            this.btn_addToDg = new DevComponents.DotNetBar.ButtonX();
            this.lbl_GoodsPrice = new DevComponents.DotNetBar.LabelX();
            this.lbl_totalPrice = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.pnl_info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_Goods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_display)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_info
            // 
            this.pnl_info.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_info.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_info.Controls.Add(this.txt_dateSaler);
            this.pnl_info.Controls.Add(this.cmb_typeBuy);
            this.pnl_info.Controls.Add(this.labelX3);
            this.pnl_info.Controls.Add(this.labelX2);
            this.pnl_info.Controls.Add(this.groupBox1);
            this.pnl_info.Controls.Add(this.labelX1);
            this.pnl_info.Controls.Add(this.txt_id);
            this.pnl_info.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_info.Location = new System.Drawing.Point(3, 18);
            this.pnl_info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(790, 118);
            this.pnl_info.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_info.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_info.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_info.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_info.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_info.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_info.Style.GradientAngle = 90;
            this.pnl_info.TabIndex = 0;
            this.pnl_info.Click += new System.EventHandler(this.pnl_info_Click);
            // 
            // txt_dateSaler
            // 
            this.txt_dateSaler.Location = new System.Drawing.Point(310, 18);
            this.txt_dateSaler.Mask = "0000/00/00";
            this.txt_dateSaler.Name = "txt_dateSaler";
            this.txt_dateSaler.Size = new System.Drawing.Size(162, 27);
            this.txt_dateSaler.TabIndex = 11;
            this.txt_dateSaler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_typeBuy
            // 
            this.cmb_typeBuy.DisplayMember = "Text";
            this.cmb_typeBuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_typeBuy.FormattingEnabled = true;
            this.cmb_typeBuy.ItemHeight = 22;
            this.cmb_typeBuy.Location = new System.Drawing.Point(9, 19);
            this.cmb_typeBuy.Name = "cmb_typeBuy";
            this.cmb_typeBuy.Size = new System.Drawing.Size(220, 28);
            this.cmb_typeBuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_typeBuy.TabIndex = 10;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(235, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(69, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "نحوه خرید";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(436, 18);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "تاریخ خرید";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nameSaler);
            this.groupBox1.Controls.Add(this.btn_addSaler);
            this.groupBox1.Controls.Add(this.lbl_idSaler);
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خریدار ";
            // 
            // lbl_nameSaler
            // 
            // 
            // 
            // 
            this.lbl_nameSaler.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_nameSaler.Location = new System.Drawing.Point(208, 39);
            this.lbl_nameSaler.Name = "lbl_nameSaler";
            this.lbl_nameSaler.Size = new System.Drawing.Size(337, 23);
            this.lbl_nameSaler.TabIndex = 1;
            this.lbl_nameSaler.Text = "****";
            // 
            // btn_addSaler
            // 
            this.btn_addSaler.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addSaler.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addSaler.Location = new System.Drawing.Point(16, 35);
            this.btn_addSaler.Name = "btn_addSaler";
            this.btn_addSaler.Size = new System.Drawing.Size(35, 27);
            this.btn_addSaler.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addSaler.Symbol = "";
            this.btn_addSaler.SymbolColor = System.Drawing.Color.Cyan;
            this.btn_addSaler.TabIndex = 4;
            // 
            // lbl_idSaler
            // 
            // 
            // 
            // 
            this.lbl_idSaler.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_idSaler.Location = new System.Drawing.Point(564, 39);
            this.lbl_idSaler.Name = "lbl_idSaler";
            this.lbl_idSaler.Size = new System.Drawing.Size(200, 23);
            this.lbl_idSaler.TabIndex = 0;
            this.lbl_idSaler.Text = "*****";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(685, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "کد سیستمی خرید";
            // 
            // txt_id
            // 
            // 
            // 
            // 
            this.txt_id.Border.Class = "TextBoxBorder";
            this.txt_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_id.Location = new System.Drawing.Point(539, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.PreventEnterBeep = true;
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(140, 27);
            this.txt_id.TabIndex = 0;
            // 
            // pnl_Goods
            // 
            this.pnl_Goods.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Goods.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Goods.Controls.Add(this.labelX7);
            this.pnl_Goods.Controls.Add(this.lbl_totalPrice);
            this.pnl_Goods.Controls.Add(this.dg_display);
            this.pnl_Goods.Controls.Add(this.groupPanel1);
            this.pnl_Goods.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Goods.Location = new System.Drawing.Point(3, 146);
            this.pnl_Goods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Goods.Name = "pnl_Goods";
            this.pnl_Goods.Size = new System.Drawing.Size(790, 476);
            this.pnl_Goods.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Goods.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Goods.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Goods.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Goods.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Goods.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Goods.Style.GradientAngle = 90;
            this.pnl_Goods.TabIndex = 10;
            // 
            // dg_display
            // 
            this.dg_display.AllowUserToAddRows = false;
            this.dg_display.AllowUserToDeleteRows = false;
            this.dg_display.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.buyCode,
            this.goodsCode,
            this.price,
            this.numbers,
            this.totalPrice});
            this.dg_display.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_display.Location = new System.Drawing.Point(0, 109);
            this.dg_display.Name = "dg_display";
            this.dg_display.ReadOnly = true;
            this.dg_display.RowHeadersVisible = false;
            this.dg_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_display.ShowEditingIcon = false;
            this.dg_display.Size = new System.Drawing.Size(790, 335);
            this.dg_display.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbl_GoodsPrice);
            this.groupPanel1.Controls.Add(this.btn_addToDg);
            this.groupPanel1.Controls.Add(this.txt_numbersGoods);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.btn_addGoods);
            this.groupPanel1.Controls.Add(this.lbl_goodsInfo);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_goodsId);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(784, 100);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "مشخصات کالای جاری";
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(614, 632);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(179, 54);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.Symbol = "";
            this.btn_save.SymbolColor = System.Drawing.Color.ForestGreen;
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "ذخیره کردن";
            // 
            // btn_clearGoods
            // 
            this.btn_clearGoods.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_clearGoods.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_clearGoods.Location = new System.Drawing.Point(189, 632);
            this.btn_clearGoods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clearGoods.Name = "btn_clearGoods";
            this.btn_clearGoods.Size = new System.Drawing.Size(268, 54);
            this.btn_clearGoods.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_clearGoods.Symbol = "";
            this.btn_clearGoods.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clearGoods.TabIndex = 16;
            this.btn_clearGoods.Text = "پاک کردن لیست کالا";
            // 
            // btn_allClear
            // 
            this.btn_allClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_allClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_allClear.Location = new System.Drawing.Point(3, 632);
            this.btn_allClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_allClear.Name = "btn_allClear";
            this.btn_allClear.Size = new System.Drawing.Size(179, 54);
            this.btn_allClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_allClear.Symbol = "";
            this.btn_allClear.SymbolColor = System.Drawing.Color.Red;
            this.btn_allClear.TabIndex = 17;
            this.btn_allClear.Text = "پاک کردن همه";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "کد سیستم";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // buyCode
            // 
            this.buyCode.DataPropertyName = "buyCode";
            this.buyCode.HeaderText = "کد خرید";
            this.buyCode.Name = "buyCode";
            this.buyCode.ReadOnly = true;
            this.buyCode.Visible = false;
            // 
            // goodsCode
            // 
            this.goodsCode.DataPropertyName = "goodsCode";
            this.goodsCode.HeaderText = "کد کالا";
            this.goodsCode.Name = "goodsCode";
            this.goodsCode.ReadOnly = true;
            this.goodsCode.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "قیمت";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // numbers
            // 
            this.numbers.DataPropertyName = "numbers";
            this.numbers.HeaderText = "تعداد";
            this.numbers.Name = "numbers";
            this.numbers.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPrice.DataPropertyName = "totalPrice";
            this.totalPrice.HeaderText = "قیمت کل";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // txt_goodsId
            // 
            // 
            // 
            // 
            this.txt_goodsId.Border.Class = "TextBoxBorder";
            this.txt_goodsId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_goodsId.Location = new System.Drawing.Point(533, 3);
            this.txt_goodsId.Name = "txt_goodsId";
            this.txt_goodsId.PreventEnterBeep = true;
            this.txt_goodsId.Size = new System.Drawing.Size(140, 27);
            this.txt_goodsId.TabIndex = 0;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(679, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(94, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "کد سیستمی کالا";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // lbl_goodsInfo
            // 
            // 
            // 
            // 
            this.lbl_goodsInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_goodsInfo.Location = new System.Drawing.Point(3, 7);
            this.lbl_goodsInfo.Name = "lbl_goodsInfo";
            this.lbl_goodsInfo.Size = new System.Drawing.Size(463, 23);
            this.lbl_goodsInfo.TabIndex = 5;
            this.lbl_goodsInfo.Text = "****";
            // 
            // btn_addGoods
            // 
            this.btn_addGoods.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addGoods.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addGoods.Location = new System.Drawing.Point(489, 3);
            this.btn_addGoods.Name = "btn_addGoods";
            this.btn_addGoods.Size = new System.Drawing.Size(35, 27);
            this.btn_addGoods.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addGoods.Symbol = "";
            this.btn_addGoods.SymbolColor = System.Drawing.Color.Cyan;
            this.btn_addGoods.TabIndex = 6;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(679, 38);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(94, 23);
            this.labelX6.TabIndex = 7;
            this.labelX6.Text = "تعداد تقاضا";
            // 
            // txt_numbersGoods
            // 
            this.txt_numbersGoods.Location = new System.Drawing.Point(533, 38);
            this.txt_numbersGoods.Mask = "000";
            this.txt_numbersGoods.Name = "txt_numbersGoods";
            this.txt_numbersGoods.Size = new System.Drawing.Size(153, 27);
            this.txt_numbersGoods.TabIndex = 8;
            // 
            // btn_addToDg
            // 
            this.btn_addToDg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addToDg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addToDg.Location = new System.Drawing.Point(371, 34);
            this.btn_addToDg.Name = "btn_addToDg";
            this.btn_addToDg.Size = new System.Drawing.Size(153, 35);
            this.btn_addToDg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addToDg.TabIndex = 9;
            this.btn_addToDg.Text = "اضافه کردن به لیست";
            // 
            // lbl_GoodsPrice
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_GoodsPrice.Location = new System.Drawing.Point(21, 38);
            this.lbl_GoodsPrice.Name = "lbl_GoodsPrice";
            this.lbl_GoodsPrice.Size = new System.Drawing.Size(277, 23);
            this.lbl_GoodsPrice.TabIndex = 10;
            this.lbl_GoodsPrice.Text = "****";
            // 
            // lbl_totalPrice
            // 
            // 
            // 
            // 
            this.lbl_totalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_totalPrice.Location = new System.Drawing.Point(0, 450);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(241, 23);
            this.lbl_totalPrice.TabIndex = 11;
            this.lbl_totalPrice.Text = "****";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(247, 450);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(94, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "جمع کل";
            // 
            // frm_buyNaqdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 689);
            this.Controls.Add(this.btn_allClear);
            this.Controls.Add(this.btn_clearGoods);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pnl_Goods);
            this.Controls.Add(this.pnl_info);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_buyNaqdi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خرید نقدی";
            this.Load += new System.EventHandler(this.frm_buyNaqdi_Load);
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnl_Goods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_display)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_info;
        private DevComponents.DotNetBar.PanelEx pnl_Goods;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_clearGoods;
        private DevComponents.DotNetBar.ButtonX btn_allClear;
        private System.Windows.Forms.DataGridView dg_display;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX lbl_nameSaler;
        private DevComponents.DotNetBar.LabelX lbl_idSaler;
        private DevComponents.DotNetBar.ButtonX btn_addSaler;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_id;
        private System.Windows.Forms.MaskedTextBox txt_dateSaler;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_typeBuy;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private DevComponents.DotNetBar.LabelX lbl_goodsInfo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_goodsId;
        private DevComponents.DotNetBar.ButtonX btn_addToDg;
        private System.Windows.Forms.MaskedTextBox txt_numbersGoods;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btn_addGoods;
        private DevComponents.DotNetBar.LabelX lbl_GoodsPrice;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX lbl_totalPrice;
    }
}