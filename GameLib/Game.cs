using System.Collections.Generic;

public class Game
{
    public AvailableCards availableCards = new();
    public Player player = new();
    public Card[] RefreshPlayerStore() { 
        this.player.Store.RefreshStore(availableCards);
        return this.player.Store.Cards;
    }
}