using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinic.BL
{
    class CLS_Job_Husbend
    {
        DAL.DataBase dal = new DAL.DataBase();
        public DataTable AllJob()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllJobHusbend", null);
            dal.Close();
            return dt;
        }
        public void AddJob(string MhnaHazp)
        {
            SqlParameter[] param = new SqlParameter[1];
            
            param[0] = new SqlParameter("@MhnaHazp", SqlDbType.NVarChar, 15);
            param[0].Value = MhnaHazp;

            dal.Open();
            dal.ExecuteCommand("AddJobHusband", param);
            dal.Close();
        }

        public DataTable VerifiyJobHusband(string Job)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mhnahazp", SqlDbType.NVarChar, 30);
            param[0].Value = Job;

            dal.Open();
            DataTable dt = dal.SelectData("VerifiyJobHusband", param);
            dal.Close();
            return dt;
        }
    }
}
