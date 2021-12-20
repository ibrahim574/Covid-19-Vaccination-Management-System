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
    public partial class RegisteredUser : Form
    {
        public RegisteredUser()
        {
            InitializeComponent();
        }

        private void RegisteredUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadRegisteredUserButton_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        void UpdateGridView()
        {
            RegisteredUserDataAccess registeredUserDataAccess = new RegisteredUserDataAccess();
            registeredUserDataGridView.DataSource = registeredUserDataAccess.GetRegisteredUser();
        }

        private void registeredUserBackButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void RegisteredUser_Load(object sender, EventArgs e)
        {

        }

        private void loadCompletedVaccinationButton_Click(object sender, EventArgs e)
        {
            VaccinationCompleted vaccinationCompleted = new VaccinationCompleted();
            vaccinationCompleted.Show();
            this.Hide();
        }

        private void loadFirstDoseButton_Click(object sender, EventArgs e)
        {
            FirstDoseCompleted firstDoseCompleted = new FirstDoseCompleted();
            firstDoseCompleted.Show();
            this.Hide();
        }

        private void loadFirstSecondDoseButton_Click(object sender, EventArgs e)
        {
            FristDosePending secondDoseCompleted = new FristDosePending();
            secondDoseCompleted.Show();
            this.Hide();
        }

        private void vaccineLoadButton_Click(object sender, EventArgs e)
        {
            UpdateGridViewForVaccine();
        }

        void UpdateGridViewForVaccine()
        {
            VaccineDataAccess vaccineDataAccess = new VaccineDataAccess();
            vaccineLoadDataGridView.DataSource = vaccineDataAccess.GetVaccineNames();
        }

        private void loadFirstSecondDoseButton_Click_1(object sender, EventArgs e)
        {
            FristDosePending fristDosePending = new FristDosePending();
            fristDosePending.Show();
            this.Hide();
        }

        private void searchByVaccineTextBox_TextChanged(object sender, EventArgs e)
        {
            RegisteredUserDataAccess registeredUserDataAccess = new RegisteredUserDataAccess();
            searchByVaccineDataGridView.DataSource = registeredUserDataAccess.GetUserNyVaccineByName(searchByVaccineTextBox.Text);
        }
    }
}
