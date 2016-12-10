using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Process;

namespace SkidarHoshiary
{
    public partial class Godown : MetroFramework.Forms.MetroForm
    {
        public Godown()
        {
            InitializeComponent();
        }
        public void reset()
        {
            txtPin.Text = "";
            txtGName.Text = "";
            txtContact.Text = "";
            txtAddr.Text = "";
            txtContact.Text = "";
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddr.Text == "" && txtContact.Text == "" && txtPin.Text == "" && txtContact.Text == "" && txtGName.Text=="")
            {
                MessageBox.Show("Please enter all details.");
            }
            else
            {
                try
                {
                    bool company = GodownProcess.GetGodown(txtGName.Text,txtAddr.Text,txtPin.Text,txtContact.Text,"Insert");
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
