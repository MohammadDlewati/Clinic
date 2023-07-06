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
        public void AddJob(int N, string MhnaHazp)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@N", SqlDbType.Int);
            param[0].Value = N;

            param[1] = new SqlParameter("@MhnaHazp", SqlDbType.NVarChar, 15);
            param[1].Value = MhnaHazp;
        }
    }
}
