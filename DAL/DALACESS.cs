using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALACESS
    {
        public static int GetLoginStatus(string username, string password,string actionset)
        {
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SPUserLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userid", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@Action", actionset);
                SqlParameter outmsg = new SqlParameter("@OutputMsg", SqlDbType.Int,16){ Direction = ParameterDirection.Output };     
                cmd.Parameters.Add(outmsg);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                int msg = Convert.ToInt16(outmsg.Value);
                //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //adapt.Fill(ds);
                con.Close();
               // int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                return msg;
            }
            catch (SqlException ex)
            {
                return 0;

            }
        }
        private static string GetConnectionString()
        {
            string cs = ConfigurationManager.ConnectionStrings["conntionstring1"].ConnectionString;
            return cs;
        }
    }
}
