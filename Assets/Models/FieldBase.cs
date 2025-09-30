
public abstract class FieldBase
{
  protected BonusBase[] bonuses;
  public BonusBase[,] field { get; protected set;}
  public abstract void roll();
}
