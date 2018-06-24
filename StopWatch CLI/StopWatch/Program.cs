using System;
using System.Collections.Generic;
using System.Threading;

namespace StopWatch
{

    class Program
    {

        public static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine("The total elapsed time is: " + stopWatch.GetDifference());
        }
    }
}
