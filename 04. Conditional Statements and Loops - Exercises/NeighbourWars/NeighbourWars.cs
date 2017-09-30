namespace NeighbourWars
{
    using System;

    public class NeighbourWars
    {
        public static void Main()
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            int counter = 0;

            bool isAnyoneAlive = true;
            string attackName = string.Empty;
            string attacker = string.Empty;
            string attacked = string.Empty;
            int attackedHealth = 0;


            while (isAnyoneAlive)
            {
                counter++;

                if (counter % 2 != 0)
                {
                    goshosHealth -= peshoDamage;
                    attackName = "Roundhouse kick";
                    attacker = "Pesho";
                    attacked = "Gosho";
                    attackedHealth = goshosHealth;
                }

                else
                {
                    peshosHealth -= goshoDamage;
                    attackName = "Thunderous fist";
                    attacker = "Gosho";
                    attacked = "Pesho";
                    attackedHealth = peshosHealth;
                }

                if (peshosHealth <= 0 || goshosHealth <= 0)
                {
                    Console.WriteLine($"{attacker} won in {counter}th round.");
                    isAnyoneAlive = false;
                }

                else
                {
                    if (counter % 3 == 0)
                    {
                        goshosHealth += 10;
                        peshosHealth += 10;
                    }

                    Console.WriteLine($"{attacker} used {attackName} and reduced {attacked} to {attackedHealth} health.");
                    //var peshoHealthPoints = 100;
                    //var goshoHealthPoints = 100;

                    //var round = 0;

                    //while (peshoHealthPoints > 0 || goshoHealthPoints > 0)
                    //{
                    //    round++;
                    //    goshoHealthPoints -= peshoDamage;

                    //    Console.WriteLine($"{name of the attacker} used {name of the attack} and reduced {name of the defending player} to { health of the defending player} health");
                    //    if (round % 3 == 0)
                    //    {
                    //        goshoHealthPoints += 10;
                    //        peshoHealthPoints += 10;
                    //    }

                    //    round++;
                    //    peshoHealthPoints -= goshoDamage;

                    //    if (round % 3 == 0)
                    //    {
                    //        goshoHealthPoints += 10;
                    //        peshoHealthPoints += 10;
                    //    }
                }
            }
        }
    }
}
