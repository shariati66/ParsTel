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
using ParsTel.kala;

namespace ParsTel.kala
{
    public partial class frm_goods : Office2007Form
    {
        public frm_goods()
        {
            InitializeComponent();
        }

        private void frm_goods_Load(object sender, EventArgs e)
        {
            FillElements();
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
        public void FillElements()
        {
            using (ParsTelModel ptm = new ParsTelModel())
            {
                cmb_typeGoods.Items.Clear();
                using (DbContextTransaction trans = ptm.Database.BeginTransaction())
                {
                    try
                    {
                        //display goods in datagrid
                        var query = ptm.Commodity.ToList();
                        dataGridView1.DataSource = query;

                        //set txt_id 
                        var query1 = ptm.InitializeTables.First();
                        txt_Id.Text = query1.goodsCode.ToString();

                        //set type goods in combobox
                        var query2 = ptm.TypeGoods.ToList();
                        if (query2 != null)
                        {
                            foreach (var item in query2)
                                cmb_typeGoods.Items.Add(item.gtype);
                        }


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
        private void txt_nameGoods_KeyPress(object sender, KeyPressEventArgs e)
        {

            

            

                

        }

        private void txt_nameGoods_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool flag_save = true;
            flag_save = CheckFields();
            if (flag_save)
            {
                using (ParsTelModel ptm = new ParsTelModel())
                {
                    using (DbContextTransaction trans = ptm.Database.BeginTransaction())
                        try
                        {
                            commodity commo = new commodity();
                            commo.id = Convert.ToInt32(txt_Id.Text);
                            commo.gName = txt_nameGoods.Text;
                            commo.brand = txt_brandGoods.Text;
                            commo.price = Convert.ToInt32(txt_priceGoods.Text.Trim());

                            commo.gNumber = Convert.ToInt32(txt_numberGoods.Text.Trim());
                            commo.model = txt_modelGoods.Text;
                            commo.type = cmb_typeGoods.SelectedIndex;
                            commo.gComments = txt_commentGoods.Text;
                            ptm.Commodity.Add(commo);
                            ptm.SaveChanges();

                            //update goodsKey
                            var query = ptm.InitializeTables.First();
                            query.goodsCode++;

                            ptm.SaveChanges();
                            Success_Message("ذخیره سازی انجام شد");
                            trans.Commit();
                        }
                        catch (Exception ex)
                        {
                            Error_Message("به دلیل بروز خطا عملیات انجام نشد");
                            MessageBox.Show(ex.Message);
                            trans.Rollback();
                            
                        }
                    finally
                        {
                            FillElements();
                            btn_clear.PerformClick();
                        }
                }
            }
            else
            {
                Error_Message("فیلد ها با لیبل قرمز رنگ الزاما باید تکمیل شوند");
            }
        }

        private bool CheckFields()
        {
            if (txt_brandGoods.Text.Trim() == "")
            {
                errProvider.SetError(txt_brandGoods, "باید نوشته شود");
                return false;
            }
            if (txt_priceGoods.Text.Trim() == null)
            {
                errProvider.SetError(txt_priceGoods, "باید نوشته شود");
                return false;
            }
            if (txt_numberGoods.Text.Trim() == null)
            {
                errProvider.SetError(txt_numberGoods, "باید نوشته شود");
                return false;
            }
            if (txt_nameGoods.Text.Trim() == null)
            {
                errProvider.SetError(txt_nameGoods, "باید نوشته شود");
                return false;
            }
            if (cmb_typeGoods.SelectedIndex == null)
            {
                errProvider.SetError(cmb_typeGoods, "باید نوشته شود");
                return false;
            }
            return true;

        }

        private void btn_typeAdd_Click(object sender, EventArgs e)
        {
            frm_typeGoods ftg=new frm_typeGoods(this);
            ftg.ShowDialog();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_save.Enabled = true;

            txt_brandGoods.Clear();
            txt_commentGoods.Clear();
            txt_modelGoods.Clear();
            txt_nameGoods.Clear();
            txt_numberGoods.Text = "";
            txt_priceGoods.Text = "";
            cmb_typeGoods.Text = "";
            lbl_LettersPrice.Text = "صفر تومان";
            FillElements();

        }

        private void txt_priceGoods_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_priceGoods_TextChanged(object sender, EventArgs e)
        {
            lbl_LettersPrice.Text=Persian_Number_To_String.GET_Number_To_PersianString(txt_priceGoods.Text)+" تومان";
        }

        private void mi_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string str_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int id = Convert.ToInt32(str_id);
                string mes = "شما می خواهید کالا به شماره ";
                mes += str_id;
                mes += " از سیستم حذف کنید؟";
                DialogResult dr = MessageBox.Show(mes, "سیستم", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        using (ParsTelModel ptm = new ParsTelModel())
                        {
                            
                            var query = ptm.Commodity.Where(c => c.id ==id ).First();
                            ptm.Commodity.Remove(query);
                            ptm.SaveChanges();

                        }
                        Success_Message("کالای موردنظر حذف شد");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                  
                }
            }
            catch(Exception ex)
            {
                Error_Message("به دلیل بروز خطا امکان انجام عملیات موجود نیست");
            }
            finally
            {
                FillElements();
                btn_clear.PerformClick();
            }
        }

        private void mi_edit_Click(object sender, EventArgs e)
        {
            btn_clear.PerformClick();
            try
            {
                
                txt_Id.Text = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                cmb_typeGoods.SelectedIndex= Int32.Parse(dataGridView1.CurrentRow.Cells["type"].Value.ToString());
                txt_nameGoods.Text = dataGridView1.CurrentRow.Cells["gName"].Value.ToString();
                txt_modelGoods.Text = dataGridView1.CurrentRow.Cells["model"].Value.ToString();
                txt_brandGoods.Text = dataGridView1.CurrentRow.Cells["brand"].Value.ToString();
                txt_numberGoods.Text = dataGridView1.CurrentRow.Cells["gNumber"].Value.ToString();
                txt_priceGoods.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                

                btn_save.Enabled = false;
                btn_edit.Enabled = true;


            }
            catch(Exception ex)
            {

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            using(ParsTelModel ptm=new ParsTelModel())
            {
                try
                {
                    int id = Convert.ToInt32(txt_Id.Text);
                    var query = ptm.Commodity.Where(c => c.id == id).First();
                    if(query!=null)
                    { 
                        query.price = Convert.ToInt32(query.price);
                        query.model = txt_modelGoods.Text;
                        query.brand = txt_brandGoods.Text;
                        query.gNumber = Convert.ToInt32(txt_numberGoods.Text);
                        query.gComments = txt_commentGoods.Text;
                        query.gName = txt_nameGoods.Text;
                        query.type = cmb_typeGoods.SelectedIndex;
                    }
                    ptm.SaveChanges();
                    Success_Message("ويرايش اطلاعات انجام شد");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    FillElements();
                    btn_clear.PerformClick();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_Id.Text=dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                txt_nameGoods.Text= dataGridView1.CurrentRow.Cells["gName"].Value.ToString();
                txt_brandGoods.Text= dataGridView1.CurrentRow.Cells["brand"].Value.ToString();
                txt_commentGoods.Text= dataGridView1.CurrentRow.Cells["gComments"].Value.ToString();
                txt_modelGoods.Text= dataGridView1.CurrentRow.Cells["model"].Value.ToString();
                txt_numberGoods.Text= dataGridView1.CurrentRow.Cells["gNumber"].Value.ToString();
                txt_priceGoods.Text= dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                cmb_typeGoods.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["type"].Value.ToString());
                btn_save.Enabled=false;
                btn_edit.Enabled = true;
            }
            catch
            {

            }
        }
    }
}
