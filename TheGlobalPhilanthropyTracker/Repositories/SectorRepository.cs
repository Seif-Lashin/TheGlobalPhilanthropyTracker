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
                    string sql = "SELECT * FROM SECTORS";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var sector = new Sectors();
                                sector.sectorId = Convert.ToInt32(reader["SECTORID"]);
                                sector.name = reader["NAME"].ToString();
                                sector.description = reader["DESCRIPTION"] == DBNull.Value ? null : reader["DESCRIPTION"].ToString();
                                sectors.Add(sector);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sql = "SELECT * FROM SECTORS WHERE SECTORID = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var sector = new Sectors();
                                sector.sectorId = Convert.ToInt32(reader["SECTORID"]);
                                sector.name = reader["NAME"].ToString();
                                sector.description = reader["DESCRIPTION"] == DBNull.Value ? null : reader["DESCRIPTION"].ToString();
                                return sector;
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

        public void AddSector(Sectors sector)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "INSERT INTO SECTORS (NAME, DESCRIPTION) VALUES (@name, @description)";
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
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteSector(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "DELETE FROM SECTORS WHERE SECTORID = @id";
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

        public void UpdateSector(Sectors sector)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    conn.Open();
                    string sql = "UPDATE SECTORS SET NAME = @name, DESCRIPTION = @description WHERE SECTORID = @id";
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
                MessageBox.Show($"Database error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
