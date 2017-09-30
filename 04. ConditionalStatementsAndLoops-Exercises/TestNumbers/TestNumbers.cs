namespace TestNumbers
{
    using System;

    public class TestNumbers
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var maximumSumBoundary = int.Parse(Console.ReadLine());

            var countOfCombinations = 0;
            var totalSumOfNumbers = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    countOfCombinations++;
                    totalSumOfNumbers += 3 * (i * j);

                    if (totalSumOfNumbers >= maximumSumBoundary)
                    {
                        Console.WriteLine($"{countOfCombinations} combinations");
                        Console.WriteLine($"Sum: {totalSumOfNumbers} >= {maximumSumBoundary}");

                        return;
                    }
                }
            }

            if (totalSumOfNumbers < maximumSumBoundary)
            {
                Console.WriteLine($"{countOfCombinations} combinations");
                Console.WriteLine($"Sum: {totalSumOfNumbers}");
            }
        }
    }
}
