using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDemo.Gui
{
    public partial class Home : Form
    {
        public Home(string user)
        {
            InitializeComponent();
            /// LoadDashboard();
            buttonFocus(btnDashboard);
            
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("T");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
          //  HideSubMenu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAddSubmenu.Visible = true;
            buttonFocus(btnAdd);

        }
        void HideSubMenu()
        {
            if (panelAddSubmenu.Visible == true)
            {
                panelAddSubmenu.Visible = false;
            }
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HideSubMenu();

            if(panelHome.Contains(panelDashboard))
            {
                panelDashboard.BringToFront();
                buttonFocus(btnDashboard);
            }
            // LoadDashboard();

        }
        void buttonFocus(Button btn)
        {
             btn.BackColor= Color.FromArgb(153, 180, 209);
             btn.ForeColor = Color.Black;

            if (btn != btnAccounts)
            {
                btnAccounts.BackColor = Color.FromArgb(35, 69, 99);
                btnAccounts.ForeColor = Color.White;

            }
            if(btn!=btnUsers)
            {
                btnUsers.BackColor = Color.FromArgb(35, 69, 99);
                btnUsers.ForeColor = Color.White;
            }
            if (btn != btnPatients)
            {
                btnPatients.BackColor = Color.FromArgb(35, 69, 99);
                btnPatients.ForeColor = Color.White;
            }
            if (btn != btnEmployees)
            {
                btnEmployees.BackColor = Color.FromArgb(35, 69, 99);
                btnEmployees.ForeColor = Color.White;
            }
            if (btn != btnDashboard)
            {
                btnDashboard.BackColor = Color.FromArgb(35, 69, 99);
                btnDashboard.ForeColor = Color.White;
            }
            if (btn != btnAdd)
            {
                btnAdd.BackColor = Color.FromArgb(35, 69, 99);
                btnAdd.ForeColor = Color.White;
            }
            if (btn != btnAdmission1)
            {
                btnAdmission1.BackColor = Color.FromArgb(35, 69, 99);
                btnAdmission1.ForeColor = Color.White;
            }
            if (btn != btnAppointment)
            {
                btnAppointment.BackColor = Color.FromArgb(35, 69, 99);
                btnAppointment.ForeColor = Color.White;
            }
            if (btn != btnAddNewPatient)
            {
                btnAddNewPatient.BackColor = SystemColors.ControlDark;
                btnAddNewPatient.ForeColor = Color.White;
            }
            if (btn != btnNewEmployee)
            {
                btnNewEmployee.BackColor = SystemColors.ControlDark;
                btnNewEmployee.ForeColor = Color.White;
            }
            if (btn != btnPatientBillGen)
            {
                btnPatientBillGen.BackColor = Color.FromArgb(35, 69, 99);
                btnPatientBillGen.ForeColor = Color.White;
            }
            if(btn!=btnDoctors)
            {
                btnDoctors.BackColor = Color.FromArgb(35, 69, 99);
                btnDoctors.ForeColor = Color.White;
            }
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.White;
           
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.Black;
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            buttonFocus(btnNewEmployee);
            if (!panelHome.Controls.Contains(ucAddNewEmployee.instance))
            {
                panelHome.Controls.Add(ucAddNewEmployee.instance);
                ucAddNewEmployee.instance.Dock = DockStyle.Fill;
                ucAddNewEmployee.instance.BringToFront();
                
            }
            else
                ucAddNewEmployee.instance.BringToFront();


        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnUsers);
            if (!panelHome.Controls.Contains(ucUsers.instance))
            {
                panelHome.Controls.Add(ucUsers.instance);
                ucUsers.instance.Dock = DockStyle.Fill;
                ucUsers.instance.BringToFront();
                
            }
            else
                ucUsers.instance.BringToFront();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnEmployees);
            if (!panelHome.Controls.Contains(ucEmployees.instance))
            {
                panelHome.Controls.Add(ucEmployees.instance);
                ucEmployees.instance.Dock = DockStyle.Fill;
                ucEmployees.instance.BringToFront();
                
            }
            else
                ucEmployees.instance.BringToFront();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnPatients);
            if (!panelHome.Controls.Contains(ucPatients.instance))
            {
                panelHome.Controls.Add(ucPatients.instance);
                ucPatients.instance.Dock = DockStyle.Fill;
                ucPatients.instance.BringToFront();
                
            }
            else
                ucPatients.instance.BringToFront();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnAccounts);
            if (!panelHome.Controls.Contains(ucFinancials.instance))
            {
                panelHome.Controls.Add(ucFinancials.instance);
                ucFinancials.instance.Dock = DockStyle.Fill;
                ucFinancials.instance.BringToFront();
                
            }
            else
                ucFinancials.instance.BringToFront();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnAppointment);
            if (!panelHome.Controls.Contains(ucAppointment.instance))
            {
                panelHome.Controls.Add(ucAppointment.instance);
                ucAppointment.instance.Dock = DockStyle.Fill;
                ucAppointment.instance.BringToFront();

            }
            else
                ucAppointment.instance.BringToFront();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnAdmission1);
            if (!panelHome.Controls.Contains(ucAdmission.instance))
            {
                panelHome.Controls.Add(ucAdmission.instance);
                ucAdmission.instance.Dock = DockStyle.Fill;
                ucAdmission.instance.BringToFront();
                
            }
            else
                ucAdmission.instance.BringToFront();
            
        }
        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
           // HideSubMenu();
            buttonFocus(btnAddNewPatient);
            if (!panelHome.Controls.Contains(ucAddNewPatient.instance))
            {
                panelHome.Controls.Add(ucAddNewPatient.instance);
                ucAddNewPatient.instance.Dock = DockStyle.Fill;
                ucAddNewPatient.instance.BringToFront();

            }
            else
                ucAddNewPatient.instance.BringToFront();
        }

        private void btnPatientBillGen_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnPatientBillGen);
            if (!panelHome.Controls.Contains(ucPatientBill.instance))
            {
                panelHome.Controls.Add(ucPatientBill.instance);
                ucPatientBill.instance.Dock = DockStyle.Fill;
                ucPatientBill.instance.BringToFront();

            }
            else
                ucPatientBill.instance.BringToFront();
        }

        private void btnPatientBill_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnPatientBillGen);
            if (!panelHome.Controls.Contains(ucPatientBill.instance))
            {
                panelHome.Controls.Add(ucPatientBill.instance);
                ucPatientBill.instance.Dock = DockStyle.Fill;
                ucPatientBill.instance.BringToFront();

            }
            else
                ucPatientBill.instance.BringToFront();

        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            buttonFocus(btnDoctors);
            if (!panelHome.Controls.Contains(ucDoctorAppointments.instance))
            {
                panelHome.Controls.Add(ucDoctorAppointments.instance);
                ucDoctorAppointments.instance.Dock = DockStyle.Fill;
                ucDoctorAppointments.instance.BringToFront();

            }
            else
                ucDoctorAppointments.instance.BringToFront();
        }
    }
}
