using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OfficeManager.DBAccess
{
    class SqlADO
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                string userName = "ucfuser";
                string password = "ucfuser";

                SqlConnection cSQLConnection = new SqlConnection();

                cSQLConnection.ConnectionString = "User ID='" + userName + "'; Password='" + password +
                "';Database='UCFOfficeManager';" + "Server='WS-KRISTINA-VOS\\ucfofficemanager'";

                cSQLConnection.Open();

                return cSQLConnection;
            }

            catch
            {
                throw new ApplicationException();
            }

        }

        public static DataSet RunQuery(ref SqlConnection cCallerConnection, ref SqlDataAdapter imp_cDataAdapter, String imp_sSelectSQL,
        SqlCommand imp_oInsertCommand, SqlCommand imp_oUpdateCommand, SqlCommand imp_oDeleteCommand)
        {
            SqlCommand cSQLCommand = new SqlCommand(); 
            DataSet cDataSet = new DataSet(); 
            SqlCommandBuilder oCmdBuilder = new SqlCommandBuilder();

            String sToken;

            try
            {
                if (cCallerConnection == null)
                {
                    MessageBox.Show("No data connection passed in");

                    return null;
                }

                //Build SQl Select Command object for execution
                cSQLCommand.CommandType = CommandType.Text;
                cSQLCommand.CommandText = imp_sSelectSQL;
                cSQLCommand.Connection = cCallerConnection;

                sToken = imp_sSelectSQL.Substring(0, 4);
                if ("INSE,DELE,UPDA,CREA,ALTE,DROP,EXEC".Contains(sToken.ToUpper()))
                {
                    cSQLCommand.ExecuteNonQuery();
                    return null;
                }

                else
                {
                    cDataSet.EnforceConstraints = false;
                    //Execute SELECT query command and fill dataset with returned resultset
                    imp_cDataAdapter = new SqlDataAdapter();
                    imp_cDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    imp_cDataAdapter.SelectCommand = cSQLCommand;
                    imp_cDataAdapter.Fill(cDataSet);


                    if (imp_oInsertCommand == null)
                    {
                        oCmdBuilder = new SqlCommandBuilder(imp_cDataAdapter);
                        imp_cDataAdapter.InsertCommand = oCmdBuilder.GetInsertCommand();
                    }

                    else
                    {
                        imp_cDataAdapter.InsertCommand = imp_oInsertCommand;
                    }

                    if (imp_oUpdateCommand == null)
                    {
                        oCmdBuilder = new SqlCommandBuilder(imp_cDataAdapter);
                        imp_cDataAdapter.UpdateCommand = oCmdBuilder.GetUpdateCommand();
                    }

                    else
                    {
                        imp_cDataAdapter.UpdateCommand = imp_oUpdateCommand;
                    }

                    if (imp_oDeleteCommand == null)
                    {
                        oCmdBuilder = new SqlCommandBuilder(imp_cDataAdapter);
                        imp_cDataAdapter.DeleteCommand = oCmdBuilder.GetDeleteCommand();
                    }

                    else
                    {
                        imp_cDataAdapter.DeleteCommand = imp_oDeleteCommand;
                    }

                    return cDataSet;
                }
            }

            catch (Exception ex)
            {
                throw new ApplicationException();
            }


            finally
            {
                cDataSet.Dispose();
                cSQLCommand.Dispose();
            }
        }
    }
}
