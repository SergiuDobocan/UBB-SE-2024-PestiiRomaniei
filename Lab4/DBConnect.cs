using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ISS
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\IssDB.mdf; Integrated Security = True"); //Specify your connection string to the database

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
