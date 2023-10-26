using System.Collections.Generic;
public class Player
{
    public int gold { get; set; } = 15;
    public int life { get; set; } = 5;
    public Card[] Cards { get; set; } = new Card[5];
    public Store Store { get; set; } = new();


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

        this.RemoveGold(3);
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

    public List<Card> RefreshStore(Player player, AvailableCards availableCards, bool free)
    {
        if(this.gold < 1)
            return this.Store.Cards;
        if(!free)
            this.RemoveGold(1);
        this.Store.RefreshStore(availableCards);
        this.Store.SetOwner(player);
        return this.Store.Cards;
    }

    public void GiveGold(int gold)
        => this.gold += gold;
    public void RemoveGold(int gold)
        {
            if(this.gold <= 0)
                return;
            this.gold -= gold;
        }
}