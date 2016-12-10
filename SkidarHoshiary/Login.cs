using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Process;

namespace SkidarHoshiary
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public static string uid;
        public Login()
        {
            InitializeComponent();
        }
        //string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SkidarHosiaryDB;Integrated Security=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUid.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                int loginStatus = ProcessLayer.GetLoginStatus(txtUid.Text,txtPass.Text,"Login");
                if (loginStatus>=1)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else 
                {
                    MessageBox.Show("Login Failed!");
                }
                //Create SqlConnection
                //SqlConnection con = new SqlConnection(cs);
                //SqlCommand cmd = new SqlCommand("Select userid,password,compId from tblUsers where UserId=@username and Password=@password and status=1", con);
                //cmd.Parameters.AddWithValue("@username",  txtUid.Text);
                //cmd.Parameters.AddWithValue("@password", txtPass.Text);
                //con.Open();
                //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //adapt.Fill(ds);
                //con.Close();
                //int count = ds.Tables[0].Rows.Count;
                ////If count is equal to 1, than show frmMain form
                //if (count == 1)
                //{
                //    //MessageBox.Show("Login Successful!");
                //    uid = ds.Tables[0].Rows[0][2].ToString();
                //    this.Hide();
                //    Dashboard das = new Dashboard();
                //    das.Show();
                //}

                //else
                //{
                //    MessageBox.Show("Login Failed!");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
    
