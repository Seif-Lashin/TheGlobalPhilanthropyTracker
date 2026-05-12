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
                    SELECT TOP 3 S.SECTORID AS [Sector ID], S.name AS [Name of sector], COUNT(C.UNIQUE_REFERENCE) AS [Number of Contribution]
                    FROM Sectors S
                    Left JOIN INITIATIVES I ON S.SECTORID = I.SECTORID
                    Left JOIN CONTRIBUTIONS C ON I.INITIATIVEID = C.INITIATIVEID
                    GROUP BY S.SECTORID, S.name
                    ORDER BY [Number of Contribution] DESC";
                DataTable resultTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(resultTable);
                }
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
                    AND MONTH(C.timestamp) = MONTH(DATEADD(MONTH,-1,GETDATE()))
                    AND YEAR(C.timestamp) = YEAR(DATEADD(MONTH,-1,GETDATE()))
                    Where C.UNIQUE_REFERENCE IS NULL
                    ";

                DataTable resultTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(resultTable);
                }
                return resultTable;
            }
        }
        public DataTable GetTopContributors()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT TOP 3 S.SUPPORTERID AS [Supporter ID],S.FIRSTNAME + ' ' + S.LASTNAME AS [Full Name], Sum(C.AMOUNT) AS [Total Donated]
                    FROM SUPPORTERS S
                    INNER JOIN CONTRIBUTIONS C ON S.SUPPORTERID = C.SUPPORTERID
                    Where MONTH(C.timestamp) = MONTH(DATEADD(MONTH,-1,GETDATE()))
                    AND YEAR(C.timestamp) = YEAR(DATEADD(MONTH,-1,GETDATE()))
                    GROUP BY S.SUPPORTERID, S.FIRSTNAME,S.LASTNAME
                    ORDER BY [Total Donated] DESC";
                DataTable resultTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(resultTable);
                }
                return resultTable;
            }
        }
    }
}


