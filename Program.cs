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
        public static int money = 500;

        public static void ShopFront()
        {
            Console.WriteLine("______________________________________________________\n");
            Console.WriteLine($"\tYour current shop balance is ${money}.");
            Console.WriteLine("\tShop Categiry 1          - Press [1].");
            Console.WriteLine("\tShop Categiry 2          - Press [2].");
            Console.WriteLine("\tShop Categiry 3          - Press [3].");
            Console.WriteLine("\tAdd funds to Shop Balance -Press [4].\n");
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
                default:
                    Console.WriteLine("\tYour input is invalid. Choose again please.");
                    ShopFront();
                    break;
            }
        }

        public static void CategoryOne()
        {
            Console.WriteLine("Category One");
                }
        public static void CategoryTwo()
        {
            Console.WriteLine("Category Two");
        }
        public static void CategoryThree()
        {
            Console.WriteLine("Category Three");
        }
        public static void AddFunds()
        {
            Console.WriteLine("\tAdd Funds");
         }
        static void Main(string[] args) 
        {
           
        }
    }
}