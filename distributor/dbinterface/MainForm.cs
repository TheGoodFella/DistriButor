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
        LicenseForm licenseFrm;

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
                if (funcRes == "1") /*if login success*/
                {
                    UpdateStatusStrip("ready", SystemColors.Control);  //if the checklogin success, set the label properly

                    string welcomeMSG = db.welcomeMessage(); //show the welcome message from server
                    if (welcomeMSG != "-1")
                        MessageBox.Show(welcomeMSG, "Message from server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(funcRes=="-1") /*if login denied*/
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

        private ListNav comboSelectedItem()
        {
            ListNav item;

            if (Enum.TryParse(toolStripComboBox.Text, out item))  //get the equivalent enum from combobox text
                return item;

            return default(ListNav);
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
            MessageBox.Show("Developed by Daniele Galas" +
                            "\nLicensed under MIT license, see File>License for the details"+
                            "\nCopyright (c) 2016 Daniele Galas"+
                            "\nVersion: 0.2",
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
            if (!update)  //update is false, so user click on "delete"
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
                case ListNav.allWorkers:
                    UpdateWorkers(rows, update);
                    break;
                case ListNav.PhoneNumbers:
                    UpdatePhoneNumber(rows, update);
                    break;
                case ListNav.AllMagazines:
                    UpdateMagazine(rows, update);
                    break;
                case ListNav.allMagRelases:
                    UpdateMagRelase(rows, update);
                    break;
                case ListNav.allLocations:
                    UpdateLocation(rows, update);
                    break;
                case ListNav.allTasks:
                    UpdateTask(rows, update);
                    break;
                case ListNav.allJobs:
                    UpdateJobs(rows, update);
                    break;
                case ListNav.allPeriods:
                    UpdatePeriod(rows, update);
                    break;
                case ListNav.allNewsstands:
                    UpdateNewsstand(rows, update);
                    break;
            }

            RefreshDataGridView();
        }

        private void UpdatePhoneNumber(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.PhoneExist(row.Cells[0].Value.ToString()));  //populate id list.
            if (update)
            {
                insPhone = new InsertPhoneForm(db, updateType.update, int.Parse(listIDs[0]));
                insPhone.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertPhoneNumber("", "", "", updateType.delete, item.ToString());
                        if (res == "5")
                            n++;
                    }
                    ShowItemsDeletedMessage(n);
                }
                else
                    return;
            }
        }

        private void UpdateTask(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
            {
                DateTime d;
                DateTime.TryParse(row.Cells[11].Value.ToString(), out d);
                listIDs.Add(db.TaskExist(row.Cells[0].Value.ToString(), db.JobExist(row.Cells[10].Value.ToString(),d.ToString("yyyy-MM-dd")), db.NewsStandExist(row.Cells[5].Value.ToString())));  //populate id list.
            }
            if (update)
            {
                insTask = new InsertTaskForm(db, updateType.update, int.Parse(listIDs[0]));
                insTask.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertTask("", (-1).ToString(), "", "", (-1).ToString(), "", "", "", "", "", updateType.delete, item.ToString());
                        if (res == "9")
                            n++;
                    }
                        ShowItemsDeletedMessage(n);
                }
                else
                    return;
            }
        }

        private void UpdatePeriod(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.PeriodExist(row.Cells[0].Value.ToString()));  //populate id list.

            if (update)
            {
                insPeriod = new InsertPeriodForm(db, updateType.update, int.Parse(listIDs[0]));
                insPeriod.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertPeriod("", updateType.delete, item.ToString());
                        if (res == "4")
                            n++;
                    }
                    ShowItemsDeletedMessage(n);
                }
                else
                    return;
            }
        }

        private void UpdateNewsstand(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.NewsStandExist(row.Cells[1].Value.ToString()));  //populate id list.

            if (update)
            {
                insNewsstand = new InsertNewsstandForm(db, updateType.update, int.Parse(listIDs[0]));
                insNewsstand.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertNewsStand("","","","","","","","","",updateType.delete,item.ToString());
                        if (res == "5")
                            n++;
                    }
                    ShowItemsDeletedMessage(n);
                }
                else
                    return;
            }
        }

        private void UpdateMagRelase(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.MagRelaseExist(db.MagazineExist(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString()));  //populate id list.

            if (update)
            {
                insMagRelase = new InsertMagRelaseForm(db, updateType.update, int.Parse(listIDs[0]));
                insMagRelase.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertMagRelase("", (-1).ToString(), "", "", (0.0).ToString(), 0.ToString(), updateType.delete, item.ToString());
                        MessageBox.Show(item.ToString());
                        if (res == "5")
                            n++;
                    }
                    ShowItemsDeletedMessage(n);
                }
                else
                    return;
            }
        }

        private void UpdateMagazine(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.MagazineExist(row.Cells[0].Value.ToString()));  //populate id list.

            if (update)
            {
                insMagazine = new InsertMagazineForm(db, updateType.update, int.Parse(listIDs[0]));
                insMagazine.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertMagazine("","","","",updateType.delete,item.ToString());
                        if (res == "6")
                            n++;
                    }
                    ShowItemsDeletedMessage(n);
                }
                else
                    return;
            }
        }

        private void UpdateJobs(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
            {
                DateTime d;
                DateTime.TryParse(row.Cells[1].Value.ToString().ToString(), out d);
                listIDs.Add(db.JobExist(row.Cells[0].Value.ToString(), d.ToString("yyyy-MM-dd")));  //populate id list.
            }

            if (update)
            {
                insjob = new InsertJobForm(db, updateType.update, int.Parse(listIDs[0]));
                insjob.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertJob("","",updateType.delete,item.ToString());
                        if (res == "4")
                            n++;
                    }
                    ShowItemsDeletedMessage(n);
                }
                else
                    return;
            }
        }

        private void UpdateWorkers(DataGridViewSelectedRowCollection rows, bool update)
        {
            List<string> listIDs = new List<string>();  //id list

            foreach (DataGridViewRow row in rows)
                listIDs.Add(db.WorkerExist(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()));  //populate id list.

            if (update)
            {
                insWorker = new InsertWorkerForm(db, updateType.update, int.Parse(listIDs[0]));
                insWorker.ShowDialog();
            }
            else  //delete
            {
                if (LastDeleteNotice(rows.Count))
                {
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertWorker("", "", "", "", "", "", "", "", updateType.delete, item.ToString());
                        if (res == "5")
                            n++;
                    }
                    if (res == "5")
                        ShowItemsDeletedMessage(n);
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
                    int n = 0;
                    string res = "";
                    foreach (var item in listIDs)
                    {
                        res = db.InsertLocation(null, null, null, updateType.delete, item.ToString());
                        if (res == "4")
                            n++;
                    }
                    ShowItemsDeletedMessage(n);
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
            if (comboSelectedItem() == ListNav.showSoldCopies)
                contextUpdate.Enabled = false;
            else
            {
                contextUpdate.Enabled = true;
                if (dataGridView.SelectedRows.Count >= 2)
                    contextUpdate.Items[0].Enabled = false;
                else
                    contextUpdate.Items[0].Enabled = true;
            }
        }

        private void contextBtnDelete_Click(object sender, EventArgs e)
        {
            ManageValues(false);
        }

        private void ShowItemsDeletedMessage(int n)
        {
            MessageBox.Show(n + " item/s deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            licenseFrm = new LicenseForm();
            licenseFrm.ShowDialog();
        }

        private void toolStripComboBox_Click(object sender, EventArgs e)
        {

        }
    }
}
