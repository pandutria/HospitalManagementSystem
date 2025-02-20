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
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();

            if (FormManageMeeting.status == "edit")
            {
                btnAddNew.Visible = false;
                btnEdit.Visible = true;
            } else
            {
                btnAddNew.Visible = true;
                btnEdit.Visible = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();

            var query = new patient_record();
            query.patient_id = FormManageMeeting.selectedPatientId;
            query.meeting_id = FormManageMeeting.selectedMeetingId;
            query.notes = tbNotes.Text;
            query.date = FormManageMeeting.selectedMeetingDate;
            query.created_at = DateTime.Now;
            
            db.patient_records.InsertOnSubmit(query);
            db.SubmitChanges();

            Support.msi("add new data succsess");
            Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();

            var query = db.patient_records.FirstOrDefault(x => x.id == FormManageMeeting.selectedRecordId);

            if (query != null)
            {
                query.patient_id = FormManageMeeting.selectedPatientId;
                query.meeting_id = FormManageMeeting.selectedMeetingId;
                query.notes = tbNotes.Text;
                query.date = FormManageMeeting.selectedMeetingDate;
                query.last_updated_at = DateTime.Now;

                db.SubmitChanges();

                Support.msi("edit data succsess");
                Hide();
            }
            
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            tbNotes.Text = FormManageMeeting.recordText;
        }
    }
}
