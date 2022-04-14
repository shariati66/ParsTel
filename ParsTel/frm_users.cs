using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ParsTel
{
    public partial class frm_users : Office2007Form
    {
        frm_main frmm;
        public frm_users(frm_main fmain)
        {
            frmm = fmain;
            InitializeComponent();
        }

        private void frm_users_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            treeView1.CheckBoxes = true;
            treeView1.Nodes.Clear();
            TreeNode print_node = new TreeNode("دسترسی به چاپ");
            TreeNode users_node = new TreeNode("دسترسی به کاربران");
            TreeNode node_aqsat = new TreeNode("خرید اقساط");
            treeView1.Nodes.Add(print_node);
            treeView1.Nodes.Add(users_node);
            treeView1.Nodes.Add(node_aqsat);
            DisplayUsers();
        }

        private void DisplayUsers()
        {
            if (frmm.lbl_username.Text == "admin")
            {
                using (ParsTelModel ptm = new ParsTelModel())
                {
                    var query = ptm.Users.ToList();
                    dg_operator.DataSource = query;
                }
            }
        }

        private void Error_Message(string strMes)
        {
            StopMessage();
            lbl_message.ForeColor = Color.Red;
            lbl_message.Text = strMes;
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Success_Message(string strMes)
        {
            StopMessage();
            lbl_message.ForeColor = Color.Green;
            lbl_message.Text = strMes;
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void btn_createUser_Click(object sender, EventArgs e)
        {
            if (txt_newPassword.Text == txt_confirmPassword.Text)
            {


                try
                {
                    string username = txt_username.Text;
                    string password = txt_newPassword.Text;
                    string new_username=txt_username.Text.Trim();
                    if (new_username.Length > 0)
                    {
                        using (ParsTelModel ptm = new ParsTelModel())
                        {
                            var query = ptm.Users.Where(c => c.username == new_username).ToList() ;
                            
                            if (query.Count > 0)
                                Error_Message("نام کاربری در سیستم موجود می باشد");
                            else
                            {
                                users usr = new users();
                                usr.password = txt_newPassword.Text;
                                usr.username = new_username;
                                
                                ptm.Users.Add(usr);
                                ptm.SaveChanges();

                                Success_Message("کاربر جدید با موفقیت ایجاد شد.");
                            }
                        }
                    }
                    else
                        Error_Message("فیلد نام کاربری نمی تواند خالی باشد");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطا در برنامه");
                }
            }
            else
            {
                Error_Message("رمز جدید و تکرار آن یکی نیستند");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        int time_elapsed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_elapsed++;

            if (time_elapsed % 2 == 0)
                lbl_message.Visible = false;
            else
                lbl_message.Visible = true;
            if(time_elapsed==10)
                StopMessage();
        }
        private void StopMessage()
        {
            lbl_message.Text = "";
            time_elapsed = 0;
            timer1.Stop();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
