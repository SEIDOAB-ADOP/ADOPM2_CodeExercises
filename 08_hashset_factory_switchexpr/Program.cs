using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using Seido.Utilities.SeedGenerator;

namespace _08_hashset_factory_switchexpr;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("08_hashset_factory_switchexpr");

        var rnd = new SeedGenerator();
        var p1 = new Pearl(rnd);
        Console.WriteLine(p1);

        var p1_copy = new Pearl(p1);
        Console.WriteLine(p1_copy);

        Console.WriteLine(p1.Equals(p1_copy));
        Console.WriteLine(p1 == p1_copy);

        var p3 = new Pearl(rnd);
        Console.WriteLine(p3);
        Console.WriteLine(p1.Equals(p3));
        Console.WriteLine(p1 == p3);

        var n1 = new Necklace(100, "Pearl necklace");
        n1.ListOfPearls.Sort();
        Console.WriteLine(n1);

        var n2 = new Necklace(n1);
        Console.WriteLine(n2);

        Console.WriteLine(n1.Equals(n2));
    }
}

//Exercise:
//HashSet<T>
//1. i Main() skapa en lista av 10 olika pärlor slumpmässigt, dock ska alla ha storlek 5mm

//Class factory
//2. i Necklace skapa en statisk metod, CreateSaltWaterUnique, som skapar ett
//   halsband som har 10 unika saltvatten pärlor
//3. i Necklace skapa en statisk metod, CreateXL, som tar en parameter, NrPearls, och skapar ett
//   halsband med NrOfPearls pärlor av storlek 15 - 20mm

//Switch expressions
//4. Modifera ToString() i Pearl så att det läggs till en rad när pärlan presenteras avseende storleken
// <= 10mm ska ”a small pearl” skrivas ut
// >10 och <= 15 ska ”a midsized pearl” skrivas ut
// > 15 ska ”a large pearl” skrivas ut

