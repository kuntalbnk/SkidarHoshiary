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
    public class OrderDAL
    {
        public static bool GetOrder(string OrderNo,string item, int qty, string date, string time, string entrymod)
        {
            bool Value = false;
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SPOrderEntry";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderid", OrderNo);
                cmd.Parameters.AddWithValue("@Orderdt", Convert.ToDateTime(date));
                cmd.Parameters.AddWithValue("@Item", item);
                cmd.Parameters.AddWithValue("@Qty",Convert.ToInt16(qty));
                cmd.Parameters.AddWithValue("@ordertime", Convert.ToDateTime(time));
                cmd.Parameters.AddWithValue("@entrymode", entrymod);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    //SqlCommand retrive = new SqlCommand("select Top 1 OrderID from tblOrders where OrderNo='"+OrderNo+"'order by OrderID desc",con);
                    //SqlDataAdapter da = new SqlDataAdapter(retrive);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    //if(dt.Rows.Count > 0)
                    //{
                    //    Value = dt.Rows[0][0].ToString();
                    //    return Value;
                    //}
                    Value = true;
                    return Value;
                    
                }
                else
                {
                    Value = false;
                    return Value;
                }
            }
            catch (SqlException ex)
            {
               // return false;

            }
            return Value;

        }
        private static string GetConnectionString()
        {
            string cs = ConfigurationManager.ConnectionStrings["conntionstring1"].ConnectionString;
            return cs;
        }
    }
}
