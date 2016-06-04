namespace dbinterface.advancedQueries
{
    partial class AdvQrTasksByType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvQrTasksByType));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblTaskType = new System.Windows.Forms.ToolStripLabel();
            this.comboTaskType = new System.Windows.Forms.ToolStripComboBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTaskType,
            this.comboTaskType,
            this.btnSearch,
            this.toolStripSeparator1,
            this.btn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(841, 25);
            this.toolStrip.TabIndex = 12;
            this.toolStrip.Text = "toolStrip1";
            // 
            // lblTaskType
            // 
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(57, 22);
            this.lblTaskType.Text = "task type:";
            // 
            // comboTaskType
            // 
            this.comboTaskType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboTaskType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTaskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(121, 25);
            this.comboTaskType.SelectedIndexChanged += new System.EventHandler(this.comboTaskType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 22);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(841, 424);
            this.dataGridView.TabIndex = 11;
            // 
            // AdvQrTasksByType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 449);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvQrTasksByType";
            this.Text = "Search tasks by type";
            this.Load += new System.EventHandler(this.AdvQrTasksByType_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel lblTaskType;
        private System.Windows.Forms.ToolStripComboBox comboTaskType;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}