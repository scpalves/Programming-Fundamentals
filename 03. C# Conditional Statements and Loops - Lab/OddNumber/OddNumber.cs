namespace OddNumber
{
    using System;

    public class OddNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            while (Math.Abs(number) % 2 != 1)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: " + Math.Abs(number));
        }
    }
}
