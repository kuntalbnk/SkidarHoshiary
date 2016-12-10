using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Process;
using System.Data.SqlClient;

namespace SkidarHoshiary
{
    public partial class Sales : MetroFramework.Forms.MetroForm
    {
        decimal result,result1,dis,amt;
        public static string billno1 = string.Empty;
                        
        public Sales()
        {
            InitializeComponent();
        }
       private void Sales_Load(object sender, EventArgs e)
        {
            
            try
            {
                DataTable dt = Process.SalesProcess.GetItem();
                if (dt.Rows.Count > 0)
                {
                    cmbItem.DataSource = dt;
                    cmbItem.DisplayMember = "item";
                    cmbItem.ValueMember = "orderno";
                    // cmbItem.SelectedValue = "Select";                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void reset()
        {
            txtDiscount.Text = "";
            txtSalesQty.Text = "";
            txtSalesRate.Text = "";
            txtMobNo.Text = "";
            txtCName.Text = "";
            txtCAddr.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                bool result = false;
                if (txtBill.Text=="" && txtCAddr.Text=="" && txtCName.Text=="" && txtMobNo.Text=="" && txtSalesQty.Text=="" && txtSalesRate.Text=="")
                {
                    MessageBox.Show("Please Enter All Details.");
                }
                else
                {
                    //string billno = Process.SalesProcess.billchk(txtBill.Text);
                    //if (billno != txtBill.Text)
                    //{
                        //string a = enterqty();
                        //MessageBox.Show(a);
                       // txtSalesQty.Text = "";
                       
                        result = Process.SalesProcess.InsertSalesData("Insert", txtCName.Text, txtCAddr.Text, txtMobNo.Text, cmbItem.SelectedValue.ToString(), txtSalesQty.Text, txtSalesRate.Text, txtDiscount.Text, txtNetAmt.Text, txtBill.Text);
                        billno1 = txtBill.Text;
                        if (result)
                        {
                           // MessageBox.Show("Successfully Sale.");
                            Sales salesform = new Sales();
                            salesform.Dispose();
                            this.Close();
                            this.Hide();
                            PrintBill print = new PrintBill();
                           // print.Size = new System.Drawing.Size(700, 700);
                            print.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Operation Failed");
                        }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     public void amtcalculate()
        {
            if (txtDiscount.Text != "")
            {
                result1 = Convert.ToDecimal(txtDiscount.Text) / Convert.ToDecimal(100);
                dis = result1 * Convert.ToDecimal(txtSalesRate.Text);
                amt = ((Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtSalesQty.Text)) - dis);
            }
            else
            {
                amt = Convert.ToDecimal(txtSalesQty.Text) * Convert.ToDecimal(txtSalesRate.Text);
                txtNetAmt.Text = amt.ToString();
            }
        }
        public string enterqty()
        {
            string returnValue = string.Empty;
            try
            {
                if (txtSalesQty.Text == "0")
                {
                    returnValue = "Qty can't be 0!";
                }
                else
                {
                    if (txtSalesQty.Text == txtPurchaseQty.Text)
                    {
                        returnValue = "0";
                    }
                    if (!string.IsNullOrEmpty(txtSalesQty.Text))
                    {
                        if (Convert.ToInt32(txtSalesQty.Text) < Convert.ToInt32(txtPurchaseQty.Text))
                        {
                            returnValue = "0";
                        }
                        else
                        {
                            returnValue = "Qty can't be more than order qty!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return returnValue;

        }
        

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard das = new Dashboard();
            das.Show();

        }

        private void txtSalesQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSalesRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderQty = Process.SalesProcess.GetpurchaseQtyData(cmbItem.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(orderQty))
            {
                txtPurchaseQty.ReadOnly = true;
                txtPurchaseQty.Text = orderQty;
                //txtCName.Text = orderQty;
            }
            string rate = Process.SalesProcess.GetpurchaserateData(cmbItem.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(rate))
            {
                txtPurchaseRate.ReadOnly = true;
                txtPurchaseRate.Text = rate;
                //txtCName.Text = orderQty;
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            amtcalculate();
        }

        private void txtSalesRate_TextChanged(object sender, EventArgs e)
        {
            amtcalculate();
        }
    }
}
