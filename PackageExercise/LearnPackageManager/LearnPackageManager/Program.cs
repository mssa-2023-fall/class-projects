// See https://aka.ms/new-console-template for more information
using LearnPackageManager;
using System.Collections;
using System.Text;
using TexasHoldem.Logic.Cards;//card and deck class
using TexasHoldem.Logic.Helpers;//Helpers class
using System.Linq;
using System.Threading.Channels;
//fix UTF-8 output card symbol
Console.OutputEncoding = Encoding.UTF8;
int x = 10;
int y = x;
x = x + 1;

Temperature t2 = new Temperature(72);
Temperature t3 = t2;
t2.TempInFerenheit = 100;
Console.WriteLine(t3.TempInFerenheit);



Temperature t1 = new Temperature(72);
Console.WriteLine($"kelvin: {t1.TempInKelvin}, celcius:{t1.TempInCelcius}, ferenheit:{t1.TempInFerenheit}");
t1.TempInFerenheit = 70f;
Console.WriteLine($"kelvin: {t1.TempInKelvin}, celcius:{t1.TempInCelcius}, ferenheit:{t1.TempInFerenheit}");
// starts with a shuffled deck
Deck aDeck = new Deck();
//test if the GetNextCard work
var firstCard = aDeck.GetNextCard();
Console.WriteLine($"first card is {firstCard}");

//Prepare a List Of Card to be evaluated
IList<Card> cards = new List<Card>();
//Pull out 7 cards from the deck
for (int i = 0; i < 15; i++) {
    var newCard = aDeck.GetNextCard();//assing new card
    Console.WriteLine($"Card {i+1} is {newCard.Type} of {newCard.Suit.ToFriendlyString()}");
    //let me see the card
    cards.Add(newCard);//add it to my hand
}
//Func<T,bool>
var faceCard = cards.Where((c) => c.Suit != CardSuit.Club).OrderBy((c)=>c.Suit);

//var faceCard = from c in cards
//             where (c.Suit == CardSuit.Club || c.Suit ==CardSuit.Spade) && c.Type >= CardType.Jack
//             select c;

List<Card> result = new List<Card>(faceCard);
int test = 100;
//result.ForEach(blah); // print the result
result.ForEach((c) => Console.WriteLine(c +$"{test}")); // print the result



