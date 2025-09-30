
public class BonusPoints : BonusBase
{
  private int _points;

  public BonusPoints(string id, int points)
  {
    _id = id;
    _points = points;
  }

  public override int addPoints(int points)
  {
    return points + _points;
  }
}
