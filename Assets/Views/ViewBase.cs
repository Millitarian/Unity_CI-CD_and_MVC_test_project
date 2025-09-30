using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public abstract class ViewBase : MonoBehaviour
{
  public abstract void display(BonusBase[,] field, int score);
}
