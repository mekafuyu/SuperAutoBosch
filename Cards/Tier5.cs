namespace Cards.Tier5;

public class FresaCNC : Card
{
    public override string Name { get; set; } = "Fresa CNC";
    public override int Attack { get; set; } = 8;
    public override int Life { get; set; } = 4;
    public override int Tier { get; set; } = 5; 

    public override object Clone()
    {
        return new FresaCNC()
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

public class TornoCNC : Card
{
    public override string Name { get; set; } = "Torno CNC";
    public override int Attack { get; set; } = 5;
    public override int Life { get; set; } = 8;
    public override int Tier { get; set; } = 5;

    public override object Clone()
    {
        return new TornoCNC()
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