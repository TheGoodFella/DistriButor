using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        InsertPhoneForm insPhone;

        public MainForm()
        {
            InitializeComponent();
            LogIn();
        }

        private void menuStripLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void menuStripInsLocations_Click(object sender, EventArgs e)
        {
            insLocation = new InsertLocationForm();
            DialogResult res = insLocation.ShowDialog();
            if(res==DialogResult.OK)
            {
                string funcRes = db.InsertLocation(insLocation.Country, insLocation._Region, insLocation.Province);
                UpdateStatusStrip(funcRes);
            }
        }

        private void menuStripQueryLocations_Click(object sender, EventArgs e)
        {
            qf = new QueryForm(db.SelectAllLocations());
            qf.ShowDialog();
        }

        private void menuStripInsPhoneN_Click(object sender, EventArgs e)
        {
            insPhone = new InsertPhoneForm();
            DialogResult res = insPhone.ShowDialog();
            if(res==DialogResult.OK)
            {
                string funcRes = db.InsertPhoneNumber(insPhone.Phone);
                UpdateStatusStrip(funcRes);
            }
        }

        private void UpdateStatusStrip(string text)
        {
            if (text == "1")
            {
                statusMySQL.BackColor = Color.Green;
                statusMySQL.Text = "insert succeeded";
            }
            else if (text == "0")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "record already exists";
            }
        }

        private void menuStripQueryPhones_Click(object sender, EventArgs e)
        {
            qf = new QueryForm(db.SelectAllPhones());
            qf.ShowDialog();
        }

        private void LogIn()
        {
            login = new LoginForm();
            DialogResult loginRes = login.ShowDialog();
            if (loginRes == DialogResult.OK)
            {
                db = new DB(login.Database, login.DataSource, login.Port, login.User, login.Password);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
