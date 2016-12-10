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

namespace SkidarHoshiary
{
    public partial class PurchaseItems : MetroFramework.Forms.MetroForm
    {
        DataTable DT = new DataTable();
        MasterDAL objmaster = new MasterDAL();
        String mTempMenu;
        public PurchaseItems()
        {
            InitializeComponent();
        }

        private void PurchaseItems_Load(object sender, EventArgs e)
        {
            Load_Grid();
        }
        private void Load_Grid()
        {
            GVPurchaseItems.AutoGenerateColumns = false;
            if (GVPurchaseItems.ColumnCount > 0) { GVPurchaseItems.Columns.Clear(); }

            try
            {
                //  Add Form Item
                switch (CommonConfig.selectedMenu)
                {
                    case "Sales":
                        this.Text = "sales Print Module";
                        break;
                    case "Purchase":
                        this.Text = "Purchase Print Module";
                        break;
                }

                //  Add Column
                switch (CommonConfig.selectedMenu)
                {
                    case "Sales":
                        GridColAdd(GVPurchaseItems, "OrderNo", "OrderNo", 0, false, 0);
                        GridColAdd(GVPurchaseItems, "Item", "Item", 80, true, 2);

                        GVPurchaseItems.Columns[0].Visible = false;
                        break;
                    case "Purchase":
                        GridColAdd(GVPurchaseItems, "OrderNo", "OrderNo", 0, false, 0);
                        GridColAdd(GVPurchaseItems, "Item", "Item", 80, true, 2);

                        GVPurchaseItems.Columns[0].Visible = false;
                        break;
                }

                DataGridViewCheckBoxColumn Chk = new DataGridViewCheckBoxColumn();
                Chk.HeaderText = "Select";
                Chk.Name = "CheckBox";
                GVPurchaseItems.Columns.Insert(0, Chk);


                Load_Grid_Data("PrintPopulate");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        private void Load_Grid_Data(string Action)
        {
            this.GVPurchaseItems.DataSource = null;
            this.GVPurchaseItems.Rows.Clear();
            this.GVPurchaseItems.Refresh();
            //GV.Rows.Clear();
            switch (CommonConfig.selectedMenu)
            {
                case "Sales":
                    //InvSalesBO objInvSales = new InvSalesBO();
                    //objInvSales.SearchKey = txtSearch.Text.Trim();
                    DT = objmaster.GetSalesItems().Tables["sales"];

                    break;
                case "Purchase":
                   // PurchaseProcess objInvPurchase = new PurchaseProcess();
                   // objInvPurchase.SearchKey = txtSearch.Text.Trim();
                    DT = objmaster.GetPurchaseItems().Tables["purchase"];

                    break;
            }
            GVPurchaseItems.DataSource = DT;

        }
        private void GridColAdd(Object Component, String ColumnName, String ColumnHeading, int ColumnWidth, Boolean ColumnVisibility, int FormatStyle)
        {
            DataGridViewColumn GVColumn;
            GVColumn = new DataGridViewTextBoxColumn();
            GVColumn.DataPropertyName = ColumnName;
            GVColumn.HeaderText = ColumnHeading;
            GVColumn.Width = ColumnWidth;
            GVColumn.Visible = ColumnVisibility;
            if (FormatStyle == 1)
            {
                GVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                GVColumn.DefaultCellStyle.Format = "n";
            }
            else if (FormatStyle == 2)
            {
                GVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                GVColumn.DefaultCellStyle.Format = "dd-MM-yyyy";
            }
            else if (FormatStyle == 3)
            {
                GVColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                GVColumn.DefaultCellStyle.Format = "HH:mm:ss";
            }
            ((DataGridView)Component).Columns.Add(GVColumn);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CommonConfig.mPrintDataStr = "";
            if (GVPurchaseItems.Rows.Count != 0)
            {

                foreach (DataGridViewRow row in GVPurchaseItems.Rows)
                {

                    bool isSelected = Convert.ToBoolean(row.Cells["CheckBox"].Value);
                    if (isSelected)
                    {
                        CommonConfig.mPrintDataStr = "'" + row.Cells[1].Value.ToString() + "'," + CommonConfig.mPrintDataStr;
                    }
                }
            }
            if (CommonConfig.mPrintDataStr.Trim().Length == 0)
            {
                CommonConfig.mPrintDataStr = "";
                MessageBox.Show("Please Select Value");
            }
            else
            {
                //CommonConfig.mPassStartDt = metroDTPStartDate.Value;
                //CommonConfig.mPassEndDt = metroDTPEndDate.Value;
                //CommonConfig.mPassRptDt = metroDTPProsDate.Value;
                CommonConfig.mPrintDataStr = CommonConfig.mPrintDataStr.Substring(0, CommonConfig.mPrintDataStr.Length - 1);
                mTempMenu = CommonConfig.selectedMenu;
                Print ObjPrint = new Print();

                switch (CommonConfig.selectedMenu)
                {
                    case "Sales":
                        CommonConfig.selectedMenu = "RepSales";
                        ObjPrint.ShowDialog();
                        ObjPrint.Dispose();
                        CommonConfig.selectedMenu = mTempMenu;
                        break;
                    case "Purchase":
                        CommonConfig.selectedMenu = "RepPurchase";
                        ObjPrint.ShowDialog();
                        ObjPrint.Dispose();
                        CommonConfig.selectedMenu = mTempMenu;
                        break;
                 }
            }
        }
    }
}
