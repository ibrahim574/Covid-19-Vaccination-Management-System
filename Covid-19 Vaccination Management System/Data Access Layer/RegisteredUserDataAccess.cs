using Covid_19_Vaccination_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_Vaccination_Management_System.Data_Access_Layer
{
    class RegisteredUserDataAccess:DataAccess
    {
        public List<RegisteredUser> GetRegisteredUser()
        {
            string sql = "SELECT * FROM RegisteredUsers";
            SqlDataReader reader = this.GetData(sql);
            List<RegisteredUser> registeredUsers = new List<RegisteredUser>();
            while (reader.Read())
            {
                RegisteredUser registeredUser = new RegisteredUser();
                registeredUser.PatientId = (int)reader["PatientId"];
                registeredUser.PatientName = reader["PatientName"].ToString();
                registeredUser.PatientNid = (int)reader["PatientNid"];
                registeredUser.Email = reader["Email"].ToString();
                registeredUser.Age = (int)reader["Age"];            
                registeredUser.Gender = reader["Gender"].ToString();
                registeredUser.BloodGroup = reader["BloodGroup"].ToString();
                registeredUser.FirstDose = reader["FirstDose"].ToString();
                registeredUser.SecondDose = reader["SecondDose"].ToString();
                registeredUser.VaccineName = reader["VaccineName"].ToString();
                registeredUsers.Add(registeredUser);
            }
            return registeredUsers;
        }


        public List<RegisteredUser> GetVaccinationCompletedUser()
        {
            string sql = "SELECT * FROM RegisteredUsers WHERE FirstDose != 'Pending' AND SecondDose != 'Pending'";
            SqlDataReader reader = this.GetData(sql);
            List<RegisteredUser> registeredUsers = new List<RegisteredUser>();
            while (reader.Read())
            {
                RegisteredUser registeredUser = new RegisteredUser();
                registeredUser.PatientId = (int)reader["PatientId"];
                registeredUser.PatientName = reader["PatientName"].ToString();
                registeredUser.PatientNid = (int)reader["PatientNid"];
                registeredUser.Email = reader["Email"].ToString();
                registeredUser.Age = (int)reader["Age"];
                registeredUser.Gender = reader["Gender"].ToString();
                registeredUser.BloodGroup = reader["BloodGroup"].ToString();
                registeredUser.FirstDose = reader["FirstDose"].ToString();
                registeredUser.SecondDose = reader["SecondDose"].ToString();
                registeredUser.VaccineName = reader["VaccineName"].ToString();
                registeredUsers.Add(registeredUser);
            }
            return registeredUsers;
        }


        public List<RegisteredUser> GetFirstDoseCompletedUser()
        {
            string sql = "SELECT * FROM RegisteredUsers WHERE FirstDose != 'Pending' AND SecondDose = 'Pending'";
            SqlDataReader reader = this.GetData(sql);
            List<RegisteredUser> registeredUsers = new List<RegisteredUser>();
            while (reader.Read())
            {
                RegisteredUser registeredUser = new RegisteredUser();
                registeredUser.PatientId = (int)reader["PatientId"];
                registeredUser.PatientName = reader["PatientName"].ToString();
                registeredUser.PatientNid = (int)reader["PatientNid"];
                registeredUser.Email = reader["Email"].ToString();
                registeredUser.Age = (int)reader["Age"];
                registeredUser.Gender = reader["Gender"].ToString();
                registeredUser.BloodGroup = reader["BloodGroup"].ToString();
                registeredUser.FirstDose = reader["FirstDose"].ToString();
                registeredUser.SecondDose = reader["SecondDose"].ToString();
                registeredUser.VaccineName = reader["VaccineName"].ToString();
                registeredUsers.Add(registeredUser);
            }
            return registeredUsers;
        }


        public List<RegisteredUser> GetFirstDosePendingUser()
        {
            string sql = "SELECT * FROM RegisteredUsers WHERE FirstDose = 'Pending' AND SecondDose = 'Pending'";
            SqlDataReader reader = this.GetData(sql);
            List<RegisteredUser> registeredUsers = new List<RegisteredUser>();
            while (reader.Read())
            {
                RegisteredUser registeredUser = new RegisteredUser();
                registeredUser.PatientId = (int)reader["PatientId"];
                registeredUser.PatientName = reader["PatientName"].ToString();
                registeredUser.PatientNid = (int)reader["PatientNid"];
                registeredUser.Email = reader["Email"].ToString();
                registeredUser.Age = (int)reader["Age"];
                registeredUser.Gender = reader["Gender"].ToString();
                registeredUser.BloodGroup = reader["BloodGroup"].ToString();
                registeredUser.FirstDose = reader["FirstDose"].ToString();
                registeredUser.SecondDose = reader["SecondDose"].ToString();
                registeredUser.VaccineName = reader["VaccineName"].ToString();
                registeredUsers.Add(registeredUser);
            }
            return registeredUsers;
        }




        public List<RegisteredUser> GetUserNyVaccineByName(string str)
        {
            string sql = "SELECT * FROM RegisteredUsers WHERE VaccineName LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<RegisteredUser> registeredUsers = new List<RegisteredUser>();
            while (reader.Read())
            {
                RegisteredUser registeredUser = new RegisteredUser();
                registeredUser.PatientId = (int)reader["PatientId"];
                registeredUser.PatientName = reader["PatientName"].ToString();
                registeredUser.PatientNid = (int)reader["PatientNid"];
                registeredUser.Email = reader["Email"].ToString();
                registeredUser.Age = (int)reader["Age"];
                registeredUser.Gender = reader["Gender"].ToString();
                registeredUser.BloodGroup = reader["BloodGroup"].ToString();
                registeredUser.FirstDose = reader["FirstDose"].ToString();
                registeredUser.SecondDose = reader["SecondDose"].ToString();
                registeredUser.VaccineName = reader["VaccineName"].ToString();
                registeredUsers.Add(registeredUser);
            }
            return registeredUsers;
        }



    }
}
