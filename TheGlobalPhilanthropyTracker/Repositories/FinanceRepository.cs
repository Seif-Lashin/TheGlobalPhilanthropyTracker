using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TheGlobalPhilanthropyTracker.Models;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    internal class FinanceRepository
    {
        private readonly string _connectionString = DatabaseConfig.GetConnectionString();

        public void AddExpenditure(Expenditures e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO EXPENDITURES (INITIATIVEID, VENDORID, AMOUNT_SPENT, DATE_SPENT) " +
                                 "VALUES ( @initiativeId, @vendorId, @amountSpent, @dateSpent)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@initiativeId", e.initiativeId);
                        cmd.Parameters.AddWithValue("@vendorId", e.vendorId);
                        cmd.Parameters.AddWithValue("@amountSpent", e.amountSpent);
                        cmd.Parameters.AddWithValue("@dateSpent", e.dateSpent);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public decimal GetInitiativeProgress(int initiativeId)
        {
            decimal fundingTarget = 0;
            decimal amountRaised = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string targetSql = "SELECT FUNDING_TARGET " +
                                       "FROM INITIATIVES " +
                                       "WHERE INITIATIVEID = @initiativeId";

                    using (SqlCommand cmd = new SqlCommand(targetSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@initiativeId", initiativeId);

                        var result = cmd.ExecuteScalar();
                        fundingTarget = result == DBNull.Value ? 0 : Convert.ToDecimal(result);


                    }

                    string raisedSql = "SELECT SUM(AMOUNT) " +
                                      "FROM CONTRIBUTIONS " +
                                      "WHERE INITIATIVEID = @initiativeId";

                    using (SqlCommand cmd = new SqlCommand(raisedSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@initiativeId", initiativeId);

                        var result = cmd.ExecuteScalar();
                        amountRaised = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
                    }

                    if (fundingTarget == 0) return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Math.Round((amountRaised / fundingTarget) * 100, 2);
        }

        public DataTable GetSupporterContributions(int supporterId)
        {
            DataTable contributions = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "SELECT UNIQUE_REFERENCE, C.AMOUNT, C.TIMESTAMP, I.TITLE " +
                                 "FROM CONTRIBUTIONS C " +
                                 "INNER JOIN INITIATIVES I " +
                                 "ON C.INITIATIVEID = I.INITIATIVEID " +
                                 "WHERE C.SUPPORTERID = @supporterId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@supporterId", supporterId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(contributions);
                        return contributions;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return contributions;

        }
        public List<Vendors> GetVendors()
        {
            List<Vendors> vendors = new List<Vendors>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "SELECT VENDORID, COMPANY_NAME FROM VENDORS";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                vendors.Add(new Vendors
                                {
                                    vendorId = Convert.ToInt32(reader["VENDORID"]),
                                    companyName = reader["COMPANY_NAME"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vendors;
        }
    }
}