using System;
using System.Drawing;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class InsertLocationForm : Form
    {
        DB _db;
        updateType _t;

        public string Country { get; set; }
        public string _Region { get; set; }
        public string Province { get; set; }

        public InsertLocationForm(DB db, updateType t)
        {
            InitializeComponent();
            _db = db;
            _t = t;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Country = txtCountry.Text;
            _Region = txtRegion.Text;
            Province = txtProvince.Text;

            string funcRes = _db.InsertLocation(Country, _Region, Province, _t, "-1");
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
                statusMySQL.Text = "empty or null fields";
            }
        }

        private void InsertLocationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
