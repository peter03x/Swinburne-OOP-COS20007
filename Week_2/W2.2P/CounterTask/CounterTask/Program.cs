﻿namespace CounterTask
{
    internal class Program
    {
        private static void PrintCounters(Counter[] counters)
        {
           foreach(Counter c in counters)
            {
                Console.WriteLine(c.Name + " is " + c.Ticks);
            } 
        }
        static void Main(string[] args)
        {
            Counter[] myCounters = { null, null, null };
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];
            for (int i = 0; i <= 9; i++)
            {
                myCounters[0].Increment();
            }
            for (int i = 0; i <= 14; i++)
            {
                myCounters[1].Increment();
            }
            PrintCounters (myCounters);
            myCounters[2].Reset();
            PrintCounters(myCounters);
            Console.ReadLine(); 
        }
    }
}