public class OneLineSummController : ControllerBase
{ 
  protected override int calculateScore(BonusBase[,] field)
  {
    int score = 0;

    int columns = field.GetLength(0);    // количество столбцов
    int rows = field.GetLength(1);        // количество строк
    int calculatedLineIndex = rows / 2;

    for (int i = 0; i < columns; i++)
    {
      score = field[i, calculatedLineIndex].addPoints(score);
    }
    return score;
  }
}
