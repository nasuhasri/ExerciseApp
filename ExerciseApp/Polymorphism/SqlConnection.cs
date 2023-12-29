using System;

namespace ExerciseApp
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
        
        public override void OpenConnection()
        {
            Console.WriteLine("Sql connection is opened");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Sql connection is closed");
        }
    }
}
