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
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Form f1 in Application.OpenForms)
            {
                if(f1!=this)
                    f1.Close();
            }
            lbl_message.Text = "";
            using (ParsTelModel ptm=new ParsTelModel())
            {
                var query = ptm.Users.ToList();
                dataGridView1.DataSource = query;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        int time_elapsed = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            //stop message if Error running
            StopMessage();

            if (txt_password.Text.Trim().Length>0 && txt_username.Text.Trim().Length>0)
                Login();
            else
                Error_Message("نام کاربری یا رمز عبور نمی تواند خالی باشد");
        }

        private void Error_Message(string strMes)
        {
            lbl_message.ForeColor = Color.Red;
            lbl_message.Text = strMes;
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Success_Message(string strMes)
        {
            lbl_message.ForeColor = Color.Green;
            lbl_message.Text = strMes;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Login()
        {
            try
            {
                string sys_password = "";
                string sys_username="";
                string password = txt_password.Text;
                string username = txt_username.Text;

                using (ParsTelModel ptm=new ParsTelModel())
                {
                    var query = ptm.Users.Where(c=>c.username==username).First();
                    sys_password = query.password;
                }
                
                if (sys_password == password)
                {
                    frm_main frmm = new frm_main(this);
                    frmm.lbl_username.Text = username;
                    frmm.Show();
                    Hide();
                }
                else
                    Error_Message("نام کاربری یا رمز عبور اشتباه است");
        }
            catch
            {
                Error_Message("دوباره تلاش کنید. ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_elapsed++;

            if (time_elapsed % 2 == 0)
                lbl_message.Visible = false;
            else
                lbl_message.Visible = true;
        }

        private void StopMessage()
        {
            lbl_message.Text = "";
            time_elapsed = 0;
            timer1.Stop();
        }
    }
}
