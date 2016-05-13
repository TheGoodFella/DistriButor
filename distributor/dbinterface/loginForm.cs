using System;
using System.Windows.Forms;

namespace dbinterface
{
    public partial class LoginForm : Form
    {
        public string Database { get; private set; }
        public string DataSource { get; private set; }
        public string Port { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            Database = txtDatabase.Text;
            DataSource = txtDataSource.Text;
            Port = txtPort.Text;
            User = txtUser.Text;
            Password = txtPassword.Text;
        }
    }
}
