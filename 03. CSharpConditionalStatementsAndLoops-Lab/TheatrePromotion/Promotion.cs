namespace TheatrePromotion
{
    using System;

   public class Promotion
    {
        public static void Main()
        {
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var price = -1;

            if (typeOfDay.Equals("Weekday"))
            {
                if (age >= 0 && age <= 18)
                {
                    price = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                }
            }

            else if (typeOfDay.Equals("Weekend"))
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
            }

            else if (typeOfDay.Equals("Holiday"))
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
            }

            if (price < 0)
            {
                Console.WriteLine("Error!");
            }

            else
            {
                Console.WriteLine(price + "$");
            }
        }
    }
}
