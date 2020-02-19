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
            
                Console.WriteLine("WELCOME TO SPACE X UNIVERSE");
                Console.WriteLine("===========================");
                Console.WriteLine("Type S : to start || Type C : to see credits");
                char S = (char)Console.Read();
                char C = (char)Console.Read();
                if (Char.IsLetter(S))
                {
                    Planet.Map();
                }
                else
                {
                    Credits();
                }
               
                Console.Clear();

           
           
            
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













}
    