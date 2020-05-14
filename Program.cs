using System;

namespace FantasyCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Hazel = new Wizard("Hazel");
            Ninja Hayabusa = new Ninja("Hayabusa");
            Samurai Goh = new Samurai("Goh");
            Console.WriteLine("My name is " + Hazel.Name + " my intelligence is " + Hazel.Intelligence + " my strength is " + Hazel.Strength);
            Console.WriteLine("My name is " + Hayabusa.Name + " my dexterity is " + Hayabusa.Dexterity + " my strength is " + Hazel.Strength);
            Console.WriteLine("My name is " + Goh.Name + " my health is " + Goh.health + " my strength is " + Hazel.Strength);
            Hazel.Attack(Goh);
            Hayabusa.Attack(Hazel);
            Console.WriteLine($"{Hazel.Name}'s health is {Hazel.health}");
            Goh.Attack(Hayabusa);
            Goh.Attack(Hayabusa);
            Goh.Attack(Hayabusa);
            Goh.Attack(Hayabusa);
            Goh.Attack(Hayabusa);
            Hayabusa.Attack(Goh);
            Console.WriteLine($"{Goh.Name}'s health is now {Goh.health}");
            Goh.Attack(Hayabusa);
            Console.WriteLine($"{Hayabusa.Name}'s health is {Hayabusa.health}");
            Hayabusa.Attack(Goh);
            Console.WriteLine($"{Goh.Name}'s health is now {Goh.health}");
            Goh.Meditate();
            Hayabusa.Steal(Goh);
            Console.WriteLine($"{Goh.Name}'s health is {Goh.health}");
            
            
        }
    }
}
