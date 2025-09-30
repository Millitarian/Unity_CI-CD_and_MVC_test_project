using UnityEngine;

public class Field3x3 : FieldBase
{
  private const int rows = 3;
  private const int columns = 3;

  public Field3x3() 
  {
    field = new BonusBase[rows, columns];

    bonuses = new BonusBase[] { 
      new BonusMultiplier("x3", 3),
      new BonusPoints("+10", 10),
      new BonusPoints("+100", 100),
      new BonusPoints("+300", 300) };
  }


  public override void roll() 
  {
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        field[i, j] = bonuses[Random.RandomRange(0, bonuses.Length)];
        Debug.Log(field[i, j]._id);
      }
    }
  }
}
