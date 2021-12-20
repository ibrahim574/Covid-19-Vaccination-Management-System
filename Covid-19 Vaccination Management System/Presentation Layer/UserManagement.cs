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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void loadUserButton_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        void UpdateGridView()
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            userDataGridView.DataSource = userDataAccess.GetUser();
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userManagementBackButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            
        }


        void ClearFields()
        {
            userDeleteIdTextBox.Text = string.Empty;
            updateUserIdTextBox.Text = string.Empty;
            updateUserNTextBox.Text = string.Empty;
            updateUserNamTextBox.Text = string.Empty;
            updateUserPasswordTextBox.Text = string.Empty;
            updateUserEmailTextBox.Text = string.Empty;
            updateDateOfBirthDateTimePicker.Text = string.Empty;
            bloodGroupComboBox.Text = string.Empty;
        }


        private void userInfroUpdateButton_Click(object sender, EventArgs e)
        {
            string gender;

            if (updateUserIdTextBox.Text == "")
            {
                MessageBox.Show("Id cannot be empty");
            }
            else if (updateUserIdTextBox.Text.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Vaccine ID cannot contin character");
            }
            else if (updateUserNTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (updateUserNTextBox.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Name cannot contin any numerical value");
            }
            else if (updateUserNamTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (updateUserPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (updateUserPasswordTextBox.Text.Length < 6 )
            {
                MessageBox.Show("Password is too short, Must be 6 character");
            }
            else if (updateUserEmailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (updateDateOfBirthDateTimePicker.Text == "")
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
                if (maleRadioButton.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                UserDataAccess userDataAccess = new UserDataAccess();
                if (userDataAccess.UpdateUser(Convert.ToInt32(updateUserIdTextBox.Text), updateUserNTextBox.Text, updateUserNamTextBox.Text, updateUserPasswordTextBox.Text, updateUserEmailTextBox.Text, updateDateOfBirthDateTimePicker.Text, gender, bloodGroupComboBox.Text))
                {
                    MessageBox.Show("User updated");
                    UpdateGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error in updating");
                    ClearFields();
                }


            }


        }



        private void userDeleteButton_Click(object sender, EventArgs e)
        {

            if (userDeleteIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a User Id !");
            }

            else if (userDeleteIdTextBox.Text.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("User ID cannot contin character");
            }

            else
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                User user = userDataAccess.GetUserById(Convert.ToInt32(userDeleteIdTextBox.Text));
                if (user == null)
                {
                    MessageBox.Show("Invalid User ID");
                    ClearFields();
                }

                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        userDataAccess = new UserDataAccess();
                        if (userDataAccess.DeleteUser(Convert.ToInt32(userDeleteIdTextBox.Text)))
                        {
                            MessageBox.Show("User deleted");
                            UpdateGridView();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Error in deleting! Admin can not be deleted");
                            ClearFields();

                        }
                    }
                }
            }

        }
    }
}
