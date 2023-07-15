using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinic.BL
{
    class CLS_Job
    {
        DAL.DataBase dal = new DAL.DataBase();
        public DataTable AllJob()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllJob", null);
            dal.Close();
            return dt;
        }

        public void AddJob(string Mhnapation)
        {
            SqlParameter[] param = new SqlParameter[1];          

            param[0] = new SqlParameter("@Mhnapation", SqlDbType.NVarChar, 15);
            param[0].Value = Mhnapation;

            dal.Open();
            dal.ExecuteCommand("AddJob", param);
            dal.Close();
        }

        public DataTable VerifiyJob(string Job)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mhnapation", SqlDbType.NVarChar, 30);
            param[0].Value = Job;            

            dal.Open();
            DataTable dt = dal.SelectData("VerifiyJob", param);
            dal.Close();
            return dt;
        }
    }
}
