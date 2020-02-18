using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace GroupProject
{
    class Program
    {
        public static List<string> PlanetList = new List<string> { };
        public static int PlanetOrder = 0;
        

        public static void Main(string[] args)
        {

            
            GameTitle();
            
            

        }

        public static void MainMenuShow(string input)
        {
            switch (input)
            {
                case "Enter":


                    break;

                case "L":

                    ImportPlanetList();

                    break;

                case "I":

                    Credits();

                    break;

                default:
                    break;
            }

               
        }

        public static void PortMenu(string input)
        {
            switch(input)
            {
                case "B":
                    Console.WriteLine("What are you buying?");
                    
                    break;

            }
        }

        public static void PlanetInteract(string input)
        {
            switch(input)
            {
                
            }
        }
        

        private static void ImportPlanetList()
        {
            PlanetList = System.IO.File.ReadAllLines(@"C:\Users\Texas\source\repos\GroupProject\PlanetList.txt").ToList();
        }

        public static void SaveGame()
        {
           System.IO.File.WriteAllLines(@"C:\Users\Texas\source\repos\GroupProject\PlanetList.txt", PlanetList);
        }

        public static void Display()
        {
            int showplanet = 5;
            for (int i = 0; i < showplanet; i++)
            {

            }
        }

       

        public static void GameTitle()
        {
            Console.WriteLine("WELCOME TO SPACE X UNIVERSE");

            MainMenu();
            Console.Clear();   
        }
       
        public static void EndGame()
        {
            Console.WriteLine("End of Game");
            Console.WriteLine("Press 'X' to Exit");
            Console.WriteLine("Press 'X' to Exit or 'Enter' to Begin Another Game");
            Console.ReadLine();
            Console.Clear();
        }
      

        public static void YouWin()
        {
            Console.WriteLine("You Won '$$' ");
            Console.WriteLine("Press 'X' to Exit or 'Enter' to Begin Another Game");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Credits()
        {
            Console.WriteLine("JC");
            Console.WriteLine("Ty");
            Console.ReadLine();
            Console.Clear();

        }

        public static void MainMenu()
        {
            Console.WriteLine("Press 'Enter' to begin");
            Console.WriteLine("Type L : to Load last save");
            Console.WriteLine("Type I : to see credits");
        }

        

        public static void Menubuttons()
        {
           

            Console.WriteLine("\nYou are resting easy at your current port. What would you like to do?");
            Console.WriteLine("\nType B : Buy");
            Console.WriteLine("\nType S : Sell");
            Console.WriteLine("\nType I : Seek information");


            
        }

        public static void PlanetChoice()
        {
            Console.WriteLine($"\nYou are currently at : ");
            Console.WriteLine($"\n Type {2} : Moon");
            Console.WriteLine($"\n Type {3} : Mars");
            Console.WriteLine($"\n Type {4} : Hadley's Hope");
            Console.WriteLine($"\n Type {5} : Ticonderoga");

        }

        public static void Planets()
        {
            var planetA = new Planet();
            planetA.Name = "Earth : Trade Station Terra ";
            planetA.Size = "Diameter 4,196 MILES (6,752 KM)";
            planetA.DistancefromStar = "141,635,350 Miles (227,940,00 KM)";
            planetA.Population = "7.6B Terrans";
            planetA.Climate = "Ranges from extreme cold at the poles to tropical heat at the Equator";
            planetA.Atmoshphere = "78% Nitrogen,  21% Oxygen, 0.93% Argon, 0.04% Carbon Dioxide";
            planetA.TradeSupply = "FoodRations, Fuel, Medical Supplies, Mining Equipment, Luxury Items, Water";
            planetA.TradeDemand = "Mineral Ores, Metals, Energy Batteries";

            var planetB = new Planet();
            planetB.Name = "Mars : Trade Port Aries";
            planetB.Size = "Diameter 8,000 MILES (13,000 KM)";
            planetB.DistancefromStar = "141,635,350 Miles (227,940,00 KM)";
            planetB.Population = "120K Martians";
            planetB.Climate = "Average temperature -80F";
            planetB.Atmoshphere = "95% Carbon Dioxide, 3% Nitrogen, 1.6% Argon";
            planetB.TradeSupply = "Metals, Mineral Ores, Water, Medical Supplies";
            planetB.TradeDemand = "Food Rations, Fuel, Equipment Parts";

            var planetC = new Planet();
            planetC.Name = "Moon : Mining Station Arklay";
            planetB.Size = "Diameter 2900 Miles (13,000 KM)";
            planetB.DistancefromStar = "150,245,120 Miles (241,796,082 KM)";
            planetB.Population = "10K Colonists";
            planetB.Climate = "Average temperature : -300F";
            planetB.Atmoshphere = "95% Carbon Dioxide, 3% Nitrogen, 1.6% Argon";
            planetB.TradeSupply = "Water, Food Rations, Mineral Ore";
            planetB.TradeDemand = "Seeds, Medical Supplies, Fuel, Food Rations";
        }

        public static void SpaceStation()
        {
            var spacestationA = new SpaceStation();
            spacestationA.StationName = "Trade Station : Hadley's Hope";
            spacestationA.Size = "2900 Miles (4600 kilometres)";
            spacestationA.Population = "8,000 Stationers";
            spacestationA.TradeSupply = "Food Rations, Mineral Ore";
            spacestationA.TradeDemand = "Seeds, Medical Supplies, Fuel, Food Rations";

            var spacestationB = new SpaceStation();
            spacestationB.StationName = "Frontier Station : Ticondaroga";
            spacestationB.Size = "2900 Miles (4600 kilometres)";
            spacestationB.Population = "5,000 Stationers";
            spacestationB.TradeSupply = "Luxury Items, Ship Parts, Fuel";
            spacestationB.TradeDemand = "Food Rations, Water, Government Cargo, Seeds, Medical Supplies";
        }

        public static void SpaceShip()
        {
            var spaceship = new Ship();
            spaceship.ShipName = "Phoenix";
            spaceship.CargoCap = 1000;
            spaceship.ShipSpeed = 90;
        }

        public static void Currency()
        {
            var currency = new Currency();
            currency.SpaceXBucks = int.Parse(Console.ReadLine());
        }


    }







    

   
    


}
    