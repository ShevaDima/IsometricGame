using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class EnemyWeapon : MonoBehaviour
{
  public GameObject Target;
  public EnemyBullet BulletPrefab;

  public float AttackDistance;

  public float AttackCooldown;
  public float Force = 100f;

  private float attackCooldown;

  private void Update()
  {
    UpdateCooldown();

    if (NearPlayer() && CooldownIsUp())
      StartAttack(Target);
  }

  private void StartAttack(GameObject target)
  {
    EnemyBullet bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
    Vector3 direction = PickDirection(target);

    bullet.Rigidbody.AddForce(direction * Force);

    attackCooldown = AttackCooldown;
  }

  private Vector3 PickDirection(GameObject target)
  {
    Vector3 direction = target.transform.position - transform.position;
    direction.Normalize();

    return direction;
  }

  private bool CooldownIsUp()
  {
    return attackCooldown <= 0f;
  }

  private void UpdateCooldown()
  {
    if (!CooldownIsUp())
      attackCooldown -= Time.deltaTime;
  }

  private bool NearPlayer()
  {
    if (Target != null)
    {
      if (Vector3.Distance(transform.position, Target.transform.position) <= AttackDistance)
      {
        return true;
      }
    }
    
    return false;
  }
}