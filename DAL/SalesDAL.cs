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

    public class SalesDAL
    {
        public static string billchk(string bill)
        {
            string cs = GetConnectionString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select billno from tblsales where billno='" + bill + "'", con);
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
        public static bool InsertSalesEntry(string mode,string name, string addr, string contact, string orderno, string salesqty, string rate, string dis, string amt,string billno)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(billno) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(addr) && !string.IsNullOrEmpty(contact) && !string.IsNullOrEmpty(orderno) &&
                !string.IsNullOrEmpty(salesqty) && !string.IsNullOrEmpty(rate) && !string.IsNullOrEmpty(amt))
            {
                if(dis==string.Empty)
                {
                    dis = "0";
                }
                string cs = GetConnectionString();
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPSales";
                cmd.Parameters.AddWithValue("@mode", mode);
                //cmd.Parameters.AddWithValue("@SalesId", salesid);
                cmd.Parameters.AddWithValue("@cname", name);
                cmd.Parameters.AddWithValue("@addr", addr);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@orderno", orderno);
                cmd.Parameters.AddWithValue("@salesqty", Convert.ToInt32(salesqty));
                cmd.Parameters.AddWithValue("@rate", Convert.ToDecimal(rate));
                cmd.Parameters.AddWithValue("@discount", Convert.ToInt32(dis));
                cmd.Parameters.AddWithValue("@amt", Convert.ToDecimal(amt));
                cmd.Parameters.AddWithValue("@billno", billno);
                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        public static string GetPurchaseData(string ItemType)
        {
            string cs = GetConnectionString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select purchaseqty from tblpurchase where OrderNo='" + ItemType + "'", con);
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
        public static string GetPurchaserateData(string ItemType)
        {
            string cs = GetConnectionString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select netamt from tblpurchase where OrderNo='" + ItemType + "'", con);
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
        public static DataTable GetItemValue()
        {

            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection();
                string cs = GetConnectionString();
                conn = new SqlConnection(cs);
                conn.Open();
                string query = "select a.item,b.orderno,b.PurchaseQty from tblOrders a,tblpurchase b where a.orderno=b.orderno";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Order");
                dt = ds.Tables["Order"];
            }
            catch (Exception ex)
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
