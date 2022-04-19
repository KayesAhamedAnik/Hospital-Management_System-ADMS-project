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
    public partial class admitNewPatient : Form
    {
        DoctorRepo dRepo = new DoctorRepo();
        PatientRepo pRepo = new PatientRepo();
        public admitNewPatient()
        {
            InitializeComponent();
            cmbDoctor.DataSource = dRepo.GetDoctorNames("");
            cmbWardNo.DataSource = dRepo.getAvailableWards();
            cmbParientId.DataSource = pRepo.getPatientIds();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(cmbParientId.Text!="")
            {
                if(cmbWardNo.Text!="")
                {
                    if(cmbDoctor.Text!="")
                    {
                        if(dtpAdmissionDate.Text!="")
                        {
                            PatientRepo pRepo = new PatientRepo();
                            Admit ad = ConvertToEntity();
                            string result = pRepo.patient_Admission_Crud("insert",ad);
                            
                            if(result.Contains("Successful"))
                            {
                                MessageBox.Show(result);
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show(result);
                            }
                        }
                    }
                }
            }
        }
        private Admit ConvertToEntity()
        {
            var A = new Admit();
            A.admissionDate = dtpAdmissionDate.Value.ToString("dd-MMM-yyyy");
            A.patientId = cmbParientId.Text.ToString().Substring(0,6);
            A.status = txtStatus.Text.ToString(); ;
            A.assignedDoctor = cmbDoctor.Text.ToString().Substring(0,6);
            A.wardNo =int.Parse(cmbWardNo.Text.ToString());
            A.dischargeDate = "";
            A.billId = 0;
            A.admissionId = 0;
            return A;
        }
        private void cmbParientId_Click(object sender, EventArgs e)
        {
            cmbParientId.DataSource = pRepo.getPatientIds();
        }
    }
}
