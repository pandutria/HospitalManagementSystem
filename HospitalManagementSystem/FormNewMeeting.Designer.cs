namespace HospitalManagementSystem
{
    partial class FormNewMeeting
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkPatientRecord = new System.Windows.Forms.LinkLabel();
            this.linkViewPatientData = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDoctorName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDoctorCategory = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblQueneNumber = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(342, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(209, 38);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Master Patient";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkPatientRecord);
            this.groupBox1.Controls.Add(this.linkViewPatientData);
            this.groupBox1.Controls.Add(this.tbPatientName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(37, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 138);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Patient";
            // 
            // linkPatientRecord
            // 
            this.linkPatientRecord.AutoSize = true;
            this.linkPatientRecord.Location = new System.Drawing.Point(19, 100);
            this.linkPatientRecord.Name = "linkPatientRecord";
            this.linkPatientRecord.Size = new System.Drawing.Size(128, 16);
            this.linkPatientRecord.TabIndex = 20;
            this.linkPatientRecord.TabStop = true;
            this.linkPatientRecord.Text = "View Patient Record";
            this.linkPatientRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPatientRecord_LinkClicked);
            // 
            // linkViewPatientData
            // 
            this.linkViewPatientData.AutoSize = true;
            this.linkViewPatientData.Location = new System.Drawing.Point(19, 68);
            this.linkViewPatientData.Name = "linkViewPatientData";
            this.linkViewPatientData.Size = new System.Drawing.Size(112, 16);
            this.linkViewPatientData.TabIndex = 19;
            this.linkViewPatientData.TabStop = true;
            this.linkViewPatientData.Text = "View Patient Data";
            this.linkViewPatientData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewPatientData_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDoctorName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboDoctorCategory);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(454, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 138);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Doctor";
            // 
            // cboDoctorName
            // 
            this.cboDoctorName.FormattingEnabled = true;
            this.cboDoctorName.Location = new System.Drawing.Point(158, 65);
            this.cboDoctorName.Name = "cboDoctorName";
            this.cboDoctorName.Size = new System.Drawing.Size(224, 24);
            this.cboDoctorName.TabIndex = 24;
            this.cboDoctorName.SelectedValueChanged += new System.EventHandler(this.cboDoctorName_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // cboDoctorCategory
            // 
            this.cboDoctorCategory.FormattingEnabled = true;
            this.cboDoctorCategory.Location = new System.Drawing.Point(158, 31);
            this.cboDoctorCategory.Name = "cboDoctorCategory";
            this.cboDoctorCategory.Size = new System.Drawing.Size(224, 24);
            this.cboDoctorCategory.TabIndex = 22;
            this.cboDoctorCategory.SelectedValueChanged += new System.EventHandler(this.cboDoctorCategory_SelectedValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 100);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Patient Data";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblQueneNumber);
            this.groupBox3.Controls.Add(this.dtpDate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(37, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 138);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose Date";
            // 
            // lblQueneNumber
            // 
            this.lblQueneNumber.AutoSize = true;
            this.lblQueneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueneNumber.Location = new System.Drawing.Point(156, 76);
            this.lblQueneNumber.Name = "lblQueneNumber";
            this.lblQueneNumber.Size = new System.Drawing.Size(129, 23);
            this.lblQueneNumber.TabIndex = 23;
            this.lblQueneNumber.Text = "Queue Number";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(93, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(289, 22);
            this.dtpDate.TabIndex = 22;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Queue Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(542, 318);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(195, 30);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Patient Name";
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(160, 31);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(222, 22);
            this.tbPatientName.TabIndex = 12;
            this.tbPatientName.TextChanged += new System.EventHandler(this.tbPatientName_TextChanged);
            // 
            // FormNewMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 425);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormNewMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewMeeting";
            this.Load += new System.EventHandler(this.FormNewMeeting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkPatientRecord;
        private System.Windows.Forms.LinkLabel linkViewPatientData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboDoctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDoctorCategory;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQueneNumber;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.Label label3;
    }
}