using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GroupProject
{



    class Planet
    {
        public static void Map()
        {
            do
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
                for (int i = 0; i < 50; i++) //yValue
                {
                    for (int a = 0; a < 100; a++) //xValue
                    {

                        if (XYPair.Contains((a, i)))
                        {
                            Console.Write("(   )");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                       
                        if (a == 99)
                        {
                            Console.Write("\n");
                        }



                    }
                }

                Trademenuscreen();
                Console.Write("==============================");
                PlanetChoicescreen();
            } while (true);
           
        }


        
        public static void TradeMenu(string input)
        {
            switch (input)
            {
                case "B":
                    Console.WriteLine("What are you buying?");
                    break;
                case "S":
                    Console.WriteLine("What are you selling");
                    break;
                case "I":
                    Console.WriteLine("There are no information brokers here today");
                    break;

            }
        }

        public static void Planetchoicemenu(string input)
        {
            switch (input)
            {
                case "MN":
                    break;
                case "MS":
                    break;
                case "HH":
                    break;
                case "TA":
                    break;

            }
        }

        public static void Trademenuscreen()
        {


            Console.WriteLine("\nYou are resting easy at your current port. What would you like to do?");
            Console.WriteLine("\nType B : Buy || Type S : Sell || Type I : Seek Information");
            



        }

        public static void PlanetChoicescreen()
        {

            Console.WriteLine($"\n You are currently at Earth");
            Console.WriteLine($"\n Type MN : To travel to the Moon || Type MS : To travel to Mars || Type HH : To travel to Hadley's Hope || Type TA : To travel to Ticonderoga ");
           

        }
        
        public int x;
        public int y;


    }

}


            

        