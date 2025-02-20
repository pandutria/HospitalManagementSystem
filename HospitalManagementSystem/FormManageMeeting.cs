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
    public partial class FormManageMeeting : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public static int selectedMeetingId;
        public static DateTime selectedMeetingDate;
        public static int selectedRecordId;
        public static int selectedPatientId;

        public static string status;
        public static string recordText;
        public FormManageMeeting()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dgvData.Columns.Clear();

            var btnPayment = new DataGridViewButtonColumn();
            btnPayment.HeaderText = "";
            btnPayment.Text = "Payment";
            btnPayment.Name = "btnPayment";
            btnPayment.UseColumnTextForButtonValue = true;

            var query = db.meetings.Select(x => new
            {
                Date = x.date,
                PatientName = x.patient.name,
                DoctorCategory = x.doctor.doctor_category.category,
                DoctorName = x.doctor.name,
                Queue = x.queue_number,
                x.id,
                patientId = x.patient.id
            }).ToList();

            dgvData.DataSource = query;
            dgvData.Columns.Add(btnPayment);

            dgvData.Columns["PatientName"].HeaderText = "Patient Name";
            dgvData.Columns["DoctorCategory"].HeaderText = "Doctor Category";
            dgvData.Columns["DoctorName"].HeaderText = "Doctor Name";
            dgvData.Columns["id"].Visible = false;
            dgvData.Columns["patientId"].Visible = false;
        }

        private void loadDgvRecord()
        {
            dgvDataRecord.Columns.Clear();

            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue= true;

            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            var query = db.patient_records.Where(x => x.meeting_id == selectedMeetingId && x.deleted_at == null)
                .Select(x => new
                {
                    Record = x.notes,
                    x.id
                });

            dgvDataRecord.DataSource= query;
            dgvDataRecord.Columns.Add(btnEdit);
            dgvDataRecord.Columns.Add(btnDelete);
            dgvDataRecord.Columns["id"].Visible = false;

            var isDone = db.payments.FirstOrDefault(x => x.meeting_id == selectedMeetingId);

            if (isDone != null)
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                btnAddNew.Visible = false;
            } else
            {
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                btnAddNew.Visible = true;
            }

        }

        private void FormManageMeeting_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadDgvRecord();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMeetingId = (int) dgvData.Rows[e.RowIndex].Cells["id"].Value;
                selectedPatientId = (int)dgvData.Rows[e.RowIndex].Cells["patientId"].Value;
                selectedMeetingDate = (DateTime) dgvData.Rows[e.RowIndex].Cells["Date"].Value;
                loadDgvRecord() ;
            }

            if (e.ColumnIndex == dgvData.Columns["btnPayment"].Index && e.RowIndex >= 0)
            {
                new FormPayment().Show();
                Hide();
            }
        }

        private void dgvDataRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDataRecord.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var queryDelete = db.patient_records.FirstOrDefault(x => x.id == (int)dgvDataRecord.Rows[e.RowIndex].Cells["id"].Value);

                if (queryDelete != null)
                {
                    db.patient_records.DeleteOnSubmit(queryDelete);
                    db.SubmitChanges();
                    Support.msi("delete data berhasil");
                    loadDgv();
                    loadDgvRecord();
                }
            }

            selectedRecordId = (int)dgvDataRecord.Rows[e.RowIndex].Cells["id"].Value;
            

            if (e.ColumnIndex == dgvDataRecord.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                var queryUpdate = db.patient_records.FirstOrDefault(x => x.id == (int)dgvDataRecord.Rows[e.RowIndex].Cells["id"].Value);

                if (queryUpdate != null)
                {
                    recordText = (string)dgvDataRecord.Rows[e.RowIndex].Cells["Record"].Value;
                    status = "edit";
                    new FormDialog().ShowDialog();

                    loadDgv();
                    loadDgvRecord();
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            status = "add";
            new FormDialog().ShowDialog();

            loadDgv();
            loadDgvRecord();
        }
    }
}
