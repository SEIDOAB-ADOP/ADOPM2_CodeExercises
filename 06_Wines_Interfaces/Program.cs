using System.Xml.Linq;
using Seido.Utilities.SeedGenerator;

namespace _05_Wines_Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Wines with Interface!");

        var rnd = new SeedGenerator();
        WineCellar wineCellar = new WineCellar("Martin's cellar");

        #region Add wines to the winecellar

        var w = new WineAsClass();
        w.Seed(rnd);

        #endregion

        Console.WriteLine($"\nWinecellar: {wineCellar.Name}");
        Console.WriteLine(wineCellar);

        Console.WriteLine($"Value of winecellar: {wineCellar.Value:N2} Sek");

        var hilo = wineCellar.WineHiLoCost();
        Console.WriteLine($"\nMost expensive wine:\n{hilo}");
        Console.WriteLine($"Least expensive wine:\n{hilo.locost}");
    }
}

/* Exercises
1. Implement WineAsClass and WineAsStruct
2. Add some wines to the cellar of both WineAsClass and WineAsStruct, notice you can mix
*/

