using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkidarHoshiary
{
    public partial class UserRights : MetroFramework.Forms.MetroForm
    {
        public UserRights()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SkidarHosiaryDB;Integrated Security=True";

        
        private int checkUid()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select userid from tblusers where userid='" + txtUid.Text + "'", con);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void UserRights_Load(object sender, EventArgs e)
        {
            setCompany();
            setRights();
        }
        private void setRights()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(cs);
                string query = "select rightid,rightsname from tblHelp where RightId in(1,2)";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Rights");
                cmbUserR.DisplayMember = "rightsname";
                cmbUserR.ValueMember = "rightid";
                cmbUserR.DataSource = ds.Tables["Rights"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setCompany()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(cs);
                string query = "select compid,compName from tblcompanies";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Company");
                cmbComp.DisplayMember = "compName";
                cmbComp.ValueMember = "compid";
                cmbComp.DataSource = ds.Tables["Company"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkUid() == 0)
            {
                if (txtCpass.Text == txtPass.Text)
                {
                    SqlConnection con = new SqlConnection(cs);
                    try
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SPNewUserEntry";
                        cmd.Parameters.AddWithValue("@EntryMode", "Insert");
                        cmd.Parameters.AddWithValue("@CompId", cmbComp.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@UserId", txtUid.Text);
                        cmd.Parameters.AddWithValue("@Pass", txtCpass.Text);
                        cmd.Parameters.AddWithValue("@Rights", Convert.ToInt16(cmbUserR.SelectedValue.ToString()));
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successfully Create New User.");
                        txtUid.Text = "";
                        txtPass.Text = "";
                        txtCpass.Text = "";
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Both Password must be same!");
                }
            }
            else
            {
                MessageBox.Show("User name is present! Enter New One.");
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
