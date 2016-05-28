using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace distributor
{
    public enum ListNav
    {
        allWorkers,
        showSoldCopies,
        PhoneNumbers,
        AllMagazines,
        allMagRelases,
        allLocations,
        allTasks,
        allJobs,
        allPeriods,
        allNewsstands
    }

    public class DB
    {
        #region properties

        public MySqlConnection cn { get; set; }

        public MySqlCommand cmd { get; set; }

        #endregion



        public DB()
        {
            cn = new MySqlConnection();
        }

        /// <summary>
        /// define the connection string to connect to the database
        /// </summary>
        /// <param name="database">db name</param>
        /// <param name="dataSource">db server address</param>
        /// <param name="port">db server port</param>
        /// <param name="user">your username to access to db</param>
        /// <param name="password">your password to access to db</param>
        public DB(string database,string dataSource,string port,string user,string password)
        {
            cn = new MySqlConnection("Database=" + database + ";Data Source=" + dataSource + ";Port=" + port + ";User Id=" + user + ";Password=" + password+ ";SSL Mode=PREFERRED;Keepalive=60"); 
        }

        /// <summary>
        /// default empty datatable for empty set queries or functions/procedures errors. Datatable column title: no data, row text: empty set 
        /// </summary>
        /// <returns>the universal empty set datatable</returns>
        public DataTable GetEmptyDataTable()
        {
            DataTable dt_temp = new DataTable();

            dt_temp.Columns.Add("no data");
            dt_temp.Rows.Add("empty set");
            return dt_temp;
        }

        #region stored functions
        
        /// <summary>
        /// execute the functions stored in the MySqlCommand (cmd). All stored functions methods call this to actually execute the stored function
        /// </summary>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        private string CallFunctionTemplate()
        {
            string res = "";

            try
            {
                cn.Open();
                res = cmd.ExecuteScalar().ToString();
                
            }
            catch(MySqlException)
            {
                res = "-1";  //-1 is my convention for ERROR
            }
            cn.Close();
            return res;
        }

        public string LocationExist(string province)
        {
            string q = "SELECT locationExist(@province)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@province", province);
            return CallFunctionTemplate();
        }

        /// <summary>
        /// add a new location
        /// </summary>
        /// <param name="country">Country</param>
        /// <param name="region">Region</param>
        /// <param name="province">Province</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertLocation(string country, string region, string province)
        {
            string q = "SELECT insertLocation(@country,@region,@province)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@region", region);
            cmd.Parameters.AddWithValue("@province", province);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// add a new phone number to somebody, and eventually add a new "somebody"
        /// </summary>
        /// <param name="phoneNumber">the phone number</param>
        /// <param name="lastnameOwner">lastname of the phone number owner</param>
        /// <param name="nameOwner">name of the phone number owner</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertPhoneNumber(string phoneNumber, string lastnameOwner,string nameOwner)
        {
            string q = "SELECT insertPhoneNumber(@phoneN,@lastnameOwner,@nameOwner)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@phoneN", phoneNumber);
            cmd.Parameters.AddWithValue("@lastnameOwner", lastnameOwner);
            cmd.Parameters.AddWithValue("@nameOwner", nameOwner);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// insert a new worker, and eventually add new location if not listed yet
        /// </summary>
        /// <param name="lastName">lastname</param>
        /// <param name="name">name</param>
        /// <param name="email">email</param>
        /// <param name="dateOfBirth">date of birth</param>
        /// <param name="province">province where he lives</param>
        /// <param name="city">city where he lives</param>
        /// <param name="zipcode">city zipcode</param>
        /// <param name="address">home address</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertWorker(string lastName,string name,string email,string dateOfBirth,string province, string city,string zipcode,string address)
        {
            string q = "SELECT insertWorker(@lastname,@name,@email,@dateOfBirth,@province,@city,@zipcode,@address)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@lastname", lastName);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@province", province);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@zipcode", zipcode);
            cmd.Parameters.AddWithValue("@address", address);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// insert a new newsstand, and eventually add new location and/or a new owner, if not listed yet 
        /// </summary>
        /// <param name="businessName">business name</param>
        /// <param name="piva">VAT number</param>
        /// <param name="city">newsstand city location</param>
        /// <param name="zipCode">city zipcode</param>
        /// <param name="address">newsstand address</param>
        /// <param name="province">newsstand province (from locations table)</param>
        /// <param name="newsstandPhone">newsstand landline</param>
        /// <param name="lastnameOwner">owner lastname</param>
        /// <param name="nameOwner">owner name</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertNewsStand(string businessName,string piva,string city,string zipCode,string address,string province,string newsstandPhone,string lastnameOwner,string nameOwner)
        {
            string q = "SELECT insertNewsStand(@businessName,@piva,@city,@zipCode,@address,@province,@newsstandPhone,@lastnameOwner,@nameOwner)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@businessName", businessName);
            cmd.Parameters.AddWithValue("@piva", piva);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@zipCode", zipCode);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@province", province);
            cmd.Parameters.AddWithValue("@newsstandPhone", newsstandPhone);
            cmd.Parameters.AddWithValue("@lastnameOwner", lastnameOwner);
            cmd.Parameters.AddWithValue("@nameOwner", nameOwner);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// call a simple function to check if you are connected to the database and the login was successful
        /// </summary>
        /// <returns>1 if success</returns>
        public string CheckLogIn()
        {
            string q = "SELECT checkLogIn()";
            cmd = new MySqlCommand(q, cn);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// insert a new magazine, and eventually add a new owner, if not listed yet
        /// </summary>
        /// <param name="title">magazine title</param>
        /// <param name="period">magazine periodicity</param>
        /// <param name="lastnameOwner">magazine owner lastname</param>
        /// <param name="nameOwner">magazine owner name</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertMagazine(string title,string period,string lastnameOwner,string nameOwner)
        {
            string q = "SELECT insertMagazine(@title,@period,@lastnameOwner,@nameOwner)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@period", period);
            cmd.Parameters.AddWithValue("@lastnameOwner", lastnameOwner);
            cmd.Parameters.AddWithValue("@nameOwner", nameOwner);

            return CallFunctionTemplate();
        }


        /// <summary>
        /// add a new magazine relase, and eventually add a new magazine, if not listed
        /// </summary>
        /// <param name="magName">magazine name</param>
        /// <param name="magNumber">magazine number</param>
        /// <param name="dateRelase">relase date</param>
        /// <param name="nameRelase">relase name (for example: "april number")</param>
        /// <param name="priceToPublic">price to the public</param>
        /// <param name="percentToNS">percentage of price to public that the the newsstand earns</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertMagRelase(string magName,string magNumber,string dateRelase,string nameRelase,string priceToPublic,string percentToNS)
        {
            string q = "SELECT insertMagRelase(@magName,@magNumber,@dateRelase,@nameRelase,@priceToPublic,@percentToNS)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@magName", magName);
            cmd.Parameters.AddWithValue("@magNumber", magNumber);
            cmd.Parameters.AddWithValue("@dateRelase", dateRelase);
            cmd.Parameters.AddWithValue("@nameRelase", nameRelase);
            cmd.Parameters.AddWithValue("@priceToPublic", priceToPublic);
            cmd.Parameters.AddWithValue("@percentToNS", percentToNS);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// insert a new period
        /// </summary>
        /// <param name="period">peridiocity (monthly,weekly, etc)</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertPeriod(string period)
        {
            string q = "SELECT insertPeriod(@period)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@period", period);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// insert a new job (a job is a set of tasks, a task is a delivery/recovery magazines to one newsstand)
        /// </summary>
        /// <param name="jobName">the job name</param>
        /// <param name="jobDate">the job date</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertJob(string jobName,string jobDate)
        {
            string q = "SELECT insertJob(@jobName,@jobDate)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@jobName", jobName);
            cmd.Parameters.AddWithValue("@jobDate", jobDate);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// returns the amount of jobs
        /// </summary>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string HowManyJobs()
        {
            string q = "SELECT howManyJobs()";
            cmd = new MySqlCommand(q, cn);

            return CallFunctionTemplate();
        }

        /// <summary>
        /// insert a new task
        /// </summary>
        /// <param name="taskName">task name</param>
        /// <param name="nCopies">number of magazines copies</param>
        /// <param name="typeTask">the task type (must be "deliver" or "returner"</param>
        /// <param name="magTitle">magazine title</param>
        /// <param name="magNumber">magazine number</param>
        /// <param name="nsBusinessName">newsstand's business name</param>
        /// <param name="lastNameWorker">lastname of the distributor</param>
        /// <param name="nameWorker">name of the distributor</param>
        /// <param name="jobName">job name (this task must belong to a job)</param>
        /// <param name="jobDate">job date</param>
        /// <returns>the returned value from stored function on database. Return -1 if an error occurred</returns>
        public string InsertTask(string taskName, string nCopies, string typeTask, string magTitle, string magNumber, string nsBusinessName, string lastNameWorker, string nameWorker, string jobName, string jobDate)
        {
            string q = "SELECT insertTask(@taskName,@nCopies,@typeTask,@magTitle,@magNumber,@nsBusinessName,@lastNameWorker,@nameWorker,@jobName,@jobDate)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@taskName", taskName);
            cmd.Parameters.AddWithValue("@nCopies", nCopies);
            cmd.Parameters.AddWithValue("@typeTask", typeTask);
            cmd.Parameters.AddWithValue("@magTitle", magTitle);
            cmd.Parameters.AddWithValue("@magNumber", magNumber);
            cmd.Parameters.AddWithValue("@nsBusinessName", nsBusinessName);
            cmd.Parameters.AddWithValue("@lastNameWorker", lastNameWorker);
            cmd.Parameters.AddWithValue("@nameWorker", nameWorker);
            cmd.Parameters.AddWithValue("@jobName", jobName);
            cmd.Parameters.AddWithValue("@jobDate", jobDate);

            return CallFunctionTemplate();
        }

        #endregion

        #region stored procedures

        /// <summary>
        /// execute the procedure stored in the MySqlCommand (cmd). All stored procedure methods call this to actually execute the stored procedure
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        private DataTable CallProcedureTemplate()
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                dt.Load(cmd.ExecuteReader());
                
            }
            catch (MySqlException)
            {
                dt = GetEmptyDataTable();  //ERROR
            }
            cn.Close();
            return dt;
        }

        /// <summary>
        /// show tasks information
        /// </summary>
        /// <param name="taskType">tasktype: deliver or returner</param>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable CallShowTaskByType(string taskType)
        {
            string q = "CALL showtaskByType(@typetask)";
            
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@typetask", taskType);
            
            return CallProcedureTemplate();
        }

        /// <summary>
        /// show all the sold copies and their iformations
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable CallShowSoldCopies()
        {
            string q = "CALL showSoldCopies()";

            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        /// <summary>
        /// all provinces in locations table
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable allProvinces()
        {
            string q = "CALL allProvince()";
            cmd = new MySqlCommand(q, cn);
            
            return CallProcedureTemplate();
        }

        /// <summary>
        /// shows all owners lastname and name order by lastname
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable allOwners()
        {
            string q = "CALL allOwners()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        /// <summary>
        /// shows all workers info order by lastname
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllWorkers()
        {
            string q = "CALL allWorkers()";
            cmd = new MySqlCommand(q, cn);
            return CallProcedureTemplate();
        }

        /// <summary>
        /// shows worker lastname and name with his phone number, order by lastname
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable PhoneNumbersName()
        {
            string q = "CALL workersPhoneNumber()";
            cmd = new MySqlCommand(q, cn);
            return CallProcedureTemplate();
        }

        public DataTable allPeriods()
        {
            string q = "CALL allPeriods()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        /// <summary>
        /// magazines info (title,period,owner)
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllMagazines()
        {
            string q = "CALL allMagazines()";
            cmd = new MySqlCommand(q, cn);
            return CallProcedureTemplate();
        }

        /// <summary>
        /// all magazines title
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllMagazinesName()
        {
            string q = "CALL allMagazinesName()";
            cmd = new MySqlCommand(q, cn);
            return CallProcedureTemplate();
        }

        /// <summary>
        /// all magazine relases with magazine titles instead of magazine index
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllMagRelases()
        {
            string q = "CALL allMagRelases()";
            cmd = new MySqlCommand(q, cn);
            return CallProcedureTemplate();
        }

        /// <summary>
        /// all locations procedure
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllLocations()
        {
            string q = "CALL allLocations()";
            cmd = new MySqlCommand(q, cn);
            return CallProcedureTemplate();
        }

        /// <summary>
        /// returns all tasks by idJob
        /// </summary>
        /// <param name="idJob">id Job</param>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable TasksByIDJob(string idJob)
        {
            string q = "CALL tasksByIDJob(@idJob)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@idJob", idJob);

            return CallProcedureTemplate();
        }

        /// <summary>
        /// shows all the relases of a magazine
        /// </summary>
        /// <param name="magazineName">magazine name</param>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable RelaseNumbersByMagName(string magazineName)
        {
            string q = "CALL relaseNumbersByMagName(@magName)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@magName", magazineName);

            return CallProcedureTemplate();
        }

        /// <summary>
        /// shows all the jobs of a day
        /// </summary>
        /// <param name="jobDate">job date</param>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllJobsByDate(string jobDate)
        {
            string q = "CALL allJobsByDate(@jobDate)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@jobDate", jobDate);

            return CallProcedureTemplate();
        }

        /// <summary>
        /// shows all newsstand business name
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllBusinessName()
        {
            string q = "CALL allBusinessName()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        /// <summary>
        /// shows all the task type
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        public DataTable AllTaskType()
        {
            string q = "CALL allTaskType()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        public DataTable AllJobsDate()
        {
            string q = "CALL allJobsDate()";
            cmd = new MySqlCommand(q, cn);
            return CallProcedureTemplate();
        }

        public DataTable ShowAllTasks()
        {
            string q = "CALL showAllTasks()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        public DataTable TasksByJob(string jobName,string jobDate)
        {
            string q = "CALL tasksByJob(@jobName,@jobDate)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@jobName", jobName);
            cmd.Parameters.AddWithValue("@jobDate", jobDate);

            return CallProcedureTemplate();
        }

        public DataTable AllJobs()
        {
            string q = "CALL allJobs()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        public DataTable AllNewsstands()
        {
            string q = "CALL allNewsstands()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        public DataTable ShowSoldCopiesInvoiced(bool b)
        {
            string q = "CALL showSoldCopiesInvoiced(@b)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@b", (b == true ? 1 : 0));  //if b is true send 1, if false 0

            return CallProcedureTemplate();
        }

        #endregion

        #region queries

        /// <summary>
        /// execute the query stored in the MySqlCommand (cmd). All queries methods call this to actually execute the query
        /// </summary>
        /// <returns>the DataTable with the procedure output. If an error occurred, returns the default empty DataTable</returns>
        private DataTable queryTemplate()
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                dt.Load(cmd.ExecuteReader());
                
            }
            catch (MySqlException)
            {
                dt = GetEmptyDataTable();  //ERROR
            }
            cn.Close();
            return dt;
        }

        #endregion
    }
}
