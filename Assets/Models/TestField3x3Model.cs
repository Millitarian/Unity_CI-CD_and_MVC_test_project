public class TestField3x3Model
{
  private Field3x3 testField;

  public bool test()
  {
    testField = new Field3x3();

    testField.roll();

    foreach (BonusBase bonus in testField.field) 
    {
      if (bonus == null) 
      {
        return false;
      }
    }

    return true;
  }

  public bool test2() 
  {
    testField = new Field3x3();

    testField.roll();

    foreach (BonusBase bonus in testField.bonuses)
    {
      if (bonus == null)
      {
        return false;
      }
    }
    return true;
  }
}
