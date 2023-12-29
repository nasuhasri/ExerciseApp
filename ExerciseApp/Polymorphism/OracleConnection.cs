using System;

namespace ExerciseApp
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle connection is opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection is closed");
        }
    }
}
