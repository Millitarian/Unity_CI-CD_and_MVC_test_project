using System;

public abstract class FieldBase
{
  public BonusBase[,] field { get; protected set;}

  protected BonusBase[] bonuses;
  protected Random random;
  public abstract void roll();
}
