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
    public partial class InsertWorkerForm : Form
    {
        public InsertWorkerForm()
        {
            InitializeComponent();
        }

        public InsertWorkerForm(List<string> provinces)
        {
            InitializeComponent();
            for (int i = 0; i < provinces.Count; i++)
                comboLocation.Items.Add(provinces[i]);
        }
    }
}
