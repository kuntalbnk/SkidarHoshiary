using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Process;

namespace SkidarHoshiary
{
    public partial class Company : MetroFramework.Forms.MetroForm
    {
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
        }
        public void reset()
        {
            txtEmail.Text = "";
            txtPin.Text = "";
            txtVat.Text = "";
            txtContact.Text = "";
            txtCName.Text = "";
            txtCAddr.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCAddr.Text == "" && txtCName.Text == "" && txtPin.Text == "" && txtContact.Text == "")
            {
                MessageBox.Show("Please enter details.(VAT and Email are optional)");
            }
            else
            {
                try
                {
                    bool company = CompanyProcess.GetCompany(txtCName.Text, txtCAddr.Text,txtPin.Text,txtVat.Text,txtContact.Text,txtEmail.Text,"Insert");
                    if (company)
                    {
                        MessageBox.Show("Successfully Saved.");
                        reset();
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
    }
}
