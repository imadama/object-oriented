using System;

public class Pokeball
{
    private Charmander _containedCharmander;
    public bool IsOpen { get; private set; }

    public Pokeball()
    {
        _containedCharmander = null;
        IsOpen = false;
    }

    public void Contain(Charmander charmander)
    {
        if (_containedCharmander == null && !IsOpen)
        {
            _containedCharmander = charmander;
            Console.WriteLine("Charmander is now contained within the Pokeball.");
        }
        else
        {
            Console.WriteLine("The Pokeball is either open or already contains a Charmander.");
        }
    }

    public void Throw()
    {
        if (_containedCharmander != null && !IsOpen)
        {
            IsOpen = true;
            Console.WriteLine("Pokeball is thrown and opens up!");
            _containedCharmander.Roar(); // Charmander wordt vrijgelaten
            _containedCharmander = null;
        }
        else
        {
            Console.WriteLine("The Pokeball is empty or already open.");
        }
    }

    public void Return(Charmander charmander)
    {
        if (_containedCharmander == null && IsOpen)
        {
            _containedCharmander = charmander;
            IsOpen = false;
            Console.WriteLine("Charmander is returned to the Pokeball, which closes again.");
        }
        else
        {
            Console.WriteLine("The Pokeball cannot contain more than one Charmander or is not open.");
        }
    }
}
