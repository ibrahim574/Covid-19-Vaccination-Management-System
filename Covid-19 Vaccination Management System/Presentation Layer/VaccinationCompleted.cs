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
    public partial class VaccinationCompleted : Form
    {
        public VaccinationCompleted()
        {
            InitializeComponent();
        }

        private void VaccinationCompleted_Load(object sender, EventArgs e)
        {
            RegisteredUserDataAccess registeredUserDataAccess = new RegisteredUserDataAccess();
            vaccineCompletedUserDataGridView.DataSource = registeredUserDataAccess.GetVaccinationCompletedUser();
        }

        private void vaccinationCompletedbackButton_Click(object sender, EventArgs e)
        {
            RegisteredUser registeredUser = new RegisteredUser();
            registeredUser.Show();
            this.Hide();
        }

        private void VaccinationCompleted_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
