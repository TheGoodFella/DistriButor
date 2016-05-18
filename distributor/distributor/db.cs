using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace distributor
{
    public class DB
    {
        #region properties

        public MySqlConnection cn { get; set; }

        public MySqlCommand cmd { get; set; }

        #endregion



        public DB() { }

        //"Database=Agenzia;Data Source=inf2-23;User Id=Studente;Password=Studente5Bi"
        public DB(string database,string dataSource,string port,string user,string password)
        {
            cn = new MySqlConnection("Database=" + database + ";Data Source=" + dataSource + ";Port=" + port + ";User Id=" + user + ";Password=" + password);
        }

        #region stored functions
        
        private string CallFunctionTemplate()
        {
            string res;

            cn.Open();
            res = cmd.ExecuteScalar().ToString();
            cn.Close();

            return res;
        }

        public string InsertLocation(string country, string region, string province)
        {
            string q = "SELECT insertLocation(@country,@region,@province)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@region", region);
            cmd.Parameters.AddWithValue("@province", province);

            return CallFunctionTemplate();
        }

        public string InsertPhoneNumber(string phoneNumber)
        {
            string q = "SELECT insertPhoneNumber(@phoneN)";
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@phoneN", phoneNumber);

            return CallFunctionTemplate();
        }

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

        #endregion

        #region stored procedures

        private DataTable CallProcedureTemplate()
        {
            DataTable dt = new DataTable();

            cn.Open();
            dt.Load(cmd.ExecuteReader());

            cn.Close();

            return dt;
        }

        public DataTable CallShowTask(string taskType)
        {
            string q = "CALL showtask(@typetask)";
            
            cmd = new MySqlCommand(q, cn);
            cmd.Parameters.AddWithValue("@typetask", taskType);
            
            return CallProcedureTemplate();
        }

        public DataTable CallShowSoldCopies()
        {
            string q = "CALL showSoldCopies()";

            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        public DataTable allProvinces()
        {
            string q = "CALL allProvince()";
            cmd = new MySqlCommand(q, cn);
            
            return CallProcedureTemplate();
        }

        public DataTable allOwners()
        {
            string q = "CALL allOwners()";
            cmd = new MySqlCommand(q, cn);

            return CallProcedureTemplate();
        }

        #endregion

        #region queries

        private DataTable queryTemplate()
        {
            DataTable dt = new DataTable();

            cn.Open();

            dt.Load(cmd.ExecuteReader());
            
            cn.Close();

            return dt;
        }

        public DataTable testQuery()
        {
            cmd = new MySqlCommand("select \"hello!\"", cn);
            return queryTemplate();
        }

        public DataTable SelectAllTasks()
        {
            cmd = new MySqlCommand("select * from tasks", cn);
            return queryTemplate();
        }

        public DataTable SelectAllLocations()
        {
            cmd = new MySqlCommand("select * from locations", cn);
            return queryTemplate();
        }

        public DataTable SelectAllPhones()
        {
            cmd = new MySqlCommand("select * from phoneNumbers", cn);
            return queryTemplate();
        }

        #endregion
    }
}
