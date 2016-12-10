using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ReportDAL
    {
        public static DataTable GetGodownReportData()
        {
            DataTable dt = new DataTable();
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand("select GodownName,GodownsLocation,GodownsPin as 'Pin Code',ContactNo from tblGodowns", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ec.Message);
            }
            return dt;
        }
        public static DataTable GetOrderReportData()
        {
            DataTable dt = new DataTable();
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand("Select Item,Qty as 'Order Qty',cast(Orderdt as nvarchar) as 'Order Date',orderid as 'Order No',case when orderstatus=0 then 'Order Purchased' else 'Still Remains' end as 'Order Status' from tblOrders", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ec.Message);
            }
            return dt;
        }
        public static DataTable GetCompanyReportData()
        {
            DataTable dt = new DataTable();
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand("select CompName,Address,PinCode,ContactNo,EmailId,VATNo from tblCompanies", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ec.Message);
            }
            return dt;
        }
        public static DataTable GetPurchaseReportData()
        {
            DataTable dt = new DataTable();
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand("select CompanyName,ContactPerson,ContactNo,Item,PurchaseQty as 'Purchased Qty', tblpurchase.Rate, WBTax, CST, ItemCost, tblpurchase.NetAmt, cast(PurchaseDt as nvarchar) as 'Purchase Date' from tblPurchase,tblOrders where tblPurchase.OrderNo = tblOrders.OrderNo", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ec.Message);
            }
            return dt;
        }
        public static DataTable GetTransReportData()
        {
            DataTable dt = new DataTable();
            try
            {
                string sc = GetConnectionString();
                SqlConnection con = new SqlConnection(sc);
                SqlCommand cmd = new SqlCommand("select GodownName,Item,transqty as 'Qty',vno as 'Vechicle No',cast(transdt as nvarchar) as 'Date',cast(transtime as nvarchar) as 'Time',cast(estdt as nvarchar) as 'Estimated Delivery Date' from tblTrans, tblOrders, tblGodowns where tblTrans.OrderNo = tblOrders.OrderNo and tbltrans.godownno=tblGodowns.GodownNo", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ec.Message);
            }
            return dt;
        }
        private static string GetConnectionString()
        {
            string cs = ConfigurationManager.ConnectionStrings["conntionstring1"].ConnectionString;
            return cs;
        }
    }
}
