// See https://aka.ms/new-console-template for more information
//using LearnPackageManager;
using System.Text;
using TexasHoldem.Logic.Cards;
using TexasHoldem.Logic.Helpers;


//Temperature t1 = new Temperature(72);
/*
string flush = firstTry();
int tries = 1;
while (flush != "StraightFlush")
{
    flush = firstTry();
    tries++;
}
Console.WriteLine($"Only took {tries} tries!");
*/
static string firstTry()
{
    Deck aDeck = new Deck(); //CTR + . allows for intell-essence to offer solution
    var firstCard = aDeck.GetNextCard();
    var secondCard = aDeck.GetNextCard();
    Console.WriteLine($"Your cards are {firstCard} and {secondCard}");

    List<Card> cards = new List<Card>();
    for (int i = 0; i < 5; i++) cards.Add(aDeck.GetNextCard());

    Console.Write("The River is: ");
    foreach (Card card in cards) Console.Write(card + ", ");

    cards.Add(firstCard);
    cards.Add(secondCard);
    var result = Helpers.GetHandRank(cards);
    Console.WriteLine(result.ToString());
    return result.ToString();
}