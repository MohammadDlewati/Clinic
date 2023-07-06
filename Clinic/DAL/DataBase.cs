using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinic.DAL
{
    class DataBase
    {
        private String connectionString = @"Data Source=DESKTOP-PL6QQTF\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        private SqlConnection sqlConnection;

        public DataBase()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public DataTable SelectData(String storedProcedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            return dt;
        }

        public void ExecuteCommand(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
        
            sqlCommand.ExecuteNonQuery();
            
        }

        public int ExecuteCount(string storedProcedure)
        {
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;

            return Convert.ToInt32(sqlCommand.ExecuteScalar());

        }

    }
}
