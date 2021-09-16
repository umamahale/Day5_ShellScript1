using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Flip_Coin
    {
        public static void FlipCoin()
        {
            //Scanner flipTimes = new Scanner(System.in);
            Console.WriteLine("Enter the number of times you want to flip the coin.");
            int coinTossedTimes = Convert.ToInt32(Console.ReadLine());
            int countHead = 0;
            int countTail = 0;
            for (int i = 0; i < coinTossedTimes; i++)
            {
                Random r = new Random();
                int coinStatus = (int)(r.Next(0, 2) + 0.5);
                Console.WriteLine("Random number is: " + coinStatus);
                if (coinStatus == 0)
                {
                    //Console.WriteLine("Head Won");
                    countHead = countHead + 1;
                }
                else
                    //Console.WriteLine("Tail Won");
                    countTail = countTail + 1;
            }
            Console.WriteLine("Head Won " + countHead + " Times");
            Console.WriteLine("Tail Won " + countTail + " Times");
            Console.WriteLine("Head Won " + (countHead * 100) / coinTossedTimes + "% Times");
            Console.WriteLine("Tail Won " + (countTail * 100) / coinTossedTimes + "% Times");
        }

    }
}
