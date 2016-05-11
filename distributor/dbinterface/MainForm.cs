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
    public partial class MainForm : Form
    {
        DB db;

        public MainForm()
        {
            new LoginForm().ShowDialog();
            InitializeComponent();
        }
    }
}
