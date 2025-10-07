using UnityEngine;

public class DebugView : IView
{
  public void display(BonusBase[,] field, int score) 
  {
    Debug.Log("-------------");
    foreach (var item in field) 
    {
      Debug.Log(item._id);
    }
    Debug.Log("-------------");
    Debug.Log(score);
  }
}
