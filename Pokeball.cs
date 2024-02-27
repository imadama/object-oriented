public class Pokeball
{
	public Charmander? Charmander { get; private set; }

	public Pokeball(Charmander? charmander = null)
	{
		Charmander = charmander;
	}

	public void Throw()
	{
		if (Charmander == null)
		{
			Console.WriteLine("The pokeball is empty.");
		}
		else
		{
			Console.WriteLine("The pokeball opens and releases Charmander!");
			Charmander.BattleCry();
			Charmander = null; // Releases the Charmander
		}
	}

	public void Return(Charmander charmander)
	{
		if (Charmander == null)
		{
			Charmander = charmander;
			Console.WriteLine("Charmander is returned to its pokeball.");
		}
		else
		{
			Console.WriteLine("The pokeball already contains a Charmander.");
		}
	}
}
