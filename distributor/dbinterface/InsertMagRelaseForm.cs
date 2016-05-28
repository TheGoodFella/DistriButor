using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class InsertMagRelaseForm : Form
    {
        DB _db;
        InsertMagazineForm insMagazine;
        updateType _t;
        int _id;

        public InsertMagRelaseForm(DB db, updateType t)
        {
            InitializeComponent();
            _db = db;
            _t = t;
        }

        public InsertMagRelaseForm(DB db, updateType t, int idToChange)
        {
            InitializeComponent();
            _db = db;
            _t = t;
            _id = idToChange;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string dateRelase= dateTimePicker.Value.ToString("yyyy-MM-dd");
            string percentToNS = numPercentToNS.Value.ToString().Replace(',', '.');
            string priceToPublic = numPriceToPublic.Value.ToString().Replace(',', '.');

            string funcRes = _db.InsertMagRelase(comboMagName.Text, numMagNumber.Value.ToString(), dateRelase, txtNameRelase.Text, priceToPublic, percentToNS,_t,_id.ToString());

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
            if (text == "4")
            {
                statusMySQL.BackColor = Color.Green;
                statusMySQL.Text = "update succeeded";
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
            insMagazine = new InsertMagazineForm(_db, updateType.insert);
            insMagazine.ShowDialog();
            StoreComboBoxMagName();
        }
    }
}
