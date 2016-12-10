using System;
using System.Data;
using System.Data.SqlClient;

namespace SkidarHoshiary
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company objComp = new Company();
            objComp.MdiParent = this;
            objComp.Show();

        }

        private bool IsFormOpen(string text)
        {
            throw new NotImplementedException();
        }

        private void godowns_Click(object sender, EventArgs e)
        {
            Godown objGodown = new Godown();
            objGodown.MdiParent = this;
            objGodown.Show();
        }

        private void order_Click(object sender, EventArgs e)
        {
            Order objOrder = new Order();
            objOrder.MdiParent = this;
            objOrder.Show();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            Purchase objPurchase = new Purchase();
            objPurchase.MdiParent = this;
            objPurchase.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }

        private void transportation_Click(object sender, EventArgs e)
        {
            Transportation objTrans = new Transportation();
            objTrans.MdiParent = this;
            objTrans.Show();
        }

        private void OrRept_Click(object sender, EventArgs e)
        {
            OrderReport objOR = new OrderReport();
            objOR.MdiParent = this;
            objOR.Show();
        }

        private void PurRept_Click(object sender, EventArgs e)
        {
            PurchaseReport objPR = new PurchaseReport();
            objPR.MdiParent = this;
            objPR.Show();
        }

        private void TransRept_Click(object sender, EventArgs e)
        {
            TransportationReport objTR = new TransportationReport();
            objTR.MdiParent = this;
            objTR.Show();
        }

        private void CmpRept_Click(object sender, EventArgs e)
        {
            CompanyReport objCR = new CompanyReport();
            objCR.MdiParent = this;
            objCR.Show();
        }

        private void GoRept_Click(object sender, EventArgs e)
        {
            GodownsReport objGR = new GodownsReport();
            objGR.MdiParent = this;
            objGR.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword objPass = new ChangePassword();
            objPass.MdiParent = this;
            objPass.Show();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            Sales objPass = new Sales();
            objPass.MdiParent = this;
            objPass.Show();
        }

        private void createNewUsers_Click(object sender, EventArgs e)
        {
            UserRights objRight = new UserRights();
            objRight.MdiParent = this;
            objRight.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonConfig.selectedMenu = "Purchase";
            PurchaseItems objpurprint = new PurchaseItems();
            objpurprint.MdiParent = this;
            objpurprint.Show();

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonConfig.selectedMenu = "Sales";
            PurchaseItems objpurprint = new PurchaseItems();
            objpurprint.MdiParent = this;
            objpurprint.Show();

        }
    }
}
