using System;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
  public float Damage = 5f;
  
  public Rigidbody2D Rigidbody;

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Player"))
    {
      other.GetComponent<HeroHealth>().TakeDamage(Damage);
      Destroy(gameObject);
    }
  }
}