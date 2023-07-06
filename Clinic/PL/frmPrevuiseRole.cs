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
    public partial class frmPrevuiseRole : Form
    {
       
        CLS_Name nam = new CLS_Name();
        CLS_RecordWait wait = new CLS_RecordWait();
        int Id;
        string NamePationt;
        string Husband;

        public frmPrevuiseRole()
        {
            InitializeComponent();
        }
        public frmPrevuiseRole(int ID, string Name, string Husband)
        {
            InitializeComponent();
            this.Id = ID;
            this.NamePationt = Name;
            this.Husband = Husband;

            txtPationt.Text = NamePationt;
            txtHusband.Text = Husband;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateVisit_ValueChanged(object sender, EventArgs e)
        {
            string day = dateVisit.Value.DayOfWeek.ToString();
            getDay(day);
        }

        private void getDay(string day)
        {
            if (day == "Saturday")
                txtDayVisit.Text = "السبت";
            else if (day == "Sunday")
                txtDayVisit.Text = "الأحد";
            else if (day == "Monday")
                txtDayVisit.Text = "الاثنين";
            else if (day == "Tuesday")
                txtDayVisit.Text = "الثلاثاء";
            else if (day == "Wednesday")
                txtDayVisit.Text = "الأربعاء";
            else if (day == "Thursday")
                txtDayVisit.Text = "الخميس";
            else if (day == "Friday")
                txtDayVisit.Text = "الجمعة";
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            wait.AddRecordWait(Id, comKindVisit.Text, wait.CountRecord() + 1, NamePationt, DateTime.Now.ToString("hh:mm:ss"), DateTime.Now.ToShortDateString(), TimeVisit.Value.ToString("hh:mm:ss"), dateVisit.Value.ToShortDateString(), txtNotes.Text);

            MessageBox.Show("تم حجز الموعد بنجاح");
        }

        private void frmPrevuiseRole_Load(object sender, EventArgs e)
        {
            string day = dateVisit.Value.DayOfWeek.ToString();
            getDay(day);
        }

       

      
    }
}
