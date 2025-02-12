using System;
using System.Collections.Generic;

namespace FantasyCharacter{
class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int health;

    public int OriginalHealth;
     
    public int Health
    {
        get { return health; }
    }
     
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
        OriginalHealth = 100;

    }
     
    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        health = hp;
    }
     
    // Build Attack method
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }
}
}