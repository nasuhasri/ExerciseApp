using System;

namespace ExerciseApp
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            Console.WriteLine("Start");
            _startTime = DateTime.Now;
            _isRunning = true;

            Console.WriteLine(_startTime);
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running!");
            }

            Console.WriteLine("Stop");
            _endTime = DateTime.Now;
            _isRunning = false;

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
