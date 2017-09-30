namespace BackIn30Minutes
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var hoursInMinutes = hours * 60;
            var totalMinutes = hoursInMinutes + minutes + 30;

            var resultHour = totalMinutes / 60;
            var resultMinutes = totalMinutes % 60;

            if (resultHour > 23)
            {
                resultHour -= 24;
            }

            Console.WriteLine($"{resultHour}:{resultMinutes:D2}");
        }
    }
}
