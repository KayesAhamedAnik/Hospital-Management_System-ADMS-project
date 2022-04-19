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
    public partial class ucAddNewEmployee : UserControl
    {
        private EmployeeRepo EmpRepo = new EmployeeRepo();
        private Employee emp = new Employee();
        private DoctorRepo dRepo = new DoctorRepo();

        public ucAddNewEmployee()
        {
            InitializeComponent();
            LoadAutoAppId();
            dtpJoinningDate.Format = DateTimePickerFormat.Custom;
            dtpJoinningDate.CustomFormat = "dd-MMM-yyyy";
            ClearFields();
            this.cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CmbDesignation.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadAutoAppId()
        {
            //int serial = EmpRepo.IdGenerator();
            //EmpRepo.Id = (++serial).ToString("d4");
            this.txtId.Text = EmpRepo.employeeIDGenerator();// EmpRepo.Id;
            if(panelISDoctor.Visible==true)
            {
                //this.txtDoctorId.Text = dRepo.IdGenerator();
            }
        }
        private static ucAddNewEmployee _Instance;

        public static ucAddNewEmployee instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucAddNewEmployee();
                return _Instance;
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            
            bool valid = this.FillEntity();
            // MessageBox.Show(emp.joinningDate);
            //  bool validPhone = IsPhoneNumber(txtPhone.Text);
            //   bool validEmergencyContact = IsPhoneNumber(txtemergencyContact.Text);
            int check;
            if (Validation.IsStringValid(this.txtName.Text) && txtName.Text!="" && txtName.Text.Length<30 && !txtName.Text.All(Char.IsDigit)) 
            {
                ValidTextField(customNameBorder);
                if(Validation.IsIntValid(this.txtPhone.Text) && txtPhone.Text != "" && txtPhone.Text.Length<12 && Int32.TryParse(txtPhone.Text, out check))
                {
                    ValidTextField(CustomPhoneBorder);
                    if (Validation.IsIntValid(this.txtemergencyContact.Text) && txtemergencyContact.Text != "" && txtemergencyContact.Text.Length<12 && Int32.TryParse(txtemergencyContact.Text, out check))
                    {
                        ValidTextField(CustomEphoneBorder);
                        if (Validation.IsIntValid(this.txtWeight.Text) && txtWeight.Text != "" && int.Parse(txtWeight.Text)<= 800)
                        {
                            ValidTextField(customWeightBorder);
                            if (Validation.IsIntValid(this.txtAge.Text) && txtAge.Text != "" && int.Parse(txtAge.Text) <= 150)
                            {
                                ValidTextField(customAgeBorder);
                                if (CmbDesignation.Text!="")
                                {
                                    ValidTextField(customDesignationBorder);
                                    if (cmbBloodGroup.Text!="")
                                    {
                                        ValidTextField(customBloodBorder);
                                        if (Validation.IsStringValid(txtAddress.Text) && txtAddress.Text != "")
                                        {
                                            ValidTextField(customAddressBorder);
                                            if (Validation.IsIntValid(txtSalary.Text) && txtSalary.Text != "" && txtSalary.Text.Length<8)
                                            {
                                                ValidTextField(customSalaryBorder);
                                                if (Validation.IsStringValid(txtMedicalHistory.Text) && txtMedicalHistory.Text != "")
                                                {
                                                    ValidTextField(customMediaclHistoryBorder);
                                                    if (panelISDoctor.Visible==true && CmbDesignation.SelectedItem.ToString()=="Doctor" )
                                                    {
                                                        if(txtDoctorId.Text!="")
                                                        {
                                                            if (cmbDepartment.Text != "")
                                                            {
                                                                if (cbSchedule.CheckedItems.Count>0 && txtHHFrom.Text!="" && txtHHFrom.Text!="HH" && txtMMFrom.Text!="" && txtMMFrom.Text != "MM" && int.Parse(txtHHFrom.Text)<12 && int.Parse(txtHHFrom.Text) >0 && int.Parse(txtMMFrom.Text) < 60 && int.Parse(txtMMFrom.Text) >= 0 )
                                                                {
                                                                    if (txtHHTo.Text != "" && txtHHTo.Text != "HH" && txtMMTo.Text != "" && txtMMTo.Text != "MM" && int.Parse(txtHHTo.Text) < 12 && int.Parse(txtHHTo.Text) > 0 && int.Parse(txtMMTo.Text) < 60 && int.Parse(txtMMTo.Text) >=0)
                                                                    {
                                                                        // do stuff here for doctor insert
                                                                        bool d = EmpRepo.employee_Crud("insert", txtId.Text, txtName.Text, cmbBloodGroup.Text, Int32.Parse(txtWeight.Text), Int32.Parse(txtAge.Text), Int32.Parse(txtPhone.Text), Int32.Parse(txtemergencyContact.Text), txtAddress.Text, txtMedicalHistory.Text, Int32.Parse(txtSalary.Text), CmbDesignation.Text, dtpJoinningDate.Value.ToString("dd/MMM/yyyy"));
                                                                        if (d == true)
                                                                        {
                                                                            Doctor doc = docEntity();
                                                                            bool verify = dRepo.doctor_Crud("insert", doc);
                                                                            Random rnd = new Random();
                                                                            string pass = rnd.Next(100000, 999999).ToString();
                                                                            UserRepo uRepo = new UserRepo();
                                                                            bool decision= uRepo.User_CRUD(doc.doctorId,pass,CmbDesignation.Text.ToString(),1,"insert");
                                                                            if (verify && decision)
                                                                            {
                                                                                MessageBox.Show("User Inserted.\n Password: " + pass + "  For User: " + doc.doctorId);
                                                                                ClearFields();
                                                                                this.txtDoctorId.Text = dRepo.doctorIDGenerator();
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Invalid schedule end time");
                                                                    }
                                                                   
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Invalid schedule");
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Invalid Department. Select Department");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Invalid Doctor Id");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        ValidTextField(customMediaclHistoryBorder);
                                                        if (valid)
                                                        {
                                                            // bool d = EmpRepo.Save(emp);
                                                            bool d = EmpRepo.employee_Crud("insert",txtId.Text,txtName.Text,cmbBloodGroup.Text,Int32.Parse(txtWeight.Text),Int32.Parse(txtAge.Text),Int32.Parse(txtPhone.Text),Int32.Parse(txtemergencyContact.Text),txtAddress.Text,txtMedicalHistory.Text,Int32.Parse(txtSalary.Text), CmbDesignation.Text, dtpJoinningDate.Value.ToString("dd-MMM-yyyy"));
                                                            if (d == true)
                                                            {
                                                                MessageBox.Show("Insert Successful");
                                                                ClearFields();
                                                            }
                                                            else
                                                                MessageBox.Show("Invalid Data", " \n Please Enter Correct Data");
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Invalid Data", " \n Please Enter Correct Data");
                                                        }

                                                    }


                                                }
                                                else
                                                {
                                                    InvalidTextField(customMediaclHistoryBorder);
                                                    ValidTextField(customSalaryBorder);
                                                    MessageBox.Show("Invalid Medical History");
                                                }
                                            }
                                            else
                                            {
                                                InvalidTextField(customSalaryBorder);
                                                ValidTextField(customAddressBorder);
                                                MessageBox.Show("Invalid Salary");
                                            }
                                        }
                                        else
                                        {
                                            InvalidTextField(customAddressBorder);
                                            ValidTextField(customBloodBorder);
                                            MessageBox.Show("Invalid Address");
                                        }
                                    }
                                    else
                                    {
                                        InvalidTextField(customBloodBorder);
                                        ValidTextField(customDesignationBorder);
                                        MessageBox.Show("Invalid BloodGroup");
                                    }
                                }
                                else
                                {
                                    InvalidTextField(customDesignationBorder);
                                    ValidTextField(customAgeBorder);
                                    MessageBox.Show("Invalid Designation");
                                }
                            }
                            else
                            {
                                InvalidTextField(customAgeBorder);
                                ValidTextField(customWeightBorder);
                                MessageBox.Show("Invalid Age");
                            }
                        }
                        else
                        {
                            InvalidTextField(customWeightBorder);
                            ValidTextField(CustomEphoneBorder);
                            MessageBox.Show("Invalid Weight");
                        }
                    }
                    else
                    {
                        InvalidTextField(CustomEphoneBorder);
                        ValidTextField(CustomPhoneBorder);
                        MessageBox.Show("Invalid Emergency Contact");
                    }
                }
                else
                {
                    InvalidTextField(CustomPhoneBorder);
                    ValidTextField(customNameBorder);
                    MessageBox.Show("Invalid Phone No");
                }
                
            }
            else
            {
                InvalidTextField(customNameBorder);
                MessageBox.Show("Invalid Name");
            }
        }

        private void InvalidTextField(Panel customPanel)
        {
            //customPanel.BackColor = Color.Red;

        }
        private void ValidTextField(Panel customPanel)
        {
            //customPanel.BackColor = SystemColors.Control; 

        }
        private  Doctor  docEntity()
        {
            Doctor doc = new Doctor();
            doc.doctorId=txtDoctorId.Text;
            doc.empid = txtId.Text;
            doc.dept = cmbDepartment.Text;

            string selectedItems = "";
            for (int i = 0; i < cbSchedule.Items.Count; i++)
            {
                if (cbSchedule.GetItemChecked(i))
                    selectedItems += cbSchedule.Items[i].ToString() + ",";
            }
            //string selectedItems = String.Join(",", cbSchedule.Items.OfType<CheckedListBox>().Where(r => r.Items[r]) .Select(r => r.Text));

            doc.schedule = selectedItems+"   "+txtHHFrom.Text+":"+txtMMFrom.Text+" "+btnAMPMFrom.Text+" to "+txtHHTo.Text+":"+txtMMTo.Text+" "+btnAMPMTo.Text;
            return doc;
        }
        private bool FillEntity()
        {
            if (!IsValidToSave())
                return false;
            
            emp.joinningDate = dtpJoinningDate.Value.ToString("dd-MMM-yyyy");
            emp.ename = txtName.Text;
            emp.empId = txtId.Text;
            emp.age = Int32.Parse(this.txtAge.Text);
            emp.weight = Int32.Parse(this.txtWeight.Text);
            
            emp.phoneNo = Int32.Parse(this.txtPhone.Text);
            emp.emergencyContact = Int32.Parse(this.txtemergencyContact.Text);
            emp.medicalHistory = txtMedicalHistory.Text;
            emp.bloodGroup = cmbBloodGroup.Text;
            emp.designation = CmbDesignation.Text;
            emp.address = txtAddress.Text;
            emp.salary = Int32.Parse(this.txtSalary.Text);
            return true;
        }
        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.txtName.Text) && Validation.IsStringValid(this.txtId.Text) &&
                Validation.IsStringValid(this.txtAddress.Text) && Validation.IsStringValid(this.txtPhone.Text) && Validation.IsStringValid(this.txtemergencyContact.Text) &&
                Validation.IsStringValid(this.CmbDesignation.Text) && Validation.IsStringValid(this.txtMedicalHistory.Text) && Validation.IsStringValid(this.cmbBloodGroup.Text) &&
                Validation.IsDateTimeValid(this.dtpJoinningDate.Text) && Validation.IsIntValid(this.txtSalary.Text) && Validation.IsIntValid(this.txtAge.Text) && Validation.IsIntValid(this.txtWeight.Text))
                return true;
            else
                return false;
        }
        void ClearFields()
        {
            LoadAutoAppId();
            txtName.Text = "";
            CmbDesignation.SelectedIndex = -1;
            txtAge.Text = "";
            txtWeight.Text = "";
            cmbBloodGroup.SelectedIndex =-1;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtemergencyContact.Text = "";
            txtSalary.Text = "";
            dtpJoinningDate.ResetText();
            txtMedicalHistory.Text = "None";
            txtMedicalHistory.ReadOnly = true;

            txtHHFrom.Text = "HH";
            txtHHTo.Text = "HH";
            txtMMFrom.Text= "MM";
            txtMMTo.Text = "MM";
            btnAMPMFrom.Text = "PM";
            btnAMPMTo.Text = "PM";
            cmbDepartment.Text = "";
            
        }

        public static bool IsPhoneNumber(string number)
        {
            int test;
            return int.TryParse(number, out test);
        }
        private void txtMedicalHistory_MouseClick(object sender, MouseEventArgs e)
        {
            txtMedicalHistory.ReadOnly = false;
        }
        private void CmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbDesignation.Text=="Doctor")
            {
                panelISDoctor.Visible = true;

                this.txtDoctorId.Text = dRepo.doctorIDGenerator();
            }
            else
                panelISDoctor.Visible = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
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
    }
}
