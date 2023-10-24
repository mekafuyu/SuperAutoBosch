using System.Collections.Generic;

public class Game
{
    private Game() { }
    private Game curr = new Game();
    public Game Current => curr;

    public Player player = new();
    public AvailableCards availableCards = new();

}