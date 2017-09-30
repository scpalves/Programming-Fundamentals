namespace PassedOrFailed
{
    using System;

    public class Grade
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade < 3)
            {
                Console.WriteLine("Failed!");
            }

            else
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
