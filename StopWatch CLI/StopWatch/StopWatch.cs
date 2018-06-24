using System;
namespace StopWatch
{
    public class StopWatch
    {
        // fields
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void Start()
        {
            if (!_isRunning)
            {
                Console.WriteLine("Please type start to begin the Stop Watch");
                var input = Console.ReadLine().ToLower();

                _startTime = DateTime.Now;
                _isRunning = true;
                Console.WriteLine(_startTime);
            }
            else 
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }
        } 

        public void Stop()
        {
            if (_isRunning)
            {
                Console.WriteLine("Please type start to begin the Stop Watch");
                var input = Console.ReadLine().ToLower();

                _stopTime = DateTime.Now;
                _isRunning = false;
                Console.WriteLine(_stopTime);
            }
        }

        public TimeSpan GetDifference()
        {
            var difference = _stopTime - _startTime;

            return difference;
        }
    }
}
