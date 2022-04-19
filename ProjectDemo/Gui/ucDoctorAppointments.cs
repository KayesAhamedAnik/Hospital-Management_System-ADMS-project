using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectDemo.Entity;
using ProjectDemo.Repo;

namespace ProjectDemo.Gui
{
    public partial class ucDoctorAppointments : UserControl
    {
        DoctorRepo dRepo = new DoctorRepo();
        public ucDoctorAppointments()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private static ucDoctorAppointments _Instance;
        public static ucDoctorAppointments instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucDoctorAppointments();
                return _Instance;
            }
        }
        private void PopulateGridView()
        {
            this.dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.MultiSelect = false;
            // dgvEmployee.Dock = DockStyle.Fill;
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.AutoGenerateColumns = false;
            this.dgvDoctors.DataSource = dRepo.GetDoctors().ToList();
            this.dgvDoctors.ClearSelection();
            this.dgvDoctors.Refresh();
        }

        private void updateDocSchedule_Click(object sender, EventArgs e)
        {
            if(dgvDoctors.SelectedRows.Count==1)
            {
                Doctor doc = new Doctor();
                if (dgvDoctors.CurrentRow.Cells["doctorid"].Value.ToString() != null)
                {
                    doc.doctorId = dgvDoctors.CurrentRow.Cells["doctorid"].Value.ToString();
                }
                if(dgvDoctors.CurrentRow.Cells["details"].Value.ToString()!=null)
                {
                    doc.details = dgvDoctors.CurrentRow.Cells["details"].Value.ToString();
                }
                if( dgvDoctors.CurrentRow.Cells["schedule"].Value.ToString()!=null)
                {
                    doc.schedule = dgvDoctors.CurrentRow.Cells["schedule"].Value.ToString();
                }
                if(dgvDoctors.CurrentRow.Cells["dept"].Value.ToString()!=null)
                {
                    doc.dept = dgvDoctors.CurrentRow.Cells["dept"].Value.ToString();
                   
                }
                
                
                updateDoctorInfo udi = new updateDoctorInfo(doc);
                udi.ShowDialog();
            }
            else
            {
                MessageBox.Show("PLease Select A Row.");
            }
        }

        private void viewAppointments_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 1)
            {

               string id = dgvDoctors.CurrentRow.Cells["doctorid"].Value.ToString();
               string name = dgvDoctors.CurrentRow.Cells["ename"].Value.ToString();
                DoctorAppointments dapp = new DoctorAppointments(name,id);
                dapp.ShowDialog();
                PopulateGridView();
            }
            else
            {
                MessageBox.Show("PLease Select A Row.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();

        }
    }
}
