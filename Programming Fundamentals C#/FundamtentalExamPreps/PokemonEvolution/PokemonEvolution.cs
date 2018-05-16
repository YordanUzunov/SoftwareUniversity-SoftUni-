using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    public class PokemonType
    {
        public string TypeName { get; set; }
        public int Index { get; set; }
    }

    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, List<PokemonType>>();
            var inputLine = Console.ReadLine();
            while (inputLine != "wubbalubbadubdub")
            {
                var tokens = inputLine
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string pokemonName = tokens[0];
                if (tokens.Length > 1)
                {
                    string pokemonType = tokens[1];
                    int index = int.Parse(tokens[2]);

                    PokemonType poki = new PokemonType();
                    poki.TypeName = pokemonType;
                    poki.Index = index;

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<PokemonType>();
                    }

                    pokemons[pokemonName].Add(poki);
                }
                else
                {

                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var p in pokemons[pokemonName])
                        {
                            Console.WriteLine($"{p.TypeName} <-> {p.Index}");
                        }
                    }

                }

                inputLine = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var p in pokemon.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{p.TypeName} <-> {p.Index}");
                }
            }
        }
    }
}
