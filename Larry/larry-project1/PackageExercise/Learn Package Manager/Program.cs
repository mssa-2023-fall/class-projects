using TexasHoldem;
using System;
using TexasHoldem.Logic.GameMechanics;
using TexasHoldem.Logic.Cards;
using TexasHoldem.Logic.Helpers;

namespace LearningPackageManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck aDeck = new Deck();
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 7; i++)
            {
                var newCard = aDeck.GetNextCard();
                Console.WriteLine($"Card {i + 1} is {newCard.Type} of {newCard.Suit}");
                var result1 = newCard;
                Console.WriteLine(result1);
                Console.WriteLine();
                Helpers.GetHandRank(cards);
                
                
            }
            Console.ReadLine();





















        }
        }
    }