using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static FlowerStore flowerList;

        static void Main(string[] args)
        {
            PrepateFowerlist();
            ShowNumberMenu();
        }

        static void PrepateFowerlist()
        {
            Program.flowerList = new FlowerStore();
        }

        static void ShowNumberMenu()
        {
            Console.WriteLine("Select Number for buy flower.");
            Console.WriteLine("1 Rose.");
            Console.WriteLine("2 Lotus");
            InputSelectFlower();
        }

        static void InputSelectFlower()
        {
            string selectflower = Console.ReadLine();
            AddflowerToCart(selectflower);
        }

        static void AddflowerToCart(string selectflower)
        {
            if(selectflower == "1")
            {
                flowerList.addTocard("Rose");
                Console.WriteLine("Added Rose");
            }
            else if (selectflower =="2")
            {
                flowerList.addTocard("Lotus");
                Console.WriteLine("Added Lotus");
            }
            else
            {
                Console.WriteLine("Not Added to cart. found select number of flower");
            }
            Exit();
        }

        static void Exit()
        {
            Console.WriteLine("You can stop progress ? exit for >> exit << progress and press any key for continue");
            string inputexit = Console.ReadLine();
            if (inputexit !="exit")
            {
                ShowNumberMenu();
            }
            else
            {
                flowerList.ShowCard();
            }
        }
    }

    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();

        public void addTocard(string name)
        {
            cart.Add(name);
        }

        public void ShowCard()
        {
            if(cart.Count == 0)
            {
                Console.WriteLine("Cart is enpty.");
            }
            else
            {
                Console.WriteLine("My cart : ");
                foreach(string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
