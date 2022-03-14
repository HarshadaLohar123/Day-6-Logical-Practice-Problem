using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    internal class StopWatch
    {
        public static void SimulateStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(2);
            }
            stopwatch.Stop();
            Console.WriteLine("End");
            Console.WriteLine("Time elapsed: {0}",
                stopwatch.Elapsed);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Simulate Stopwatch Program");
            Console.ReadLine();
            Console.WriteLine("Starting Stopwatch Time: ");
            StopWatch.SimulateStopwatch();
            
        }
    }
}
