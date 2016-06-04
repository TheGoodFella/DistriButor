using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class InsertNewsstandForm : Form
    {
        DB _db;
        InsertLocationForm insLocation;
        InsertWorkerForm insWorker;
        updateType _t;
        int _id;

        public InsertNewsstandForm(DB db, updateType t)
        {
            InitializeComponent();
            _db = db;
            _t = t;
        }

        public InsertNewsstandForm(DB db, updateType t, int idToChange)
        {
            InitializeComponent();
            _db = db;
            _t = t;
            _id = idToChange;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            insLocation = new InsertLocationForm(_db, updateType.insert);
            insLocation.ShowDialog();

            StoreComboBoxProvince();
        }

        private void StoreComboBoxProvince()
        {
            DataTable dt = _db.allProvinces();
            comboLocation.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    comboLocation.Items.Add(item);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            insWorker = new InsertWorkerForm(_db, updateType.insert);
            insWorker.ShowDialog();

            StoreComboBoxOwners();
            StoreComboBoxProvince();
        }

        private void StoreComboBoxOwners()
        {
            DataTable dt = _db.allOwners();
            comboOwners.Items.Clear();
            foreach (DataRow row in dt.Rows)
                for (int i = 0; i < row.ItemArray.Length - 1; i++)
                    comboOwners.Items.Add(row.ItemArray[i].ToString() + "-" + row.ItemArray[i + 1].ToString());
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string funcRes;
            if (comboOwners.Text.Contains('-'))
            {
                string[] completename = comboOwners.Text.Split('-');
                funcRes = _db.InsertNewsStand(txtBusinessName.Text, txtPiva.Text, txtCity.Text, txtZipCode.Text, txtAddress.Text, comboLocation.Text, txtNPhone.Text, completename[0], completename[1],_t,_id.ToString());
            }
            else
            {
                if (comboOwners.Text.Length > 0)
                    funcRes = _db.InsertNewsStand(txtBusinessName.Text, txtPiva.Text, txtCity.Text, txtZipCode.Text, txtAddress.Text, comboLocation.Text, txtNPhone.Text, comboOwners.Text, comboOwners.Text, _t, _id.ToString());
                else
                    funcRes = _db.InsertNewsStand(txtBusinessName.Text, txtPiva.Text, txtCity.Text, txtZipCode.Text, txtAddress.Text, comboLocation.Text, txtNPhone.Text, "", "", _t, _id.ToString());
            }

            UpdateStatusStrip(funcRes);
        }

        private void InsertNewsstandForm_Load(object sender, EventArgs e)
        {
            StoreComboBoxProvince();
            StoreComboBoxOwners();
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
                statusMySQL.Text = "province doesn't exist";
            }
            if (text == "3")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "owner doesn't exist";
            }
            if (text == "-1")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "ERROR";
            }
            if (text == "4")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "empty or null fields";
            }
            if (text == "5")
            {
                statusMySQL.BackColor = Color.Green;
                statusMySQL.Text = "update succeeded";
            }
        }
    }
}
