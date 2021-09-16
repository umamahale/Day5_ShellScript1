using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Harmonic
    {
        static float sum(int n)
        {
            double i, s = 0.0;

            for (i = 1; i <= n; i++)
                s = s + 1 / i;

            return (float)s;
        }


        // Driven Program
        public static void Main()
        {
            int n = 5;
            Console.WriteLine("Sum is "
                               + sum(n));
        }
    }
}

