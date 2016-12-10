using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using System.Drawing;
using Process;

namespace SkidarHoshiary
{
    public partial class OrderReport : MetroFramework.Forms.MetroForm
    {
        //private DataGridPrinter dataGridPrinter1 = null;
       // BindingSource bsource = new BindingSource();
        DataTable dt = new DataTable();
        public OrderReport()
        {
            dt = new DataTable();
            InitializeComponent();
        }
       // string cs = @"Data Source=AVIJAN-PC\SQLEXPRESS;Initial Catalog=SkidarHosiaryDB;Integrated Security=True";

        private void OrderReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource bsource = new BindingSource();
                bsource.DataSource = Process.ReportProcess.GetOrderReportProcess();
                dataGridView1.DataSource = bsource;
                dataGridView1.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating DataTable
            DataTable dt1 = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt1.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt1.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt1.Rows[dt1.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            //Exporting to Excel
            string folderPath = "C:\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt1, "Orders");
                wb.SaveAs(folderPath + "OrderReport.xlsx");
                MessageBox.Show("Successfully Exported. your saved filepath is " + folderPath + "OrderReport.xlsx");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(cs);
            //SqlCommand cmd = new SqlCommand("Select Item,Qty as 'Order Qty',cast(Orderdt as nvarchar) as 'Order Date',cast(ordertime as nvarchar) as 'Order Time',case when orderstatus=0 then 'Order Purchased' else 'Still Remains' end as 'Order Status' from tblOrders", con);
            //con.Open();
            //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adapt.Fill(ds);
            //con.Close();
            //int count = ds.Tables[0].Rows.Count;
            //if (count == 1)
            //{
                //dataGridPrinter1 = new DataGridPrinter(dataGridView1, printDocument1,dt);
                //this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
                printDocument1.Print();
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Graphics g = e.Graphics;
            //DrawTopLabel(g);
            //bool more = dataGridPrinter1.DrawDataGrid(g);
            //if (more == true)
            //{
            //    e.HasMorePages = true;
            //    dataGridPrinter1.PageNumber++;
            //}
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm,60, 80);
        }
        void DrawTopLabel(Graphics g)
        {
            int TopMargin = printDocument1.DefaultPageSettings.Margins.Top;

            //g.FillRectangle(new SolidBrush(label1.BackColor), label1.Location.X, label1.Location.Y + TopMargin, label1.Size.Width, label1.Size.Height);
            //g.DrawString(label1.Text, label1.Font, new SolidBrush(label1.ForeColor), label1.Location.X + 50, label1.Location.Y + TopMargin, new StringFormat());
        }
    }
}
