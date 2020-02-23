using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _02_BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            int n = int.Parse(Console.ReadLine());
            var field = new char[n][];
            var word = new Stack<char>(input);
            int playerRow = -1;
            int playerCol = -1;
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().ToCharArray();
                
                if (playerRow == -1)
                {
                    for (int j = 0; j < row.Length; j++)
                    {

                        if (row[j] == 'P')
                        {
                            playerRow = i;
                            playerCol = j;
                            break;
                        }
                    }
                }
                field[i] = row;
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                if (command == "down")
                {
                    if (playerRow + 1 < n)
                    {
                        playerRow++;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow - 1][playerCol] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        playerRow--;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }
                        field[playerRow][playerCol] = 'P';
                        field[playerRow + 1][playerCol] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 < n)
                    {
                        playerCol++;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }

                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol - 1] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
                else if (command == "left")
                {

                    if (playerCol - 1 >= 0)
                    {
                        playerCol--;
                        char symbol = field[playerRow][playerCol];
                        if (char.IsLetter(symbol))
                        {
                            word.Push(symbol);
                        }
                        field[playerRow][playerCol] = 'P';
                        field[playerRow][playerCol + 1] = '-';
                    }
                    else
                    {
                        Punish(word);
                    }
                }
            }

            Console.WriteLine(string.Join("", word.Reverse()));
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{field[i][j]}");
                }

                Console.WriteLine();
            }


        }

        private static void Punish(Stack<char> player)
        {
            if (player.Count > 0)
            {
                player.Pop();
            }
        }


    }
}