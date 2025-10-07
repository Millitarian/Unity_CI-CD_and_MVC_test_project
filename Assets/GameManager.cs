using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  [SerializeField] GameObject viewObj;

  private ControllerBase controller;
  private FieldBase model;
  private IView view;

  private bool canGame = true;
  private void Start()
  {
    controller = new OneLineStandartController();
    //controller = new OneLineSummController();
    //model = new Field4x3();
    model = new Field3x3();
    //view = new DebugView();
    view = viewObj.GetComponent<IView>();

    controller.model = model;
    controller.view = view;
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      if (canGame) 
      {
        StartCoroutine(gameProcess());
      }
    }
  }


  private IEnumerator gameProcess() 
  {
    canGame = false;
    controller.game();
    yield return new WaitForSeconds(2.2f);
    canGame = true;
  }
}
