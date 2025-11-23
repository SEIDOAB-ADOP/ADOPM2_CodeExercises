using System;
using Seido.Utilities.SeedGenerator;

namespace _05_Wines_Interfaces
{

    public class WineAsClass : IWine
    {
        public string Name { get; set; }

        public Country Country { get; set; }
        public WineType WineType { get; set; }
        public GrapeType GrapeType { get; set; }

        public decimal Price { get; set; }

        public IWine Seed(SeedGenerator rnd)
        {
            this.Country = rnd.FromEnum<Country>();

            return this;
        }
    }

    /*
    public struct WineAsStruct : IWine
    {
    }
    */

}

