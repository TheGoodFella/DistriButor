using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class MainForm : Form
    {
        DB db;
        LoginForm login;
        QueryForm qf;

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStripLogin_Click(object sender, EventArgs e)
        {
            login = new LoginForm();
            DialogResult loginRes = login.ShowDialog();
            if (loginRes == DialogResult.OK)
            {
                db = new DB(login.Database, login.DataSource, login.Port, login.User, login.Password);
                qf = new QueryForm(db.SelectAllTasks());
                qf.ShowDialog();
            }
        }

        private void menuStripInsLocations_Click(object sender, EventArgs e)
        {

        }
    }
}
