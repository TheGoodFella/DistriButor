using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using distributor;
using dbinterface.advancedQueries;
using System.Collections.Generic;

namespace dbinterface
{
    public partial class MainForm : Form
    {
        DB db;
        LoginForm login;
        InsertLocationForm insLocation;
        InsertPhoneForm insPhone;
        InsertWorkerForm insWorker;
        InsertNewsstandForm insNewsstand;
        InsertMagazineForm insMagazine;
        InsertPeriodForm insPeriod;
        InsertMagRelaseForm insMagRelase;
        InsertJobForm insjob;
        InsertTaskForm insTask;
        AdvQrTasksForm advTask;
        AdvQrTasksByType advTaskByType;
        AdvQrSoldCopies advSoldCp;

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStripLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void menuStripInsLocations_Click(object sender, EventArgs e)
        {
            insLocation = new InsertLocationForm(db, updateType.insert);
            insLocation.ShowDialog();
        }

        private void menuStripInsPhoneN_Click(object sender, EventArgs e)
        {
            insPhone = new InsertPhoneForm(db,updateType.insert);
            insPhone.ShowDialog();
        }

        /// <summary>
        /// update text and color of the label in the status strip
        /// </summary>
        /// <param name="text">text</param>
        /// <param name="color">text color (forecolor)</param>
        private void UpdateStatusStrip(string text, Color color)
        {
                statusMySQL.BackColor = color;
                statusMySQL.Text = text;
        }

        /// <summary>
        /// shows login form and creates a new db instance with the login credentials
        /// </summary>
        private void LogIn()
        {
            login = new LoginForm(db);  //create login form
            DialogResult loginRes = login.ShowDialog();  //show login form and store the dialog result (OK if login button is clicked, calcel if cancel button is clicked, simple isn't it?)
            if (loginRes == DialogResult.OK)
            {
                db = new DB(login.Database, login.DataSource, login.Port, login.User, login.Password);  //create a new instance of db with the new credentials
                string funcRes = db.CheckLogIn();
                if(funcRes=="1")
                    UpdateStatusStrip("ready", SystemColors.Control);  //if the checklogin success, set the label properly
                if(funcRes=="-1")
                    UpdateStatusStrip("login failed", Color.Red);  //if failed, red write to the label 
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new DB();
            LogIn();

           
            RefreshAll();
        }

        

        /// <summary>
        /// store combobox in the binding navigation from the enum
        /// </summary>
        private void StoreComboBoxFromEnum()
        {
            toolStripComboBox.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(ListNav)))
                toolStripComboBox.Items.Add(item.ToString());

            if (toolStripComboBox.Items.Count >= 1)
                toolStripComboBox.SelectedIndex = 1;
        }

        private void menuStripInsWorker_Click(object sender, EventArgs e)
        {
            insWorker = new InsertWorkerForm(db, updateType.insert);
            insWorker.ShowDialog();
        }

        private void menuStripInsNewsStand_Click(object sender, EventArgs e)
        {
            insNewsstand = new InsertNewsstandForm(db, updateType.insert);
            DialogResult res = insNewsstand.ShowDialog();
        }

        /// <summary>
        /// Refresh all that needs to be refreshed. PAY ATTENTION: if in a index change event of one of a combobox contained in this method, CALL RefreshDataGridView (or else) INSTEAD of RefreshAll. RefreshAll cause a recoursion , because it contains storing method of combobox.
        /// </summary>
        private void RefreshAll()
        {
            RefreshDataGridView();
            StoreComboBoxFromEnum();
            
        }

        /// <summary>
        /// refresh the datagrid view based on what is selected in the combobox
        /// </summary>
        private void RefreshDataGridView()
        {
            
            ListNav item;
            DataTable dt_temp = db.GetEmptyDataTable();


            if (!Enum.TryParse(toolStripComboBox.Text, out item))
            {
                dataGridView.DataSource = dt_temp;  //if failed, set the datagrid view with the default empty datatable
                return;
            }
            //if success, call the properly database procedure...
            switch(item)
            {
                case ListNav.allWorkers:
                    dt_temp = db.AllWorkers();
                    break;
                case ListNav.showSoldCopies:
                    dt_temp = db.CallShowSoldCopies();
                    break;
                case ListNav.PhoneNumbers:
                    dt_temp = db.PhoneNumbersName();
                    break;
                case ListNav.AllMagazines:
                    dt_temp = db.AllMagazines();
                    break;
                case ListNav.allMagRelases:
                    dt_temp = db.AllMagRelases();
                    break;
                case ListNav.allLocations:
                    dt_temp = db.AllLocations();
                    break;
                case ListNav.allTasks:
                    dt_temp = db.ShowAllTasks();
                    break;
                case ListNav.allJobs:
                    dt_temp = db.AllJobs();
                    break;
                case ListNav.allPeriods:
                    dt_temp = db.allPeriods();
                    break;
                case ListNav.allNewsstands:
                    dt_temp = db.AllNewsstands();
                    break;
                default:
                    dataGridView.Rows.Clear();
                    break;
            }

            dataGridView.DataSource = dt_temp;  //assign the datatable with the new values to the datagridview
            //dataGridView.Refresh();
        }

        private void menuStripInsMagazine_Click(object sender, EventArgs e)
        {
            insMagazine = new InsertMagazineForm(db, updateType.insert);
            insMagazine.ShowDialog();
        }

        private void menuStripInsPeriod_Click(object sender, EventArgs e)
        {
            insPeriod = new InsertPeriodForm(db, updateType.insert);
            insPeriod.ShowDialog();
        }

        private void menuStripInsMagRelase_Click(object sender, EventArgs e)
        {
            insMagRelase = new InsertMagRelaseForm(db, updateType.insert);
            insMagRelase.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void menuStripInsJob_Click(object sender, EventArgs e)
        {
            insjob = new InsertJobForm(db, updateType.insert);
            insjob.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("repository of this project: \n"+@"https://github.com/TheGoodFella/DistriButor" +
                            "\n\nDeveloped by Daniele Galas" +
                            "\nLicensed under MIT license"+
                            "\nCopyright (c) 2016 Daniele Galas"+
                            "\nVersion: 0.1",
                            "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStripInsTask_Click(object sender, EventArgs e)
        {
            insTask = new InsertTaskForm(db, updateType.insert);
            insTask.ShowDialog();
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advTask = new AdvQrTasksForm(db);
            advTask.Show();
        }

        private void btnAdvTaskByType_Click(object sender, EventArgs e)
        {
            advTaskByType = new AdvQrTasksByType(db);
            advTaskByType.Show();
        }

        private void btnAdvSoldCopies_Click(object sender, EventArgs e)
        {
            advSoldCp = new AdvQrSoldCopies(db);
            advSoldCp.Show();
        }

        private void contextbtnUpdate_Click(object sender, EventArgs e)
        {
            ManageValues(true);
        }

        /// <summary>
        /// update or delete values
        /// </summary>
        /// <param name="update">true if you want update the values, false if you want delete them</param>
        private void ManageValues(bool update)
        {
            if (!update)
            {
                DialogResult res = MessageBox.Show("PAY ATTENTION: \nif you delete an item, ALL the fields related with the item will be DELETED AS WELL"+
                    "\nThis action CAN NOT be undone"+
                    "\nif you want to keep the information we recommend to update the record instead of delete it" +
                    "\nDelete the item/s?", 
                    "Pay attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;
            }

            ListNav item;
            if (!Enum.TryParse(toolStripComboBox.Text, out item))
                return;

            DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;  //selected rows

            switch (item)
            {
                case ListNav.allLocations:
                    UpdateLocation(rows, update);
                    break;
                case ListNav.allWorkers:
                    UpdateWorkers(rows,update);
                    break;
            }

            RefreshDataGridView();
        }

        private void UpdateWorkers(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.WorkerExist(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()));  //populate id list by call LocationsExist.

            if (update)
            {
                insWorker = new InsertWorkerForm(db, updateType.update, int.Parse(listIDs[0]));
                insWorker.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    foreach (var item in listIDs)
                        db.InsertWorker("","","","","","","","", updateType.delete, item.ToString());
                    ShowItemsDeletedMessage();
                }
                else
                    return;
            }
        }

        private void UpdateLocation(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.LocationExist(row.Cells[2].Value.ToString()));  //populate id list by call LocationsExist. Cell[2] is the cell contains the province
            
            if(update)
            {
                insLocation = new InsertLocationForm(db, updateType.update, int.Parse(listIDs[0]));
                insLocation.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    foreach (var item in listIDs)
                        db.InsertLocation(null, null, null, updateType.delete, item.ToString());
                    ShowItemsDeletedMessage();
                }
                else
                    return;
            }
        }

        private bool LastDeleteNotice(int itemsCount)
        {
            DialogResult res = MessageBox.Show(itemsCount + " items and ALL the information related to them will be deleted. Continue?",
                    "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return false; //click no
            return true; //click yes
        }

        private void contextUpdate_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if the selected items are more than 1, you can only delete them, not update

            if (dataGridView.SelectedRows.Count >= 2)
                contextUpdate.Items[0].Enabled = false;
            else
                contextUpdate.Items[0].Enabled = true;
        }

        private void contextBtnDelete_Click(object sender, EventArgs e)
        {
            ManageValues(false);
        }

        private void ShowItemsDeletedMessage()
        {
            MessageBox.Show("Item/s deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
