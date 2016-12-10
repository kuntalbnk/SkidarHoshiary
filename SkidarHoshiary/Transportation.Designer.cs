namespace SkidarHoshiary
{
    partial class Transportation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbItem = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtpurchaseQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTransportQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtLrNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpOrderDt = new System.Windows.Forms.DateTimePicker();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbGName = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cboCompName = new MetroFramework.Controls.MetroComboBox();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.GVDetl = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GVDetl)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(4, 148);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Model No";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.ItemHeight = 23;
            this.cmbItem.Location = new System.Drawing.Point(80, 148);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(144, 29);
            this.cmbItem.TabIndex = 21;
            this.cmbItem.UseSelectable = true;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(230, 148);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Purchase Qty";
            // 
            // txtpurchaseQty
            // 
            this.txtpurchaseQty.Lines = new string[0];
            this.txtpurchaseQty.Location = new System.Drawing.Point(327, 148);
            this.txtpurchaseQty.MaxLength = 32767;
            this.txtpurchaseQty.Name = "txtpurchaseQty";
            this.txtpurchaseQty.PasswordChar = '\0';
            this.txtpurchaseQty.ReadOnly = true;
            this.txtpurchaseQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpurchaseQty.SelectedText = "";
            this.txtpurchaseQty.Size = new System.Drawing.Size(59, 23);
            this.txtpurchaseQty.TabIndex = 23;
            this.txtpurchaseQty.UseSelectable = true;
            this.txtpurchaseQty.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(392, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Transport Qty";
            // 
            // txtTransportQty
            // 
            this.txtTransportQty.Lines = new string[0];
            this.txtTransportQty.Location = new System.Drawing.Point(493, 148);
            this.txtTransportQty.MaxLength = 32767;
            this.txtTransportQty.Name = "txtTransportQty";
            this.txtTransportQty.PasswordChar = '\0';
            this.txtTransportQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTransportQty.SelectedText = "";
            this.txtTransportQty.Size = new System.Drawing.Size(53, 23);
            this.txtTransportQty.TabIndex = 25;
            this.txtTransportQty.UseSelectable = true;
            this.txtTransportQty.UseStyleColors = true;
            this.txtTransportQty.TextChanged += new System.EventHandler(this.txtTransportQty_TextChanged);
            this.txtTransportQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransportQty_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "L R No";
            // 
            // txtLrNo
            // 
            this.txtLrNo.Lines = new string[0];
            this.txtLrNo.Location = new System.Drawing.Point(79, 71);
            this.txtLrNo.MaxLength = 32767;
            this.txtLrNo.Name = "txtLrNo";
            this.txtLrNo.PasswordChar = '\0';
            this.txtLrNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLrNo.SelectedText = "";
            this.txtLrNo.Size = new System.Drawing.Size(323, 23);
            this.txtLrNo.TabIndex = 27;
            this.txtLrNo.UseSelectable = true;
            this.txtLrNo.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(726, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Transport Date";
            // 
            // dtpOrderDt
            // 
            this.dtpOrderDt.CustomFormat = "dd-MM-yyyy HH:MM";
            this.dtpOrderDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDt.Location = new System.Drawing.Point(833, 74);
            this.dtpOrderDt.Name = "dtpOrderDt";
            this.dtpOrderDt.Size = new System.Drawing.Size(307, 20);
            this.dtpOrderDt.TabIndex = 29;
            this.dtpOrderDt.Value = new System.DateTime(2016, 11, 15, 0, 0, 0, 0);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(552, 148);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(101, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Godown Name";
            // 
            // cmbGName
            // 
            this.cmbGName.FormattingEnabled = true;
            this.cmbGName.ItemHeight = 23;
            this.cmbGName.Location = new System.Drawing.Point(659, 148);
            this.cmbGName.Name = "cmbGName";
            this.cmbGName.Size = new System.Drawing.Size(106, 29);
            this.cmbGName.TabIndex = 33;
            this.cmbGName.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1065, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1065, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(4, 110);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1136, 23);
            this.metroTile1.TabIndex = 36;
            this.metroTile1.Text = "Transport Details";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(771, 152);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Company Name";
            // 
            // cboCompName
            // 
            this.cboCompName.FormattingEnabled = true;
            this.cboCompName.ItemHeight = 23;
            this.cboCompName.Location = new System.Drawing.Point(885, 148);
            this.cboCompName.Name = "cboCompName";
            this.cboCompName.Size = new System.Drawing.Size(106, 29);
            this.cboCompName.TabIndex = 38;
            this.cboCompName.UseSelectable = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1051, 152);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 39;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseSelectable = true;
            this.btnInsert.UseStyleColors = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1009, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Modify";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseStyleColors = true;
            // 
            // GVDetl
            // 
            this.GVDetl.AllowUserToResizeRows = false;
            this.GVDetl.BackgroundColor = System.Drawing.Color.Silver;
            this.GVDetl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVDetl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVDetl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVDetl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GVDetl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVDetl.DefaultCellStyle = dataGridViewCellStyle2;
            this.GVDetl.EnableHeadersVisualStyles = false;
            this.GVDetl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GVDetl.GridColor = System.Drawing.Color.Silver;
            this.GVDetl.Location = new System.Drawing.Point(2, 183);
            this.GVDetl.Name = "GVDetl";
            this.GVDetl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVDetl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GVDetl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVDetl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVDetl.Size = new System.Drawing.Size(1138, 188);
            this.GVDetl.TabIndex = 41;
            // 
            // Transportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 434);
            this.Controls.Add(this.GVDetl);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cboCompName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbGName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtpOrderDt);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtLrNo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTransportQty);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtpurchaseQty);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.metroLabel6);
            this.Name = "Transportation";
            this.Text = "Transportation";
            this.Load += new System.EventHandler(this.Transportation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDetl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtpurchaseQty;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTransportQty;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtLrNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dtpOrderDt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbGName;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cboCompName;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroGrid GVDetl;
    }
}