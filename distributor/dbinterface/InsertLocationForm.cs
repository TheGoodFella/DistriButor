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
    public partial class InsertLocationForm : Form
    {
        public string Country { get; set; }
        public string _Region { get; set; }
        public string Province { get; set; }

        public InsertLocationForm()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Country = txtCountry.Text;
            _Region = txtRegion.Text;
            Province = txtProvince.Text;
        }
    }
}
