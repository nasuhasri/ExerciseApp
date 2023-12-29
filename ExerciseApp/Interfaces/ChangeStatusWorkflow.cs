using System;

namespace ExerciseApp
{
    public class ChangeStatusWorkflow : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Run change status workflow...");
        }
    }
}
