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
    public partial class InsertPhoneForm : Form
    {
        DB _db;

        InsertWorkerForm insWorker;

        public string Phone { get; private set; }

        public InsertPhoneForm(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string funcRes;
            if (comboOwners.Text.Contains('-'))
            {
                string[] completename = comboOwners.Text.Split('-');
                funcRes = _db.InsertPhoneNumber(txtPhone.Text, completename[0], completename[1]);
            }
            else
            {
                if (comboOwners.Text.Length > 0)
                    funcRes = _db.InsertPhoneNumber(txtPhone.Text, comboOwners.Text, comboOwners.Text);
                else
                    funcRes = _db.InsertPhoneNumber(txtPhone.Text, "", "");
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
                statusMySQL.Text = "can't access database";
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
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            insWorker = new InsertWorkerForm(_db);
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
