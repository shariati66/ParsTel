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
using ParsTel.Buy;

namespace ParsTel.Buy
{
    public partial class frm_BuySelect : Office2007Form
    {
        public frm_BuySelect()
        {
            InitializeComponent();
        }

        private void frm_BuySelect_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_buyNaqdi_Click(object sender, EventArgs e)
        {
           
            frm_buyNaqdi fbn = new frm_buyNaqdi();fbn.ShowDialog();
           
        }
    }
}
