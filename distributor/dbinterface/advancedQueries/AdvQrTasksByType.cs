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

namespace dbinterface.advancedQueries
{
    public partial class AdvQrTasksByType : Form
    {
        DB _db;

        public AdvQrTasksByType(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AdvQrTasksByType_Load(object sender, EventArgs e)
        {
            StoreComboBoxTaskType();
        }

        /// <summary>
        /// store the combobox with the task type
        /// </summary>
        private void StoreComboBoxTaskType()
        {
            DataTable dt = _db.AllTaskType();
            comboTaskType.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    comboTaskType.Items.Add(item);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            DataTable dt = _db.CallShowTaskByType(comboTaskType.Text);
            if (dt.Rows.Count < 1)
                dataGridView.DataSource = _db.GetEmptyDataTable();
            else
                dataGridView.DataSource = dt;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            StoreComboBoxTaskType();
        }

        private void comboTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
