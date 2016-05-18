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
    public partial class InsertNewsstandForm : Form
    {
        DB _db;
        InsertLocationForm insLocation;
        InsertWorkerForm insWorker;

        public InsertNewsstandForm()
        {
            InitializeComponent();
        }

        public InsertNewsstandForm(DB db)
        {
            InitializeComponent();
            _db = db;
            
            insLocation = new InsertLocationForm(_db);
            insWorker = new InsertWorkerForm(_db);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            insLocation.ShowDialog();

            StoreComboBoxProvince();
        }

        private void StoreComboBoxProvince()
        {
            DataTable dt = _db.allProvinces();
            comboLocation.Items.Clear();
            foreach (DataRow row in dt.Rows)
                foreach (var item in row.ItemArray)
                    comboLocation.Items.Add(item);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            insWorker.ShowDialog();

            StoreComboBoxOwners();
            StoreComboBoxProvince();
        }

        private void StoreComboBoxOwners()
        {
            DataTable dt = _db.allOwners();
            comboOwners.Items.Clear();
            foreach (DataRow row in dt.Rows)
                for (int i = 0; i < row.ItemArray.Length - 1; i++)
                    comboOwners.Items.Add(row.ItemArray[i].ToString() + " " + row.ItemArray[i + 1].ToString());
        }

        private void btnGO_Click(object sender, EventArgs e)
        {

        }

        private void InsertNewsstandForm_Load(object sender, EventArgs e)
        {
            StoreComboBoxProvince();
            StoreComboBoxOwners();
        }
    }
}
