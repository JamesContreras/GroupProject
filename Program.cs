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
            var currency = new Currency();

            do
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                string s = "\nWELCOME TO SPACE X UNIVERSE";
                string a = "\n===========================";
                string b = "\nType S : to start || Type C : to see credits";
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 10, Console.CursorTop);
                Console.SetCursorPosition((Console.WindowWidth - a.Length) / 8, Console.CursorTop);
                Console.SetCursorPosition((Console.WindowWidth - b.Length) / 7, Console.CursorTop);
                Console.WriteLine(s);
                Console.WriteLine(a);
                Console.WriteLine(b);                     
                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'S')
                {
                    Planet.Map(currency);
                    valid = true;
                }
                else if (input == 'C')
                {
                    Credits();
                    valid = true;
                }
                
            } while (!valid);



        }

        public static void Credits()
        {
            Console.WriteLine("James Contreras and Ty Meeks");
            
            Console.ReadLine();
            Console.Clear();
            MainMenu();

        }















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












    }













}
