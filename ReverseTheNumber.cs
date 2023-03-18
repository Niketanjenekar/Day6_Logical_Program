using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class ReverseTheNumber
    {
        public static void ReversetheNumbers()
        {
            int num, reverse = 0, rem;
            Console.WriteLine("Please Enter the Number whch you want to reverse : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
                
            }
            Console.WriteLine("Reversed Number : " + reverse + " ");
        }
    }
}
