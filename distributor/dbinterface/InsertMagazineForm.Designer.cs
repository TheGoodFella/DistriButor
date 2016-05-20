namespace dbinterface
{
    partial class InsertMagazineForm
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
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.comboOwners = new System.Windows.Forms.ComboBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddPeriod = new System.Windows.Forms.Button();
            this.comboPeriods = new System.Windows.Forms.ComboBox();
            this.lblPeriodicity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwner.Location = new System.Drawing.Point(333, 86);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(100, 23);
            this.btnAddOwner.TabIndex = 45;
            this.btnAddOwner.Text = "Add owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // comboOwners
            // 
            this.comboOwners.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboOwners.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboOwners.FormattingEnabled = true;
            this.comboOwners.Location = new System.Drawing.Point(176, 88);
            this.comboOwners.Name = "comboOwners";
            this.comboOwners.Size = new System.Drawing.Size(151, 21);
            this.comboOwners.TabIndex = 44;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(131, 91);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(39, 13);
            this.lblOwner.TabIndex = 46;
            this.lblOwner.Text = "owner:";
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(176, 35);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(151, 20);
            this.txTitle.TabIndex = 47;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(144, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(26, 13);
            this.lblTitle.TabIndex = 48;
            this.lblTitle.Text = "title:";
            // 
            // btnAddPeriod
            // 
            this.btnAddPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeriod.Location = new System.Drawing.Point(333, 59);
            this.btnAddPeriod.Name = "btnAddPeriod";
            this.btnAddPeriod.Size = new System.Drawing.Size(100, 23);
            this.btnAddPeriod.TabIndex = 50;
            this.btnAddPeriod.Text = "Add period";
            this.btnAddPeriod.UseVisualStyleBackColor = true;
            this.btnAddPeriod.Click += new System.EventHandler(this.btnAddPeriod_Click);
            // 
            // comboPeriods
            // 
            this.comboPeriods.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPeriods.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPeriods.FormattingEnabled = true;
            this.comboPeriods.Location = new System.Drawing.Point(176, 61);
            this.comboPeriods.Name = "comboPeriods";
            this.comboPeriods.Size = new System.Drawing.Size(151, 21);
            this.comboPeriods.TabIndex = 49;
            // 
            // lblPeriodicity
            // 
            this.lblPeriodicity.AutoSize = true;
            this.lblPeriodicity.Location = new System.Drawing.Point(113, 64);
            this.lblPeriodicity.Name = "lblPeriodicity";
            this.lblPeriodicity.Size = new System.Drawing.Size(57, 13);
            this.lblPeriodicity.TabIndex = 51;
            this.lblPeriodicity.Text = "periodicity:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(271, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGO
            // 
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGO.Location = new System.Drawing.Point(165, 155);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 23);
            this.btnGO.TabIndex = 52;
            this.btnGO.Text = "Add magazine";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMySQL});
            this.statusStrip.Location = new System.Drawing.Point(0, 202);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(535, 22);
            this.statusStrip.TabIndex = 65;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMySQL
            // 
            this.statusMySQL.Name = "statusMySQL";
            this.statusMySQL.Size = new System.Drawing.Size(36, 17);
            this.statusMySQL.Text = "ready";
            // 
            // InsertMagazineForm
            // 
            this.AcceptButton = this.btnGO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 224);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnAddPeriod);
            this.Controls.Add(this.comboPeriods);
            this.Controls.Add(this.lblPeriodicity);
            this.Controls.Add(this.txTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.comboOwners);
            this.Controls.Add(this.lblOwner);
            this.Name = "InsertMagazineForm";
            this.Text = "Insert a new magazine";
            this.Load += new System.EventHandler(this.InsertMagazineForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.ComboBox comboOwners;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddPeriod;
        private System.Windows.Forms.ComboBox comboPeriods;
        private System.Windows.Forms.Label lblPeriodicity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMySQL;
    }
}