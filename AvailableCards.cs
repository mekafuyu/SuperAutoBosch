using System;
using System.Collections.Generic;

public class AvailableCards
{
    // private AvailableCards() { }
    // private AvailableCards curr = new AvailableCards();
    // public AvailableCards Current => curr;

    private List<Card> cards { get; set; }
    public void AddCard(Card card)
        => this.cards.Add(card);    

    public void AddTier(List<Card> cards)
    {
        foreach (Card card in cards)
            this.AddCard(card.Clone() as Card);
    }

    public Card GetRandomCard()
    {
        Random rnd = new Random();
        int i = rnd.Next(0, this.cards.Count);
        return cards[i];
    }

}
