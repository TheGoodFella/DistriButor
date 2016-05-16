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
    public partial class InsertPhoneForm : Form
    {
        public string Phone { get; private set; }

        public InsertPhoneForm()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Phone = txtPhone.Text;
        }
    }
}
