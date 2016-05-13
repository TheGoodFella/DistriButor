using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbinterface
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        public QueryForm(DataTable dt)
        {
            InitializeComponent();
            dataGridView.DataSource = dt;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
