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
    public partial class updateEmployee : Form
    {
        Employee Emp = new Employee();
        EmployeeRepo EmpRepo = new EmployeeRepo();
        public updateEmployee(Employee emp)
        {
            InitializeComponent();
            Emp = emp;
            dtpJoinningDate.Format = DateTimePickerFormat.Custom;
            dtpJoinningDate.CustomFormat = "dd-MMM-yyyy";

            this.cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CmbDesignation.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void updateEmployee_Load(object sender, EventArgs e)
        {
            txtId.Text = Emp.empId;
            txtName.Text = Emp.ename;
            txtPhone.Text = Emp.phoneNo.ToString();
            txtemergencyContact.Text = Emp.emergencyContact.ToString();
            txtAge.Text = Emp.age.ToString();
            txtWeight.Text = Emp.weight.ToString();
            txtSalary.Text = Emp.salary.ToString();
            txtMedicalHistory.Text = Emp.medicalHistory;
            dtpJoinningDate.Text = Emp.joinningDate;
            cmbBloodGroup.Text = Emp.bloodGroup;
            CmbDesignation.Text = Emp.designation;
            txtAddress.Text = Emp.address;
        }
        void ClearFields()
        {

            txtName.Text = "";
            CmbDesignation.SelectedIndex = -1;
            txtAge.Text = "";
            txtWeight.Text = "";
            cmbBloodGroup.SelectedIndex = -1;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtemergencyContact.Text = "";
            txtSalary.Text = "";
            dtpJoinningDate.ResetText();
            txtMedicalHistory.Text = "None";
            txtMedicalHistory.ReadOnly = true;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int check;
            if (Validation.IsStringValid(this.txtName.Text) && txtName.Text != "" && txtName.Text.Length < 30 && !txtName.Text.All(Char.IsDigit))
            {
                if (Validation.IsIntValid(this.txtPhone.Text) && txtPhone.Text != "" && txtPhone.Text.Length < 12 && Int32.TryParse(txtPhone.Text, out check))
                {
                    if (Validation.IsIntValid(this.txtemergencyContact.Text) && txtemergencyContact.Text != "" && txtemergencyContact.Text.Length < 12 && Int32.TryParse(txtemergencyContact.Text, out check))
                    {
                        if (Validation.IsIntValid(this.txtWeight.Text) && txtWeight.Text != "" && int.Parse(txtWeight.Text) <= 800)
                        {
                            if (Validation.IsIntValid(this.txtAge.Text) && txtAge.Text != "" && int.Parse(txtAge.Text) <= 150)
                            {
                                if (CmbDesignation.Text != "")
                                {
                                    if (cmbBloodGroup.Text != "")
                                    {
                                        if (Validation.IsStringValid(txtAddress.Text) && txtAddress.Text != "")
                                        {
                                            if (Validation.IsIntValid(txtSalary.Text) && txtSalary.Text != "" && txtSalary.Text.Length < 8)
                                            {
                                                if (Validation.IsStringValid(txtMedicalHistory.Text) && txtMedicalHistory.Text != "")
                                                {
                                                    
                                                    
                                                       
                                                        
                                                            // bool d = EmpRepo.Save(emp);
                                                            bool d = EmpRepo.employee_Crud("update", txtId.Text, txtName.Text, cmbBloodGroup.Text, Int32.Parse(txtWeight.Text), Int32.Parse(txtAge.Text), Int32.Parse(txtPhone.Text), Int32.Parse(txtemergencyContact.Text), txtAddress.Text, txtMedicalHistory.Text, Int32.Parse(txtSalary.Text), CmbDesignation.Text, dtpJoinningDate.Value.ToString("dd-MMM-yyyy"));
                                                            if (d == true)
                                                            {
                                                                MessageBox.Show("Update Successful");
                                                                this.Close();
                                                                ClearFields();
                                                            }
                                                            else
                                                                MessageBox.Show("Invalid Data", " \n Please Enter Correct Data");    
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Invalid Medical History");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid Salary");
                                            }
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

                                    MessageBox.Show("Invalid Designation");
                                }
                            }
                            else
                            {

                                MessageBox.Show("Invalid Age");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Weight");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Emergency Contact");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Phone No");
                }

            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }
    

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMedicalHistory_Click(object sender, EventArgs e)
        {
            txtMedicalHistory.ReadOnly = false;
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
