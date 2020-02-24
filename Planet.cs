using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GroupProject
{



    class Planet
    {
        public int x;
        public int y;
        public int userLocation;

        

        public static void Map(Currency currency)
        {


            List<Planet> planetList = new List<Planet> { };

            Planet earth = new Planet();
            earth.x = 0;
            earth.y = 0;
            planetList.Add(earth);

            Planet moon = new Planet();
            moon.x = 8;
            moon.y = 5;
            planetList.Add(moon);

            Planet mars = new Planet();
            mars.x = 30;
            mars.y = 20;
            planetList.Add(mars);

            Planet HadleyHope = new Planet();
            HadleyHope.x = 70;
            HadleyHope.y = 10;
            planetList.Add(HadleyHope);

            Planet Ticonderoga = new Planet();
            Ticonderoga.x = 90;
            Ticonderoga.y = 20;
            planetList.Add(Ticonderoga);



            List<(int, int)> XYPair = new List<(int, int)> { };

            foreach (Planet planet in planetList)
            {
                XYPair.Add((planet.x, planet.y));
                
            }

            do
            {

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var xy in XYPair)
                {
                    Console.SetCursorPosition(xy.Item1, xy.Item2);
                    
                    Console.Write("    ");
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n");

                Ship.Starship();
                PlanetChoicescreen(currency);
                
                
                
            } while (true);

        }


       

        public static void PlanetChoicescreen(Currency currency)
        {
            bool valid = false;
            
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n");
                Console.WriteLine("\n**********************************");
                Console.WriteLine("\nWhere would you like to go?");
                Console.WriteLine($"\nType E : To travel to the Earth || Type M : To travel to the Moon || Type R : To travel to Mars || Type H : To travel to Hadley's Hope || Type T : To travel to Ticonderoga || Type C : to check Cargo ");

                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'E')
                {
                    valid = true;
                    Console.Clear();
                    EarthTrademenuscreen(currency);
                }
                if (input == 'M')
                {
                    valid = true;
                    Console.Clear();
                    MoonTrademenuscreen();
                }
                if (input == 'R')
                {
                    valid = true;
                    Console.Clear();
                    MarsTrademenuscreen(currency);
                }
                if (input == 'H')
                {
                    valid = true;
                    Console.Clear();
                    HadleyTrademenuscreen();
                }
                if (input == 'T')
                {
                    valid = true;
                    Console.Clear();
                    TiconderogaTrademenuscreen();
                }
                if (input == 'C')
                {
                    valid = true;
                    Console.Clear();
                    Ship.StarshipCargo(currency);
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n*****************************");
                Ship.Starship();
                

                
            } while (!valid);
        }

        public static void EarthTrademenuscreen(Currency currency)
        {
            bool valid = false;

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType B : Buy || Type S : Sell || Type I : Seek Information || Type G : Return to planet menu");
                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'B')
                {
                    valid = true;
                    Console.Clear();
                    Goods.EarthSellList(currency);                                  
                }
                else if (input == 'S')
                {
                    valid = true;
                    Console.Clear();
                    Goods.EarthBuyList();
                }
                else if (input == 'I')
                {
                    
                    Console.WriteLine("There are no information brokers yet");
                    Console.WriteLine("Press 'Enter' to return to the option screen");
                    Console.ReadLine();
                    Console.Clear();
                    EarthTrademenuscreen(currency);
                    valid = true;
                }
                else if (input == 'G')
                {
                    valid = true;
                    Console.Clear();
                    Map(currency);
                    PlanetChoicescreen(currency);
                }


            } while (!valid);


        }

        public static void MarsTrademenuscreen(Currency currency)
        {
            bool valid = false;

            do
            {

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType B : Buy || Type S : Sell || Type I : Seek Information || Type G : Return to Menu");
                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'B')
                {
                    valid = true;
                    Console.Clear();
                    

                }
                if (input == 'S')
                {
                    valid = true;
                    Console.Clear();
                    
                }
                if (input == 'I')
                {
                    Console.WriteLine("There are no information brokers yet");
                    valid = true;
                }
                if (input == 'G')
                {
                    valid = true;
                    PlanetChoicescreen(currency);
                }

            } while (valid);


        }

        public static void MoonTrademenuscreen()
        {
            bool valid = false;

            do
            {

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType B : Buy || Type S : Sell || Type I : Seek Information");
                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'B')
                {
                    valid = true;
                    Console.Clear();
                   

                }
                if (input == 'S')
                {
                    valid = true;
                    Console.Clear();
                    
                }
                if (input == 'I')
                {
                    Console.WriteLine("There are no information brokers yet");
                    valid = true;
                }

            } while (valid);


        }

        public static void HadleyTrademenuscreen()
        {
            bool valid = false;

            do
            {

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType B : Buy || Type S : Sell || Type I : Seek Information");
                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'B')
                {
                    valid = true;
                    Console.Clear();
                    

                }
                if (input == 'S')
                {
                    valid = true;
                    Console.Clear();
                  
                }
                if (input == 'I')
                {
                    Console.WriteLine("There are no information brokers yet");
                    valid = true;
                }

            } while (valid);


        }

        public static void TiconderogaTrademenuscreen()
        {
            bool valid = false;

            do
            {

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType B : Buy || Type S : Sell || Type I : Seek Information");
                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'B')
                {
                    valid = true;
                    Console.Clear();
                  

                }
                if (input == 'S')
                {
                    valid = true;
                    Console.Clear();
                   
                }
                if (input == 'I')
                {
                    Console.WriteLine("There are no information brokers yet");
                    valid = true;
                }

            } while (valid);


        }

       




    }

}




