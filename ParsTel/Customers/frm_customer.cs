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
using ParsTel.initialize;
using System.Data.Entity;

namespace ParsTel.Customers
{
    public partial class frm_customer : Office2007Form
    {
        public frm_customer()
        {
            InitializeComponent();
        }
        
        private void frm_customer_Load(object sender, EventArgs e)
        {
            DisplayArgumant();
        }

        private void DisplayArgumant()
        {
            try
            {
                using (ParsTelModel ptm = new ParsTelModel())
                {
                    var query = ptm.InitializeTables.FirstOrDefault();
                    txt_Id.Text = query.customerCode.ToString();

                    var query1 = ptm.Customers.ToList();
                    dg_display.DataSource = query1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fetal Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag_insert = true;
                string str_errorMessage = "";
                checkEmptyText(ref flag_insert, ref str_errorMessage);
                if (flag_insert)
                {
                    using (ParsTelModel ptm = new ParsTelModel())
                    {
                        using (DbContextTransaction trans = ptm.Database.BeginTransaction())
                        {
                            try
                            {
                                customer cusm = new customer();
                                cusm.id = Convert.ToInt32(txt_Id.Text);
                                cusm.fname = txt_fname.Text;
                                cusm.lname = txt_lname.Text;
                                cusm.phone = txt_phone.Text;
                                cusm.sadere = txt_sadere.Text;
                                cusm.shenasnameID = txt_shenasname.Text;
                                cusm.postalCode = txt_postalCode.Text;
                                cusm.address = txt_Address.Text;
                                cusm.birthPlace = txt_tavalod.Text;
                                cusm.fatherName = txt_fatheName.Text;
                                cusm.city = txt_city.Text;
                                cusm.melli = txt_melli.Text;
                                cusm.mobile = txt_mobile.Text;
                                cusm.phone = txt_phone.Text;
                                ptm.Customers.Add(cusm);
                                initializeTables initTbl = ptm.InitializeTables.First();
                                int customerCode = initTbl.customerCode;
                                initTbl.customerCode = ++customerCode;

                                ptm.Customers.Add(cusm);
                                ptm.SaveChanges();
                                trans.Commit();
                                MessageBox.Show("اطلاعات مشتری جدید ذخیره گردید");
                            }
                            catch (Exception ex)
                            {
                                trans.Rollback();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        DisplayArgumant();
                    }
                }
                else
                    MessageBox.Show(str_errorMessage, "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_clear.PerformClick();
            }
        }

        private void checkEmptyText(ref bool flag_insert, ref string str_errorMessage)
        {
            if (txt_fname.Text.Trim().Length == 0)
            {
                flag_insert = false;
                errorProvider1.SetError(txt_fname, "این قسمت نمی تواند خالی باشد");
                str_errorMessage += "\n نام مشتری نوشته نشده است";
            }
            if (txt_lname.Text.Trim().Length == 0)
            {
                flag_insert = false;
                errorProvider1.SetError(txt_lname, "این قسمت نمی تواند خالی باشد");
                str_errorMessage += "\nنام خانوادگی مشتری به درستی وارده نشده است";
            }
            if (txt_melli.Text.Length != 10)
            {
                flag_insert = false;
                errorProvider1.SetError(txt_melli, "کد ملی 10 رقمی است");
                str_errorMessage += "\n کد ملی مشتری یک کد 10 رقمی است";
            }
            if (txt_mobile.Text.Trim().Length != 11)
            {
                flag_insert = false;
                errorProvider1.SetError(txt_mobile, "تلفن همراه 11 رقمی است");
                str_errorMessage += "\n شماره موبایل یک عدد 11 رقمی است";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DisplayArgumant();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_fatheName.Clear();
            txt_city.Clear();
            txt_shenasname.Clear();
            txt_tavalod.Clear();
            txt_melli.Clear();  
            txt_sadere.Clear();
            txt_postalCode.Clear();
            txt_mobile.Clear();
            txt_phone.Clear();
            txt_Address.Clear();    
            btn_edit.Enabled = false;
            btn_save.Enabled = true;
            txt_fname.Focus();
        }

        private void dg_display_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                btn_edit.Enabled = true;
                btn_save.Enabled = false;
                txt_Id.Text = dg_display.CurrentRow.Cells["id"].Value.ToString();
                txt_fname.Text = dg_display.CurrentRow.Cells["fname"].Value.ToString();
                txt_lname.Text = dg_display.CurrentRow.Cells["lname"].Value.ToString();
                txt_fatheName.Text = dg_display.CurrentRow.Cells["fatherName"].Value.ToString();
                txt_city.Text = dg_display.CurrentRow.Cells["city"].Value.ToString();
                txt_shenasname.Text = dg_display.CurrentRow.Cells["shenasnameID"].Value.ToString();
                txt_tavalod.Text = dg_display.CurrentRow.Cells["birthPlace"].Value.ToString();
                txt_sadere.Text = dg_display.CurrentRow.Cells["sadere"].Value.ToString();
                txt_Address.Text = dg_display.CurrentRow.Cells["address"].Value.ToString();
                txt_postalCode.Text = dg_display.CurrentRow.Cells["postalCode"].Value.ToString();
                txt_mobile.Text = dg_display.CurrentRow.Cells["mobile"].Value.ToString();
                txt_phone.Text = dg_display.CurrentRow.Cells["phone"].Value.ToString();
                txt_melli.Text = dg_display.CurrentRow.Cells["melli"].Value.ToString();

            }
            catch

            {

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag_update = true;
                string str_errorMessage = "";
                checkEmptyText(ref flag_update, ref str_errorMessage);
                if (flag_update)
                {
                    int id = Convert.ToInt32(txt_Id.Text);
                    using (ParsTelModel ptm = new ParsTelModel())
                    {
                        var upd = ptm.Customers.Where(c => c.id == id).First();
                        if(upd!=null)
                        {
                            upd.id = id;
                            upd.fname=txt_fname.Text;   
                            upd.lname=txt_lname.Text;
                            upd.fatherName = txt_fatheName.Text;
                            upd.city = txt_city.Text;
                            upd.shenasnameID=txt_shenasname.Text;
                            upd.birthPlace = txt_tavalod.Text;
                            upd.melli = txt_melli.Text;
                            upd.sadere=txt_sadere.Text;
                            upd.postalCode= txt_postalCode.Text;
                            upd.mobile=txt_mobile.Text;
                            upd.phone=txt_phone.Text;
                            upd.address = txt_Address.Text;
                            ptm.SaveChanges();
                            MessageBox.Show("اطلاعات مشتری به روز شد");
                        }
                    }
                }
                else
                    MessageBox.Show(str_errorMessage, "خطای کاربر", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btn_clear.PerformClick();
            }
        }
    }
}
