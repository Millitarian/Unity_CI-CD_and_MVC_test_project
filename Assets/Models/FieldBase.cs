using System;

public abstract class FieldBase
{
  public BonusBase[,] field { get; protected set;}
  public BonusBase[] bonuses { get; protected set;}

  protected Random random;
  public abstract void roll();
}
