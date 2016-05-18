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
    public partial class InsertNewsstandForm : Form
    {
        DB _db;
        InsertLocationForm insLocation;
        InsertWorkerForm insWorker;

        public InsertNewsstandForm()
        {
            InitializeComponent();
        }

        public InsertNewsstandForm(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            insLocation = new InsertLocationForm(_db);
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
            insWorker = new InsertWorkerForm(_db);
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
            string[] completename = comboOwners.Text.Split('-');
            string funcRes = _db.InsertNewsStand(txtBusinessName.Text, txtPiva.Text, txtCity.Text, txtZipCode.Text, txtAddress.Text, comboLocation.Text, txtNPhone.Text, completename[0], completename[1]);
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
                statusMySQL.Text = "record already exists";
            }
            if (text == "1")
            {
                statusMySQL.BackColor = Color.Green;
                statusMySQL.Text = "insert succeeded";
            }
            if (text == "2")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "province doesn't exists";
            }
            if (text == "3")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "owner doesn't exists";
            }
            if (text == "-1")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "can't access database";
            }
        }
    }
}
