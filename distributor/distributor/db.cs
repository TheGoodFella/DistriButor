using System;
using System.Data;
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

        #region queries

        public DataTable queryTemplate(string query)
        {
            cn.Open();
            DataTable dt = new DataTable();
            cmd = new MySqlCommand(query, cn);

            dt.Load(cmd.ExecuteReader());

            cn.Close();

            return dt;
        }

        public DataTable testQuery()
        {
            return queryTemplate("select \"hello!\"");
        }

        public DataTable SelectAllTasks()
        {
            return queryTemplate("select * from tasks");
        }

        #endregion
    }
}
