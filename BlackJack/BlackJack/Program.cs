using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Deck deck = new Deck();
                Hand playerHand = new Hand();
                string input = string.Empty;

                Console.WriteLine("Welcome to Black Jack");
                Console.WriteLine("Your cards are the following:");
                playerHand.Cards.Add(deck.DrawCard());
                playerHand.Cards.Add(deck.DrawCard());
                Console.WriteLine(playerHand.ToString());
                Console.WriteLine(playerHand.EvaluateHand());

                Console.WriteLine("Hit or stay? (h/s)");
                input = Console.ReadLine();
                if (input.ToLower() == "h")
                {
                    playerHand.Cards.Add(deck.DrawCard());
                    Console.WriteLine(playerHand.ToString());
                    Console.WriteLine(playerHand.EvaluateHand());
                }
                else
                {
                    Console.WriteLine($"You stayed. Your score was {playerHand.EvaluateHand()}.");
                }
            }

            Console.ReadKey();
        }
    }
}
