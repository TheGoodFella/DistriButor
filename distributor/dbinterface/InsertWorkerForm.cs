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
    public partial class InsertWorkerForm : Form
    {
        DB _db;

        InsertLocationForm insLocation;

        public string LastName { get; private set; }
        public string _Name { get; private set; }
        public string Email { get; private set; }
        public string DateOfBirth { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string Address { get; private set; }
        public string _Location { get; private set; }


        public InsertWorkerForm()
        {
            InitializeComponent();
        }

        public InsertWorkerForm(DB db)
        {
            _db = db;
            InitializeComponent();
        }

        private void StoreComboBoxProvince()
        {
            DataTable dt = _db.allProvinces();
            comboLocation.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    comboLocation.Items.Add(item);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            insLocation = new InsertLocationForm(_db);
            insLocation.ShowDialog();

            StoreComboBoxProvince();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            LastName = txtLastname.Text;
            _Name = txtName.Text;
            Email = txtEmail.Text;
            DateOfBirth = dateTimePicker.Value.ToString("yyyy-MM-dd");
            City = txtCity.Text;
            ZipCode = txtZipCode.Text;
            Address = txtAddress.Text;
            _Location = comboLocation.Text;

            string funcRes = _db.InsertWorker(LastName, _Name, Email, DateOfBirth, _Location, City, ZipCode, Address);
            UpdateStatusStrip(funcRes);
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
            if (text == "-1")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "can't access database";
            }
            if (text == "3")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "empty or null fields";
            }
        }

        private void InsertWorkerForm_Load(object sender, EventArgs e)
        {
            StoreComboBoxProvince();
        }

        private void txtLastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsLetter((char)e.KeyValue))
                e.SuppressKeyPress = true;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsLetter((char)e.KeyValue))
                e.SuppressKeyPress = true;
        }
    }
}
