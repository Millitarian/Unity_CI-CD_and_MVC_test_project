public class OneLineStandartController : ControllerBase
{
  protected override int calculateScore(BonusBase[,] field)
  {
    var score = 100;
    int columns = field.GetLength(0);    // количество столбцов
    int rows = field.GetLength(1);        // количество строк
    int calculatedLineIndex = rows / 2;

    score = field[0, calculatedLineIndex].addPoints(score);

    for (int i = 1; i < columns; i++)
    {
      if (field[i-1, calculatedLineIndex]._id == field[i, calculatedLineIndex]._id) 
      {
        score = field[i, calculatedLineIndex].addPoints(score);
      } else 
      {
        return 0;
      }
    }
    return score;
  }
}
