namespace BeverageLabels
{
    using System;

    public class BeverageLabels
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var energy = (energyContent * volume) / 100.0;
            var sugar = (sugarContent * volume) / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
