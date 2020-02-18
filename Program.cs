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
            Display();
            

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

       

        public static void Currency()
        {
            var currency = new Currency();
            currency.SpaceXBucks = int.Parse(Console.ReadLine());
        }

        private static void ImportPlanetList()
        {
            PlanetList = System.IO.File.ReadAllLines(@"C:\Users\Texas\source\repos\GroupProject\PlanetList.txt").ToList();
        }

        public static void SaveGame()
        {
            System.IO.File.WriteAllLines(@"C:\Users\Texas\source\repos\GroupProject\PlanetList.txt", PlanetList);
        }

    }







    

   
    


}
    