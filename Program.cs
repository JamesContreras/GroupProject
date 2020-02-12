using System;

namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var planet = new Planet();
            Console.WriteLine(Planet.Name);

            
        }
    }

    class Planet
    {
        public string Name;
        public int Size;
        public int DistancefromStar;
        public int Population;
        public string Climate;
        public int Atmoshphere;
        public string TradeSupply;
        public string TradeDemand;
    }
    class SpaceStation
    {
        public string Name;
        public int Size;
        public int DistancefromStar;
        public int Population;
        public string TradeSupply;
        public string TradeDemand;
    }
}
    