using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserRepository
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DemoMVCAppConnection"].ToString();

        public UserRepository()
        {
         
        }

        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Users (Username, Email, Password, Age)
                             VALUES (@Username, @Email, @Password, @Age)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Age", user.Age);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Username = reader["Username"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Age = Convert.ToInt32(reader["Age"])
                    });
                }
            }

            return users;
        }

    }
}