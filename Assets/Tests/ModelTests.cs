using NUnit.Framework;

public class ModelTests
{
  [Test]
  public void FieldRollTestContainsBonuses() 
  {
    var testField = new Field3x3();

    testField.roll();

    foreach (BonusBase bonus in testField.bonuses)
    {
      Assert.IsNotNull(bonus);
    }
  }
}
