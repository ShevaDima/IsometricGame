using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDeath : MonoBehaviour
{
    public HeroHealth HeroHealth;

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
