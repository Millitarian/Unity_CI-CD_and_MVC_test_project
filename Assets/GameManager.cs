using UnityEngine;

public class GameManager : MonoBehaviour
{
  ControllerBase controller;
  FieldBase model;
  ViewBase view;
  private void Start()
  {
    controller = new OneLineSummController();
    model = new Field3x3();
    view = new DebugView();

    controller.model = model;
    controller.view = view;
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      controller.game();
    }
  }
}
