using System.Collections.Generic;

public class Store
{
    public List<Card> Cards { get; set; } = new();

    public void SetOwner(Player player)
    {
        foreach (Card card in this.Cards)
        {
            card.Player = player;
        }
    }

    public void RefreshStore(AvailableCards availableCards)
    {
        this.Cards = new();
        for (int i = 0; i < 3; i++)
        {
            this.Cards.Add(availableCards.GetRandomCard());
        }
    }
    public Card Buy(int selectedCard)
    {
        var card = this.Cards[selectedCard];
        this.Cards[selectedCard] = null;
        return card;
    }
}