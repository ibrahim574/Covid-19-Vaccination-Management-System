using Covid_19_Vaccination_Management_System.Data_Access_Layer;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashbord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            if (UserDataAccess.type == "A")
            {
                registeredUserButton.Visible = true;
                vaccineManagementButton.Visible = true;
                userManagementButton.Visible = true;
                button4.Visible = true;
            }
            else if(UserDataAccess.type == "U")
            {
                registeredUserButton.Visible = true;
                vaccineManagementButton.Visible = false;
                userManagementButton.Visible = false;
                button4.Visible = true;
            }
        }

        private void vaccineManagementButton_Click(object sender, EventArgs e)
        {
            ManageVaccine manageVaccine = new ManageVaccine();
            manageVaccine.Show();
            this.Hide();
        }

        private void registeredUserButton_Click(object sender, EventArgs e)
        {
            RegisteredUser registeredUser = new RegisteredUser();
            registeredUser.Show();
            this.Hide();
        }

        private void dashboardLogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            userManagement.Show();
            this.Hide();
        }
    }
}
