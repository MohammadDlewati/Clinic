namespace Clinic.PL
{
    partial class frmPrevuiseRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateVisit = new System.Windows.Forms.DateTimePicker();
            this.TimeVisit = new System.Windows.Forms.DateTimePicker();
            this.comKindVisit = new System.Windows.Forms.ComboBox();
            this.txtDayVisit = new System.Windows.Forms.TextBox();
            this.txtHusband = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPationt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateVisit);
            this.panel1.Controls.Add(this.TimeVisit);
            this.panel1.Controls.Add(this.comKindVisit);
            this.panel1.Controls.Add(this.txtDayVisit);
            this.panel1.Controls.Add(this.txtHusband);
            this.panel1.Controls.Add(this.txtNotes);
            this.panel1.Controls.Add(this.txtPationt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 254);
            this.panel1.TabIndex = 1;
            // 
            // dateVisit
            // 
            this.dateVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVisit.Location = new System.Drawing.Point(274, 142);
            this.dateVisit.Name = "dateVisit";
            this.dateVisit.RightToLeftLayout = true;
            this.dateVisit.Size = new System.Drawing.Size(154, 27);
            this.dateVisit.TabIndex = 17;
            this.dateVisit.ValueChanged += new System.EventHandler(this.dateVisit_ValueChanged);
            // 
            // TimeVisit
            // 
            this.TimeVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeVisit.CustomFormat = "mm:hh";
            this.TimeVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeVisit.Location = new System.Drawing.Point(12, 75);
            this.TimeVisit.Name = "TimeVisit";
            this.TimeVisit.RightToLeftLayout = true;
            this.TimeVisit.ShowUpDown = true;
            this.TimeVisit.Size = new System.Drawing.Size(154, 27);
            this.TimeVisit.TabIndex = 17;
            // 
            // comKindVisit
            // 
            this.comKindVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comKindVisit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comKindVisit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comKindVisit.FormattingEnabled = true;
            this.comKindVisit.Items.AddRange(new object[] {
            "معاينة جديدة",
            "مراجعة",
            "مراقبة حمل",
            "جراحة",
            "تحليل",
            "مراقبة إباضة"});
            this.comKindVisit.Location = new System.Drawing.Point(274, 75);
            this.comKindVisit.Name = "comKindVisit";
            this.comKindVisit.Size = new System.Drawing.Size(168, 27);
            this.comKindVisit.TabIndex = 16;
            // 
            // txtDayVisit
            // 
            this.txtDayVisit.Location = new System.Drawing.Point(12, 142);
            this.txtDayVisit.Name = "txtDayVisit";
            this.txtDayVisit.Size = new System.Drawing.Size(163, 27);
            this.txtDayVisit.TabIndex = 15;
            // 
            // txtHusband
            // 
            this.txtHusband.Location = new System.Drawing.Point(12, 8);
            this.txtHusband.Name = "txtHusband";
            this.txtHusband.ReadOnly = true;
            this.txtHusband.Size = new System.Drawing.Size(163, 27);
            this.txtHusband.TabIndex = 15;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 209);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(436, 27);
            this.txtNotes.TabIndex = 15;
            this.txtNotes.Text = "موعد مسبق";
            // 
            // txtPationt
            // 
            this.txtPationt.Location = new System.Drawing.Point(274, 8);
            this.txtPationt.Name = "txtPationt";
            this.txtPationt.ReadOnly = true;
            this.txtPationt.Size = new System.Drawing.Size(147, 27);
            this.txtPationt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "يوم الموعد";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "توقيت الزيارة";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "ملاحظات";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاريخ الموعد";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "نوع الزيارة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم الزوج";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم المريضة";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnRole);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 72);
            this.panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(20, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRole
            // 
            this.btnRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Location = new System.Drawing.Point(391, 16);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(104, 37);
            this.btnRole.TabIndex = 0;
            this.btnRole.Text = "حجز الموعد";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // frmPrevuiseRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrevuiseRole";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حجز موعد مسبق";
            this.Load += new System.EventHandler(this.frmPrevuiseRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.DateTimePicker dateVisit;
        private System.Windows.Forms.DateTimePicker TimeVisit;
        private System.Windows.Forms.ComboBox comKindVisit;
        private System.Windows.Forms.TextBox txtDayVisit;
        private System.Windows.Forms.TextBox txtHusband;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPationt;
    }
}