using System;
using System.Runtime.InteropServices;

namespace Classes
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;

        private TimeSpan _duration;

        //public Stopwatch()
        //{

        //}

        public TimeSpan Duration()
        {
            _duration += _stop - _start;
            Console.WriteLine(_duration);
            return _duration;
            
        }

        public void Start()
        {
            _start = DateTime.Now;
            Console.WriteLine(_start);
        }

        public void Stop()
        {
            _stop = DateTime.Now;
            var dur = _stop - _start;
            Console.WriteLine(dur);
        }

    }
}