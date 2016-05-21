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
using System.Globalization;

namespace dbinterface
{
    public partial class InsertMagRelaseForm : Form
    {
        DB _db;
        InsertMagazineForm insMagazine;

        public InsertMagRelaseForm(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string dateRelase= dateTimePicker.Value.ToString("yyyy-MM-dd");
            string percentToNS = numPercentToNS.Value.ToString().Replace(',', '.');
            string priceToPublic = numPriceToPublic.Value.ToString().Replace(',', '.');

            string funcRes = _db.InsertMagRelase(comboMagName.Text, numMagNumber.Value.ToString(), dateRelase, txtNameRelase.Text, priceToPublic, percentToNS);

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
                statusMySQL.Text = "magazine doesn't exist";
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

        private void InsertMagRelaseForm_Load(object sender, EventArgs e)
        {
            StoreComboBoxMagName();
        }

        private void StoreComboBoxMagName()
        {
            DataTable dt = _db.AllMagazinesName();
            comboMagName.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    comboMagName.Items.Add(item);
        }

        private void btnAddMagName_Click(object sender, EventArgs e)
        {
            insMagazine = new InsertMagazineForm(_db);
            insMagazine.ShowDialog();
            StoreComboBoxMagName();
        }
    }
}
