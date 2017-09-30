namespace DebitCardNumber
{
    using System;

    public class RectangleArea
    {
        public static void Main()
        {
            var width = decimal.Parse(Console.ReadLine());
            var height = decimal.Parse(Console.ReadLine());

            var area = width * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
