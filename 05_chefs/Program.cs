using Seido.Utilities.SeedGenerator;

namespace _05_chefs;

public class Chef
{
    public string Name => "Boring";

    public string Hello => $"Hello";
    public string FavoriteDish => "nothing";

    public override string ToString() => $"{Hello}, I am {Name}. I like {FavoriteDish}";

}

public class FrenchChef : Chef
{
}

public class GermanChef : Chef
{
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Chefs!");
    }
}

//Exercises
// 1. Create a FrechChef named Pierre who says Bonjour and likes Escargo
// 2. Create a GermanChef named Heinz who says Guten Tag and likes Wurtz
// 3. Create a list of 10 mixed german and french chefs.
//    Have the chefs present themselves correctly through polymorfism

