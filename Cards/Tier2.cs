namespace Cards.Tier2;

public class FornoIndustrialGas : Card
{
    public override string Name { get; set; } = "Forno Industrial a Gás";
    public override int Attack { get; set; } = 1;
    public override int Life { get; set; } = 3;
    public override int Tier { get; set; } = 2; 

    public override void onStartTurn()
    {
        this.Player.GiveGold(1);
    }

    public override object Clone()
    {
        return new FornoIndustrialGas()
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

public class FuradeiraColuna : Card
{
    public override string Name { get; set; } = "Furadeira de Coluna";
    public override int Attack { get; set; } = 3;
    public override int Life { get; set; } = 4;
    public override int Tier { get; set; } = 2; 

    public override object Clone()
    {
        return new FuradeiraColuna()
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

public class RetificadaPlana : Card
{
    public override string Name { get; set; } = "Retíficada Plana";
    public override int Attack { get; set; } = 4;
    public override int Life { get; set; } = 2;
    public override int Tier { get; set; } = 2; 


    public override object Clone()
    {
        return new RetificadaPlana()
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
