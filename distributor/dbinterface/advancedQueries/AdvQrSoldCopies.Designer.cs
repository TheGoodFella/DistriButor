namespace dbinterface.advancedQueries
{
    partial class AdvQrSoldCopies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvQrSoldCopies));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btn = new System.Windows.Forms.ToolStripButton();
            this.checkInvoice = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(682, 456);
            this.dataGridView.TabIndex = 11;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(682, 25);
            this.toolStrip.TabIndex = 12;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btn
            // 
            this.btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(47, 22);
            this.btn.Text = "refresh";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // checkInvoice
            // 
            this.checkInvoice.AutoSize = true;
            this.checkInvoice.Location = new System.Drawing.Point(63, 5);
            this.checkInvoice.Name = "checkInvoice";
            this.checkInvoice.Size = new System.Drawing.Size(66, 17);
            this.checkInvoice.TabIndex = 13;
            this.checkInvoice.Text = "invoiced";
            this.checkInvoice.UseVisualStyleBackColor = true;
            this.checkInvoice.CheckedChanged += new System.EventHandler(this.checkInvoice_CheckedChanged);
            // 
            // AdvQrSoldCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 481);
            this.Controls.Add(this.checkInvoice);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvQrSoldCopies";
            this.Text = "Show invoiced copies";
            this.Load += new System.EventHandler(this.AdvQrSoldCopies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btn;
        private System.Windows.Forms.CheckBox checkInvoice;
    }
}