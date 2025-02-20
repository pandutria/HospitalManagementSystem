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
    public partial class FormMasterPatient : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public FormMasterPatient()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dgvData.Columns.Clear();

            var query = db.patients.Where(x => x.name.StartsWith(tbSearch.Text) && x.deleted_at == null)
            .Select(x => new
            {
                Name = x.name,
                PhoneNumber = x.phone_number,
                Email = x.email,
                DateOfBirth = x.date_of_birth,
                Address = x.address,
                Gender = x.gender,
                BloodType = x.blood_type,
                x.last_updated_at
            }).ToList();

            dgvData.DataSource = query;
            dgvData.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            dgvData.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvData.Columns["BloodType"].HeaderText = "Blood Type";
            dgvData.Columns["last_updated_at"].Visible = false;
        }
        private void FormMasterPatient_Load(object sender, EventArgs e)
        {
            loadDgv();
            tbSearch.Text = FormNewMeeting.patientName;
            tbName.Enabled = tbPhoneNumber.Enabled = tbEmail.Enabled = tbDtp.Enabled  = tbAddress.Enabled = tbGender.Enabled = tbBloodType.Enabled = false;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbPhoneNumber.Text = dgvData.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                tbEmail.Text = dgvData.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                tbDtp.Text = dgvData.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
                tbAddress.Text = dgvData.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                tbGender.Text = dgvData.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                tbBloodType.Text = dgvData.Rows[e.RowIndex].Cells["BloodType"].Value.ToString();

                if (dgvData.Rows[e.RowIndex].Cells["last_updated_at"].Value != null)
                {
                    lblLastUpdated.Text = "Last updated " + dgvData.Rows[e.RowIndex].Cells["last_updated_at"].Value.ToString();
                }
                else
                {
                    lblLastUpdated.Text = "Last updated at...";
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void lblLastUpdated_Click(object sender, EventArgs e)
        {

        }
    }
}
