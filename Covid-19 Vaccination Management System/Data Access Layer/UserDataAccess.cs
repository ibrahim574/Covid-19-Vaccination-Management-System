using Covid_19_Vaccination_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_Vaccination_Management_System.Data_Access_Layer
{
    class UserDataAccess:DataAccess
    {

        public bool UserRegister(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup,UserType) VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.BloodGroup + "','"+user.UserType+"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                if (reader[8].ToString() == "Admin")
                {
                    UserDataAccess.type = "A";
                }

                else if (reader[8].ToString() == "User")
                {
                    UserDataAccess.type = "U";
                }

                return true;

            }
            else
            {
                return false;
            }
           
        }




        public List<User> GetUser()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.BloodGroup = reader["BloodGroup"].ToString();
                user.UserType = reader["UserType"].ToString();
                users.Add(user);
            }
            return users;
        }




        public bool UpdateUser(int userId, string name, string userName, string password, string email, string dateOfBirth, string gender, string bloodGroup)
        {
            string userType = "User";
            string sql = "UPDATE Users SET  Name='" + name + "', Username='" + userName + "', Password='" + password + "', Email = '"+ email + "', DateOfBirth='"+ dateOfBirth + "' , Gender='"+ gender + "', BloodGroup='"+ bloodGroup+ "', UserType='"+ userType + "' WHERE Id=" + userId;
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


        public bool DeleteUser(int userId)
        {
            string userType = "Admin";
            string sql = "DELETE FROM Users WHERE Id = "+userId+" AND UserType != '"+ userType + "'";
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




        public User GetUserById(int userId)
        {
            string sql = "SELECT * FROM Users WHERE Id=" + userId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                user.Email = reader["Email"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.BloodGroup = reader["BloodGroup"].ToString();
                user.UserType = reader["UserType"].ToString();
                return user;
            }
            else
            {
                return null;
            }
        }



        //public bool LoginValidation(string username, string password)
        //{
        //    string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
        //    SqlDataReader reader = this.GetData(sql);
        //    if (reader.HasRows)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}


    }
}
