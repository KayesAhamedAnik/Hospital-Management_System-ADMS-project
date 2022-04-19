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
using projectDemo.Framework;

namespace ProjectDemo.Gui
{
    public partial class ucAddNewPatient : UserControl
    {
        PatientRepo pRepo = new PatientRepo();
        public ucAddNewPatient()
        {
            InitializeComponent();
            this.cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadAutoAppId();
        }
        private void LoadAutoAppId()
        {
            this.txtPatientId.Text = pRepo.patientIDGenerator();// EmpRepo.Id;
        }
        private static ucAddNewPatient _Instance;
        public static ucAddNewPatient instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucAddNewPatient();
                return _Instance;
            }
        }
        private Patient fillEntity()
        {
            Patient pt = new Patient();
            pt.patientId=txtPatientId.Text;
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
        int check;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtPatientId.Text!="")
            {
                if(txtName.Text!="" && !txtName.Text.All(Char.IsDigit) && txtName.Text.Length<30)
                {
                    if (txtPhone.Text != "" && Int32.TryParse(txtPhone.Text,out check) && txtPhone.Text.Length < 12) //&& txtPhone.Text.Length!=11 || txtPhone.Text.Length!=8 
                    {
                        if (txtemergencyContact.Text != "" && Int32.TryParse(txtemergencyContact.Text, out check) && txtemergencyContact.Text.Length < 12) //&& txtemergencyContact.Text.Length!=11 || txtemergencyContact.Text.Length!=8 
                        {
                            if(txtWeight.Text != "" && Int32.TryParse(txtWeight.Text, out check) && int.Parse(txtWeight.Text) <= 800)
                            {
                                if (txtAge.Text != "" && Int32.TryParse(txtAge.Text, out check) && int.Parse(txtAge.Text) <= 120)
                                {
                                    if (cmbBloodGroup.Text != "")
                                    {
                                        if (txtAddress.Text != "")
                                        {
                                            Patient pt =fillEntity();

                                            string result= pRepo.patient_Crud("insert", pt);
                                            if (result == "Inserted")
                                            {
                                               
                                                clearFields();
                                                MessageBox.Show(result);
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
        private void clearFields()
        {
            LoadAutoAppId();
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

        private void txtSickness_Click(object sender, EventArgs e)
        {
            txtSickness.ReadOnly = false;
        }
    }
}
