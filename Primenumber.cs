using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series_Test_Problem
{
    internal class Primenumber
    {
        public static void Number()
        {
            Console.WriteLine("Please Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
           
            if (IsPrime(num))
            {
                Console.WriteLine(num + " is a prime number.");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number.");
            }

            static bool IsPrime(int n)
            {
                if (n <= 1)
                {
                    return false;
                }

                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

        }
    }
}
