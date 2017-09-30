namespace _5DifferentNumbers
{
    using System;

    public class DifferentNumbers
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            bool isValid = false;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                if (a <= i && i < j && j < k && k < l && l < m && m <= b)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    isValid = true;                                
                                }
                            }
                        }
                    }
                }
            }

            if (!isValid)
            {
                Console.WriteLine("No");
            }
        }
    }
}
