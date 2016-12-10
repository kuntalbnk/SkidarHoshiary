using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Process;

namespace SkidarHoshiary
{
    public partial class Transportation : MetroFramework.Forms.MetroForm
    {
        public Transportation()
        {
            InitializeComponent();
        }
        
        private void Transportation_Load(object sender, EventArgs e)
        {
            ItemLoad();
            GodownLoad();
            
        }
        public void ItemLoad()
        {
            try
            {
                DataTable dt = Process.TransportationProcess.GetItem();
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
        public void GodownLoad()
        {
            try
            {
                DataTable dt = Process.TransportationProcess.GetGodown();
                if (dt.Rows.Count > 0)
                {
                    cmbGName.DataSource = dt;
                    cmbGName.DisplayMember = "GodownName";
                    cmbGName.ValueMember = "GodownNo";
                    // cmbItem.SelectedValue = "Select";                 
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

        private void txtTransportQty_TextChanged(object sender, EventArgs e)
        {
            string a = enterqty();
            if (a == "0")
            {

            }
            else {
                MessageBox.Show(a);
                txtTransportQty.Text = "";
            }
        }
        public string enterqty()
        {
            try
            {
                if (txtTransportQty.Text == "0")
                {
                    return "Transport qty can't be 0!";
                }
                else
                {
                    if (txtTransportQty.Text == txtpurchaseQty.Text)
                    {
                        return "0";
                    }
                    else if (Convert.ToInt16(txtTransportQty.Text) < Convert.ToInt16(txtpurchaseQty.Text))
                    {
                        return "0";
                    }
                    else
                    {
                        return "Qty can't be more than order qty!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private void txtTransportQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string purchaseqty = Process.TransportationProcess.GetPurchaseQtyData(cmbItem.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(purchaseqty))
            {
                txtpurchaseQty.ReadOnly = true;
                txtpurchaseQty.Text = purchaseqty;
                //txtCName.Text = orderQty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                if (!string.IsNullOrEmpty(txtTransportQty.Text) && !string.IsNullOrEmpty(txtLrNo.Text))
                {
                    MessageBox.Show("Please Enter All Details.");
                }
                else
                {
                    result = Process.TransportationProcess.InsertTransportedData(cmbItem.SelectedValue.ToString(), txtpurchaseQty.Text, txtTransportQty.Text, txtLrNo.Text, cmbGName.SelectedValue.ToString(), Convert.ToString(dtpOrderDt.Value.ToShortDateString()), Convert.ToString(dtpTime.Value.ToShortTimeString()), Convert.ToString(dtpEstDt.Value.ToShortDateString()));
                    if (result)
                    {
                        MessageBox.Show("Successfully Transported.");
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
