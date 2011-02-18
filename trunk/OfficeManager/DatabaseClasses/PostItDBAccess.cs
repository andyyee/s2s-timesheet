using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace OfficeManager.DatabaseClasses
{
    class PostItDBAccess:DBAccess
    {
        private const String tableName = "PostItNote";
        private SqlParameter user_id = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
        private SqlParameter start_date_time = new SqlParameter("@start_date_time", SqlDbType.DateTime);
        private SqlParameter end_date_time = new SqlParameter("@end_date_time", SqlDbType.DateTime);
        private SqlParameter subject = new SqlParameter("@subject", SqlDbType.VarChar, 50);
        private SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar);
        private SqlParameter is_announcement = new SqlParameter("@is_announcement", SqlDbType.Bit);

        public PostItDBAccess()
        {
  
        }

        public int getPostItByID(String id)
        {
            user_id.Value = id;
            DateTime date =  DateTime.Now;
            start_date_time.Value = date;
            end_date_time.Value = date;
            myConnection.Open();
            command.CommandText = "INSERT INTO " + tableName + " VALUES('2','@user_id','@start_date_time','@end_date_time',' ',' ','1')";
            command.Parameters.Add(start_date_time);
            command.Parameters.Add(end_date_time);
            
            command.Parameters.Add(user_id);
            command.ExecuteNonQuery();
            command.Parameters.Remove(start_date_time);
            command.CommandText = "SELECT * FROM " + tableName + " WHERE user_id = @user_id";
            

            
            DataSet set = new DataSet();
           
            SqlDataReader data = command.ExecuteReader();
            data.Close();

            SqlDataAdapter adapt = new SqlDataAdapter();
            adapt.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapt.SelectCommand = command;
            //command.
            adapt.Fill(set);

            set.Tables[0].Rows.Count.ToString();
            myConnection.Close();
            return set.Tables[0].Rows.Count;
        }
    }
}
