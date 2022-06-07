using System;

namespace PiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_GATHER_FROM_MINE = 100;
            const int DAILY_DECREASE_OF_MINE_YIELD = 10;

            int countSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCounter = 0; 

            while (countSpices >= MINIMUM_SPICES_TO_GATHER_FROM_MINE)
            {
                totalConsumed += countSpices - CONSUMED_BY_WORKERS;
                countSpices -= DAILY_DECREASE_OF_MINE_YIELD;
                daysCounter++;

                if (countSpices < MINIMUM_SPICES_TO_GATHER_FROM_MINE)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalConsumed);

            
        }
    }
}
