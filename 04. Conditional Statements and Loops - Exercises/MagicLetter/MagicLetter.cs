namespace MagicLetter
{
    using System;

    public class MagicLetter
    {
        public static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var thirdLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i != thirdLetter && j != thirdLetter && k != thirdLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
