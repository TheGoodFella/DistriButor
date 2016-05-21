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
    public partial class InsertPeriodForm : Form
    {
        DB _db;

        public InsertPeriodForm(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string funcRes = _db.InsertPeriod(txtPeriod.Text);
            UpdateStatusStrip(funcRes);
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
    }
}
