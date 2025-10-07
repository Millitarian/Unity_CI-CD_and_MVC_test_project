using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartView : MonoBehaviour, IView
{
  [SerializeField] private GameObject[] slots;
  [SerializeField] private Sprite[] sprites;

  [SerializeField] private Animator baseAnimator;
  public void display(BonusBase[,] field, int score) 
  {
    baseAnimator.SetTrigger("roll");

    var i = 0;
    foreach(var slot in field)
    {
      switch (slot._id) 
      {
        case "x3":
          slots[i].GetComponent<SpriteRenderer>().sprite = sprites[0];
          break;
        case "+10":
          slots[i].GetComponent<SpriteRenderer>().sprite = sprites[1];
          break;
        case "+100":
          slots[i].GetComponent<SpriteRenderer>().sprite = sprites[2];
          break;
        case "+300":
          slots[i].GetComponent<SpriteRenderer>().sprite = sprites[3];
          break;
      }
      i++;
    }
    Debug.Log(score);
  }
}
