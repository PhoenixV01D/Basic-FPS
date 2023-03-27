using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour, Damage
{
  public void ObjectHit()
  {
    Destroy(gameObject);
  }
}
