using NUnit.Framework;


public class ControllerTests: OneLineStandartController
{
  private BonusBase[] bonuses = {
      new BonusMultiplier("x3", 3),
      new BonusPoints("+10", 10),
      new BonusPoints("+100", 100),
      new BonusPoints("+300", 300) };

  [Test]
  public void ControllerCalculateTestWin1()
  {
    var field = new BonusBase[,]
    { { bonuses[0], bonuses[1], bonuses[0] },
    { bonuses[0], bonuses[1], bonuses[0] },
    { bonuses[0], bonuses[1], bonuses[0] } };

    var score = calculateScore(field);
      
    Assert.AreEqual(130, score);
  }

  [Test]
  public void ControllerCalculateTestWin2() 
  {
    var field = new BonusBase[,]
    { { bonuses[0], bonuses[0], bonuses[0] },
    { bonuses[0], bonuses[0], bonuses[0] },
    { bonuses[0], bonuses[0], bonuses[0] } };

    var score = calculateScore(field);

    Assert.AreEqual(2700, score);
  }

  [Test]
  public void ControllerCalculateTestWin3() 
  {
    var field = new BonusBase[,]
    { { bonuses[0], bonuses[2], bonuses[0] },
    { bonuses[0], bonuses[2], bonuses[0] },
    { bonuses[0], bonuses[2], bonuses[0] } };

    var score = calculateScore(field);

    Assert.AreEqual(400, score);
  }

  [Test]
  public void ControllerCalculateTestWin4() 
  {
    var field = new BonusBase[,]
    { { bonuses[0], bonuses[3], bonuses[0] },
    { bonuses[0], bonuses[3], bonuses[0] },
    { bonuses[0], bonuses[3], bonuses[0] } };

    var score = calculateScore(field);

    Assert.AreEqual(1000, score);
  }

  [Test]
  public void ControllerCalculateTestLose() 
  {
    var field = new BonusBase[,]
    { { bonuses[0], bonuses[0], bonuses[0] },
    { bonuses[0], bonuses[1], bonuses[0] },
    { bonuses[0], bonuses[3], bonuses[0] } };

    var score = calculateScore(field);

    Assert.AreEqual(0, score);
  }
}
