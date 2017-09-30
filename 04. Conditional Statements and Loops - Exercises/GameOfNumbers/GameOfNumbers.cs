namespace GameOfNumbers
{
    using System;

    public class GameOfNumbers
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = M; i >= N; i--)
            {
                for (int j = M; j >= N; j--)
                {
                    counter++;

                    if ((i + j).Equals(magicalNumber))
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");

                        return;
                    }
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
        }
    }
}
