namespace SumOfOddNumbers
{
    using System;

    public class OddNumbersSum
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var oddNumber = 1;
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += oddNumber;
                Console.WriteLine(oddNumber);
                oddNumber += 2;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
