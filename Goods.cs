using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class Goods
    {
        //Creates goods for planet tradesystem

        
        public static void EarthBuyList()
        {
            bool valid = false; //Sets the bool condition for the do loop
            
            do
            {
                Console.WriteLine("What would you like to Sell Terran?");
                Console.WriteLine("=================================================================");
                Console.WriteLine($"\n Currently in high demand | Mineral Ores : {150} Bucks || Metals : {200} Bucks || Energy Batteries : {400} Bucks");
                string input = Console.ReadLine();

                if (input == "MO")
                {
                    valid = true;                  
                }
                if (input == "MS")
                {
                    valid = true;
                }
                if (input == "EN")
                {
                    valid = true;
                }
            } while (!valid);

            
        }

        public static void EarthSellList(Currency currency)
        {
            bool valid = false;
            do
            {
                Console.WriteLine("What would you like to Buy Terran?");
                Console.WriteLine("=================================================================");
                Console.WriteLine($"\nMining Equipment : {23} Bucks || Water : {100} Bucks || Food Supplies : {10} Bucks || Fuel : {15} Bucks || LuxueryItems : {40} Bucks || Medical Supplies : {32} || Return to Menu");
                string input = Console.ReadLine();
                do
                {
                    

                    if (input == "Mining Equipment")
                    {
                        valid = true;
                        Console.WriteLine("\nQuantity?");

                        // Get input from user
                        // Int.parse()
                        var amount = int.Parse(Console.ReadLine());

                        if (amount >= 10)
                        {
                            Console.WriteLine("You can't buy that much, try again");
                            Console.ReadLine();
                        }


                        // Multiply quantity by price of item
                        var totalPrice = amount * 23;

                        // Decrement currency amount
                        currency.Spend(totalPrice);

                        Console.WriteLine($"\nYou bought {amount} Mining Equipment pieces for {totalPrice}");

                        Console.WriteLine("\nWould you like to make another purchase: Yes or No?");

                        char charYesOrNo;

                        do
                        {
                            charYesOrNo = Console.ReadKey().KeyChar;

                        } while (char.ToUpper(charYesOrNo) != 'N');
                        

                        Console.ReadLine();



                    }

                } while (!valid);

                if (input == "Water")
                {
                    valid = true;
                    Console.WriteLine("\nQuantity?");

                    var amount = int.Parse(Console.ReadLine());


                    if (amount > 10)
                    {
                        Console.WriteLine(" You can't buy that much, try again");
                        Console.ReadLine();
                    }
                    else
                    {
                        var totalPrice = amount * 100;

                        currency.Spend(totalPrice);

                        Console.WriteLine($"You bought {amount} for {totalPrice}");

                        Console.WriteLine("Do you want to make another purchase : Y or N?");

                        input = Console.ReadLine();


                    }    

                }   


                if (input == "Food Supplies")
                {
                    valid = true;
                    Console.WriteLine("\nQuantity?");

                    var amount = int.Parse(Console.ReadLine());
                   
                    if (amount >= 10)
                    {
                        Console.WriteLine("Not enough supplies");
                    }
                    else
                    {
                        var totalPrice = amount * 10;

                        currency.Spend(totalPrice);

                        Console.WriteLine($"You bought {amount} for {totalPrice}");
                    }
                  

                }

                if (input == "Fuel")
                {
                    valid = true;
                    Console.WriteLine("\nQuantity?");

                    var amount = int.Parse(Console.ReadLine());
                    
                    
                        Console.WriteLine("You can not buy anymore");
                        Console.Clear();

                        var totalPrice = amount * 15;

                        currency.Spend(totalPrice);

                        Console.WriteLine($"You bought {amount} for {totalPrice}");
                    
                }

                if (input == "LuxuryItems")
                {
                    valid = true;
                    Console.WriteLine("\nQuantity?");

                    var amount = int.Parse(Console.ReadLine());
                   
                    
                        Console.WriteLine("You can not buy anymore");
                        Console.Clear();

                        var totalPrice = amount * 40;

                        currency.Spend(totalPrice);

                        Console.WriteLine($"You bought {amount} for {totalPrice}");
                    
                }

                if (input == "Medical Supplies")
                {
                    valid = true;
                    Console.WriteLine("\nQuantity?");

                    var amount = int.Parse(Console.ReadLine());
                   
                    
                        Console.WriteLine("You can not buy anymore");
                        Console.Clear();

                        var totalPrice = amount * 40;

                        currency.Spend(totalPrice);

                        Console.WriteLine($"You bought {amount} for {totalPrice}");
                    
                }

                if (input == "Return to Menu")
                {
                    valid = true;
                    Console.Clear();
                }

               

            } while (!valid);
            
        }








        //        public static void MarsGoodList()
        //        {
        //            int[] sellprice = new int[4] { 250, 80, 20, 32};
        //            string[] sellgood = new string[4] { "Metals", "Mineral Ores", "Water", "Medical Supplies"};
        //            int[] buyprice = new int[3] { 20, 30, 200 };
        //            string[] buygood = new string[3] { "Food Supplies", "Fuel", "Equipment Parts" };

        //        }
        //        public static void MoonGoodList()
        //        {
        //            int[] sellprice = new int[6] { 23, 100, 10, 4, 40, 32 };
        //            string[] sellgood = new string[6] { "Mining Equipment", "Water", "Food Supples", "Fuel", "LuxuryItems", "Medical Supplies" };
        //            int[] buyprice = new int[3] { 150, 200, 400 };
        //            string[] buygood = new string[3] { "Mineral ores", "Metals", "Energy Batteries" };
        //        }

        //        public static void HadleyGoodList()
        //        {
        //            int[] sellprice = new int[2] { 30, 100};
        //            string[] sellgood = new string[2] { "Food Supples", "Mineral Ores" };
        //            int[] buyprice = new int[4] { 150, 90, 100, 85 };
        //            string[] buygood = new string[4] { "Seeds","Medical Supplies", "Fuel", "Food Supplies" };

        //        }
        //        public static void TiconderogaGoodList()
        //        {
        //             int[] sellprice = new int[3] { 23, 100, 300 };
        //            string[] sellgood = new string[3] { "Ship Parts", "Fuel", "LuxuryItems"};
        //            int[] buyprice = new int[5] { 80, 500, 1000, 600, 200};
        //            string[] buygood = new string[5] { "Food Supplies", "Water", "Government Cargo", "Seeds", "Medical Supplies"};
        //        }


        //        public string ProductName;
        //        public int ProductValue;


    }
}
