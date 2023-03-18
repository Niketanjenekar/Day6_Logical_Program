using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PerfectNumberProblem
    {
        public static void FindPerfectNumber()
        {
            int num, min, max, i, sum;

            Console.WriteLine("Find the Pefect Numbers Within a Range");
            Console.WriteLine("Please enter the Starting Range : ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Ending Range : ");
            max = int.Parse(Console.ReadLine());

            for(num = min; num <= max; num++)
            {
                i = 1;
                sum = 0;
                while(i<num)
                {
                    if (num % i == 0)
                        sum = sum + i;
                    i++;

                }
                if (sum == num)
                {
                    Console.WriteLine(num + " ");
                }
            }
        }
    }
}
