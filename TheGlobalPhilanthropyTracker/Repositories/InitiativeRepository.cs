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

                    string sql = "SELECT * FROM initiatives ORDER BY initiativeID";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Initiatives initiative = new Initiatives();
                                initiative.initiativeId = Convert.ToInt32(reader["initiativeID"]);
                                initiative.sectorId = Convert.ToInt32(reader["sectorID"]);
                                initiative.title = reader["title"].ToString();
                                initiative.primaryObjective = reader["primary_Objective"] == DBNull.Value ? null : reader["primary_Objective"].ToString();
                                initiative.fundingTarget = reader["funding_Target"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["funding_Target"]);
                                initiative.startDate = reader["start_Date"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["start_Date"]);
                                initiative.endDate = reader["end_Date"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["end_Date"]);
                                initiative.impactSummaries = reader["impact_Summaries"] == DBNull.Value ? null : reader["impact_Summaries"].ToString();

                                initiatives.Add(initiative);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
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

                    string sql = "SELECT * FROM initiatives WHERE initiativeID = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Initiatives initiative = new Initiatives();
                                initiative.initiativeId = Convert.ToInt32(reader["initiativeID"]);
                                initiative.sectorId = Convert.ToInt32(reader["sectorID"]);
                                initiative.title = reader["title"].ToString();
                                initiative.primaryObjective = reader["primary_Objective"] == DBNull.Value ? null : reader["primary_Objective"].ToString();
                                initiative.fundingTarget = reader["funding_Target"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["funding_Target"]);
                                initiative.startDate = reader["start_Date"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["start_Date"]);
                                initiative.endDate = reader["end_Date"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["end_Date"]);
                                initiative.impactSummaries = reader["impact_Summaries"] == DBNull.Value ? null : reader["impact_Summaries"].ToString();

                                return initiative;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
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

                    string sql = "INSERT INTO initiatives" +
                        "(sectorID, title, primary_Objective, funding_Target, start_Date, end_Date, impact_Summaries)" +
                        "VALUES (@sectorId, @title, @primaryObjective, @fundingTarget, @startDate, @endDate, @impactSummaries)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@sectorId", initiative.sectorId);
                        cmd.Parameters.AddWithValue("@title", initiative.title);
                        cmd.Parameters.AddWithValue("@primaryObjective", initiative.primaryObjective);
                        cmd.Parameters.AddWithValue("@fundingTarget", initiative.fundingTarget);
                        cmd.Parameters.AddWithValue("@startDate", initiative.startDate);
                        cmd.Parameters.AddWithValue("@endDate", initiative.endDate);
                        cmd.Parameters.AddWithValue("@impactSummaries", initiative.impactSummaries);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void UpdateInitiative(Initiatives initiatives)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();

                    string sql = "UPDATE initiatives " +
                                "SET sectorID = @sectorId, title = @title, primary_Objective = @primaryObjective, funding_Target = @fundingTarget, start_Date = @startDate, end_Date = @endDate, impact_Summaries = @impactSummaries " +
                                "WHERE initiativeID = @initiativeId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@initiativeId", initiatives.initiativeId);
                        cmd.Parameters.AddWithValue("@sectorId", initiatives.sectorId);
                        cmd.Parameters.AddWithValue("@title", initiatives.title);
                        cmd.Parameters.AddWithValue("@primaryObjective", initiatives.primaryObjective);
                        cmd.Parameters.AddWithValue("@fundingTarget", initiatives.fundingTarget);
                        cmd.Parameters.AddWithValue("@startDate", initiatives.startDate);
                        cmd.Parameters.AddWithValue("@endDate", initiatives.endDate);
                        cmd.Parameters.AddWithValue("@impactSummaries", initiatives.impactSummaries);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void DeleteInitiative(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "DELETE FROM initiatives WHERE initiativeID = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

    }
}

    
