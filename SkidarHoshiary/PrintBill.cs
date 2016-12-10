using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Process;
using DAL;
using CrystalDecisions.CrystalReports.Engine;
using SkidarHoshiary.OrderReport1;
using System.Data.SqlClient;
using System.Configuration;

namespace SkidarHoshiary
{
    public partial class PrintBill : MetroFramework.Forms.MetroForm
    {
        //ReportDocument m_Report;
        //TextObject objTextbox;
        //DateTime dt = DateTime.Now;
        public PrintBill()
        {
            InitializeComponent();
        }

        private void PrintBill_Load(object sender, EventArgs e)
        {
            Sales obj = new Sales();
            string OrderNo = Sales.billno1.ToString();
            Bill crystalReport = new Bill();
            DataSet1 dsCustomers = GetData(OrderNo);
            crystalReport.SetDataSource(dsCustomers);
            this.crystalReportViewer1.ReportSource = crystalReport;
            //objTextbox = (TextObject)m_Report.ReportDefinition.ReportObjects["txtdate"];
            //objTextbox.Text = dt.ToString("dd-MM-yyyy");
            this.crystalReportViewer1.RefreshReport();
        }
        private DataSet1 GetData(string OrderNo)
        {
            //string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Sample Project\Asp.net\CrystalReport\CrystalReport_CS\Database1.mdf;Integrated Security=True";
            string sc = GetConnectionString();
            DataSet1 dsCustomers = new DataSet1();
            try
            {
                using (SqlConnection con = new SqlConnection(sc))
                {
                    using (SqlCommand cmd = new SqlCommand("select a.BillNo,a.CustomarName,a.CustAddr,a.CustMob,b.Item,a.SalesQty,a.SalesRate,a.NetAmt from tblsales a,tblorders b where a.OrderNo=b.OrderNo and a.BillNo='" + OrderNo + "'", con))
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
