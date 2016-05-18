namespace dbinterface
{
    partial class InsertNewsstandForm
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
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.txtPiva = new System.Windows.Forms.TextBox();
            this.lblPiva = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtNPhone = new System.Windows.Forms.TextBox();
            this.lblNPhone = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.comboOwners = new System.Windows.Forms.ComboBox();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMySQL = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(220, 32);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(151, 20);
            this.txtBusinessName.TabIndex = 0;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(134, 35);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(80, 13);
            this.lblBusinessName.TabIndex = 16;
            this.lblBusinessName.Text = "business name:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(302, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnGO
            // 
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGO.Location = new System.Drawing.Point(196, 281);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 23);
            this.btnGO.TabIndex = 10;
            this.btnGO.Text = "Add newsstand";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // txtPiva
            // 
            this.txtPiva.Location = new System.Drawing.Point(220, 58);
            this.txtPiva.Name = "txtPiva";
            this.txtPiva.Size = new System.Drawing.Size(151, 20);
            this.txtPiva.TabIndex = 1;
            // 
            // lblPiva
            // 
            this.lblPiva.AutoSize = true;
            this.lblPiva.Location = new System.Drawing.Point(177, 65);
            this.lblPiva.Name = "lblPiva";
            this.lblPiva.Size = new System.Drawing.Size(37, 13);
            this.lblPiva.TabIndex = 31;
            this.lblPiva.Text = "P.IVA:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(220, 84);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 20);
            this.txtCity.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(188, 87);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(26, 13);
            this.lblCity.TabIndex = 33;
            this.lblCity.Text = "city:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(220, 110);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(151, 20);
            this.txtZipCode.TabIndex = 3;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(167, 113);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(47, 13);
            this.lblZipCode.TabIndex = 35;
            this.lblZipCode.Text = "zipcode:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(220, 136);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(167, 139);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 13);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "address:";
            // 
            // txtNPhone
            // 
            this.txtNPhone.Location = new System.Drawing.Point(220, 188);
            this.txtNPhone.Name = "txtNPhone";
            this.txtNPhone.Size = new System.Drawing.Size(151, 20);
            this.txtNPhone.TabIndex = 7;
            // 
            // lblNPhone
            // 
            this.lblNPhone.AutoSize = true;
            this.lblNPhone.Location = new System.Drawing.Point(120, 191);
            this.lblNPhone.Name = "lblNPhone";
            this.lblNPhone.Size = new System.Drawing.Size(94, 13);
            this.lblNPhone.TabIndex = 41;
            this.lblNPhone.Text = "newsstand phone:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(175, 217);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(39, 13);
            this.lblOwner.TabIndex = 43;
            this.lblOwner.Text = "owner:";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Location = new System.Drawing.Point(377, 159);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(100, 23);
            this.btnAddLocation.TabIndex = 6;
            this.btnAddLocation.Text = "Add location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // comboLocation
            // 
            this.comboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Location = new System.Drawing.Point(220, 161);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(151, 21);
            this.comboLocation.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(167, 164);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(47, 13);
            this.lblLocation.TabIndex = 45;
            this.lblLocation.Text = "location:";
            // 
            // comboOwners
            // 
            this.comboOwners.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboOwners.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboOwners.FormattingEnabled = true;
            this.comboOwners.Location = new System.Drawing.Point(220, 214);
            this.comboOwners.Name = "comboOwners";
            this.comboOwners.Size = new System.Drawing.Size(151, 21);
            this.comboOwners.TabIndex = 8;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwner.Location = new System.Drawing.Point(377, 212);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(100, 23);
            this.btnAddOwner.TabIndex = 9;
            this.btnAddOwner.Text = "Add owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMySQL});
            this.statusStrip.Location = new System.Drawing.Point(0, 342);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(597, 22);
            this.statusStrip.TabIndex = 50;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMySQL
            // 
            this.statusMySQL.Name = "statusMySQL";
            this.statusMySQL.Size = new System.Drawing.Size(36, 17);
            this.statusMySQL.Text = "ready";
            // 
            // InsertNewsstandForm
            // 
            this.AcceptButton = this.btnGO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 364);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.comboOwners);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.comboLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtNPhone);
            this.Controls.Add(this.lblNPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtPiva);
            this.Controls.Add(this.lblPiva);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.lblBusinessName);
            this.Name = "InsertNewsstandForm";
            this.Text = "Insert a new newsstand";
            this.Load += new System.EventHandler(this.InsertNewsstandForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtPiva;
        private System.Windows.Forms.Label lblPiva;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtNPhone;
        private System.Windows.Forms.Label lblNPhone;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox comboOwners;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMySQL;
    }
}