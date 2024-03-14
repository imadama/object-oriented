using System;

class Game
{
    private Trainer trainer;
    private Pokeball pokeball;

    public Game()
    {
        trainer = new Trainer();
        pokeball = new Pokeball();
    }

    public void StartGame()
    {
        Console.WriteLine("Welcome to the Pokemon Game!");
        Console.WriteLine("Trainer, get ready to catch a Pokemon!");

        Charmander charmander = new Charmander();

        Console.WriteLine("Trainer throws a Pokeball...");
        bool isCaught = pokeball.Catch(charmander);

        if (isCaught)
        {
            Console.WriteLine("Congratulations! Charmander was caught!");
        }
        else
        {
            Console.WriteLine("Oh no! Charmander escaped!");
        }
    }
}
