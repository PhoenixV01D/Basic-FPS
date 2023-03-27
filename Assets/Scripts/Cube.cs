using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, Damage
{

  public int health;

  public void ObjectHit()
  {
    health--;
    Debug.Log(health);

    if (health <= -5)
    {
      Destroy(gameObject);
    }
  }
}
