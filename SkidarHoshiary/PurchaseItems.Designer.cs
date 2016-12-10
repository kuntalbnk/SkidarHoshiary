namespace SkidarHoshiary
{
    partial class PurchaseItems
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
            this.GVPurchaseItems = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVPurchaseItems)).BeginInit();
            this.SuspendLayout();
            // 
            // GVPurchaseItems
            // 
            this.GVPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPurchaseItems.Location = new System.Drawing.Point(23, 77);
            this.GVPurchaseItems.Name = "GVPurchaseItems";
            this.GVPurchaseItems.Size = new System.Drawing.Size(326, 314);
            this.GVPurchaseItems.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(274, 408);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PurchaseItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 443);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.GVPurchaseItems);
            this.Name = "PurchaseItems";
            this.Text = "Purchase Items";
            this.Load += new System.EventHandler(this.PurchaseItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVPurchaseItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVPurchaseItems;
        private System.Windows.Forms.Button btnPrint;
    }
}