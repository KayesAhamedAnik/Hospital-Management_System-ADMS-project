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
    public partial class DoctorAppointments : Form
    {
        DoctorRepo dREpo = new DoctorRepo();
        string docID;
        public DoctorAppointments(string name,String id)
        {
            InitializeComponent();
            labelDoctorId.Text = id;
            labelDoctorName.Text = name;
            docID = id;
            PopulateGridView(date);
            dtpAppDate.CustomFormat = "dd-MMM-yyyy";
        }
        string date = DateTime.Now.ToString("dd-MMM-yy").ToUpper();
       
        private void PopulateGridView(string  date)
        {
            this.dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Dock = DockStyle.Fill;

            this.dgvAppointments.AutoGenerateColumns = false;
            this.dgvAppointments.DataSource = dREpo.GetAppointments(docID, date).ToList();
            this.dgvAppointments.ClearSelection();
            this.dgvAppointments.Refresh();


        }

        private void dtpAppDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dtpAppDate.Value.ToString("dd/MMM/yyyy");
            PopulateGridView(date);
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
