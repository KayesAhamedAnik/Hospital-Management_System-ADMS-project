using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectDemo.Repo;
using ProjectDemo.Entity;

namespace ProjectDemo.Gui
{
    public partial class ucPatients : UserControl
    {
        public ucPatients()
        {
            InitializeComponent();
            PopulateGridView();
        }
        PatientRepo pt = new PatientRepo();
        private static ucPatients _Instance;
        public static ucPatients instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucPatients();
                return _Instance;
            }
        }
        private void PopulateGridView()
        {
            this.dgvPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.MultiSelect = false;

            this.dgvPatient.AutoGenerateColumns = false;
            this.dgvPatient.DataSource = pt.GetAllpatients().ToList();
            this.dgvPatient.ClearSelection();
            this.dgvPatient.Refresh();
           // dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvPatient.ScrollBars = HorizontalScroll.Visible;

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void updatePatient_Click(object sender, EventArgs e)
        {
            if (this.dgvPatient.SelectedRows.Count == 1)
            {
                Patient pt = ConvertToPatientEntity(dgvPatient.CurrentRow);
                updatePatient uPatient = new updatePatient(pt);
                uPatient.ShowDialog();
                PopulateGridView();
            }
            else
            {
                MessageBox.Show("Plese Select a row first");
            }
        }
        private Patient ConvertToPatientEntity(DataGridViewRow row)
        {
            if (row == null)
            {
                return null;
            }

            var P = new Patient();
            P.patientId = row.Cells["patientid"].Value.ToString();
            P.name = row.Cells["name"].Value.ToString();
            P.bloodGroup = row.Cells["bloodgroup"].Value.ToString();
            P.weight = Int32.Parse(row.Cells["weight"].Value.ToString());
            P.age = Int32.Parse(row.Cells["age"].Value.ToString());
            P.phoneNo = Int64.Parse(row.Cells["phoneno"].Value.ToString());
            P.emergencyContact = Int64.Parse(row.Cells["emergencyContact"].Value.ToString());
            P.address = row.Cells["address"].Value.ToString();
            P.sickness = row.Cells["sickness"].Value.ToString();

            return P;

        }
    }
}
