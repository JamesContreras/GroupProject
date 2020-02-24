using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class Ship
    {
        static string Name = "Serenity";
        static double CargoCap = 50;
        static double BucksInAccount = 1000;
        static int Age = 18;

        public static void Starship()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nShipName :");
            Console.WriteLine(Ship.Name);
            Console.WriteLine("\nCurrent Cargo Size :");
            Console.WriteLine(Ship.CargoCap);
            Console.WriteLine($"\nCurrent Bucks :");
            Console.WriteLine(Ship.BucksInAccount);
            Console.WriteLine("\nAge : ");
            Console.WriteLine(Ship.Age);
            
            
        }

        public static void StarshipCargo(Currency currency)
        {
            List<string> cargos = new List<string>() {"\nMineral Ores", "\nwater" };

            Console.WriteLine("\nYou currently have : ");

            foreach (string value in cargos)
            {
                
                Console.WriteLine(value);
            }

            Console.WriteLine("\nPress 'Enter' to return to the travel screen");
            Console.ReadLine();
            Console.Clear();
            Planet.Map(currency);
            Planet.PlanetChoicescreen(currency);

           

          

        

            

            

        }

        
    }
}
