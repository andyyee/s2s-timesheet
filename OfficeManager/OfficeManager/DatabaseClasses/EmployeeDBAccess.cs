using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using OfficeManager;

/*
 * Needs to be implemented
 * 
 */
namespace OfficeManager.DatabaseClasses
{
    class EmployeeDBAccess:DBAccess
    {
        public EmployeeDBAccess()
        {
            
        }

        public String getEmployee(String id)
        {
            myConnection.Open();
            myConnection.Close();
            return "";
        }
    }
}
