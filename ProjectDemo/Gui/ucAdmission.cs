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
    public partial class ucAdmission : UserControl
    {
        Admit admit = new Admit();
        PatientRepo pRepo = new PatientRepo();
        public ucAdmission()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private static ucAdmission _Instance;

        public static ucAdmission instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucAdmission();
                return _Instance;
            }
        }
        private void PopulateGridView()
        {
            this.dgvAdmissions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmissions.MultiSelect = false;
            // dgvEmployee.Dock = DockStyle.Fill;
            dgvAdmissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmissions.AutoGenerateColumns = false;
            this.dgvAdmissions.DataSource =pRepo.GetAllAdmissions().ToList();
            this.dgvAdmissions.ClearSelection();
            this.dgvAdmissions.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnAddNewAdmit_Click(object sender, EventArgs e)
        {
            admitNewPatient anp = new admitNewPatient();
            anp.ShowDialog();
            PopulateGridView();
        }
    }
}
