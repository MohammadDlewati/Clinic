using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinic.BL;

namespace Clinic.PL
{
    public partial class frmNurse : Form
    {
        CLS_Name Nam = new CLS_Name();
        CLS_RecordWait wait = new CLS_RecordWait();
    
        public frmNurse()
        {
            InitializeComponent();
            lblRecored.Text = Nam.CountName().ToString();
           
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddName frAdd = new frmAddName();
            frAdd.ShowDialog();
            btnEdit.Visible = true;
            btnPrivuseVisit.Visible = true;
            btnVisit.Visible = true;
            getRecord(Nam.getLastName());
        }

        private void frmNurse_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = Nam.SearchName(txtSearch.Text);
            dgName.DataSource = dt;
            dgName.Columns[0].HeaderText = "الرقم ";
            dgName.Columns[0].Visible = false;
            dgName.Columns[1].HeaderText = "اسم المريضة";
            dgName.Columns[2].HeaderText = "اسم الزوج";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddName frm = new frmAddName(int.Parse(txtId.Text));
            frm.ShowDialog();
            DataTable dtNam = Nam.getName(int.Parse(txtId.Text));
            getRecord(dtNam);
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            //إظهار القائمة المنسدلة في أسفل الزر عند الضغط بالزر الأيسر
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);

            //contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            
        }

        private void strNewPreview_Click(object sender, EventArgs e)
        {

            wait.AddRecordWait(Convert.ToInt32(txtId.Text), "معاينة", wait.CountRecord() + 1, txtName.Text, DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), "");

                    MessageBox.Show("تم حجز الدور بنجاح");
               
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            frmWaitList frm = new frmWaitList();
            frm.ShowDialog();
            //Application.OpenForms["frmWaitList"].Show();
        }

        private void strReview_Click(object sender, EventArgs e)
        {
            try
            {
                wait.AddRecordWait(Convert.ToInt32(txtId.Text), "مراجعة", wait.CountRecord() + 1, txtName.Text, DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), "");

                MessageBox.Show("تم حجز الدور بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void strPregnancyMonitoring_Click(object sender, EventArgs e)
        {
            wait.AddRecordWait(Convert.ToInt32(txtId.Text), "مراقبة حمل", wait.CountRecord() + 1, txtName.Text, DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), "");

            MessageBox.Show("تم حجز الدور بنجاح");
              
        }

        private void strSurgery_Click(object sender, EventArgs e)
        {
            wait.AddRecordWait(Convert.ToInt32(txtId.Text), "جراحة", wait.CountRecord() + 1, txtName.Text, DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), "");

            MessageBox.Show("تم حجز الدور بنجاح");
              
        }

        private void strAnalysis_Click(object sender, EventArgs e)
        {
            wait.AddRecordWait(Convert.ToInt32(txtId.Text), "تحليل", wait.CountRecord() + 1, txtName.Text, DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), "");

            MessageBox.Show("تم حجز الدور بنجاح");
              
        }

        private void strOvulationMonitoring_Click(object sender, EventArgs e)
        {
            wait.AddRecordWait(Convert.ToInt32(txtId.Text), "مراقبة إباضة", wait.CountRecord() + 1, txtName.Text, DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), "");

            MessageBox.Show("تم حجز الدور بنجاح");
              
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrivuseVisit_Click(object sender, EventArgs e)
        {
            frmPrevuiseRole frm = new frmPrevuiseRole(int.Parse(txtId.Text),txtName.Text,txtHusbandName.Text);
            frm.ShowDialog();
        }

        private void dgName_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dtNam = Nam.getName(Int32.Parse(dgName.Rows[e.RowIndex].Cells[0].Value.ToString()));
                getRecord(dtNam);

                btnEdit.Visible = true;
                btnPrivuseVisit.Visible = true;
                btnVisit.Visible = true;
            }
        }
    }
}
