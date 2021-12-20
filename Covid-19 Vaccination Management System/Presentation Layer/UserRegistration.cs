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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void userRegistrationBackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (nameTextBox.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Name cannot contin any numerical value");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if(passwordTextBox.Text.Length < 6)
            {
                MessageBox.Show("Password is too short, Must be 6 character");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm password cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {

                    User user = new User();
                    user.Name = nameTextBox.Text;
                    user.Username = usernameTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.Email = emailTextBox.Text;
                    user.DateOfBirth = dateOfBirthDateTimePicker.Text;
                    if (maleRadioButton.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else
                    {
                        user.Gender = "Female";
                    }
                    user.BloodGroup = bloodGroupComboBox.Text;
                    user.UserType = "User";

                    UserDataAccess userDataAccess = new UserDataAccess();
                    if (userDataAccess.UserRegister(user))
                    {
                        MessageBox.Show("User added");
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }

                }
            }
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(submitButton.Enabled == false)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
