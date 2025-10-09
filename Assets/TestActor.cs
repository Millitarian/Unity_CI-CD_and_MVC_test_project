using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestActor : MonoBehaviour
{
  private TestOneLineStandartController testController;
  private TestField3x3Model testField3x3Model;
  void Start()
  {
    testController = new TestOneLineStandartController();
    testField3x3Model = new TestField3x3Model();

    var result = testController.test();
    Debug.Log(result);
    var result1 = testController.test1();
    Debug.Log(result1);
    var result2 = testController.test2();
    Debug.Log(result2);
    var result3 = testController.test3();
    Debug.Log(result3);

    var result4 = testField3x3Model.test();
    Debug.Log(result4);
    var result5 = testField3x3Model.test2();
    Debug.Log(result5);
  }
}
