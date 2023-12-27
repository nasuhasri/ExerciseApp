using System;

namespace ExerciseApp
{
    public class EmailWorkflow : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Run send email workflow...");
        }
    }
}
