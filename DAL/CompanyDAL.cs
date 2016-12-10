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
    public class CompanyDAL
    {
        public static bool GetCompany(string companyname, string adress, string pin, string vat, string phone, string email, string entrymod)
        {
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SPCompanyEntry";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompName", companyname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@mobno", phone);
                cmd.Parameters.AddWithValue("@address", adress);
                cmd.Parameters.AddWithValue("@pincode", pin);
                cmd.Parameters.AddWithValue("@VAT", vat);
                cmd.Parameters.AddWithValue("@EntryMode", entrymod);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if(x>0)
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
