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
    public partial class frmWaitList : Form
    {
        CLS_RecordWait wait = new CLS_RecordWait();
        DataTable dt;
        bool State;
        public frmWaitList(bool state)
        {
            InitializeComponent();
            this.State = state;
            RefreshTable();            
            dgvWait.Columns[0].HeaderText = "الرقم";
            dgvWait.Columns[0].Visible = false;
            dgvWait.Columns[1].HeaderText = "رقم المريضة";
            dgvWait.Columns[1].Visible = false;
            dgvWait.Columns[2].HeaderText = "نوع الزيارة";
            dgvWait.Columns[3].HeaderText = "رقم الدور";
            dgvWait.Columns[4].HeaderText = "اسم المريضة";
            dgvWait.Columns[5].HeaderText = "وقت التسجيل";
            dgvWait.Columns[6].HeaderText = "تاريخ التسجيل";
            dgvWait.Columns[7].HeaderText = "توقيت الموعد ";
            dgvWait.Columns[8].HeaderText = "تاريخ الموعد ";
            dgvWait.Columns[9].HeaderText = "ملاحظات";
            if (State)
            {
                btnPriveue.Visible = true;
            }
            else
            {
                btnPriveue.Visible = false;
            }
        }

        public void RefreshTable()
        {
            dt = wait.AllRecordWait();
            dgvWait.DataSource = dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmWaitList_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();       

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWait.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من حذف الدور؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    wait.DelRecordWait(Int32.Parse(dgvWait.CurrentRow.Cells[0].Value.ToString()));
                    this.RefreshTable();
                }
            }
            else
            {
                MessageBox.Show("لا يوجد سجلات للحذف");
            }
        }

       
    }
}
