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
            int index = 0;
            Random random = new Random();
            for (int i = cards.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = cards[j];
                cards[j] = cards[i];
                cards[i] = temp;
            }
            string NewGame = "1";
            Random Player = new Random();
            while (NewGame == "1")
            {
                var a = (Player.Next(0, 2));
                if (a == 0)
                {
                    int PointsPlayer1 = 0;
                    int PointsPlayer2 = 0;
                    Console.WriteLine("You take cards first");
                    Console.ReadKey();
                    int q = cards[index];
                    index++;
                    int w = cards[index];
                    index++;
                    PointsPlayer1 = q + w;
                    Console.WriteLine($"You took {q} and {w}, your summa = {PointsPlayer1} of 21 ");
                    int e = cards[index];
                    index++;
                    int r = cards[index];
                    index++;
                    PointsPlayer2 = e + r;
                    Console.WriteLine("Computer took cards too");
                    if (PointsPlayer1 == 21)
                    {
                        Console.WriteLine("You took 21 points, you won!");
                    }
                    if (PointsPlayer2 == 21)
                    {
                        Console.WriteLine("Computer took 21 points, you lose!");
                    }
                    if (PointsPlayer1 == 21 && PointsPlayer2 == 21)
                    {
                        Console.WriteLine("DRAW!!!");
                    }
                    Console.ReadKey();
                    string MorePlayer1 = "1";
                    while (MorePlayer1 == "1" && PointsPlayer1 < 21)
                    {
                        Console.WriteLine("Do you want take more?");
                        Console.WriteLine("Yes - 1 / No -click something");
                        MorePlayer1 = Console.ReadLine();
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
                    while (PointsPlayer2 < 16)
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
                    if (PointsPlayer1 > PointsPlayer2 && PointsPlayer1 <= 21)
                    {
                        Console.WriteLine($"You have {PointsPlayer1} points, computer have {PointsPlayer2} points.");
                        Console.WriteLine("VICTORY!!!");
                    }
                    else if (PointsPlayer2 > PointsPlayer1 && PointsPlayer2 <= 21)
                    {
                        Console.WriteLine($"You have {PointsPlayer1} points, computer have {PointsPlayer2} points.");
                        Console.WriteLine("You LOSE!!!");
                    }
                }
                else
                {
                    int PointsPlayer1 = 0;
                    int PointsPlayer2 = 0;
                    Console.WriteLine("Computer take cards first");
                    Console.ReadKey();
                    int e = cards[index];
                    index++;
                    int r = cards[index];
                    index++;
                    PointsPlayer2 = e + r;
                    Console.WriteLine("Computer took cards");
                    int q = cards[index];
                    index++;
                    int w = cards[index];
                    index++;
                    PointsPlayer1 = q + w;
                    Console.WriteLine($"You took {q} and {w}, your summa = {PointsPlayer1} of 21 ");
                    if (PointsPlayer2 == 21)
                    {
                        Console.WriteLine("Computer took 21 points, you lose!");
                    }
                    if (PointsPlayer1 == 21)
                    {
                        Console.WriteLine("You took 21 points, you won!");
                    }
                    if (PointsPlayer2 == 21 && PointsPlayer1 == 21)
                    {
                        Console.WriteLine("DRAW!!!");
                    }
                    Console.ReadKey();
                    while (21 - PointsPlayer2 > 6)
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
                    string MorePlayer1 = "1";
                    while (MorePlayer1 == "1" && PointsPlayer1 < 21)
                    {
                        Console.WriteLine("Do you want take more?");
                        Console.WriteLine("Yes - 1 / No -click something");
                        MorePlayer1 = Console.ReadLine();
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
                    if (PointsPlayer2 > PointsPlayer1 && PointsPlayer2 < 21)
                    {
                        Console.WriteLine($"You have {PointsPlayer1} points, computer have {PointsPlayer2} points.");
                        Console.WriteLine("You LOSE!!!");
                    }
                    else if (PointsPlayer1 > PointsPlayer2 && PointsPlayer1 < 21)
                    {
                        Console.WriteLine($"You have {PointsPlayer1} points, computer have {PointsPlayer2} points.");
                        Console.WriteLine("VICTORY!!!");
                    }
                }
                Console.WriteLine("Do you want start new game?");
                Console.WriteLine("1 - Yes / 2 - No");
                NewGame = Console.ReadLine();
            }
        }
    }
}
