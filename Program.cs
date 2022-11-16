using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    internal class Program
    {
        //Global class variables
        public static int money = 200;

        public static void ShopFront()
        {
            Console.WriteLine("______________________________________________________\n");
            Console.WriteLine("\tWelcome to JP's Snack Shop!\n");
            Console.WriteLine($"\tYour current shop balance is ${money}.");
            Console.WriteLine("\tTo shop Chocolate Bars         - Press [1].");
            Console.WriteLine("\tTo shop Chips & Dips           - Press [2].");
            Console.WriteLine("\tTo shop Soft Drinks & Juices   - Press [3].");
            Console.WriteLine("\tTo add funds to Shop Balance   - Press [4].\n");
            Console.WriteLine("To exit Application              - Press [x].\n");
            Console.WriteLine("______________________________________________________\n");
            Console.WriteLine("↓↓↓↓ Enter your option ↓↓↓↓");
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
                    Console.WriteLine("\tYour input is invalid. Choose again please.");
                    ShopFront();
                    break;
            }
        }

        public static void CategoryOne()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t______________________________Chcolate Bars_________________________\n");
            Console.WriteLine("Cadbury Dairy Milk Original    180g   ($5)    - Press 1 to purchase[1]"); 
            Console.WriteLine("Cadbury Dairy Milk Top Deck    180g   ($5)    - Press 2 to purchase[2]");
            Console.WriteLine("Whittaker's Creamy Milk        250g   ($7)    - Press 3 to purchase[3]");
            Console.WriteLine("Whittaker's Almond Gold        250g   ($7)    - Press 4 to purchase[4]");
            Console.WriteLine("Whittaker's Berry Forest       250g   ($7)    - Press 5 to purchase[5]");
            Console.WriteLine("]tReturn to Shop Front                        - Press 6 to return  [6]\n");

            switch(Console.ReadLine())
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
                    Console.WriteLine("\tYour input is invalid. Choose again please.");
                    CategoryOne();
                    break;


            }
        }

        public static void CategoryTwo()
        {
            Console.Clear();
            Console.WriteLine("\t___________________________Chips & Dips_____________________________\n");
            Console.WriteLine("Bluebird Ready Salted Chips    150g   ($4)    - Press 1 to purchase[1]");
            Console.WriteLine("Bluebird Salt & Vinegar Chips  150g   ($4)    - Press 2 to purchase[2]");
            Console.WriteLine("Bluebird Cheezels              150g   ($4)    - Press 3 to purchase[3]");
            Console.WriteLine("Bluebird Twisties              150g   ($4)    - Press 4 to purchase[4]");
            Console.WriteLine("Nestle Reduced Cream Onion Dip 230ml  ($4)    - Press 5 to purchase[5]");
            Console.WriteLine("]tReturn to Shop Front                        - Press 6 to return  [6]\n");

            switch (Console.ReadLine())
            {
                case "1":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Ready Salted Chips for $4. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "2":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Salt & Vinegar Chips for $4. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "3":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Cheezels for $4. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "4":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Bluebird Twisties for $4. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "5":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Nestle Reduced Cream Onion Dip for $4. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "6":
                    ShopFront();
                    break;

                default:
                    Console.WriteLine("\tYour input is invalid. Choose again please.");
                    CategoryTwo();
                    break;


            }
        }

        public static void CategoryThree()
        {
            Console.Clear();
            Console.WriteLine("\t________________________Soft Drinks & Juices_______________________\n");
            Console.WriteLine("Coca Cola              1.5l    ($5)    - Press 1 to purchase[1]");
            Console.WriteLine("Sprite                 1.5l    ($5)    - Press 2 to purchase[2]");
            Console.WriteLine("Fanta                  1.5l    ($5)    - Press 3 to purchase[3]");
            Console.WriteLine("Keri Apple Juice       1.0l    ($4)    - Press 4 to purchase[4]");
            Console.WriteLine("Keri Orange Juice      1.0l    ($4)    - Press 5 to purchase[5]");
            Console.WriteLine("]tReturn to Shop Front                 - Press 6 to return  [6]\n");

            switch (Console.ReadLine())
            {
                case "1":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Coca Cola 1.5l for $5. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "2":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Sprite 1.5l for $5. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "3":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased Fanta 1.5l for $5. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "4":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Keri Apple Juice 1.0l for $4. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "5":
                    money -= 4;
                    Console.WriteLine($"\tYou have purchased Keri Orange Juice 1.0l for $4. Your remaining shop funds is ${money}");
                    CategoryOne();
                    break;

                case "6":
                    ShopFront();
                    break;

                default:
                    Console.WriteLine("\tYour input is invalid. Choose again please.");
                    CategoryThree();
                    break;


            }
        }

        public static void AddFunds()
        {
            Console.Clear();
            Console.WriteLine("\tAdd Funds ↓↓↓");
            money= int.Parse(Console.ReadLine()) + money;
            Console.WriteLine($"\tYour Balance has been uodated. Shop Funds avalaible is now {money}");
            ShopFront();
         }

        static void Main(string[] args) 
        {
           ShopFront();
        }
    }
}