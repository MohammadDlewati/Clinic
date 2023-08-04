using Clinic.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic.PL
{
    public partial class SearchName : Form
    {
        CLS_Name Nam = new CLS_Name();
        public int NameID;
        public SearchName()
        {
            InitializeComponent();
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = Nam.SearchName(txtSearch.Text);
            dgName.DataSource = dt;
            dgName.Columns[0].HeaderText = "الرقم ";
            dgName.Columns[1].HeaderText = "اسم المريضة";
            dgName.Columns[2].HeaderText = "اسم الزوج";
        }

        private void dgName_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {                
                NameID = Int32.Parse(dgName.Rows[e.RowIndex].Cells[0].Value.ToString());
                //نقل رقم المريضة الى شاشة الطبيب
                var y = Application.OpenForms["frmDoctor"] as frmDoctor;
                y.nameID = NameID;
                this.Close();
            }
        }

      
    }
}
