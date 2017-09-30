namespace Hotel
{
    using System;

    public class Hotel
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var priceForStudio = 0.0;
            var priceForDouble = 0.0;
            var priceForSuite = 0.0;

            if (month.Equals("May") || month.Equals("October"))
            {

                if (month.Equals("October") && nightsCount > 7)
                {
                    priceForStudio = 50 * 0.95 * (nightsCount - 1);
                }
                else
                {
                    priceForStudio = 50 * nightsCount;
                }

                if (month.Equals("May") && nightsCount > 7)
                {
                    priceForStudio = 50 * 0.95 * nightsCount;
                }

                priceForDouble = 65 * nightsCount;
                priceForSuite = 75 * nightsCount;
            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                if (month.Equals("September") && nightsCount > 7)
                {
                    priceForStudio = 60 * nightsCount - 60;
                }
                else
                {
                    priceForStudio = 60 * nightsCount;
                }

                if (nightsCount > 14)
                {
                    priceForDouble = (72 * nightsCount) * 0.9;
                }
                else
                {
                    priceForDouble = 72 * nightsCount;
                }

                priceForSuite = 82 * nightsCount;
            }
            else if (month.Equals("July") || month.Equals("August") || month.Equals("December"))
            {
                priceForStudio = 68 * nightsCount;
                priceForDouble = 77 * nightsCount;

                if (nightsCount > 14)
                {
                    priceForSuite = (89 * nightsCount) * 0.85;
                }
                else
                {
                    priceForSuite = 89 * nightsCount;
                }
            }

            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
            Console.WriteLine($"Double: {priceForDouble:f2} lv.");
            Console.WriteLine($"Suite: {priceForSuite:f2} lv.");
        }
    }
}
