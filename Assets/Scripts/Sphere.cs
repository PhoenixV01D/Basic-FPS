using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, Damage
{
  public int rotation = 5;
  public void ObjectHit()
    {
      transform.Rotate(Vector3.up,rotation);
    }
}