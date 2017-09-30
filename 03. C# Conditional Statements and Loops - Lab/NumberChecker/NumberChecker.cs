namespace NumberChecker
{
    using System;

    public class NumberChecker
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            int number;

            if (int.TryParse(input, out number))
            {
                Console.WriteLine("It is a number.");
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
