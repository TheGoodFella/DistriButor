namespace dbinterface
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsPhoneN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQueryLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQueryPhones = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripInsWorker = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(637, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(326, 195);
            this.dataGridView.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripDatabase,
            this.menuStripData});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(975, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
            // 
            // menuStripDatabase
            // 
            this.menuStripDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripLogin});
            this.menuStripDatabase.Name = "menuStripDatabase";
            this.menuStripDatabase.Size = new System.Drawing.Size(67, 20);
            this.menuStripDatabase.Text = "Database";
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Size = new System.Drawing.Size(104, 22);
            this.menuStripLogin.Text = "Login";
            this.menuStripLogin.Click += new System.EventHandler(this.menuStripLogin_Click);
            // 
            // menuStripData
            // 
            this.menuStripData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripInsert,
            this.menuStripQueries});
            this.menuStripData.Name = "menuStripData";
            this.menuStripData.Size = new System.Drawing.Size(43, 20);
            this.menuStripData.Text = "Data";
            // 
            // menuStripInsert
            // 
            this.menuStripInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripInsLocations,
            this.menuStripInsPhoneN,
            this.menuStripInsWorker});
            this.menuStripInsert.Name = "menuStripInsert";
            this.menuStripInsert.Size = new System.Drawing.Size(152, 22);
            this.menuStripInsert.Text = "Insert";
            // 
            // menuStripInsLocations
            // 
            this.menuStripInsLocations.Name = "menuStripInsLocations";
            this.menuStripInsLocations.Size = new System.Drawing.Size(153, 22);
            this.menuStripInsLocations.Text = "Locations";
            this.menuStripInsLocations.Click += new System.EventHandler(this.menuStripInsLocations_Click);
            // 
            // menuStripInsPhoneN
            // 
            this.menuStripInsPhoneN.Name = "menuStripInsPhoneN";
            this.menuStripInsPhoneN.Size = new System.Drawing.Size(153, 22);
            this.menuStripInsPhoneN.Text = "Phone number";
            this.menuStripInsPhoneN.Click += new System.EventHandler(this.menuStripInsPhoneN_Click);
            // 
            // menuStripQueries
            // 
            this.menuStripQueries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripQueryLocations,
            this.menuStripQueryPhones});
            this.menuStripQueries.Name = "menuStripQueries";
            this.menuStripQueries.Size = new System.Drawing.Size(152, 22);
            this.menuStripQueries.Text = "Queries";
            // 
            // menuStripQueryLocations
            // 
            this.menuStripQueryLocations.Name = "menuStripQueryLocations";
            this.menuStripQueryLocations.Size = new System.Drawing.Size(158, 22);
            this.menuStripQueryLocations.Text = "Locations";
            this.menuStripQueryLocations.Click += new System.EventHandler(this.menuStripQueryLocations_Click);
            // 
            // menuStripQueryPhones
            // 
            this.menuStripQueryPhones.Name = "menuStripQueryPhones";
            this.menuStripQueryPhones.Size = new System.Drawing.Size(158, 22);
            this.menuStripQueryPhones.Text = "Phone numbers";
            this.menuStripQueryPhones.Click += new System.EventHandler(this.menuStripQueryPhones_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMySQL});
            this.statusStrip.Location = new System.Drawing.Point(0, 452);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(975, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMySQL
            // 
            this.statusMySQL.Name = "statusMySQL";
            this.statusMySQL.Size = new System.Drawing.Size(36, 17);
            this.statusMySQL.Text = "ready";
            // 
            // menuStripInsWorker
            // 
            this.menuStripInsWorker.Name = "menuStripInsWorker";
            this.menuStripInsWorker.Size = new System.Drawing.Size(153, 22);
            this.menuStripInsWorker.Text = "Worker";
            this.menuStripInsWorker.Click += new System.EventHandler(this.menuStripInsWorker_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 474);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem menuStripData;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsert;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsLocations;
        private System.Windows.Forms.ToolStripMenuItem menuStripQueries;
        private System.Windows.Forms.ToolStripMenuItem menuStripQueryLocations;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMySQL;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsPhoneN;
        private System.Windows.Forms.ToolStripMenuItem menuStripQueryPhones;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsWorker;
    }
}

