using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        // Set up private fields
        private DateTime _start;
        private DateTime _stop;
        private TimeSpan _duration;

        public string Start()
        {
            // Throw exception if stopwatch started twice in a row
            try
            {
                _start = DateTime.Now;
                return Convert.ToString(_start);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("e == " + e);
            }
            return String.Empty;
        }

        public string Stop()
        {
            // Throw exception if stopwatch started twice in a row
            try
            {
                _stop = DateTime.Now;
                return Convert.ToString(_stop);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("e == " + e);
            }
            return String.Empty;
        }

        public TimeSpan Duration()
        {
            // Calculate duration in TimeSpan
            var _tsStart = new TimeSpan(_start.Hour, _start.Minute, _start.Second);
            var _tsStop = new TimeSpan(_stop.Hour, _stop.Minute, _stop.Second);

            _duration = _tsStop - _tsStart;

            return _duration;
        }
    }
}