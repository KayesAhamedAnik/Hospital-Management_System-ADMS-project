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
    public partial class updateDoctorInfo : Form
    {
        Doctor D;
        DoctorRepo dRepo = new DoctorRepo();
        public updateDoctorInfo(Doctor doc)
        {
            InitializeComponent();
            D = doc;
            this.cmbDept.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void updateDoctorInfo_Load(object sender, EventArgs e)
        {
            txtDoctorId.Text = D.doctorId;
            cmbDept.Text = D.dept;
            txtspecialities.Text = D.details.ToString();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtDoctorId.Text != "")
            {
                if (cmbDept.Text != "")
                {
                    if (cbSchedule.CheckedItems.Count > 0 && txtHHFrom.Text != "" && txtHHFrom.Text != "HH" && txtMMFrom.Text != "" && txtMMFrom.Text != "MM" && int.Parse(txtHHFrom.Text) < 12 && int.Parse(txtHHFrom.Text) > 0 && int.Parse(txtMMFrom.Text) < 60 && int.Parse(txtMMFrom.Text) >= 0)
                    {
                        if (txtHHTo.Text != "" && txtHHTo.Text != "HH" && txtMMTo.Text != "" && txtMMTo.Text != "MM" && int.Parse(txtHHTo.Text) < 12 && int.Parse(txtHHTo.Text) > 0 && int.Parse(txtMMTo.Text) < 60 && int.Parse(txtMMTo.Text) >= 0)
                        {
                            // do stuff here for doctor insert
                            // bool d = EmpRepo.employee_Crud("update", txtId.Text, txtName.Text, cmbBloodGroup.Text, Int32.Parse(txtWeight.Text), Int32.Parse(txtAge.Text), Int32.Parse(txtPhone.Text), Int32.Parse(txtemergencyContact.Text), txtAddress.Text, txtMedicalHistory.Text, Int32.Parse(txtSalary.Text), CmbDesignation.Text, dtpJoinningDate.Value.ToString("dd/MMM/yyyy"));


                            Doctor doc = docEntity();
                            bool verify = dRepo.doctor_Crud("update", doc);
                            if (verify)
                            {
                                MessageBox.Show("Info Updated");
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid schedule end time");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid schedule time.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Department");
                }
            }
            else
            {
                MessageBox.Show("Doctor ID");
            }
        }

        private Doctor docEntity()
        {
            Doctor doc = new Doctor();
            doc.doctorId = txtDoctorId.Text;
            doc.dept = cmbDept.Text;
            doc.details = txtspecialities.Text;
            string selectedItems = "";
            for (int i = 0; i < cbSchedule.Items.Count; i++)
            {
                if (cbSchedule.GetItemChecked(i))
                    selectedItems += cbSchedule.Items[i].ToString() + ",";
            }
            //string selectedItems = String.Join(",", cbSchedule.Items.OfType<CheckedListBox>().Where(r => r.Items[r]) .Select(r => r.Text));

            doc.schedule = selectedItems + "   " + txtHHFrom.Text + ":" + txtMMFrom.Text + " " + btnAMPMFrom.Text + " to " + txtHHTo.Text + ":" + txtMMTo.Text + " " + btnAMPMTo.Text;
            return doc;
        }
        private void btnAMPMFrom_Click(object sender, EventArgs e)
        {
            if (btnAMPMFrom.Text == "PM")
            {
                btnAMPMFrom.Text = "AM";
            }
            else
                btnAMPMFrom.Text = "PM";
        }

        private void btnAMPMTo_Click(object sender, EventArgs e)
        {
            if (btnAMPMTo.Text == "PM")
            {
                btnAMPMTo.Text = "AM";
            }
            else
                btnAMPMTo.Text = "PM";
        }
        int outputValue = 0;
        bool isNumber = false;
        private void txtHHFrom_Click(object sender, EventArgs e)
        {
            isNumber = int.TryParse(txtHHFrom.Text, out outputValue);
            if (txtHHFrom.Text == "HH" || !isNumber)
            {
                txtHHFrom.Text = "";
            }
        }

        private void txtMMFrom_Click(object sender, EventArgs e)
        {
            isNumber = int.TryParse(txtMMFrom.Text, out outputValue);
            if (txtMMFrom.Text == "MM" || !isNumber)
            {
                txtMMFrom.Text = "";
            }

        }

        private void txtHHTo_Click(object sender, EventArgs e)
        {
            isNumber = int.TryParse(txtHHTo.Text, out outputValue);
            if (txtHHTo.Text == "HH" || !isNumber)
            {
                txtHHTo.Text = "";
            }
        }

        private void txtMMTo_Click(object sender, EventArgs e)
        {
            isNumber = int.TryParse(txtMMTo.Text, out outputValue);
            if (txtMMTo.Text == "MM" || !isNumber)
            {
                txtMMTo.Text = "";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
    }
}

