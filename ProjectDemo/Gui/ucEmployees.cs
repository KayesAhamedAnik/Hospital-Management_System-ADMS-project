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
    public partial class ucEmployees : UserControl
    {
        EmployeeRepo eRepo = new EmployeeRepo();
        public ucEmployees()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private static ucEmployees _Instance;
        public static ucEmployees instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucEmployees();
                return _Instance;
            }
        }
        private void PopulateGridView()
        {
            this.dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.MultiSelect = false;
           // dgvEmployee.Dock = DockStyle.Fill;
           dgvEmployee.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = eRepo.GetAllEmployees().ToList();
            this.dgvEmployee.ClearSelection();
            this.dgvEmployee.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();
            txtSearch.Text = "";
        }
        private void updateEmployee_Click(object sender, EventArgs e)
        {
            if (this.dgvEmployee.SelectedRows.Count == 1)
            {
                Employee emp = ConvertToEmployeeEntity(dgvEmployee.CurrentRow);
                updateEmployee uemp = new updateEmployee(emp);
                uemp.ShowDialog();
                PopulateGridView();
            }
            //if(this.dgvSearch.SelectedRows.Count == 1)
            //{
            //    foreach(DataGridViewRow rows in dgvEmployee.Rows)
            //     {
            //        if(dgvSearch.CurrentRow.Cells[0]==  rows.Cells[0])
            //        {
            //        // var i=  dgvSearch.CurrentRow.Index;
            //           rows.Selected = true;
            //            Employee emp = ConvertToEmployeeEntity(dgvEmployee.CurrentRow);
            //            updateEmployee uemp = new updateEmployee(emp);
            //            uemp.ShowDialog();
            //            PopulateGridView();
            //        }


            //    }
  
            //}
            else
            {
                MessageBox.Show("Plese Select a row first");
            }
        }
        private Employee ConvertToEmployeeEntity(DataGridViewRow row)
        {
            if (row == null)
            {
                return null;
            }

            var E = new Employee();
            E.empId = row.Cells["empid"].Value.ToString();
            E.ename = row.Cells["ename"].Value.ToString();
            E.bloodGroup =row.Cells["bloodgroup"].Value.ToString();
            E.weight = Int32.Parse(row.Cells["weight"].Value.ToString());
            E.age = Int32.Parse(row.Cells["age"].Value.ToString());
            E.phoneNo = Int64.Parse(row.Cells["phoneno"].Value.ToString());
            E.emergencyContact = Int64.Parse(row.Cells["emergencyContact"].Value.ToString());
            E.address = row.Cells["address"].Value.ToString();
            E.medicalHistory =row.Cells["medicalhistory"].Value.ToString();
            E.salary = Int32.Parse(row.Cells["salary"].Value.ToString());
            E.designation = row.Cells["designation"].Value.ToString();
            E.joinningDate = row.Cells["joinningDate"].Value.ToString();
            return E;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text=="" )
            {
                dgvSearch.Visible = false;
            }
            else
                dgvSearch.Visible = true;
                PopulateSearchResult();


        }
        void PopulateSearchResult()
        {
           // this.dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.MultiSelect = false;
            // dgvEmployee.Dock = DockStyle.Fill;
          //  dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.AutoGenerateColumns = false;
            this.dgvSearch.DataSource = eRepo.Search(txtSearch.Text.ToString()+'%').ToList();
            this.dgvSearch.ClearSelection();
            this.dgvSearch.Refresh();
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {


          if(dgvSearch.SelectedRows.Count==1)
            {
                
                foreach (DataGridViewRow rows in dgvEmployee.Rows)
                {
                    if (dgvSearch.CurrentRow.Cells[0].Value.ToString() == rows.Cells[0].Value.ToString())
                    {
                        // var i=  dgvSearch.CurrentRow.Index;
                        
                        dgvEmployee.ClearSelection();
                        
                        //dgvEmployee.CurrentRow. = rows[SelectedRow.Value];
                        rows.Selected = true;
                    }


                }
            }
        }

    }
}
