namespace RestaurantDiscount
{
    using System;

    public class Discount
    {
        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var servicePackage = Console.ReadLine();

            var hallType = string.Empty;
            var hallPrice = 0.0;
            var totalPriceAfterDiscount = 0.0;

            if (groupSize <= 50)
            {
                hallType = "Small Hall";
                hallPrice = 2500;

                switch (servicePackage)
                {
                    case "Normal":
                        totalPriceAfterDiscount = (hallPrice + 500) * 0.95;
                        break;
                    case "Gold":
                        totalPriceAfterDiscount = (hallPrice + 750) * 0.9;
                        break;
                    case "Platinum":
                        totalPriceAfterDiscount = (hallPrice + 1000) * 0.85;
                        break;
                }
            }
            else if (groupSize <= 100)
            {
                hallType = "Terrace";
                hallPrice = 5000;

                switch (servicePackage)
                {
                    case "Normal":
                        totalPriceAfterDiscount = (hallPrice + 500) * 0.95;
                        break;
                    case "Gold":
                        totalPriceAfterDiscount = (hallPrice + 750) * 0.9;
                        break;
                    case "Platinum":
                        totalPriceAfterDiscount = (hallPrice + 1000) * 0.85;
                        break;
                }
            }
            else if (groupSize <= 120)
            {
                hallType = "Great Hall";
                hallPrice = 7500;

                switch (servicePackage)
                {
                    case "Normal":
                        totalPriceAfterDiscount = (hallPrice + 500) * 0.95;
                        break;
                    case "Gold":
                        totalPriceAfterDiscount = (hallPrice + 750) * 0.9;
                        break;
                    case "Platinum":
                        totalPriceAfterDiscount = (hallPrice + 1000) * 0.85;
                        break;
                }
            }

            var pricePerPerson = totalPriceAfterDiscount / groupSize;

            if (totalPriceAfterDiscount != 0)
            {
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
