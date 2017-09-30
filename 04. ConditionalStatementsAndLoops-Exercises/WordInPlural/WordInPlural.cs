namespace WordInPlural
{
    using System;

    public class WordInPlural
    {
        public static void Main()
        {
            var noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                noun = noun.Insert(noun.Length, "ies");
            }

            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") 
                || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun = noun.Insert(noun.Length, "es");
            }

            else
            {
                noun = noun.Insert(noun.Length, "s");
            }

            Console.WriteLine(noun);
        }
    }
}
