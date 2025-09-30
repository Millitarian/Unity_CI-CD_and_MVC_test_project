public class OneLineSummController : ControllerBase
{ 
  protected override int calculateScore(BonusBase[,] field)
  {
    int score = 0;

    int rows = field.GetUpperBound(0) + 1;    // ���������� �����
    int columns = field.Length / rows;        // ���������� ��������
    int calculatedLineIndex = rows / 2;

    for (int i = 0; i < columns; i++)
    {
      score = field[i, calculatedLineIndex].addPoints(score);
    }
    return score;
  }
}
