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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsPhoneN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsNewsStand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsMagazine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsMagRelase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsTask = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnGoToFirst = new System.Windows.Forms.ToolStripButton();
            this.btnGoToPrevious = new System.Windows.Forms.ToolStripButton();
            this.txtPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.btnGoToNext = new System.Windows.Forms.ToolStripButton();
            this.btnGoToLast = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(975, 403);
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
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.menuStripInsert});
            this.menuStripData.Name = "menuStripData";
            this.menuStripData.Size = new System.Drawing.Size(43, 20);
            this.menuStripData.Text = "Data";
            // 
            // menuStripInsert
            // 
            this.menuStripInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripInsLocations,
            this.menuStripInsPhoneN,
            this.menuStripInsWorker,
            this.menuStripInsNewsStand,
            this.menuStripInsMagazine,
            this.menuStripInsPeriod,
            this.menuStripInsMagRelase,
            this.menuStripInsJob,
            this.menuStripInsTask});
            this.menuStripInsert.Name = "menuStripInsert";
            this.menuStripInsert.Size = new System.Drawing.Size(103, 22);
            this.menuStripInsert.Text = "Insert";
            // 
            // menuStripInsLocations
            // 
            this.menuStripInsLocations.Name = "menuStripInsLocations";
            this.menuStripInsLocations.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuStripInsLocations.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsLocations.Text = "Locations";
            this.menuStripInsLocations.Click += new System.EventHandler(this.menuStripInsLocations_Click);
            // 
            // menuStripInsPhoneN
            // 
            this.menuStripInsPhoneN.Name = "menuStripInsPhoneN";
            this.menuStripInsPhoneN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuStripInsPhoneN.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsPhoneN.Text = "Phone number";
            this.menuStripInsPhoneN.Click += new System.EventHandler(this.menuStripInsPhoneN_Click);
            // 
            // menuStripInsWorker
            // 
            this.menuStripInsWorker.Name = "menuStripInsWorker";
            this.menuStripInsWorker.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuStripInsWorker.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsWorker.Text = "Worker";
            this.menuStripInsWorker.Click += new System.EventHandler(this.menuStripInsWorker_Click);
            // 
            // menuStripInsNewsStand
            // 
            this.menuStripInsNewsStand.Name = "menuStripInsNewsStand";
            this.menuStripInsNewsStand.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStripInsNewsStand.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsNewsStand.Text = "Newsstand";
            this.menuStripInsNewsStand.Click += new System.EventHandler(this.menuStripInsNewsStand_Click);
            // 
            // menuStripInsMagazine
            // 
            this.menuStripInsMagazine.Name = "menuStripInsMagazine";
            this.menuStripInsMagazine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuStripInsMagazine.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsMagazine.Text = "Magazine";
            this.menuStripInsMagazine.Click += new System.EventHandler(this.menuStripInsMagazine_Click);
            // 
            // menuStripInsPeriod
            // 
            this.menuStripInsPeriod.Name = "menuStripInsPeriod";
            this.menuStripInsPeriod.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuStripInsPeriod.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsPeriod.Text = "Period";
            this.menuStripInsPeriod.Click += new System.EventHandler(this.menuStripInsPeriod_Click);
            // 
            // menuStripInsMagRelase
            // 
            this.menuStripInsMagRelase.Name = "menuStripInsMagRelase";
            this.menuStripInsMagRelase.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.menuStripInsMagRelase.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsMagRelase.Text = "Magazine new relase";
            this.menuStripInsMagRelase.Click += new System.EventHandler(this.menuStripInsMagRelase_Click);
            // 
            // menuStripInsJob
            // 
            this.menuStripInsJob.Name = "menuStripInsJob";
            this.menuStripInsJob.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.menuStripInsJob.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsJob.Text = "Job";
            this.menuStripInsJob.Click += new System.EventHandler(this.menuStripInsJob_Click);
            // 
            // menuStripInsTask
            // 
            this.menuStripInsTask.Name = "menuStripInsTask";
            this.menuStripInsTask.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuStripInsTask.Size = new System.Drawing.Size(289, 22);
            this.menuStripInsTask.Text = "Task";
            this.menuStripInsTask.Click += new System.EventHandler(this.menuStripInsTask_Click);
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
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox,
            this.btnRefresh,
            this.btnGoToFirst,
            this.btnGoToPrevious,
            this.txtPositionItem,
            this.btnGoToNext,
            this.btnGoToLast,
            this.btnDelete});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(975, 25);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(150, 25);
            this.toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(47, 22);
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGoToFirst
            // 
            this.btnGoToFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGoToFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToFirst.Image")));
            this.btnGoToFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToFirst.Name = "btnGoToFirst";
            this.btnGoToFirst.Size = new System.Drawing.Size(27, 22);
            this.btnGoToFirst.Text = "<<";
            // 
            // btnGoToPrevious
            // 
            this.btnGoToPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGoToPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToPrevious.Image")));
            this.btnGoToPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToPrevious.Name = "btnGoToPrevious";
            this.btnGoToPrevious.Size = new System.Drawing.Size(23, 22);
            this.btnGoToPrevious.Text = "<";
            // 
            // txtPositionItem
            // 
            this.txtPositionItem.Name = "txtPositionItem";
            this.txtPositionItem.Size = new System.Drawing.Size(100, 25);
            // 
            // btnGoToNext
            // 
            this.btnGoToNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGoToNext.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToNext.Image")));
            this.btnGoToNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToNext.Name = "btnGoToNext";
            this.btnGoToNext.Size = new System.Drawing.Size(23, 22);
            this.btnGoToNext.Text = ">";
            // 
            // btnGoToLast
            // 
            this.btnGoToLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGoToLast.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToLast.Image")));
            this.btnGoToLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToLast.Name = "btnGoToLast";
            this.btnGoToLast.Size = new System.Drawing.Size(27, 22);
            this.btnGoToLast.Text = ">>";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "X";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 474);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMySQL;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsPhoneN;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsWorker;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsNewsStand;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsMagazine;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsPeriod;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsMagRelase;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsJob;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripInsTask;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnGoToFirst;
        private System.Windows.Forms.ToolStripButton btnGoToPrevious;
        private System.Windows.Forms.ToolStripTextBox txtPositionItem;
        private System.Windows.Forms.ToolStripButton btnGoToNext;
        private System.Windows.Forms.ToolStripButton btnGoToLast;
        private System.Windows.Forms.ToolStripButton btnDelete;
    }
}

