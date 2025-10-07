
public abstract class ControllerBase
{
  public FieldBase model;
  public IView view;

  public void game()
  {
    model.roll();
    view.display(model.field, calculateScore(model.field));
  }
  protected abstract int calculateScore(BonusBase[,] field);
}
