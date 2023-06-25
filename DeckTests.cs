using DeckNamespace;
using NUnit.Framework;

[TestFixture]
public class ShuffleTests
{
    private Deck deck;

    [SetUp]
    public void Setup()
    {
        deck = new Deck();
    }

    [Test]
    public void Shuffle_ShufflesDeck()
    {
        // Act
        Functions.Shuffle(deck);

        // Assert
        CollectionAssert.AreNotEqual(deck.Cards, new Deck().Cards);
    }

    [Test]
    public void Shuffle_EachCardAppearsOnce()
    {
        // Act
        Functions.Shuffle(deck);
    
        // Assert
        var distinctCards = deck.Cards.Distinct();
        Assert.AreEqual(deck.Cards.Count(), distinctCards.Count());
    }
}
