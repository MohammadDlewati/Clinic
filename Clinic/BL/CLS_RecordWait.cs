using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinic.BL
{
    class CLS_RecordWait
    {
        DAL.DataBase dal = new DAL.DataBase();


        public DataTable AllRecordWait()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllRecordWait", null);
            dal.Close();
            return dt;
        }

        public int CountRecord()
        {
            dal.Open();
            int number = dal.ExecuteCount("RecordWaitCount");
            dal.Close();
            return number;
        }

        public void AddRecordWait(int Nez, string Kindrecord, int Npatino, string Name, string Timercord, string Daterecord, string Timedat, string DatePrevious, string Note)
        {
            SqlParameter[] param = new SqlParameter[9];
          
            param[0] = new SqlParameter("@Nez", SqlDbType.Int);
            param[0].Value = Nez;

            param[1] = new SqlParameter("@Kindrecord", SqlDbType.NVarChar, 15);
            param[1].Value = Kindrecord;

            param[2] = new SqlParameter("@Npatino", SqlDbType.Int);
            param[2].Value = Npatino;

            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[3].Value = Name;

            param[4] = new SqlParameter("@Timercord", SqlDbType.NVarChar,20);
            param[4].Value = Timercord;

            param[5] = new SqlParameter("@Daterecord", SqlDbType.NVarChar,20);
            param[5].Value = Daterecord;

            param[6] = new SqlParameter("@Timedat", SqlDbType.NVarChar, 20);
            param[6].Value = Timedat;

            param[7] = new SqlParameter("@DatePrevious", SqlDbType.NVarChar, 20);
            param[7].Value = DatePrevious;            

            param[8] = new SqlParameter("@Note", SqlDbType.NVarChar, 100);
            param[8].Value = Note;

            dal.Open();
            dal.ExecuteCommand("AddRecordWait", param);
            dal.Close();
        }

        public void DelRecordWait(int N)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@N", SqlDbType.Int);
            param[0].Value = N;
            dal.Open();
            dal.ExecuteCommand("DelRecord", param);
            dal.Close();
        }
    }
}
