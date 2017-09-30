namespace MultiplicationTable2_0
{
    using System;

    public class MultiplicationTable
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            }

            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
        }
    }
}

