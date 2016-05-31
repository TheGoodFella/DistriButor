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
            txt.Text = LoadLicenses();
        }

        private string LoadLicenses()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("repository of this project: https://github.com/TheGoodFella/DistriButor \nDistriButor License:\n\n");
            sb.Append(dbinterface.Properties.Resources.DistruButorLicense);

            sb.Append("\n\n\nThird-party licenses:\n");
            sb.Append(dbinterface.Properties.Resources.DistriButorTPL);

            return sb.ToString();
        }

        private void txt_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
