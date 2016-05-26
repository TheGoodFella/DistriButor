using System;
using System.Drawing;
using System.Windows.Forms;
using distributor;
using System.Text.RegularExpressions;

namespace dbinterface
{
    public partial class InsertJobForm : Form
    {
        DB _db;
        
        public InsertJobForm(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");

            string funcRes = _db.InsertJob(txtJobName.Text, date);
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

        private void txtJobName_KeyPress(object sender, KeyPressEventArgs e)
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
