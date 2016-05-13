namespace dbinterface
{
    partial class LoginForm
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
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(107, 30);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(54, 13);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "database:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(82, 56);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "server address:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(131, 108);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(30, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "user:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(106, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "password:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(167, 27);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(151, 20);
            this.txtDatabase.TabIndex = 4;
            this.txtDatabase.Text = "DISTRIBUTOR";
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(167, 53);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(151, 20);
            this.txtDataSource.TabIndex = 5;
            this.txtDataSource.Text = "localhost";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(167, 105);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(151, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "guest";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(151, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnGO
            // 
            this.btnGO.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGO.Location = new System.Drawing.Point(191, 178);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(100, 23);
            this.btnGO.TabIndex = 8;
            this.btnGO.Text = "LOGIN";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(132, 82);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(28, 13);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(167, 79);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(151, 20);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "3306";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnGO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 228);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDataSource);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "login to database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
    }
}