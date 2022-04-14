namespace ParsTel
{
    partial class frm_main
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
            this.toolstrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_username = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_changePassword = new System.Windows.Forms.ToolStripButton();
            this.btn_customer = new System.Windows.Forms.ToolStripButton();
            this.btn_goods = new System.Windows.Forms.ToolStripButton();
            this.btn_buy = new System.Windows.Forms.ToolStripButton();
            this.toolstrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstrip1
            // 
            this.toolstrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolstrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_changePassword,
            this.toolStripSeparator1,
            this.btn_customer,
            this.toolStripSeparator2,
            this.btn_goods,
            this.toolStripSeparator3,
            this.btn_buy,
            this.toolStripSeparator4,
            this.lbl_username});
            this.toolstrip1.Location = new System.Drawing.Point(469, 0);
            this.toolstrip1.Name = "toolstrip1";
            this.toolstrip1.Size = new System.Drawing.Size(117, 449);
            this.toolstrip1.TabIndex = 0;
            this.toolstrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // lbl_username
            // 
            this.lbl_username.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_username.ForeColor = System.Drawing.Color.Blue;
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(114, 21);
            this.lbl_username.Text = "toolStripLabel1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(114, 6);
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_changePassword.Image = global::ParsTel.Properties.Resources.system_config_root;
            this.btn_changePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_changePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(114, 68);
            this.btn_changePassword.Text = "کاربران";
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_customer.Image = global::ParsTel.Properties.Resources.user_customer;
            this.btn_customer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_customer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(114, 68);
            this.btn_customer.Text = "مشتریان";
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_goods
            // 
            this.btn_goods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_goods.Image = global::ParsTel.Properties.Resources.tag_barcode;
            this.btn_goods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_goods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_goods.Name = "btn_goods";
            this.btn_goods.Size = new System.Drawing.Size(114, 68);
            this.btn_goods.Text = "مشتریان";
            this.btn_goods.Click += new System.EventHandler(this.btn_goods_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_buy.Image = global::ParsTel.Properties.Resources.buy;
            this.btn_buy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_buy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(114, 68);
            this.btn_buy.Text = "مشتریان";
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.toolstrip1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "صفحه اصلی نرم افزار پارس تل";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.toolstrip1.ResumeLayout(false);
            this.toolstrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolstrip1;
        private System.Windows.Forms.ToolStripButton btn_changePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected internal System.Windows.Forms.ToolStripLabel lbl_username;
        private System.Windows.Forms.ToolStripButton btn_customer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_goods;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_buy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}