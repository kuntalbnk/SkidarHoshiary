using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkidarHoshiary
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SkidarHosiaryDB;Integrated Security=True";

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCP.Text == txtNewP.Text)
            {
                SqlConnection con = new SqlConnection(cs);
                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SPUpdatePass";
                    cmd.Parameters.AddWithValue("@userid", Login.uid);
                    cmd.Parameters.AddWithValue("@pass", txtCP.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Changed.");
                    txtNewP.Text = "";
                    txtCP.Text = "";
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Both password should be same!");
            }
        }
    }
}
