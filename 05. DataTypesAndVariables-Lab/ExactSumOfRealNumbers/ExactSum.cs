﻿namespace ExactSumOfRealNumbers
{
    using System;

    public class ExactSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());

                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
