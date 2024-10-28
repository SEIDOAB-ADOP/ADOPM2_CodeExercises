using System;
using Helpers;

namespace _05_Wines_Interfaces
{

    public class csWine : IWine
    {
        public string Name { get; set; }

        public enCountry Country { get; set; }
        public enWineType WineType { get; set; }
        public enGrapeType GrapeType { get; set; }

        public decimal Price { get; set; }

        public IWine Seed(csSeedGenerator rnd)
        {
            this.Country = rnd.FromEnum<enCountry>();

            return this;
        }
    }

    /*
    public struct stWine : IWine
    {
    }
    */

}

