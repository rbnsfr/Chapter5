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
            int[] areacodes     = { 262,  414,  608,  715,  815,  920  };
            double[] perminrate = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };
            bool isValidCode    = false;
            double total;

            Console.Write("Enter your area code: ");
            for (int a = 0; a < areacodes.Length; ++a)
            {
                if (Console.ReadLine() == areacodes[a].ToString())
                {
                    isValidCode = true;
                    total = Convert.ToDouble(Console.ReadLine()) * perminrate[a];
                }
            }
            if (isValidCode)
            {
                Console.Write("Enter how many minutes your call lasted: ");
                Console.WriteLine("\nYour total is {0}.", total);
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
