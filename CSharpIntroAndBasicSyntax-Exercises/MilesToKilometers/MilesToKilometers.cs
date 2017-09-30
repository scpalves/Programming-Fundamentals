namespace MilesToKilometers
{
    using System;

    public class MilesToKilometers
    {
        public static void Main()
        {
            var miles = decimal.Parse(Console.ReadLine());
            var milesToKilometers = miles * 1.60934m; 

            Console.WriteLine($"{milesToKilometers:f2}");
        }
    }
}
