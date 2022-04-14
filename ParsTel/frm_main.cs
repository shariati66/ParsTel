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
using ParsTel.Customers;
using ParsTel.kala;
using ParsTel.Buy;

namespace ParsTel
{
    public partial class frm_main : Office2007Form
    {
        Form1 f1;
        public frm_main(Form1 frm)
        {
            f1 = frm;
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            frm_users fu=new frm_users(this);
            fu.txt_username.Text = lbl_username.Text;
            fu.ShowDialog();
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str_question = "آیا به طور کامل می خواهید از برنامه خارج شوید؟";
            str_question += "\n\n";
            str_question += "بله:خروج کامل \t خیر: صفحه لاگین";
            
            DialogResult dr = MessageBox.Show(str_question,"خطا",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
                f1.Show();
                
            }
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            frm_customer fc = new frm_customer();
            fc.ShowDialog();
        }

        private void btn_goods_Click(object sender, EventArgs e)
        {
            frm_goods fg= new frm_goods();
            fg.ShowDialog();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            frm_BuySelect fselect = new frm_BuySelect();
            fselect.ShowDialog();
        }
    }
}
