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
using System.Data.Entity;

namespace ParsTel.kala
{
    public partial class frm_typeGoods : Office2007Form
    {
        frm_goods formg;
        public frm_typeGoods(frm_goods fg)
        {
            formg = fg;
            InitializeComponent();
        }

        private void frm_typeGoods_Load(object sender, EventArgs e)
        {
            using (ParsTelModel ptm=new ParsTelModel())
            {
                using (DbContextTransaction trans=ptm.Database.BeginTransaction())
                {
                    try
                    {
                        var query = ptm.TypeGoods.ToList();
                        dg_display.DataSource = query;

                        var query1 = ptm.InitializeTables.First();
                        txt_id.Text = query1.typeGoodsCode.ToString();

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show(ex.Message);
                    }
            }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using(ParsTelModel ptm=new ParsTelModel())
            {
                using (DbContextTransaction trans=ptm.Database.BeginTransaction())
                {
                    try
                    {
                        TypeGoods tg = new TypeGoods();
                        tg.Id=Convert.ToInt32(txt_id.Text);
                        tg.gtype = txt_typeName.Text;  

                        ptm.TypeGoods.Add(tg);


                        var query = ptm.InitializeTables.First();
                        query.typeGoodsCode++;

                        ptm.SaveChanges();
                        formg.cmb_typeGoods.Text=txt_typeName.Text;
                        trans.Commit();
                    }
                    catch(Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        formg.FillElements();
                        Close();

                    }
                }
            }
        }
    }
}
