using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using distributor;
using System.Text.RegularExpressions;

namespace dbinterface
{
    public partial class InsertWorkerForm : Form
    {
        DB _db;
        updateType _t;
        int _id;

        InsertLocationForm insLocation;

        public string LastName { get; private set; }
        public string _Name { get; private set; }
        public string Email { get; private set; }
        public string DateOfBirth { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string Address { get; private set; }
        public string _Location { get; private set; }

        public InsertWorkerForm(DB db, updateType t, int idToChange)
        {
            InitializeComponent();
            _db = db;
            _t = t;
            _id = idToChange;
        }

        public InsertWorkerForm(DB db, updateType t)
        {
            InitializeComponent();
            _db = db;
            _t = t;
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
            insLocation = new InsertLocationForm(_db, updateType.insert);
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

            string funcRes = _db.InsertWorker(LastName, _Name, Email, DateOfBirth, _Location, City, ZipCode, Address,_t,_id.ToString());
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\-^\/^\*^\(^\)]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\-^\/^\*^\(^\)]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }
    }
}
