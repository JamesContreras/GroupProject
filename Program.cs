using System;

namespace GroupProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            gameTitle();
            startGame();
            endGame();
            gameOver();
            youWin(); 
            credits();
        }
        
        public static void gameTitle()
        {
            Console.WriteLine("Welcome to SpaceX World");
            Console.WriteLine("Press 'Enter' to Begin");
            Console.Readline();
            Console.Clear();   
        }
        public static void startGame()
        {
            Console.WriteLine("Start the Game");
        }
        public static void endGame()
        {
            Console.WriteLine("Game Over");
            Console.WriteLine("Press 'X' to Exit");
            Console.WriteLine("Press 'X' to Exit or 'Enter' to Begin Another Game");
            Console.Readline();
            Console.Clear();
        }
        public static void youWin()
        {
            Console.WriteLine("You Won '$$' ");
            Console.WriteLine("Press 'X' to Exit or 'Enter' to Begin Another Game");
            Console.Readline();
            Console.Clear();
        }
        public static void credits()
        {
            Console.WriteLine("JC");
            Console.WriteLine("Ty");
            Console.Readline();
            Console.Clear();
        }
    }

    class Planet
    {
        public string Name;
        public int Size;
        public int DistancefromStar;
        public int Population;
        public string Climate;
        public int Atmoshphere;
        public string TradeSupply;
        public string TradeDemand;
    }
    class SpaceStation
    {
        public string Name;
        public int Size;
        public int DistancefromStar;
        public int Population;
        public string TradeSupply;
        public string TradeDemand;
    }
}
    