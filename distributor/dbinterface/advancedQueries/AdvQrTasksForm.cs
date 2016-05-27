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
    public partial class AdvQrTasksForm : Form
    {
        DB _db;

        public AdvQrTasksForm(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AdvQueryForm_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void RefreshAll()
        {
            StoreComboBoxJobDate();
            StoreComboBoxJobName();
        }

        /// <summary>
        /// store the combobox with the job names
        /// </summary>
        private void StoreComboBoxJobName()
        {
            DataTable dt = _db.AllJobsByDate(comboJobDate.Text);
            comboJobName.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    comboJobName.Items.Add(item);
            comboJobName.Text = "";
        }

        /// <summary>
        /// store the jod date combobox with the job date (astounding, isnt it?)
        /// </summary>
        private void StoreComboBoxJobDate()
        {
            DataTable dt = _db.AllJobsDate();
            comboJobDate.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                {
                    DateTime timeTemp;
                    if (DateTime.TryParse(item.ToString(), out timeTemp))  //if the date is actually a date (just check, the bug is sneaky) add to combobox
                        comboJobDate.Items.Add(timeTemp.ToString("yyyy-MM-dd"));
                }


            comboJobDate.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            DataTable dt = _db.TasksByJob(comboJobName.Text, comboJobDate.Text);
            if (dt.Rows.Count < 1)
                dataGridView.DataSource = _db.GetEmptyDataTable();
            else
                dataGridView.DataSource = dt;
        }

        private void comboJobDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreComboBoxJobName();
            Search();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            StoreComboBoxJobDate();
        }

        private void comboJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
