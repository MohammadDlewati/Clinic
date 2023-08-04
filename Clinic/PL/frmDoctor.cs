using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinic.BL;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Clinic.PL
{
    public partial class frmDoctor : Form
    {
        CLS_Name Nam = new CLS_Name();
        CLS_GlobalKind proc = new CLS_GlobalKind();

        public FilterInfoCollection CamsCollection;
        public VideoCaptureDevice Cam = null;

        public string TableName;
        public int nameID;
        public frmDoctor()
        { 
            InitializeComponent();
        }
        
        void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic1.Image = (Bitmap)eventArgs.Frame.Clone();   
        }

        private void tsBtnWait_Click(object sender, EventArgs e)
        {
            frmWaitList frm = new frmWaitList(true);
            frm.ShowDialog();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            frmAddName frm = new frmAddName();
            frm.ShowDialog();
            getRecord(Nam.getLastName());
            gbVisit.Enabled = true;
            panel7.Enabled = true;
            dgGlobal.Enabled = true;
        }

        private void getRecord(DataTable dtName)
        {

            txtId.Text = dtName.Rows[0]["N"].ToString();
            txtName.Text = dtName.Rows[0]["Name"].ToString();
            txtAge.Text = dtName.Rows[0]["Age"].ToString();
            txtBload.Text = dtName.Rows[0]["Bload"].ToString();
            txtHusbandBload.Text = dtName.Rows[0]["Bloadhazpend"].ToString();
            txtPuberty.Text = dtName.Rows[0]["Ageatamint"].ToString();
            txtJob.Text = dtName.Rows[0]["Mhnapation"].ToString();
            txtHusbandName.Text = dtName.Rows[0]["Hazpend"].ToString();
            txtHusbandAge.Text = dtName.Rows[0]["Hazage"].ToString();
            txtHusbandJob.Text = dtName.Rows[0]["Mhnahazpend"].ToString();
            txtPhone.Text = dtName.Rows[0]["Phone"].ToString();
            txtDateMarriage.Text = dtName.Rows[0]["Datemarig"].ToString();
            txtBirths.Text = dtName.Rows[0]["BirthN"].ToString();
            txtLastPregnancy.Text = dtName.Rows[0]["Datebrithfinal"].ToString();
            txtPregnancies.Text = dtName.Rows[0]["CarryN"].ToString();
            txtAbortions.Text = dtName.Rows[0]["Carryfoal"].ToString();
            txtLiveMales.Text = dtName.Rows[0]["MealliveN"].ToString();
            txtLiveFemales.Text = dtName.Rows[0]["FemalliveN"].ToString();
            txtDeadMales.Text = dtName.Rows[0]["MealdeadN"].ToString();
            txtDeadFemales.Text = dtName.Rows[0]["FemaldeadN"].ToString();
            txtBirthStories.Text = dtName.Rows[0]["Storybirth"].ToString();
            txtSurgicalHistory.Text = dtName.Rows[0]["Storygrahi"].ToString();
            txtCaesarean.Text = dtName.Rows[0]["KaysarN"].ToString();
            txtPreviousIllnesses.Text = dtName.Rows[0]["Olddisease"].ToString();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            CamsCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            Cam = new VideoCaptureDevice(CamsCollection[0].MonikerString);
            Cam.NewFrame += new NewFrameEventHandler(Cam_NewFrame);
            Cam.Start();
        }

        private void frmDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cam.Stop();
        }

        private void dgGlobal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProcessing_Click(object sender, EventArgs e)
        {
            TableName = "ProcessingKind";
            DataTable dt = proc.AllProcessingKind();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "المعالجة";
            
        }

        private void dgSickComplaint_Click(object sender, EventArgs e)
        {
            TableName = "SickComplaintKind";
            DataTable dt = proc.AllSickComplaintKind();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "الشكاية المرضية";
        }

        private void dgMedicalExam_Click(object sender, EventArgs e)
        {
            TableName = "MedicalExamKind";
            DataTable dt = proc.AllMedicalExamKind();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "الفحوص الطبية";
        }

        private void dgLaboratoryTest_Click(object sender, EventArgs e)
        {
            TableName = "LaboratoryTestKind";
            DataTable dt = proc.AllLaboratoryTestKind();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "الفحوص المخبرية";
        }

        private void dgEcho_Click(object sender, EventArgs e)
        {
            TableName = "EchoKind";
            DataTable dt = proc.AllEchoKind();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "الايكو";
        }

        private void dgInfertility_Click(object sender, EventArgs e)
        {
            TableName = "InfertilityKind";
            DataTable dt = proc.AllInfertilityKind();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "العقم";
        }

        private void dgMedicine_Click(object sender, EventArgs e)
        {
            TableName = "MedicinesKind";
            DataTable dt = proc.AllMedicinesKind();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "الادوية";
            dgGlobal.Columns[2].HeaderText = "الجرعة";
        }

        private void dgDiagnostics_Click(object sender, EventArgs e)
        {
            TableName = "Diagnostics";
            DataTable dt = proc.AllDiagnostics();
            dgGlobal.DataSource = dt;
            dgGlobal.Columns[0].HeaderText = "الرقم ";
            dgGlobal.Columns[0].Visible = false;
            dgGlobal.Columns[1].HeaderText = "التشخيص";
        }

        private void tsBtnSearch_Click(object sender, EventArgs e)
        {

            SearchName frm = new SearchName();
            frm.ShowDialog();
            
            getRecord(Nam.getName(nameID));
            gbVisit.Enabled = true;
            panel7.Enabled = true;
            dgGlobal.Enabled = true;
        }
    }
}
