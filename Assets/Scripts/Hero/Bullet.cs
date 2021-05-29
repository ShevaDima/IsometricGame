using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  public PlayerData PlayerData;
  
    private Rigidbody2D rb;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       rb.AddForce(transform.right * 10f, ForceMode2D.Impulse); 
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Enemy"))
      {
        other.GetComponent<EnemyHealth>().TakeDamage(PlayerData.WeaponPower);
        
        Destroy(gameObject);
      }
    }
}
