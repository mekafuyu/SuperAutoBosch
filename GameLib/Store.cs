using System.Collections.Generic;

public class Store
{
    public Card[] Cards { get; set; } = new Card[3];

    public void RefreshStore(AvailableCards availableCards)
    {
        for (int i = 0; i < 3; i++)
            this.Cards[i] = availableCards.GetRandomCard();
    }
    public Card Buy(int selectedCard)
    {
        var card = this.Cards[selectedCard];
        this.Cards[selectedCard] = null;
        return card;
    }
}