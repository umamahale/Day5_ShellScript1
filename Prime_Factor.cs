using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Prime_Factor
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
        }
    }
}
