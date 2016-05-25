namespace dbinterface
{
    partial class InsertTaskForm
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
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.comboWorkers = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.numNCopies = new System.Windows.Forms.NumericUpDown();
            this.lblNCopies = new System.Windows.Forms.Label();
            this.comboTaskType = new System.Windows.Forms.ComboBox();
            this.lblTypeTask = new System.Windows.Forms.Label();
            this.btnAddMagazine = new System.Windows.Forms.Button();
            this.comboMagTitle = new System.Windows.Forms.ComboBox();
            this.lblMagTitle = new System.Windows.Forms.Label();
            this.btnAddMagRelase = new System.Windows.Forms.Button();
            this.comboMagRelase = new System.Windows.Forms.ComboBox();
            this.lblMagRelase = new System.Windows.Forms.Label();
            this.btnAddNewsStand = new System.Windows.Forms.Button();
            this.comboBusinessName = new System.Windows.Forms.ComboBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.comboJobName = new System.Windows.Forms.ComboBox();
            this.lblJobName = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numNCopies)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(290, 38);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(151, 20);
            this.txtTaskName.TabIndex = 0;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(232, 41);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(59, 13);
            this.lblTaskName.TabIndex = 18;
            this.lblTaskName.Text = "task name:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(378, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGO
            // 
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGO.Location = new System.Drawing.Point(272, 386);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 23);
            this.btnGO.TabIndex = 14;
            this.btnGO.Text = "Add newsstand";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.Location = new System.Drawing.Point(445, 198);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(127, 23);
            this.btnAddWorker.TabIndex = 10;
            this.btnAddWorker.Text = "Add a new worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // comboWorkers
            // 
            this.comboWorkers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboWorkers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboWorkers.FormattingEnabled = true;
            this.comboWorkers.Location = new System.Drawing.Point(288, 200);
            this.comboWorkers.Name = "comboWorkers";
            this.comboWorkers.Size = new System.Drawing.Size(151, 21);
            this.comboWorkers.TabIndex = 9;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(198, 203);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(84, 13);
            this.lblWorker.TabIndex = 46;
            this.lblWorker.Text = "distributor name:";
            // 
            // numNCopies
            // 
            this.numNCopies.Location = new System.Drawing.Point(290, 91);
            this.numNCopies.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numNCopies.Name = "numNCopies";
            this.numNCopies.Size = new System.Drawing.Size(120, 20);
            this.numNCopies.TabIndex = 2;
            this.numNCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNCopies
            // 
            this.lblNCopies.AutoSize = true;
            this.lblNCopies.Location = new System.Drawing.Point(193, 93);
            this.lblNCopies.Name = "lblNCopies";
            this.lblNCopies.Size = new System.Drawing.Size(91, 13);
            this.lblNCopies.TabIndex = 48;
            this.lblNCopies.Text = "number of copies:";
            // 
            // comboTaskType
            // 
            this.comboTaskType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboTaskType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTaskType.Location = new System.Drawing.Point(290, 64);
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(151, 21);
            this.comboTaskType.TabIndex = 1;
            // 
            // lblTypeTask
            // 
            this.lblTypeTask.AutoSize = true;
            this.lblTypeTask.Location = new System.Drawing.Point(231, 67);
            this.lblTypeTask.Name = "lblTypeTask";
            this.lblTypeTask.Size = new System.Drawing.Size(53, 13);
            this.lblTypeTask.TabIndex = 51;
            this.lblTypeTask.Text = "task type:";
            // 
            // btnAddMagazine
            // 
            this.btnAddMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMagazine.Location = new System.Drawing.Point(445, 115);
            this.btnAddMagazine.Name = "btnAddMagazine";
            this.btnAddMagazine.Size = new System.Drawing.Size(127, 23);
            this.btnAddMagazine.TabIndex = 4;
            this.btnAddMagazine.Text = "Add a new magazine";
            this.btnAddMagazine.UseVisualStyleBackColor = true;
            this.btnAddMagazine.Click += new System.EventHandler(this.btnAddMagazine_Click);
            // 
            // comboMagTitle
            // 
            this.comboMagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboMagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMagTitle.FormattingEnabled = true;
            this.comboMagTitle.Location = new System.Drawing.Point(290, 117);
            this.comboMagTitle.Name = "comboMagTitle";
            this.comboMagTitle.Size = new System.Drawing.Size(151, 21);
            this.comboMagTitle.TabIndex = 3;
            this.comboMagTitle.SelectedIndexChanged += new System.EventHandler(this.comboMagTitle_SelectedIndexChanged);
            // 
            // lblMagTitle
            // 
            this.lblMagTitle.AutoSize = true;
            this.lblMagTitle.Location = new System.Drawing.Point(210, 120);
            this.lblMagTitle.Name = "lblMagTitle";
            this.lblMagTitle.Size = new System.Drawing.Size(74, 13);
            this.lblMagTitle.TabIndex = 54;
            this.lblMagTitle.Text = "magazine title:";
            // 
            // btnAddMagRelase
            // 
            this.btnAddMagRelase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMagRelase.Location = new System.Drawing.Point(445, 142);
            this.btnAddMagRelase.Name = "btnAddMagRelase";
            this.btnAddMagRelase.Size = new System.Drawing.Size(127, 23);
            this.btnAddMagRelase.TabIndex = 6;
            this.btnAddMagRelase.Text = "Add a new relase";
            this.btnAddMagRelase.UseVisualStyleBackColor = true;
            this.btnAddMagRelase.Click += new System.EventHandler(this.btnAddMagRelase_Click);
            // 
            // comboMagRelase
            // 
            this.comboMagRelase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboMagRelase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMagRelase.FormattingEnabled = true;
            this.comboMagRelase.Location = new System.Drawing.Point(290, 144);
            this.comboMagRelase.Name = "comboMagRelase";
            this.comboMagRelase.Size = new System.Drawing.Size(151, 21);
            this.comboMagRelase.TabIndex = 5;
            // 
            // lblMagRelase
            // 
            this.lblMagRelase.AutoSize = true;
            this.lblMagRelase.Location = new System.Drawing.Point(154, 147);
            this.lblMagRelase.Name = "lblMagRelase";
            this.lblMagRelase.Size = new System.Drawing.Size(130, 13);
            this.lblMagRelase.TabIndex = 57;
            this.lblMagRelase.Text = "magazine release number:";
            // 
            // btnAddNewsStand
            // 
            this.btnAddNewsStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewsStand.Location = new System.Drawing.Point(445, 169);
            this.btnAddNewsStand.Name = "btnAddNewsStand";
            this.btnAddNewsStand.Size = new System.Drawing.Size(127, 23);
            this.btnAddNewsStand.TabIndex = 8;
            this.btnAddNewsStand.Text = "Add a new newsstand";
            this.btnAddNewsStand.UseVisualStyleBackColor = true;
            this.btnAddNewsStand.Click += new System.EventHandler(this.btnAddNewsStand_Click);
            // 
            // comboBusinessName
            // 
            this.comboBusinessName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBusinessName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBusinessName.FormattingEnabled = true;
            this.comboBusinessName.Location = new System.Drawing.Point(288, 171);
            this.comboBusinessName.Name = "comboBusinessName";
            this.comboBusinessName.Size = new System.Drawing.Size(151, 21);
            this.comboBusinessName.TabIndex = 7;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(148, 174);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(134, 13);
            this.lblBusinessName.TabIndex = 60;
            this.lblBusinessName.Text = "newsstand business name:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(290, 262);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Location = new System.Drawing.Point(236, 267);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(48, 13);
            this.lblJobDate.TabIndex = 62;
            this.lblJobDate.Text = "job date:";
            // 
            // btnAddJob
            // 
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Location = new System.Drawing.Point(447, 262);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(127, 23);
            this.btnAddJob.TabIndex = 12;
            this.btnAddJob.Text = "Add a new job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // comboJobName
            // 
            this.comboJobName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboJobName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboJobName.FormattingEnabled = true;
            this.comboJobName.Location = new System.Drawing.Point(290, 288);
            this.comboJobName.Name = "comboJobName";
            this.comboJobName.Size = new System.Drawing.Size(151, 21);
            this.comboJobName.TabIndex = 13;
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(231, 291);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(53, 13);
            this.lblJobName.TabIndex = 66;
            this.lblJobName.Text = "job name:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMySQL});
            this.statusStrip.Location = new System.Drawing.Point(0, 462);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(750, 22);
            this.statusStrip.TabIndex = 67;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMySQL
            // 
            this.statusMySQL.Name = "statusMySQL";
            this.statusMySQL.Size = new System.Drawing.Size(36, 17);
            this.statusMySQL.Text = "ready";
            // 
            // InsertTaskForm
            // 
            this.AcceptButton = this.btnGO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 484);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.comboJobName);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.btnAddNewsStand);
            this.Controls.Add(this.comboBusinessName);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.btnAddMagRelase);
            this.Controls.Add(this.comboMagRelase);
            this.Controls.Add(this.lblMagRelase);
            this.Controls.Add(this.btnAddMagazine);
            this.Controls.Add(this.comboMagTitle);
            this.Controls.Add(this.lblMagTitle);
            this.Controls.Add(this.comboTaskType);
            this.Controls.Add(this.lblTypeTask);
            this.Controls.Add(this.lblNCopies);
            this.Controls.Add(this.numNCopies);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.comboWorkers);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Name = "InsertTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert a new task";
            this.Load += new System.EventHandler(this.InsertTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNCopies)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.ComboBox comboWorkers;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.NumericUpDown numNCopies;
        private System.Windows.Forms.Label lblNCopies;
        private System.Windows.Forms.ComboBox comboTaskType;
        private System.Windows.Forms.Label lblTypeTask;
        private System.Windows.Forms.Button btnAddMagazine;
        private System.Windows.Forms.ComboBox comboMagTitle;
        private System.Windows.Forms.Label lblMagTitle;
        private System.Windows.Forms.Button btnAddMagRelase;
        private System.Windows.Forms.ComboBox comboMagRelase;
        private System.Windows.Forms.Label lblMagRelase;
        private System.Windows.Forms.Button btnAddNewsStand;
        private System.Windows.Forms.ComboBox comboBusinessName;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.ComboBox comboJobName;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMySQL;
    }
}