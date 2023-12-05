using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaProggUke5;

class Pokemon
{
    public string Name;
    public int Health;
    public int MaxDmg;


    public Pokemon(string name, int health, int maxDmg)
    {
        Name = name;
        Health = health;
        MaxDmg = maxDmg;
    }

    public void ShowPokemon()
    {
        Console.WriteLine();
        Console.WriteLine("{0} - {1}",Name, Health);
        
    }

    public int Attack()
    {
        var ran = new Random();
        var dmg = ran.Next(0, MaxDmg);
        return dmg;
    }
}