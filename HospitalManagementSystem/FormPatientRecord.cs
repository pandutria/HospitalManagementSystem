using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class FormPatientRecord : Form
    {
        public FormPatientRecord()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            var db = new DataBaseDataContext();
            var query = db.patient_records.Where(x => x.patient.name == FormNewMeeting.patientName && x.deleted_at == null)
                .Select(x => new
            {
                Date = x.date,
                DoctorCategory = x.meeting.doctor.doctor_category.category,
                DoctorName = x.meeting.doctor.name,
                Record = x.notes

            }).ToList();

            dgvData.DataSource = query;
            dgvData.Columns["DoctorCategory"].HeaderText = "Doctor Category";
            dgvData.Columns["DoctorName"].HeaderText = "Doctor Name";

        }
        private void FormPatientRecord_Load(object sender, EventArgs e)
        {
            loadDgv();
            lblMedical.Text = "Medical Record of " + FormNewMeeting.patientName;
        }
    }
}
