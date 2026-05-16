using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlobalPhilanthropyTracker.Repositories
{
    public static class DatabaseConfig
    {
        private static string _connectionString = "Data Source=.;Initial Catalog=TheGlobalPhilanthropyTracker;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
