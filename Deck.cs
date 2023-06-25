
namespace DeckNamespace
{
   // See https://aka.ms/new-console-template for more information
   public enum Suit
   {
       Clubs,
       Diamonds,
       Hearts,
       Spades
   }
   
   public enum Rank
   {
       Two,
       Three,
       Four,
       Five,
       Six,
       Seven,
       Eight,
       Nine,
       Ten,
       Jack,
       Queen,
       King,
       Ace
   }
   
   public class Card
   {
       public Suit Suit { get; }
       public Rank Rank { get; }
   
       public Card(Suit s, Rank r)
       {
           Suit = s;
           Rank = r;
       }
       
       public override string ToString() => $"{Rank} of {Suit}";
   }
   
   public class Deck
   {
       static IEnumerable<Suit> Suits() => Enum.GetValues(typeof(Suit)) as IEnumerable<Suit>;
       static IEnumerable<Rank> Ranks() => Enum.GetValues(typeof(Rank)) as IEnumerable<Rank>;
       private List<Card> cards;
       
       public Deck()
       {
           var sequence = from s in Suits()
               from r in Ranks()
               select new Card(s, r);
           cards = new List<Card>(sequence);
       }
       public Deck(IEnumerable<Card> cards) => this.cards = new List<Card>(cards);
   
       public IEnumerable<Card> Cards => cards;
   }
   
   public class Functions
   {
       public static Deck Shuffle(Deck deck)
       {
           Random r = new Random();
           var shuffledCards = deck.Cards.OrderBy(card => r.Next()).ToList();
           var newDeck = new Deck(shuffledCards);
           return newDeck;
       }
   } 
}