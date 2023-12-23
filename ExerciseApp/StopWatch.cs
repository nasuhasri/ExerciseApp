using System;

namespace ExerciseApp
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public void Start()
        {
            Console.WriteLine("Start");
            _startTime = DateTime.Now;

            Console.WriteLine(_startTime);
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
            _endTime = DateTime.Now;

            Console.WriteLine(_endTime);
        }

        public void Duration()
        {
            TimeSpan timeSpan = _endTime.Subtract(_startTime);

            Console.WriteLine("Duration");
            Console.WriteLine(timeSpan);
        }
    }
}
