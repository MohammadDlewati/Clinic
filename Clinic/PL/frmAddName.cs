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
    public partial class frmAddName : Form
    {
        CLS_Name nam = new CLS_Name();
        CLS_Job job = new CLS_Job();
        CLS_Job_Husbend jobh = new CLS_Job_Husbend();
        DataTable dt, dtH,dtName;
        string state;
        public frmAddName()
        {
            InitializeComponent();
            state = "Add";
            dt = job.AllJob();

            lblCountRecored.Text = nam.CountName().ToString();

            comJob.DataSource = dt;
            comJob.DisplayMember = "Mhnapation";
            comJob.ValueMember = "N";            

            dtH = jobh.AllJob();
            comHusbandJob.DataSource = dtH;
            comHusbandJob.DisplayMember = "Mhnahazp";
            comHusbandJob.ValueMember = "N";
        }


        public frmAddName(int N)
        {
            InitializeComponent();

            state = "Edit";
            lblCountRecored.Text = nam.CountName().ToString();
            this.Text = " تعديل بطاقة";

            dtName = nam.getName(N);
            txtId.Text = dtName.Rows[0]["N"].ToString();
            txtName.Text = dtName.Rows[0]["Name"].ToString();
            txtAge.Text = dtName.Rows[0]["Age"].ToString();
            comBload.Text = dtName.Rows[0]["Bload"].ToString();
            comHusbandBload.Text = dtName.Rows[0]["Bloadhazpend"].ToString();
            txtPuberty.Text = dtName.Rows[0]["Ageatamint"].ToString();
            comJob.Text = dtName.Rows[0]["Mhnapation"].ToString();
            txtHusbandName.Text = dtName.Rows[0]["Hazpend"].ToString();
            txtHusbandAge.Text = dtName.Rows[0]["Hazage"].ToString();
            comHusbandJob.Text = dtName.Rows[0]["Mhnahazpend"].ToString();
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
            comBirthStories.Text = dtName.Rows[0]["Storybirth"].ToString();
            comSurgicalHistory.Text = dtName.Rows[0]["Storygrahi"].ToString();
            txtCaesarean.Text = dtName.Rows[0]["KaysarN"].ToString();
            comPreviousIllnesses.Text = dtName.Rows[0]["Olddisease"].ToString();

            dt = job.AllJob();
            comJob.DataSource = dt;
            comJob.DisplayMember = "Mhnapation";
            comJob.ValueMember = "N";

            dtH = jobh.AllJob();
            comHusbandJob.DataSource = dtH;
            comHusbandJob.DisplayMember = "Mhnahazp";
            comHusbandJob.ValueMember = "N";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (state.Equals("Add"))
                {
                    DataTable dt = nam.VerifiyName(txtName.Text.Trim(), txtHusbandName.Text.Trim());
                    if (dt.Rows[0][0].ToString().Equals("0"))
                    {
                        nam.AddName(
                            int.Parse(txtId.Text) ,
                            txtName.Text,                             
                            txtAge.Text,
                            comBload.Text, 
                            comHusbandBload.Text,
                            txtPuberty.Text,
                            comJob.Text,
                            txtHusbandName.Text,
                            txtHusbandAge.Text, 
                            comHusbandJob.Text,                             
                            txtPhone.Text,                           
                            txtDateMarriage.Text,                            
                            txtBirths.Text,
                            txtLastPregnancy.Text,
                            txtPregnancies.Text,
                            txtAbortions.Text,
                            txtLiveMales.Text,
                            txtLiveFemales.Text, 
                            txtDeadMales.Text, 
                            txtDeadFemales.Text, 
                            comBirthStories.Text,
                            comSurgicalHistory.Text,
                            txtCaesarean.Text,
                            comPreviousIllnesses.Text);


                        MessageBox.Show("تم الحفظ بنجاح....");
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("الاسم موجود, هل تريد إضافة بطاقة ثانية؟ ....","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            nam.AddName(
                                int.Parse(txtId.Text),
                                txtName.Text,                               
                                txtAge.Text,
                                comBload.Text, 
                                comHusbandBload.Text,
                                txtPuberty.Text,
                                comJob.Text,
                                txtHusbandName.Text,
                                txtHusbandAge.Text,
                                comHusbandJob.Text,                               
                                txtPhone.Text,                               
                                txtDateMarriage.Text,                                
                                txtBirths.Text,
                                txtLastPregnancy.Text,
                                txtPregnancies.Text,
                                txtAbortions.Text,
                                txtLiveMales.Text,
                                txtLiveFemales.Text,
                                txtDeadMales.Text,
                                txtDeadFemales.Text,
                                comBirthStories.Text,
                                comSurgicalHistory.Text,
                                txtCaesarean.Text,
                                comPreviousIllnesses.Text);
                            MessageBox.Show("تم الحفظ بنجاح....");
                            btnSave.Enabled = false;
                        }
                    }
                }

                else
                {
                    nam.EditName(
                        int.Parse(txtId.Text),
                        txtName.Text,
                        txtAge.Text,
                        comBload.Text,
                        comHusbandBload.Text,
                        txtPuberty.Text, 
                        comJob.Text, 
                        txtHusbandName.Text,
                        txtHusbandAge.Text,
                        comHusbandJob.Text,  
                        txtPhone.Text,
                        txtDateMarriage.Text,
                        txtBirths.Text,
                        txtLastPregnancy.Text,
                        txtPregnancies.Text,
                        txtAbortions.Text, 
                        txtLiveMales.Text, 
                        txtLiveFemales.Text, 
                        txtDeadMales.Text,
                        txtDeadFemales.Text,
                        comBirthStories.Text,
                        comSurgicalHistory.Text,
                        txtCaesarean.Text, 
                        comPreviousIllnesses.Text);

                    MessageBox.Show("تم التعديل بنجاح....");
                }
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("يجب ملء كل البيانات");
            //}
        }

        private void frmAddName_Load(object sender, EventArgs e)
        {
            comJob.Text = "";
            comHusbandJob.Text = "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = "Add";
            this.Text = " إضافة بطاقة";
            btnSave.Enabled = true;
            lblCountRecored.Text = nam.CountName().ToString();

            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text="";
            comBload.Text="";
            comHusbandBload.Text="";
            txtPuberty.Text="";
            comJob.Text="";
            txtHusbandName.Text="";
            txtHusbandAge.Text="";
            comHusbandJob.Text= "";
            txtPhone.Text= "";
            txtDateMarriage.Text= "";
            txtBirths.Text="";
            txtLastPregnancy.Text="";
            txtPregnancies.Text="";
            txtAbortions.Text="";
            txtLiveMales.Text="";
            txtLiveFemales.Text="";
            txtDeadMales.Text="";
            txtDeadFemales.Text="";
            comBirthStories.Text="";
            comSurgicalHistory.Text="";
            txtCaesarean.Text = "";
            comPreviousIllnesses.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
