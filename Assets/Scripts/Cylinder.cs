using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour, Damage
{
  public int points;

  public void ObjectHit()
  {
    points++;
    Debug.Log(points);

    if (points >= 5)
    {
      Destroy(gameObject);
      Debug.Log("You destroyed the evil Cylinder!");
    }
  }
}
