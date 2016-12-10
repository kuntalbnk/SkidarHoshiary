using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkidarHoshiary
{
    public partial class Purchase : MetroFramework.Forms.MetroForm
    {
        decimal result, result1, tax, cst;
        public Purchase()
        {
            InitializeComponent();
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                bool returnValue = CheckQtyValue();
                if (returnValue)
                {
                    if (string.IsNullOrEmpty(txtCName.Text) && string.IsNullOrEmpty(txtAddr.Text) && string.IsNullOrEmpty(txtPin.Text) &&
                    string.IsNullOrEmpty(txtContactPerson.Text) && string.IsNullOrEmpty(txtContact.Text) && string.IsNullOrEmpty(txtQty.Text) && string.IsNullOrEmpty(txtRate.Text))
                    {
                        MessageBox.Show("Please Enter All Details.(Except TAX Fields)");
                    }
                    else
                    {
                        result = Process.PurchaseProcess.InsertPurchaseOrderProcess(cmbItem.SelectedValue.ToString(), txtCName.Text, txtAddr.Text, txtPin.Text, txtContactPerson.Text, txtContact.Text, txtQty.Text, txtRate.Text, txtWB.Text, txtCST.Text, txtItemCost.Text, txtAmt.Text);
                        if (result)
                        {
                            Purchase purchase = new Purchase();
                            purchase.Dispose();
                            //Print print = new Print();
                            //print.Show();
                            MessageBox.Show("Successfully Inserted");
                            Dashboard dashoard = new Dashboard();
                            dashoard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Operation Failed");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard das = new Dashboard();
            das.Show();
        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

        }
        private void txtAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

        }

        //public void setvalue()
        //{
        //    txtAmt.Text = "0.00";
        //    txtRate.Text = "0.00";
        //    txtWB.Text = "0";
        //    txtCST.Text = "0";
        //    txtQty.Text = "0";
        //}
        private void Purchase_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Process.PurchaseProcess.GetItem();
                if (dt.Rows.Count > 0)
                {
                    cmbItem.DataSource = dt;
                    cmbItem.DisplayMember = "item";
                    cmbItem.ValueMember = "orderno";
                    // cmbItem.SelectedValue = "Select";  
                    string orderQty = Process.PurchaseProcess.GetOrderQtyData(cmbItem.SelectedValue.ToString());
                    if (!string.IsNullOrEmpty(orderQty))
                    {
                        txtOqty.ReadOnly = true;
                        txtOqty.Text = orderQty;
                        //txtCName.Text = orderQty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Reset()
        {
            txtQty.Text = "";
            txtAddr.Text = "";
            txtAmt.Text = "";
            txtCName.Text = "";
            txtContact.Text = "";
            txtContactPerson.Text = "";
            txtCST.Text = "";
            txtItemCost.Text = "";
            txtPin.Text = "";
            txtRate.Text = "0.00";
            txtWB.Text = "";
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderQty = Process.PurchaseProcess.GetOrderQtyData(cmbItem.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(orderQty))
            {
                txtOqty.ReadOnly = true;
                txtOqty.Text = orderQty;
                //txtCName.Text = orderQty;
            }
        }

        //private void txtQty_TextChanged(object sender, EventArgs e)
        //{
        //    string returnValue = CheckOqtyValue();
        //    if (string.IsNullOrEmpty(returnValue))
        //    {
        //       // txtOqty.Text = returnValue;
        //        MessageBox.Show("No Data Found For This Item");
        //        txtQty.Text = "";
        //    }
        //}

        public bool CheckQtyValue()
        {
            bool returnValue = false;
            try
            {
                if (!string.IsNullOrEmpty(txtQty.Text))
                {
                    if (Convert.ToInt32(txtOqty.Text) >= Convert.ToInt32(txtQty.Text))
                    {
                        returnValue = true;
                    }
                    else
                    {
                        returnValue = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return returnValue;
        }
        public bool CheckOQtyValue()
        {
            bool returnValue = false;
            try
            {
                if (string.IsNullOrEmpty(txtOqty.Text) || txtOqty.Text == "0")
                {
                    returnValue = false;
                }
                else
                {
                    returnValue = true;
                }
            }
            catch (Exception ex)
            {

            }
            return returnValue;
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            outputitemcost();
        }

        private void txtWB_TextChanged(object sender, EventArgs e)
        {
            outputitemcost();
        }

        private void txtCST_TextChanged(object sender, EventArgs e)
        {
            outputitemcost();
        }
        private void outputitemcost()
        {
            if (txtCST.Text == "" && txtWB.Text == "" && txtRate.Text != "0.00" && txtQty.Text != "")
            {
                result = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text));
                txtItemCost.Text = result.ToString();
                txtAmt.Text = result.ToString();
            }
            else if (txtCST.Text != "" && txtWB.Text != "" && txtRate.Text != "0.00" && txtQty.Text != "")
            {
                result1 = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text));
                tax = (Convert.ToDecimal(txtWB.Text) / Convert.ToDecimal(100)) * result1;
                cst = (Convert.ToDecimal(txtCST.Text) / Convert.ToDecimal(100)) * result1;
                result = result1 + tax + cst;
                txtItemCost.Text = result.ToString();
                txtAmt.Text = result.ToString();
            }
            else if (txtCST.Text != "" && txtWB.Text == "" && txtRate.Text != "0.00" && txtQty.Text != "")
            {
                // tax = Convert.ToDecimal(txtWB.Text) / Convert.ToDecimal(100);
                result1 = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text));
                cst = (Convert.ToDecimal(txtCST.Text) / Convert.ToDecimal(100)) * result1;
                result = (result1+ cst);
                txtItemCost.Text = result.ToString();
                txtAmt.Text = result.ToString();
            }
            else if (txtCST.Text == "" && txtWB.Text != "" && txtRate.Text != "0.00" && txtQty.Text != "")
            {
                result1 = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text));
               tax = (Convert.ToDecimal(txtWB.Text) / Convert.ToDecimal(100)) * result1;
                //cst = Convert.ToDecimal(txtCST.Text) / Convert.ToDecimal(100);
                result = (result1 + tax);
                txtItemCost.Text = result.ToString();
                txtAmt.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please Check Your Entries!");
            }
        }

        private void txtOqty_TextChanged(object sender, EventArgs e)
        {
            bool returnValue = CheckOQtyValue();
            if (!returnValue)
            {
                MessageBox.Show("Please Change Item Type");
            }
        }

        private void txtWB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                outputitemcost();
            }
        }

        //private void txtOqty_TextChanged(object sender, EventArgs e)
        //{
        //    string a = enterqty();
        //    if (string.IsNullOrEmpty(a))
        //    {
        //        txtOqty.Text = a;
        //    }
        //    else
        //    {
        //        MessageBox.Show(a);
        //        txtQty.Text = "";
        //    }
        //}
    }
}
