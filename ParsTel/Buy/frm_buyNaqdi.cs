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

namespace ParsTel.Buy
{
    public partial class frm_buyNaqdi : Office2007Form
    {
        public frm_buyNaqdi()
        {
            InitializeComponent();
        }

        private void frm_buyNaqdi_Load(object sender, EventArgs e)
        {
            txt_dateSaler.Text = DateClass.SolarDate();
        }

        private void pnl_info_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }
    }
}
