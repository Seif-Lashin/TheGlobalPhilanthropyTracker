using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using TheGlobalPhilanthropyTracker.Models;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    public class InitiativeRepository
    {
        public List<Initiatives> GetInitiatives()
        {
            var initiatives = new List<Initiatives>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM INITIATIVES ORDER BY INITIATIVEID";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Initiatives initiative = new Initiatives();
                                initiative.initiativeId = Convert.ToInt32(reader["INITIATIVEID"]);
                                initiative.sectorId = Convert.ToInt32(reader["SECTORID"]);
                                initiative.title = reader["TITLE"].ToString();
                                initiative.primaryObjective = reader["PRIMARY_OBJECTIVE"] == DBNull.Value ? null : reader["PRIMARY_OBJECTIVE"].ToString();
                                initiative.fundingTarget = reader["FUNDING_TARGET"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["FUNDING_TARGET"]);
                                initiative.startDate = reader["START_DATE"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["START_DATE"]);
                                initiative.endDate = reader["END_DATE"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["END_DATE"]);
                                initiative.impactSummaries = reader["IMPACT_SUMMARIES"] == DBNull.Value ? null : reader["IMPACT_SUMMARIES"].ToString();

                                initiatives.Add(initiative);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return initiatives;
        }

        public Initiatives? GetInitiative(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT * FROM INITIATIVES WHERE INITIATIVEID = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Initiatives initiative = new Initiatives();
                                initiative.initiativeId = Convert.ToInt32(reader["INITIATIVEID"]);
                                initiative.sectorId = Convert.ToInt32(reader["SECTORID"]);
                                initiative.title = reader["TITLE"].ToString();
                                initiative.primaryObjective = reader["PRIMARY_OBJECTIVE"] == DBNull.Value ? null : reader["PRIMARY_OBJECTIVE"].ToString();
                                initiative.fundingTarget = reader["FUNDING_TARGET"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["FUNDING_TARGET"]);
                                initiative.startDate = reader["START_DATE"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["START_DATE"]);
                                initiative.endDate = reader["END_DATE"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["END_DATE"]);
                                initiative.impactSummaries = reader["IMPACT_SUMMARIES"] == DBNull.Value ? null : reader["IMPACT_SUMMARIES"].ToString();

                                return initiative;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public void CreateInitiative(Initiatives initiative)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();

                    string sql = "INSERT INTO INITIATIVES" +
                        "(SECTORID, TITLE, PRIMARY_OBJECTIVE, FUNDING_TARGET, START_DATE, END_DATE, IMPACT_SUMMARIES)" +
                        "VALUES (@sectorId, @title, @primaryObjective, @fundingTarget, @startDate, @endDate, @impactSummaries)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@sectorId", initiative.sectorId);
                        cmd.Parameters.AddWithValue("@title", initiative.title);
                        cmd.Parameters.AddWithValue("@primaryObjective", (object)initiative.primaryObjective ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@fundingTarget", (object)initiative.fundingTarget ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@startDate", (object)initiative.startDate ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@endDate", (object)initiative.endDate ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@impactSummaries", (object)initiative.impactSummaries ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateInitiative(Initiatives initiatives)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();

                    string sql = "UPDATE INITIATIVES " +
                                "SET SECTORID = @sectorId, TITLE = @title, PRIMARY_OBJECTIVE = @primaryObjective, FUNDING_TARGET = @fundingTarget, START_DATE = @startDate, END_DATE = @endDate, IMPACT_SUMMARIES = @impactSummaries " +
                                "WHERE INITIATIVEID = @initiativeId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@initiativeId", initiatives.initiativeId);
                        cmd.Parameters.AddWithValue("@sectorId", initiatives.sectorId);
                        cmd.Parameters.AddWithValue("@title", initiatives.title);
                        cmd.Parameters.AddWithValue("@primaryObjective", (object)initiatives.primaryObjective ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@fundingTarget", (object)initiatives.fundingTarget ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@startDate", (object)initiatives.startDate ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@endDate", (object)initiatives.endDate ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@impactSummaries", (object)initiatives.impactSummaries ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteInitiative(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "DELETE FROM INITIATIVES WHERE INITIATIVEID = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

    
