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
    public partial class ManageVaccine : Form
    {
        public ManageVaccine()
        {
            InitializeComponent();
        }

        private void ManageVaccine_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ManageVaccine_Load(object sender, EventArgs e)
        {
            
        }

        void ClearFields()
        {
            deleteVaccineIdTextBox.Text = string.Empty;          
            addVaccineNameTextBox.Text = string.Empty;
            addVaccineQuantityNumericUpDown.Text = string.Empty;
            addVaccineCountryNameTextBox.Text = string.Empty;
            updateVaccineIdTextBox.Text = string.Empty;
            updateVaccineNameTextBox.Text = string.Empty;
            updateVaccineQuantityNumericUpDown.Text = string.Empty;
            updateCountryNameTextBox.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        void UpdateGridView()
        {
            VaccineDataAccess vaccineDataAccess = new VaccineDataAccess();
            vaccineDataGridView.DataSource = vaccineDataAccess.GetVaccine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (deleteVaccineIdTextBox.Text == "")
            {
                MessageBox.Show("Please give a vaccine Id !");
            }

            else if (deleteVaccineIdTextBox.Text.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Vaccine ID cannot contin character");
            }

            else
            {
                VaccineDataAccess vaccineDataAccess = new VaccineDataAccess();
                Vaccine vaccine = vaccineDataAccess.GetVaccineById(Convert.ToInt32(deleteVaccineIdTextBox.Text));
                if (vaccine == null)
                {
                    MessageBox.Show("Invalid Vaccine ID");
                }

                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        vaccineDataAccess = new VaccineDataAccess();
                        if (vaccineDataAccess.DeleteVaccine(Convert.ToInt32(deleteVaccineIdTextBox.Text)))
                        {
                            MessageBox.Show("Vaccine deleted");
                            UpdateGridView();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Error in deleting");
                        }
                    }
                }             
            }
        }
  

        private void addVaccineButton_Click_1(object sender, EventArgs e)
        {

            if (addVaccineNameTextBox.Text == "")
            {
                MessageBox.Show("Vaccine Name can not be empty");
            }

            else if (addVaccineQuantityNumericUpDown.Text == "0")
            {
                MessageBox.Show("Vaccine Quantity can not be empty");
            }

            else if (addVaccineCountryNameTextBox.Text == "")
            {
                MessageBox.Show("Country Name can not be empty");
            }
            else if (addVaccineCountryNameTextBox.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Country Name cannot contin any numerical value");
            }

            else
            {
                VaccineDataAccess vaccineDataAccess = new VaccineDataAccess();
                if (vaccineDataAccess.AddVaccine(addVaccineNameTextBox.Text, Convert.ToInt32(addVaccineQuantityNumericUpDown.Text), addVaccineCountryNameTextBox.Text))
                {
                    MessageBox.Show("New Vaccine Added");
                    UpdateGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error in Adding");
                }
            }

            
        }

        private void updateVaccineButton_Click(object sender, EventArgs e)
        {

            if (updateVaccineIdTextBox.Text == "")
            {
                MessageBox.Show("Vaccine ID can not be empty");
            }
            else if (updateVaccineIdTextBox.Text.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Vaccine ID cannot contin character");
            }
            else if (updateVaccineNameTextBox.Text == "")
            {
                MessageBox.Show("Vaccine Name can not be empty");
            }

            else if (updateVaccineQuantityNumericUpDown.Text == "0")
            {
                MessageBox.Show("Vaccine Quantity can not be empty");
            }

            else if (updateCountryNameTextBox.Text == "")
            {
                MessageBox.Show("Country Nam can not be empty");
            }
            else if (updateCountryNameTextBox.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Country Name cannot contin any numerical value");
            }
            else
            {
                VaccineDataAccess vaccineDataAccess = new VaccineDataAccess();
                if (vaccineDataAccess.UpdateVaccine(Convert.ToInt32(updateVaccineIdTextBox.Text), updateVaccineNameTextBox.Text, Convert.ToInt32(updateVaccineQuantityNumericUpDown.Text), updateCountryNameTextBox.Text))
                {
                    MessageBox.Show("Vaccine updated");
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

        private void searchVaccineTextBox_TextChanged(object sender, EventArgs e)
        {
            VaccineDataAccess vaccineDataAccess = new VaccineDataAccess();
            searchVaccineDataGridView.DataSource = vaccineDataAccess.GetVaccineByName(searchVaccineTextBox.Text);
        }

        private void VaccineManagementBackButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void addVaccineIdTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
