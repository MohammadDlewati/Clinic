using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Clinic.BL
{
    class CLS_GlobalKind
    {
        DAL.DataBase dal = new DAL.DataBase();

        #region Processing
        public DataTable AllProcessingKind()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllProcessingKind", null);
            dal.Close();
            return dt;
        }
        #endregion

        #region Infertility
        public DataTable AllInfertilityKind()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllInfertilityKind", null);
            dal.Close();
            return dt;
        }
        #endregion

        #region Echo
        public DataTable AllEchoKind()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllEchoKind", null);
            dal.Close();
            return dt;
        }
        #endregion

        #region LaboratoryTest
        public DataTable AllLaboratoryTestKind()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllLaboratoryTestKind", null);
            dal.Close();
            return dt;
        }
        #endregion

        #region MedicalExam
        public DataTable AllMedicalExamKind()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllMedicalExamKind", null);
            dal.Close();
            return dt;
        }
        #endregion

        #region Medicines
        public DataTable AllMedicinesKind()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllMedicinesKind", null);
            dal.Close();
            return dt;
        }
        #endregion

        #region SickComplaint
        public DataTable AllSickComplaintKind()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllSickComplaintKind", null);
            dal.Close();
            return dt;
        }
        #endregion

        #region Diagnostics
        public DataTable AllDiagnostics()
        {
            dal.Open();
            DataTable dt = dal.SelectData("AllDiagnostics", null);
            dal.Close();
            return dt;
        }
        #endregion

    }
}
