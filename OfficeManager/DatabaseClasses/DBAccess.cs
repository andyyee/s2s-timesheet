using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace OfficeManager.DatabaseClasses
{
    class DBAccess
    {

        private String connectionString;
        protected SqlConnection myConnection;
        protected SqlCommand command;

        public DBAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            myConnection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = myConnection;
            
        }
    }
}
