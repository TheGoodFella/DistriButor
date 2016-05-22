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
        InsertLocationForm insLocation;
        InsertPhoneForm insPhone;
        InsertWorkerForm insWorker;
        InsertNewsstandForm insNewsstand;
        InsertMagazineForm insMagazine;
        InsertPeriodForm insPeriod;
        InsertMagRelaseForm insMagRelase;
        InsertJobForm insjob;

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

        private void menuStripInsPhoneN_Click(object sender, EventArgs e)
        {
            insPhone = new InsertPhoneForm(db);
            insPhone.ShowDialog();
        }

        /// <summary>
        /// update text and color of the label in the status strip
        /// </summary>
        /// <param name="text">text</param>
        /// <param name="color">text color (forecolor)</param>
        private void UpdateStatusStrip(string text, Color color)
        {
                statusMySQL.BackColor = color;
                statusMySQL.Text = text;
        }

        /// <summary>
        /// shows login form and creates a new db instance with the login credentials
        /// </summary>
        private void LogIn()
        {
            login = new LoginForm(db);  //create login form
            DialogResult loginRes = login.ShowDialog();  //show login form and store the dialog result (OK if login button is clicked, calcel if cancel button is clicked, simple isn't it?)
            if (loginRes == DialogResult.OK)
            {
                db = new DB(login.Database, login.DataSource, login.Port, login.User, login.Password);  //create a new instance of db with the new credentials
                string funcRes = db.CheckLogIn();
                if(funcRes=="1")
                    UpdateStatusStrip("ready", SystemColors.Control);  //if the checklogin success, set the label properly
                if(funcRes=="-1")
                    UpdateStatusStrip("login failed", Color.Red);  //if failed, red write to the label 
            }
            RefreshDataGridView();  //refresh main datagrid view
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new DB();
            LogIn();
            StoreComboBoxFromEnum();
        }

        /// <summary>
        /// store combobox in the binding navigation from the enum
        /// </summary>
        private void StoreComboBoxFromEnum()
        {
            toolStripComboBox.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(ListNav)))
                toolStripComboBox.Items.Add(item.ToString());

            if (toolStripComboBox.Items.Count >= 1)
                toolStripComboBox.SelectedIndex = 1;
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

        /// <summary>
        /// refresh the datagrid view based on what is selected in the combobox
        /// </summary>
        private void RefreshDataGridView()
        {
            ListNav item;
            DataTable dt_temp = db.GetEmptyDataTable();
            

            if (!Enum.TryParse(toolStripComboBox.Text, out item))
            {
                dataGridView.DataSource = dt_temp;  //if failed, set the datagrid view with the default empty datatable
                return;
            }
            //if success, call the properly database procedure...
            switch(item)
            {
                case ListNav.allWorkers:
                    dt_temp = db.AllWorkers();
                    break;
                case ListNav.showSoldCopies:
                    dt_temp = db.CallShowSoldCopies();
                    break;
                case ListNav.PhoneNumbers:
                    dt_temp = db.PhoneNumbersName();
                    break;
                case ListNav.AllMagazines:
                    dt_temp = db.AllMagazines();
                    break;
                case ListNav.allMagRelases:
                    dt_temp = db.AllMagRelases();
                    break;
                case ListNav.allLocations:
                    dt_temp = db.AllLocations();
                    break;
                default:
                    dataGridView.Rows.Clear();
                    break;
            }

            dataGridView.DataSource = dt_temp;  //assign the datatable with the new values to the datagridview
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void menuStripInsMagazine_Click(object sender, EventArgs e)
        {
            insMagazine = new InsertMagazineForm(db);
            insMagazine.ShowDialog();
        }

        private void menuStripInsPeriod_Click(object sender, EventArgs e)
        {
            insPeriod = new InsertPeriodForm(db);
            insPeriod.ShowDialog();
        }

        private void menuStripInsMagRelase_Click(object sender, EventArgs e)
        {
            insMagRelase = new InsertMagRelaseForm(db);
            insMagRelase.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void menuStripInsJob_Click(object sender, EventArgs e)
        {
            insjob = new InsertJobForm(db);
            insjob.ShowDialog();
        }
    }
}
