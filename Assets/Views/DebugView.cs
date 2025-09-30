using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugView : ViewBase
{
  public override void display(BonusBase[,] field, int score) 
  {
    foreach (var item in field) 
    {
      Debug.Log(item._id);
    }
    Debug.Log("-------------");
    Debug.Log(score);
  }
}
