using System;

public class Field4x3 : FieldBase
{
  private const int rows = 3;
  private const int columns = 4;

  public Field4x3()
  {
    field = new BonusBase[columns, rows];
    random = new Random();

    bonuses = new BonusBase[] {
      new BonusMultiplier("x3", 3),
      new BonusPoints("+10", 10),
      new BonusPoints("+100", 100),
      new BonusPoints("+300", 300) };
  }


  public override void roll()
  {
    for (int i = 0; i < columns; i++)
    {
      for (int j = 0; j < rows; j++)
      {
        field[i, j] = bonuses[random.Next(0, bonuses.Length)];
      }
    }
  }
}
