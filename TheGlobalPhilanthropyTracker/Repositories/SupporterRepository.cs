using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TheGlobalPhilanthropyTracker.Models;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    public class SupporterRepository
    {
        private readonly string _connectionString = DatabaseConfig.GetConnectionString();

        public List<Supporters> GetAllSupporters()
        {
            var supporters = new List<Supporters>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT SUPPORTERID, FIRSTNAME, LASTNAME, EMAIL FROM SUPPORTERS";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            supporters.Add(new Supporters
                            {
                                SupporterId = Convert.ToInt32(reader["SUPPORTERID"]),
                                FirstName = reader["FIRSTNAME"].ToString(),
                                LastName = reader["LASTNAME"].ToString(),
                                Email = reader["EMAIL"].ToString()
                            });
                        }
                    }
                }
            }
            return supporters;
        }

        public Supporters? GetSupporter(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT SUPPORTERID, FIRSTNAME, LASTNAME, EMAIL FROM SUPPORTERS WHERE SUPPORTERID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Supporters
                            {
                                SupporterId = Convert.ToInt32(reader["SUPPORTERID"]),
                                FirstName = reader["FIRSTNAME"].ToString(),
                                LastName = reader["LASTNAME"].ToString(),
                                Email = reader["EMAIL"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void RegisterSupporter(Supporters s)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO SUPPORTERS (FIRSTNAME, LASTNAME, EMAIL) VALUES (@FirstName, @LastName, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", s.LastName);
                    cmd.Parameters.AddWithValue("@Email", s.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddContribution(int supporterId, int initiativeId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO CONTRIBUTIONS (SUPPORTERID, INITIATIVEID, AMOUNT, [TIMESTAMP]) VALUES (@SupporterId, @InitiativeId, @Amount, @Timestamp)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupporterId", supporterId);
                    cmd.Parameters.AddWithValue("@InitiativeId", initiativeId);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSupporterEmail(int id, string newEmail)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE SUPPORTERS SET EMAIL = @Email WHERE SUPPORTERID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSupporter(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM SUPPORTERS WHERE SUPPORTERID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}