﻿using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);
            Random random = new Random(s);

            int sum=0;
            for (int i = 0; i < n; i++)
            {
                sum += random.Next(1,7);
            }

            Console.WriteLine(sum);
        }
    }
}
