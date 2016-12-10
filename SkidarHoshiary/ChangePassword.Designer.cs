namespace SkidarHoshiary
{
    partial class ChangePassword
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNewP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCP = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "New Password";
            // 
            // txtNewP
            // 
            this.txtNewP.Lines = new string[0];
            this.txtNewP.Location = new System.Drawing.Point(153, 73);
            this.txtNewP.MaxLength = 32767;
            this.txtNewP.Name = "txtNewP";
            this.txtNewP.PasswordChar = '.';
            this.txtNewP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewP.SelectedText = "";
            this.txtNewP.Size = new System.Drawing.Size(314, 23);
            this.txtNewP.TabIndex = 8;
            this.txtNewP.UseSelectable = true;
            this.txtNewP.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Confirm Password";
            // 
            // txtCP
            // 
            this.txtCP.Lines = new string[0];
            this.txtCP.Location = new System.Drawing.Point(153, 117);
            this.txtCP.MaxLength = 32767;
            this.txtCP.Name = "txtCP";
            this.txtCP.PasswordChar = '.';
            this.txtCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCP.SelectedText = "";
            this.txtCP.Size = new System.Drawing.Size(314, 23);
            this.txtCP.TabIndex = 10;
            this.txtCP.UseSelectable = true;
            this.txtCP.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Change";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 204);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNewP);
            this.Controls.Add(this.metroLabel2);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNewP;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCP;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}