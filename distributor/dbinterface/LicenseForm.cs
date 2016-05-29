using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace dbinterface
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            //txt.Text = LoadLicenses();
        }

        private string LoadLicenses()
        {
            StringBuilder sb = new StringBuilder();
            
            //load license from resources... it doesn't work

            return sb.ToString();
        }

        private void txt_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
