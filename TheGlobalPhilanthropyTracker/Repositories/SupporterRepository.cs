using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using TheGlobalPhilanthropyTracker.Models;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    public class SupporterRepository
    {
        private readonly string _connectionString = DatabaseConfig.GetConnectionString();

        public DataTable GetAllSupporters()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT SupporterId, FirstName, LastName, Email FROM Supporters";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public void RegisterSupporter(Supporters s)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Supporters (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
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
                string query = "INSERT INTO CONTRIBUTIONS (SUPPORTERID, INITIATIVEID, AMOUNT, TIMESTAMP) VALUES (@SupporterId, @InitiativeId, @Amount, @Timestamp)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupporterId", supporterId);
                    cmd.Parameters.AddWithValue("@InitiativeId", initiativeId);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSupporterEmail(int id, string newEmail)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Supporters SET Email = @Email WHERE SupporterId = @Id";
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
