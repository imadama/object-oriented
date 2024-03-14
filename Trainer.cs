using System;
using System.Collections.Generic;

public class Trainer
{
    public string Name { get; private set; }
    private List<Pokeball> belt;

    public Trainer(string name)
    {
        Name = name;
        belt = new List<Pokeball>();

        // Initialiseer de riem met zes Pokeballs, elk met een Charmander erin.
        for (int i = 0; i < 6; i++)
        {
            Charmander charmander = new Charmander();
            Pokeball pokeball = new Pokeball();
            pokeball.Contain(charmander);
            belt.Add(pokeball);
        }
    }

    public void ThrowPokeball(int pokeballNumber)
    {
        if (pokeballNumber < 1 || pokeballNumber > belt.Count)
        {
            Console.WriteLine("Invalid Pokeball number.");
            return;
        }

        // Vermindert met 1 omdat de lijstindexen bij 0 beginnen
        belt[pokeballNumber - 1].Throw();
    }

    public void ReturnPokemonToPokeball(Charmander charmander, int pokeballNumber)
    {
        if (pokeballNumber < 1 || pokeballNumber > belt.Count)
        {
            Console.WriteLine("Invalid Pokeball number.");
            return;
        }

        // Vermindert met 1 omdat de lijstindexen bij 0 beginnen
        belt[pokeballNumber - 1].Return(charmander);
    }

    // Optioneel: Methode om extra validatie toe te voegen bij het toevoegen van een Pokeball.
    public void AddPokeballToBelt(Pokeball pokeball)
    {
        if (belt.Count >= 6)
        {
            throw new InvalidOperationException("Cannot add more than six Pokeballs to the belt.");
        }
        belt.Add(pokeball);
    }
}
