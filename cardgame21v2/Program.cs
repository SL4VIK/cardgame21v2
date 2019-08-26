using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame21v2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int b = 36;
            int[] cards = new int[b] { 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 11, 11, 11, 11 };
            int index;
            Random random = new Random();
            for (int i = cards.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
            string NewGame = "1";
            while(NewGame == "1")
            {
                Random NumPlayer = new Random();
                var a = (NumPlayer.Next(0, 2));
                if (a == 0)
                {
                    int summChelovek = 0;
                    int summComputer = 0;
                    Console.WriteLine("You take cards first");
                    Console.ReadKey();
                    summChelovek = cards[0] + cards[1];
                    Console.WriteLine($"You took {cards[0]} and {cards[1]}, your summa = {summChelovek} of 21 ");
                    summComputer = cards[2] + cards[3];
                    index = 4;
                    Console.WriteLine("Computer took cards too");
                    if (summChelovek == 21)
                    {
                        Console.WriteLine("You took 21 points, you won!");
                    }
                    if (summComputer == 21)
                    {
                        Console.WriteLine("Mashina took 21 points, you lose!");
                    }
                    if (summChelovek == 21 && summComputer == 21)
                    {
                        Console.WriteLine("DRAW!!!");
                    }
                    Console.ReadKey();
                    string MoreChelovek = "1";
                    while (MoreChelovek == "1" && summChelovek < 21)
                    {
                        Console.WriteLine("Do you want take more?");
                        Console.WriteLine("1 - Yes / 2 - No");
                        MoreChelovek = Console.ReadLine();
                        if (MoreChelovek == "1")
                        {
                            summChelovek += cards[index];
                            index++;
                            if (summChelovek > 21)
                            {
                                Console.WriteLine($"You took card, your summa = {summChelovek}");
                                Console.WriteLine("You have more than 21, you lose!");
                                break;
                            }
                            if (summChelovek == 21)
                            {
                                break;
                            }
                            Console.WriteLine($"You took card, your summa = {summChelovek}");
                        }

                    }
                    while (21 - summComputer > 6)
                    {
                        summComputer += cards[index];
                        index++;
                        if (summComputer > 21)
                        {
                            Console.WriteLine($"Computer took card, his summa = {summComputer}");
                            Console.WriteLine("Computer have more than 21, VICTORY!!!");
                            break;
                        }
                        if (summComputer == 21)
                        {
                            break;
                        }
                    }
                    if (summChelovek > summComputer && summChelovek <= 21)
                    {
                        Console.WriteLine($"You have {summChelovek} points, computer have {summComputer} pionts.");
                        Console.WriteLine("VICTORY!!!");
                    }
                    else if (summComputer > summChelovek && summComputer <= 21)
                    {
                        Console.WriteLine($"You have {summChelovek} points, computer have {summComputer} pionts.");
                        Console.WriteLine("You LOSE!!!");
                    }
                }
                else
                {
                    int summChelovek = 0;
                    int summComputer = 0;
                    Console.WriteLine("Computer take cards first");
                    Console.ReadKey();
                    summComputer = cards[0] + cards[1];
                    Console.WriteLine("Computer took cards");
                    summChelovek = cards[2] + cards[3];
                    index = 4;
                    Console.WriteLine($"You took {cards[2]} and {cards[3]}, your summa = {summChelovek} of 21 ");
                    if (summComputer == 21)
                    {
                        Console.WriteLine("Mashina took 21 points, you lose!");
                    }
                    if (summChelovek == 21)
                    {
                        Console.WriteLine("You took 21 points, you won!");
                    }
                    if (summComputer == 21 && summChelovek == 21)
                    {
                        Console.WriteLine("DRAW!!!");
                    }
                    Console.ReadKey();
                    while (21 - summComputer > 6)
                    {
                        summComputer += cards[index];
                        index++;
                        if (summComputer > 21)
                        {
                            Console.WriteLine($"Computer took card, his summa = {summComputer}");
                            Console.WriteLine("Computer have more than 21, VICTORY!!!");
                            break;
                        }
                        if (summComputer == 21)
                        {
                            break;
                        }
                    }
                    string MoreChelovek = "1";
                    while (MoreChelovek == "1" && summChelovek < 21)
                    {
                        Console.WriteLine("Do you want take more?");
                        Console.WriteLine("1 - Yes / 2 - No");
                        MoreChelovek = Console.ReadLine();
                        if (MoreChelovek == "1")
                        {
                            summChelovek += cards[index];
                            index++;
                            if (summChelovek > 21)
                            {
                                Console.WriteLine($"You took card, your summa = {summChelovek}");
                                Console.WriteLine("You have more than 21, you lose!");
                                break;
                            }
                            if (summChelovek == 21)
                            {
                                break;
                            }
                            Console.WriteLine($"You took card, your summa = {summChelovek}");
                        }

                    }
                    if (summComputer > summChelovek && summComputer < 21)
                    {
                        Console.WriteLine($"You have {summChelovek} points, computer have {summComputer} pionts.");
                        Console.WriteLine("You LOSE!!!");
                    }
                    else if (summChelovek > summComputer && summChelovek < 21)
                    {
                        Console.WriteLine($"You have {summChelovek} points, computer have {summComputer} pionts.");
                        Console.WriteLine("VICTORY!!!");
                    }
                }
                Console.WriteLine("Do you want to start new game?");
                Console.WriteLine("1 - Yes / 2 - No");
                NewGame = Console.ReadLine();
            }
            if (NewGame == "2")
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
