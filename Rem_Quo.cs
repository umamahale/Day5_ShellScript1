using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Rem_Quo
    {
        static void Main()
        {

            int dividend = 90, divisor = 8;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
