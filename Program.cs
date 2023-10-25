using System;
using System.Collections.Generic;
using Cards;

List<Card> Tier1 = new()
{
    new Cards.Tier1.Martelo(),
    new Cards.Tier1.ChaveFenda(),
    new Cards.Tier1.Esteira(),
};
List<Card> Tier2 = new()
{
    new Cards.Tier2.FornoIndustrialGas(),
    new Cards.Tier2.FuradeiraColuna(),
    new Cards.Tier2.RetificadaPlana(),
};
List<Card> Tier3 = new()
{
    new Cards.Tier3.FornoIndustrialEletrico(),
    new Cards.Tier3.FuradeiraCoordenada(),
    new Cards.Tier3.RetificadaCilindrica(),
};
List<Card> Tier4 = new()
{
    new Cards.Tier4.Fresa(),
    new Cards.Tier4.Torno(),
};
List<Card> Tier5 = new()
{
    new Cards.Tier5.FresaCNC(),
    new Cards.Tier5.TornoCNC(),
};
List<Card> Tier6 = new()
{
    new Cards.Tier6.CortePlamasCNC(),
};

App app = new ExampleApp(
    new Game(),
    Tier1,
    Tier2,
    Tier3,
    Tier4,
    Tier5,
    Tier6
);

app.Run();
