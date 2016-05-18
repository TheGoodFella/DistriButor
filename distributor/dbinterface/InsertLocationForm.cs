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
    public partial class InsertLocationForm : Form
    {
        DB _db;

        public string Country { get; set; }
        public string _Region { get; set; }
        public string Province { get; set; }

        public InsertLocationForm(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Country = txtCountry.Text;
            _Region = txtRegion.Text;
            Province = txtProvince.Text;

            string funcRes = _db.InsertLocation(Country, _Region, Province);
            UpdateStatusStrip(funcRes);
        }

        private void UpdateStatusStrip(string text)
        {
            if (text == "1")
            {
                statusMySQL.BackColor = Color.Green;
                statusMySQL.Text = "insert succeeded";
            }
            else if (text == "0")
            {
                statusMySQL.BackColor = Color.Red;
                statusMySQL.Text = "record already exists";
            }
        }

        private void InsertLocationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
