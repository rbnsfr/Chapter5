using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[5] { 23, 17, 92, 8, 61 };
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", myarr[0], myarr[1], myarr[2], myarr[3], myarr[4]);
            Array.Reverse(myarr);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", myarr[0], myarr[1], myarr[2], myarr[3], myarr[4]);
        }
    }
}
