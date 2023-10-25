namespace Cards.Tier4;

public class Fresa : Card
{
    public override string Name { get; set; } = "Fresa";
    public override int Attack { get; set; } = 4;
    public override int Life { get; set; } = 5;
    public override int Tier { get; set; } = 4; 

    public override object Clone()
    {
        return new Fresa()
        {
            Name = this.Name,
            Attack = this.Attack,
            Life = this.Life,
            Experience = this.Experience,
            Level = this.Level,
            Tier = this.Tier
        };
    }
}

public class Torno : Card
{
    public override string Name { get; set; } = "Torno";
    public override int Attack { get; set; } = 5;
    public override int Life { get; set; } = 3;
    public override int Tier { get; set; } = 4; 

    public override void onEndTurn()
    {
        foreach (var card in Player.Cards)
        {
            if(card.Level == 3)
            {
                this.Attack += 2;
                this.Life += 2;
            }
        }
    }

    public override object Clone()
    {
        return new Torno()
        {
            Name = this.Name,
            Attack = this.Attack,
            Life = this.Life,
            Experience = this.Experience,
            Level = this.Level,
            Tier = this.Tier
        };
    }
}