using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeQuy_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input N : ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("N! = {0}", Recursive(d));
            Console.Read();

        }

        private static double Recursive(double n)
        {
            if (n > 0)
                return n * Recursive(n - 1);
            return 1;
        }
    }
}
