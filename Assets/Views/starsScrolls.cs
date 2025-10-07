using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsScrol : MonoBehaviour
{
  [SerializeField] private float maxX = 2.7f;
  [SerializeField] private float speed = 1f;
  private float curentPositionX;
  [SerializeField] private float startPositionX = -5;

  private void Start()
  {
    curentPositionX = transform.position.x;
  }

  void LateUpdate()
  {
    curentPositionX += speed * Time.deltaTime;
    transform.position = new Vector3(curentPositionX, transform.position.y, transform.position.z);
    if (curentPositionX > maxX) 
    {
      this.gameObject.transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
      curentPositionX = startPositionX;
    }
  }
}
