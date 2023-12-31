﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinic.BL
{
    class CLS_Name
    {
        DAL.DataBase dal = new DAL.DataBase();

        public int CountName()
        {
            dal.Open();
            int number= dal.ExecuteCount("NamesCount");
            dal.Close();
            return number;
        }
        public void AddName(string Name, string Age, string Bload, string Bloadhazpend, string Ageatamint, string Mhnapation, string Hazpend, string Hazage, string Mhnahazpend, string Phone, string Datemarig,string BirthN, string Datebrithfinal, string CarryN, string Carryfoal, string MealliveN, string FemalliveN, string MealdeadN, string FemaldeadN, string Storybirth, string Storygrahi, string KaysarN, string Olddisease)
        {
            SqlParameter[] param = new SqlParameter[23];
          
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar,50);
            param[0].Value = Name;            

            param[1] = new SqlParameter("@Age", SqlDbType.NVarChar, 4);
            param[1].Value = Age;

            param[2] = new SqlParameter("@Bload", SqlDbType.NVarChar, 4);
            param[2].Value = Bload;

            param[3] = new SqlParameter("@Bloadhazpend", SqlDbType.NVarChar, 4);
            param[3].Value = Bloadhazpend;

            param[4] = new SqlParameter("@Ageatamint", SqlDbType.NVarChar, 2);
            param[4].Value = Ageatamint;

            param[5] = new SqlParameter("@Mhnapation", SqlDbType.NVarChar, 15);
            param[5].Value = Mhnapation;

            param[6] = new SqlParameter("@Hazpend", SqlDbType.NVarChar, 50);
            param[6].Value = Hazpend;

            param[7] = new SqlParameter("@Hazage", SqlDbType.NVarChar, 4);
            param[7].Value = Hazage;

            param[8] = new SqlParameter("@Mhnahazpend", SqlDbType.NVarChar, 15);
            param[8].Value = Mhnahazpend;            

            param[9] = new SqlParameter("@Phone", SqlDbType.NVarChar, 15);
            param[9].Value = Phone;            

            param[10] = new SqlParameter("@Datemarig", SqlDbType.NVarChar, 15);
            param[10].Value = Datemarig;           

            param[11] = new SqlParameter("@BirthN", SqlDbType.NVarChar, 2);
            param[11].Value = BirthN;

            param[12] = new SqlParameter("@Datebrithfinal", SqlDbType.NVarChar, 15);
            param[12].Value = Datebrithfinal;

            param[13] = new SqlParameter("@CarryN", SqlDbType.NVarChar, 3);
            param[13].Value = CarryN;

            param[14] = new SqlParameter("@Carryfoal", SqlDbType.NVarChar, 3);
            param[14].Value = Carryfoal;

            param[15] = new SqlParameter("@MealliveN", SqlDbType.NVarChar, 3);
            param[15].Value = MealliveN;

            param[16] = new SqlParameter("@FemalliveN", SqlDbType.NVarChar, 3);
            param[16].Value = FemalliveN;

            param[17] = new SqlParameter("@MealdeadN", SqlDbType.NVarChar, 3);
            param[17].Value = MealdeadN;

            param[18] = new SqlParameter("@FemaldeadN", SqlDbType.NVarChar, 3);
            param[18].Value = FemaldeadN;

            param[19] = new SqlParameter("@Storybirth", SqlDbType.NVarChar, 200);
            param[19].Value = Storybirth;

            param[20] = new SqlParameter("@Storygrahi", SqlDbType.NVarChar, 200);
            param[20].Value = Storygrahi;

            param[21] = new SqlParameter("@KaysarN", SqlDbType.NVarChar,4);
            param[21].Value = KaysarN;

            param[22] = new SqlParameter("@Olddisease", SqlDbType.NVarChar, 20);
            param[22].Value = Olddisease;
            

            dal.Open();
            dal.ExecuteCommand("AddNames", param);
            dal.Close();
        }

        public DataTable GetNameHusbend()
        {
            dal.Open();
            DataTable dt= dal.SelectData("GetAll_Name_Husbend", null);
            dal.Close();
            return dt;
        }

        public DataTable SearchName(String StrSearch)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@StrSearch", SqlDbType.NVarChar, 100);
            param[0].Value = StrSearch;
            dal.Open();
            DataTable dt = dal.SelectData("SearchName", param);
            dal.Close();
            return dt;
        }

        public void EditName(string Name, string Age, string Bload, string Bloadhazpend, string Ageatamint, string Mhnapation, string Hazpend, string Hazage, string Mhnahazpend, string Phone, string Datemarig, string BirthN, string Datebrithfinal, string CarryN, string Carryfoal, string MealliveN, string FemalliveN, string MealdeadN, string FemaldeadN, string Storybirth, string Storygrahi, string KaysarN, string Olddisease)
        {
            SqlParameter[] param = new SqlParameter[23];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Age", SqlDbType.NVarChar, 4);
            param[1].Value = Age;

            param[2] = new SqlParameter("@Bload", SqlDbType.NVarChar, 4);
            param[2].Value = Bload;

            param[3] = new SqlParameter("@Bloadhazpend", SqlDbType.NVarChar, 4);
            param[3].Value = Bloadhazpend;

            param[4] = new SqlParameter("@Ageatamint", SqlDbType.NVarChar, 2);
            param[4].Value = Ageatamint;

            param[5] = new SqlParameter("@Mhnapation", SqlDbType.NVarChar, 15);
            param[5].Value = Mhnapation;

            param[6] = new SqlParameter("@Hazpend", SqlDbType.NVarChar, 50);
            param[6].Value = Hazpend;

            param[7] = new SqlParameter("@Hazage", SqlDbType.NVarChar, 4);
            param[7].Value = Hazage;

            param[8] = new SqlParameter("@Mhnahazpend", SqlDbType.NVarChar, 15);
            param[8].Value = Mhnahazpend;

            param[9] = new SqlParameter("@Phone", SqlDbType.NVarChar, 15);
            param[9].Value = Phone;

            param[10] = new SqlParameter("@Datemarig", SqlDbType.NVarChar, 15);
            param[10].Value = Datemarig;

            param[11] = new SqlParameter("@BirthN", SqlDbType.NVarChar, 2);
            param[11].Value = BirthN;

            param[12] = new SqlParameter("@Datebrithfinal", SqlDbType.NVarChar, 15);
            param[12].Value = Datebrithfinal;

            param[13] = new SqlParameter("@CarryN", SqlDbType.NVarChar, 3);
            param[13].Value = CarryN;

            param[14] = new SqlParameter("@Carryfoal", SqlDbType.NVarChar, 3);
            param[14].Value = Carryfoal;

            param[15] = new SqlParameter("@MealliveN", SqlDbType.NVarChar, 3);
            param[15].Value = MealliveN;

            param[16] = new SqlParameter("@FemalliveN", SqlDbType.NVarChar, 3);
            param[16].Value = FemalliveN;

            param[17] = new SqlParameter("@MealdeadN", SqlDbType.NVarChar, 3);
            param[17].Value = MealdeadN;

            param[18] = new SqlParameter("@FemaldeadN", SqlDbType.NVarChar, 3);
            param[18].Value = FemaldeadN;

            param[19] = new SqlParameter("@Storybirth", SqlDbType.NVarChar, 200);
            param[19].Value = Storybirth;

            param[20] = new SqlParameter("@Storygrahi", SqlDbType.NVarChar, 200);
            param[20].Value = Storygrahi;

            param[21] = new SqlParameter("@KaysarN", SqlDbType.NVarChar, 4);
            param[21].Value = KaysarN;

            param[22] = new SqlParameter("@Olddisease", SqlDbType.NVarChar, 20);
            param[22].Value = Olddisease;

            dal.Open();
            dal.ExecuteCommand("EditNames", param);
            dal.Close();
        }

        public DataTable getName(int N)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@N", SqlDbType.Int);
            param[0].Value = N;

            dal.Open();
            DataTable dt = dal.SelectData("getNames", param);
            dal.Close();
            return dt;
        }

        public DataTable getLastName()
        {
            
            dal.Open();
            DataTable dt = dal.SelectData("getLastName", null);
            dal.Close();
            return dt;
        }

        public DataTable VerifiyName(string Name, string Hazpend)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar,50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Hazpend", SqlDbType.NVarChar,50);
            param[1].Value = Hazpend;

            dal.Open();
            DataTable dt = dal.SelectData("VerifiyName", param);
            dal.Close();
            return dt;
        }

    }
}
