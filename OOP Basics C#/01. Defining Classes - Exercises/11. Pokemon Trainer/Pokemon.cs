public class Pokemon
{
    private const int PokemonHealtLossDueToMissingElement = 10;

    public Pokemon(string name, string element, int health)
    {
        this.Name = name;
        this.Element = element;
        this.Health = health;
    }

    public int Health { get; private set; }

    public string Element { get; }

    public string Name { get; }

    public void ReduceHealth()
    {
        this.Health -= PokemonHealtLossDueToMissingElement;
    }
}