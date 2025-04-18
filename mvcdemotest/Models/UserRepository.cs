using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace mvcdemotest.Models
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        string connStr = "Data Source=LAPTOP-A0G3LSSC;Initial Catalog=EmployeePortal;Integrated Security=True;";
        private static string cName = "Data Source=LAPTOP-A0G3LSSC; Initial Catalog=EmployeePortal;User ID=sa;Password=1234";
        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(cName))
            {
                string sql = "INSERT INTO Users (Username, Email, Password, Age) VALUES (@Username, @Email, @Password, @Age)";
               

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password); // Consider hashing in real apps
                    cmd.Parameters.AddWithValue("@Age", user.Age);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Connected to DB: " + conn.Database);
                }
            }
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            string connStr = "Data Source=LAPTOP-A0G3LSSC;Initial Catalog=EmployeePortal;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT Username, Email, Password, Age FROM Users";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                Username = reader["Username"].ToString(),
                                Email = reader["Email"].ToString(),
                                Password = reader["Password"].ToString(),
                                Age = Convert.ToInt32(reader["Age"])
                            };

                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

    }
}