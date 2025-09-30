public class OneLineStandartController : ControllerBase
{
  protected override int calculateScore(BonusBase[,] field)
  {
    var score = 100;
    int rows = field.GetUpperBound(0) + 1;    // количество строк
    int columns = field.Length / rows;        // количество столбцов
    int calculatedLineIndex = rows / 2;

    if (field[0, 1]._id == field[1, 1]._id && field[1, 1]._id == field[2, 1]._id)
    {
      score = field[0, 1].addPoints(score);
      score = field[1, 1].addPoints(score);
      score = field[2, 1].addPoints(score);
    }
    else
    {
      score = 0;
    }
    return score;
  }
}
