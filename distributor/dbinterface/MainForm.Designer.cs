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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsPhoneN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInsNewsStand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQueryLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripQueryPhones = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.bNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNav)).BeginInit();
            this.bNav.SuspendLayout();
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
            this.menuStripInsWorker,
            this.menuStripInsNewsStand});
            this.menuStripInsert.Name = "menuStripInsert";
            this.menuStripInsert.Size = new System.Drawing.Size(114, 22);
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
            // menuStripInsWorker
            // 
            this.menuStripInsWorker.Name = "menuStripInsWorker";
            this.menuStripInsWorker.Size = new System.Drawing.Size(153, 22);
            this.menuStripInsWorker.Text = "Worker";
            this.menuStripInsWorker.Click += new System.EventHandler(this.menuStripInsWorker_Click);
            // 
            // menuStripInsNewsStand
            // 
            this.menuStripInsNewsStand.Name = "menuStripInsNewsStand";
            this.menuStripInsNewsStand.Size = new System.Drawing.Size(153, 22);
            this.menuStripInsNewsStand.Text = "Newsstand";
            this.menuStripInsNewsStand.Click += new System.EventHandler(this.menuStripInsNewsStand_Click);
            // 
            // menuStripQueries
            // 
            this.menuStripQueries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripQueryLocations,
            this.menuStripQueryPhones});
            this.menuStripQueries.Name = "menuStripQueries";
            this.menuStripQueries.Size = new System.Drawing.Size(114, 22);
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
            // bNav
            // 
            this.bNav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bNav.CountItem = this.bindingNavigatorCountItem;
            this.bNav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox,
            this.btnRefresh,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bNav.Location = new System.Drawing.Point(0, 24);
            this.bNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNav.Name = "bNav";
            this.bNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bNav.Size = new System.Drawing.Size(975, 25);
            this.bNav.TabIndex = 8;
            this.bNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 22);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 474);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bNav);
            this.Controls.Add(this.statusStrip);
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
            ((System.ComponentModel.ISupportInitialize)(this.bNav)).EndInit();
            this.bNav.ResumeLayout(false);
            this.bNav.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuStripInsNewsStand;
        private System.Windows.Forms.BindingNavigator bNav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.ToolStripButton btnRefresh;
    }
}

