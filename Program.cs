using System;
using RPG.src.entities;

namespace RPG.src.entities
{

class Program
{ 
    static void Main(string[] args)
    { 
        Knight heroi = new Knight("Arus", 23,"Knight");
        Wizard wizard = new Wizard("Jenika", 24, "White Wizard");
        Ninja ninja = new Ninja("Kazuo", 33, "Ninja");
        BlackWizard blackwizard = new BlackWizard("Crowley", 66, "Black Wizard")
        Console.WriteLine(heroi.Attack());
        Console.WriteLine(wizard.Attack(3));
        Console.WriteLine(ninja.Attack());
        Console.WriteLine(blackwizard.Attack(31));
        
    }
}
}

