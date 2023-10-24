using System;

public abstract class Card : ICloneable
{

    public string Name { get; set; }
    public Player Player { get; set; }
    public int Life { get; set; }
    public int Attack { get; set; }
    public int Experience { get; set; } = 1;
    public int Level { get; set; } = 1;
    public int Tier { get; set; }

    public virtual void onBuy(){}
    public virtual void onSell(){}
    public virtual void onAttack(){}
    public virtual void onReceiveDamage(){}
    public virtual void onLevelUp(){}
    public virtual void onStartTurn(){}
    public virtual void onEndTurn(){}
    public virtual void onStartBattle(){}
    public virtual void onEndBattle(){}

    public abstract object Clone();
}