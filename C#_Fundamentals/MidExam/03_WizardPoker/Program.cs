using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine()
                 .Split(':')
                 .ToList();
            List<string> myDeck = new List<string>();
            string line = Console.ReadLine();

            while (line != "Ready")
            {
                string[] lines = line.Split();
                string command = lines[0];
                if (command == "Add")
                {
                    string card = lines[1];
                    if (deck.Contains(card))
                    {
                        myDeck.Add(card);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Insert")
                {
                    string card = lines[1];
                    int index = int.Parse(lines[2]);
                    if (deck.Contains(card)
                        &&index>=0
                        &&index<myDeck.Count
                        &&index<deck.Count)
                    {
                        myDeck.Insert(index, card);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (line== "Shuffle deck")
                {
                    myDeck.Reverse();
                }
                else if (command == "Remove")
                {
                    string card = lines[1];
                    if (myDeck.Contains(card))
                    {
                        myDeck.Remove(card);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Swap")
                {
                    string firstCard = lines[1];
                    string secondCard = lines[2];
                  int indexOne = myDeck.IndexOf(firstCard);
                  int indexTwo = myDeck.IndexOf(secondCard);
                    string curent = myDeck[indexOne];
                    myDeck[indexOne] = myDeck[indexTwo];
                    myDeck[indexTwo] = curent;

                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",myDeck));
        }
    }
}
