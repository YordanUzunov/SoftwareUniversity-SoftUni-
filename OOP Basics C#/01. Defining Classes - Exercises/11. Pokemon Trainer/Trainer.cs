using System;
using System.Collections.Generic;
using System.Linq;

public class Trainer
{
    private string name;

    public Trainer(string name)
    {
        this.Name = name;
        this.Badges = 0;
        this.Pokemons = new Stack<Pokemon>();
    }

    public Stack<Pokemon> Pokemons { get; private set; }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can not be empty.");
            }

            this.name = value;
        }
    }

    public int Badges { get; private set; }

    public void AddABadge()
    {
        this.Badges++;
    }

    public void ClearDeadPokemons()
    {
        if (this.Pokemons.Count > 0 && this.Pokemons.Where(p => p.Health <= 0).FirstOrDefault() != null)
        {
            this.Pokemons = new Stack<Pokemon>(this.Pokemons.Where(p => p.Health > 0));
        }
    }
}