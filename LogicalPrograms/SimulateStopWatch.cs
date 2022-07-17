using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalPrograms
{
    class SimulateStopWatch
    {
        public static void MeasuringTimeElapsed()
        {
            Console.WriteLine("Welcome to Stop Watch Simulator");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("StopWatch Start");
            for (int index = 0; index < 100; index++)
            {
                Thread.Sleep(20);
            }
            stopwatch.Stop();
            Console.WriteLine("StopWatch End");
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time by Current Instance : " + timeSpan);
        }
    }
}
