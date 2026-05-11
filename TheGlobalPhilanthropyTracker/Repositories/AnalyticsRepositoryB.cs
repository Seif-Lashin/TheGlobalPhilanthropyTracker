using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using Microsoft.Data.SqlClient;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    internal class AnalyticsRepositoryB
    {
        private readonly string _connectionString = DatabaseConfig.GetConnectionString();

        public DataTable GetUnspentInitiatives()
        {
            string sql = @"
                SELECT i.INITIATIVEID, i.TITLE
                FROM INITIATIVES i
                WHERE i.INITIATIVEID NOT IN (SELECT DISTINCT INITIATIVEID FROM EXPENDITURES)";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn); // command object with the SQL query and connection
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // data adapter to execute the command and fill the DataTable
                    adapter.Fill(dt);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return dt;
        }

        public DataTable GetRecentActivity()
        {
            string sql = @"
                SELECT DISTINCT i.INITIATIVEID, i.TITLE
                FROM INITIATIVES i
                WHERE i.INITIATIVEID IN (
                    SELECT INITIATIVEID FROM CONTRIBUTIONS 
                    WHERE TIMESTAMP > GETDATE() - 30
                )
                OR i.INITIATIVEID IN (
                    SELECT INITIATIVEID FROM EXPENDITURES 
                    WHERE DATE_SPENT > GETDATE() - 30
                )";

            DataTable dt = new DataTable();
            try
            {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
            }
            catch(Exception ex)
            {
                    Console.WriteLine("Exception: " + ex.ToString());
            }
            return dt;
        }

        public DataTable GetDetailedSupporterProfiles()
        {
            string sql = @"
                SELECT s.SUPPORTERID, s.FIRSTNAME, s.LASTNAME, s.EMAIL,
                COUNT(DISTINCT c.INITIATIVEID) AS UniqueInitiatives
                FROM SUPPORTERS s
                LEFT JOIN CONTRIBUTIONS c ON s.SUPPORTERID = c.SUPPORTERID
                GROUP BY s.SUPPORTERID, s.FIRSTNAME, s.LASTNAME, s.EMAIL
                ORDER BY UniqueInitiatives DESC";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return dt;
        }
    }
}
