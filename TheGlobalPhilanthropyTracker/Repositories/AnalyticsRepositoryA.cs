using System.Data;
using Microsoft.Data.SqlClient;
namespace TheGlobalPhilanthropyTracker.Repositories
{
    public class AnalyticsRepositoryA
    {
        private readonly string _connectionString = DatabaseConfig.GetConnectionString();

        public DataTable GetTopSector()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT TOP 3 S.name AS [Name of sector], COUNT(I.INITIATIVEID) AS [Number of initiatives]
                    FROM Sectors S
                    Left JOIN INITIATIVES I ON S.SECTORID = I.SECTORID
                    Left JOIN CONTRIBUTIONS C ON I.INITIATIVEID = C.INITIATIVEID
                    GROUP BY S.name
                    ORDER BY [Number of initiatives] DESC";
                DataTable resultTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(resultTable);
                return resultTable;
            }
        }

        public DataTable GetInactiveInitiatives()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT I.INITIATIVEID AS [ID of initiative],
                    I.Title,
                    I.FUNDING_TARGET ,
                    I.Start_Date,
                    I.End_Date
                    
                    FROM INITIATIVES I
                    LEFT JOIN CONTRIBUTIONS C ON I.INITIATIVEID = C.INITIATIVEID
                    Where C.UNIQUE_REFERENCE IS NULL
                    ";

                DataTable resultTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(resultTable);
                return resultTable;
            }
        }
        public DataTable GetTopContributors()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT TOP 3 S.FIRSTNAME + ' ' + S.LASTNAME AS [Full Name], Sum(C.AMOUNT) AS [Total Donate]
                    FROM SUPPORTERS S
                    LEFT JOIN CONTRIBUTIONS C ON S.SUPPORTERID = C.SUPPORTERID
                    GROUP BY S.FIRSTNAME,S.LASTNAME
                    ORDER BY [Total Donate] DESC";
                DataTable resultTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(resultTable);
                return resultTable;
            }
        }
    }
}


