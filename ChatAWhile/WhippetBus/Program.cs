using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhippetBus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[4] { 25, 40, 55, 70 };

            Console.Write("Enter trip distance: ");
            int distance = Convert.ToInt32(Console.ReadLine());

            if (distance >= 0 && distance <= 99) Console.WriteLine("The price for a ticket is {0}.",prices[0].ToString("C"));
            if (distance >= 100 && distance <= 299) Console.WriteLine("The price for a ticket is {0}.", prices[1].ToString("C"));
            if (distance >= 300 && distance <= 499) Console.WriteLine("The price for a ticket is {0}.", prices[2].ToString("C"));
            if (distance >= 500) Console.WriteLine("The price for a ticket is {0}.", prices[3].ToString("C"));
        }
    }
}
