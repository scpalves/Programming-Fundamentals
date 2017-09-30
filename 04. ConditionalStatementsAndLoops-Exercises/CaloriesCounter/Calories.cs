namespace CaloriesCounter
{
    using System;

    public class Calories
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalCalories = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                if (ingredient.Equals("cheese"))
                {
                    totalCalories += 500;
                }

                else if (ingredient.Equals("tomato sauce"))
                {
                    totalCalories += 150;
                }

                else if (ingredient.Equals("salami"))
                {
                    totalCalories += 600;
                }

                else if (ingredient.Equals("pepper"))
                {
                    totalCalories += 50;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
