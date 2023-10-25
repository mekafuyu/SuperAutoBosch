namespace Cards.Tier3;

public class FornoIndustrialEletrico : Card
{
    public override string Name { get; set; } = "Forno Industrial Elétrico";
    public override int Attack { get; set; } = 4;
    public override int Life { get; set; } = 3;
    public override int Tier { get; set; } = 3; 

    public override object Clone()
    {
        return new FornoIndustrialEletrico()
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

public class FuradeiraCoordenada : Card
{
    public override string Name { get; set; } = "Furadeira de Coordenada";
    public override int Attack { get; set; } = 3;
    public override int Life { get; set; } = 5;
    public override int Tier { get; set; } = 3; 

    public virtual void onReceiveDamage(Battle battle)
    {
        if(Player.life > 0)
        {
            battle.Enemy.life -= this.Attack;
        }
    }

    public override object Clone()
    {
        return new FuradeiraCoordenada()
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

public class RetificadaCilindrica : Card
{
    public override string Name { get; set; } = "Retíficada Cilindrica";
    public override int Attack { get; set; } = 2;
    public override int Life { get; set; } = 6;
    public override int Tier { get; set; } = 3; 

    public override object Clone()
    {
        return new RetificadaCilindrica()
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