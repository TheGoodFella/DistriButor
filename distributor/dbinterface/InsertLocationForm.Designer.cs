namespace dbinterface
{
    partial class InsertLocationForm
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
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(171, 79);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(151, 20);
            this.txtProvince.TabIndex = 2;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(114, 82);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(51, 13);
            this.lblProvince.TabIndex = 20;
            this.lblProvince.Text = "province:";
            // 
            // btnADD
            // 
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Location = new System.Drawing.Point(131, 130);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(100, 23);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "add location";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(171, 53);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(151, 20);
            this.txtRegion.TabIndex = 1;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(171, 27);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(151, 20);
            this.txtCountry.TabIndex = 0;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(126, 56);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(39, 13);
            this.lblRegion.TabIndex = 12;
            this.lblRegion.Text = "region:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(120, 30);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(45, 13);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "country:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(237, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMySQL});
            this.statusStrip.Location = new System.Drawing.Point(0, 180);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(469, 22);
            this.statusStrip.TabIndex = 21;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMySQL
            // 
            this.statusMySQL.Name = "statusMySQL";
            this.statusMySQL.Size = new System.Drawing.Size(36, 17);
            this.statusMySQL.Text = "ready";
            // 
            // InsertLocationForm
            // 
            this.AcceptButton = this.btnADD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 202);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblCountry);
            this.Name = "InsertLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert a new Location";
            this.Load += new System.EventHandler(this.InsertLocationForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMySQL;
    }
}