using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Process;


namespace SkidarHoshiary
{
    public partial class Order : MetroFramework.Forms.MetroForm
    {
        public static string orderValue = string.Empty;
        public Order()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRate.Text == "" && txtQty.Text == "")
            {
                MessageBox.Show("Please enter all details.");
            }
            else
            {
                try
                {
                   bool order = OrderProcess.GetOrder(txtOrderNo.Text, txtRate.Text, Convert.ToInt16(txtQty.Text), dtpOrderDt.Value.ToShortDateString(), dtpTime.Value.ToShortTimeString(), "Insert");
                   orderValue = txtOrderNo.Text;
                    if (order)
                    {
                        Order orderform = new Order();
                        orderform.Dispose();
                        this.Close();
                        this.Hide();
                        Print print = new Print();
                       // print.Size = new System.Drawing.Size(700,700);
                        print.Show();

                    }
                    else
                    {
                        MessageBox.Show("Some Errors occures!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard das = new Dashboard();
            das.Show();
        }
        public void Reset()
        {
            txtRate.Text = "";
            txtQty.Text = "";
            this.dtpOrderDt.Value = DateTime.Now;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
