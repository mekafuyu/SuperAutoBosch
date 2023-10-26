using System;
using System.Collections.Generic;

public class AvailableCards
{
    private List<Card> cards { get; set; } = new();
    public void AddCard(Card card)
        => this.cards.Add(card.Clone() as Card);    

    public void AddCards(List<Card> cards)
    {
        foreach (var card in cards)
            this.cards.Add(card.Clone() as Card);
    }

    public Card GetRandomCard()
    {
        Random rnd = new Random();
        int i = rnd.Next(0, this.cards.Count);
        var card = cards[i].Clone() as Card;
        return card;
    }

}
