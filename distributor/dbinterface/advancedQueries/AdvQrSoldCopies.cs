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
    public partial class AdvQrSoldCopies : Form
    {
        DB _db;

        public AdvQrSoldCopies(DB db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void checkInvoice_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            dataGridView.DataSource = _db.ShowSoldCopiesInvoiced(checkInvoice.Checked);
        }

        private void AdvQrSoldCopies_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }
    }
}
