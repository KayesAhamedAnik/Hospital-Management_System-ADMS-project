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
    public partial class ucAppointment : UserControl
    {
        DoctorRepo dRepo = new DoctorRepo();

        public ucAppointment()
        {
            InitializeComponent();
            PopulateGridView();
            dtpAppointmentDate.CustomFormat = "dd-MMM-yyyy";
            this.cmbDoctorName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDept.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private static ucAppointment _Instance;

        public static ucAppointment instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucAppointment();
                return _Instance;
            }
        }
        private void PopulateGridView()
        {
            this.dgvDoctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctor.MultiSelect = false;

            this.dgvDoctor.AutoGenerateColumns = false;
            this.dgvDoctor.DataSource = dRepo.GetDoctors().ToList();
            this.dgvDoctor.ClearSelection();
            this.dgvDoctor.Refresh();
            dgvDoctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        string getDoctorId;
        private void cmdDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctorName.DataSource =dRepo.GetDoctorNames(cmbDept.Text);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void clearFields()
        {
            txtPatientName.Text = "";
            cmbDept.SelectedIndex = -1;
            cmbDoctorName.SelectedIndex = -1;
          //  txtpatientid.Text = "";
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtPatientName.Text!="")
            {
                if (cmbDept.Text != "")
                {
                    if (cmbDoctorName.Text != "")
                    {
                        if (dtpAppointmentDate.Text != "")
                        {
                            Appointment app = AppointmentEntity();
                            string result = dRepo.DoctorAppointment_Crud("insert", app);
                            clearFields();
                            MessageBox.Show(result);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Appointment Date");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Doctor Name");
                    }
                }
                else
                { 
                    MessageBox.Show("Invalid dept Name"); 
                }
            }
            else
            {
                MessageBox.Show("Invalid Patient Name");
            }
            
        }
        private Appointment AppointmentEntity() 
        {
            var app = new Appointment();
            app.patientName=txtPatientName.Text;
            app.doctorID = getDoctorId;
            string id= cmbDoctorName.Text.Substring(cmbDoctorName.Text.IndexOf('|') + 1);
            app.doctorID = id.Trim();
            app.appointmentDate = dtpAppointmentDate.Value.ToString("dd/MMM/yyyy");

            return app;
        }
    }
}
