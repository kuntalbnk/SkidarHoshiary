﻿using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Process;

namespace SkidarHoshiary
{
    public partial class TransportationReport : MetroFramework.Forms.MetroForm
    {
        public TransportationReport()
        {
            InitializeComponent();
        }
       // string cs = @"Data Source=AVIJAN-PC\SQLEXPRESS;Initial Catalog=SkidarHosiaryDB;Integrated Security=True";

        private void TransportationReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource bsource = new BindingSource();
                bsource.DataSource = Process.ReportProcess.GetTransReportProcess();
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
            DataTable dt = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
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
                wb.Worksheets.Add(dt, "TransPortation");
                wb.SaveAs(folderPath + "TransPortationReport.xlsx");
                MessageBox.Show("Successfully Exported. your saved filepath is " + folderPath + "TransPortationReport.xlsx");
            }
        }
    }
}
