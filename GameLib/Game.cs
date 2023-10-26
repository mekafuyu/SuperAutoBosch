using System.Collections.Generic;

public class Game
{
    public AvailableCards AvailableCards = new();
    public Player Player = new();
    public List<Card> RefreshPlayerStore(bool free) 
        => this.Player.RefreshStore(this.Player, this.AvailableCards, free);
}