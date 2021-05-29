using System;
using UnityEngine;

  public class EnemyHealth : MonoBehaviour
  {
    public float Max;
    public float Current;

    public event Action Changed;

    public void TakeDamage(float damage)
    {
      if(Current <= 0)
        return;

      Current -= damage;
        
      Changed?.Invoke();
    }
  }