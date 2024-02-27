using System.Collections.Generic;

public class Trainer
{
    public string Name { get; }
    public List<Pokeball> Belt { get; }

    public Trainer(string name)
    {
        Name = name;
        Belt = new List<Pokeball>();

        for (int i = 0; i < 6; i++)
        {
            Belt.Add(new Pokeball(new Charmander()));
        }
    }

    public void ThrowPokeball(int index)
    {
        if (index < 0 || index >= Belt.Count)
        {
            Console.WriteLine("Invalid pokeball index.");
            return;
        }

        Console.WriteLine($"{Name} throws a pokeball!");
        Belt[index].Throw();
    }

    public void ReturnCharmander(int index, Charmander charmander)
    {
        if (index < 0 || index >= Belt.Count)
        {
            Console.WriteLine("Invalid pokeball index.");
            return;
        }

        Belt[index].Return(charmander);
    }
}
