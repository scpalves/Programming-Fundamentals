namespace CountTheIntegers
{
    using System;

    public class IntegersCount
    {
       public static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            int number;
            var counter = 0;

            while (int.TryParse(inputLine, out number))
            {
                counter++;
                inputLine = Console.ReadLine();
            }

            Console.WriteLine(counter);
        }
    }
}
