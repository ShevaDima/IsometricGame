using UnityEngine;

public class EnemyDeath : MonoBehaviour
  {
    public EnemyHealth HeroHealth;

    private bool isDead;

    private void Start()
    {
      HeroHealth.Changed += HeroHealthChanged;
    }

    private void OnDestroy()
    {
      HeroHealth.Changed -= HeroHealthChanged;
    }

    private void HeroHealthChanged()
    {
      if (!isDead && HeroHealth.Current <= 0)
        Die();
    }

    private void Die()
    {
      isDead = true;
      Destroy(gameObject);
    }
  }