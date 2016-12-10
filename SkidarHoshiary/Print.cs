using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Process;
using DAL;
using CrystalDecisions.CrystalReports.Engine;
using SkidarHoshiary.OrderReport1;
using System.Data.SqlClient;
using System.Configuration;

namespace SkidarHoshiary
{
    public partial class Print : MetroFramework.Forms.MetroForm
    {
        //string SqlInf, stReport;
        //ReportDocument m_Report;
        //TextObject objTextbox;
        //Boolean MastReport;
        //Section objSection;
        public Print()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Print_Load(object sender, EventArgs e)
        {
            // PrintBO ObjPrintBO = new PrintBO();
            // PrintDAL ObjPrintDAL = new PrintDAL();
            // switch (CommonConfig.selectedMenu)
            // {

            //     case "Sales":
            //         m_Report = new CrystalReport2();
            //         SqlInf = "select a.CustomarName,a.CustMob,a.OrderNo,c.Item,a.SalesQty,a.SalesDt,a.SalesRate,a.NetAmt from tblSales a,tblPurchase b,tblOrders c where a.OrderNo=b.OrderNo and b.OrderNo=c.OrderNo and a.OrderNo in (" + CommonConfig.mPrintDataStr + ");";
            //         stReport = "Sales Recipt";
            //         MastReport = true;
            //         break;


            //     case "RepPurchase":
            //         m_Report = new CrystalReport1();
            //         SqlInf = "select b.Item,a.PurchaseDt,a.purchaseqty,a.rate,a.netamt from tblPurchase a,tblOrders b where a.OrderNo=b.OrderNo AND a.orderno IN (" + CommonConfig.mPrintDataStr + ");";
            //         stReport = "Purchase";
            //         MastReport = true;
            //         break;
            // }
            // DataSet MyDataSet = new DataSet();
            //// ObjPrintBO.Query = SqlInf;
            // MyDataSet = ObjPrintDAL.GetRepData(SqlInf);

            // m_Report.SetDataSource(MyDataSet.Tables["repdata"].DefaultView);
            // m_Report.Refresh();

            // switch (CommonConfig.selectedMenu)
            // {
            //     case "":
            //         objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["Company"];
            //         objTextbox.Text = CommonConfig.CompanyName;

            //         objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["Address"];
            //         objTextbox.Text = CommonConfig.CompanyAddress;
            //         break;

            //     default:
            //         objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["Company"];
            //         objTextbox.Text = CommonConfig.CompanyName;

            //         objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["Address"];
            //         objTextbox.Text = CommonConfig.CompanyAddress;

            //         objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["date"];
            //        objTextbox.Text = CommonConfig.date.ToString("dd-MM-yyyy");


            //         objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["Head"];
            //         objTextbox.Text = stReport;

            //         //objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["PhoneFaxEmail"];
            //         //objTextbox.Text = CommonConfig.PhoneFaxEmail;
            //         break;
            // }
            // switch (CommonConfig.selectedMenu)
            // {
            //     //case "RepPurchase":
            //     //    objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["SDate"];
            //     //    objTextbox.Text = CommonConfig.mPassStartDt.ToString("dd-MM-yyyy");
            //     //    objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["EDate"];
            //     //    objTextbox.Text = CommonConfig.mPassEndDt.ToString("dd-MM-yyyy");
            //     //    objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["PDate"];
            //     //    objTextbox.Text = CommonConfig.mPassRptDt.ToString("dd-MM-yyyy");

            //     //    break;


            // }

            // crystalReportViewer1.ReportSource = null;
            // crystalReportViewer1.ReportSource = m_Report;
            // crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // crystalReportViewer1.Zoom(100);
            // crystalReportViewer1.RefreshReport();
            Order obj = new Order();
            string OrderNo = Order.orderValue.ToString();
            GenarateOrderBills crystalReport = new GenarateOrderBills();
            OrderBillDataSet dsCustomers = GetData(OrderNo);
            crystalReport.SetDataSource(dsCustomers);
            this.crystalReportViewer1.ReportSource = crystalReport;
            this.crystalReportViewer1.RefreshReport();
        }
        private OrderBillDataSet GetData(string OrderNo)
        {
            //string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sample Project\Asp.net\CrystalReport\CrystalReport_CS\Database1.mdf;Integrated Security=True";
            string sc = GetConnectionString();
            OrderBillDataSet dsCustomers = new OrderBillDataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(sc))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * from tblOrders where OrderNo='" + OrderNo + "'order by OrderID desc", con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            sda.Fill(dsCustomers, "DataTable1");
                        }
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            return dsCustomers;
        }
        private static string GetConnectionString()
        {
            string cs = ConfigurationManager.ConnectionStrings["conntionstring1"].ConnectionString;
            return cs;
        }
    }
}
