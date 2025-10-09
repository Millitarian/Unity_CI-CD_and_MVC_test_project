using UnityEngine.UIElements;

public class TestOneLineStandartController: OneLineStandartController
{
  private BonusBase[] bonuses = {
      new BonusMultiplier("x3", 3),
      new BonusPoints("+10", 10),
      new BonusPoints("+100", 100),
      new BonusPoints("+300", 300) };

  private BonusBase[,] field;

public bool test() 
  {
    field = new BonusBase[,] 
    { { bonuses[0], bonuses[0], bonuses[0] }, 
    { bonuses[0], bonuses[0], bonuses[0] }, 
    { bonuses[0], bonuses[0], bonuses[0] } };

    var score = calculateScore(field);

    if (score == 2700) 
    {
      return true;
    } else 
    {
      return false;
    }
  }

  public bool test1()
  {
    field = new BonusBase[,]
    { { bonuses[0], bonuses[1], bonuses[0] },
    { bonuses[0], bonuses[1], bonuses[0] },
    { bonuses[0], bonuses[1], bonuses[0] } };

    var score = calculateScore(field);

    if (score == 130)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool test2()
  {
    field = new BonusBase[,]
    { { bonuses[0], bonuses[2], bonuses[0] },
    { bonuses[0], bonuses[2], bonuses[0] },
    { bonuses[0], bonuses[2], bonuses[0] } };

    var score = calculateScore(field);

    if (score == 400)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool test3()
  {
    field = new BonusBase[,]
    { { bonuses[0], bonuses[3], bonuses[0] },
    { bonuses[0], bonuses[3], bonuses[0] },
    { bonuses[0], bonuses[3], bonuses[0] } };

    var score = calculateScore(field);

    if (score == 1000)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool test4()
  {
    field = new BonusBase[,]
    { { bonuses[0], bonuses[0], bonuses[0] },
    { bonuses[0], bonuses[1], bonuses[0] },
    { bonuses[0], bonuses[3], bonuses[0] } };

    var score = calculateScore(field);

    if (score == 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
