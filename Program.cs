using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GroupProject
{
    class Program
    {
        
        

        public static void Main(string[] args)
        {


            Planet.Map();
            



        }



        public static void MainMenuShow(string input)
        {
            switch (input)
            {
                case "Enter":


                    break;

                case "I":

                    Credits();

                    break;

                default:
                    break;
            }


        }

        public static void MainMenu()
        {
            Console.WriteLine("Press 'Enter' to begin");
            Console.WriteLine("Type L : to Load last save");
            Console.WriteLine("Type I : to see credits");
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
    