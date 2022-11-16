using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    internal class Program
    {
        //Global class variables
        public static int money = 200;

        //Start Menu + function to exit application
        public static void ShopFront()
        {
            Console.WriteLine("______________________________________________________\n");
            Console.WriteLine("\tWelcome to JP's Snack Shop!\n");
            Console.WriteLine($"\tYour current shop balance is ${money}.");
            Console.WriteLine("\tTo shop Chocolate Bars         - Press [1].");
            Console.WriteLine("\tTo shop Chips & Dips           - Press [2].");
            Console.WriteLine("\tTo shop Soft Drinks & Juices   - Press [3].");
            Console.WriteLine("\tTo add funds to Shop Balance   - Press [4].\n");
            Console.WriteLine("\tTo exit Application            - Press [x].\n");
            Console.WriteLine("______________________________________________________\n");
            Console.WriteLine("\tEnter your option below");

            Console.Write("\t");
            switch(Console.ReadLine())
            {
                case "1":
                    CategoryOne();
                    break;
                case "2": 
                    CategoryTwo(); 
                    break;
                case "3": 
                    CategoryThree();
                    break;
                case "4": 
                    AddFunds();
                    break;
                case "x":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\tYour input is invalid. Choose from the available options please.");
                    ShopFront();
                    break;
            }
        }
        //First category with menu
        public static void CategoryOne()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t______________________________Chocolate Bars_________________________\n");
            Console.WriteLine("\tCadbury Dairy Milk Original    180g   ($5)    - Press 1 to purchase[1]"); 
            Console.WriteLine("\tCadbury Dairy Milk Top Deck    180g   ($5)    - Press 2 to purchase[2]");
            Console.WriteLine("\tWhittaker's Creamy Milk        250g   ($7)    - Press 3 to purchase[3]");
            Console.WriteLine("\tWhittaker's Almond Gold        250g   ($7)    - Press 4 to purchase[4]");
            Console.WriteLine("\tWhittaker's Berry Forest       250g   ($7)    - Press 5 to purchase[5]");
            Console.WriteLine("\tReturn to Shop Front                          - Press 6 to return  [6]\n");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Cadbury Dairy Milk Original for $5. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "2":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Cadbury Dairy Milk Top Deck for $5. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "3":
                    money -= 7;
                    Console.WriteLine($"\tYou have purchased Whittaker's Creamy Milk for $7. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                 case "4":
                    money -= 7;
                    Console.WriteLine($"\tYou have purchased Whittaker's Almond Gold  for $7. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "5":
                    money -= 7;
                    Console.WriteLine($"\tYou have purchased Whittaker's Berry Forest for $7. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "6": 
                    ShopFront();
                    break;

                default:
                    Console.WriteLine("\tYour input is invalid. Choose from the available options please.");
                    CategoryOne();
                    break;


            }
        }
        //second category with menu
        public static void CategoryTwo()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t___________________________Chips & Dips_____________________________\n");
            Console.WriteLine("\tBluebird Ready Salted Chips    150g   ($4)    - Press 1 to purchase[1]");
            Console.WriteLine("\tBluebird Salt & Vinegar Chips  150g   ($4)    - Press 2 to purchase[2]");
            Console.WriteLine("\tBluebird Cheezels              150g   ($4)    - Press 3 to purchase[3]");
            Console.WriteLine("\tBluebird Twisties              150g   ($4)    - Press 4 to purchase[4]");
            Console.WriteLine("\tNestle Reduced Cream Onion Dip 230ml  ($4)    - Press 5 to purchase[5]");
            Console.WriteLine("\tReturn to Shop Front                          - Press 6 to return  [6]\n");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Ready Salted Chips for $4. Your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;

                case "2":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Salt & Vinegar Chips for $4. Your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;

                case "3":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Cheezels for $4. Your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;

                case "4":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Twisties for $4. Your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;

                case "5":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Nestle Reduced Cream Onion Dip for $4. Your remaining shop funds is ${money}");
                    CategoryTwo();
                    break;

                case "6":
                    ShopFront();
                    break;

                default:
                    Console.WriteLine("\tYour input is invalid. Choose from the available options please.\n");
                    CategoryTwo();
                    break;


            }
        }
        //third category with menu
        public static void CategoryThree()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t________________________Soft Drinks & Juices_______________________\n");
            Console.WriteLine("\tCoca Cola              1.5l    ($5)    - Press 1 to purchase[1]");
            Console.WriteLine("\tSprite                 1.5l    ($5)    - Press 2 to purchase[2]");
            Console.WriteLine("\tFanta                  1.5l    ($5)    - Press 3 to purchase[3]");
            Console.WriteLine("\tKeri Apple Juice       1.0l    ($4)    - Press 4 to purchase[4]");
            Console.WriteLine("\tKeri Orange Juice      1.0l    ($4)    - Press 5 to purchase[5]");
            Console.WriteLine("\tReturn to Shop Front                   - Press 6 to return  [6]\n");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Coca Cola 1.5l for $5. Your remaining shop funds is ${money}");
                    CategoryThree();
                    break;

                case "2":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Sprite 1.5l for $5. Your remaining shop funds is ${money}");
                    CategoryThree();
                    break;

                case "3":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Fanta 1.5l for $5. Your remaining shop funds is ${money}");
                    CategoryThree();
                    break;

                case "4":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Keri Apple Juice 1.0l for $4. Your remaining shop funds is ${money}");
                    CategoryThree();
                    break;

                case "5":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Keri Orange Juice 1.0l for $4. Your remaining shop funds is ${money}");
                    CategoryThree();
                    break;

                case "6":
                    ShopFront();
                    break;

                default:
                    Console.WriteLine("\tYour input is invalid. Choose from the available options please.");
                    CategoryThree();
                    break;


            }
        }
        //function to add funds to existing balance
        public static void AddFunds()
        {
            Console.WriteLine("\tAdd Funds ↓↓↓");
            money = int.Parse(Console.ReadLine()) + money;
            Console.WriteLine($"\tYour Balance has been updated. Shop Funds avalaible is now {money}");
            ShopFront();
         }

        static void Main(string[] args) 
        {
           ShopFront();
        }
    }
}