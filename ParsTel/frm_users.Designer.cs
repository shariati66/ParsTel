namespace ParsTel
{
    partial class frm_users
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txt_confirmPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_newPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_oldPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_createUser = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_edit = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.dg_operator = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_operator)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(29, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 242);
            this.panel1.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(499, 242);
            this.treeView1.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txt_confirmPassword);
            this.panelEx2.Controls.Add(this.txt_newPassword);
            this.panelEx2.Controls.Add(this.txt_oldPassword);
            this.panelEx2.Controls.Add(this.panel1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(501, 86);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(557, 432);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 14;
            // 
            // txt_confirmPassword
            // 
            // 
            // 
            // 
            this.txt_confirmPassword.Border.Class = "TextBoxBorder";
            this.txt_confirmPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_confirmPassword.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_confirmPassword.Location = new System.Drawing.Point(29, 143);
            this.txt_confirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PreventEnterBeep = true;
            this.txt_confirmPassword.Size = new System.Drawing.Size(499, 37);
            this.txt_confirmPassword.TabIndex = 2;
            this.txt_confirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // txt_newPassword
            // 
            // 
            // 
            // 
            this.txt_newPassword.Border.Class = "TextBoxBorder";
            this.txt_newPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_newPassword.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_newPassword.Location = new System.Drawing.Point(29, 100);
            this.txt_newPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.PreventEnterBeep = true;
            this.txt_newPassword.Size = new System.Drawing.Size(499, 37);
            this.txt_newPassword.TabIndex = 1;
            this.txt_newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_newPassword.UseSystemPasswordChar = true;
            // 
            // txt_oldPassword
            // 
            // 
            // 
            // 
            this.txt_oldPassword.Border.Class = "TextBoxBorder";
            this.txt_oldPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_oldPassword.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_oldPassword.Location = new System.Drawing.Point(29, 41);
            this.txt_oldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_oldPassword.Name = "txt_oldPassword";
            this.txt_oldPassword.PreventEnterBeep = true;
            this.txt_oldPassword.Size = new System.Drawing.Size(499, 37);
            this.txt_oldPassword.TabIndex = 0;
            this.txt_oldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_oldPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_createUser);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Location = new System.Drawing.Point(501, 534);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 62);
            this.panel2.TabIndex = 18;
            // 
            // btn_createUser
            // 
            this.btn_createUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_createUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_createUser.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_createUser.Location = new System.Drawing.Point(335, 15);
            this.btn_createUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(159, 34);
            this.btn_createUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_createUser.Symbol = "";
            this.btn_createUser.SymbolColor = System.Drawing.Color.Blue;
            this.btn_createUser.TabIndex = 22;
            this.btn_createUser.Text = "ایجاد کاربر جدید";
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancel.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Location = new System.Drawing.Point(57, 15);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 34);
            this.btn_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancel.Symbol = "";
            this.btn_cancel.SymbolColor = System.Drawing.Color.Red;
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_edit.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.Location = new System.Drawing.Point(171, 15);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(159, 34);
            this.btn_edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_edit.Symbol = "";
            this.btn_edit.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "ذخیره تغییرات";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Location = new System.Drawing.Point(501, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 62);
            this.panel3.TabIndex = 25;
            // 
            // txt_username
            // 
            // 
            // 
            // 
            this.txt_username.Border.Class = "TextBoxBorder";
            this.txt_username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_username.Font = new System.Drawing.Font("B Titr", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_username.Location = new System.Drawing.Point(29, 14);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.PreventEnterBeep = true;
            this.txt_username.Size = new System.Drawing.Size(499, 37);
            this.txt_username.TabIndex = 1;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(13, 0, 1, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1071, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 16);
            // 
            // dg_operator
            // 
            this.dg_operator.AllowUserToAddRows = false;
            this.dg_operator.AllowUserToDeleteRows = false;
            this.dg_operator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_operator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_operator.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_operator.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dg_operator.Location = new System.Drawing.Point(0, 7);
            this.dg_operator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_operator.Name = "dg_operator";
            this.dg_operator.ReadOnly = true;
            this.dg_operator.RowHeadersWidth = 51;
            this.dg_operator.Size = new System.Drawing.Size(495, 588);
            this.dg_operator.TabIndex = 30;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "نام کاربری";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 180;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "رمز ورود";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 626);
            this.Controls.Add(this.dg_operator);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.frm_users_Load);
            this.panel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_operator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btn_cancel;
        private DevComponents.DotNetBar.ButtonX btn_edit;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_confirmPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_newPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_oldPassword;
        private System.Windows.Forms.Panel panel3;
        protected internal DevComponents.DotNetBar.Controls.TextBoxX txt_username;
        private DevComponents.DotNetBar.ButtonX btn_createUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
        private DevComponents.DotNetBar.Controls.DataGridViewX dg_operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}