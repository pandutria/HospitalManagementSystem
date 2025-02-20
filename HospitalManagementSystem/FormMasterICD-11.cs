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
    public partial class FormMasterICD_11 : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public static string doctorName;
        public FormMasterICD_11()
        {
            InitializeComponent();
        }

        private void loadCbo()  
        {
            var query = db.icd_11s;
            cboICD.DataSource = query.Where(x => x.deleted_at == null)
                .Select(x => new {ID = x.id, name = (x.id + " )  " + x.name)});

            cboICD.ValueMember = "ID";
            cboICD.DisplayMember = "name";
        }

        private void FormMasterICD_11_Load(object sender, EventArgs e)
        {
            loadCbo();
        }

        private void cboICD_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboICD.SelectedValue != null)
            {
                var queryDesc = db.icd_11s.FirstOrDefault(x => (x.id + " )  " + x.name) == cboICD.Text);

                if (queryDesc != null)
                {
                    tbDesc.Text = queryDesc.description;

                    var queryExclusions = db.icd_11_exclusions.FirstOrDefault(x => x.icd_11_id == queryDesc.id);

                    if (queryExclusions != null)
                    {
                        tbExclutions.Text = queryExclusions.exclusion;
                    }

                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

                    var queryDoctorRecomendation = db.icd_11_doctor_recommendations.FirstOrDefault(x => x.icd_11_id == queryDesc.id);
                    var queryDoctor = db.doctors.Where(x => x.doctor_category_id == queryDoctorRecomendation.doctor_category_id);

                    foreach (var q in queryDoctor)
                    {
                        var subPanel = new FlowLayoutPanel();
                        subPanel.AutoSize = true;
                        subPanel.FlowDirection = FlowDirection.LeftToRight;

                        var lblDoctorCategory = new Label();
                        lblDoctorCategory.AutoSize = true;
                        lblDoctorCategory.Text = q.doctor_category.category;

                        var linkDoctorName = new LinkLabel();
                        linkDoctorName.Name = "linkDoctorName";
                        linkDoctorName.Text = q.name;

                        linkDoctorName.LinkClicked += (s, args) =>
                        {
                            doctorName = q.name;
                            new FormMasterDoctor().ShowDialog();
                        };



                        subPanel.Controls.Add(lblDoctorCategory);
                        subPanel.Controls.Add(linkDoctorName);

                        flowLayoutPanel1.Controls.Add(subPanel);
                    }
                }

                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
