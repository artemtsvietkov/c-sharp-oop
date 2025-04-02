using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

class Atom 
{
    public int Protons { get; }
    public int Electrons { get; }

    public Atom(int protons, int electrons) 
    {
        Contract.Requires(protons > 0, "Antalet protoner måste vara större än noll");
        Contract.Requires(electrons > 0, "Antalet elektroner måste vara större än noll");

        Protons = protons;
        Electrons = electrons;
    }

    public void Info() 
    {
        Console.WriteLine($"Atom med {Protons} protoner och {Electrons} elektroner");
    }
}

class Program
{
    static void Main()
    {
        Atom hydrogen = new Atom(1, 1);
        Atom oxygen = new Atom(8, 8);

        List<Atom> waterMolecule = new List<Atom> { hydrogen, hydrogen, oxygen };

        Console.WriteLine("Atomen består av: ");
        
        foreach (var atom in waterMolecule) 
        {
            atom.Info();
        }
    }
}
