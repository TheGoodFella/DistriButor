namespace dbinterface
{
    partial class InsertMagRelaseForm
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
            this.btnAddMagName = new System.Windows.Forms.Button();
            this.comboMagName = new System.Windows.Forms.ComboBox();
            this.lblMagNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblMagName = new System.Windows.Forms.Label();
            this.numMagNumber = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblMagDateRelase = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNameRelase = new System.Windows.Forms.TextBox();
            this.lblNameRelase = new System.Windows.Forms.Label();
            this.lblPriceToPublic = new System.Windows.Forms.Label();
            this.numPriceToPublic = new System.Windows.Forms.NumericUpDown();
            this.numPercentToNS = new System.Windows.Forms.NumericUpDown();
            this.lblPercentToNS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMagNumber)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentToNS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMagName
            // 
            this.btnAddMagName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMagName.Location = new System.Drawing.Point(458, 53);
            this.btnAddMagName.Name = "btnAddMagName";
            this.btnAddMagName.Size = new System.Drawing.Size(120, 23);
            this.btnAddMagName.TabIndex = 1;
            this.btnAddMagName.Text = "Add a new magazine";
            this.btnAddMagName.UseVisualStyleBackColor = true;
            this.btnAddMagName.Click += new System.EventHandler(this.btnAddMagName_Click);
            // 
            // comboMagName
            // 
            this.comboMagName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboMagName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMagName.FormattingEnabled = true;
            this.comboMagName.Location = new System.Drawing.Point(301, 55);
            this.comboMagName.Name = "comboMagName";
            this.comboMagName.Size = new System.Drawing.Size(151, 21);
            this.comboMagName.TabIndex = 0;
            // 
            // lblMagNumber
            // 
            this.lblMagNumber.AutoSize = true;
            this.lblMagNumber.Location = new System.Drawing.Point(250, 84);
            this.lblMagNumber.Name = "lblMagNumber";
            this.lblMagNumber.Size = new System.Drawing.Size(45, 13);
            this.lblMagNumber.TabIndex = 49;
            this.lblMagNumber.Text = "number:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(314, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGO
            // 
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGO.Location = new System.Drawing.Point(208, 230);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 23);
            this.btnGO.TabIndex = 7;
            this.btnGO.Text = "Add magazine";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lblMagName
            // 
            this.lblMagName.AutoSize = true;
            this.lblMagName.Location = new System.Drawing.Point(215, 58);
            this.lblMagName.Name = "lblMagName";
            this.lblMagName.Size = new System.Drawing.Size(84, 13);
            this.lblMagName.TabIndex = 57;
            this.lblMagName.Text = "magazine name:";
            // 
            // numMagNumber
            // 
            this.numMagNumber.Location = new System.Drawing.Point(301, 82);
            this.numMagNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numMagNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMagNumber.Name = "numMagNumber";
            this.numMagNumber.Size = new System.Drawing.Size(60, 20);
            this.numMagNumber.TabIndex = 2;
            this.numMagNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(301, 108);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // lblMagDateRelase
            // 
            this.lblMagDateRelase.AutoSize = true;
            this.lblMagDateRelase.Location = new System.Drawing.Point(227, 114);
            this.lblMagDateRelase.Name = "lblMagDateRelase";
            this.lblMagDateRelase.Size = new System.Drawing.Size(68, 13);
            this.lblMagDateRelase.TabIndex = 60;
            this.lblMagDateRelase.Text = "release date:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMySQL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMySQL
            // 
            this.statusMySQL.Name = "statusMySQL";
            this.statusMySQL.Size = new System.Drawing.Size(36, 17);
            this.statusMySQL.Text = "ready";
            // 
            // txtNameRelase
            // 
            this.txtNameRelase.Location = new System.Drawing.Point(301, 134);
            this.txtNameRelase.Name = "txtNameRelase";
            this.txtNameRelase.Size = new System.Drawing.Size(151, 20);
            this.txtNameRelase.TabIndex = 4;
            // 
            // lblNameRelase
            // 
            this.lblNameRelase.AutoSize = true;
            this.lblNameRelase.Location = new System.Drawing.Point(228, 137);
            this.lblNameRelase.Name = "lblNameRelase";
            this.lblNameRelase.Size = new System.Drawing.Size(67, 13);
            this.lblNameRelase.TabIndex = 63;
            this.lblNameRelase.Text = "relase name:";
            // 
            // lblPriceToPublic
            // 
            this.lblPriceToPublic.AutoSize = true;
            this.lblPriceToPublic.Location = new System.Drawing.Point(219, 162);
            this.lblPriceToPublic.Name = "lblPriceToPublic";
            this.lblPriceToPublic.Size = new System.Drawing.Size(76, 13);
            this.lblPriceToPublic.TabIndex = 65;
            this.lblPriceToPublic.Text = "price to public:";
            // 
            // numPriceToPublic
            // 
            this.numPriceToPublic.DecimalPlaces = 2;
            this.numPriceToPublic.Location = new System.Drawing.Point(301, 160);
            this.numPriceToPublic.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.numPriceToPublic.Name = "numPriceToPublic";
            this.numPriceToPublic.Size = new System.Drawing.Size(60, 20);
            this.numPriceToPublic.TabIndex = 5;
            this.numPriceToPublic.Value = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            // 
            // numPercentToNS
            // 
            this.numPercentToNS.DecimalPlaces = 2;
            this.numPercentToNS.Location = new System.Drawing.Point(301, 186);
            this.numPercentToNS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.numPercentToNS.Name = "numPercentToNS";
            this.numPercentToNS.Size = new System.Drawing.Size(60, 20);
            this.numPercentToNS.TabIndex = 6;
            this.numPercentToNS.Value = new decimal(new int[] {
            5000,
            0,
            0,
            131072});
            // 
            // lblPercentToNS
            // 
            this.lblPercentToNS.AutoSize = true;
            this.lblPercentToNS.Location = new System.Drawing.Point(13, 186);
            this.lblPercentToNS.Name = "lblPercentToNS";
            this.lblPercentToNS.Size = new System.Drawing.Size(282, 13);
            this.lblPercentToNS.TabIndex = 67;
            this.lblPercentToNS.Text = "percentage of price to public that the the newsstand earns";
            // 
            // InsertMagRelaseForm
            // 
            this.AcceptButton = this.btnGO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 314);
            this.Controls.Add(this.numPercentToNS);
            this.Controls.Add(this.lblPercentToNS);
            this.Controls.Add(this.numPriceToPublic);
            this.Controls.Add(this.lblPriceToPublic);
            this.Controls.Add(this.txtNameRelase);
            this.Controls.Add(this.lblNameRelase);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblMagDateRelase);
            this.Controls.Add(this.numMagNumber);
            this.Controls.Add(this.lblMagName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnAddMagName);
            this.Controls.Add(this.comboMagName);
            this.Controls.Add(this.lblMagNumber);
            this.Name = "InsertMagRelaseForm";
            this.Text = "InsertMagRelaseForm";
            this.Load += new System.EventHandler(this.InsertMagRelaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMagNumber)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentToNS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMagName;
        private System.Windows.Forms.ComboBox comboMagName;
        private System.Windows.Forms.Label lblMagNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lblMagName;
        private System.Windows.Forms.NumericUpDown numMagNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblMagDateRelase;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMySQL;
        private System.Windows.Forms.TextBox txtNameRelase;
        private System.Windows.Forms.Label lblNameRelase;
        private System.Windows.Forms.Label lblPriceToPublic;
        private System.Windows.Forms.NumericUpDown numPriceToPublic;
        private System.Windows.Forms.NumericUpDown numPercentToNS;
        private System.Windows.Forms.Label lblPercentToNS;
    }
}