using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintWelCome(); 
        }

        static void PrintWelCome()
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Please Select Menu : ");
            SelectMenu();
        }

        static void SelectMenu()
        {
            int select = int.Parse(Console.ReadLine());
            if(select == 1)
            {
                PrintHeaderPlayGame();
            }
        }

        static void PrintHeaderPlayGame()
        {
            Console.Clear();
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("------------------");
            WordList();
        }

        static void WordList()
        {
            string[] Listword = new string[10];
            Listword[0] = "Tennis";
            Listword[1] = "Football";
            Listword[2] = "Badminton";
            RandomWords(Listword);
        }

        static void RandomWords(string[] Listword)
        {
            Random random = new Random();
            int resultRandom = random.Next(0,2);
            string words = Listword[resultRandom];
            char [] wordTypeChar = words.ToCharArray();

            //Console.WriteLine(words.ToCharArray());
            PrintUnderScore(wordTypeChar);
        }

        static void PrintUnderScore(char[] wordTypeChar)
        {
            int correctscore = 0;
            IncorrectScore(correctscore);
            for (int i = 1; i <= wordTypeChar.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
            do
            {
                InputAnswer(wordTypeChar);
                correctscore++;
            }
            while (correctscore != 6);
        }

        static void IncorrectScore(int incorrectScore)
        {
            incorrectScore = 0;
            Console.WriteLine("Incorrect Score : "+incorrectScore);
        }

        static void InputAnswer(char[] wordTypeChar)
        {
            char Answer = char.Parse(Console.ReadLine());
            foreach(char i in wordTypeChar)
            {
                if(Answer == i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write("_ ");
                }
            }
        }
    }

    class WordsList
    {
        public string Tennis;
        public string Football;
        public string Badminton;
        public List<string> Listword;
        public WordsList(string tennis,string football,string badminton)
        {
            this.Tennis = tennis;
            this.Football = football;
            this.Badminton = badminton;
            Listword = new List<string>();
        }

        public void addlist(WordsList wordlist)
        {
            Listword.Add(Tennis);
            Listword.Add(Football);
            Listword.Add(Badminton);
        }

        public void Getlist()
        {
            Random random = new Random();
            int resultRandom = random.Next(0, 2);
            string words = Listword[resultRandom];
            Console.WriteLine(words);
        }
    }

}
