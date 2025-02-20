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
    public partial class FormNewItem : Form
    {
        public FormNewItem()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormPayment.item = tbItem.Text;
            FormPayment.nominal = Convert.ToInt32( tbNominal.Text);
            FormPayment.notes = tbNotes.Text;
            Support.msi("add new item succses");

            Hide();
        }
    }
}
