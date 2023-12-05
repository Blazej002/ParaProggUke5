using ParaProggUke5;

namespace ParaProggUke5;

class Player
{
    public string Name;
    public List<Pokemon> myPokemon;
    
    public Player( string name = "Bob")
    {
        Name = name;
        myPokemon = new List<Pokemon>();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        myPokemon.Add(pokemon);
    }

    public void ShowAllPokemon()
    {
        foreach (var pokemon in myPokemon)
        {
            pokemon.ShowPokemon();
        }
    }
}