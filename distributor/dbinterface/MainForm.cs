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
        InsertLocationForm insLocation;

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
            }
        }

        private void menuStripInsLocations_Click(object sender, EventArgs e)
        {
            insLocation = new InsertLocationForm();
            DialogResult res = insLocation.ShowDialog();
            if(res==DialogResult.OK)
            {
                string funcRes = db.InsertLocation(insLocation.Country, insLocation._Region, insLocation.Province);
                if (funcRes == "1")
                    statusMySQL.Text = "insert succeeded";
                else if (funcRes == "0")
                    statusMySQL.Text = "province already exists";
            }
        }

        private void menuStripQueryLocations_Click(object sender, EventArgs e)
        {
            qf = new QueryForm(db.SelectAllLocations());
            qf.ShowDialog();
        }
    }
}
