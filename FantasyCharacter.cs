using System;
using System.Collections.Generic;

namespace FantasyCharacter{
class Wizard: Human{
    
    public Wizard(string name) : base(name){
        Name = name;
        Intelligence = 25;
        health = 50; 
        OriginalHealth = 50;

    }
    
    public override int Attack(Human target){
        int dmg = Strength * 3;
        // int dmgSmart = 5 * Intelligence;
        // int getDmg = dmgSmart / target.Intelligence;
        target.health -= dmg;
        
        target.Intelligence /= 5;
        health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} reduces {target.Name} intelligence to {target.Intelligence}!");
        Console.WriteLine($"{Name} heals by {dmg} and health is now {health}");
        return target.health;
    }

    public int Heal(Human target){
        int healing = 10 * Intelligence;
        target.health += healing;
        if(target.health >= target.OriginalHealth){
            target.health = target.OriginalHealth;
        }
        Console.WriteLine($"{Name} heals {target.Name} by {healing} and {target.Name}'s health is now {target.health}");
        return target.health;
    }
}

class Ninja: Human{
    public Ninja(string name) : base(name){
        Name = name;
        Dexterity = 175;
    }

    public override int Attack(Human target){
        Random rand = new Random();
        int atkPercentage = 20;
        
        int getAtkValue = rand.Next(100);

        if(getAtkValue < atkPercentage){
            Strength += 10;
        }
       
        int dmg = Strength * 3;
        // int dmgDex = 5 * Dexterity;
        // int getDex = target.Dexterity / dmgDex;
        target.health -= dmg;
        target.Dexterity /= 5;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} reduces {target.Name} dexterity to {target.Dexterity}!");
        return target.health;
    }

    public int Steal(Human target){
        int stealHealth = 5;
        target.health -= stealHealth;
        health += stealHealth;
        if(health >= OriginalHealth){
            health = OriginalHealth;
        }
        Console.WriteLine($"{Name} steals {target.Name}'s health by {stealHealth} and {Name}'s health is now {health}");
        return health;
    }
}

class Samurai: Human{
    public Samurai(string name) : base(name){
        Name = name;
        health = 200;
        OriginalHealth = 200;
    }

    public override int Attack(Human target){
        int dmg = Strength * 3;
        target.health -= dmg;
        if(target.health < 50){
            target.Strength = 0;
            Console.WriteLine($"{Name} reduces {target.Name}'s strength to {target.Strength}!");
        }
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }

    public int Meditate(){
        health = OriginalHealth;
        Console.WriteLine($"{Name}'s health has been restore to {health}");
        return health;
    }
}
}