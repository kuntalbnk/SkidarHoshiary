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
    public class PrintDAL
    {
        public DataSet GetRepData(string query)
        {

            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection();
                string cs = GetConnectionString();
                conn = new SqlConnection(cs);
                conn.Open();
               // string query = "select a.OrderNo,a.Item from tblOrders a,tblPurchase b where a.OrderNo=b.OrderNo";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                //DataSet ds = new DataSet();
                da.Fill(ds, "repdata");
                // dt = ds.Tables["Order"];
            }
            catch (Exception ex)
            {

            }
            return ds;
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
