using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GroupProject
{
    class Program
    {
        private static string[] Map;

        public static void Main(string[] args)
        {


            Display();
            Planets();
            SpaceStation();   

            GameTitle();
            StartGame();
            EndGame();
            GameOver();
            YouWin(); 
            Credits();
            
        }
        
        public static void GameTitle()
        {
            Console.WriteLine("Welcome to SpaceX World");
            Console.WriteLine("Press 'Enter' to Begin");
            Console.ReadLine();
            Console.Clear();   
        }
        public static void StartGame()
        {
            Console.WriteLine("Start the Game");
        }
        public static void EndGame()
        {
            Console.WriteLine("End of Game");
            Console.WriteLine("Press 'X' to Exit");
            Console.WriteLine("Press 'X' to Exit or 'Enter' to Begin Another Game");
            Console.ReadLine();
            Console.Clear();
        }
        public static void GameOver()
        {
            Console.WriteLine("Game Over");
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
            spaceship.CargoCap = 30;
            spaceship.ShipSpeed = 90;
        }

        public static void Currency()
        {
            var currency = new Currency();
            currency.SpaceXBucks = int.Parse(Console.ReadLine());
        }


        public static void Display(string input)
        {
            do
            {

                switch (input)
                {
                    case "1":

                        Console.WriteLine(
                    "|      Current Location: Earth    |" +
                    "|                                 |" +
                    "|   ( X )                         |" +
                    "|                                 |" +
                    "|                    (   )        |" +
                    "|                                 |" +
                    "|   ( )                           |" +
                    "|                                 |" +
                    "|                          (   )  |" +
                    "|_________________________________|");

                        break;
                    case "2":
                        Console.WriteLine(
                    "|     Current Location: Moon      |" +
                    "|     Star System: Sol            |" +
                    "|   (   )                         |" +
                    "|                                 |" +
                    "|                    (   )        |" +
                    "|                                 |" +
                    "|   (X)                           |" +
                    "|                                 |" +
                    "|                          (   )  |" +
                    "|_________________________________|");
                        break;

                    case "3":
                        Console.WriteLine(
                    "|     Current Location: Mars      |" +
                    "|                                 |" +
                    "|   (   )                         |" +
                    "|                                 |" +
                    "|                    ( X )        |" +
                    "|                                 |" +
                    "|   ( )                           |" +
                    "|                                 |" +
                    "|                          (   )  |" +
                    "|_________________________________|");
                        break;

                    case "4":
                        Console.WriteLine(
                    "|Current Location : Hadley's Hope |" +
                    "|                                 |" +
                    "|   (   )                         |" +
                    "|                                 |" +
                    "|                    (   )        |" +
                    "|                                 |" +
                    "|   ( )                           |" +
                    "|                                 |" +
                    "|                          ( X )  |" +
                    "|_________________________________|");
                        break;

                    case "5":
                        Console.WriteLine(
                    "|Current Location : Ticonderoga   |" +
                    "|Star System: Alpha Centauri      |" +
                    "|                                 |" +
                    "|                                 |" +
                    "|             ( X )               |" +
                    "|                                 |" +
                    "|                                 |" +
                    "|                                 |" +
                    "|                                 |" +
                    "|_________________________________|");
                        break;

                }

            }

        }




    }





    

   
    


}
    