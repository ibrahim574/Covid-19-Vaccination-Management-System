using Covid_19_Vaccination_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_Vaccination_Management_System.Data_Access_Layer
{
    class VaccineDataAccess:DataAccess
    {
        public List<Vaccine> GetVaccine()
        {
            string sql = "SELECT * FROM Vaccines";
            SqlDataReader reader = this.GetData(sql);
            List<Vaccine> vaccines = new List<Vaccine>();
            while (reader.Read())
            {
                Vaccine vaccine = new Vaccine();
                vaccine.VaccineId = (int)reader["VaccineId"];
                vaccine.VaccineName = reader["VaccineName"].ToString();
                vaccine.Quantity = (int)reader["Quantity"];
                vaccine.CountyrName = reader["CountryName"].ToString();
                vaccines.Add(vaccine);
            }
            return vaccines;
        }


        public Vaccine GetVaccineById(int vaccineId)
        {
            string sql = "SELECT * FROM Vaccines WHERE VaccineId=" + vaccineId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Vaccine vaccine = new Vaccine();
                vaccine.VaccineId = (int)reader["VaccineId"];
                vaccine.VaccineName = reader["VaccineName"].ToString();
                vaccine.Quantity = (int)reader["Quantity"];
                vaccine.CountyrName = reader["CountryName"].ToString();
                return vaccine;
            }
            else
            {
                return null;
            }
        }




        public bool AddVaccine(string vaccineName, int quantity, string countryName)
        {
            string sql = "INSERT INTO Vaccines(VaccineName, Quantity, CountryName) VALUES('"+ vaccineName + "',"+ quantity + ",'"+ countryName + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





        public bool UpdateVaccine(int vaccineId, string vaccineName, int quantity, string countryName)
        {
            string sql = "UPDATE Vaccines SET  VaccineName='" + vaccineName + "', Quantity=" + quantity + ", CountryName='" + countryName + "' WHERE VaccineId=" + vaccineId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





        public bool DeleteVaccine(int vaccineId)
        {
            string sql = "DELETE FROM Vaccines WHERE VaccineId =" + vaccineId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }






        public List<Vaccine> GetVaccineByName(string str)
        {
            string sql = "SELECT * FROM Vaccines WHERE VaccineName LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Vaccine> vaccines = new List<Vaccine>();
            while (reader.Read())
            {
                Vaccine vaccine = new Vaccine();
                vaccine.VaccineId = (int)reader["VaccineId"];
                vaccine.VaccineName = reader["VaccineName"].ToString();
                vaccine.Quantity = (int)(reader["Quantity"]);
                vaccine.CountyrName = reader["CountryName"].ToString();
                vaccines.Add(vaccine);
            }
            return vaccines;
        }



        public List<VaccineName> GetVaccineNames()
        {
            string sql = "SELECT VaccineName FROM Vaccines";
            SqlDataReader reader = this.GetData(sql);
            List<VaccineName> vaccines = new List<VaccineName>();
            while (reader.Read())
            {
                VaccineName vaccineName = new VaccineName();
                vaccineName.VaccineNames = reader["VaccineName"].ToString();
                vaccines.Add(vaccineName);
            }
            return vaccines;
        }

    }
}
