using System;

namespace ExerciseApp
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (_dbConnection == null)
            {
                throw new InvalidOperationException("Db connection is null");
            }

            if (string.IsNullOrEmpty(instruction))
            {
                throw new InvalidOperationException("There's no instruction given");
            }

            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Run the database...");
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
        }
    }
}
