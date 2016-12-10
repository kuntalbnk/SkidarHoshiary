namespace SkidarHoshiary
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.master = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godowns = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.purchase = new System.Windows.Forms.ToolStripMenuItem();
            this.transportation = new System.Windows.Forms.ToolStripMenuItem();
            this.sales = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrRept = new System.Windows.Forms.ToolStripMenuItem();
            this.PurRept = new System.Windows.Forms.ToolStripMenuItem();
            this.TransRept = new System.Windows.Forms.ToolStripMenuItem();
            this.CmpRept = new System.Windows.Forms.ToolStripMenuItem();
            this.GoRept = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCompName = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.master,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.printToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // master
            // 
            this.master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.godowns});
            this.master.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(71, 23);
            this.master.Text = "Master";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // godowns
            // 
            this.godowns.Name = "godowns";
            this.godowns.Size = new System.Drawing.Size(141, 24);
            this.godowns.Text = "Godowns";
            this.godowns.Click += new System.EventHandler(this.godowns_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order,
            this.purchase,
            this.transportation,
            this.sales});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // order
            // 
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(176, 24);
            this.order.Text = "Order";
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // purchase
            // 
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(176, 24);
            this.purchase.Text = "Purchase";
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // transportation
            // 
            this.transportation.Name = "transportation";
            this.transportation.Size = new System.Drawing.Size(176, 24);
            this.transportation.Text = "Transportation";
            this.transportation.Click += new System.EventHandler(this.transportation_Click);
            // 
            // sales
            // 
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(176, 24);
            this.sales.Text = "Sales";
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrRept,
            this.PurRept,
            this.TransRept,
            this.CmpRept,
            this.GoRept,
            this.testToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // OrRept
            // 
            this.OrRept.Name = "OrRept";
            this.OrRept.Size = new System.Drawing.Size(176, 24);
            this.OrRept.Text = "Order";
            this.OrRept.Click += new System.EventHandler(this.OrRept_Click);
            // 
            // PurRept
            // 
            this.PurRept.Name = "PurRept";
            this.PurRept.Size = new System.Drawing.Size(176, 24);
            this.PurRept.Text = "Purchase";
            this.PurRept.Click += new System.EventHandler(this.PurRept_Click);
            // 
            // TransRept
            // 
            this.TransRept.Name = "TransRept";
            this.TransRept.Size = new System.Drawing.Size(176, 24);
            this.TransRept.Text = "Transportation";
            this.TransRept.Click += new System.EventHandler(this.TransRept_Click);
            // 
            // CmpRept
            // 
            this.CmpRept.Name = "CmpRept";
            this.CmpRept.Size = new System.Drawing.Size(176, 24);
            this.CmpRept.Text = "Company";
            this.CmpRept.Click += new System.EventHandler(this.CmpRept_Click);
            // 
            // GoRept
            // 
            this.GoRept.Name = "GoRept";
            this.GoRept.Size = new System.Drawing.Size(176, 24);
            this.GoRept.Text = "Godowns";
            this.GoRept.Click += new System.EventHandler(this.GoRept_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Visible = false;
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.printToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.createNewUsers});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // createNewUsers
            // 
            this.createNewUsers.Name = "createNewUsers";
            this.createNewUsers.Size = new System.Drawing.Size(201, 24);
            this.createNewUsers.Text = "Create New Users";
            this.createNewUsers.Click += new System.EventHandler(this.createNewUsers_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCompName.Location = new System.Drawing.Point(162, 31);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(0, 0);
            this.lblCompName.Style = MetroFramework.MetroColorStyle.Black;
            this.lblCompName.TabIndex = 1;
            this.lblCompName.UseStyleColors = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1261, 462);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Welcome";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem master;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem godowns;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem purchase;
        private System.Windows.Forms.ToolStripMenuItem transportation;
        private System.Windows.Forms.ToolStripMenuItem sales;
        private MetroFramework.Controls.MetroLabel lblCompName;
        private System.Windows.Forms.ToolStripMenuItem OrRept;
        private System.Windows.Forms.ToolStripMenuItem PurRept;
        private System.Windows.Forms.ToolStripMenuItem TransRept;
        private System.Windows.Forms.ToolStripMenuItem CmpRept;
        private System.Windows.Forms.ToolStripMenuItem GoRept;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUsers;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
    }
}