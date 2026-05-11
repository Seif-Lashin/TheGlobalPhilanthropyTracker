using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using TheGlobalPhilanthropyTracker.Models;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    public class SectorRepository
    {
        public List<Sectors> GetSectors()
        {
            var sectors = new List<Sectors>();
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Sectors";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var sector = new Sectors();
                                sector.sectorId = Convert.ToInt32(reader["sectorId"]);
                                sector.name = reader["name"].ToString();
                                sector.description = reader["description"] == DBNull.Value ? null : reader["description"].ToString();
                                sectors.Add(sector);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return sectors;
        }

        public Sectors? GetSector(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Sectors WHERE sectorId = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var sector = new Sectors();
                                sector.sectorId = Convert.ToInt32(reader["sectorId"]);
                                sector.name = reader["name"].ToString();
                                sector.description = reader["description"] == DBNull.Value ? null : reader["description"].ToString();
                                return sector;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            return null;
        }

        public void AddSector(Sectors sector)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "INSERT INTO sectors (name, description) VALUES (@name, @description)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", sector.name);
                        cmd.Parameters.AddWithValue("@description", (object)sector.description ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public void DeleteSector(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "DELETE FROM sectors WHERE sectorId = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public void UpdateSector(Sectors sector)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "UPDATE sectors SET name = @name, description = @description WHERE sectorId = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", sector.name);
                        cmd.Parameters.AddWithValue("@description", (object)sector.description ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", sector.sectorId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
