using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class InsertTaskForm : Form
    {
        DB _db;

        InsertMagazineForm insMag;
        InsertMagRelaseForm insMagRelase;
        InsertNewsstandForm insNS;
        InsertWorkerForm insWorker;
        InsertJobForm insJob;

        public InsertTaskForm(DB db)
        {
            InitializeComponent();

            _db = db;
        }

        private void StoreComboBoxWorkers()
        {
            DataTable dt = _db.allOwners();
            comboWorkers.Items.Clear();
            foreach (DataRow row in dt.Rows)
                for (int i = 0; i < row.ItemArray.Length - 1; i++)
                    comboWorkers.Items.Add(row.ItemArray[i].ToString() + "-" + row.ItemArray[i + 1].ToString());
        }

        private void StoreComboBox(ComboBox combo, DataTable dt)
        {
            combo.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    combo.Items.Add(item);
        }

        private void UpdateStatusStrip(string text)
        {
            if (text == "0")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "record already exist";
            }
            if (text == "1")
            {
                statusMySQL.BackColor = Color.Green;
                statusMySQL.Text = "insert succeeded";
            }
            if (text == "2")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "empty or null fields";
            }
            if (text == "3")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "magazine relase does not exist";
            }

            if (text == "-1")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "can't access database";
            }
            if (text == "4")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "worker does not exist";
            }
            if (text == "5")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "job does not exist";
            }
            if (text == "6")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "newsstand does not exist";
            }
            if (text == "7")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "magazine does not exist";
            }
        }

        private void InsertTaskForm_Load(object sender, EventArgs e)
        {
            StoreComboBoxWorkers();

            StoreComboBox(comboTaskType, _db.AllTaskType());
            StoreComboBox(comboMagTitle, _db.AllMagazinesName());
            StoreComboBox(comboMagRelase, _db.RelaseNumbersByMagName(comboMagTitle.Text));
            StoreComboBox(comboBusinessName, _db.AllBusinessName());
            StoreComboBox(comboJobName, _db.AllJobsByDate(dateTimePicker.Value.ToString("yyyy-MM-dd")));
        }

        private void comboMagTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreComboBox(comboMagRelase, _db.RelaseNumbersByMagName(comboMagTitle.Text));
        }

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {
            insMag = new InsertMagazineForm(_db);
            insMag.ShowDialog();
            StoreComboBox(comboMagTitle, _db.AllMagazinesName());
        }

        private void btnAddMagRelase_Click(object sender, EventArgs e)
        {
            insMagRelase = new InsertMagRelaseForm(_db);
            insMagRelase.ShowDialog();
            StoreComboBox(comboMagRelase, _db.RelaseNumbersByMagName(comboMagTitle.Text));
        }

        private void btnAddNewsStand_Click(object sender, EventArgs e)
        {
            insNS = new InsertNewsstandForm(_db);
            insNS.ShowDialog();
            StoreComboBox(comboBusinessName, _db.AllBusinessName());
            StoreComboBoxWorkers();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            insWorker = new InsertWorkerForm(_db);
            insWorker.ShowDialog();
            StoreComboBoxWorkers();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            insJob = new InsertJobForm(_db);
            insJob.ShowDialog();
            StoreComboBox(comboJobName, _db.AllJobsByDate(dateTimePicker.Value.ToString("yyyy-MM-dd")));
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string[] completename = comboWorkers.Text.Split('-');
            string jobDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

            string funcRes;
            if (comboWorkers.Text.Contains('-'))
            {
                funcRes = _db.InsertTask(txtTaskName.Text, numNCopies.Value.ToString(), comboTaskType.Text, comboMagTitle.Text, comboMagRelase.Text, comboBusinessName.Text, completename[0], completename[1], comboJobName.Text, jobDate);
            }
            else
            {
                if (comboWorkers.Text.Length > 0)
                    funcRes = _db.InsertTask(txtTaskName.Text, numNCopies.Value.ToString(), comboTaskType.Text, comboMagTitle.Text, comboMagRelase.Text, comboBusinessName.Text, comboWorkers.Text, comboWorkers.Text, comboJobName.Text, jobDate);
                else
                    funcRes = _db.InsertTask(txtTaskName.Text, numNCopies.Value.ToString(), comboTaskType.Text, comboMagTitle.Text, comboMagRelase.Text, comboBusinessName.Text, comboWorkers.Text, "", "", jobDate);
            }

            UpdateStatusStrip(funcRes);

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            StoreComboBox(comboJobName, _db.AllJobsByDate(dateTimePicker.Value.ToString("yyyy-MM-dd")));
        }
    }
}
