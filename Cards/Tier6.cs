namespace Cards.Tier6;

public class CortePlamasCNC : Card
{
    public override string Name { get; set; } = "Corte a Plamas CNC";
    public override int Attack { get; set; } = 6;
    public override int Life { get; set; } = 8;
    public override int Tier { get; set; } = 6; 

    public override object Clone()
    {
        return new CortePlamasCNC()
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