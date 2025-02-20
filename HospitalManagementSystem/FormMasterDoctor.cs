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
    public partial class FormMasterDoctor : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public FormMasterDoctor()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadCbo()
        {
            var query = db.doctor_categories;

            cboCategory.DataSource = query;
            cboCategory.ValueMember = "id";
            cboCategory.DisplayMember = "category";
        }

        private void loadDgv()
        {
            dgvData.Columns.Clear();

            if (cboCategory.SelectedValue != null)
            {
                var query = db.doctors.Where(x => x.doctor_category.category == cboCategory.Text && x.name.StartsWith(tbSearch.Text) && x.deleted_at == null)
                .Select(x => new {
                    Name = x.name,
                    PhoneNumber = x.phone_number,
                    Email = x.email,
                    DateOfBirth = x.date_of_birth,
                    Category = x.doctor_category.category,
                    Address = x.address,
                    Gender = x.gender,
                    AssignedRoom = x.assigned_room,
                    x.last_updated_at
                }).ToList();

                dgvData.DataSource = query;
                dgvData.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                dgvData.Columns["PhoneNumber"].HeaderText = "Phone Number";
                dgvData.Columns["AssignedRoom"].HeaderText = "Assigned Room";
                dgvData.Columns["last_updated_at"].Visible = false;
            } else
            {
                var query = db.doctors.Where(x => x.name.StartsWith(tbSearch.Text) && x.deleted_at == null)
                .Select(x => new {
                    Name = x.name,
                    PhoneNumber = x.phone_number,
                    Email = x.email,
                    DateOfBirth = x.date_of_birth,
                    Category = x.doctor_category.category,
                    Address = x.address,
                    Gender = x.gender,
                    AssignedRoom = x.assigned_room,
                    x.last_updated_at
                }).ToList();

                dgvData.DataSource = query;
                dgvData.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                dgvData.Columns["PhoneNumber"].HeaderText = "Phone Number";
                dgvData.Columns["AssignedRoom"].HeaderText = "Assigned Room";
                dgvData.Columns["last_updated_at"].Visible = false;
            }
        }

        private void FormMasterDoctor_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadCbo();
            cboCategory.SelectedValue = 0;
            tbSearch.Text = FormMasterICD_11.doctorName + FormNewMeeting.doctorName;
            tbName.Enabled = tbPhoneNumber.Enabled = tbEmail.Enabled = tbDtp.Enabled = tbCategory.Enabled = tbAddress.Enabled = tbGender.Enabled = tbAssignedRoom.Enabled = false;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbPhoneNumber.Text = dgvData.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                tbEmail.Text = dgvData.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                tbDtp.Text = dgvData.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
                tbCategory.Text = dgvData.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                tbAddress.Text = dgvData.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                tbGender.Text = dgvData.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                tbAssignedRoom.Text = dgvData.Rows[e.RowIndex].Cells["AssignedRoom"].Value.ToString();

                if (dgvData.Rows[e.RowIndex].Cells["last_updated_at"].Value != null)
                {
                    lblLastUpdated.Text = "Last updated " + dgvData.Rows[e.RowIndex].Cells["last_updated_at"].Value.ToString();
                } else
                {
                    lblLastUpdated.Text = "Last updated at...";
                }
            }
        }

        private void cboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDgv();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadDgv();
        }
    }
}
