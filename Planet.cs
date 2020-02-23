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

                foreach (var xy in XYPair)
                {
                    Console.SetCursorPosition(xy.Item1, xy.Item2);
                    Console.Write("(   )");
                }

                Console.WriteLine("\n");
                PlanetChoicescreen(currency);
                
                
                
            } while (true);

        }


       

        public static void PlanetChoicescreen(Currency currency)
        {
            bool valid = false;
            
            do
            {

                Console.WriteLine($"\n Type E : To travel to the Earth || Type M : To travel to the Moon || Type R : To travel to Mars || Type H : To travel to Hadley's Hope || Type T : To travel to Ticonderoga ");

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
                    MarsTrademenuscreen();
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
                      
                    

                
            } while (!valid);
        }

        public static void EarthTrademenuscreen(Currency currency)
        {
            bool valid = false;

            do
            {
                
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
                    Console.Clear();
                    Console.WriteLine("There are no information brokers yet");
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

        public static void MarsTrademenuscreen()
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




