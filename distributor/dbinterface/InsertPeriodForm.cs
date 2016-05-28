using System;
using System.Drawing;
using System.Windows.Forms;
using distributor;

namespace dbinterface
{
    public partial class InsertPeriodForm : Form
    {
        DB _db;
        updateType _t;
        int _id;

        public InsertPeriodForm(DB db, updateType t)
        {
            InitializeComponent();
            _db = db;
            _t = t;
        }
        public InsertPeriodForm(DB db, updateType t, int idToChange)
        {
            InitializeComponent();
            _db = db;
            _t = t;
            _id = idToChange;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string funcRes = _db.InsertPeriod(txtPeriod.Text,_t,_id.ToString());
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
