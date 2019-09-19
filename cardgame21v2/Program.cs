using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame21vStr
{
    struct Game
    {
        public int index;
        public int[] cards;
        public int PointsPlayer1;
        public int PointsPlayer2;
        public string MorePlayer1;
        public int a;
        public string enter;
        public void Mixing()
        {
            Random random = new Random();
            for (int i = cards.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
        }
        public void Take(int a)
        {
            while(enter != "1")
            {
                Console.WriteLine("OK - 1");
                enter = Console.ReadLine();
            }
            if(index < 32)
            {
                int temporary = cards[index];
                index++;
                temporary += cards[index];
                index++;
                if(a == 0)
                {
                    PointsPlayer1 = temporary;
                    Console.WriteLine($"Your summa = {PointsPlayer1} of 21 ");
                }
                else
                {
                    PointsPlayer2 = temporary;
                }
            }
        }
        public void More(int a)
        {
            if(a == 0 && index < 35)
            {
                while (MorePlayer1 == "1" && PointsPlayer1 < 21)
                {
                    while (MorePlayer1 != "1" || MorePlayer1 != "2")
                    {
                        Console.WriteLine("Do you want take more?");
                        Console.WriteLine("Yes - 1 / No - 2");
                        MorePlayer1 = Console.ReadLine();
                        if (MorePlayer1 == "1" || MorePlayer1 == "2")
                        {
                            break;
                        }
                    }
                    if (MorePlayer1 == "1")
                    {
                        PointsPlayer1 += cards[index];
                        index++;
                        if (PointsPlayer1 > 21)
                        {
                            Console.WriteLine($"You took card, your summa = {PointsPlayer1}");
                            Console.WriteLine("You have more than 21, you lose!");
                            break;
                        }
                        if (PointsPlayer1 == 21)
                        {
                            break;
                        }
                        Console.WriteLine($"You took card, your summa = {PointsPlayer1}");
                    }
                }
            }
            else if(a == 1 && index < 35)
            {
                while (PointsPlayer2 < 16 && index < 35)
                {
                    PointsPlayer2 += cards[index];
                    index++;
                    if (PointsPlayer2 > 21)
                    {
                        Console.WriteLine($"Computer took card, his summa = {PointsPlayer2}");
                        Console.WriteLine("Computer have more than 21, VICTORY!!!");
                        break;
                    }
                    if (PointsPlayer2 == 21)
                    {
                        break;
                    }
                }
            }
        }
        public void Comparison()
        {
            if ((PointsPlayer1 > PointsPlayer2 && PointsPlayer1 < 21)|| PointsPlayer1 == 21)
            {
                Console.WriteLine($"You have {PointsPlayer1} points, computer have {PointsPlayer2} points.");
                Console.WriteLine("VICTORY!!!");
            }
            else if ((PointsPlayer2 > PointsPlayer1 && PointsPlayer2 < 21)|| PointsPlayer2 == 21)
            {
                Console.WriteLine($"You have {PointsPlayer1} points, computer have {PointsPlayer2} points.");
                Console.WriteLine("You LOSE!!!");
            }
            else if (PointsPlayer1 == 21 && PointsPlayer2 == 21)
            {
                Console.WriteLine("DRAW!!!");
            }
        }
        public void Random()
        {
            Random random = new Random();
            a = (random.Next(0, 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game BJ = new Game();
            BJ.index = 0;
            BJ.cards = new int[36] { 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 11, 11, 11, 11 };
            BJ.PointsPlayer1 = 0;
            BJ.PointsPlayer2 = 0;
            BJ.Mixing();
            string NewGame = "1";
            
            while (NewGame == "1" && BJ.index < 32)
            {
                BJ.Random();

                if (BJ.a == 0)
                {

                    Console.WriteLine("You take cards first");
                    BJ.Take(0);
                    BJ.Take(1);
                    BJ.MorePlayer1 = "1";
                    BJ.More(0);
                    BJ.More(1);
                    BJ.Comparison();
                }
                else
                {
                    Console.WriteLine("Computer take cards first");
                    BJ.Take(1);
                    BJ.Take(0);
                    BJ.More(1);
                    BJ.MorePlayer1 = "1";
                    BJ.More(0);
                    BJ.Comparison();
                }
                if(BJ.index == 35)
                {
                    Console.WriteLine("Deck is over");
                }
                BJ.PointsPlayer1 = 0;
                BJ.PointsPlayer2 = 0;
                while (NewGame != "1" || NewGame != "2" || BJ.index != 35)
                {
                    Console.WriteLine("Do you want start new game?");
                    Console.WriteLine("Yes - 1 / No - 2");
                    NewGame = Console.ReadLine();
                    if (NewGame == "1" || NewGame == "2" || BJ.index == 35)
                    {
                        break;
                    }
                }
            }
        }
    }
}