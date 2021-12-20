using Covid_19_Vaccination_Management_System.Data_Access_Layer;
using Covid_19_Vaccination_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19_Vaccination_Management_System.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (userNameTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Username and password can not be empty");
            }
            else if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                if (userDataAccess.LoginValidation(userNameTextBox.Text, passwordTextBox.Text))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Show();
            this.Hide();
        }
    }
}
