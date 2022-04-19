using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectDemo.Gui;
using ProjectDemo.Repo;

namespace ProjectDemo.Gui
{
    public partial class login : Form
    {
        private UserRepo userRp { get; set; }
        public login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.userRp = new UserRepo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserame.Text != "" && txtPassword.Text != "")
            {
                string verify = userRp.Login(txtUserame.Text, txtPassword.Text);
                //if (verify==)
                //{
                //    string role = userRp.Role(txtUserame.Text);
                if (verify == "Admin")
                {
                    MessageBox.Show("Login Successfull");
                    this.Hide();
                    Home home = new Home(txtUserame.Text); //Admin
                    home.ShowDialog();
                    this.Show();
                    txtUserame.Text = "";
                    txtPassword.Text = "";
                }
                else if (verify == "Doctor")
                {
                    MessageBox.Show("Login Successfull");
                    this.Hide();
                    Home home = new Home(txtUserame.Text); // Doctor Dashboard
                    home.ShowDialog();
                    this.Show();
                    txtUserame.Text = "";
                    txtPassword.Text = "";
                }
                else if (verify == "Receiptionist")
                {
                    MessageBox.Show("Login Successfull");
                    this.Hide();
                    Home home = new Home(txtUserame.Text); //Receiptionist Dashboard 
                    home.ShowDialog();
                    this.Show();
                    txtUserame.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUserame.Text = "";
                txtPassword.Text = "";
                lblForgotPassword.Visible = true;
            }
        }
        
           
            
    }


}

