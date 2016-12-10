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
    public class TransportationDAL
    {
        public static string GetPurchaseData(string ItemType)
        {
            string cs = GetConnectionString();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select purchaseqty from tblPurchase where OrderNo='" + ItemType + "'", con);
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

        public static bool InsertTransportData(string Item, string purchaseqty, string transqty, string vno, string gno,
            string tranddt, string transtime, string estdt)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(Item) && !string.IsNullOrEmpty(purchaseqty) && !string.IsNullOrEmpty(transqty) && !string.IsNullOrEmpty(vno) &&
                !string.IsNullOrEmpty(gno) && !string.IsNullOrEmpty(tranddt) && !string.IsNullOrEmpty(transtime) && !string.IsNullOrEmpty(estdt))
            {
                string cs = GetConnectionString();
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SPTransPortation";
                cmd.Parameters.AddWithValue("@orderno", Item);
                cmd.Parameters.AddWithValue("@transqty", Convert.ToInt16(transqty));
                cmd.Parameters.AddWithValue("@vno", vno);
                cmd.Parameters.AddWithValue("@transdt", Convert.ToDateTime(tranddt));
                cmd.Parameters.AddWithValue("@transtime", Convert.ToDateTime(transtime));
                cmd.Parameters.AddWithValue("@gno", gno);
                cmd.Parameters.AddWithValue("@estdt", Convert.ToDateTime(estdt));
                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    result = true;
                }
            }
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
                string query = "select item,orderno from tblorders where orderno in(select orderno from tblpurchase where clearstatus=1)";
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
        public static DataTable GetGodownValue()
        {

            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection();
                string cs = GetConnectionString();
                conn = new SqlConnection(cs);
                conn.Open();
                string query = "select GodownNo,GodownName from tblGodowns";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Godown");
                dt = ds.Tables["Godown"];
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
