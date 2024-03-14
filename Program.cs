using System;
using System.Collections.Generic;

class Pokeball
{
    private bool charmanderInside;

    public Pokeball()
    {
        charmanderInside = false;
    }

    public void Throw()
    {
        if (!charmanderInside)
        {
            Console.WriteLine("Pokeball is empty. Nothing to throw.");
            return;
        }

        Console.WriteLine("Pokeball is thrown. Charmander is released!");
        charmanderInside = false;
    }

    public void ReturnCharmander()
    {
        if (charmanderInside)
        {
            Console.WriteLine("Charmander is already inside the Pokeball.");
            return;
        }

        Console.WriteLine("Charmander is returned to the Pokeball.");
        charmanderInside = true;
    }
}

class Trainer
{
    private string name;
    private List<Pokeball> belt;

    public Trainer(string trainerName)
    {
        name = trainerName;
        belt = new List<Pokeball>();
    }

    public void AddPokeball(Pokeball pokeball)
    {
        if (belt.Count >= 6)
        {
            throw new Exception("Belt can only have six pokeballs.");
        }

        belt.Add(pokeball);
    }

    public void ThrowPokeball(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            Console.WriteLine("Invalid pokeball index.");
            return;
        }

        belt[index].Throw();
    }

    public void ReturnCharmander(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            Console.WriteLine("Invalid pokeball index.");
            return;
        }

        belt[index].ReturnCharmander();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

        // Create trainers
        Trainer trainer1 = new Trainer("Ash");
        Trainer trainer2 = new Trainer("Gary");

        // Add pokeballs to trainers
        for (int i = 0; i < 6; i++)
        {
            trainer1.AddPokeball(new Pokeball());
            trainer2.AddPokeball(new Pokeball());
        }

        // Game loop
        while (true)
        {
            Console.WriteLine("1. Start the battle");
            Console.WriteLine("2. Quit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"{trainer1.name} throws Pokeball {i + 1}");
                    trainer1.ThrowPokeball(i);

                    Console.WriteLine($"{trainer2.name} throws Pokeball {i + 1}");
                    trainer2.ThrowPokeball(i);

                    Console.WriteLine($"{trainer1.name} returns Charmander to Pokeball {i + 1}");
                    trainer1.ReturnCharmander(i);

                    Console.WriteLine($"{trainer2.name} returns Charmander to Pokeball {i + 1}");
                    trainer2.ReturnCharmander(i);
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
