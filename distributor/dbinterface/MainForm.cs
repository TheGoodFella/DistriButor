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
        InsertWorkerForm insWorker;
        InsertNewsstandForm insNewsstand;

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStripLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void menuStripInsLocations_Click(object sender, EventArgs e)
        {
            insLocation = new InsertLocationForm(db);
            insLocation.ShowDialog();
        }

        private void menuStripQueryLocations_Click(object sender, EventArgs e)
        {
            qf = new QueryForm(db.SelectAllLocations());
            qf.ShowDialog();
        }

        private void menuStripInsPhoneN_Click(object sender, EventArgs e)
        {
            insPhone = new InsertPhoneForm(db);
            insPhone.ShowDialog();
        }

        private void UpdateStatusStrip(string text, Color color)
        {
                statusMySQL.BackColor = color;
                statusMySQL.Text = text;
        }

        private void menuStripQueryPhones_Click(object sender, EventArgs e)
        {
            qf = new QueryForm(db.SelectAllPhones());
            qf.ShowDialog();
        }

        private void LogIn()
        {
            login = new LoginForm(db);
            DialogResult loginRes = login.ShowDialog();
            if (loginRes == DialogResult.OK)
            {
                db = new DB(login.Database, login.DataSource, login.Port, login.User, login.Password);
                string funcRes = db.CheckLogIn();
                if(funcRes=="1")
                    UpdateStatusStrip("ready", SystemColors.Control);
                if(funcRes=="-1")
                    UpdateStatusStrip("login failed", Color.Red);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogIn();
            StoreComboBoxFromEnum();
        }

        private void StoreComboBoxFromEnum()
        {
            toolStripComboBox.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(ListNav)))
            {
                toolStripComboBox.Items.Add(item.ToString());
            }
        }

        private void menuStripInsWorker_Click(object sender, EventArgs e)
        {
            insWorker = new InsertWorkerForm(db);
            insWorker.ShowDialog();
        }

        private void menuStripInsNewsStand_Click(object sender, EventArgs e)
        {
            insNewsstand = new InsertNewsstandForm(db);
            DialogResult res = insNewsstand.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            ListNav item;
            DataTable dt_temp = new DataTable();

            dt_temp.Columns.Add("no data");
            dt_temp.Rows.Add("empty set");
            

            if (!Enum.TryParse(toolStripComboBox.Text, out item))
            {
                dataGridView.DataSource = dt_temp;
                
                return;
            }
            
            switch(item)
            {
                case ListNav.allWorkers:
                    dt_temp = db.AllWorkers();
                    break;
                case ListNav.showSoldCopies:
                    dt_temp = db.CallShowSoldCopies();
                    break;
                default:
                    dataGridView.Rows.Clear();
                    break;
            }

            dataGridView.DataSource = dt_temp;
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
