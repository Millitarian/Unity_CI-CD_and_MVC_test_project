
public abstract class ControllerBase
{
  public FieldBase model;
  public IView view;

  public void game()
  {
    model?.roll();
    var score = calculateScore(model.field);
    view?.display(model.field, score);
  }
  protected abstract int calculateScore(BonusBase[,] field);
}
