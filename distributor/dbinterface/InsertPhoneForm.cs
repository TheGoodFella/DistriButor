using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class InsertPhoneForm : Form
    {
        DB _db;
        updateType _t;
        int _id;

        InsertWorkerForm insWorker;

        public string Phone { get; private set; }

        public InsertPhoneForm(DB db, updateType t, int idToChange)
        {
            InitializeComponent();
            _db = db;
            _t = t;
            _id = idToChange;
        }

        public InsertPhoneForm(DB db, updateType t)
        {
            InitializeComponent();
            _db = db;
            _t = t;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string funcRes;
            if (comboOwners.Text.Contains('-'))
            {
                string[] completename = comboOwners.Text.Split('-');
                funcRes = _db.InsertPhoneNumber(txtPhone.Text, completename[0], completename[1],_t,_id.ToString());
            }
            else
            {
                if (comboOwners.Text.Length > 0)
                    funcRes = _db.InsertPhoneNumber(txtPhone.Text, comboOwners.Text, comboOwners.Text, _t, _id.ToString());
                else
                    funcRes = _db.InsertPhoneNumber(txtPhone.Text, "", "", _t, _id.ToString());
            }

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
            if (text == "-1")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "ERROR";
            }
            if (text == "2")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "owner doesn't exist";
            }
            if (text == "3")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "empty or null fields";
            }
            if (text == "4")
            {
                statusMySQL.BackColor = Color.Green;
                statusMySQL.Text = "update succeeded";
            }
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            insWorker = new InsertWorkerForm(_db, updateType.insert);
            insWorker.ShowDialog();

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

        private void InsertPhoneForm_Load(object sender, EventArgs e)
        {
            StoreComboBoxOwners();
        }
    }
}
