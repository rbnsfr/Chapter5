using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areacodes     = { 262,  414,  608,  715,  815,  920 };
            double[] perminrate = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            double total;
            bool isValidCode    = false;

            Console.Write("Enter your area code: ");
            if (Console.ReadLine() == areacodes[0].ToString())
            {
                Console.Write("Enter how many minutes your call lasted: ");
                int min = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < areacodes.Length; ++i)
                {
                    if (min == areacodes[i])
                    {
                        isValidCode = true;
                        total = min;
                        Console.WriteLine("\nYour total is ${0}.", min * perminrate[0]);
                    }
                }
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("\nThat's not a valid area code!");
                Thread.Sleep(3000);
            }
        }
    }
}
