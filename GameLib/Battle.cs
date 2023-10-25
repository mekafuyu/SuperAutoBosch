public class Battle
{
    private Battle(Player player, Bot bot)
    {
        this.Player = player;
        this.Enemy = bot;
    }
    private static Battle curr = new Battle(null, null);
    public static Battle Current => curr;

    public Player Player { get; set; } = new();
    public Bot Enemy { get; set; } = null;

    public static void New(Player player, Bot bot)
        => curr = new Battle(player, bot);


}