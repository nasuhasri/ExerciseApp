using System;
using System.Data.SqlClient;

namespace ExerciseApp
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly int _timeout = 60;

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string given is null or empty");
            }

            _connectionString = connectionString;

            var builder = new SqlConnectionStringBuilder(_connectionString);
            Console.WriteLine("Original: " + builder.ConnectionString);
            Console.WriteLine("ConnectTimeout={0}", builder.ConnectTimeout);
            builder.ConnectTimeout = _timeout;
            Console.WriteLine("Modified: " + builder.ConnectionString);
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
