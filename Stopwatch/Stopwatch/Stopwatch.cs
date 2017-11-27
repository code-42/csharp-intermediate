using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;

        private TimeSpan _duration;

        public TimeSpan Duration()
        {
            var start = new TimeSpan(_start.Hour, _start.Minute, _start.Second);
            var stop = new TimeSpan(_stop.Hour, _stop.Minute, _stop.Second);

            _duration = stop - start;

            return _duration;
        }

        public string Start()
        {
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

    }
}