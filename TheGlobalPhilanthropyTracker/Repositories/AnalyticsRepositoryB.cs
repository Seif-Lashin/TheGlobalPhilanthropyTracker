using Microsoft.Data.SqlClient;
using System.Data;

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
                WHERE NOT EXISTS 
                (
                    SELECT 1 FROM EXPENDITURES e WHERE e.INITIATIVEID = i.INITIATIVEID
                    AND MONTH(e.DATE_SPENT) = MONTH(DATEADD(MONTH, -1, GETDATE())) 
                    AND YEAR(e.DATE_SPENT) = YEAR(DATEADD(MONTH, -1, GETDATE()))
                )";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetRecentActivity()
        {
            string sql = @"
                SELECT DISTINCT i.INITIATIVEID, i.TITLE, sec.NAME AS [Sector]
                FROM INITIATIVES i
                LEFT JOIN SECTORS sec ON i.SECTORID = sec.SECTORID
                WHERE i.INITIATIVEID IN (
                    SELECT c.INITIATIVEID FROM CONTRIBUTIONS c
                    WHERE MONTH(c.TIMESTAMP) = MONTH(DATEADD(MONTH, -1, GETDATE())) AND YEAR(c.TIMESTAMP) = YEAR(DATEADD(MONTH, -1, GETDATE()))
                )
                OR i.INITIATIVEID IN (
                    SELECT e.INITIATIVEID FROM EXPENDITURES e
                    WHERE MONTH(e.DATE_SPENT) = MONTH(DATEADD(MONTH, -1, GETDATE())) AND YEAR(e.DATE_SPENT) = YEAR(DATEADD(MONTH, -1, GETDATE()))
                )";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
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
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
