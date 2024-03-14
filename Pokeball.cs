using System;

class Pokeball
{
    public bool Catch(Charmander charmander)
    {
        Random random = new Random();
        int catchChance = random.Next(1, 11); // Random number between 1 and 10

        if (catchChance > 5)
        {
            Console.WriteLine("Pokeball shakes once... twice... three times! Pokemon caught!");
            return true;
        }
        else
        {
            Console.WriteLine("Oh no! Pokemon broke free from the Pokeball!");
            return false;
        }
    }
}
