using ParaProggUke5;

namespace ParaProggUke5;

internal class Program
{
    static void Main(string[] args)
    {
        var PokemonList = new List<Pokemon>
        {
            new Pokemon("Bulbasaur", 21,10),
            new Pokemon("Charmander", 22,11),
            new Pokemon("Squirtle", 23, 9)
        };
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        var player = new Player(name);

        StarterPokemon(PokemonList, player);
        player.ShowAllPokemon();
        while (true)
        {
            Console.WriteLine("1. Maps");
            Console.WriteLine("2. Shop");
            Console.WriteLine("i. Inventory");
            

        }

    }

    private static void StarterPokemon(List<Pokemon> PokemonList, Player player)
    {
        Console.WriteLine("Choose a starter: ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1}. ");
            PokemonList[i].ShowPokemon();
        }

        bool x = false;
        while (!x)
        {

            var userInput = Console.ReadKey().Key;

            switch (userInput)
            {
                case ConsoleKey.D1:
                    player.AddPokemon(PokemonList[0]);
                    x = true;
                    break;
                case ConsoleKey.D2:
                    player.AddPokemon(PokemonList[1]);
                    x = true;
                    break;
                case ConsoleKey.D3:
                    player.AddPokemon(PokemonList[2]);
                    x = true;
                    break;

            }
        }
    }
}