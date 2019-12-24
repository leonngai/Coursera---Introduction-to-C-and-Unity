using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the game called 'Nothing Like Blackjack!");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)

            //deal first card to each player
            Card card1ForPlayer1 = deck.TakeTopCard();
            Card card1ForPlayer2 = deck.TakeTopCard();
            Card card1ForPlayer3 = deck.TakeTopCard();

            //deal second card to each player
            Card card2ForPlayer1 = deck.TakeTopCard();
            Card card2ForPlayer2 = deck.TakeTopCard();
            Card card2ForPlayer3 = deck.TakeTopCard();

            // flip all the cards over for each player
            card1ForPlayer1.FlipOver();
            card1ForPlayer2.FlipOver();
            card1ForPlayer3.FlipOver();
            card2ForPlayer1.FlipOver();
            card2ForPlayer2.FlipOver();
            card2ForPlayer3.FlipOver();

            // print the cards for player
            Console.WriteLine("For Player 1:");
            Console.WriteLine("Your first card is " + card1ForPlayer1.Rank + " of " + card1ForPlayer1.Suit);
            Console.WriteLine("Your second card is " + card2ForPlayer1.Rank + " of " + card2ForPlayer1.Suit + "\n");

            // print the cards for player 2
            Console.WriteLine("For Player 2:");
            Console.WriteLine("Your first card is " + card1ForPlayer2.Rank + " of " + card1ForPlayer2.Suit);
            Console.WriteLine("Your second card is " + card2ForPlayer2.Rank + " of " + card2ForPlayer2.Suit + "\n");

            // print the cards for player 3
            Console.WriteLine("For Player 3:");
            Console.WriteLine("Your first card is " + card1ForPlayer3.Rank + " of " + card1ForPlayer3.Suit);
            Console.WriteLine("Your second card is " + card2ForPlayer3.Rank + " of " + card2ForPlayer3.Suit + "\n");

            Console.WriteLine();
        }
    }
}
