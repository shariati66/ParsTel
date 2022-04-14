namespace ParsTel.Buy
{
    partial class frm_BuySelect
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_close = new DevComponents.DotNetBar.ButtonX();
            this.btn_buyAqsati = new DevComponents.DotNetBar.ButtonX();
            this.btn_buyNaqdi = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_close);
            this.panelEx1.Controls.Add(this.btn_buyAqsati);
            this.panelEx1.Controls.Add(this.btn_buyNaqdi);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(479, 176);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_close.Location = new System.Drawing.Point(12, 129);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(455, 35);
            this.btn_close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "بستن این صفحه";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_buyAqsati
            // 
            this.btn_buyAqsati.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_buyAqsati.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_buyAqsati.Location = new System.Drawing.Point(12, 71);
            this.btn_buyAqsati.Name = "btn_buyAqsati";
            this.btn_buyAqsati.Size = new System.Drawing.Size(455, 35);
            this.btn_buyAqsati.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_buyAqsati.TabIndex = 1;
            this.btn_buyAqsati.Text = "خرید اقساطی";
            // 
            // btn_buyNaqdi
            // 
            this.btn_buyNaqdi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_buyNaqdi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_buyNaqdi.Location = new System.Drawing.Point(12, 12);
            this.btn_buyNaqdi.Name = "btn_buyNaqdi";
            this.btn_buyNaqdi.Size = new System.Drawing.Size(455, 35);
            this.btn_buyNaqdi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_buyNaqdi.TabIndex = 0;
            this.btn_buyNaqdi.Text = "خرید به صورت نقدی";
            this.btn_buyNaqdi.Click += new System.EventHandler(this.btn_buyNaqdi_Click);
            // 
            // frm_BuySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 176);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(479, 176);
            this.MinimumSize = new System.Drawing.Size(479, 176);
            this.Name = "frm_BuySelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب نوع خرید";
            this.Load += new System.EventHandler(this.frm_BuySelect_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_close;
        private DevComponents.DotNetBar.ButtonX btn_buyAqsati;
        private DevComponents.DotNetBar.ButtonX btn_buyNaqdi;
    }
}