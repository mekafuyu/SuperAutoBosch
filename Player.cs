using System.Collections.Generic;
public class Player
{
    private int gold { get; set; } = 10;
    private int life { get; set; } = 5;
    public Card[] Cards { get; set; } = new Card[5];
    public Store Store { get; set; }

    public void Buy(int item)
    {
        if(gold < 3)
            return;
            
        int pos = -1;
        for (int i = 0; i < 5; i++)
            if (this.Cards[i] is null)
            {
                pos = i;
                break;
            }
        if(pos == -1)
            return;

        this.gold -= 3;
        this.Cards[pos] = this.Store.Buy(item);
        this.Cards[pos].Player = this;
        this.Cards[pos].onBuy();
    }

    public void Sell(int selectedCard)
    {
        this.gold += this.Cards[selectedCard].Level;
        this.Cards[selectedCard].onSell();
        this.Cards[selectedCard] = null;
    }
}