namespace SkidarHoshiary
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpOrderDt = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtOrderNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtFromComp = new MetroFramework.Controls.MetroTextBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.txtAddr = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.cmbItem = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtNetAmt = new MetroFramework.Controls.MetroTextBox();
            this.GVDetl = new MetroFramework.Controls.MetroGrid();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.btnModify = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GVDetl)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 189);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Model No";
            // 
            // txtRate
            // 
            this.txtRate.Lines = new string[0];
            this.txtRate.Location = new System.Drawing.Point(412, 195);
            this.txtRate.MaxLength = 32767;
            this.txtRate.Name = "txtRate";
            this.txtRate.PasswordChar = '\0';
            this.txtRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRate.SelectedText = "";
            this.txtRate.Size = new System.Drawing.Size(94, 23);
            this.txtRate.TabIndex = 8;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.UseSelectable = true;
            this.txtRate.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(267, 195);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(299, 195);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(65, 23);
            this.txtQty.TabIndex = 10;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.UseSelectable = true;
            this.txtQty.UseStyleColors = true;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(413, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Order Date & Time";
            // 
            // dtpOrderDt
            // 
            this.dtpOrderDt.CustomFormat = "dd-MM-yyyy HH:MM";
            this.dtpOrderDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDt.Location = new System.Drawing.Point(534, 75);
            this.dtpOrderDt.Name = "dtpOrderDt";
            this.dtpOrderDt.Size = new System.Drawing.Size(269, 20);
            this.dtpOrderDt.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(825, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(825, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Lines = new string[0];
            this.txtOrderNo.Location = new System.Drawing.Point(96, 71);
            this.txtOrderNo.MaxLength = 32767;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.PasswordChar = '\0';
            this.txtOrderNo.ReadOnly = true;
            this.txtOrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderNo.SelectedText = "";
            this.txtOrderNo.Size = new System.Drawing.Size(288, 23);
            this.txtOrderNo.TabIndex = 19;
            this.txtOrderNo.UseSelectable = true;
            this.txtOrderNo.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(23, 71);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Order No";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(12, 115);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "From Company";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(632, 119);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Contact No";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(306, 119);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Address";
            // 
            // txtFromComp
            // 
            this.txtFromComp.Lines = new string[0];
            this.txtFromComp.Location = new System.Drawing.Point(122, 115);
            this.txtFromComp.MaxLength = 32767;
            this.txtFromComp.Name = "txtFromComp";
            this.txtFromComp.PasswordChar = '\0';
            this.txtFromComp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFromComp.SelectedText = "";
            this.txtFromComp.Size = new System.Drawing.Size(171, 23);
            this.txtFromComp.TabIndex = 24;
            this.txtFromComp.UseSelectable = true;
            this.txtFromComp.UseStyleColors = true;
            // 
            // txtContact
            // 
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(729, 115);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(171, 23);
            this.txtContact.TabIndex = 25;
            this.txtContact.UseSelectable = true;
            this.txtContact.UseStyleColors = true;
            // 
            // txtAddr
            // 
            this.txtAddr.Lines = new string[0];
            this.txtAddr.Location = new System.Drawing.Point(370, 115);
            this.txtAddr.MaxLength = 32767;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.PasswordChar = '\0';
            this.txtAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddr.SelectedText = "";
            this.txtAddr.Size = new System.Drawing.Size(256, 23);
            this.txtAddr.TabIndex = 26;
            this.txtAddr.UseSelectable = true;
            this.txtAddr.UseStyleColors = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 158);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(877, 23);
            this.metroTile1.TabIndex = 27;
            this.metroTile1.Text = "Order Details";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.ItemHeight = 23;
            this.cmbItem.Location = new System.Drawing.Point(96, 189);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(165, 29);
            this.cmbItem.TabIndex = 28;
            this.cmbItem.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(370, 195);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(36, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Rate";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(512, 195);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Net Price";
            // 
            // txtNetAmt
            // 
            this.txtNetAmt.Lines = new string[0];
            this.txtNetAmt.Location = new System.Drawing.Point(582, 195);
            this.txtNetAmt.MaxLength = 32767;
            this.txtNetAmt.Name = "txtNetAmt";
            this.txtNetAmt.PasswordChar = '\0';
            this.txtNetAmt.ReadOnly = true;
            this.txtNetAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetAmt.SelectedText = "";
            this.txtNetAmt.Size = new System.Drawing.Size(102, 23);
            this.txtNetAmt.TabIndex = 32;
            this.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetAmt.UseSelectable = true;
            this.txtNetAmt.UseStyleColors = true;
            // 
            // GVDetl
            // 
            this.GVDetl.AllowUserToResizeRows = false;
            this.GVDetl.BackgroundColor = System.Drawing.Color.Silver;
            this.GVDetl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVDetl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GVDetl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVDetl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GVDetl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVDetl.DefaultCellStyle = dataGridViewCellStyle5;
            this.GVDetl.EnableHeadersVisualStyles = false;
            this.GVDetl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GVDetl.GridColor = System.Drawing.Color.Silver;
            this.GVDetl.Location = new System.Drawing.Point(23, 224);
            this.GVDetl.Name = "GVDetl";
            this.GVDetl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVDetl.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GVDetl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVDetl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVDetl.Size = new System.Drawing.Size(877, 150);
            this.GVDetl.TabIndex = 34;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(638, 393);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(39, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel11.TabIndex = 35;
            this.metroLabel11.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(697, 389);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(203, 23);
            this.txtTotal.TabIndex = 36;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.UseStyleColors = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(769, 192);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 29);
            this.btnInsert.TabIndex = 37;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseSelectable = true;
            this.btnInsert.UseStyleColors = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(697, 192);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 26);
            this.btnModify.TabIndex = 39;
            this.btnModify.Text = "Modify";
            this.btnModify.UseSelectable = true;
            this.btnModify.UseStyleColors = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 464);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.GVDetl);
            this.Controls.Add(this.txtNetAmt);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtFromComp);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpOrderDt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.metroLabel2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDetl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtRate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtpOrderDt;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtOrderNo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtFromComp;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox txtAddr;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroComboBox cmbItem;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtNetAmt;
        private MetroFramework.Controls.MetroGrid GVDetl;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroButton btnModify;
    }
}