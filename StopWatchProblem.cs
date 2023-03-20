using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series_Test_Problem
{
    internal class StopWatchProblem
    {
        public static void StoptheWatch()
        {
            Console.WriteLine("Press Enter to start the StopWatch...");
            Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Stopwatch has started. ");
            Console.WriteLine(" Press Enter to stop the StopWatch...");
            Console.ReadLine();

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine("Elapsed time: {0}", elapsedTime);



        }
    }
}
