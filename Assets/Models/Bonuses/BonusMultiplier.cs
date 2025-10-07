
public class BonusMultiplier: BonusBase
{
  private int _multiplier;
  public BonusMultiplier(string id, int multiplier) {
    _id = id;
    _multiplier = multiplier;
  }
  public override int addPoints(int points)
  {
    return points * _multiplier;
  }
}
