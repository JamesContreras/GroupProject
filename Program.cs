using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GroupProject
{
    class Program
    {

        public static int TaskOrder = 0;

        public static void Main(string[] args)
        {


            MainMenu();


        }

        public static void MainMenu()
        {
            bool valid = false;

            do
            {
                Console.Clear();

                Console.WriteLine("WELCOME TO SPACE X UNIVERSE");
                Console.WriteLine("===========================");
                Console.WriteLine("Type S : to start || Type C : to see credits");
                char input = char.ToLower(Console.ReadKey().KeyChar);

                if (input == 's')
                {
                    Planet.Map();
                    valid = true;
                }
                else if (input == 'c')
                {
                    Credits();
                    valid = true;
                }
            } while (!valid);


        }

        public static void Credits()
        {
            Console.WriteLine("JC");
            Console.WriteLine("Ty");
            Console.ReadLine();
            Console.Clear();
        }














        //public static void GameTitle()
        //{
        //    Console.WriteLine("WELCOME TO SPACE X UNIVERSE");

        //    MainMenu();
        //    Console.Clear();
        //}

        //public static void EndGame()
        //{
        //    Console.WriteLine("End of Game");
        //    Console.WriteLine("Press 'X' to Exit");
        //    Console.WriteLine("Press 'X' to Exit or 'Enter' to Begin Another Game");
        //    Console.ReadLine();
        //    Console.Clear();
        //}


        //public static void YouWin()
        //{
        //    Console.WriteLine("You Won '$$' ");
        //    Console.WriteLine("Press 'X' to Exit or 'Enter' to Begin Another Game");
        //    Console.ReadLine();
        //    Console.Clear();
        //}










        //public static void Currency()
        //{
        //    var currency = new Currency();
        //    currency.SpaceXBucks = int.Parse(Console.ReadLine());
        //}



    }
        public static void inclementWeather()
            {
        Console.WriteLine("If weather is good, trade and then move to new destination.");
        Console.WriteLine("If weather is bad, stay put.");
        
        string inclementWather;

            if (inclementWeather = true)
            {
            Console.WriteLine("trade and move to next destination");
            }
            else if (inclementWeather = false)
                {
                Console.WriteLine("stay put");
                }
        }

        public static void partsMalfuction()
        {
            Console.WriteLine("If repaired, earn $$$ and move to next destination");
            Console.WriteLine("If not repaired, stay put and pay taxes");

            string partsMalfuction;

            if (partsMalfuction = yes)
            {
            Console.WriteLine("Earned $$$");
            }
            else if (partsMalfontuntion = no)
                {
                Console.WriteLine("pay taxes on planet");
                }
        }
        public static void theft()
        {
        Console.WriteLine("Your vehicle is stolen");
        Console.WriteLine("Sorry you have been robbed");

            string theft;

             if (theft = yes)
        {
                Console.WriteLine("stay on planet and sell all supplies");

        }
             else if (theft = no)
        {
                Console.WriteLine("continue to next destination");
        }
    }

}