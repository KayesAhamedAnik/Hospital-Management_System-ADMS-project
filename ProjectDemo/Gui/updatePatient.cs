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
using projectDemo.Framework;
using ProjectDemo.Repo;

namespace ProjectDemo.Gui
{
    public partial class updatePatient : Form
    {
        Patient pt=new Patient();
        PatientRepo pRepo = new PatientRepo();
        public updatePatient(Patient patient)
        {
            InitializeComponent();
            pt = patient;
            this.cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int check;
            if (txtPatientId.Text != "")
            {
                if (txtName.Text != "" && !txtName.Text.All(Char.IsDigit) && txtName.Text.Length < 30)
                {
                    if (txtPhone.Text != "" && Int32.TryParse(txtPhone.Text, out check) && txtPhone.Text.Length < 12) //&& txtPhone.Text.Length!=11 || txtPhone.Text.Length!=8 
                    {
                        if (txtemergencyContact.Text != "" && Int32.TryParse(txtemergencyContact.Text, out check) && txtemergencyContact.Text.Length < 12) //&& txtemergencyContact.Text.Length!=11 || txtemergencyContact.Text.Length!=8 
                        {
                            if (txtWeight.Text != "" && Int32.TryParse(txtWeight.Text, out check) && int.Parse(txtWeight.Text) <= 800)
                            {
                                if (txtAge.Text != "" && Int32.TryParse(txtAge.Text, out check) && int.Parse(txtAge.Text) <= 120)
                                {
                                    if (cmbBloodGroup.Text != "")
                                    {
                                        if (txtAddress.Text != "")
                                        {
                                            Patient pt = fillEntity();

                                            string result = pRepo.patient_Crud("update", pt);
                                            if (result == "Patient Updated.")
                                            {
                                                MessageBox.Show(result);
                                                clearFields();
                                                this.Close();
                                            }
                                            else
                                                MessageBox.Show(result);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid Address");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid BloodGroup");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Age Data");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Weight Data");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Emergency Contact");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid PhoneNo");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Name");
                }
            }
            else
            {
                MessageBox.Show("Invalid Id");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private Patient fillEntity()
        {
            Patient pt = new Patient();
            pt.patientId = txtPatientId.Text;
            pt.name = txtName.Text;
            pt.phoneNo = Int32.Parse(txtPhone.Text);
            pt.emergencyContact = Int32.Parse(txtemergencyContact.Text);
            pt.weight = Int32.Parse(txtWeight.Text);
            pt.age = Int32.Parse(txtAge.Text);
            pt.address = txtAddress.Text;
            pt.sickness = txtSickness.Text;
            pt.bloodGroup = cmbBloodGroup.Text;

            return pt;
        }
        private void clearFields()
        {
            
            txtName.Text = "";
            txtPhone.Text = "";
            txtWeight.Text = "";
            txtSickness.Text = "None";
            txtemergencyContact.Text = "";
            txtAge.Text = "";
            cmbBloodGroup.SelectedIndex = -1;
            txtAddress.Text = "";
            txtSickness.Text = "None";
            txtSickness.ReadOnly = true;
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
        private void txtSickness_Click(object sender, EventArgs e)
        {
            txtSickness.ReadOnly = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatePatient_Load(object sender, EventArgs e)
        {
            txtPatientId.Text = pt.patientId;
            txtName.Text = pt.name;
            txtPhone.Text = pt.phoneNo.ToString();
            txtemergencyContact.Text = pt.emergencyContact.ToString();
            txtAge.Text = pt.age.ToString();
            txtWeight.Text = pt.weight.ToString();
            txtSickness.Text = pt.sickness;
            cmbBloodGroup.Text = pt.bloodGroup;
            txtAddress.Text = pt.address;
        }
    }
}
