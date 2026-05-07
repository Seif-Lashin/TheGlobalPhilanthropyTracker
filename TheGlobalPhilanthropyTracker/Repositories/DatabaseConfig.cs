using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    public static class DatabaseConfig
    {
        private static string _connectionString = "Server=.;Database=TheGlobalPhilanthropyTracker;Trusted_Connection=True;TrustServerCertificate=True;";
        public static string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
