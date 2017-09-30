namespace SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                number = number / 10;
                sum += lastDigit;
            }

            for (int i = 1; i < number; i++)
            {
                if (sum == 5 || sum == 7 || sum == 11)
                {

                }
            }
        }
    }
}
