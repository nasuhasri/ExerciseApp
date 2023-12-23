using System;

namespace ExerciseApp
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public void Start()
        {
            Console.WriteLine("Start");
            startTime = DateTime.Now;

            Console.WriteLine(startTime);
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
            endTime = DateTime.Now;

            Console.WriteLine(endTime);
        }

        public void Duration()
        {
            TimeSpan timeSpan = endTime.Subtract(startTime);

            Console.WriteLine("Duration");
            Console.WriteLine(timeSpan);
        }
    }
}
