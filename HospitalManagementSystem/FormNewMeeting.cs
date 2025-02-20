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

    public partial class FormNewMeeting : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public static string patientName;
        int patientId;
        public static string doctorName;
        string doctorRoom;

        public FormNewMeeting()
        {
            InitializeComponent();
        }

        private void FormNewMeeting_Load(object sender, EventArgs e)
        {
            lblQueneNumber.Text = string.Empty;
            loadCbo();
            dtpDate.CustomFormat = "dddd ,dd MMMM yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
        }

        private void linkViewPatientData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbPatientName.Text != string.Empty)
            {
                patientName = tbPatientName.Text;
                new FormMasterPatient().ShowDialog();
            }
            else
            {
                Support.msw("Field patient name must be field");
            }
        }

        private void linkPatientRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbPatientName.Text != string.Empty)
            {
                var query = db.patients.FirstOrDefault(x => x.name == tbPatientName.Text);

                if (query != null)
                {
                    patientName = tbPatientName.Text;
                    new FormPatientRecord().ShowDialog();
                }
                else
                {
                    Support.msw("patient not found in db");
                }

            }
            else
            {
                Support.msw("Field patient name must be filled");
            }
        }

        private void loadCbo()
        {
            var queryDoctorCategory = db.doctor_categories;
            cboDoctorCategory.DataSource = queryDoctorCategory;
            cboDoctorCategory.ValueMember = "id";
            cboDoctorCategory.DisplayMember = "category";

            var queryDoctorName = db.doctors.Where(x => x.doctor_category.category == cboDoctorCategory.Text);
            cboDoctorName.DataSource = queryDoctorName;
            cboDoctorName.ValueMember = "id";
            cboDoctorName.DisplayMember = "name";


        }

        private void cboDoctorCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            loadCbo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doctorName = cboDoctorName.Text;
            new FormMasterDoctor().ShowDialog();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            var queryRescheduleMeeting = db.meetings.FirstOrDefault(x => x.date == dtpDate.Value && x.patient.name == tbPatientName.Text);

            if (queryRescheduleMeeting != null)
            {
                Support.msw("patient already have meeeting, create new meeting please");
            }

            var queryNewMeeting = db.meetings.FirstOrDefault(x => x.date == dtpDate.Value && x.patient.name != tbPatientName.Text && x.doctor.name != cboDoctorName.Text);

            if (queryNewMeeting != null)
            {
                lblQueneNumber.Text = (queryNewMeeting.queue_number + 1).ToString();
            }
            else
            {
                lblQueneNumber.Text = "1";
            }

        }

        private void tbPatientName_TextChanged(object sender, EventArgs e)
        {
            var query = db.patients.FirstOrDefault(x => x.name == tbPatientName.Text);

            if (query != null)
            {
                patientId = query.id;
            }
        }

        private void cboDoctorName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboDoctorName.SelectedValue != null)
            {
                var query = db.doctors.FirstOrDefault(x => x.name == cboDoctorName.Text);

                if (query != null)
                {
                    doctorRoom = query.assigned_room;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (lblQueneNumber.Text == string.Empty || tbPatientName.Text == string.Empty)
            {
                Support.msw("All field must field");
            }
            else
            {
                try
                {
                    var query = new meeting();
                    query.patient_id = patientId;
                    query.doctor_id = (int) cboDoctorCategory.SelectedValue;
                    query.queue_number = Convert.ToInt32( lblQueneNumber.Text);
                    query.date = dtpDate.Value;
                    query.created_at = DateTime.Now;
                    query.room = doctorRoom;

                    db.meetings.InsertOnSubmit(query);
                    db.SubmitChanges();
                    Support.msi("create meeting succses");
                    Hide();

                } catch (Exception ex)
                {
                    Support.mse(ex.Message);
                }
             }

        }
    }
}
