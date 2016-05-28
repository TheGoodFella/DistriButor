using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class InsertMagazineForm : Form
    {
        DB _db;
        updateType _t;
        int _id;

        InsertWorkerForm insWorker;
        InsertPeriodForm insPeriod;

        public InsertMagazineForm(DB db, updateType t)
        {
            InitializeComponent();
            _db = db;
            _t = t;
        }
        public InsertMagazineForm(DB db, updateType t, int idToChange)
        {
            InitializeComponent();
            _db = db;
            _t = t;
            _id = idToChange;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string funcRes;
            if (comboOwners.Text.Contains('-'))
            {
                string[] completename = comboOwners.Text.Split('-');
                funcRes = _db.InsertMagazine(txTitle.Text, comboPeriods.Text, completename[0], completename[1],_t,_id.ToString());
            }
            else
            {
                if (comboOwners.Text.Length > 0)
                    funcRes = _db.InsertMagazine(txTitle.Text, comboPeriods.Text, comboOwners.Text, comboOwners.Text, _t, _id.ToString());
                else
                    funcRes = _db.InsertMagazine(txTitle.Text, comboPeriods.Text, "", "", _t, _id.ToString());
            }

            UpdateStatusStrip(funcRes);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            insWorker = new InsertWorkerForm(_db, updateType.insert);
            insWorker.ShowDialog();

            StoreComboBoxOwners();
        }

        private void InsertMagazineForm_Load(object sender, EventArgs e)
        {
            StoreComboBoxPeriod();
            StoreComboBoxOwners();
        }

        private void StoreComboBoxOwners()
        {
            DataTable dt = _db.allOwners();
            comboOwners.Items.Clear();
            foreach (DataRow row in dt.Rows)
                for (int i = 0; i < row.ItemArray.Length - 1; i++)
                    comboOwners.Items.Add(row.ItemArray[i].ToString() + "-" + row.ItemArray[i + 1].ToString());
        }

        private void StoreComboBoxPeriod()
        {
            DataTable dt = _db.allPeriods();
            comboPeriods.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    comboPeriods.Items.Add(item);
        }

        private void btnAddPeriod_Click(object sender, EventArgs e)
        {
            insPeriod = new InsertPeriodForm(_db, updateType.insert);
            insPeriod.ShowDialog();
            StoreComboBoxPeriod();
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
                statusMySQL.Text = "owner does not exist";
            }
            if (text == "3")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "periodicity does not exist";
            }
            
            if (text == "-1")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "can't access database";
            }
            if (text == "4")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "empty or null fields";
            }
        }
    }
}
