namespace HospitalManagementSystem
{
    partial class FormMain
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMasterICD = new System.Windows.Forms.Button();
            this.btnMasterDoctor = new System.Windows.Forms.Button();
            this.btnMasterPatient = new System.Windows.Forms.Button();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnManageMeeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(28, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(90, 38);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(397, 39);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 32);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMasterICD
            // 
            this.btnMasterICD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterICD.Location = new System.Drawing.Point(193, 117);
            this.btnMasterICD.Name = "btnMasterICD";
            this.btnMasterICD.Size = new System.Drawing.Size(146, 32);
            this.btnMasterICD.TabIndex = 8;
            this.btnMasterICD.Text = "Master ICD-11";
            this.btnMasterICD.UseVisualStyleBackColor = true;
            this.btnMasterICD.Click += new System.EventHandler(this.btnMasterICD_Click);
            // 
            // btnMasterDoctor
            // 
            this.btnMasterDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterDoctor.Location = new System.Drawing.Point(193, 166);
            this.btnMasterDoctor.Name = "btnMasterDoctor";
            this.btnMasterDoctor.Size = new System.Drawing.Size(146, 32);
            this.btnMasterDoctor.TabIndex = 9;
            this.btnMasterDoctor.Text = "Master Doctor";
            this.btnMasterDoctor.UseVisualStyleBackColor = true;
            this.btnMasterDoctor.Click += new System.EventHandler(this.btnMasterDoctor_Click);
            // 
            // btnMasterPatient
            // 
            this.btnMasterPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterPatient.Location = new System.Drawing.Point(193, 213);
            this.btnMasterPatient.Name = "btnMasterPatient";
            this.btnMasterPatient.Size = new System.Drawing.Size(146, 32);
            this.btnMasterPatient.TabIndex = 10;
            this.btnMasterPatient.Text = "Master Patient";
            this.btnMasterPatient.UseVisualStyleBackColor = true;
            this.btnMasterPatient.Click += new System.EventHandler(this.btnMasterPatient_Click);
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPatient.Location = new System.Drawing.Point(193, 260);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(146, 32);
            this.btnNewPatient.TabIndex = 11;
            this.btnNewPatient.Text = "New Meeting";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnManageMeeting
            // 
            this.btnManageMeeting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMeeting.Location = new System.Drawing.Point(193, 308);
            this.btnManageMeeting.Name = "btnManageMeeting";
            this.btnManageMeeting.Size = new System.Drawing.Size(146, 32);
            this.btnManageMeeting.TabIndex = 12;
            this.btnManageMeeting.Text = "Manage Meeting";
            this.btnManageMeeting.UseVisualStyleBackColor = true;
            this.btnManageMeeting.Click += new System.EventHandler(this.btnManageMeeting_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 378);
            this.Controls.Add(this.btnManageMeeting);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.btnMasterPatient);
            this.Controls.Add(this.btnMasterDoctor);
            this.Controls.Add(this.btnMasterICD);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMasterICD;
        private System.Windows.Forms.Button btnMasterDoctor;
        private System.Windows.Forms.Button btnMasterPatient;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnManageMeeting;
    }
}