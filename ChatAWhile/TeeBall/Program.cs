using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeeBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] statistics = new int[12,5];

            while (true)
            {
                Console.Write("Enter the player number (999 to quit): ");

                if (Console.ReadLine() == "999") break;
                else statistics[0, 0] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
