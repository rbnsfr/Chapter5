using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = new int[10] { 18042, 27163, 11637, 33521, 22894, 17226, 26216, 31744, 16802, 17823 };

            Console.Write("Enter a zip code: ");
            if (zips.Contains(Convert.ToInt32(Console.ReadLine()))) Console.WriteLine("We deliver!");
            else Console.WriteLine("Sorry, we don't deliver there...");
        }
    }
}
