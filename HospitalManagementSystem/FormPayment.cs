using System;
using System.Collections;
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
    public partial class FormPayment : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        int currentSelectedRow;

        public static string item;
        public static int nominal;
        public static string notes;
        public FormPayment()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dgvData.Rows.Clear();

            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "";
            btnDelete.Text = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;

            var query = db.payment_details.Where(x => x.payment.meeting_id == FormManageMeeting.selectedMeetingId && x.deleted_at == null)
                .Select(x => new
                {
                    x.item,
                    x.nominal,
                    x.notes,
                }).ToList();

            foreach (var q in query)
            {
                dgvData.Rows.Add(q.item, q.nominal.ToString("N0").Replace(",", ""), q.notes);
            }

            dgvData.Columns.Add(btnDelete);

            var isDone = db.payments.FirstOrDefault(x => x.meeting_id == FormManageMeeting.selectedMeetingId && x.deleted_at == null);

            if (isDone != null)
            {
                tbCardHolderName.ReadOnly = tbPrimary.ReadOnly = tbServiceCode.ReadOnly = true;
                dtpExp.Enabled = btnAddNew.Enabled = btnSubmit.Enabled = false;
                btnDelete.Visible = false;
            }
            else
            {
                tbCardHolderName.ReadOnly = tbPrimary.ReadOnly = tbServiceCode.ReadOnly = false;
                dtpExp.Enabled = btnAddNew.Enabled = btnSubmit.Enabled = true;
                btnDelete.Visible = true;
            }

        }

        private void loadData()
        {
            var query = db.payments.FirstOrDefault(x => x.meeting_id == FormManageMeeting.selectedMeetingId);

            if (query != null)
            {
                tbCardHolderName.Text = query.card_holder_name;
                tbPrimary.Text = query.primary_account_number;
                dtpExp.Value = query.expiration_date;
                tbServiceCode.Text = query.service_code.ToString();
                tbTotalPayment.Text = query.total_payment.ToString("N0").Replace(",", ".") + ",00";

            }
        }

        private void calculateTotal()
        {
            var total = 0;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                total += Convert.ToInt32(row.Cells[1].Value);
            }
            tbTotalPayment.Text = total.ToString("N0").Replace(",", ".") + ",00";
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            loadDgv();
            loadData();
            tbTotalPayment.Enabled = false;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedRow = e.RowIndex;
            if (e.ColumnIndex == dgvData.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                dgvData.Rows.RemoveAt(currentSelectedRow);
                calculateTotal();
            }
        }

        private bool validation()
        {
            if (dgvData.Rows == null || tbCardHolderName.Text == string.Empty ||
                tbPrimary.Text == string.Empty || tbServiceCode.Text == string.Empty)
            {
                Support.msw("All field must be filled");
                return false;
            }

            if (tbServiceCode.TextLength != 3 && tbServiceCode.Text.Any(x => char.IsDigit(x)))
            {
                Support.msw("Service code must be 3 digit numeric");
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validation())
            {

                var queryPayment = new payment();
                queryPayment.meeting_id = FormManageMeeting.selectedMeetingId;
                queryPayment.card_holder_name = tbCardHolderName.Text;
                queryPayment.primary_account_number = tbPrimary.Text;
                queryPayment.expiration_date = dtpExp.Value;
                queryPayment.service_code = Convert.ToInt32(tbServiceCode.Text);
                queryPayment.total_payment = Convert.ToInt32(tbTotalPayment.Text.Replace(",", "").Replace(".", ""));
                queryPayment.created_at = DateTime.Now;

                db.payments.InsertOnSubmit(queryPayment);
                db.SubmitChanges();

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    var queryPaymentDetail = new payment_detail();
                    queryPaymentDetail.payment_id = queryPayment.id;
                    queryPaymentDetail.item = row.Cells[0].Value.ToString();
                    queryPaymentDetail.nominal = Convert.ToDecimal( row.Cells[1].Value);
                    queryPaymentDetail.notes = row.Cells[2].Value.ToString();
                    queryPaymentDetail.created_at = DateTime.Now;

                    db.payment_details.InsertOnSubmit(queryPaymentDetail);
                    db.SubmitChanges();
                }

                Support.msi("submit data berhasil");
                db.SubmitChanges();
                Hide();
                loadData();
                loadDgv();


            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FormNewItem().ShowDialog();
            dgvData.Rows.Add(item, nominal, notes);
            calculateTotal();
        }

        private void tbServiceCode_TextChanged(object sender, EventArgs e)
        {
            dtpExp.Value = DateTime.Now.AddYears(5);
        }
    }
}
