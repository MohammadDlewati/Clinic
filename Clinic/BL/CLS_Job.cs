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

        public void AddJob(int N, string Mhnapation)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@N", SqlDbType.Int);
            param[0].Value = N;

            param[1] = new SqlParameter("@Mhnapation", SqlDbType.NVarChar, 15);
            param[1].Value = Mhnapation;
        }
    }
}
