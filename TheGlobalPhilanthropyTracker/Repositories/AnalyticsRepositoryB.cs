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

        // Initiatives (total donations > total expenditures)
        public DataTable GetUnspentInitiatives()
        {
            string sql = @"
                SELECT i.INITIATIVEID, i.TITLE, ISNULL(SUM(c.AMOUNT), 0) AS TotalDonations, ISNULL(SUM(e.AMOUNT_SPENT), 0) AS TotalExpenditures
                FROM INITIATIVES i
                LEFT JOIN CONTRIBUTIONS c ON i.INITIATIVEID = c.INITIATIVEID
                LEFT JOIN EXPENDITURES e ON i.INITIATIVEID = e.INITIATIVEID
                GROUP BY i.INITIATIVEID, i.TITLE
                HAVING ISNULL(SUM(c.AMOUNT), 0) > ISNULL(SUM(e.AMOUNT_SPENT), 0)";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn); // command object with the SQL query and connection
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // data adapter to execute the command and fill the DataTable
                adapter.Fill(dt);
            }
            return dt;
        }

        // Initiatives with contributions or expenditures in the last 30 days
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
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Supporter Profiles : total donated by each supporter
        public DataTable GetDetailedSupporterProfiles()
        {
            string sql = @"
                SELECT s.SUPPORTERID, s.FIRSTNAME, s.LASTNAME, s.EMAIL, ISNULL(SUM(c.AMOUNT), 0) AS TotalDonated
                FROM SUPPORTERS s
                LEFT JOIN CONTRIBUTIONS c ON s.SUPPORTERID = c.SUPPORTERID
                GROUP BY s.SUPPORTERID, s.FIRSTNAME, s.LASTNAME, s.EMAIL
                ORDER BY TotalDonated DESC";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
