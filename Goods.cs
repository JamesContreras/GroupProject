using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class Goods
    {
        //Creates goods for planet tradesystem

        public static void EarthGoodList()
        {
                       
            int[] buyprice = new int[3] { 150, 200, 400};
            string[] buygood = new string[3] { "Mineral ores", "Metals", "Energy Batteries"};
            Console.WriteLine("Welcome to the best trade port in the Sol System.  What can I get you?");
            Console.WriteLine(new string[3]);


        }

        public static void EarthSellList()
        {
            int[] sellprice = new int[6] { 23, 100, 10, 15, 40, 32 };
            string[] sellgood = new string[6] { "Mining Equipment", "Water", "Food Supples", "Fuel", "LuxuryItems", "Medical Supplies" };
        }
        public static void MarsGoodList()
        {
            int[] sellprice = new int[4] { 250, 80, 20, 32};
            string[] sellgood = new string[4] { "Metals", "Mineral Ores", "Water", "Medical Supplies"};
            int[] buyprice = new int[3] { 20, 30, 200 };
            string[] buygood = new string[3] { "Food Supplies", "Fuel", "Equipment Parts" };

        }
        public static void MoonGoodList()
        {
            int[] sellprice = new int[6] { 23, 100, 10, 4, 40, 32 };
            string[] sellgood = new string[6] { "Mining Equipment", "Water", "Food Supples", "Fuel", "LuxuryItems", "Medical Supplies" };
            int[] buyprice = new int[3] { 150, 200, 400 };
            string[] buygood = new string[3] { "Mineral ores", "Metals", "Energy Batteries" };
        }

        public static void HadleyGoodList()
        {
            int[] sellprice = new int[2] { 30, 100};
            string[] sellgood = new string[2] { "Food Supples", "Mineral Ores" };
            int[] buyprice = new int[4] { 150, 90, 100, 85 };
            string[] buygood = new string[4] { "Seeds","Medical Supplies", "Fuel", "Food Supplies" };

        }
        public static void TiconderogaGoodList()
        {
             int[] sellprice = new int[3] { 23, 100, 300 };
            string[] sellgood = new string[3] { "Ship Parts", "Fuel", "LuxuryItems"};
            int[] buyprice = new int[5] { 80, 500, 1000, 600, 200};
            string[] buygood = new string[5] { "Food Supplies", "Water", "Government Cargo", "Seeds", "Medical Supplies"};
        }


        public string ProductName;
        public int ProductValue;
        

    }
}
