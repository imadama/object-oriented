using System;

class Program
{
    static void Main(string[] args)
    {
        bool gameRunning = true;

        while (gameRunning)
        {
            Console.WriteLine("Welcome to the simple Pokemon battle simulator!");
            Console.WriteLine("Enter the name of the first trainer:");
            string trainer1Name = Console.ReadLine();
            Trainer trainer1 = new Trainer(trainer1Name);

            Console.WriteLine("Enter the name of the second trainer:");
            string trainer2Name = Console.ReadLine();
            Trainer trainer2 = new Trainer(trainer2Name);

            for (int i = 1; i <= 6; i++) // Er zijn 6 Pokeballs per trainer
            {
                Console.WriteLine($"{trainer1Name}'s turn:");
                trainer1.ThrowPokeball(i);
                Console.WriteLine($"{trainer2Name}'s turn:");
                trainer2.ThrowPokeball(i);

                // Simulatie dat Charmander zijn strijdkreet laat horen is al geïmplementeerd in de Throw methode van Pokeball

                // Charmanders terugroepen
                Console.WriteLine($"{trainer1Name} returns Charmander to its Pokeball.");
                trainer1.ReturnPokemonToPokeball(new Charmander(), i);
                Console.WriteLine($"{trainer2Name} returns Charmander to its Pokeball.");
                trainer2.ReturnPokemonToPokeball(new Charmander(), i);
            }

            Console.WriteLine("All Pokeballs have been used. Would you like to play again? (yes/no)");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "yes")
            {
                gameRunning = false;
                Console.WriteLine("Thank you for playing the simple Pokemon battle simulator!");
            }
        }
    }
}
