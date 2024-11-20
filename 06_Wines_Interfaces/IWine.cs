using System;
using Seido.Utilities.SeedGenerator;

namespace _05_Wines_Interfaces
{
    public enum GrapeType { Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
    public enum WineType { Red, White, Rose }
    public enum Country { Germany, France, Spain }

    public interface IWine
	{
        /// <summary>
        /// Name of the wine
        /// </summary>
        public string Name { get; set; }

        public Country Country { get; set; }
        public WineType WineType { get; set; }
        public GrapeType GrapeType { get; set; }

        public decimal Price { get; set; }
    }
}

