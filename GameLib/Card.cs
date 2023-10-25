using System;

public abstract class Card : ICloneable
{

    public virtual string Name { get; set; }
    public virtual Player Player { get; set; }
    public virtual int Life { get; set; }
    public virtual int Attack { get; set; }
    public virtual int Experience { get; set; } = 1;
    public virtual int Level { get; set; } = 1;
    public virtual int Tier { get; set; }

    public virtual void onBuy(){}
    public virtual void onSell(){}
    public virtual void onAttack(){}
    public virtual void onReceiveDamage(){}
    public virtual void onLevelUp(){}
    public virtual void onStartTurn(){}
    public virtual void onEndTurn(){}
    public virtual void onStartBattle(Battle battle){}
    public virtual void onEndBattle(Battle battle){}

    public abstract object Clone();
    // {
    //     return new Card(){};
    // }
}