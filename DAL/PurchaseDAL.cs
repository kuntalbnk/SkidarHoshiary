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
    public class PurchaseDAL
    {
        public static string GetPurchaseData(string ItemType)
        {
            string cs = GetConnectionString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select qty from tblOrders where OrderNo='" + ItemType + "'", con);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count > 0)
            {
                return ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public static bool InsertPurchaseData(string Item,string CompanyName,string Address,string Pin,string ContactPerson,
            string ContactNo,string Qty,string Rate,string WBTax,string Cst,string ItemCost, string Amount)
        {
            bool result = false;
            try
            {             
                if (!string.IsNullOrEmpty(Item) && !string.IsNullOrEmpty(CompanyName) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(Pin) &&
                    !string.IsNullOrEmpty(ContactPerson) && !string.IsNullOrEmpty(ContactNo) && !string.IsNullOrEmpty(Qty) && !string.IsNullOrEmpty(Rate) &&
                     !string.IsNullOrEmpty(Cst) && !string.IsNullOrEmpty(ItemCost) && !string.IsNullOrEmpty(Amount))
                {
                    string cs = GetConnectionString();
                    int Tax = WBTax == string.Empty ? 0 :Convert.ToInt32(WBTax);
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SPPurchase";
                    cmd.Parameters.AddWithValue("@orderno", Item);
                    cmd.Parameters.AddWithValue("@cname", CompanyName);
                    cmd.Parameters.AddWithValue("@addr", Address);
                    cmd.Parameters.AddWithValue("@pin", Pin);
                    cmd.Parameters.AddWithValue("@person", ContactPerson);
                    cmd.Parameters.AddWithValue("@contact", ContactNo);
                    cmd.Parameters.AddWithValue("@purchaseqty", Convert.ToInt32(Qty));
                    cmd.Parameters.AddWithValue("@rate", Convert.ToDecimal(Rate));
                    cmd.Parameters.AddWithValue("@wb", Convert.ToInt32(Tax));
                    cmd.Parameters.AddWithValue("@cst", Convert.ToInt32(Cst));
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(ItemCost));
                    cmd.Parameters.AddWithValue("@amt", Convert.ToDecimal(Amount));
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            { }
            return result;
        }

        public static DataTable GetItemValue()
        {
            
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection();
                string cs = GetConnectionString();
                conn = new SqlConnection(cs);
                conn.Open();               
                string query = "select item,orderno,qty from tblOrders where orderstatus=1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Order");
                dt = ds.Tables["Order"];
            }
            catch(Exception ex)
            {

            }
            return dt;
            //cmbItem.DisplayMember = "item";
            //cmbItem.ValueMember = "orderno";
            //cmbItem.DataSource = ds.Tables["Order"];
        }

        private static string GetConnectionString()
        {
            string cs = ConfigurationManager.ConnectionStrings["conntionstring1"].ConnectionString;
            return cs;
        }
    }
}
