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
    public class GodownDAL
    {
        public static bool GetGodown(string godownname, string adress, string pin, string phone, string entrymod)
        {
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SPGodownEntry";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@godownname", godownname);
                cmd.Parameters.AddWithValue("@addr", adress);
                cmd.Parameters.AddWithValue("@contactno", phone);
                cmd.Parameters.AddWithValue("@pin", pin);
                cmd.Parameters.AddWithValue("@entrymode", entrymod);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                return false;

            }
        }
        private static string GetConnectionString()
        {
            string cs = ConfigurationManager.ConnectionStrings["conntionstring1"].ConnectionString;
            return cs;
        }
    }
}
